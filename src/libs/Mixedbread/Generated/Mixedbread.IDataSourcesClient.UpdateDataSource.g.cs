#nullable enable

namespace Mixedbread
{
    public partial interface IDataSourcesClient
    {

        /// <summary>
        /// Update a data source<br/>
        /// Update a data source.<br/>
        /// Args:<br/>
        ///     data_source_id: The ID of the data source to update.<br/>
        ///     params: The data source to update.<br/>
        /// Returns:<br/>
        ///     The updated data source.
        /// </summary>
        /// <param name="dataSourceId">
        /// The ID of the data source to update
        /// </param>

        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.DataSource> UpdateDataSourceAsync(
            global::System.Guid dataSourceId,

            global::Mixedbread.AnyOf<global::Mixedbread.NotionDataSourceCreateOrUpdateParams, global::Mixedbread.LinearDataSourceCreateOrUpdateParams> request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a data source<br/>
        /// Update a data source.<br/>
        /// Args:<br/>
        ///     data_source_id: The ID of the data source to update.<br/>
        ///     params: The data source to update.<br/>
        /// Returns:<br/>
        ///     The updated data source.
        /// </summary>
        /// <param name="dataSourceId">
        /// The ID of the data source to update
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.DataSource> UpdateDataSourceAsync(
            global::System.Guid dataSourceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}