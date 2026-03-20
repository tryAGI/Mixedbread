#nullable enable

namespace Mixedbread
{
    public partial interface IDataSourcesClient
    {

        /// <summary>
        /// Create a new data source<br/>
        /// Create a new data source.<br/>
        /// Args:<br/>
        ///     params: The data source to create.<br/>
        /// Returns:<br/>
        ///     The created data source.
        /// </summary>

        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.DataSource> CreateDataSourceAsync(

            global::Mixedbread.AnyOf<global::Mixedbread.NotionDataSourceCreateOrUpdateParams, global::Mixedbread.LinearDataSourceCreateOrUpdateParams> request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a new data source<br/>
        /// Create a new data source.<br/>
        /// Args:<br/>
        ///     params: The data source to create.<br/>
        /// Returns:<br/>
        ///     The created data source.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.DataSource> CreateDataSourceAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}