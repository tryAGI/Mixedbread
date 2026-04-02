#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mixedbread.JsonConverters
{
    /// <inheritdoc />
    public class GeneratedMetadataVariant110JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mixedbread.GeneratedMetadataVariant110>
    {
        /// <inheritdoc />
        public override global::Mixedbread.GeneratedMetadataVariant110 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunkGeneratedMetadataVariant1Discriminator>(ref readerCopy, options);

            global::Mixedbread.MarkdownChunkGeneratedMetadata? markdown = default;
            if (discriminator?.Type == global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Markdown)
            {
                markdown = global::System.Text.Json.JsonSerializer.Deserialize<global::Mixedbread.MarkdownChunkGeneratedMetadata>(ref reader, options);
            }
            global::Mixedbread.TextChunkGeneratedMetadata? text = default;
            if (discriminator?.Type == global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::Mixedbread.TextChunkGeneratedMetadata>(ref reader, options);
            }
            global::Mixedbread.PDFChunkGeneratedMetadata? pdf = default;
            if (discriminator?.Type == global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Pdf)
            {
                pdf = global::System.Text.Json.JsonSerializer.Deserialize<global::Mixedbread.PDFChunkGeneratedMetadata>(ref reader, options);
            }
            global::Mixedbread.CodeChunkGeneratedMetadata? code = default;
            if (discriminator?.Type == global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Code)
            {
                code = global::System.Text.Json.JsonSerializer.Deserialize<global::Mixedbread.CodeChunkGeneratedMetadata>(ref reader, options);
            }
            global::Mixedbread.AudioChunkGeneratedMetadata? audio = default;
            if (discriminator?.Type == global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Audio)
            {
                audio = global::System.Text.Json.JsonSerializer.Deserialize<global::Mixedbread.AudioChunkGeneratedMetadata>(ref reader, options);
            }
            global::Mixedbread.VideoChunkGeneratedMetadata? video = default;
            if (discriminator?.Type == global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Video)
            {
                video = global::System.Text.Json.JsonSerializer.Deserialize<global::Mixedbread.VideoChunkGeneratedMetadata>(ref reader, options);
            }
            global::Mixedbread.ImageChunkGeneratedMetadata? image = default;
            if (discriminator?.Type == global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Image)
            {
                image = global::System.Text.Json.JsonSerializer.Deserialize<global::Mixedbread.ImageChunkGeneratedMetadata>(ref reader, options);
            }

            var __value = new global::Mixedbread.GeneratedMetadataVariant110(
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
            global::Mixedbread.GeneratedMetadataVariant110 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsMarkdown)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Markdown, typeof(global::Mixedbread.MarkdownChunkGeneratedMetadata), options);
            }
            else if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::Mixedbread.TextChunkGeneratedMetadata), options);
            }
            else if (value.IsPdf)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Pdf, typeof(global::Mixedbread.PDFChunkGeneratedMetadata), options);
            }
            else if (value.IsCode)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Code, typeof(global::Mixedbread.CodeChunkGeneratedMetadata), options);
            }
            else if (value.IsAudio)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Audio, typeof(global::Mixedbread.AudioChunkGeneratedMetadata), options);
            }
            else if (value.IsVideo)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Video, typeof(global::Mixedbread.VideoChunkGeneratedMetadata), options);
            }
            else if (value.IsImage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image, typeof(global::Mixedbread.ImageChunkGeneratedMetadata), options);
            }
        }
    }
}