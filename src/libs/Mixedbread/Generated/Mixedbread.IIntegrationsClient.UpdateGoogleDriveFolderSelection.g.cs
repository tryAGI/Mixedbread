#nullable enable

namespace Mixedbread
{
    public partial interface IIntegrationsClient
    {
        /// <summary>
        /// Update Google Drive folders for store ingestion<br/>
        /// Replace the Google Drive folders selected for ingestion into a store.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.GoogleDriveFolderSelectionUpdateResponse> UpdateGoogleDriveFolderSelectionAsync(

            global::Mixedbread.GoogleDriveFolderSelectionUpdateParams request,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Google Drive folders for store ingestion<br/>
        /// Replace the Google Drive folders selected for ingestion into a store.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.AutoSDKHttpResponse<global::Mixedbread.GoogleDriveFolderSelectionUpdateResponse>> UpdateGoogleDriveFolderSelectionAsResponseAsync(

            global::Mixedbread.GoogleDriveFolderSelectionUpdateParams request,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Google Drive folders for store ingestion<br/>
        /// Replace the Google Drive folders selected for ingestion into a store.
        /// </summary>
        /// <param name="installationId">
        /// Google Drive installation ID
        /// </param>
        /// <param name="folderIds">
        /// Google Drive folder IDs to ingest into the store
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.GoogleDriveFolderSelectionUpdateResponse> UpdateGoogleDriveFolderSelectionAsync(
            global::System.Guid installationId,
            global::System.Collections.Generic.IList<string> folderIds,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}