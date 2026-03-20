#nullable enable

namespace Mixedbread
{
    public partial interface IStoresClient
    {

        /// <summary>
        /// Search store files<br/>
        /// Search for files within a store based on semantic similarity.<br/>
        /// Args:<br/>
        ///     store_identifier: The ID or name of the store to search within<br/>
        ///     search_params: Search configuration including query text, pagination, and filters<br/>
        /// Returns:<br/>
        ///     StoreFileSearchResponse: List of matching files with relevance scores
        /// </summary>

        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.StoreFileSearchResponse> SearchStoreFilesAsync(

            global::Mixedbread.StoreFileSearchParams request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Search store files<br/>
        /// Search for files within a store based on semantic similarity.<br/>
        /// Args:<br/>
        ///     store_identifier: The ID or name of the store to search within<br/>
        ///     search_params: Search configuration including query text, pagination, and filters<br/>
        /// Returns:<br/>
        ///     StoreFileSearchResponse: List of matching files with relevance scores
        /// </summary>
        /// <param name="query">
        /// Search query text
        /// </param>
        /// <param name="storeIdentifiers">
        /// IDs or names of stores to search
        /// </param>
        /// <param name="topK">
        /// Number of results to return<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="filters">
        /// Optional filter conditions
        /// </param>
        /// <param name="fileIds">
        /// Optional list of file IDs to filter chunks by (inclusion filter)
        /// </param>
        /// <param name="searchOptions">
        /// Search configuration options
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.StoreFileSearchResponse> SearchStoreFilesAsync(
            global::Mixedbread.MultiModalQuery query,
            global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<string, global::System.Guid?>> storeIdentifiers,
            int? topK = default,
            global::Mixedbread.AnyOf<global::Mixedbread.SearchFilter, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilter, global::Mixedbread.SearchFilterCondition>>, object>? filters = default,
            global::Mixedbread.AnyOf<byte[], global::System.Collections.Generic.IList<global::System.Guid>, object>? fileIds = default,
            global::Mixedbread.StoreFileSearchOptions? searchOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}