#nullable enable

namespace Mixedbread
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Get file details<br/>
        /// Retrieve details of a specific file by its ID.<br/>
        /// Args:<br/>
        ///     file_id: The ID of the file to retrieve.<br/>
        /// Returns:<br/>
        ///     FileResponse: The response containing the file details.
        /// </summary>
        /// <param name="fileId">
        /// The ID of the file to retrieve
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.FileObject> RetrieveFileAsync(
            global::System.Guid fileId,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}