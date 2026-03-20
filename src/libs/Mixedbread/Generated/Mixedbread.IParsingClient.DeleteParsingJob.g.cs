#nullable enable

namespace Mixedbread
{
    public partial interface IParsingClient
    {
        /// <summary>
        /// Delete a parsing job<br/>
        /// Delete a specific parse job.<br/>
        /// Args:<br/>
        ///     job_id: The ID of the parse job to delete.<br/>
        /// Returns:<br/>
        ///     The deleted parsing job.
        /// </summary>
        /// <param name="jobId">
        /// The ID of the parse job to delete
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.ParsingJobDeleted> DeleteParsingJobAsync(
            global::System.Guid jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}