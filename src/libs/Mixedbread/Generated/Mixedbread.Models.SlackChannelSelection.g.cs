
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Slack channel selection for a store connector.
    /// </summary>
    public sealed partial class SlackChannelSelection
    {
        /// <summary>
        /// Whether Slack is installed for the organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_installed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsInstalled { get; set; }

        /// <summary>
        /// Slack installation ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installation_id")]
        public string? InstallationId { get; set; }

        /// <summary>
        /// Slack team ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        public string? TeamId { get; set; }

        /// <summary>
        /// Slack team name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_name")]
        public string? TeamName { get; set; }

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
        /// Whether all current and future Slack channels are synced automatically<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_sync_all_channels")]
        public bool? AutoSyncAllChannels { get; set; }

        /// <summary>
        /// Available public Slack channels
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Mixedbread.SlackChannel> Channels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackChannelSelection" /> class.
        /// </summary>
        /// <param name="isInstalled">
        /// Whether Slack is installed for the organization
        /// </param>
        /// <param name="channels">
        /// Available public Slack channels
        /// </param>
        /// <param name="installationId">
        /// Slack installation ID
        /// </param>
        /// <param name="teamId">
        /// Slack team ID
        /// </param>
        /// <param name="teamName">
        /// Slack team name
        /// </param>
        /// <param name="storeId">
        /// Mixedbread store ID
        /// </param>
        /// <param name="storeName">
        /// Mixedbread store name
        /// </param>
        /// <param name="autoSyncAllChannels">
        /// Whether all current and future Slack channels are synced automatically<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SlackChannelSelection(
            bool isInstalled,
            global::System.Collections.Generic.IList<global::Mixedbread.SlackChannel> channels,
            string? installationId,
            string? teamId,
            string? teamName,
            string? storeId,
            string? storeName,
            bool? autoSyncAllChannels)
        {
            this.IsInstalled = isInstalled;
            this.InstallationId = installationId;
            this.TeamId = teamId;
            this.TeamName = teamName;
            this.StoreId = storeId;
            this.StoreName = storeName;
            this.AutoSyncAllChannels = autoSyncAllChannels;
            this.Channels = channels ?? throw new global::System.ArgumentNullException(nameof(channels));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackChannelSelection" /> class.
        /// </summary>
        public SlackChannelSelection()
        {
        }

    }
}