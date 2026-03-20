#nullable enable

namespace Mixedbread
{
    public partial interface IBillingClient
    {

        /// <summary>
        /// List store cost information
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.StoreCostListResponse> ListStoreCostInfoAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}