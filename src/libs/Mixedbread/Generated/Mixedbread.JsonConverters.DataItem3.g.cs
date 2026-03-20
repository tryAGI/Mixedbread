#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mixedbread.JsonConverters
{
    /// <inheritdoc />
    public class DataItem3JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mixedbread.DataItem3>
    {
        /// <inheritdoc />
        public override global::Mixedbread.DataItem3 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.VectorStoreSearchResponseDataItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.VectorStoreSearchResponseDataItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mixedbread.VectorStoreSearchResponseDataItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunk? text = default;
            if (discriminator?.Type == global::Mixedbread.VectorStoreSearchResponseDataItemDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunk> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunk)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunk? imageUrl = default;
            if (discriminator?.Type == global::Mixedbread.VectorStoreSearchResponseDataItemDiscriminatorType.ImageUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunk> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunk)}");
                imageUrl = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunk? audioUrl = default;
            if (discriminator?.Type == global::Mixedbread.VectorStoreSearchResponseDataItemDiscriminatorType.AudioUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunk> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunk)}");
                audioUrl = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunk? videoUrl = default;
            if (discriminator?.Type == global::Mixedbread.VectorStoreSearchResponseDataItemDiscriminatorType.VideoUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunk> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunk)}");
                videoUrl = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Mixedbread.DataItem3(
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
            global::Mixedbread.DataItem3 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunk?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunk).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeInfo);
            }
            else if (value.IsImageUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunk?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunk).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageUrl, typeInfo);
            }
            else if (value.IsAudioUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunk?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunk).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AudioUrl, typeInfo);
            }
            else if (value.IsVideoUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunk?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunk).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VideoUrl, typeInfo);
            }
        }
    }
}