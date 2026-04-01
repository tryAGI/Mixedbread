#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mixedbread.JsonConverters
{
    /// <inheritdoc />
    public class SourcesItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mixedbread.SourcesItem>
    {
        /// <inheritdoc />
        public override global::Mixedbread.SourcesItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.StoreQAResultsSourceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.StoreQAResultsSourceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mixedbread.StoreQAResultsSourceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunk? text = default;
            if (discriminator?.Type == global::Mixedbread.StoreQAResultsSourceDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunk> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunk)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunk? imageUrl = default;
            if (discriminator?.Type == global::Mixedbread.StoreQAResultsSourceDiscriminatorType.ImageUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunk> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunk)}");
                imageUrl = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunk? audioUrl = default;
            if (discriminator?.Type == global::Mixedbread.StoreQAResultsSourceDiscriminatorType.AudioUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunk> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunk)}");
                audioUrl = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunk? videoUrl = default;
            if (discriminator?.Type == global::Mixedbread.StoreQAResultsSourceDiscriminatorType.VideoUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunk> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunk)}");
                videoUrl = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Mixedbread.SourcesItem(
                discriminator?.Type,
                text,

                imageUrl,

                audioUrl,

                videoUrl
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mixedbread.SourcesItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunk?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunk).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text!, typeInfo);
            }
            else if (value.IsImageUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunk?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunk).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageUrl!, typeInfo);
            }
            else if (value.IsAudioUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunk?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunk).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AudioUrl!, typeInfo);
            }
            else if (value.IsVideoUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunk?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunk).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VideoUrl!, typeInfo);
            }
        }
    }
}