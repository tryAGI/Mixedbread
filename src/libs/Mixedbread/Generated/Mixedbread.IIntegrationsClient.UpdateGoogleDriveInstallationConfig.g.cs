#nullable enable

namespace Mixedbread
{
    public partial interface IIntegrationsClient
    {
        /// <summary>
        /// Update Google Drive data source config<br/>
        /// Update a Google Drive data source config (sync entire Drive). Enabling syncs the whole Drive.
        /// </summary>
        /// <param name="installationId">
        /// Google Drive installation ID
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.GoogleDriveFolderSelectionResponse> UpdateGoogleDriveInstallationConfigAsync(
            global::System.Guid installationId,

            global::Mixedbread.GoogleDriveInstallationConfigUpdateBody request,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Google Drive data source config<br/>
        /// Update a Google Drive data source config (sync entire Drive). Enabling syncs the whole Drive.
        /// </summary>
        /// <param name="installationId">
        /// Google Drive installation ID
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.AutoSDKHttpResponse<global::Mixedbread.GoogleDriveFolderSelectionResponse>> UpdateGoogleDriveInstallationConfigAsResponseAsync(
            global::System.Guid installationId,

            global::Mixedbread.GoogleDriveInstallationConfigUpdateBody request,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Google Drive data source config<br/>
        /// Update a Google Drive data source config (sync entire Drive). Enabling syncs the whole Drive.
        /// </summary>
        /// <param name="installationId">
        /// Google Drive installation ID
        /// </param>
        /// <param name="autoSyncAll">
        /// Whether the entire Drive (all current and future files) is synced automatically
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.GoogleDriveFolderSelectionResponse> UpdateGoogleDriveInstallationConfigAsync(
            global::System.Guid installationId,
            bool autoSyncAll,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}