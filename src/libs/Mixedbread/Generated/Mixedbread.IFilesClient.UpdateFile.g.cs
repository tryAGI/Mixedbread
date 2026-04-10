#nullable enable

namespace Mixedbread
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Update file<br/>
        /// Update the details of a specific file.<br/>
        /// Args:<br/>
        ///     file_id: The ID of the file to update.<br/>
        ///     file: The new details for the file.<br/>
        /// Returns:<br/>
        ///     FileObject: The updated file details.
        /// </summary>
        /// <param name="fileId">
        /// The ID of the file to update
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.FileObject> UpdateFileAsync(
            global::System.Guid fileId,

            global::Mixedbread.BodyUpdateFile request,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update file<br/>
        /// Update the details of a specific file.<br/>
        /// Args:<br/>
        ///     file_id: The ID of the file to update.<br/>
        ///     file: The new details for the file.<br/>
        /// Returns:<br/>
        ///     FileObject: The updated file details.
        /// </summary>
        /// <param name="fileId">
        /// The ID of the file to update
        /// </param>
        /// <param name="file">
        /// The file to update
        /// </param>
        /// <param name="filename">
        /// The file to update
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.FileObject> UpdateFileAsync(
            global::System.Guid fileId,
            byte[] file,
            string filename,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}