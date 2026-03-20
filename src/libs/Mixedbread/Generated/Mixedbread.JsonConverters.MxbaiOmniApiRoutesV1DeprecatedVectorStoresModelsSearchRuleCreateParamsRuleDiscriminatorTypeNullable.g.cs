#nullable enable

namespace Mixedbread.JsonConverters
{
    /// <inheritdoc />
    public sealed class MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleCreateParamsRuleDiscriminatorTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleCreateParamsRuleDiscriminatorType?>
    {
        /// <inheritdoc />
        public override global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleCreateParamsRuleDiscriminatorType? Read(
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
                        return global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleCreateParamsRuleDiscriminatorTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleCreateParamsRuleDiscriminatorType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleCreateParamsRuleDiscriminatorType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleCreateParamsRuleDiscriminatorType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleCreateParamsRuleDiscriminatorTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
