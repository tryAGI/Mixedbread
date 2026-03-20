#nullable enable

namespace Mixedbread
{
    public partial interface IStoresClient
    {

        /// <summary>
        /// Get metadata facets
        /// </summary>

        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.MetadataFacets> GetMetadataFacetsAsync(

            global::Mixedbread.MetadataFacetsParams request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get metadata facets
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
        /// <param name="facets">
        /// Optional list of facets to return. Use dot for nested fields.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.MetadataFacets> GetMetadataFacetsAsync(
            global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<string, global::System.Guid?>> storeIdentifiers,
            string? query = default,
            int? topK = default,
            global::Mixedbread.AnyOf<global::Mixedbread.SearchFilter, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilter, global::Mixedbread.SearchFilterCondition>>, object>? filters = default,
            global::Mixedbread.AnyOf<byte[], global::System.Collections.Generic.IList<global::System.Guid>, object>? fileIds = default,
            global::Mixedbread.StoreChunkSearchOptions? searchOptions = default,
            global::System.Collections.Generic.IList<string>? facets = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}