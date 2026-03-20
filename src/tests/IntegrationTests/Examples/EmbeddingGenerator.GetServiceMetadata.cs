/*
order: 40
title: Embedding Generator Get Service Metadata
slug: embedding-generator-get-service-metadata
*/

using Meai = Microsoft.Extensions.AI;

namespace Mixedbread.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void EmbeddingGenerator_GetService_Metadata()
    {
        using var client = new MixedbreadClient("test-api-key");
        Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator = client;

        //// Retrieve metadata about the embedding provider.
        var metadata = Meai.EmbeddingGeneratorExtensions.GetService<Meai.EmbeddingGeneratorMetadata>(generator);

        metadata.Should().NotBeNull();
        metadata!.ProviderName.Should().Be(nameof(MixedbreadClient));
    }
}
