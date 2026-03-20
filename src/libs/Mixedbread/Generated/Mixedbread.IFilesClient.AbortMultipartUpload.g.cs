#nullable enable

namespace Mixedbread
{
    public partial interface IFilesClient
    {

        /// <summary>
        /// Abort multipart upload<br/>
        /// Abort a multipart upload and clean up any uploaded parts.
        /// </summary>
        /// <param name="uploadId">
        /// The ID of the multipart upload to abort
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.FileDeleted> AbortMultipartUploadAsync(
            global::System.Guid uploadId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}