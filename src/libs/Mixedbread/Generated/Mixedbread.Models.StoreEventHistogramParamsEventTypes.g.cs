
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Restrict the histogram to these event types. When omitted, includes search, agentic_search, and ingestion events.
    /// </summary>
    public sealed partial class StoreEventHistogramParamsEventTypes
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}