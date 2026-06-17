#nullable enable

namespace Mixedbread
{
    public partial interface IIntegrationsClient
    {
        /// <summary>
        /// Sync a Google Drive connector<br/>
        /// Queue an incremental Google Drive change sync.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.GoogleDriveSyncResponse> SyncGoogleDriveAsync(

            global::Mixedbread.GoogleDriveSyncParams request,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Sync a Google Drive connector<br/>
        /// Queue an incremental Google Drive change sync.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.AutoSDKHttpResponse<global::Mixedbread.GoogleDriveSyncResponse>> SyncGoogleDriveAsResponseAsync(

            global::Mixedbread.GoogleDriveSyncParams request,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Sync a Google Drive connector<br/>
        /// Queue an incremental Google Drive change sync.
        /// </summary>
        /// <param name="installationId">
        /// Google Drive installation ID
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.GoogleDriveSyncResponse> SyncGoogleDriveAsync(
            global::System.Guid installationId,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}