#nullable enable

namespace Mixedbread
{
    public partial interface IIntegrationsClient
    {
        /// <summary>
        /// Authorize Slack integration<br/>
        /// Start Slack OAuth for the current organization.
        /// </summary>
        /// <param name="storeName">
        /// Optional ingestion store name
        /// </param>
        /// <param name="autoSyncAll">
        /// Automatically sync all current and future channels<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task AuthorizeSlackIntegrationAsync(
            string? storeName = default,
            bool? autoSyncAll = default,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Authorize Slack integration<br/>
        /// Start Slack OAuth for the current organization.
        /// </summary>
        /// <param name="storeName">
        /// Optional ingestion store name
        /// </param>
        /// <param name="autoSyncAll">
        /// Automatically sync all current and future channels<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.AutoSDKHttpResponse> AuthorizeSlackIntegrationAsResponseAsync(
            string? storeName = default,
            bool? autoSyncAll = default,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}