#nullable enable

namespace Mixedbread
{
    public partial interface IFilesClient
    {

        /// <summary>
        /// Get multipart upload details<br/>
        /// Get a multipart upload's details with fresh presigned URLs for any parts not yet uploaded.
        /// </summary>
        /// <param name="uploadId">
        /// The ID of the multipart upload
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.MultipartUploadDetailResponse> GetMultipartUploadAsync(
            global::System.Guid uploadId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}