
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Parameters for selecting Google Drive folders for store ingestion.
    /// </summary>
    public sealed partial class GoogleDriveFolderSelectionUpdateParams
    {
        /// <summary>
        /// Google Drive installation ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid InstallationId { get; set; }

        /// <summary>
        /// Google Drive folder IDs to ingest into the store
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> FolderIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleDriveFolderSelectionUpdateParams" /> class.
        /// </summary>
        /// <param name="installationId">
        /// Google Drive installation ID
        /// </param>
        /// <param name="folderIds">
        /// Google Drive folder IDs to ingest into the store
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GoogleDriveFolderSelectionUpdateParams(
            global::System.Guid installationId,
            global::System.Collections.Generic.IList<string> folderIds)
        {
            this.InstallationId = installationId;
            this.FolderIds = folderIds ?? throw new global::System.ArgumentNullException(nameof(folderIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleDriveFolderSelectionUpdateParams" /> class.
        /// </summary>
        public GoogleDriveFolderSelectionUpdateParams()
        {
        }

    }
}