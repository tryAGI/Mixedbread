#nullable enable

namespace Mixedbread
{
    public partial interface IBucketsClient
    {
        /// <summary>
        /// List buckets<br/>
        /// List the organization's connected buckets.<br/>
        /// Non-secret auth metadata (auth type, role ARN, external ID) is included;<br/>
        /// access-key credentials are never returned.<br/>
        /// Args:<br/>
        ///     options: The pagination options.<br/>
        /// Returns:<br/>
        ///     BucketListResponse: The list of buckets.
        /// </summary>
        /// <param name="limit">
        /// Maximum number of items to return per page (1-100)<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="after">
        /// Cursor for forward pagination - get items after this position. Use last_cursor from previous response.
        /// </param>
        /// <param name="before">
        /// Cursor for backward pagination - get items before this position. Use first_cursor from previous response.
        /// </param>
        /// <param name="includeTotal">
        /// Whether to include total count in response (expensive operation)<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.BucketListResponse> ListBucketsAsync(
            int? limit = default,
            string? after = default,
            string? before = default,
            bool? includeTotal = default,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List buckets<br/>
        /// List the organization's connected buckets.<br/>
        /// Non-secret auth metadata (auth type, role ARN, external ID) is included;<br/>
        /// access-key credentials are never returned.<br/>
        /// Args:<br/>
        ///     options: The pagination options.<br/>
        /// Returns:<br/>
        ///     BucketListResponse: The list of buckets.
        /// </summary>
        /// <param name="limit">
        /// Maximum number of items to return per page (1-100)<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="after">
        /// Cursor for forward pagination - get items after this position. Use last_cursor from previous response.
        /// </param>
        /// <param name="before">
        /// Cursor for backward pagination - get items before this position. Use first_cursor from previous response.
        /// </param>
        /// <param name="includeTotal">
        /// Whether to include total count in response (expensive operation)<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.AutoSDKHttpResponse<global::Mixedbread.BucketListResponse>> ListBucketsAsResponseAsync(
            int? limit = default,
            string? after = default,
            string? before = default,
            bool? includeTotal = default,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}