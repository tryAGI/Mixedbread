#nullable enable

namespace Mixedbread.JsonConverters
{
    /// <inheritdoc />
    public sealed class IntegrationProviderManifestIngestionBacking2NullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mixedbread.IntegrationProviderManifestIngestionBacking2?>
    {
        /// <inheritdoc />
        public override global::Mixedbread.IntegrationProviderManifestIngestionBacking2? Read(
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
                        return global::Mixedbread.IntegrationProviderManifestIngestionBacking2Extensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Mixedbread.IntegrationProviderManifestIngestionBacking2)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Mixedbread.IntegrationProviderManifestIngestionBacking2?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mixedbread.IntegrationProviderManifestIngestionBacking2? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Mixedbread.IntegrationProviderManifestIngestionBacking2Extensions.ToValueString(value.Value));
            }
        }
    }
}
