#nullable enable

namespace Mixedbread
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// Delete API key<br/>
        /// Delete a specific API key by its ID.<br/>
        /// Args:<br/>
        ///     api_key_id: The ID of the API key to delete.<br/>
        /// Returns:<br/>
        ///     ApiKeyDeleted: The response containing the details of the deleted API key.
        /// </summary>
        /// <param name="apiKeyId">
        /// The ID of the API key to delete
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.ApiKeyDeleted> DeleteApiKeyAsync(
            global::System.Guid apiKeyId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}