#nullable enable

namespace Mixedbread
{
    public partial interface IStoresClient
    {

        /// <summary>
        /// Get a store<br/>
        /// Get a store by ID or name.<br/>
        /// Args:<br/>
        ///     store_identifier: The ID or name of the store to retrieve.<br/>
        /// Returns:<br/>
        ///     Store: The response containing the store details.
        /// </summary>
        /// <param name="storeIdentifier">
        /// The ID or name of the store
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.Store> RetrieveStoreAsync(
            global::Mixedbread.AnyOf<string, global::System.Guid?> storeIdentifier,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}