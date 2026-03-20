#nullable enable

using Meai = Microsoft.Extensions.AI;

namespace Mixedbread;

public partial class MixedbreadClient : Meai.IEmbeddingGenerator<string, Meai.Embedding<float>>
{
    private Meai.EmbeddingGeneratorMetadata? _embeddingMetadata;

    /// <inheritdoc />
    object? Meai.IEmbeddingGenerator.GetService(Type serviceType, object? serviceKey)
    {
        ArgumentNullException.ThrowIfNull(serviceType);

        return
            serviceKey is not null ? null :
            serviceType == typeof(Meai.EmbeddingGeneratorMetadata)
                ? (_embeddingMetadata ??= new(nameof(MixedbreadClient), BaseUri))
                : serviceType.IsInstanceOfType(this) ? this
                : null;
    }

    /// <inheritdoc />
    async Task<Meai.GeneratedEmbeddings<Meai.Embedding<float>>>
        Meai.IEmbeddingGenerator<string, Meai.Embedding<float>>.GenerateAsync(
            IEnumerable<string> values,
            Meai.EmbeddingGenerationOptions? options,
            CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(values);

        var textList = values.ToList();

        var request = new EmbeddingCreateParams
        {
            Model = options?.ModelId ?? "mixedbread-embed-large-v1",
            Input = textList.Count == 1
                ? new AnyOf<string, IList<string>>(textList[0])
                : new AnyOf<string, IList<string>>((IList<string>)textList),
            EncodingFormat = new AnyOf<EncodingFormat3?, IList<EncodingFormat3>>(EncodingFormat3.Float),
        };

        if (options?.Dimensions is { } dimensions)
        {
            request.Dimensions = dimensions;
        }

        var response = await CreateEmbeddingsAsync(request, cancellationToken).ConfigureAwait(false);

        var embeddings = new Meai.GeneratedEmbeddings<Meai.Embedding<float>>();

        if (response.Data.IsValue1 && response.Data.Value1 is { } data)
        {
            foreach (var item in data)
            {
                if (item.Embedding1.IsValue1 && item.Embedding1.Value1 is { } doubleList)
                {
                    var floatArray = new float[doubleList.Count];
                    for (var i = 0; i < doubleList.Count; i++)
                    {
                        floatArray[i] = (float)doubleList[i];
                    }

                    embeddings.Add(new Meai.Embedding<float>(floatArray)
                    {
                        ModelId = response.Model,
                    });
                }
            }
        }

        if (response.Usage is { } usage)
        {
            embeddings.Usage = new Meai.UsageDetails
            {
                InputTokenCount = usage.PromptTokens,
                TotalTokenCount = usage.TotalTokens,
            };
        }

        return embeddings;
    }
}
