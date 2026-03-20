/*
order: 30
title: Embedding Generator Custom Dimensions
slug: embedding-generator-custom-dimensions
*/

using Meai = Microsoft.Extensions.AI;

namespace Mixedbread.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task EmbeddingGenerator_CustomDimensions()
    {
        using var client = GetAuthenticatedClient();
        Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator = client;

        //// Generate embeddings with custom output dimensions.
        var embeddings = await generator.GenerateAsync(
            ["Compact embedding for efficient storage."],
            new Meai.EmbeddingGenerationOptions
            {
                ModelId = "mxbai-embed-2d-large-v1",
                Dimensions = 256,
            });

        embeddings.Should().HaveCount(1);
        embeddings[0].Vector.Length.Should().Be(256);
    }
}
