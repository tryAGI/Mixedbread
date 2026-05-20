
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Enhanced query response.
    /// </summary>
    public sealed partial class QueryEnhanceResults
    {
        /// <summary>
        /// Enhanced query item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Mixedbread.ItemsItem> Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryEnhanceResults" /> class.
        /// </summary>
        /// <param name="items">
        /// Enhanced query item
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryEnhanceResults(
            global::System.Collections.Generic.IList<global::Mixedbread.ItemsItem> items)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryEnhanceResults" /> class.
        /// </summary>
        public QueryEnhanceResults()
        {
        }

    }
}