#nullable enable

namespace Mixedbread.JsonConverters
{
    /// <inheritdoc />
    public sealed class VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mixedbread.VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType?>
    {
        /// <inheritdoc />
        public override global::Mixedbread.VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Mixedbread.VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Mixedbread.VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Mixedbread.VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mixedbread.VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Mixedbread.VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
