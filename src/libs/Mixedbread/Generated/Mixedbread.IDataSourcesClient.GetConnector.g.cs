#nullable enable

namespace Mixedbread
{
    public partial interface IDataSourcesClient
    {

        /// <summary>
        /// Get a connector by ID<br/>
        /// Get a connector by ID.<br/>
        /// Args:<br/>
        ///     data_source_id: The ID of the data source to get a connector for.<br/>
        ///     connector_id: The ID of the connector to get.<br/>
        /// Returns:<br/>
        ///     The connector.
        /// </summary>
        /// <param name="dataSourceId">
        /// The ID of the data source to get a connector for
        /// </param>
        /// <param name="connectorId">
        /// The ID of the connector to get
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.DataSourceConnector> GetConnectorAsync(
            global::System.Guid dataSourceId,
            global::System.Guid connectorId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}