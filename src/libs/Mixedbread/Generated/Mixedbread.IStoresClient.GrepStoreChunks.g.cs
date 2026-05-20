#nullable enable

namespace Mixedbread
{
    public partial interface IStoresClient
    {
        /// <summary>
        /// Match store chunks against a regular expression<br/>
        /// Match store chunks against a regular expression.<br/>
        /// Unlike `/stores/search`, this performs exact text matching — no embeddings, no<br/>
        /// semantic similarity, no reranking. Use it to find chunks containing a specific<br/>
        /// token, identifier, error code, or literal phrase.<br/>
        /// grep targets a single store and does not support pagination; raise `top_k` to<br/>
        /// retrieve more matches.<br/>
        /// Args:<br/>
        ///     grep_params: Grep configuration including:<br/>
        ///         - pattern: RE2 regular expression matched against chunk text<br/>
        ///         - targets: chunk content groups to match (`text`, `generated`)<br/>
        ///         - case_sensitive: whether the pattern is case-sensitive<br/>
        ///         - store_identifiers: the single store to grep<br/>
        ///         - file_ids: optional list of file IDs to filter chunks by<br/>
        ///         - filters: optional metadata filter conditions<br/>
        ///         - top_k: number of matches to return<br/>
        /// Returns:<br/>
        ///     StoreGrepResponse containing the list of matching chunks.<br/>
        /// Raises:<br/>
        ///     HTTPException (400): If grep parameters are invalid<br/>
        ///     HTTPException (404): If the store is not found
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.StoreGrepResponse> GrepStoreChunksAsync(

            global::Mixedbread.StoreChunkGrepParams request,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Match store chunks against a regular expression<br/>
        /// Match store chunks against a regular expression.<br/>
        /// Unlike `/stores/search`, this performs exact text matching — no embeddings, no<br/>
        /// semantic similarity, no reranking. Use it to find chunks containing a specific<br/>
        /// token, identifier, error code, or literal phrase.<br/>
        /// grep targets a single store and does not support pagination; raise `top_k` to<br/>
        /// retrieve more matches.<br/>
        /// Args:<br/>
        ///     grep_params: Grep configuration including:<br/>
        ///         - pattern: RE2 regular expression matched against chunk text<br/>
        ///         - targets: chunk content groups to match (`text`, `generated`)<br/>
        ///         - case_sensitive: whether the pattern is case-sensitive<br/>
        ///         - store_identifiers: the single store to grep<br/>
        ///         - file_ids: optional list of file IDs to filter chunks by<br/>
        ///         - filters: optional metadata filter conditions<br/>
        ///         - top_k: number of matches to return<br/>
        /// Returns:<br/>
        ///     StoreGrepResponse containing the list of matching chunks.<br/>
        /// Raises:<br/>
        ///     HTTPException (400): If grep parameters are invalid<br/>
        ///     HTTPException (404): If the store is not found
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.AutoSDKHttpResponse<global::Mixedbread.StoreGrepResponse>> GrepStoreChunksAsResponseAsync(

            global::Mixedbread.StoreChunkGrepParams request,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Match store chunks against a regular expression<br/>
        /// Match store chunks against a regular expression.<br/>
        /// Unlike `/stores/search`, this performs exact text matching — no embeddings, no<br/>
        /// semantic similarity, no reranking. Use it to find chunks containing a specific<br/>
        /// token, identifier, error code, or literal phrase.<br/>
        /// grep targets a single store and does not support pagination; raise `top_k` to<br/>
        /// retrieve more matches.<br/>
        /// Args:<br/>
        ///     grep_params: Grep configuration including:<br/>
        ///         - pattern: RE2 regular expression matched against chunk text<br/>
        ///         - targets: chunk content groups to match (`text`, `generated`)<br/>
        ///         - case_sensitive: whether the pattern is case-sensitive<br/>
        ///         - store_identifiers: the single store to grep<br/>
        ///         - file_ids: optional list of file IDs to filter chunks by<br/>
        ///         - filters: optional metadata filter conditions<br/>
        ///         - top_k: number of matches to return<br/>
        /// Returns:<br/>
        ///     StoreGrepResponse containing the list of matching chunks.<br/>
        /// Raises:<br/>
        ///     HTTPException (400): If grep parameters are invalid<br/>
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
        /// <param name="pattern">
        /// Regular expression (RE2 syntax) matched against chunk text
        /// </param>
        /// <param name="targets">
        /// Chunk content groups to match against. `text` matches the original text of text chunks; `generated` matches ingestion-derived fields (transcription, OCR text, summaries).
        /// </param>
        /// <param name="caseSensitive">
        /// Whether the regular expression is case-sensitive<br/>
        /// Default Value: false
        /// </param>
        /// <param name="returnMetadata">
        /// Whether to return file metadata<br/>
        /// Default Value: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.StoreGrepResponse> GrepStoreChunksAsync(
            global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<string, global::System.Guid?>> storeIdentifiers,
            string pattern,
            int? topK = default,
            global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>>, object>? filters = default,
            global::Mixedbread.AnyOf<global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>>, global::System.Collections.Generic.IList<global::System.Guid>, object>? fileIds = default,
            global::System.Collections.Generic.IList<global::Mixedbread.StoreChunkGrepTarget>? targets = default,
            bool? caseSensitive = default,
            bool? returnMetadata = default,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}