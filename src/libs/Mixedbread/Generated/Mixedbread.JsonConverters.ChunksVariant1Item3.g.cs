#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mixedbread.JsonConverters
{
    /// <inheritdoc />
    public class ChunksVariant1Item3JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mixedbread.ChunksVariant1Item3>
    {
        /// <inheritdoc />
        public override global::Mixedbread.ChunksVariant1Item3 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.StoreFileChunksVariant1ItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.StoreFileChunksVariant1ItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mixedbread.StoreFileChunksVariant1ItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Mixedbread.TextInputChunk? text = default;
            if (discriminator?.Type == global::Mixedbread.StoreFileChunksVariant1ItemDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.TextInputChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.TextInputChunk> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mixedbread.TextInputChunk)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mixedbread.ImageUrlInputChunk? imageUrl = default;
            if (discriminator?.Type == global::Mixedbread.StoreFileChunksVariant1ItemDiscriminatorType.ImageUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.ImageUrlInputChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.ImageUrlInputChunk> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mixedbread.ImageUrlInputChunk)}");
                imageUrl = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mixedbread.AudioUrlInputChunk? audioUrl = default;
            if (discriminator?.Type == global::Mixedbread.StoreFileChunksVariant1ItemDiscriminatorType.AudioUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.AudioUrlInputChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.AudioUrlInputChunk> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mixedbread.AudioUrlInputChunk)}");
                audioUrl = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mixedbread.VideoUrlInputChunk? videoUrl = default;
            if (discriminator?.Type == global::Mixedbread.StoreFileChunksVariant1ItemDiscriminatorType.VideoUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.VideoUrlInputChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.VideoUrlInputChunk> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mixedbread.VideoUrlInputChunk)}");
                videoUrl = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Mixedbread.ChunksVariant1Item3(
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
            global::Mixedbread.ChunksVariant1Item3 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.TextInputChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.TextInputChunk?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mixedbread.TextInputChunk).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeInfo);
            }
            else if (value.IsImageUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.ImageUrlInputChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.ImageUrlInputChunk?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mixedbread.ImageUrlInputChunk).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageUrl, typeInfo);
            }
            else if (value.IsAudioUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.AudioUrlInputChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.AudioUrlInputChunk?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mixedbread.AudioUrlInputChunk).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AudioUrl, typeInfo);
            }
            else if (value.IsVideoUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.VideoUrlInputChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.VideoUrlInputChunk?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mixedbread.VideoUrlInputChunk).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VideoUrl, typeInfo);
            }
        }
    }
}