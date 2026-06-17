
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Customer bucket backing this store's storage; null = platform default
    /// </summary>
    public sealed partial class StoreBucketId
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}