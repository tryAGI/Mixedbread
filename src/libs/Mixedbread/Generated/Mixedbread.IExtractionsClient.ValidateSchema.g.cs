#nullable enable

namespace Mixedbread
{
    public partial interface IExtractionsClient
    {
        /// <summary>
        /// Validate a schema<br/>
        /// Validate a schema.<br/>
        /// Args:<br/>
        ///     params: The parameters for validating a schema.<br/>
        /// Returns:<br/>
        ///     The validation result.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.ValidatedJsonSchema> ValidateSchemaAsync(

            global::Mixedbread.JsonSchemaValidateParams request,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Validate a schema<br/>
        /// Validate a schema.<br/>
        /// Args:<br/>
        ///     params: The parameters for validating a schema.<br/>
        /// Returns:<br/>
        ///     The validation result.
        /// </summary>
        /// <param name="jsonSchema">
        /// The JSON schema to validate
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.ValidatedJsonSchema> ValidateSchemaAsync(
            object jsonSchema,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}