#nullable enable

namespace Mixedbread
{
    public partial interface IApiKeysClient
    {

        /// <summary>
        /// Create API key<br/>
        /// Create a new API key.<br/>
        /// Args:<br/>
        ///     params: The parameters for creating the API key.<br/>
        /// Returns:<br/>
        ///     ApiKeyCreated: The response containing the details of the created API key.
        /// </summary>

        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.ApiKeyCreated> CreateApiKeyAsync(

            global::Mixedbread.ApiKeyCreateParams request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create API key<br/>
        /// Create a new API key.<br/>
        /// Args:<br/>
        ///     params: The parameters for creating the API key.<br/>
        /// Returns:<br/>
        ///     ApiKeyCreated: The response containing the details of the created API key.
        /// </summary>
        /// <param name="name">
        /// A name/description for the API key<br/>
        /// Default Value: API Key
        /// </param>
        /// <param name="scope">
        /// The scope of the API key
        /// </param>
        /// <param name="expiresAt">
        /// Optional expiration datetime
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.ApiKeyCreated> CreateApiKeyAsync(
            string? name = default,
            global::System.Collections.Generic.IList<global::Mixedbread.Scope>? scope = default,
            global::System.DateTime? expiresAt = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}