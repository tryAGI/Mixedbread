
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Summary of a connected Slack workspace for the data sources overview.
    /// </summary>
    public sealed partial class SlackInstallationOverview
    {
        /// <summary>
        /// Slack installation ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InstallationId { get; set; }

        /// <summary>
        /// Slack team ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamId { get; set; }

        /// <summary>
        /// Slack team name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_name")]
        public string? TeamName { get; set; }

        /// <summary>
        /// The installation status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Mixedbread ingestion store ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store_id")]
        public string? StoreId { get; set; }

        /// <summary>
        /// Mixedbread ingestion store name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store_name")]
        public string? StoreName { get; set; }

        /// <summary>
        /// Number of Slack channels selected for ingestion<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("syncing_channel_count")]
        public int? SyncingChannelCount { get; set; }

        /// <summary>
        /// Whether all current and future Slack channels are synced automatically<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_sync_all_channels")]
        public bool? AutoSyncAllChannels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackInstallationOverview" /> class.
        /// </summary>
        /// <param name="installationId">
        /// Slack installation ID
        /// </param>
        /// <param name="teamId">
        /// Slack team ID
        /// </param>
        /// <param name="status">
        /// The installation status
        /// </param>
        /// <param name="teamName">
        /// Slack team name
        /// </param>
        /// <param name="storeId">
        /// Mixedbread ingestion store ID
        /// </param>
        /// <param name="storeName">
        /// Mixedbread ingestion store name
        /// </param>
        /// <param name="syncingChannelCount">
        /// Number of Slack channels selected for ingestion<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="autoSyncAllChannels">
        /// Whether all current and future Slack channels are synced automatically<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SlackInstallationOverview(
            string installationId,
            string teamId,
            string status,
            string? teamName,
            string? storeId,
            string? storeName,
            int? syncingChannelCount,
            bool? autoSyncAllChannels)
        {
            this.InstallationId = installationId ?? throw new global::System.ArgumentNullException(nameof(installationId));
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.TeamName = teamName;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.StoreId = storeId;
            this.StoreName = storeName;
            this.SyncingChannelCount = syncingChannelCount;
            this.AutoSyncAllChannels = autoSyncAllChannels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackInstallationOverview" /> class.
        /// </summary>
        public SlackInstallationOverview()
        {
        }

    }
}