#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mixedbread.JsonConverters
{
    /// <inheritdoc />
    public class GeneratedMetadataVariant111JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mixedbread.GeneratedMetadataVariant111>
    {
        /// <inheritdoc />
        public override global::Mixedbread.GeneratedMetadataVariant111 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunkGeneratedMetadataVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunkGeneratedMetadataVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunkGeneratedMetadataVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Mixedbread.MarkdownChunkGeneratedMetadata? markdown = default;
            if (discriminator?.Type == global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorType.Markdown)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.MarkdownChunkGeneratedMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.MarkdownChunkGeneratedMetadata> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mixedbread.MarkdownChunkGeneratedMetadata)}");
                markdown = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mixedbread.TextChunkGeneratedMetadata? text = default;
            if (discriminator?.Type == global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.TextChunkGeneratedMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.TextChunkGeneratedMetadata> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mixedbread.TextChunkGeneratedMetadata)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mixedbread.PDFChunkGeneratedMetadata? pdf = default;
            if (discriminator?.Type == global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorType.Pdf)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.PDFChunkGeneratedMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.PDFChunkGeneratedMetadata> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mixedbread.PDFChunkGeneratedMetadata)}");
                pdf = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mixedbread.CodeChunkGeneratedMetadata? code = default;
            if (discriminator?.Type == global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorType.Code)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.CodeChunkGeneratedMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.CodeChunkGeneratedMetadata> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mixedbread.CodeChunkGeneratedMetadata)}");
                code = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mixedbread.AudioChunkGeneratedMetadata? audio = default;
            if (discriminator?.Type == global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorType.Audio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.AudioChunkGeneratedMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.AudioChunkGeneratedMetadata> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mixedbread.AudioChunkGeneratedMetadata)}");
                audio = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mixedbread.VideoChunkGeneratedMetadata? video = default;
            if (discriminator?.Type == global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorType.Video)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.VideoChunkGeneratedMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.VideoChunkGeneratedMetadata> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mixedbread.VideoChunkGeneratedMetadata)}");
                video = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mixedbread.ImageChunkGeneratedMetadata? image = default;
            if (discriminator?.Type == global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorType.Image)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.ImageChunkGeneratedMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.ImageChunkGeneratedMetadata> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mixedbread.ImageChunkGeneratedMetadata)}");
                image = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Mixedbread.GeneratedMetadataVariant111(
                discriminator?.Type,
                markdown,

                text,

                pdf,

                code,

                audio,

                video,

                image
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mixedbread.GeneratedMetadataVariant111 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMarkdown)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.MarkdownChunkGeneratedMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.MarkdownChunkGeneratedMetadata?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mixedbread.MarkdownChunkGeneratedMetadata).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Markdown!, typeInfo);
            }
            else if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.TextChunkGeneratedMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.TextChunkGeneratedMetadata?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mixedbread.TextChunkGeneratedMetadata).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text!, typeInfo);
            }
            else if (value.IsPdf)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.PDFChunkGeneratedMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.PDFChunkGeneratedMetadata?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mixedbread.PDFChunkGeneratedMetadata).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Pdf!, typeInfo);
            }
            else if (value.IsCode)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.CodeChunkGeneratedMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.CodeChunkGeneratedMetadata?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mixedbread.CodeChunkGeneratedMetadata).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Code!, typeInfo);
            }
            else if (value.IsAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.AudioChunkGeneratedMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.AudioChunkGeneratedMetadata?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mixedbread.AudioChunkGeneratedMetadata).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Audio!, typeInfo);
            }
            else if (value.IsVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.VideoChunkGeneratedMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.VideoChunkGeneratedMetadata?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mixedbread.VideoChunkGeneratedMetadata).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Video!, typeInfo);
            }
            else if (value.IsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.ImageChunkGeneratedMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.ImageChunkGeneratedMetadata?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mixedbread.ImageChunkGeneratedMetadata).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image!, typeInfo);
            }
        }
    }
}