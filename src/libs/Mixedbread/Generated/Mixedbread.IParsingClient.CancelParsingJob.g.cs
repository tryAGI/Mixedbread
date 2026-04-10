#nullable enable

namespace Mixedbread
{
    public partial interface IParsingClient
    {
        /// <summary>
        /// Cancel a parsing job<br/>
        /// Cancel a specific parse job.<br/>
        /// Args:<br/>
        ///     job_id: The ID of the parse job to cancel.<br/>
        /// Returns:<br/>
        ///     The cancelled parsing job.
        /// </summary>
        /// <param name="jobId">
        /// The ID of the parse job to cancel
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.ParsingJob> CancelParsingJobAsync(
            global::System.Guid jobId,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}