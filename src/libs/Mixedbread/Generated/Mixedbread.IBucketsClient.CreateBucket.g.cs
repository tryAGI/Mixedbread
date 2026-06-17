#nullable enable

namespace Mixedbread
{
    public partial interface IBucketsClient
    {
        /// <summary>
        /// Add a bucket<br/>
        /// Attach a customer-owned storage bucket to the organization.<br/>
        /// Access is validated against the bucket (reachability + write/delete probe) before<br/>
        /// anything is stored, so an unreachable or unwritable bucket is rejected here.<br/>
        /// With `assume_role` credentials (recommended for AWS) the probe performs the actual<br/>
        /// STS AssumeRole and nothing secret is persisted — only the role ARN and the<br/>
        /// organization's external ID. With `access_key` credentials (S3-compatible<br/>
        /// endpoints) the keys are encrypted before they are stored.<br/>
        /// Args:<br/>
        ///     params: The bucket connection details and credentials.<br/>
        /// Returns:<br/>
        ///     Bucket: The attached bucket. Credentials are never returned.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.Bucket> CreateBucketAsync(

            global::Mixedbread.BucketCreateParams request,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add a bucket<br/>
        /// Attach a customer-owned storage bucket to the organization.<br/>
        /// Access is validated against the bucket (reachability + write/delete probe) before<br/>
        /// anything is stored, so an unreachable or unwritable bucket is rejected here.<br/>
        /// With `assume_role` credentials (recommended for AWS) the probe performs the actual<br/>
        /// STS AssumeRole and nothing secret is persisted — only the role ARN and the<br/>
        /// organization's external ID. With `access_key` credentials (S3-compatible<br/>
        /// endpoints) the keys are encrypted before they are stored.<br/>
        /// Args:<br/>
        ///     params: The bucket connection details and credentials.<br/>
        /// Returns:<br/>
        ///     Bucket: The attached bucket. Credentials are never returned.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.AutoSDKHttpResponse<global::Mixedbread.Bucket>> CreateBucketAsResponseAsync(

            global::Mixedbread.BucketCreateParams request,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add a bucket<br/>
        /// Attach a customer-owned storage bucket to the organization.<br/>
        /// Access is validated against the bucket (reachability + write/delete probe) before<br/>
        /// anything is stored, so an unreachable or unwritable bucket is rejected here.<br/>
        /// With `assume_role` credentials (recommended for AWS) the probe performs the actual<br/>
        /// STS AssumeRole and nothing secret is persisted — only the role ARN and the<br/>
        /// organization's external ID. With `access_key` credentials (S3-compatible<br/>
        /// endpoints) the keys are encrypted before they are stored.<br/>
        /// Args:<br/>
        ///     params: The bucket connection details and credentials.<br/>
        /// Returns:<br/>
        ///     Bucket: The attached bucket. Credentials are never returned.
        /// </summary>
        /// <param name="name">
        /// Display name for the bucket
        /// </param>
        /// <param name="provider">
        /// Object storage provider<br/>
        /// Default Value: aws_s3
        /// </param>
        /// <param name="bucket">
        /// The bucket name
        /// </param>
        /// <param name="region">
        /// The bucket region
        /// </param>
        /// <param name="endpointUrl">
        /// Custom S3-compatible endpoint (omit for AWS)
        /// </param>
        /// <param name="prefix">
        /// Key prefix within the bucket
        /// </param>
        /// <param name="sseKmsKeyId">
        /// KMS key id/ARN to encrypt writes with (SSE-KMS); omit for the bucket's default encryption
        /// </param>
        /// <param name="credentials">
        /// How Mixedbread authenticates against the bucket. `assume_role` is the recommended default for AWS; `access_key` is for S3-compatible providers with a custom endpoint.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.Bucket> CreateBucketAsync(
            string name,
            string bucket,
            global::Mixedbread.Credentials credentials,
            string? provider = default,
            string? region = default,
            string? endpointUrl = default,
            string? prefix = default,
            string? sseKmsKeyId = default,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}