#nullable enable

namespace Mixedbread
{
    public partial interface IIntegrationsClient
    {
        /// <summary>
        /// Connect Slack with a customer-provided app<br/>
        /// Connect a Slack workspace using a customer-created app's bot token and signing secret.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.IntegrationInstallationResponse> ConnectSlackManualAsync(

            global::Mixedbread.SlackManualConnectBody request,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Connect Slack with a customer-provided app<br/>
        /// Connect a Slack workspace using a customer-created app's bot token and signing secret.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.AutoSDKHttpResponse<global::Mixedbread.IntegrationInstallationResponse>> ConnectSlackManualAsResponseAsync(

            global::Mixedbread.SlackManualConnectBody request,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Connect Slack with a customer-provided app<br/>
        /// Connect a Slack workspace using a customer-created app's bot token and signing secret.
        /// </summary>
        /// <param name="botToken">
        /// Slack bot user OAuth token (xoxb-…)
        /// </param>
        /// <param name="signingSecret">
        /// Slack app signing secret
        /// </param>
        /// <param name="storeName">
        /// Optional ingestion store name
        /// </param>
        /// <param name="autoSyncAll">
        /// Automatically sync all current and future channels<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.IntegrationInstallationResponse> ConnectSlackManualAsync(
            string botToken,
            string signingSecret,
            string? storeName = default,
            bool? autoSyncAll = default,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}