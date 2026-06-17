
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Parameters for selecting Slack channels for store ingestion.
    /// </summary>
    public sealed partial class SlackChannelSelectionUpdateParams
    {
        /// <summary>
        /// Slack installation ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid InstallationId { get; set; }

        /// <summary>
        /// Slack channel IDs to ingest into the store
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ChannelIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackChannelSelectionUpdateParams" /> class.
        /// </summary>
        /// <param name="installationId">
        /// Slack installation ID
        /// </param>
        /// <param name="channelIds">
        /// Slack channel IDs to ingest into the store
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SlackChannelSelectionUpdateParams(
            global::System.Guid installationId,
            global::System.Collections.Generic.IList<string> channelIds)
        {
            this.InstallationId = installationId;
            this.ChannelIds = channelIds ?? throw new global::System.ArgumentNullException(nameof(channelIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackChannelSelectionUpdateParams" /> class.
        /// </summary>
        public SlackChannelSelectionUpdateParams()
        {
        }

    }
}