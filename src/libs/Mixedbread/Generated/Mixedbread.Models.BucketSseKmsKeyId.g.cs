
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// KMS key id/ARN used to encrypt writes (SSE-KMS)
    /// </summary>
    public sealed partial class BucketSseKmsKeyId
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}