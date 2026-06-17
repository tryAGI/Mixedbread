#nullable enable

namespace Mixedbread
{
    public partial interface IIntegrationsClient
    {
        /// <summary>
        /// Disconnect Google Drive<br/>
        /// Disconnect a specific Google Drive installation from the current organization.
        /// </summary>
        /// <param name="installationId">
        /// Google Drive installation ID
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.IntegrationInstallationResponse> DisconnectGoogleDriveInstallationAsync(
            global::System.Guid installationId,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Disconnect Google Drive<br/>
        /// Disconnect a specific Google Drive installation from the current organization.
        /// </summary>
        /// <param name="installationId">
        /// Google Drive installation ID
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.AutoSDKHttpResponse<global::Mixedbread.IntegrationInstallationResponse>> DisconnectGoogleDriveInstallationAsResponseAsync(
            global::System.Guid installationId,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}