#nullable enable

namespace Mixedbread
{
    public partial interface IIntegrationsClient
    {
        /// <summary>
        /// Google Drive OAuth callback<br/>
        /// Complete Google Drive OAuth and persist the installation.
        /// </summary>
        /// <param name="state">
        /// Google OAuth state
        /// </param>
        /// <param name="code">
        /// Google OAuth authorization code
        /// </param>
        /// <param name="error">
        /// Google OAuth error
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task GoogleDriveOauthCallbackAsync(
            string state,
            string? code = default,
            string? error = default,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Google Drive OAuth callback<br/>
        /// Complete Google Drive OAuth and persist the installation.
        /// </summary>
        /// <param name="state">
        /// Google OAuth state
        /// </param>
        /// <param name="code">
        /// Google OAuth authorization code
        /// </param>
        /// <param name="error">
        /// Google OAuth error
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.AutoSDKHttpResponse> GoogleDriveOauthCallbackAsResponseAsync(
            string state,
            string? code = default,
            string? error = default,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}