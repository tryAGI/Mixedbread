#nullable enable

namespace Mixedbread
{
    public partial interface IBillingClient
    {
        /// <summary>
        /// Get parsing cost histogram
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.CostHistogramResponse> GetParsingCostHistogramAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}