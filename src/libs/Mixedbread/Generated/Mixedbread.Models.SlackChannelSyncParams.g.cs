
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Parameters for manually syncing selected Slack channels.
    /// </summary>
    public sealed partial class SlackChannelSyncParams
    {
        /// <summary>
        /// Slack installation ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid InstallationId { get; set; }

        /// <summary>
        /// Slack channel IDs to sync. Defaults to all selected channels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel_ids")]
        public global::System.Collections.Generic.IList<string>? ChannelIds { get; set; }

        /// <summary>
        /// Only retry Slack items that failed in the most recent import.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retry_failed_only")]
        public bool? RetryFailedOnly { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackChannelSyncParams" /> class.
        /// </summary>
        /// <param name="installationId">
        /// Slack installation ID
        /// </param>
        /// <param name="channelIds">
        /// Slack channel IDs to sync. Defaults to all selected channels.
        /// </param>
        /// <param name="retryFailedOnly">
        /// Only retry Slack items that failed in the most recent import.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SlackChannelSyncParams(
            global::System.Guid installationId,
            global::System.Collections.Generic.IList<string>? channelIds,
            bool? retryFailedOnly)
        {
            this.InstallationId = installationId;
            this.ChannelIds = channelIds;
            this.RetryFailedOnly = retryFailedOnly;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackChannelSyncParams" /> class.
        /// </summary>
        public SlackChannelSyncParams()
        {
        }

    }
}