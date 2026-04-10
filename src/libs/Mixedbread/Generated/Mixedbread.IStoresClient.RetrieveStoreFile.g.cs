#nullable enable

namespace Mixedbread
{
    public partial interface IStoresClient
    {
        /// <summary>
        /// Get store file<br/>
        /// Get a file from a store.<br/>
        /// Args:<br/>
        ///     store_identifier: The ID or name of the store.<br/>
        ///     file_id: The ID or name of the file.<br/>
        ///     options: Get file options.<br/>
        /// Returns:<br/>
        ///     VectorStoreFile: The file details.
        /// </summary>
        /// <param name="storeIdentifier">
        /// The ID or name of the store
        /// </param>
        /// <param name="fileIdentifier">
        /// The ID or name of the file
        /// </param>
        /// <param name="returnChunks">
        /// Whether to return the chunks for the file. If a list of integers is provided, only the chunks at the specified indices will be returned.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.StoreFile> RetrieveStoreFileAsync(
            global::Mixedbread.AnyOf<string, global::System.Guid?> storeIdentifier,
            global::Mixedbread.AnyOf<string, global::System.Guid?> fileIdentifier,
            global::Mixedbread.AnyOf<bool?, global::System.Collections.Generic.IList<int>>? returnChunks = default,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}