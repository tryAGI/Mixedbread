
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Service-level representation of an installed provider integration.
    /// </summary>
    public sealed partial class IntegrationInstallation
    {
        /// <summary>
        /// The integration installation ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The creation time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The last update time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The organization ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// The integration provider identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// The provider workspace/account ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_account_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExternalAccountId { get; set; }

        /// <summary>
        /// The provider workspace/account name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_account_name")]
        public string? ExternalAccountName { get; set; }

        /// <summary>
        /// The Mixedbread user who installed the provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installed_by_user_id")]
        public string? InstalledByUserId { get; set; }

        /// <summary>
        /// The installation status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Granted provider scopes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        /// Provider-specific metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationInstallation" /> class.
        /// </summary>
        /// <param name="id">
        /// The integration installation ID
        /// </param>
        /// <param name="createdAt">
        /// The creation time
        /// </param>
        /// <param name="updatedAt">
        /// The last update time
        /// </param>
        /// <param name="organizationId">
        /// The organization ID
        /// </param>
        /// <param name="provider">
        /// The integration provider identifier
        /// </param>
        /// <param name="externalAccountId">
        /// The provider workspace/account ID
        /// </param>
        /// <param name="status">
        /// The installation status
        /// </param>
        /// <param name="metadata">
        /// Provider-specific metadata
        /// </param>
        /// <param name="externalAccountName">
        /// The provider workspace/account name
        /// </param>
        /// <param name="installedByUserId">
        /// The Mixedbread user who installed the provider
        /// </param>
        /// <param name="scopes">
        /// Granted provider scopes
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IntegrationInstallation(
            string id,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string organizationId,
            string provider,
            string externalAccountId,
            string status,
            object metadata,
            string? externalAccountName,
            string? installedByUserId,
            global::System.Collections.Generic.IList<string>? scopes)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.ExternalAccountId = externalAccountId ?? throw new global::System.ArgumentNullException(nameof(externalAccountId));
            this.ExternalAccountName = externalAccountName;
            this.InstalledByUserId = installedByUserId;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Scopes = scopes;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationInstallation" /> class.
        /// </summary>
        public IntegrationInstallation()
        {
        }

    }
}