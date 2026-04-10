#nullable enable

namespace Mixedbread
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// Reingest all stores<br/>
        /// Reingest all stores across all organizations (admin only).<br/>
        /// This endpoint creates StoreFileReingestionJob for each store.<br/>
        /// Returns:<br/>
        ///     dict: Confirmation message with count of jobs created.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="storeIdentifier"></param>
        /// <param name="statuses">
        /// Statuses of files to reingest
        /// </param>
        /// <param name="billable">
        /// Whether the reingestion is billable to the user<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ReingestAllStoresAsync(
            global::System.Guid organizationId,
            string storeIdentifier,
            global::System.Collections.Generic.IList<global::Mixedbread.VectorStoreFileStatus>? statuses = default,
            bool? billable = default,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}