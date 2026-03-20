#nullable enable

namespace Mixedbread
{
    public partial interface IBillingClient
    {

        /// <summary>
        /// Get billing summary
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.BillingPeriodSummary> GetBillingSummaryAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}