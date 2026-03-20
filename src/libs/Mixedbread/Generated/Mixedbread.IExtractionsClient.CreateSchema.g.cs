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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.CreatedJsonSchema> CreateSchemaAsync(

            global::Mixedbread.JsonSchemaCreateParams request,
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.CreatedJsonSchema> CreateSchemaAsync(
            string description,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}