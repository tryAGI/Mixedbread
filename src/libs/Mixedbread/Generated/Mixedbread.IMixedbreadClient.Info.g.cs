#nullable enable

namespace Mixedbread
{
    public partial interface IMixedbreadClient
    {
        /// <summary>
        /// Info<br/>
        /// Returns service information, including name and version.<br/>
        /// Returns:<br/>
        ///     InfoResponse: A response containing the service name and version.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.InfoResponse> InfoAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}