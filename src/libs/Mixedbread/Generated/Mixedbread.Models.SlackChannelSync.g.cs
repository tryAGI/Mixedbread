
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Result of manually syncing selected Slack channels.
    /// </summary>
    public sealed partial class SlackChannelSync
    {
        /// <summary>
        /// Mixedbread store ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StoreId { get; set; }

        /// <summary>
        /// Slack channel IDs queued for historical sync
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queued_channel_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> QueuedChannelIds { get; set; }

        /// <summary>
        /// Slack channel IDs skipped by validation
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
        /// Initializes a new instance of the <see cref="SlackChannelSync" /> class.
        /// </summary>
        /// <param name="storeId">
        /// Mixedbread store ID
        /// </param>
        /// <param name="queuedChannelIds">
        /// Slack channel IDs queued for historical sync
        /// </param>
        /// <param name="skippedChannels">
        /// Slack channel IDs skipped by validation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SlackChannelSync(
            string storeId,
            global::System.Collections.Generic.IList<string> queuedChannelIds,
            global::System.Collections.Generic.Dictionary<string, string> skippedChannels)
        {
            this.StoreId = storeId ?? throw new global::System.ArgumentNullException(nameof(storeId));
            this.QueuedChannelIds = queuedChannelIds ?? throw new global::System.ArgumentNullException(nameof(queuedChannelIds));
            this.SkippedChannels = skippedChannels ?? throw new global::System.ArgumentNullException(nameof(skippedChannels));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackChannelSync" /> class.
        /// </summary>
        public SlackChannelSync()
        {
        }

    }
}