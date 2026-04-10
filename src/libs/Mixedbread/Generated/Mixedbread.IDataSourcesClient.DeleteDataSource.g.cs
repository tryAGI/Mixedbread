#nullable enable

namespace Mixedbread
{
    public partial interface IDataSourcesClient
    {
        /// <summary>
        /// Delete a data source<br/>
        /// Delete a data source.<br/>
        /// Args:<br/>
        ///     data_source_id: The ID of the data source to delete.
        /// </summary>
        /// <param name="dataSourceId">
        /// The ID of the data source to delete
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.DataSourceDeleted> DeleteDataSourceAsync(
            global::System.Guid dataSourceId,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}