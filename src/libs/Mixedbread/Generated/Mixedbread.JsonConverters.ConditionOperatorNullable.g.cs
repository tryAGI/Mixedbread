#nullable enable

namespace Mixedbread.JsonConverters
{
    /// <inheritdoc />
    public sealed class ConditionOperatorNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mixedbread.ConditionOperator?>
    {
        /// <inheritdoc />
        public override global::Mixedbread.ConditionOperator? Read(
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
                        return global::Mixedbread.ConditionOperatorExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Mixedbread.ConditionOperator)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Mixedbread.ConditionOperator?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mixedbread.ConditionOperator? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Mixedbread.ConditionOperatorExtensions.ToValueString(value.Value));
            }
        }
    }
}
