
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Request body for updating a Slack installation's data source config.
    /// </summary>
    public sealed partial class SlackInstallationConfigUpdateBody
    {
        /// <summary>
        /// Whether all current and future Slack channels are synced automatically
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_sync_all_channels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AutoSyncAllChannels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackInstallationConfigUpdateBody" /> class.
        /// </summary>
        /// <param name="autoSyncAllChannels">
        /// Whether all current and future Slack channels are synced automatically
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SlackInstallationConfigUpdateBody(
            bool autoSyncAllChannels)
        {
            this.AutoSyncAllChannels = autoSyncAllChannels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackInstallationConfigUpdateBody" /> class.
        /// </summary>
        public SlackInstallationConfigUpdateBody()
        {
        }

    }
}