#nullable enable

namespace Mixedbread.JsonConverters
{
    /// <inheritdoc />
    public sealed class StoreSearchEventResultFirstStageSourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mixedbread.StoreSearchEventResultFirstStageSource>
    {
        /// <inheritdoc />
        public override global::Mixedbread.StoreSearchEventResultFirstStageSource Read(
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
                        return global::Mixedbread.StoreSearchEventResultFirstStageSourceExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Mixedbread.StoreSearchEventResultFirstStageSource)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Mixedbread.StoreSearchEventResultFirstStageSource);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mixedbread.StoreSearchEventResultFirstStageSource value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Mixedbread.StoreSearchEventResultFirstStageSourceExtensions.ToValueString(value));
        }
    }
}
