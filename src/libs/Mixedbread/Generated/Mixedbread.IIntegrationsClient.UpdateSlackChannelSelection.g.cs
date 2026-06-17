#nullable enable

namespace Mixedbread
{
    public partial interface IIntegrationsClient
    {
        /// <summary>
        /// Update Slack channels for store ingestion<br/>
        /// Replace the Slack channels selected for ingestion into a store.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.SlackChannelSelectionUpdateResponse> UpdateSlackChannelSelectionAsync(

            global::Mixedbread.SlackChannelSelectionUpdateParams request,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Slack channels for store ingestion<br/>
        /// Replace the Slack channels selected for ingestion into a store.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.AutoSDKHttpResponse<global::Mixedbread.SlackChannelSelectionUpdateResponse>> UpdateSlackChannelSelectionAsResponseAsync(

            global::Mixedbread.SlackChannelSelectionUpdateParams request,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Slack channels for store ingestion<br/>
        /// Replace the Slack channels selected for ingestion into a store.
        /// </summary>
        /// <param name="installationId">
        /// Slack installation ID
        /// </param>
        /// <param name="channelIds">
        /// Slack channel IDs to ingest into the store
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.SlackChannelSelectionUpdateResponse> UpdateSlackChannelSelectionAsync(
            global::System.Guid installationId,
            global::System.Collections.Generic.IList<string> channelIds,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}