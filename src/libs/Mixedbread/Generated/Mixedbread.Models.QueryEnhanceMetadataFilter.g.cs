
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Metadata filter condition.
    /// </summary>
    public sealed partial class QueryEnhanceMetadataFilter
    {
        /// <summary>
        /// Metadata field key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Comparison operator
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mixedbread.JsonConverters.ConditionOperatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mixedbread.ConditionOperator Operator { get; set; }

        /// <summary>
        /// Value to compare against. Use a list for `in`/`not_in`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<string, int?, double?, bool?>>, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mixedbread.AnyOf<string, int?, double?, bool?, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<string, int?, double?, bool?>>, object> Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryEnhanceMetadataFilter" /> class.
        /// </summary>
        /// <param name="key">
        /// Metadata field key
        /// </param>
        /// <param name="operator">
        /// Comparison operator
        /// </param>
        /// <param name="value">
        /// Value to compare against. Use a list for `in`/`not_in`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryEnhanceMetadataFilter(
            string key,
            global::Mixedbread.ConditionOperator @operator,
            global::Mixedbread.AnyOf<string, int?, double?, bool?, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<string, int?, double?, bool?>>, object> value)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Operator = @operator;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryEnhanceMetadataFilter" /> class.
        /// </summary>
        public QueryEnhanceMetadataFilter()
        {
        }

    }
}