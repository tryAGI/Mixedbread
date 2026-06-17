
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Summary of a connected Google Drive account for the data sources overview.
    /// </summary>
    public sealed partial class GoogleDriveInstallationOverview
    {
        /// <summary>
        /// Google Drive installation ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InstallationId { get; set; }

        /// <summary>
        /// Connected Google account email
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account_email")]
        public string? AccountEmail { get; set; }

        /// <summary>
        /// Connected Google account name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account_name")]
        public string? AccountName { get; set; }

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
        /// Number of Google Drive folders selected for ingestion<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("syncing_folder_count")]
        public int? SyncingFolderCount { get; set; }

        /// <summary>
        /// Whether the entire Drive is synced automatically<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_sync_all")]
        public bool? AutoSyncAll { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleDriveInstallationOverview" /> class.
        /// </summary>
        /// <param name="installationId">
        /// Google Drive installation ID
        /// </param>
        /// <param name="status">
        /// The installation status
        /// </param>
        /// <param name="accountEmail">
        /// Connected Google account email
        /// </param>
        /// <param name="accountName">
        /// Connected Google account name
        /// </param>
        /// <param name="storeId">
        /// Mixedbread ingestion store ID
        /// </param>
        /// <param name="storeName">
        /// Mixedbread ingestion store name
        /// </param>
        /// <param name="syncingFolderCount">
        /// Number of Google Drive folders selected for ingestion<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="autoSyncAll">
        /// Whether the entire Drive is synced automatically<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GoogleDriveInstallationOverview(
            string installationId,
            string status,
            string? accountEmail,
            string? accountName,
            string? storeId,
            string? storeName,
            int? syncingFolderCount,
            bool? autoSyncAll)
        {
            this.InstallationId = installationId ?? throw new global::System.ArgumentNullException(nameof(installationId));
            this.AccountEmail = accountEmail;
            this.AccountName = accountName;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.StoreId = storeId;
            this.StoreName = storeName;
            this.SyncingFolderCount = syncingFolderCount;
            this.AutoSyncAll = autoSyncAll;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleDriveInstallationOverview" /> class.
        /// </summary>
        public GoogleDriveInstallationOverview()
        {
        }

    }
}