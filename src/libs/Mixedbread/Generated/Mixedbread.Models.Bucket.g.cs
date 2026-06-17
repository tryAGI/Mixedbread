
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Service-level representation of a bucket. Credentials are never returned.
    /// </summary>
    public sealed partial class Bucket
    {
        /// <summary>
        /// The ID of the bucket
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Creation time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Last update time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Display name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Object storage provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mixedbread.JsonConverters.BucketProviderJsonConverter))]
        public global::Mixedbread.BucketProvider Provider { get; set; }

        /// <summary>
        /// The bucket name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucket")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Bucket1 { get; set; }

        /// <summary>
        /// The bucket region
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// Custom S3-compatible endpoint
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint_url")]
        public string? EndpointUrl { get; set; }

        /// <summary>
        /// Key prefix within the bucket
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prefix { get; set; }

        /// <summary>
        /// KMS key id/ARN used to encrypt writes (SSE-KMS)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sse_kms_key_id")]
        public string? SseKmsKeyId { get; set; }

        /// <summary>
        /// Authentication type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mixedbread.JsonConverters.BucketAuthTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mixedbread.BucketAuthType AuthType { get; set; }

        /// <summary>
        /// IAM role Mixedbread assumes (auth_type=assume_role); not a secret
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_arn")]
        public string? RoleArn { get; set; }

        /// <summary>
        /// sts:ExternalId the role's trust policy must require (auth_type=assume_role); not a secret
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_id")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// Validation status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mixedbread.JsonConverters.BucketStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mixedbread.BucketStatus Status { get; set; }

        /// <summary>
        /// When the bucket was last validated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_validated_at")]
        public global::System.DateTime? LastValidatedAt { get; set; }

        /// <summary>
        /// Whether secret credentials are stored (always false for assume-role buckets)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_credentials")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasCredentials { get; set; }

        /// <summary>
        /// Increments on every credential rotation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentials_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CredentialsVersion { get; set; }

        /// <summary>
        /// The type of the object<br/>
        /// Default Value: bucket
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Bucket" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the bucket
        /// </param>
        /// <param name="createdAt">
        /// Creation time
        /// </param>
        /// <param name="updatedAt">
        /// Last update time
        /// </param>
        /// <param name="name">
        /// Display name
        /// </param>
        /// <param name="bucket1">
        /// The bucket name
        /// </param>
        /// <param name="prefix">
        /// Key prefix within the bucket
        /// </param>
        /// <param name="authType">
        /// Authentication type
        /// </param>
        /// <param name="status">
        /// Validation status
        /// </param>
        /// <param name="hasCredentials">
        /// Whether secret credentials are stored (always false for assume-role buckets)
        /// </param>
        /// <param name="credentialsVersion">
        /// Increments on every credential rotation
        /// </param>
        /// <param name="provider">
        /// Object storage provider
        /// </param>
        /// <param name="region">
        /// The bucket region
        /// </param>
        /// <param name="endpointUrl">
        /// Custom S3-compatible endpoint
        /// </param>
        /// <param name="sseKmsKeyId">
        /// KMS key id/ARN used to encrypt writes (SSE-KMS)
        /// </param>
        /// <param name="roleArn">
        /// IAM role Mixedbread assumes (auth_type=assume_role); not a secret
        /// </param>
        /// <param name="externalId">
        /// sts:ExternalId the role's trust policy must require (auth_type=assume_role); not a secret
        /// </param>
        /// <param name="lastValidatedAt">
        /// When the bucket was last validated
        /// </param>
        /// <param name="object">
        /// The type of the object<br/>
        /// Default Value: bucket
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Bucket(
            string id,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string name,
            string bucket1,
            string prefix,
            global::Mixedbread.BucketAuthType authType,
            global::Mixedbread.BucketStatus status,
            bool hasCredentials,
            int credentialsVersion,
            global::Mixedbread.BucketProvider provider,
            string? region,
            string? endpointUrl,
            string? sseKmsKeyId,
            string? roleArn,
            string? externalId,
            global::System.DateTime? lastValidatedAt,
            string? @object)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Provider = provider;
            this.Bucket1 = bucket1 ?? throw new global::System.ArgumentNullException(nameof(bucket1));
            this.Region = region;
            this.EndpointUrl = endpointUrl;
            this.Prefix = prefix ?? throw new global::System.ArgumentNullException(nameof(prefix));
            this.SseKmsKeyId = sseKmsKeyId;
            this.AuthType = authType;
            this.RoleArn = roleArn;
            this.ExternalId = externalId;
            this.Status = status;
            this.LastValidatedAt = lastValidatedAt;
            this.HasCredentials = hasCredentials;
            this.CredentialsVersion = credentialsVersion;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Bucket" /> class.
        /// </summary>
        public Bucket()
        {
        }

    }
}