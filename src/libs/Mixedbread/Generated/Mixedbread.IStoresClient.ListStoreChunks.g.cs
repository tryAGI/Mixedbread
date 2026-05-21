#nullable enable

namespace Mixedbread
{
    public partial interface IStoresClient
    {
        /// <summary>
        /// List store chunks by metadata filter and numeric ranking<br/>
        /// List store chunks purely by metadata filters — no embeddings, no semantic similarity, no reranking.<br/>
        /// Unlike `/stores/search`, this endpoint does not require a query and never runs a vector lookup.<br/>
        /// It returns chunks whose file and chunk metadata satisfy `filters`, optionally ordered by a<br/>
        /// numeric metadata field via `sort_by`. Useful for ranked retrieval over numeric attributes<br/>
        /// (e.g. price, BPM) and for reproducing the agentic `filter_chunks` tool externally.<br/>
        /// list-chunks targets a single store and does not support pagination; raise `top_k` to<br/>
        /// retrieve more chunks.<br/>
        /// Args:<br/>
        ///     filter_params: Filter configuration including:<br/>
        ///         - store_identifiers: the single store to filter against<br/>
        ///         - filters: optional metadata filter conditions<br/>
        ///         - file_ids: optional list of file IDs to filter chunks by<br/>
        ///         - sort_by: optional metadata field path, or `(field, ascending)` tuple, for numeric ordering<br/>
        ///         - top_k: number of chunks to return<br/>
        /// Returns:<br/>
        ///     StoreListChunksResponse containing the list of matching chunks.<br/>
        /// Raises:<br/>
        ///     HTTPException (400): If filter parameters are invalid or multiple stores are passed<br/>
        ///     HTTPException (404): If the store is not found
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.StoreListChunksResponse> ListStoreChunksAsync(

            global::Mixedbread.StoreChunkFilterParams request,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List store chunks by metadata filter and numeric ranking<br/>
        /// List store chunks purely by metadata filters — no embeddings, no semantic similarity, no reranking.<br/>
        /// Unlike `/stores/search`, this endpoint does not require a query and never runs a vector lookup.<br/>
        /// It returns chunks whose file and chunk metadata satisfy `filters`, optionally ordered by a<br/>
        /// numeric metadata field via `sort_by`. Useful for ranked retrieval over numeric attributes<br/>
        /// (e.g. price, BPM) and for reproducing the agentic `filter_chunks` tool externally.<br/>
        /// list-chunks targets a single store and does not support pagination; raise `top_k` to<br/>
        /// retrieve more chunks.<br/>
        /// Args:<br/>
        ///     filter_params: Filter configuration including:<br/>
        ///         - store_identifiers: the single store to filter against<br/>
        ///         - filters: optional metadata filter conditions<br/>
        ///         - file_ids: optional list of file IDs to filter chunks by<br/>
        ///         - sort_by: optional metadata field path, or `(field, ascending)` tuple, for numeric ordering<br/>
        ///         - top_k: number of chunks to return<br/>
        /// Returns:<br/>
        ///     StoreListChunksResponse containing the list of matching chunks.<br/>
        /// Raises:<br/>
        ///     HTTPException (400): If filter parameters are invalid or multiple stores are passed<br/>
        ///     HTTPException (404): If the store is not found
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.AutoSDKHttpResponse<global::Mixedbread.StoreListChunksResponse>> ListStoreChunksAsResponseAsync(

            global::Mixedbread.StoreChunkFilterParams request,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List store chunks by metadata filter and numeric ranking<br/>
        /// List store chunks purely by metadata filters — no embeddings, no semantic similarity, no reranking.<br/>
        /// Unlike `/stores/search`, this endpoint does not require a query and never runs a vector lookup.<br/>
        /// It returns chunks whose file and chunk metadata satisfy `filters`, optionally ordered by a<br/>
        /// numeric metadata field via `sort_by`. Useful for ranked retrieval over numeric attributes<br/>
        /// (e.g. price, BPM) and for reproducing the agentic `filter_chunks` tool externally.<br/>
        /// list-chunks targets a single store and does not support pagination; raise `top_k` to<br/>
        /// retrieve more chunks.<br/>
        /// Args:<br/>
        ///     filter_params: Filter configuration including:<br/>
        ///         - store_identifiers: the single store to filter against<br/>
        ///         - filters: optional metadata filter conditions<br/>
        ///         - file_ids: optional list of file IDs to filter chunks by<br/>
        ///         - sort_by: optional metadata field path, or `(field, ascending)` tuple, for numeric ordering<br/>
        ///         - top_k: number of chunks to return<br/>
        /// Returns:<br/>
        ///     StoreListChunksResponse containing the list of matching chunks.<br/>
        /// Raises:<br/>
        ///     HTTPException (400): If filter parameters are invalid or multiple stores are passed<br/>
        ///     HTTPException (404): If the store is not found
        /// </summary>
        /// <param name="storeIdentifiers">
        /// IDs or names of stores
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
        /// <param name="sortBy">
        /// Optional sort applied to the returned chunks. Pass a metadata field path or a tuple of (field path, ascending). Unprefixed dot paths target file metadata; generated_metadata.* targets chunk metadata.
        /// </param>
        /// <param name="searchOptions">
        /// Search configuration options
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.StoreListChunksResponse> ListStoreChunksAsync(
            global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<string, global::System.Guid?>> storeIdentifiers,
            int? topK = default,
            global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>>, object>? filters = default,
            global::Mixedbread.AnyOf<global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>>, global::System.Collections.Generic.IList<global::System.Guid>, object>? fileIds = default,
            global::Mixedbread.AnyOf<string, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<string, bool?>>, object>? sortBy = default,
            global::Mixedbread.StoreChunkSearchOptions? searchOptions = default,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}