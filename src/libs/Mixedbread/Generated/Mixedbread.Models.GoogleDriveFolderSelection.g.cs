
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Google Drive folder selection for a store connector.
    /// </summary>
    public sealed partial class GoogleDriveFolderSelection
    {
        /// <summary>
        /// Whether Google Drive is installed for the organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_installed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsInstalled { get; set; }

        /// <summary>
        /// Google Drive installation ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installation_id")]
        public string? InstallationId { get; set; }

        /// <summary>
        /// Connected Google account email
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account_email")]
        public string? AccountEmail { get; set; }

        /// <summary>
        /// Mixedbread store ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store_id")]
        public string? StoreId { get; set; }

        /// <summary>
        /// Mixedbread store name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store_name")]
        public string? StoreName { get; set; }

        /// <summary>
        /// Whether the entire Drive (all current and future files) is synced automatically<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_sync_all")]
        public bool? AutoSyncAll { get; set; }

        /// <summary>
        /// Available Google Drive folders
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folders")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Mixedbread.GoogleDriveFolder> Folders { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleDriveFolderSelection" /> class.
        /// </summary>
        /// <param name="isInstalled">
        /// Whether Google Drive is installed for the organization
        /// </param>
        /// <param name="folders">
        /// Available Google Drive folders
        /// </param>
        /// <param name="installationId">
        /// Google Drive installation ID
        /// </param>
        /// <param name="accountEmail">
        /// Connected Google account email
        /// </param>
        /// <param name="storeId">
        /// Mixedbread store ID
        /// </param>
        /// <param name="storeName">
        /// Mixedbread store name
        /// </param>
        /// <param name="autoSyncAll">
        /// Whether the entire Drive (all current and future files) is synced automatically<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GoogleDriveFolderSelection(
            bool isInstalled,
            global::System.Collections.Generic.IList<global::Mixedbread.GoogleDriveFolder> folders,
            string? installationId,
            string? accountEmail,
            string? storeId,
            string? storeName,
            bool? autoSyncAll)
        {
            this.IsInstalled = isInstalled;
            this.InstallationId = installationId;
            this.AccountEmail = accountEmail;
            this.StoreId = storeId;
            this.StoreName = storeName;
            this.AutoSyncAll = autoSyncAll;
            this.Folders = folders ?? throw new global::System.ArgumentNullException(nameof(folders));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleDriveFolderSelection" /> class.
        /// </summary>
        public GoogleDriveFolderSelection()
        {
        }

    }
}