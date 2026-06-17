
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Provider-agnostic summary of a connected data source for the overview list.
    /// </summary>
    public sealed partial class DataSourceInstallation
    {
        /// <summary>
        /// Integration installation ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InstallationId { get; set; }

        /// <summary>
        /// The integration provider identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// Human-readable connected account/workspace name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// The installation status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Mixedbread ingestion store ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store_id")]
        public string? StoreId { get; set; }

        /// <summary>
        /// Mixedbread ingestion store name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store_name")]
        public string? StoreName { get; set; }

        /// <summary>
        /// Number of selected ingestion items (channels/folders)<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_count")]
        public int? ItemCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSourceInstallation" /> class.
        /// </summary>
        /// <param name="installationId">
        /// Integration installation ID
        /// </param>
        /// <param name="provider">
        /// The integration provider identifier
        /// </param>
        /// <param name="displayName">
        /// Human-readable connected account/workspace name
        /// </param>
        /// <param name="status">
        /// The installation status
        /// </param>
        /// <param name="storeId">
        /// Mixedbread ingestion store ID
        /// </param>
        /// <param name="storeName">
        /// Mixedbread ingestion store name
        /// </param>
        /// <param name="itemCount">
        /// Number of selected ingestion items (channels/folders)<br/>
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataSourceInstallation(
            string installationId,
            string provider,
            string displayName,
            string status,
            string? storeId,
            string? storeName,
            int? itemCount)
        {
            this.InstallationId = installationId ?? throw new global::System.ArgumentNullException(nameof(installationId));
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.StoreId = storeId;
            this.StoreName = storeName;
            this.ItemCount = itemCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSourceInstallation" /> class.
        /// </summary>
        public DataSourceInstallation()
        {
        }

    }
}