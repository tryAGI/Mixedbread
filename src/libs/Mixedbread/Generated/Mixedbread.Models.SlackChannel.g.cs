
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Slack public channel exposed for connector configuration.
    /// </summary>
    public sealed partial class SlackChannel
    {
        /// <summary>
        /// Slack channel ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Slack channel name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Whether the Slack channel is archived
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_archived")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsArchived { get; set; }

        /// <summary>
        /// Whether the Slack app bot is a member
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_member")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsMember { get; set; }

        /// <summary>
        /// Whether this channel is selected for store ingestion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_selected")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsSelected { get; set; }

        /// <summary>
        /// Approximate Slack channel member count
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_members")]
        public int? NumMembers { get; set; }

        /// <summary>
        /// Current Slack ingestion status<br/>
        /// Default Value: not_syncing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sync_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mixedbread.JsonConverters.SlackChannelSyncStatusJsonConverter))]
        public global::Mixedbread.SlackChannelSyncStatus? SyncStatus { get; set; }

        /// <summary>
        /// Last successful Slack sync time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_synced_at")]
        public global::System.DateTime? LastSyncedAt { get; set; }

        /// <summary>
        /// Last Slack sync error
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sync_error")]
        public string? SyncError { get; set; }

        /// <summary>
        /// Most recent Slack history import status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_sync_status")]
        public global::Mixedbread.SlackChannelLastSyncStatus2? LastSyncStatus { get; set; }

        /// <summary>
        /// Most recent Slack history import start time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_sync_started_at")]
        public global::System.DateTime? LastSyncStartedAt { get; set; }

        /// <summary>
        /// Most recent Slack history import completion time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_sync_completed_at")]
        public global::System.DateTime? LastSyncCompletedAt { get; set; }

        /// <summary>
        /// Messages fetched in the last Slack history import
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_sync_message_count")]
        public int? LastSyncMessageCount { get; set; }

        /// <summary>
        /// Store files written in the last Slack history import
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_sync_store_file_count")]
        public int? LastSyncStoreFileCount { get; set; }

        /// <summary>
        /// Most recent Slack history import run ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_sync_run_id")]
        public string? LastSyncRunId { get; set; }

        /// <summary>
        /// Number of active Slack history imports for this channel<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("syncs_in_progress")]
        public int? SyncsInProgress { get; set; }

        /// <summary>
        /// Most recent Slack item-level sync warning
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_sync_warning")]
        public string? LastSyncWarning { get; set; }

        /// <summary>
        /// Number of Slack items that failed in the most recent import<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_sync_failed_item_count")]
        public int? LastSyncFailedItemCount { get; set; }

        /// <summary>
        /// Bounded Slack item failures from the most recent import
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_sync_failed_items")]
        public global::System.Collections.Generic.IList<object>? LastSyncFailedItems { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackChannel" /> class.
        /// </summary>
        /// <param name="id">
        /// Slack channel ID
        /// </param>
        /// <param name="name">
        /// Slack channel name
        /// </param>
        /// <param name="isArchived">
        /// Whether the Slack channel is archived
        /// </param>
        /// <param name="isMember">
        /// Whether the Slack app bot is a member
        /// </param>
        /// <param name="isSelected">
        /// Whether this channel is selected for store ingestion
        /// </param>
        /// <param name="numMembers">
        /// Approximate Slack channel member count
        /// </param>
        /// <param name="syncStatus">
        /// Current Slack ingestion status<br/>
        /// Default Value: not_syncing
        /// </param>
        /// <param name="lastSyncedAt">
        /// Last successful Slack sync time
        /// </param>
        /// <param name="syncError">
        /// Last Slack sync error
        /// </param>
        /// <param name="lastSyncStatus">
        /// Most recent Slack history import status
        /// </param>
        /// <param name="lastSyncStartedAt">
        /// Most recent Slack history import start time
        /// </param>
        /// <param name="lastSyncCompletedAt">
        /// Most recent Slack history import completion time
        /// </param>
        /// <param name="lastSyncMessageCount">
        /// Messages fetched in the last Slack history import
        /// </param>
        /// <param name="lastSyncStoreFileCount">
        /// Store files written in the last Slack history import
        /// </param>
        /// <param name="lastSyncRunId">
        /// Most recent Slack history import run ID
        /// </param>
        /// <param name="syncsInProgress">
        /// Number of active Slack history imports for this channel<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="lastSyncWarning">
        /// Most recent Slack item-level sync warning
        /// </param>
        /// <param name="lastSyncFailedItemCount">
        /// Number of Slack items that failed in the most recent import<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="lastSyncFailedItems">
        /// Bounded Slack item failures from the most recent import
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SlackChannel(
            string id,
            string name,
            bool isArchived,
            bool isMember,
            bool isSelected,
            int? numMembers,
            global::Mixedbread.SlackChannelSyncStatus? syncStatus,
            global::System.DateTime? lastSyncedAt,
            string? syncError,
            global::Mixedbread.SlackChannelLastSyncStatus2? lastSyncStatus,
            global::System.DateTime? lastSyncStartedAt,
            global::System.DateTime? lastSyncCompletedAt,
            int? lastSyncMessageCount,
            int? lastSyncStoreFileCount,
            string? lastSyncRunId,
            int? syncsInProgress,
            string? lastSyncWarning,
            int? lastSyncFailedItemCount,
            global::System.Collections.Generic.IList<object>? lastSyncFailedItems)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.IsArchived = isArchived;
            this.IsMember = isMember;
            this.IsSelected = isSelected;
            this.NumMembers = numMembers;
            this.SyncStatus = syncStatus;
            this.LastSyncedAt = lastSyncedAt;
            this.SyncError = syncError;
            this.LastSyncStatus = lastSyncStatus;
            this.LastSyncStartedAt = lastSyncStartedAt;
            this.LastSyncCompletedAt = lastSyncCompletedAt;
            this.LastSyncMessageCount = lastSyncMessageCount;
            this.LastSyncStoreFileCount = lastSyncStoreFileCount;
            this.LastSyncRunId = lastSyncRunId;
            this.SyncsInProgress = syncsInProgress;
            this.LastSyncWarning = lastSyncWarning;
            this.LastSyncFailedItemCount = lastSyncFailedItemCount;
            this.LastSyncFailedItems = lastSyncFailedItems;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackChannel" /> class.
        /// </summary>
        public SlackChannel()
        {
        }

    }
}