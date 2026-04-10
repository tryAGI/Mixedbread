#nullable enable

namespace Mixedbread
{
    public partial interface IParsingClient
    {
        /// <summary>
        /// Start a parse job<br/>
        /// Start a parse job for the provided file.<br/>
        /// Args:<br/>
        ///     params: The parameters for creating a parse job.<br/>
        /// Returns:<br/>
        ///     The created parsing job.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.ParsingJob> CreateParsingJobAsync(

            global::Mixedbread.ParsingJobCreateParams request,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start a parse job<br/>
        /// Start a parse job for the provided file.<br/>
        /// Args:<br/>
        ///     params: The parameters for creating a parse job.<br/>
        /// Returns:<br/>
        ///     The created parsing job.
        /// </summary>
        /// <param name="fileId">
        /// The ID of the file to parse
        /// </param>
        /// <param name="elementTypes">
        /// The elements to extract from the document
        /// </param>
        /// <param name="chunkingStrategy">
        /// The strategy to use for chunking the content<br/>
        /// Default Value: page
        /// </param>
        /// <param name="returnFormat">
        /// The format of the returned content<br/>
        /// Default Value: markdown
        /// </param>
        /// <param name="mode">
        /// The strategy to use for OCR<br/>
        /// Default Value: high_quality
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.ParsingJob> CreateParsingJobAsync(
            string fileId,
            global::System.Collections.Generic.IList<global::Mixedbread.ElementType>? elementTypes = default,
            global::Mixedbread.ChunkingStrategy? chunkingStrategy = default,
            global::Mixedbread.ReturnFormat? returnFormat = default,
            global::Mixedbread.Mode? mode = default,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}