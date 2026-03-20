#nullable enable

namespace Mixedbread
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Upload file<br/>
        /// Upload a new file.<br/>
        /// Args:<br/>
        ///     file: The file to upload.<br/>
        /// Returns:<br/>
        ///     FileResponse: The response containing the details of the uploaded file.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.FileObject> CreateFileAsync(

            global::Mixedbread.BodyCreateFile request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload file<br/>
        /// Upload a new file.<br/>
        /// Args:<br/>
        ///     file: The file to upload.<br/>
        /// Returns:<br/>
        ///     FileResponse: The response containing the details of the uploaded file.
        /// </summary>
        /// <param name="file">
        /// The file to upload
        /// </param>
        /// <param name="filename">
        /// The file to upload
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.FileObject> CreateFileAsync(
            byte[] file,
            string filename,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}