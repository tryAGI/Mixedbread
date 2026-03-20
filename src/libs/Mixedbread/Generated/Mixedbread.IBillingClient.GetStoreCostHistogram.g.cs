#nullable enable

namespace Mixedbread
{
    public partial interface IBillingClient
    {

        /// <summary>
        /// Get store cost histogram
        /// </summary>
        /// <param name="storeId">
        /// The ID of the store
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.CostHistogramResponse> GetStoreCostHistogramAsync(
            global::System.Guid storeId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}