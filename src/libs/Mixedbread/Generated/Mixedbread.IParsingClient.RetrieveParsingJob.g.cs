#nullable enable

namespace Mixedbread
{
    public partial interface IParsingClient
    {
        /// <summary>
        /// Get parsing job result<br/>
        /// Get detailed information about a specific parse job.<br/>
        /// Args:<br/>
        ///     job_id: The ID of the parse job.<br/>
        /// Returns:<br/>
        ///     Detailed information about the parse job.
        /// </summary>
        /// <param name="jobId">
        /// The ID of the parse job to retrieve
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.ParsingJob> RetrieveParsingJobAsync(
            global::System.Guid jobId,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}