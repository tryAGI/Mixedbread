
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class MixedbreadClient : global::Mixedbread.IMixedbreadClient, global::System.IDisposable
    {
        /// <summary>
        /// mixedbread ai production server
        /// </summary>
        public const string DefaultBaseUrl = "https://api.mixedbread.com";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::Mixedbread.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif
        /// <summary>
        /// 
        /// </summary>
        #pragma warning disable CS0618 // Type or member is obsolete
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::Mixedbread.JsonConverters.AudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter(),
                    new global::Mixedbread.JsonConverters.AudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::Mixedbread.JsonConverters.ChunkingStrategyJsonConverter(),
                    new global::Mixedbread.JsonConverters.ChunkingStrategyNullableJsonConverter(),
                    new global::Mixedbread.JsonConverters.ConditionOperatorJsonConverter(),
                    new global::Mixedbread.JsonConverters.ConditionOperatorNullableJsonConverter(),
                    new global::Mixedbread.JsonConverters.DataSourceAuthParamsVariant1DiscriminatorTypeJsonConverter(),
                    new global::Mixedbread.JsonConverters.DataSourceAuthParamsVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::Mixedbread.JsonConverters.DataSourceTypeJsonConverter(),
                    new global::Mixedbread.JsonConverters.DataSourceTypeNullableJsonConverter(),
                    new global::Mixedbread.JsonConverters.ElementTypeJsonConverter(),
                    new global::Mixedbread.JsonConverters.ElementTypeNullableJsonConverter(),
                    new global::Mixedbread.JsonConverters.EncodingFormat3JsonConverter(),
                    new global::Mixedbread.JsonConverters.EncodingFormat3NullableJsonConverter(),
                    new global::Mixedbread.JsonConverters.ImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter(),
                    new global::Mixedbread.JsonConverters.ImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::Mixedbread.JsonConverters.LinearDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorTypeJsonConverter(),
                    new global::Mixedbread.JsonConverters.LinearDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::Mixedbread.JsonConverters.ModeJsonConverter(),
                    new global::Mixedbread.JsonConverters.ModeNullableJsonConverter(),
                    new global::Mixedbread.JsonConverters.MultiModalQueryVariant2DiscriminatorTypeJsonConverter(),
                    new global::Mixedbread.JsonConverters.MultiModalQueryVariant2DiscriminatorTypeNullableJsonConverter(),
                    new global::Mixedbread.JsonConverters.NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorTypeJsonConverter(),
                    new global::Mixedbread.JsonConverters.NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::Mixedbread.JsonConverters.ParsingJobStatusJsonConverter(),
                    new global::Mixedbread.JsonConverters.ParsingJobStatusNullableJsonConverter(),
                    new global::Mixedbread.JsonConverters.RegexFlagJsonConverter(),
                    new global::Mixedbread.JsonConverters.RegexFlagNullableJsonConverter(),
                    new global::Mixedbread.JsonConverters.ReturnFormatJsonConverter(),
                    new global::Mixedbread.JsonConverters.ReturnFormatNullableJsonConverter(),
                    new global::Mixedbread.JsonConverters.ScopeMethodJsonConverter(),
                    new global::Mixedbread.JsonConverters.ScopeMethodNullableJsonConverter(),
                    new global::Mixedbread.JsonConverters.ScoredStoreFileChunksVariant1ItemDiscriminatorTypeJsonConverter(),
                    new global::Mixedbread.JsonConverters.ScoredStoreFileChunksVariant1ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::Mixedbread.JsonConverters.ScoredVectorStoreFileChunksVariant1ItemDiscriminatorTypeJsonConverter(),
                    new global::Mixedbread.JsonConverters.ScoredVectorStoreFileChunksVariant1ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::Mixedbread.JsonConverters.StoreEventHistogramBucketTypeJsonConverter(),
                    new global::Mixedbread.JsonConverters.StoreEventHistogramBucketTypeNullableJsonConverter(),
                    new global::Mixedbread.JsonConverters.StoreEventListResponseDataItemDiscriminatorTypeJsonConverter(),
                    new global::Mixedbread.JsonConverters.StoreEventListResponseDataItemDiscriminatorTypeNullableJsonConverter(),
                    new global::Mixedbread.JsonConverters.StoreFileChunksVariant1ItemDiscriminatorTypeJsonConverter(),
                    new global::Mixedbread.JsonConverters.StoreFileChunksVariant1ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::Mixedbread.JsonConverters.StoreFileParsingStrategyJsonConverter(),
                    new global::Mixedbread.JsonConverters.StoreFileParsingStrategyNullableJsonConverter(),
                    new global::Mixedbread.JsonConverters.StoreFileStatusJsonConverter(),
                    new global::Mixedbread.JsonConverters.StoreFileStatusNullableJsonConverter(),
                    new global::Mixedbread.JsonConverters.StoreQAResultsSourceDiscriminatorTypeJsonConverter(),
                    new global::Mixedbread.JsonConverters.StoreQAResultsSourceDiscriminatorTypeNullableJsonConverter(),
                    new global::Mixedbread.JsonConverters.StoreSearchResponseDataItemDiscriminatorTypeJsonConverter(),
                    new global::Mixedbread.JsonConverters.StoreSearchResponseDataItemDiscriminatorTypeNullableJsonConverter(),
                    new global::Mixedbread.JsonConverters.StoreStatusJsonConverter(),
                    new global::Mixedbread.JsonConverters.StoreStatusNullableJsonConverter(),
                    new global::Mixedbread.JsonConverters.SyncStatusJsonConverter(),
                    new global::Mixedbread.JsonConverters.SyncStatusNullableJsonConverter(),
                    new global::Mixedbread.JsonConverters.TextInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter(),
                    new global::Mixedbread.JsonConverters.TextInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::Mixedbread.JsonConverters.VectorStoreFileChunksVariant1ItemDiscriminatorTypeJsonConverter(),
                    new global::Mixedbread.JsonConverters.VectorStoreFileChunksVariant1ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::Mixedbread.JsonConverters.VectorStoreFileStatusJsonConverter(),
                    new global::Mixedbread.JsonConverters.VectorStoreFileStatusNullableJsonConverter(),
                    new global::Mixedbread.JsonConverters.VectorStoreQAResultsSourceDiscriminatorTypeJsonConverter(),
                    new global::Mixedbread.JsonConverters.VectorStoreQAResultsSourceDiscriminatorTypeNullableJsonConverter(),
                    new global::Mixedbread.JsonConverters.VectorStoreSearchResponseDataItemDiscriminatorTypeJsonConverter(),
                    new global::Mixedbread.JsonConverters.VectorStoreSearchResponseDataItemDiscriminatorTypeNullableJsonConverter(),
                    new global::Mixedbread.JsonConverters.VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter(),
                    new global::Mixedbread.JsonConverters.VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter(),
                    new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter(),
                    new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter(),
                    new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter(),
                    new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleCreateParamsRuleDiscriminatorTypeJsonConverter(),
                    new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleCreateParamsRuleDiscriminatorTypeNullableJsonConverter(),
                    new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleResponseRuleDiscriminatorTypeJsonConverter(),
                    new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleResponseRuleDiscriminatorTypeNullableJsonConverter(),
                    new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorTypeJsonConverter(),
                    new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorTypeNullableJsonConverter(),
                    new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeletedDeletedRuleDiscriminatorTypeJsonConverter(),
                    new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeletedDeletedRuleDiscriminatorTypeNullableJsonConverter(),
                    new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorTypeJsonConverter(),
                    new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleCreateParamsRuleDiscriminatorTypeJsonConverter(),
                    new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleCreateParamsRuleDiscriminatorTypeNullableJsonConverter(),
                    new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleResponseRuleDiscriminatorTypeJsonConverter(),
                    new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleResponseRuleDiscriminatorTypeNullableJsonConverter(),
                    new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorTypeJsonConverter(),
                    new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorTypeNullableJsonConverter(),
                    new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeletedDeletedRuleDiscriminatorTypeJsonConverter(),
                    new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeletedDeletedRuleDiscriminatorTypeNullableJsonConverter(),
                    new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorTypeJsonConverter(),
                    new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::Mixedbread.JsonConverters.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter(),
                    new global::Mixedbread.JsonConverters.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::Mixedbread.JsonConverters.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter(),
                    new global::Mixedbread.JsonConverters.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::Mixedbread.JsonConverters.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter(),
                    new global::Mixedbread.JsonConverters.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::Mixedbread.JsonConverters.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter(),
                    new global::Mixedbread.JsonConverters.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::Mixedbread.JsonConverters.ListStoreEventsEventTypeJsonConverter(),
                    new global::Mixedbread.JsonConverters.ListStoreEventsEventTypeNullableJsonConverter(),
                    new global::Mixedbread.JsonConverters.GeneratedMetadataVariant1JsonConverter(),
                    new global::Mixedbread.JsonConverters.AuthParamsVariant1JsonConverter(),
                    new global::Mixedbread.JsonConverters.EmbeddingItemJsonConverter(),
                    new global::Mixedbread.JsonConverters.GeneratedMetadataVariant12JsonConverter(),
                    new global::Mixedbread.JsonConverters.AuthParamsVariant12JsonConverter(),
                    new global::Mixedbread.JsonConverters.MultiModalQueryJsonConverter(),
                    new global::Mixedbread.JsonConverters.MultiModalQueryVariant2JsonConverter(),
                    new global::Mixedbread.JsonConverters.AuthParamsVariant13JsonConverter(),
                    new global::Mixedbread.JsonConverters.ChunksVariant1ItemJsonConverter(),
                    new global::Mixedbread.JsonConverters.ChunksVariant1Item2JsonConverter(),
                    new global::Mixedbread.JsonConverters.DataItemJsonConverter(),
                    new global::Mixedbread.JsonConverters.ChunksVariant1Item3JsonConverter(),
                    new global::Mixedbread.JsonConverters.SourcesItemJsonConverter(),
                    new global::Mixedbread.JsonConverters.DataItem2JsonConverter(),
                    new global::Mixedbread.JsonConverters.GeneratedMetadataVariant13JsonConverter(),
                    new global::Mixedbread.JsonConverters.ChunksVariant1Item4JsonConverter(),
                    new global::Mixedbread.JsonConverters.SourcesItem2JsonConverter(),
                    new global::Mixedbread.JsonConverters.DataItem3JsonConverter(),
                    new global::Mixedbread.JsonConverters.GeneratedMetadataVariant14JsonConverter(),
                    new global::Mixedbread.JsonConverters.GeneratedMetadataVariant15JsonConverter(),
                    new global::Mixedbread.JsonConverters.GeneratedMetadataVariant16JsonConverter(),
                    new global::Mixedbread.JsonConverters.GeneratedMetadataVariant17JsonConverter(),
                    new global::Mixedbread.JsonConverters.GeneratedMetadataVariant18JsonConverter(),
                    new global::Mixedbread.JsonConverters.RulesItemJsonConverter(),
                    new global::Mixedbread.JsonConverters.RulesItem2JsonConverter(),
                    new global::Mixedbread.JsonConverters.RuleJsonConverter(),
                    new global::Mixedbread.JsonConverters.DeletedRuleJsonConverter(),
                    new global::Mixedbread.JsonConverters.RulesVariant1ItemJsonConverter(),
                    new global::Mixedbread.JsonConverters.RulesItem3JsonConverter(),
                    new global::Mixedbread.JsonConverters.RulesItem4JsonConverter(),
                    new global::Mixedbread.JsonConverters.Rule2JsonConverter(),
                    new global::Mixedbread.JsonConverters.DeletedRule2JsonConverter(),
                    new global::Mixedbread.JsonConverters.RulesVariant1Item2JsonConverter(),
                    new global::Mixedbread.JsonConverters.GeneratedMetadataVariant19JsonConverter(),
                    new global::Mixedbread.JsonConverters.GeneratedMetadataVariant110JsonConverter(),
                    new global::Mixedbread.JsonConverters.GeneratedMetadataVariant111JsonConverter(),
                    new global::Mixedbread.JsonConverters.GeneratedMetadataVariant112JsonConverter(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<bool?, global::System.Collections.Generic.IList<string>>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<int?, string, object>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<int?, string, object>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.EncodingFormat3?, global::System.Collections.Generic.IList<global::Mixedbread.EncodingFormat3>>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Mixedbread.Embedding>, global::System.Collections.Generic.IList<global::Mixedbread.MultiEncodingEmbedding>>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.EncodingFormat3?, global::System.Collections.Generic.IList<global::Mixedbread.EncodingFormat3>>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.TextInput, global::Mixedbread.ImageUrlInput2>>>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.TextInput, global::Mixedbread.ImageUrlInput2>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilter, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilter, global::Mixedbread.SearchFilterCondition>>, object>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilter, global::Mixedbread.SearchFilterCondition>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilter, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilter, global::Mixedbread.SearchFilterCondition>>, object>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilter, global::Mixedbread.SearchFilterCondition>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<byte[], global::System.Collections.Generic.IList<global::System.Guid>, object>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<bool?, global::System.Collections.Generic.IList<string>>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<object>>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?, object>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilter, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilter, global::Mixedbread.SearchFilterCondition>>, object>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilter, global::Mixedbread.SearchFilterCondition>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilter, global::Mixedbread.SearchFilterCondition>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilter, global::Mixedbread.SearchFilterCondition>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilter, global::Mixedbread.SearchFilterCondition>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<bool?, global::Mixedbread.RerankConfig, object>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<bool?, global::Mixedbread.AgenticSearchConfig, object>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilter, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilter, global::Mixedbread.SearchFilterCondition>>, object>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilter, global::Mixedbread.SearchFilterCondition>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<byte[], global::System.Collections.Generic.IList<global::System.Guid>, object>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<bool?, global::Mixedbread.ContextualizationConfig>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<bool?, global::Mixedbread.RerankConfig, object>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<bool?, global::Mixedbread.AgenticSearchConfig, object>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilter, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilter, global::Mixedbread.SearchFilterCondition>>, object>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilter, global::Mixedbread.SearchFilterCondition>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<byte[], global::System.Collections.Generic.IList<global::System.Guid>, object>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilter, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilter, global::Mixedbread.SearchFilterCondition>>, object>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilter, global::Mixedbread.SearchFilterCondition>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<byte[], global::System.Collections.Generic.IList<global::System.Guid>, object>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, int?>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<bool?, global::Mixedbread.RerankConfig, object>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<bool?, global::Mixedbread.AgenticSearchConfig, object>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilter, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilter, global::Mixedbread.SearchFilterCondition>>, object>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilter, global::Mixedbread.SearchFilterCondition>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<byte[], global::System.Collections.Generic.IList<global::System.Guid>, object>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<bool?, global::Mixedbread.RerankConfig, object>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<bool?, global::Mixedbread.AgenticSearchConfig, object>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilter, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilter, global::Mixedbread.SearchFilterCondition>>, object>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilter, global::Mixedbread.SearchFilterCondition>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<byte[], global::System.Collections.Generic.IList<global::System.Guid>, object>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilter, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilter, global::Mixedbread.SearchFilterCondition>>, object>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilter, global::Mixedbread.SearchFilterCondition>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<byte[], global::System.Collections.Generic.IList<global::System.Guid>, object>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.NotionDataSourceCreateOrUpdateParams, global::Mixedbread.LinearDataSourceCreateOrUpdateParams>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.NotionDataSourceCreateOrUpdateParams, global::Mixedbread.LinearDataSourceCreateOrUpdateParams>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<bool?, global::System.Collections.Generic.IList<int>>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::Mixedbread.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// 
        /// </summary>
        public AdminClient Admin => new AdminClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ApiKeysClient ApiKeys => new ApiKeysClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public BillingClient Billing => new BillingClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public CompletionsClient Completions => new CompletionsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DataSourcesClient DataSources => new DataSourcesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ExtractionsClient Extractions => new ExtractionsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public FilesClient Files => new FilesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ParsingClient Parsing => new ParsingClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SchemasClient Schemas => new SchemasClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public StoresClient Stores => new StoresClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Creates a new instance of the MixedbreadClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public MixedbreadClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::Mixedbread.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true)
        {
            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::Mixedbread.EndPointAuthorization>();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}