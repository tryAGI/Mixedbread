#nullable enable

namespace Mixedbread
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Download file<br/>
        /// Download a specific file by its ID.<br/>
        /// Args:<br/>
        ///     file_id: The ID of the file to download.<br/>
        /// Returns:<br/>
        ///     FileStreamResponse: The response containing the file to be downloaded.
        /// </summary>
        /// <param name="fileId">
        /// The ID of the file to download
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> DownloadFileAsync(
            global::System.Guid fileId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}