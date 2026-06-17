
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Provider metadata exposed to product surfaces.
    /// </summary>
    public sealed partial class IntegrationProviderManifest
    {
        /// <summary>
        /// The integration provider identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mixedbread.JsonConverters.IntegrationProviderManifestProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mixedbread.IntegrationProviderManifestProvider Provider { get; set; }

        /// <summary>
        /// Human-readable provider name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// Primary authorization method
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mixedbread.JsonConverters.IntegrationProviderManifestAuthTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mixedbread.IntegrationProviderManifestAuthType AuthType { get; set; }

        /// <summary>
        /// Supported integration capabilities
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capabilities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Mixedbread.IntegrationProviderManifestCapabilitie> Capabilities { get; set; }

        /// <summary>
        /// Provider scopes required for the initial install
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_scopes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> RequiredScopes { get; set; }

        /// <summary>
        /// The backend subsystem used for ingestion, if ingestion is supported
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ingestion_backing")]
        public global::Mixedbread.IntegrationProviderManifestIngestionBacking2? IngestionBacking { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationProviderManifest" /> class.
        /// </summary>
        /// <param name="provider">
        /// The integration provider identifier
        /// </param>
        /// <param name="displayName">
        /// Human-readable provider name
        /// </param>
        /// <param name="authType">
        /// Primary authorization method
        /// </param>
        /// <param name="capabilities">
        /// Supported integration capabilities
        /// </param>
        /// <param name="requiredScopes">
        /// Provider scopes required for the initial install
        /// </param>
        /// <param name="ingestionBacking">
        /// The backend subsystem used for ingestion, if ingestion is supported
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IntegrationProviderManifest(
            global::Mixedbread.IntegrationProviderManifestProvider provider,
            string displayName,
            global::Mixedbread.IntegrationProviderManifestAuthType authType,
            global::System.Collections.Generic.IList<global::Mixedbread.IntegrationProviderManifestCapabilitie> capabilities,
            global::System.Collections.Generic.IList<string> requiredScopes,
            global::Mixedbread.IntegrationProviderManifestIngestionBacking2? ingestionBacking)
        {
            this.Provider = provider;
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.AuthType = authType;
            this.Capabilities = capabilities ?? throw new global::System.ArgumentNullException(nameof(capabilities));
            this.RequiredScopes = requiredScopes ?? throw new global::System.ArgumentNullException(nameof(requiredScopes));
            this.IngestionBacking = ingestionBacking;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationProviderManifest" /> class.
        /// </summary>
        public IntegrationProviderManifest()
        {
        }

    }
}