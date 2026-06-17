#nullable enable

namespace Mixedbread
{
    public partial interface IIntegrationsClient
    {
        /// <summary>
        /// Update Slack data source config<br/>
        /// Update a Slack data source config (auto-sync-all). Enabling it syncs every channel.
        /// </summary>
        /// <param name="installationId">
        /// Slack installation ID
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.SlackChannelSelectionResponse> UpdateSlackInstallationConfigAsync(
            global::System.Guid installationId,

            global::Mixedbread.SlackInstallationConfigUpdateBody request,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Slack data source config<br/>
        /// Update a Slack data source config (auto-sync-all). Enabling it syncs every channel.
        /// </summary>
        /// <param name="installationId">
        /// Slack installation ID
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.AutoSDKHttpResponse<global::Mixedbread.SlackChannelSelectionResponse>> UpdateSlackInstallationConfigAsResponseAsync(
            global::System.Guid installationId,

            global::Mixedbread.SlackInstallationConfigUpdateBody request,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Slack data source config<br/>
        /// Update a Slack data source config (auto-sync-all). Enabling it syncs every channel.
        /// </summary>
        /// <param name="installationId">
        /// Slack installation ID
        /// </param>
        /// <param name="autoSyncAllChannels">
        /// Whether all current and future Slack channels are synced automatically
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.SlackChannelSelectionResponse> UpdateSlackInstallationConfigAsync(
            global::System.Guid installationId,
            bool autoSyncAllChannels,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}