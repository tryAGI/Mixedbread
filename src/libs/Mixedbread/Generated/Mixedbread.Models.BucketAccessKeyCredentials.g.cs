
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// AWS-style access key credentials for a customer bucket (write-only, never returned).
    /// </summary>
    public sealed partial class BucketAccessKeyCredentials
    {
        /// <summary>
        /// Default Value: access_key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Access key id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_key_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccessKeyId { get; set; }

        /// <summary>
        /// Secret access key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_access_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SecretAccessKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BucketAccessKeyCredentials" /> class.
        /// </summary>
        /// <param name="accessKeyId">
        /// Access key id
        /// </param>
        /// <param name="secretAccessKey">
        /// Secret access key
        /// </param>
        /// <param name="type">
        /// Default Value: access_key
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BucketAccessKeyCredentials(
            string accessKeyId,
            string secretAccessKey,
            string? type)
        {
            this.Type = type;
            this.AccessKeyId = accessKeyId ?? throw new global::System.ArgumentNullException(nameof(accessKeyId));
            this.SecretAccessKey = secretAccessKey ?? throw new global::System.ArgumentNullException(nameof(secretAccessKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BucketAccessKeyCredentials" /> class.
        /// </summary>
        public BucketAccessKeyCredentials()
        {
        }

    }
}