#nullable enable

namespace Mixedbread
{
    public partial interface IExtractionsClient
    {
        /// <summary>
        /// Extract content from a string<br/>
        /// Extract content from a string using the provided schema.<br/>
        /// Args:<br/>
        ///     params: The parameters for extracting content from a string.<br/>
        /// Returns:<br/>
        ///     The extracted content.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.ExtractionResult> ExtractContentAsync(

            global::Mixedbread.ExtractContentCreateParams request,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Extract content from a string<br/>
        /// Extract content from a string using the provided schema.<br/>
        /// Args:<br/>
        ///     params: The parameters for extracting content from a string.<br/>
        /// Returns:<br/>
        ///     The extracted content.
        /// </summary>
        /// <param name="content">
        /// The content to extract from
        /// </param>
        /// <param name="jsonSchema">
        /// The JSON schema to use for extraction
        /// </param>
        /// <param name="instructions">
        /// Additional instructions for the extraction
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.ExtractionResult> ExtractContentAsync(
            global::Mixedbread.AnyOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.TextInput, global::Mixedbread.ImageUrlInput2>>> content,
            object jsonSchema,
            string? instructions = default,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}