
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Parameters for attaching a customer-owned bucket.
    /// </summary>
    public sealed partial class BucketCreateParams
    {
        /// <summary>
        /// Display name for the bucket
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Object storage provider<br/>
        /// Default Value: aws_s3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// The bucket name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucket")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Bucket { get; set; }

        /// <summary>
        /// The bucket region
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// Custom S3-compatible endpoint (omit for AWS)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint_url")]
        public string? EndpointUrl { get; set; }

        /// <summary>
        /// Key prefix within the bucket
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix")]
        public string? Prefix { get; set; }

        /// <summary>
        /// KMS key id/ARN to encrypt writes with (SSE-KMS); omit for the bucket's default encryption
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sse_kms_key_id")]
        public string? SseKmsKeyId { get; set; }

        /// <summary>
        /// How Mixedbread authenticates against the bucket. `assume_role` is the recommended default for AWS; `access_key` is for S3-compatible providers with a custom endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentials")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mixedbread.JsonConverters.CredentialsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mixedbread.Credentials Credentials { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BucketCreateParams" /> class.
        /// </summary>
        /// <param name="name">
        /// Display name for the bucket
        /// </param>
        /// <param name="bucket">
        /// The bucket name
        /// </param>
        /// <param name="credentials">
        /// How Mixedbread authenticates against the bucket. `assume_role` is the recommended default for AWS; `access_key` is for S3-compatible providers with a custom endpoint.
        /// </param>
        /// <param name="provider">
        /// Object storage provider<br/>
        /// Default Value: aws_s3
        /// </param>
        /// <param name="region">
        /// The bucket region
        /// </param>
        /// <param name="endpointUrl">
        /// Custom S3-compatible endpoint (omit for AWS)
        /// </param>
        /// <param name="prefix">
        /// Key prefix within the bucket
        /// </param>
        /// <param name="sseKmsKeyId">
        /// KMS key id/ARN to encrypt writes with (SSE-KMS); omit for the bucket's default encryption
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BucketCreateParams(
            string name,
            string bucket,
            global::Mixedbread.Credentials credentials,
            string? provider,
            string? region,
            string? endpointUrl,
            string? prefix,
            string? sseKmsKeyId)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Provider = provider;
            this.Bucket = bucket ?? throw new global::System.ArgumentNullException(nameof(bucket));
            this.Region = region;
            this.EndpointUrl = endpointUrl;
            this.Prefix = prefix;
            this.SseKmsKeyId = sseKmsKeyId;
            this.Credentials = credentials;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BucketCreateParams" /> class.
        /// </summary>
        public BucketCreateParams()
        {
        }

    }
}