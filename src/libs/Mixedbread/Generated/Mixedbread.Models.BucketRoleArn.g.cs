
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// IAM role Mixedbread assumes (auth_type=assume_role); not a secret
    /// </summary>
    public sealed partial class BucketRoleArn
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}