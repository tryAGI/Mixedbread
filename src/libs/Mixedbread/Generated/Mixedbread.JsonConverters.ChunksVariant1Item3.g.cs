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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Mixedbread.StoreFileChunksVariant1ItemDiscriminator>(ref readerCopy, options);

            global::Mixedbread.TextInputChunk? text = default;
            if (discriminator?.Type == global::Mixedbread.StoreFileChunksVariant1ItemDiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::Mixedbread.TextInputChunk>(ref reader, options);
            }
            global::Mixedbread.ImageUrlInputChunk? imageUrl = default;
            if (discriminator?.Type == global::Mixedbread.StoreFileChunksVariant1ItemDiscriminatorType.ImageUrl)
            {
                imageUrl = global::System.Text.Json.JsonSerializer.Deserialize<global::Mixedbread.ImageUrlInputChunk>(ref reader, options);
            }
            global::Mixedbread.AudioUrlInputChunk? audioUrl = default;
            if (discriminator?.Type == global::Mixedbread.StoreFileChunksVariant1ItemDiscriminatorType.AudioUrl)
            {
                audioUrl = global::System.Text.Json.JsonSerializer.Deserialize<global::Mixedbread.AudioUrlInputChunk>(ref reader, options);
            }
            global::Mixedbread.VideoUrlInputChunk? videoUrl = default;
            if (discriminator?.Type == global::Mixedbread.StoreFileChunksVariant1ItemDiscriminatorType.VideoUrl)
            {
                videoUrl = global::System.Text.Json.JsonSerializer.Deserialize<global::Mixedbread.VideoUrlInputChunk>(ref reader, options);
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

            if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::Mixedbread.TextInputChunk), options);
            }
            else if (value.IsImageUrl)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageUrl, typeof(global::Mixedbread.ImageUrlInputChunk), options);
            }
            else if (value.IsAudioUrl)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AudioUrl, typeof(global::Mixedbread.AudioUrlInputChunk), options);
            }
            else if (value.IsVideoUrl)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VideoUrl, typeof(global::Mixedbread.VideoUrlInputChunk), options);
            }
        }
    }
}