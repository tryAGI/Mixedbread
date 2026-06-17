
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Result of updating Slack channel selection.
    /// </summary>
    public sealed partial class SlackChannelSelectionUpdate
    {
        /// <summary>
        /// Mixedbread store ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StoreId { get; set; }

        /// <summary>
        /// Selected Slack channel IDs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selected_channel_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> SelectedChannelIds { get; set; }

        /// <summary>
        /// Slack channels the app joined while saving
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("joined_channel_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> JoinedChannelIds { get; set; }

        /// <summary>
        /// Slack channels queued for historical ingestion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backfill_channel_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> BackfillChannelIds { get; set; }

        /// <summary>
        /// Slack channel IDs skipped by Slack error
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipped_channels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> SkippedChannels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackChannelSelectionUpdate" /> class.
        /// </summary>
        /// <param name="storeId">
        /// Mixedbread store ID
        /// </param>
        /// <param name="selectedChannelIds">
        /// Selected Slack channel IDs
        /// </param>
        /// <param name="joinedChannelIds">
        /// Slack channels the app joined while saving
        /// </param>
        /// <param name="backfillChannelIds">
        /// Slack channels queued for historical ingestion
        /// </param>
        /// <param name="skippedChannels">
        /// Slack channel IDs skipped by Slack error
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SlackChannelSelectionUpdate(
            string storeId,
            global::System.Collections.Generic.IList<string> selectedChannelIds,
            global::System.Collections.Generic.IList<string> joinedChannelIds,
            global::System.Collections.Generic.IList<string> backfillChannelIds,
            global::System.Collections.Generic.Dictionary<string, string> skippedChannels)
        {
            this.StoreId = storeId ?? throw new global::System.ArgumentNullException(nameof(storeId));
            this.SelectedChannelIds = selectedChannelIds ?? throw new global::System.ArgumentNullException(nameof(selectedChannelIds));
            this.JoinedChannelIds = joinedChannelIds ?? throw new global::System.ArgumentNullException(nameof(joinedChannelIds));
            this.BackfillChannelIds = backfillChannelIds ?? throw new global::System.ArgumentNullException(nameof(backfillChannelIds));
            this.SkippedChannels = skippedChannels ?? throw new global::System.ArgumentNullException(nameof(skippedChannels));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackChannelSelectionUpdate" /> class.
        /// </summary>
        public SlackChannelSelectionUpdate()
        {
        }

    }
}