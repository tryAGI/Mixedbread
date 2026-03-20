# CLAUDE.md — Mixedbread SDK

## Overview

Auto-generated C# SDK for [Mixedbread](https://mixedbread.ai/) — embeddings, reranking, vector stores, document parsing, search, Q&A, and billing.

## Build & Test

```bash
dotnet build Mixedbread.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Bearer token auth with Mixedbread API key:

```csharp
var client = new MixedbreadClient(apiKey); // MIXEDBREAD_API_KEY env var
```

## Key Files

- `src/libs/Mixedbread/generate.sh` — Regeneration script (downloads Stainless-hosted spec, runs autosdk)
- `src/libs/Mixedbread/Generated/` — **Never edit** — auto-generated code
- `src/libs/Mixedbread/Extensions/MixedbreadClient.EmbeddingGenerator.cs` — MEAI `IEmbeddingGenerator` implementation
- `src/tests/IntegrationTests/Tests.cs` — Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` — Example tests (also generate docs)

## MEAI Integration

- **Interface:** `IEmbeddingGenerator<string, Embedding<float>>`
- **Namespace conflict:** Yes — uses `using Meai = Microsoft.Extensions.AI;` alias
- **Direct client method:** `MixedbreadClient.CreateEmbeddingsAsync()` (no sub-client)
- **EmbeddingItem union:** `Value1` (double[]), `Value2` (int[]), `Value3` (string) — always requests `EncodingFormat3.Float`
- **Features:** Custom dimensions, token usage tracking

## NuGet

- **PackageId:** `Mixedbread` (we own the name)
