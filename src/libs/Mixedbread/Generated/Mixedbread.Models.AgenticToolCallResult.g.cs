
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Result returned to the model (gen_ai.tool.call.result). None if the tool errored.
    /// </summary>
    public sealed partial class AgenticToolCallResult
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}