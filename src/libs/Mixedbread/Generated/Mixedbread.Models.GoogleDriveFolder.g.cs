
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Google Drive folder exposed for connector configuration.
    /// </summary>
    public sealed partial class GoogleDriveFolder
    {
        /// <summary>
        /// Google Drive folder ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Google Drive folder name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Whether this folder is selected for store ingestion<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_selected")]
        public bool? IsSelected { get; set; }

        /// <summary>
        /// Google Drive web view link
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_view_link")]
        public string? WebViewLink { get; set; }

        /// <summary>
        /// Last successful sync time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_synced_at")]
        public global::System.DateTime? LastSyncedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleDriveFolder" /> class.
        /// </summary>
        /// <param name="id">
        /// Google Drive folder ID
        /// </param>
        /// <param name="name">
        /// Google Drive folder name
        /// </param>
        /// <param name="isSelected">
        /// Whether this folder is selected for store ingestion<br/>
        /// Default Value: false
        /// </param>
        /// <param name="webViewLink">
        /// Google Drive web view link
        /// </param>
        /// <param name="lastSyncedAt">
        /// Last successful sync time
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GoogleDriveFolder(
            string id,
            string name,
            bool? isSelected,
            string? webViewLink,
            global::System.DateTime? lastSyncedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.IsSelected = isSelected;
            this.WebViewLink = webViewLink;
            this.LastSyncedAt = lastSyncedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleDriveFolder" /> class.
        /// </summary>
        public GoogleDriveFolder()
        {
        }

    }
}