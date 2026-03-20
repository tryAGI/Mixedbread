
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleCreateParamsRuleDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleCreateParamsRuleDiscriminatorTypeJsonConverter))]
        public global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleCreateParamsRuleDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleCreateParamsRuleDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleCreateParamsRuleDiscriminator(
            global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleCreateParamsRuleDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleCreateParamsRuleDiscriminator" /> class.
        /// </summary>
        public MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleCreateParamsRuleDiscriminator()
        {
        }
    }
}