#nullable enable

namespace Mixedbread
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Complete multipart upload<br/>
        /// Complete a multipart upload after all parts have been uploaded.<br/>
        /// Creates the file object and returns it.
        /// </summary>
        /// <param name="uploadId">
        /// The ID of the multipart upload
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.FileObject> CompleteMultipartUploadAsync(
            global::System.Guid uploadId,

            global::Mixedbread.CompleteMultipartUploadRequest request,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Complete multipart upload<br/>
        /// Complete a multipart upload after all parts have been uploaded.<br/>
        /// Creates the file object and returns it.
        /// </summary>
        /// <param name="uploadId">
        /// The ID of the multipart upload
        /// </param>
        /// <param name="parts">
        /// List of completed parts with their ETags
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.FileObject> CompleteMultipartUploadAsync(
            global::System.Guid uploadId,
            global::System.Collections.Generic.IList<global::Mixedbread.MultipartUploadPart> parts,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}