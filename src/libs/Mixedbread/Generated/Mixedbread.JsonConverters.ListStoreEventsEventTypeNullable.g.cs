#nullable enable

namespace Mixedbread.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListStoreEventsEventTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mixedbread.ListStoreEventsEventType?>
    {
        /// <inheritdoc />
        public override global::Mixedbread.ListStoreEventsEventType? Read(
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
                        return global::Mixedbread.ListStoreEventsEventTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Mixedbread.ListStoreEventsEventType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Mixedbread.ListStoreEventsEventType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mixedbread.ListStoreEventsEventType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Mixedbread.ListStoreEventsEventTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
