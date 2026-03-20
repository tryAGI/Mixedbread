
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorTypeJsonConverter))]
        public global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminator(
            global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminator" /> class.
        /// </summary>
        public MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminator()
        {
        }
    }
}