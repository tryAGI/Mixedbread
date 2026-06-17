#nullable enable

namespace Mixedbread
{
    public partial interface IIntegrationsClient
    {
        /// <summary>
        /// Slack OAuth callback<br/>
        /// Complete Slack OAuth and persist the workspace installation.
        /// </summary>
        /// <param name="state">
        /// Slack OAuth state
        /// </param>
        /// <param name="code">
        /// Slack OAuth authorization code
        /// </param>
        /// <param name="error">
        /// Slack OAuth error
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task SlackOauthCallbackAsync(
            string state,
            string? code = default,
            string? error = default,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Slack OAuth callback<br/>
        /// Complete Slack OAuth and persist the workspace installation.
        /// </summary>
        /// <param name="state">
        /// Slack OAuth state
        /// </param>
        /// <param name="code">
        /// Slack OAuth authorization code
        /// </param>
        /// <param name="error">
        /// Slack OAuth error
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.AutoSDKHttpResponse> SlackOauthCallbackAsResponseAsync(
            string state,
            string? code = default,
            string? error = default,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}