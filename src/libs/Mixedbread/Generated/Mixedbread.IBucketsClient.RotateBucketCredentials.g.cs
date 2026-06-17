#nullable enable

namespace Mixedbread
{
    public partial interface IBucketsClient
    {
        /// <summary>
        /// Rotate bucket credentials<br/>
        /// Replace a bucket's stored credentials.<br/>
        /// Only available for `access_key` buckets — `assume_role` buckets store no<br/>
        /// credentials (manage access via the role's trust policy instead). The new<br/>
        /// credentials are re-validated against the bucket's existing (immutable) identity<br/>
        /// before they are persisted. The credentials version is bumped so cached storage clients rebuild.<br/>
        /// Args:<br/>
        ///     bucket_id: The ID of the bucket to rotate credentials for.<br/>
        ///     params: The new bucket access credentials.<br/>
        /// Returns:<br/>
        ///     Bucket: The updated bucket. Credentials are never returned.
        /// </summary>
        /// <param name="bucketId">
        /// The ID of the bucket to rotate credentials for
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.Bucket> RotateBucketCredentialsAsync(
            global::System.Guid bucketId,

            global::Mixedbread.BucketRotateCredentialsParams request,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rotate bucket credentials<br/>
        /// Replace a bucket's stored credentials.<br/>
        /// Only available for `access_key` buckets — `assume_role` buckets store no<br/>
        /// credentials (manage access via the role's trust policy instead). The new<br/>
        /// credentials are re-validated against the bucket's existing (immutable) identity<br/>
        /// before they are persisted. The credentials version is bumped so cached storage clients rebuild.<br/>
        /// Args:<br/>
        ///     bucket_id: The ID of the bucket to rotate credentials for.<br/>
        ///     params: The new bucket access credentials.<br/>
        /// Returns:<br/>
        ///     Bucket: The updated bucket. Credentials are never returned.
        /// </summary>
        /// <param name="bucketId">
        /// The ID of the bucket to rotate credentials for
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.AutoSDKHttpResponse<global::Mixedbread.Bucket>> RotateBucketCredentialsAsResponseAsync(
            global::System.Guid bucketId,

            global::Mixedbread.BucketRotateCredentialsParams request,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rotate bucket credentials<br/>
        /// Replace a bucket's stored credentials.<br/>
        /// Only available for `access_key` buckets — `assume_role` buckets store no<br/>
        /// credentials (manage access via the role's trust policy instead). The new<br/>
        /// credentials are re-validated against the bucket's existing (immutable) identity<br/>
        /// before they are persisted. The credentials version is bumped so cached storage clients rebuild.<br/>
        /// Args:<br/>
        ///     bucket_id: The ID of the bucket to rotate credentials for.<br/>
        ///     params: The new bucket access credentials.<br/>
        /// Returns:<br/>
        ///     Bucket: The updated bucket. Credentials are never returned.
        /// </summary>
        /// <param name="bucketId">
        /// The ID of the bucket to rotate credentials for
        /// </param>
        /// <param name="credentials">
        /// New bucket access credentials
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.Bucket> RotateBucketCredentialsAsync(
            global::System.Guid bucketId,
            global::Mixedbread.BucketAccessKeyCredentials credentials,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}