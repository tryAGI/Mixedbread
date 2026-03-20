/*
order: 20
title: Embedding Generator Generate Async
slug: embedding-generator-generate-async
*/

using Meai = Microsoft.Extensions.AI;

namespace Mixedbread.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task EmbeddingGenerator_GenerateAsync()
    {
        using var client = GetAuthenticatedClient();
        Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator = client;

        //// Generate embeddings using the MEAI IEmbeddingGenerator interface.
        var embeddings = await generator.GenerateAsync(
            ["Hello, world!"],
            new Meai.EmbeddingGenerationOptions
            {
                ModelId = "mixedbread-ai/mxbai-embed-large-v1",
            });

        embeddings.Should().HaveCount(1);
        embeddings[0].Vector.Length.Should().BeGreaterThan(0);
        embeddings.Usage.Should().NotBeNull();
        embeddings.Usage!.TotalTokenCount.Should().BeGreaterThan(0);
    }
}
