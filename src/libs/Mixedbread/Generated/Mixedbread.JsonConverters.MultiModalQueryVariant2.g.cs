#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mixedbread.JsonConverters
{
    /// <inheritdoc />
    public class MultiModalQueryVariant2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mixedbread.MultiModalQueryVariant2>
    {
        /// <inheritdoc />
        public override global::Mixedbread.MultiModalQueryVariant2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Mixedbread.MultiModalQueryVariant2Discriminator>(ref readerCopy, options);

            global::Mixedbread.ImageUrlInput2? imageUrl = default;
            if (discriminator?.Type == global::Mixedbread.MultiModalQueryVariant2DiscriminatorType.ImageUrl)
            {
                imageUrl = global::System.Text.Json.JsonSerializer.Deserialize<global::Mixedbread.ImageUrlInput2>(ref reader, options);
            }
            global::Mixedbread.TextInput? text = default;
            if (discriminator?.Type == global::Mixedbread.MultiModalQueryVariant2DiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::Mixedbread.TextInput>(ref reader, options);
            }

            var __value = new global::Mixedbread.MultiModalQueryVariant2(
                discriminator?.Type,
                imageUrl,

                text
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mixedbread.MultiModalQueryVariant2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsImageUrl)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageUrl, typeof(global::Mixedbread.ImageUrlInput2), options);
            }
            else if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::Mixedbread.TextInput), options);
            }
        }
    }
}