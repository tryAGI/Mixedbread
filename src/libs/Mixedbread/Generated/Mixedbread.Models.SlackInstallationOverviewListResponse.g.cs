
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// List of connected Slack workspaces for the data sources overview.
    /// </summary>
    public sealed partial class SlackInstallationOverviewListResponse
    {
        /// <summary>
        /// Connected Slack workspaces
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Mixedbread.SlackInstallationOverview> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackInstallationOverviewListResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Connected Slack workspaces
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SlackInstallationOverviewListResponse(
            global::System.Collections.Generic.IList<global::Mixedbread.SlackInstallationOverview> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackInstallationOverviewListResponse" /> class.
        /// </summary>
        public SlackInstallationOverviewListResponse()
        {
        }

    }
}