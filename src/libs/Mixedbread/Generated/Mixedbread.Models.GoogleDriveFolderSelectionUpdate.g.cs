
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Result of updating Google Drive folder selection.
    /// </summary>
    public sealed partial class GoogleDriveFolderSelectionUpdate
    {
        /// <summary>
        /// Mixedbread store ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StoreId { get; set; }

        /// <summary>
        /// Selected Google Drive folder IDs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selected_folder_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> SelectedFolderIds { get; set; }

        /// <summary>
        /// Folders queued for backfill ingestion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backfill_folder_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> BackfillFolderIds { get; set; }

        /// <summary>
        /// Folder IDs skipped with a reason
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipped_folders")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> SkippedFolders { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleDriveFolderSelectionUpdate" /> class.
        /// </summary>
        /// <param name="storeId">
        /// Mixedbread store ID
        /// </param>
        /// <param name="selectedFolderIds">
        /// Selected Google Drive folder IDs
        /// </param>
        /// <param name="backfillFolderIds">
        /// Folders queued for backfill ingestion
        /// </param>
        /// <param name="skippedFolders">
        /// Folder IDs skipped with a reason
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GoogleDriveFolderSelectionUpdate(
            string storeId,
            global::System.Collections.Generic.IList<string> selectedFolderIds,
            global::System.Collections.Generic.IList<string> backfillFolderIds,
            global::System.Collections.Generic.Dictionary<string, string> skippedFolders)
        {
            this.StoreId = storeId ?? throw new global::System.ArgumentNullException(nameof(storeId));
            this.SelectedFolderIds = selectedFolderIds ?? throw new global::System.ArgumentNullException(nameof(selectedFolderIds));
            this.BackfillFolderIds = backfillFolderIds ?? throw new global::System.ArgumentNullException(nameof(backfillFolderIds));
            this.SkippedFolders = skippedFolders ?? throw new global::System.ArgumentNullException(nameof(skippedFolders));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleDriveFolderSelectionUpdate" /> class.
        /// </summary>
        public GoogleDriveFolderSelectionUpdate()
        {
        }

    }
}