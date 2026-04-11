
#nullable enable

namespace Mixedbread
{
    public partial class StoresClient
    {

        private static readonly global::Mixedbread.AutoSDKServer[] s_CreateQuestionAnsweringServers = new global::Mixedbread.AutoSDKServer[]
        {            new global::Mixedbread.AutoSDKServer(
                id: "https-api-mixedbread-com",
                name: "mixedbread ai production server",
                url: "https://api.mixedbread.com/",
                description: "mixedbread ai production server"),
            new global::Mixedbread.AutoSDKServer(
                id: "https-api-dev-mixedbread-com",
                name: "mixedbread ai development server",
                url: "https://api.dev.mixedbread.com/",
                description: "mixedbread ai development server"),
            new global::Mixedbread.AutoSDKServer(
                id: "http-127-0-0-1",
                name: "mixedbread local server",
                url: "http://127.0.0.1:8000/",
                description: "mixedbread local server"),
            new global::Mixedbread.AutoSDKServer(
                id: "http-localhost",
                name: "mixedbread local server",
                url: "http://localhost:8000/",
                description: "mixedbread local server"),
        };


        private static readonly global::Mixedbread.EndPointSecurityRequirement s_CreateQuestionAnsweringSecurityRequirement0 =
            new global::Mixedbread.EndPointSecurityRequirement
            {
                Authorizations = new global::Mixedbread.EndPointAuthorizationRequirement[]
                {                    new global::Mixedbread.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Mixedbread.EndPointSecurityRequirement[] s_CreateQuestionAnsweringSecurityRequirements =
            new global::Mixedbread.EndPointSecurityRequirement[]
            {                s_CreateQuestionAnsweringSecurityRequirement0,
            };
        partial void PrepareCreateQuestionAnsweringArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Mixedbread.StoreQAParams request);
        partial void PrepareCreateQuestionAnsweringRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Mixedbread.StoreQAParams request);
        partial void ProcessCreateQuestionAnsweringResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateQuestionAnsweringResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Question answering
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Mixedbread.StoreQAResults> CreateQuestionAnsweringAsync(

            global::Mixedbread.StoreQAParams request,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateQuestionAnsweringArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Mixedbread.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateQuestionAnsweringSecurityRequirements,
                operationName: "CreateQuestionAnsweringAsync");

            using var __timeoutCancellationTokenSource = global::Mixedbread.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Mixedbread.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Mixedbread.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {
                            var __pathBuilder = new global::Mixedbread.PathBuilder(
                                path: "/v1/stores/question-answering",
                                baseUri: ResolveBaseUri(
                                servers: s_CreateQuestionAnsweringServers,
                                defaultBaseUrl: "https://api.mixedbread.com/"));
                            var __path = __pathBuilder.ToString();
                __path = global::Mixedbread.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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
                global::Mixedbread.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareCreateQuestionAnsweringRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Mixedbread.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Mixedbread.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateQuestionAnswering",
                                methodName: "CreateQuestionAnsweringAsync",
                                pathTemplate: "\"/v1/stores/question-answering\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Mixedbread.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Mixedbread.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateQuestionAnswering",
                                methodName: "CreateQuestionAnsweringAsync",
                                pathTemplate: "\"/v1/stores/question-answering\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Mixedbread.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Mixedbread.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::Mixedbread.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Mixedbread.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateQuestionAnswering",
                                methodName: "CreateQuestionAnsweringAsync",
                                pathTemplate: "\"/v1/stores/question-answering\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Mixedbread.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessCreateQuestionAnsweringResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Mixedbread.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Mixedbread.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateQuestionAnswering",
                                methodName: "CreateQuestionAnsweringAsync",
                                pathTemplate: "\"/v1/stores/question-answering\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Mixedbread.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Mixedbread.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateQuestionAnswering",
                                methodName: "CreateQuestionAnsweringAsync",
                                pathTemplate: "\"/v1/stores/question-answering\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Validation Error
                            if ((int)__response.StatusCode == 422)
                            {
                                string? __content_422 = null;
                                global::System.Exception? __exception_422 = null;
                                global::Mixedbread.HTTPValidationError? __value_422 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_422 = global::Mixedbread.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

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

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessCreateQuestionAnsweringResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::Mixedbread.StoreQAResults.FromJson(__content, JsonSerializerContext) ??
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
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    return
                                        await global::Mixedbread.StoreQAResults.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
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
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Question answering
        /// </summary>
        /// <param name="query">
        /// Question to answer. If not provided, the question will be extracted from the passed messages.
        /// </param>
        /// <param name="storeIdentifiers">
        /// IDs or names of stores to search
        /// </param>
        /// <param name="topK">
        /// Number of results to return<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="filters">
        /// Optional filter conditions
        /// </param>
        /// <param name="fileIds">
        /// Optional list of file IDs to filter chunks by (inclusion filter)
        /// </param>
        /// <param name="searchOptions">
        /// Search configuration options
        /// </param>
        /// <param name="stream">
        /// Whether to stream the answer<br/>
        /// Default Value: false
        /// </param>
        /// <param name="instructions">
        /// Additional custom instructions (followed only when not in conflict with existing rules)
        /// </param>
        /// <param name="qaOptions">
        /// Question answering configuration options
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Mixedbread.StoreQAResults> CreateQuestionAnsweringAsync(
            global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<string, global::System.Guid?>> storeIdentifiers,
            string? query = default,
            int? topK = default,
            global::Mixedbread.AnyOf<global::Mixedbread.SearchFilter, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilter, global::Mixedbread.SearchFilterCondition>>, object>? filters = default,
            global::Mixedbread.AnyOf<global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>>, global::System.Collections.Generic.IList<global::System.Guid>, object>? fileIds = default,
            global::Mixedbread.StoreChunkSearchOptions? searchOptions = default,
            bool? stream = default,
            string? instructions = default,
            global::Mixedbread.QuestionAnsweringOptions? qaOptions = default,
            global::Mixedbread.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Mixedbread.StoreQAParams
            {
                Query = query,
                StoreIdentifiers = storeIdentifiers,
                TopK = topK,
                Filters = filters,
                FileIds = fileIds,
                SearchOptions = searchOptions,
                Stream = stream,
                Instructions = instructions,
                QaOptions = qaOptions,
            };

            return await CreateQuestionAnsweringAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}