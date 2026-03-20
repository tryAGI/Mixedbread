#nullable enable

namespace Mixedbread.JsonConverters
{
    /// <inheritdoc />
    public sealed class StoreFileParsingStrategyJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mixedbread.StoreFileParsingStrategy>
    {
        /// <inheritdoc />
        public override global::Mixedbread.StoreFileParsingStrategy Read(
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
                        return global::Mixedbread.StoreFileParsingStrategyExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Mixedbread.StoreFileParsingStrategy)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Mixedbread.StoreFileParsingStrategy);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mixedbread.StoreFileParsingStrategy value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Mixedbread.StoreFileParsingStrategyExtensions.ToValueString(value));
        }
    }
}
