
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Cross-account IAM role the platform assumes via STS (recommended for AWS).<br/>
    /// Nothing secret is stored: the role ARN and the server-generated external id<br/>
    /// are plain metadata, and access is granted/revoked entirely through the<br/>
    /// role's trust policy in the customer's account.
    /// </summary>
    public sealed partial class BucketAssumeRoleCredentials
    {
        /// <summary>
        /// Default Value: assume_role
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// ARN of the IAM role Mixedbread assumes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_arn")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RoleArn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BucketAssumeRoleCredentials" /> class.
        /// </summary>
        /// <param name="roleArn">
        /// ARN of the IAM role Mixedbread assumes
        /// </param>
        /// <param name="type">
        /// Default Value: assume_role
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BucketAssumeRoleCredentials(
            string roleArn,
            string? type)
        {
            this.Type = type;
            this.RoleArn = roleArn ?? throw new global::System.ArgumentNullException(nameof(roleArn));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BucketAssumeRoleCredentials" /> class.
        /// </summary>
        public BucketAssumeRoleCredentials()
        {
        }

    }
}