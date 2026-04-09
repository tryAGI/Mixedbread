
#nullable enable

namespace Mixedbread
{
    public partial class DataSourcesClient
    {


        private static readonly global::Mixedbread.EndPointSecurityRequirement s_CreateDataSourceSecurityRequirement0 =
            new global::Mixedbread.EndPointSecurityRequirement
            {
                Authorizations = new global::Mixedbread.EndPointAuthorizationRequirement[]
                {                    new global::Mixedbread.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Mixedbread.EndPointSecurityRequirement[] s_CreateDataSourceSecurityRequirements =
            new global::Mixedbread.EndPointSecurityRequirement[]
            {                s_CreateDataSourceSecurityRequirement0,
            };
        partial void PrepareCreateDataSourceArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Mixedbread.AnyOf<global::Mixedbread.NotionDataSourceCreateOrUpdateParams, global::Mixedbread.LinearDataSourceCreateOrUpdateParams> request);
        partial void PrepareCreateDataSourceRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Mixedbread.AnyOf<global::Mixedbread.NotionDataSourceCreateOrUpdateParams, global::Mixedbread.LinearDataSourceCreateOrUpdateParams> request);
        partial void ProcessCreateDataSourceResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateDataSourceResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        public async global::System.Threading.Tasks.Task<global::Mixedbread.DataSource> CreateDataSourceAsync(

            global::Mixedbread.AnyOf<global::Mixedbread.NotionDataSourceCreateOrUpdateParams, global::Mixedbread.LinearDataSourceCreateOrUpdateParams> request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareCreateDataSourceArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Mixedbread.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateDataSourceSecurityRequirements,
                operationName: "CreateDataSourceAsync");

            var __pathBuilder = new global::Mixedbread.PathBuilder(
                path: "/v1/data_sources/",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateDataSourceRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateDataSourceResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Validation Error
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                global::Mixedbread.HTTPValidationError? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::Mixedbread.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                    }
                    else
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_422 = global::Mixedbread.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::Mixedbread.ApiException<global::Mixedbread.HTTPValidationError>(
                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_422,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_422,
                    ResponseObject = __value_422,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessCreateDataSourceResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Mixedbread.DataSource.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Mixedbread.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Mixedbread.DataSource.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::Mixedbread.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
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
        public async global::System.Threading.Tasks.Task<global::Mixedbread.DataSource> CreateDataSourceAsync(
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Mixedbread.AnyOf<global::Mixedbread.NotionDataSourceCreateOrUpdateParams, global::Mixedbread.LinearDataSourceCreateOrUpdateParams>
            {
            };

            return await CreateDataSourceAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}