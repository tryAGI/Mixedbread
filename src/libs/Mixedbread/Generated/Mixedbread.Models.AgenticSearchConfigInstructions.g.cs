
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Additional custom instructions (followed only when not in conflict with existing rules)
    /// </summary>
    public sealed partial class AgenticSearchConfigInstructions
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}