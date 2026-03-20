#nullable enable

namespace Mixedbread
{
    public partial interface IExtractionsClient
    {

        /// <summary>
        /// Start an extraction job<br/>
        /// Start an extraction job for the provided file and schema.<br/>
        /// Args:<br/>
        ///     params: The parameters for creating an extraction job.<br/>
        /// Returns:<br/>
        ///     The created extraction job.
        /// </summary>

        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.ExtractionJob> CreateExtractionJobAsync(

            global::Mixedbread.ExtractJobCreateParams request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Start an extraction job<br/>
        /// Start an extraction job for the provided file and schema.<br/>
        /// Args:<br/>
        ///     params: The parameters for creating an extraction job.<br/>
        /// Returns:<br/>
        ///     The created extraction job.
        /// </summary>
        /// <param name="fileId">
        /// The ID of the file to extract from
        /// </param>
        /// <param name="jsonSchema">
        /// The JSON schema to use for extraction
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.ExtractionJob> CreateExtractionJobAsync(
            string fileId,
            object jsonSchema,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}