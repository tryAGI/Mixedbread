# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Mixedbread SDK implements `IEmbeddingGenerator<string, Embedding<float>>` from [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai), providing a unified interface for generating text embeddings.

## Installation

```bash
dotnet add package Mixedbread
```

## Generate Embeddings

`MixedbreadClient` directly implements `IEmbeddingGenerator<string, Embedding<float>>`, so you can use it with the standard MEAI interface.

```csharp
using Mixedbread;
using Meai = Microsoft.Extensions.AI;

Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator =
    new MixedbreadClient(apiKey: Environment.GetEnvironmentVariable("MIXEDBREAD_API_KEY")!);

var embeddings = await generator.GenerateAsync(
    ["Hello, world!"],
    new Meai.EmbeddingGenerationOptions { ModelId = "mixedbread-ai/mxbai-embed-large-v1" });

Console.WriteLine($"Dimensions: {embeddings[0].Vector.Length}");
Console.WriteLine($"Model: {embeddings[0].ModelId}");
```

## Batch Embeddings

```csharp
using Mixedbread;
using Meai = Microsoft.Extensions.AI;

Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator =
    new MixedbreadClient(apiKey: Environment.GetEnvironmentVariable("MIXEDBREAD_API_KEY")!);

var texts = new[]
{
    "The quick brown fox jumps over the lazy dog.",
    "Machine learning is a subset of artificial intelligence.",
    "Embeddings represent text as numerical vectors.",
};

var embeddings = await generator.GenerateAsync(
    texts,
    new Meai.EmbeddingGenerationOptions { ModelId = "mixedbread-ai/mxbai-embed-large-v1" });

Console.WriteLine($"Generated {embeddings.Count} embeddings");
Console.WriteLine($"Total tokens: {embeddings.Usage?.TotalTokenCount}");
```

## Custom Dimensions

Mixedbread models support custom output dimensions via Matryoshka representation learning:

```csharp
using Mixedbread;
using Meai = Microsoft.Extensions.AI;

Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator =
    new MixedbreadClient(apiKey: Environment.GetEnvironmentVariable("MIXEDBREAD_API_KEY")!);

var options = new Meai.EmbeddingGenerationOptions
{
    ModelId = "mxbai-embed-2d-large-v1",
    Dimensions = 256,
};

var embeddings = await generator.GenerateAsync(
    ["Compact embedding for efficient storage."], options);

Console.WriteLine($"Dimensions: {embeddings[0].Vector.Length}"); // 256
```

## Dependency Injection

```csharp
using Mixedbread;
using Meai = Microsoft.Extensions.AI;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<Meai.IEmbeddingGenerator<string, Meai.Embedding<float>>>(
    new MixedbreadClient(apiKey: builder.Configuration["Mixedbread:ApiKey"]!));
```

## Provider Metadata

```csharp
var metadata = Meai.EmbeddingGeneratorExtensions.GetService<Meai.EmbeddingGeneratorMetadata>(generator);
Console.WriteLine($"Provider: {metadata?.ProviderName}"); // "MixedbreadClient"
Console.WriteLine($"Endpoint: {metadata?.ProviderUri}");
```
