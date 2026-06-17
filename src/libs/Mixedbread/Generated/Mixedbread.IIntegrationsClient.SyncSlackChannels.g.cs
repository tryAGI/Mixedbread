#nullable enable

namespace Mixedbread
{
    public partial interface IIntegrationsClient
    {
        /// <summary>
        /// Sync selected Slack channels<br/>
        /// Queue historical ingestion for selected Slack channels.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.SlackChannelSyncResponse> SyncSlackChannelsAsync(

            global::Mixedbread.SlackChannelSyncParams request,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Sync selected Slack channels<br/>
        /// Queue historical ingestion for selected Slack channels.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.AutoSDKHttpResponse<global::Mixedbread.SlackChannelSyncResponse>> SyncSlackChannelsAsResponseAsync(

            global::Mixedbread.SlackChannelSyncParams request,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Sync selected Slack channels<br/>
        /// Queue historical ingestion for selected Slack channels.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.SlackChannelSyncResponse> SyncSlackChannelsAsync(
            global::System.Guid installationId,
            global::System.Collections.Generic.IList<string>? channelIds = default,
            bool? retryFailedOnly = default,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}