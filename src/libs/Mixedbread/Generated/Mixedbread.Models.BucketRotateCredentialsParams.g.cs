
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Parameters for rotating a bucket's credentials.
    /// </summary>
    public sealed partial class BucketRotateCredentialsParams
    {
        /// <summary>
        /// New bucket access credentials
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentials")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mixedbread.BucketAccessKeyCredentials Credentials { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BucketRotateCredentialsParams" /> class.
        /// </summary>
        /// <param name="credentials">
        /// New bucket access credentials
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BucketRotateCredentialsParams(
            global::Mixedbread.BucketAccessKeyCredentials credentials)
        {
            this.Credentials = credentials ?? throw new global::System.ArgumentNullException(nameof(credentials));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BucketRotateCredentialsParams" /> class.
        /// </summary>
        public BucketRotateCredentialsParams()
        {
        }

    }
}