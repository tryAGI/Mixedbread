#nullable enable

namespace Mixedbread
{
    public partial interface IExtractionsClient
    {
        /// <summary>
        /// Create a schema<br/>
        /// Create a schema with the provided parameters.<br/>
        /// Args:<br/>
        ///     params: The parameters for creating a schema.<br/>
        /// Returns:<br/>
        ///     The created schema.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.CreatedJsonSchema> CreateSchemaAsync(

            global::Mixedbread.JsonSchemaCreateParams request,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a schema<br/>
        /// Create a schema with the provided parameters.<br/>
        /// Args:<br/>
        ///     params: The parameters for creating a schema.<br/>
        /// Returns:<br/>
        ///     The created schema.
        /// </summary>
        /// <param name="description">
        /// Description of the data to extract
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.CreatedJsonSchema> CreateSchemaAsync(
            string description,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}