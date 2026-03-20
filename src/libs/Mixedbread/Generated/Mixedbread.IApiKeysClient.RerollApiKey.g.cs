#nullable enable

namespace Mixedbread
{
    public partial interface IApiKeysClient
    {

        /// <summary>
        /// Reroll API key<br/>
        /// Reroll the secret for a specific API key by its ID.<br/>
        /// This generates a new secret key, invalidating the old one.<br/>
        /// Args:<br/>
        ///     api_key_id: The ID of the API key to reroll.<br/>
        /// Returns:<br/>
        ///     ApiKeyCreated: The response containing the API key details with the new secret key.
        /// </summary>
        /// <param name="apiKeyId">
        /// The ID of the API key to reroll
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.ApiKeyCreated> RerollApiKeyAsync(
            global::System.Guid apiKeyId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}