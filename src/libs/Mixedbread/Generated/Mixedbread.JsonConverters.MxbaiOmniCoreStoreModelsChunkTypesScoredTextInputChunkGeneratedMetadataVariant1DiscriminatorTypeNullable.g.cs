#nullable enable

namespace Mixedbread.JsonConverters
{
    /// <inheritdoc />
    public sealed class MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorType?>
    {
        /// <inheritdoc />
        public override global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorType? Read(
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
                        return global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
