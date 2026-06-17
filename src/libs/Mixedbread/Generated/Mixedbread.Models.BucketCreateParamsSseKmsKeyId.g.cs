
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// KMS key id/ARN to encrypt writes with (SSE-KMS); omit for the bucket's default encryption
    /// </summary>
    public sealed partial class BucketCreateParamsSseKmsKeyId
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}