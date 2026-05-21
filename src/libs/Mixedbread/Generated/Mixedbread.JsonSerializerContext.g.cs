
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Mixedbread
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Mixedbread.JsonConverters.AgenticSearchConfigMediaContentJsonConverter),

            typeof(global::Mixedbread.JsonConverters.AgenticSearchConfigMediaContentNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.AgenticToolCallToolTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.AgenticToolCallToolTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.AudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.AudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.ChunkingStrategyJsonConverter),

            typeof(global::Mixedbread.JsonConverters.ChunkingStrategyNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.ConditionOperatorJsonConverter),

            typeof(global::Mixedbread.JsonConverters.ConditionOperatorNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.DataSourceAuthParamsVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.DataSourceAuthParamsVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.DataSourceTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.DataSourceTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.ElementTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.ElementTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.EncodingFormat3JsonConverter),

            typeof(global::Mixedbread.JsonConverters.EncodingFormat3NullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.ImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.ImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.LinearDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.LinearDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.ModeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.ModeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MultiModalQueryVariant2DiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MultiModalQueryVariant2DiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.ParsingJobStatusJsonConverter),

            typeof(global::Mixedbread.JsonConverters.ParsingJobStatusNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.QueryEnhanceQueryItemFilterModeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.QueryEnhanceQueryItemFilterModeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.QueryEnhanceResultsItemDiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.QueryEnhanceResultsItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.QueryEnhanceSortItemFilterModeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.QueryEnhanceSortItemFilterModeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.QueryEnhanceSortItemDirectionJsonConverter),

            typeof(global::Mixedbread.JsonConverters.QueryEnhanceSortItemDirectionNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.RegexFlagJsonConverter),

            typeof(global::Mixedbread.JsonConverters.RegexFlagNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.ReturnFormatJsonConverter),

            typeof(global::Mixedbread.JsonConverters.ReturnFormatNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.ScopeMethodJsonConverter),

            typeof(global::Mixedbread.JsonConverters.ScopeMethodNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreChunkGrepTargetJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreChunkGrepTargetNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreEventHistogramBucketTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreEventHistogramBucketTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreEventHistogramParamsEventTypesVariant1ItemJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreEventHistogramParamsEventTypesVariant1ItemNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreEventListResponseDataItemDiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreEventListResponseDataItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreFileChunksVariant1ItemDiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreFileChunksVariant1ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreFileParsingStrategyJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreFileParsingStrategyNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreFileStatusJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreFileStatusNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreGrepResponseDataItemDiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreGrepResponseDataItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreListChunksResponseDataItemDiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreListChunksResponseDataItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreQAResultsSourceDiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreQAResultsSourceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreSearchEventRewriteRankDirection2JsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreSearchEventRewriteRankDirection2NullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreSearchEventRewriteRankMode2JsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreSearchEventRewriteRankMode2NullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreSearchEventResultFirstStageSource2JsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreSearchEventResultFirstStageSource2NullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreSearchResponseDataItemDiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreSearchResponseDataItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreStatusJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreStatusNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.SyncStatusJsonConverter),

            typeof(global::Mixedbread.JsonConverters.SyncStatusNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.TextInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.TextInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.VectorStoreFileChunksVariant1ItemDiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.VectorStoreFileChunksVariant1ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.VectorStoreFileStatusJsonConverter),

            typeof(global::Mixedbread.JsonConverters.VectorStoreFileStatusNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.VectorStoreQAResultsSourceDiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.VectorStoreQAResultsSourceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.VectorStoreSearchResponseDataItemDiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.VectorStoreSearchResponseDataItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleCreateParamsRuleDiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleCreateParamsRuleDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleResponseRuleDiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleResponseRuleDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeletedDeletedRuleDiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeletedDeletedRuleDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleCreateParamsRuleDiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleCreateParamsRuleDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleResponseRuleDiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleResponseRuleDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeletedDeletedRuleDiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeletedDeletedRuleDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.ListStoreEventsEventTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.ListStoreEventsEventTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.GeneratedMetadataVariant1JsonConverter),

            typeof(global::Mixedbread.JsonConverters.AuthParamsVariant1JsonConverter),

            typeof(global::Mixedbread.JsonConverters.EmbeddingItemJsonConverter),

            typeof(global::Mixedbread.JsonConverters.GeneratedMetadataVariant12JsonConverter),

            typeof(global::Mixedbread.JsonConverters.AuthParamsVariant12JsonConverter),

            typeof(global::Mixedbread.JsonConverters.MultiModalQueryJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MultiModalQueryVariant2JsonConverter),

            typeof(global::Mixedbread.JsonConverters.AuthParamsVariant13JsonConverter),

            typeof(global::Mixedbread.JsonConverters.ItemsItemJsonConverter),

            typeof(global::Mixedbread.JsonConverters.DataItemJsonConverter),

            typeof(global::Mixedbread.JsonConverters.ChunksVariant1ItemJsonConverter),

            typeof(global::Mixedbread.JsonConverters.DataItem2JsonConverter),

            typeof(global::Mixedbread.JsonConverters.DataItem3JsonConverter),

            typeof(global::Mixedbread.JsonConverters.SourcesItemJsonConverter),

            typeof(global::Mixedbread.JsonConverters.DataItem4JsonConverter),

            typeof(global::Mixedbread.JsonConverters.GeneratedMetadataVariant13JsonConverter),

            typeof(global::Mixedbread.JsonConverters.ChunksVariant1Item2JsonConverter),

            typeof(global::Mixedbread.JsonConverters.SourcesItem2JsonConverter),

            typeof(global::Mixedbread.JsonConverters.DataItem5JsonConverter),

            typeof(global::Mixedbread.JsonConverters.GeneratedMetadataVariant14JsonConverter),

            typeof(global::Mixedbread.JsonConverters.GeneratedMetadataVariant15JsonConverter),

            typeof(global::Mixedbread.JsonConverters.GeneratedMetadataVariant16JsonConverter),

            typeof(global::Mixedbread.JsonConverters.GeneratedMetadataVariant17JsonConverter),

            typeof(global::Mixedbread.JsonConverters.GeneratedMetadataVariant18JsonConverter),

            typeof(global::Mixedbread.JsonConverters.RulesItemJsonConverter),

            typeof(global::Mixedbread.JsonConverters.RulesItem2JsonConverter),

            typeof(global::Mixedbread.JsonConverters.RuleJsonConverter),

            typeof(global::Mixedbread.JsonConverters.DeletedRuleJsonConverter),

            typeof(global::Mixedbread.JsonConverters.RulesVariant1ItemJsonConverter),

            typeof(global::Mixedbread.JsonConverters.RulesItem3JsonConverter),

            typeof(global::Mixedbread.JsonConverters.RulesItem4JsonConverter),

            typeof(global::Mixedbread.JsonConverters.Rule2JsonConverter),

            typeof(global::Mixedbread.JsonConverters.DeletedRule2JsonConverter),

            typeof(global::Mixedbread.JsonConverters.RulesVariant1Item2JsonConverter),

            typeof(global::Mixedbread.JsonConverters.GeneratedMetadataVariant19JsonConverter),

            typeof(global::Mixedbread.JsonConverters.GeneratedMetadataVariant110JsonConverter),

            typeof(global::Mixedbread.JsonConverters.GeneratedMetadataVariant111JsonConverter),

            typeof(global::Mixedbread.JsonConverters.GeneratedMetadataVariant112JsonConverter),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<bool?, global::System.Collections.Generic.IList<string>>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.EncodingFormat3?, global::System.Collections.Generic.IList<global::Mixedbread.EncodingFormat3>>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Mixedbread.Embedding>, global::System.Collections.Generic.IList<global::Mixedbread.MultiEncodingEmbedding>>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.EncodingFormat3?, global::System.Collections.Generic.IList<global::Mixedbread.EncodingFormat3>>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.TextInput, global::Mixedbread.ImageUrlInput2>>>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.TextInput, global::Mixedbread.ImageUrlInput2>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>>, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>>, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>>, global::System.Collections.Generic.IList<global::System.Guid>, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<string, int?, double?, bool?>>, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>>, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>>, global::System.Collections.Generic.IList<global::System.Guid>, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<bool?, global::System.Collections.Generic.IList<string>>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<object>>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>>, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition>>, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>>, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>>, global::System.Collections.Generic.IList<global::System.Guid>, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<string, bool?>>, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, bool?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>>, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>>, global::System.Collections.Generic.IList<global::System.Guid>, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<bool?, global::Mixedbread.RerankConfig, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<bool?, global::Mixedbread.AgenticSearchConfig, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>>, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>>, global::System.Collections.Generic.IList<global::System.Guid>, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<bool?, global::Mixedbread.ContextualizationConfig>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>>, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>>, global::System.Collections.Generic.IList<global::System.Guid>, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition>>, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition>>, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, int?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<bool?, global::Mixedbread.RerankConfig, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<bool?, global::Mixedbread.AgenticSearchConfig, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>>, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>>, global::System.Collections.Generic.IList<global::System.Guid>, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>>, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>>, global::System.Collections.Generic.IList<global::System.Guid>, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.NotionDataSourceCreateOrUpdateParams, global::Mixedbread.LinearDataSourceCreateOrUpdateParams>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.NotionDataSourceCreateOrUpdateParams, global::Mixedbread.LinearDataSourceCreateOrUpdateParams>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<bool?, global::System.Collections.Generic.IList<int>>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType?), TypeInfoPropertyName = "MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunkGeneratedMetadataVariant1Discri_3c2191d673db2d33")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType?), TypeInfoPropertyName = "MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunkGeneratedMetadataVariant1Discri_aff54a326955d8df")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType?), TypeInfoPropertyName = "MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunkGeneratedMetadataVariant1Discri_59284f7c8f26921d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AgenticSearchConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AgenticSearchConfigMediaContent), TypeInfoPropertyName = "AgenticSearchConfigMediaContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AgenticSearchTokenUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AgenticToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AgenticToolCallToolType), TypeInfoPropertyName = "AgenticToolCallToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.Scope>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.Scope))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ApiKeyCreateOrUpdateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ApiKeyCreateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ApiKeyCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ApiKeyDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ApiKeyListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.PaginationWithTotal))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.ApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ApiKeyUpdateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AudioChunkGeneratedMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AudioUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AudioUrlInputChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.GeneratedMetadataVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MarkdownChunkGeneratedMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.TextChunkGeneratedMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.PDFChunkGeneratedMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.CodeChunkGeneratedMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.VideoChunkGeneratedMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ImageChunkGeneratedMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AudioUrlInputChunkGeneratedMetadataVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType), TypeInfoPropertyName = "AudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.BalanceInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.BillingPeriodSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.Period))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.CostInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Mixedbread.UsageInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.UsageInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.BodyCreateFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.BodyUpdateFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.BodyUploadStoreFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.Chunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.ChunkElement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ChunkElement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ElementType), TypeInfoPropertyName = "ElementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ChunkSearchResultRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ChunkingStrategy), TypeInfoPropertyName = "ChunkingStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.CompleteMultipartUploadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.MultipartUploadPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MultipartUploadPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ConditionOperator), TypeInfoPropertyName = "ConditionOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ConnectorListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.CursorPaginationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.DataSourceConnector>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.DataSourceConnector))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ContextualizationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<bool?, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "AnyOfBooleanIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.CostHistogramResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.DailyCostBucket>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.DailyCostBucket))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.PhaseCostInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.PhaseCostInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.ProductCostInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ProductCostInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.CreateMultipartUploadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.CreateMultipartUploadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.MultipartUploadPartUrl>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MultipartUploadPartUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.CreatedJsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.DataSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.DataSourceType), TypeInfoPropertyName = "DataSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AuthParamsVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.DataSourceOAuth2Params))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.DataSourceApiKeyParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.DataSourceAuthParamsVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.DataSourceAuthParamsVariant1DiscriminatorType), TypeInfoPropertyName = "DataSourceAuthParamsVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.SyncStatus), TypeInfoPropertyName = "SyncStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.DataSourceConnectorCreateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<int?, string, object>), TypeInfoPropertyName = "AnyOfInt32StringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.DataSourceConnectorDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.DataSourceConnectorUpdateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.DataSourceDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.DataSourceListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.DataSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.DeprecatedStoreFileUpsertParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreFileConfig2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.DocumentParserResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ReturnFormat), TypeInfoPropertyName = "ReturnFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.ElementType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.Chunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.Embedding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.EmbeddingItem), TypeInfoPropertyName = "EmbeddingItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.EmbeddingCreateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "AnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<global::Mixedbread.EncodingFormat3?, global::System.Collections.Generic.IList<global::Mixedbread.EncodingFormat3>>), TypeInfoPropertyName = "AnyOfEncodingFormat3IListEncodingFormat32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.EncodingFormat3), TypeInfoPropertyName = "EncodingFormat32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.EncodingFormat3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.EmbeddingCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.Usage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<global::System.Collections.Generic.IList<global::Mixedbread.Embedding>, global::System.Collections.Generic.IList<global::Mixedbread.MultiEncodingEmbedding>>), TypeInfoPropertyName = "AnyOfIListEmbeddingIListMultiEncodingEmbedding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.Embedding>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.MultiEncodingEmbedding>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MultiEncodingEmbedding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.EnhancedJsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.InnerErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ExpiresAfter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ExtractContentCreateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.TextInput, global::Mixedbread.ImageUrlInput2>>>), TypeInfoPropertyName = "AnyOfStringIListStringIListAnyOfTextInputImageUrlInput22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.TextInput, global::Mixedbread.ImageUrlInput2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<global::Mixedbread.TextInput, global::Mixedbread.ImageUrlInput2>), TypeInfoPropertyName = "AnyOfTextInputImageUrlInput22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.TextInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ImageUrlInput2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ExtractJobCreateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ExtractionJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ParsingJobStatus), TypeInfoPropertyName = "ParsingJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ExtractionResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.FileCounts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.FileDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.FileListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.FileObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.FileObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.FileSearchResultRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ImageUrlInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ImageUrlOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ImageUrlInputChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.GeneratedMetadataVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ImageUrlInputChunkGeneratedMetadataVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType), TypeInfoPropertyName = "ImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.InfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.JsonSchemaCreateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.JsonSchemaEnhanceParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.JsonSchemaValidateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.LinearDataSourceCreateOrUpdateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AuthParamsVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.OAuth2CreateOrUpdateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.LinearDataSourceCreateOrUpdateParamsAuthParamsVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.LinearDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType), TypeInfoPropertyName = "LinearDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.MarkdownHeading>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MarkdownHeading))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MetadataCursorPagination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.StoreFileStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreFileStatus), TypeInfoPropertyName = "StoreFileStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>>, object>), TypeInfoPropertyName = "AnyOfSearchFilterInputSearchFilterConditionIListAnyOfSearchFilterInputSearchFilterConditionObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.SearchFilterInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.SearchFilterCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>), TypeInfoPropertyName = "AnyOfSearchFilterInputSearchFilterCondition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MetadataFacets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MetadataFacetsParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<string, global::System.Guid?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<string, global::System.Guid?>), TypeInfoPropertyName = "AnyOfStringGuid2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>>, global::System.Collections.Generic.IList<global::System.Guid>, object>), TypeInfoPropertyName = "AnyOfIListAnyOfConditionOperatorIListGuidIListGuidObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>), TypeInfoPropertyName = "AnyOfConditionOperatorIListGuid2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreChunkSearchOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.Mode), TypeInfoPropertyName = "Mode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MultipleEncodingsEmbeddingItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MultiModalQuery), TypeInfoPropertyName = "MultiModalQuery2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MultiModalQueryVariant2), TypeInfoPropertyName = "MultiModalQueryVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MultiModalQueryVariant2Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MultiModalQueryVariant2DiscriminatorType), TypeInfoPropertyName = "MultiModalQueryVariant2DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MultipartUploadDetailResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MultipartUploadListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.MultipartUploadObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MultipartUploadObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.NotionDataSourceCreateOrUpdateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AuthParamsVariant13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType), TypeInfoPropertyName = "NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ParsingJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ParsingJobCreateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ParsingJobDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ParsingJobListItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ParsingJobListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.ParsingJobListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.QueryEnhanceMetadataFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<string, int?, double?, bool?, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<string, int?, double?, bool?>>, object>), TypeInfoPropertyName = "AnyOfStringInt32DoubleBooleanIListAnyOfStringInt32DoubleBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<string, int?, double?, bool?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<string, int?, double?, bool?>), TypeInfoPropertyName = "AnyOfStringInt32DoubleBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.QueryEnhanceParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.QueryEnhanceQueryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.QueryEnhanceMetadataFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.QueryEnhanceQueryItemFilterMode), TypeInfoPropertyName = "QueryEnhanceQueryItemFilterMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.QueryEnhanceResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.ItemsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ItemsItem), TypeInfoPropertyName = "ItemsItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.QueryEnhanceSortItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.QueryEnhanceResultsItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.QueryEnhanceResultsItemDiscriminatorType), TypeInfoPropertyName = "QueryEnhanceResultsItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.QueryEnhanceSortItemFilterMode), TypeInfoPropertyName = "QueryEnhanceSortItemFilterMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.QueryEnhanceSortItemDirection), TypeInfoPropertyName = "QueryEnhanceSortItemDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.QueryRegexSubstitutionRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.RegexFlag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.RegexFlag), TypeInfoPropertyName = "RegexFlag2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.QueryStringSubstitutionRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.QuestionAnsweringOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.RankedDocument))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.RerankConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.RerankParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<string, object, global::System.Collections.Generic.IList<object>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<string, object, global::System.Collections.Generic.IList<object>>), TypeInfoPropertyName = "AnyOfStringObjectIListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.RerankResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.RankedDocument>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ScopeMethod), TypeInfoPropertyName = "ScopeMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<string, global::System.Guid?, object>), TypeInfoPropertyName = "AnyOfStringGuidObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.SearchCursorPagination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.SearchFilterOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition>), TypeInfoPropertyName = "AnyOfSearchFilterOutputSearchFilterCondition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.Store))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreConfig2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreStatus), TypeInfoPropertyName = "StoreStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreAgenticSearchEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition>>, object>), TypeInfoPropertyName = "AnyOfSearchFilterOutputSearchFilterConditionIListAnyOfSearchFilterOutputSearchFilterConditionObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.AgenticToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.StoreSearchEventResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreSearchEventResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreChunkFilterParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<string, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<string, bool?>>, object>), TypeInfoPropertyName = "AnyOfStringIListAnyOfStringBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<string, bool?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<string, bool?>), TypeInfoPropertyName = "AnyOfStringBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreChunkGrepParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.StoreChunkGrepTarget>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreChunkGrepTarget), TypeInfoPropertyName = "StoreChunkGrepTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<bool?, global::Mixedbread.RerankConfig, object>), TypeInfoPropertyName = "AnyOfBooleanRerankConfigObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<bool?, global::Mixedbread.AgenticSearchConfig, object>), TypeInfoPropertyName = "AnyOfBooleanAgenticSearchConfigObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreChunkSearchParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<bool?, global::Mixedbread.ContextualizationConfig>), TypeInfoPropertyName = "AnyOfBooleanContextualizationConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreCostInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreCostListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.StoreCostInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreCreateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreEventHistogramBucket))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreEventHistogramBucketType), TypeInfoPropertyName = "StoreEventHistogramBucketType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreEventHistogramParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.StoreEventHistogramParamsEventTypesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreEventHistogramParamsEventTypesVariant1Item), TypeInfoPropertyName = "StoreEventHistogramParamsEventTypesVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreEventHistogramResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.StoreEventHistogramBucket>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreEventListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.DataItem), TypeInfoPropertyName = "DataItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreIngestionEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreSearchEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreEventListResponseDataItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreEventListResponseDataItemDiscriminatorType), TypeInfoPropertyName = "StoreEventListResponseDataItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.ChunksVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ChunksVariant1Item), TypeInfoPropertyName = "ChunksVariant1Item2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.TextInputChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.VideoUrlInputChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreFileChunksVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreFileChunksVariant1ItemDiscriminatorType), TypeInfoPropertyName = "StoreFileChunksVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreFileParsingStrategy), TypeInfoPropertyName = "StoreFileParsingStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreFileDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreFileListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.StoreFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreFileMetadataUpdateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreGrepResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.DataItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.DataItem2), TypeInfoPropertyName = "DataItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreGrepResponseDataItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreGrepResponseDataItemDiscriminatorType), TypeInfoPropertyName = "StoreGrepResponseDataItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreListChunksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.DataItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.DataItem3), TypeInfoPropertyName = "DataItem32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreListChunksResponseDataItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreListChunksResponseDataItemDiscriminatorType), TypeInfoPropertyName = "StoreListChunksResponseDataItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.Store>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreQAParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreQAResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.SourcesItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.SourcesItem), TypeInfoPropertyName = "SourcesItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreQAResultsSourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreQAResultsSourceDiscriminatorType), TypeInfoPropertyName = "StoreQAResultsSourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreSearchEventRewriteRankDirection2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreSearchEventRewriteRankMode2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreSearchEventResultFirstStageSource2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreSearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.DataItem4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.DataItem4), TypeInfoPropertyName = "DataItem42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreSearchResponseDataItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreSearchResponseDataItemDiscriminatorType), TypeInfoPropertyName = "StoreSearchResponseDataItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreUpdateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.GeneratedMetadataVariant13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.TextInputChunkGeneratedMetadataVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.TextInputChunkGeneratedMetadataVariant1DiscriminatorType), TypeInfoPropertyName = "TextInputChunkGeneratedMetadataVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ValidatedJsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.VectorStore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.VectorStoreChunkSearchOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.VectorStoreChunkSearchParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.VectorStoreCreateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.VectorStoreDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.VectorStoreFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.ChunksVariant1Item2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ChunksVariant1Item2), TypeInfoPropertyName = "ChunksVariant1Item22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.VectorStoreFileChunksVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.VectorStoreFileChunksVariant1ItemDiscriminatorType), TypeInfoPropertyName = "VectorStoreFileChunksVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.VectorStoreFileDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.VectorStoreFileListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.VectorStoreFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.VectorStoreFileStatus), TypeInfoPropertyName = "VectorStoreFileStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.VectorStoreListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.VectorStore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.VectorStoreQAParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.VectorStoreQAResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.SourcesItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.SourcesItem2), TypeInfoPropertyName = "SourcesItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.VectorStoreQAResultsSourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.VectorStoreQAResultsSourceDiscriminatorType), TypeInfoPropertyName = "VectorStoreQAResultsSourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.VectorStoreSearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.DataItem5>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.DataItem5), TypeInfoPropertyName = "DataItem52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.VectorStoreSearchResponseDataItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.VectorStoreSearchResponseDataItemDiscriminatorType), TypeInfoPropertyName = "VectorStoreSearchResponseDataItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.VectorStoreUpdateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.VideoUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.GeneratedMetadataVariant14))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.VideoUrlInputChunkGeneratedMetadataVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType), TypeInfoPropertyName = "VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.GeneratedMetadataVariant15))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunkGeneratedMetadataVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType), TypeInfoPropertyName = "MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.GeneratedMetadataVariant16))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunkGeneratedMetadataVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType), TypeInfoPropertyName = "MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.GeneratedMetadataVariant17))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunkGeneratedMetadataVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorType), TypeInfoPropertyName = "MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.GeneratedMetadataVariant18))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunkGeneratedMetadataVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType), TypeInfoPropertyName = "MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleCreateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.RulesItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.RulesItem), TypeInfoPropertyName = "RulesItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleCreateParamsRuleDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleCreateParamsRuleDiscriminatorType), TypeInfoPropertyName = "MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleCreateParamsRuleDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.RulesItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.RulesItem2), TypeInfoPropertyName = "RulesItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleResponseRuleDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleResponseRuleDiscriminatorType), TypeInfoPropertyName = "MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleResponseRuleDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeleteParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.Rule), TypeInfoPropertyName = "Rule2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeleteParamsRuleDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorType), TypeInfoPropertyName = "MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.DeletedRule), TypeInfoPropertyName = "DeletedRule2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeletedDeletedRuleDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeletedDeletedRuleDiscriminatorType), TypeInfoPropertyName = "MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeletedDeletedRuleDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleUpdateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.RulesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.RulesVariant1Item), TypeInfoPropertyName = "RulesVariant1Item2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorType), TypeInfoPropertyName = "MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleCreateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.RulesItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.RulesItem3), TypeInfoPropertyName = "RulesItem32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleCreateParamsRuleDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleCreateParamsRuleDiscriminatorType), TypeInfoPropertyName = "MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleCreateParamsRuleDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.RulesItem4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.RulesItem4), TypeInfoPropertyName = "RulesItem42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleResponseRuleDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleResponseRuleDiscriminatorType), TypeInfoPropertyName = "MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleResponseRuleDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.Rule2), TypeInfoPropertyName = "Rule22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParamsRuleDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorType), TypeInfoPropertyName = "MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.DeletedRule2), TypeInfoPropertyName = "DeletedRule22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeletedDeletedRuleDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeletedDeletedRuleDiscriminatorType), TypeInfoPropertyName = "MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeletedDeletedRuleDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleUpdateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.RulesVariant1Item2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.RulesVariant1Item2), TypeInfoPropertyName = "RulesVariant1Item22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorType), TypeInfoPropertyName = "MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.GeneratedMetadataVariant19))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunkGeneratedMetadataVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType), TypeInfoPropertyName = "MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.GeneratedMetadataVariant110))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunkGeneratedMetadataVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType), TypeInfoPropertyName = "MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.GeneratedMetadataVariant111))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunkGeneratedMetadataVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorType), TypeInfoPropertyName = "MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.GeneratedMetadataVariant112))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunkGeneratedMetadataVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType), TypeInfoPropertyName = "MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<global::Mixedbread.NotionDataSourceCreateOrUpdateParams, global::Mixedbread.LinearDataSourceCreateOrUpdateParams>), TypeInfoPropertyName = "AnyOfNotionDataSourceCreateOrUpdateParamsLinearDataSourceCreateOrUpdateParams2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.VectorStoreFileStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ListStoreEventsEventType), TypeInfoPropertyName = "ListStoreEventsEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<bool?, global::System.Collections.Generic.IList<int>>), TypeInfoPropertyName = "AnyOfBooleanIListInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.ParsingJobStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.Scope>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.ApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.ChunkElement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.MultipartUploadPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.DataSourceConnector>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<bool?, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.DailyCostBucket>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.PhaseCostInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.ProductCostInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.MultipartUploadPartUrl>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.DataSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.ElementType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.Chunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<global::Mixedbread.EncodingFormat3?, global::System.Collections.Generic.List<global::Mixedbread.EncodingFormat3>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.EncodingFormat3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<global::System.Collections.Generic.List<global::Mixedbread.Embedding>, global::System.Collections.Generic.List<global::Mixedbread.MultiEncodingEmbedding>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.Embedding>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.MultiEncodingEmbedding>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<string, global::System.Collections.Generic.List<string>, global::System.Collections.Generic.List<global::Mixedbread.AnyOf<global::Mixedbread.TextInput, global::Mixedbread.ImageUrlInput2>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.AnyOf<global::Mixedbread.TextInput, global::Mixedbread.ImageUrlInput2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.FileObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.MarkdownHeading>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.StoreFileStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.List<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.AnyOf<string, global::System.Guid?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<global::System.Collections.Generic.List<global::Mixedbread.AnyOf<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.List<global::System.Guid>>>, global::System.Collections.Generic.List<global::System.Guid>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.AnyOf<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.List<global::System.Guid>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.List<global::System.Guid>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.MultipartUploadObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.ParsingJobListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<string, int?, double?, bool?, global::System.Collections.Generic.List<global::Mixedbread.AnyOf<string, int?, double?, bool?>>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.AnyOf<string, int?, double?, bool?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.QueryEnhanceMetadataFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.ItemsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.RegexFlag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.AnyOf<string, object, global::System.Collections.Generic.List<object>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<string, object, global::System.Collections.Generic.List<object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.RankedDocument>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.List<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition>>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.AgenticToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.StoreSearchEventResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<string, global::System.Collections.Generic.List<global::Mixedbread.AnyOf<string, bool?>>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.AnyOf<string, bool?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.StoreChunkGrepTarget>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.StoreCostInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.StoreEventHistogramParamsEventTypesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.StoreEventHistogramBucket>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.ChunksVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.StoreFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.DataItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.DataItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.Store>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.SourcesItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.DataItem4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.ChunksVariant1Item2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.VectorStoreFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.VectorStore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.SourcesItem2>))]
    internal sealed partial class SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Mixedbread.JsonConverters.AgenticSearchConfigMediaContentJsonConverter),

            typeof(global::Mixedbread.JsonConverters.AgenticSearchConfigMediaContentNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.AgenticToolCallToolTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.AgenticToolCallToolTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.AudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.AudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.ChunkingStrategyJsonConverter),

            typeof(global::Mixedbread.JsonConverters.ChunkingStrategyNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.ConditionOperatorJsonConverter),

            typeof(global::Mixedbread.JsonConverters.ConditionOperatorNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.DataSourceAuthParamsVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.DataSourceAuthParamsVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.DataSourceTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.DataSourceTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.ElementTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.ElementTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.EncodingFormat3JsonConverter),

            typeof(global::Mixedbread.JsonConverters.EncodingFormat3NullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.ImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.ImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.LinearDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.LinearDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.ModeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.ModeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MultiModalQueryVariant2DiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MultiModalQueryVariant2DiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.ParsingJobStatusJsonConverter),

            typeof(global::Mixedbread.JsonConverters.ParsingJobStatusNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.QueryEnhanceQueryItemFilterModeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.QueryEnhanceQueryItemFilterModeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.QueryEnhanceResultsItemDiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.QueryEnhanceResultsItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.QueryEnhanceSortItemFilterModeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.QueryEnhanceSortItemFilterModeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.QueryEnhanceSortItemDirectionJsonConverter),

            typeof(global::Mixedbread.JsonConverters.QueryEnhanceSortItemDirectionNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.RegexFlagJsonConverter),

            typeof(global::Mixedbread.JsonConverters.RegexFlagNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.ReturnFormatJsonConverter),

            typeof(global::Mixedbread.JsonConverters.ReturnFormatNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.ScopeMethodJsonConverter),

            typeof(global::Mixedbread.JsonConverters.ScopeMethodNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreChunkGrepTargetJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreChunkGrepTargetNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreEventHistogramBucketTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreEventHistogramBucketTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreEventHistogramParamsEventTypesVariant1ItemJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreEventHistogramParamsEventTypesVariant1ItemNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreEventListResponseDataItemDiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreEventListResponseDataItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreFileChunksVariant1ItemDiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreFileChunksVariant1ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreFileParsingStrategyJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreFileParsingStrategyNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreFileStatusJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreFileStatusNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreGrepResponseDataItemDiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreGrepResponseDataItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreListChunksResponseDataItemDiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreListChunksResponseDataItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreQAResultsSourceDiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreQAResultsSourceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreSearchEventRewriteRankDirection2JsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreSearchEventRewriteRankDirection2NullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreSearchEventRewriteRankMode2JsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreSearchEventRewriteRankMode2NullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreSearchEventResultFirstStageSource2JsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreSearchEventResultFirstStageSource2NullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreSearchResponseDataItemDiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreSearchResponseDataItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreStatusJsonConverter),

            typeof(global::Mixedbread.JsonConverters.StoreStatusNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.SyncStatusJsonConverter),

            typeof(global::Mixedbread.JsonConverters.SyncStatusNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.TextInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.TextInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.VectorStoreFileChunksVariant1ItemDiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.VectorStoreFileChunksVariant1ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.VectorStoreFileStatusJsonConverter),

            typeof(global::Mixedbread.JsonConverters.VectorStoreFileStatusNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.VectorStoreQAResultsSourceDiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.VectorStoreQAResultsSourceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.VectorStoreSearchResponseDataItemDiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.VectorStoreSearchResponseDataItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleCreateParamsRuleDiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleCreateParamsRuleDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleResponseRuleDiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleResponseRuleDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeletedDeletedRuleDiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeletedDeletedRuleDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleCreateParamsRuleDiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleCreateParamsRuleDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleResponseRuleDiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleResponseRuleDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeletedDeletedRuleDiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeletedDeletedRuleDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.ListStoreEventsEventTypeJsonConverter),

            typeof(global::Mixedbread.JsonConverters.ListStoreEventsEventTypeNullableJsonConverter),

            typeof(global::Mixedbread.JsonConverters.GeneratedMetadataVariant1JsonConverter),

            typeof(global::Mixedbread.JsonConverters.AuthParamsVariant1JsonConverter),

            typeof(global::Mixedbread.JsonConverters.EmbeddingItemJsonConverter),

            typeof(global::Mixedbread.JsonConverters.GeneratedMetadataVariant12JsonConverter),

            typeof(global::Mixedbread.JsonConverters.AuthParamsVariant12JsonConverter),

            typeof(global::Mixedbread.JsonConverters.MultiModalQueryJsonConverter),

            typeof(global::Mixedbread.JsonConverters.MultiModalQueryVariant2JsonConverter),

            typeof(global::Mixedbread.JsonConverters.AuthParamsVariant13JsonConverter),

            typeof(global::Mixedbread.JsonConverters.ItemsItemJsonConverter),

            typeof(global::Mixedbread.JsonConverters.DataItemJsonConverter),

            typeof(global::Mixedbread.JsonConverters.ChunksVariant1ItemJsonConverter),

            typeof(global::Mixedbread.JsonConverters.DataItem2JsonConverter),

            typeof(global::Mixedbread.JsonConverters.DataItem3JsonConverter),

            typeof(global::Mixedbread.JsonConverters.SourcesItemJsonConverter),

            typeof(global::Mixedbread.JsonConverters.DataItem4JsonConverter),

            typeof(global::Mixedbread.JsonConverters.GeneratedMetadataVariant13JsonConverter),

            typeof(global::Mixedbread.JsonConverters.ChunksVariant1Item2JsonConverter),

            typeof(global::Mixedbread.JsonConverters.SourcesItem2JsonConverter),

            typeof(global::Mixedbread.JsonConverters.DataItem5JsonConverter),

            typeof(global::Mixedbread.JsonConverters.GeneratedMetadataVariant14JsonConverter),

            typeof(global::Mixedbread.JsonConverters.GeneratedMetadataVariant15JsonConverter),

            typeof(global::Mixedbread.JsonConverters.GeneratedMetadataVariant16JsonConverter),

            typeof(global::Mixedbread.JsonConverters.GeneratedMetadataVariant17JsonConverter),

            typeof(global::Mixedbread.JsonConverters.GeneratedMetadataVariant18JsonConverter),

            typeof(global::Mixedbread.JsonConverters.RulesItemJsonConverter),

            typeof(global::Mixedbread.JsonConverters.RulesItem2JsonConverter),

            typeof(global::Mixedbread.JsonConverters.RuleJsonConverter),

            typeof(global::Mixedbread.JsonConverters.DeletedRuleJsonConverter),

            typeof(global::Mixedbread.JsonConverters.RulesVariant1ItemJsonConverter),

            typeof(global::Mixedbread.JsonConverters.RulesItem3JsonConverter),

            typeof(global::Mixedbread.JsonConverters.RulesItem4JsonConverter),

            typeof(global::Mixedbread.JsonConverters.Rule2JsonConverter),

            typeof(global::Mixedbread.JsonConverters.DeletedRule2JsonConverter),

            typeof(global::Mixedbread.JsonConverters.RulesVariant1Item2JsonConverter),

            typeof(global::Mixedbread.JsonConverters.GeneratedMetadataVariant19JsonConverter),

            typeof(global::Mixedbread.JsonConverters.GeneratedMetadataVariant110JsonConverter),

            typeof(global::Mixedbread.JsonConverters.GeneratedMetadataVariant111JsonConverter),

            typeof(global::Mixedbread.JsonConverters.GeneratedMetadataVariant112JsonConverter),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<bool?, global::System.Collections.Generic.IList<string>>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.EncodingFormat3?, global::System.Collections.Generic.IList<global::Mixedbread.EncodingFormat3>>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Mixedbread.Embedding>, global::System.Collections.Generic.IList<global::Mixedbread.MultiEncodingEmbedding>>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.EncodingFormat3?, global::System.Collections.Generic.IList<global::Mixedbread.EncodingFormat3>>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.TextInput, global::Mixedbread.ImageUrlInput2>>>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.TextInput, global::Mixedbread.ImageUrlInput2>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>>, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>>, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>>, global::System.Collections.Generic.IList<global::System.Guid>, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<string, int?, double?, bool?>>, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>>, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>>, global::System.Collections.Generic.IList<global::System.Guid>, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<bool?, global::System.Collections.Generic.IList<string>>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<object>>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>>, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition>>, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>>, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>>, global::System.Collections.Generic.IList<global::System.Guid>, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<string, bool?>>, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, bool?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>>, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>>, global::System.Collections.Generic.IList<global::System.Guid>, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<bool?, global::Mixedbread.RerankConfig, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<bool?, global::Mixedbread.AgenticSearchConfig, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>>, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>>, global::System.Collections.Generic.IList<global::System.Guid>, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<bool?, global::Mixedbread.ContextualizationConfig>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>>, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>>, global::System.Collections.Generic.IList<global::System.Guid>, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition>>, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition>>, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, int?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<bool?, global::Mixedbread.RerankConfig, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<bool?, global::Mixedbread.AgenticSearchConfig, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>>, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>>, global::System.Collections.Generic.IList<global::System.Guid>, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>>, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>>, global::System.Collections.Generic.IList<global::System.Guid>, object>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.NotionDataSourceCreateOrUpdateParams, global::Mixedbread.LinearDataSourceCreateOrUpdateParams>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.NotionDataSourceCreateOrUpdateParams, global::Mixedbread.LinearDataSourceCreateOrUpdateParams>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<bool?, global::System.Collections.Generic.IList<int>>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Mixedbread.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType?), TypeInfoPropertyName = "MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunkGeneratedMetadataVariant1Discri_3c2191d673db2d33")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType?), TypeInfoPropertyName = "MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunkGeneratedMetadataVariant1Discri_aff54a326955d8df")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType?), TypeInfoPropertyName = "MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunkGeneratedMetadataVariant1Discri_59284f7c8f26921d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.DataItem5>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.RulesItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.RulesItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.RulesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.RulesItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.RulesItem4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.RulesVariant1Item2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.VectorStoreFileStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<bool?, global::System.Collections.Generic.List<int>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.ParsingJobStatus>))]
    internal sealed partial class SourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = global::System.Text.Json.Serialization.Metadata.JsonTypeInfoResolver.Combine(
            SourceGenerationContextChunk0.Default,

            SourceGenerationContextChunk1.Default
            );

        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        /// 
        /// </summary>
        public static SourceGenerationContext Default { get; } = new(DefaultOptions);

        private SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            options.Converters.Add(new global::Mixedbread.JsonConverters.AgenticSearchConfigMediaContentJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AgenticSearchConfigMediaContentNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AgenticToolCallToolTypeJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AgenticToolCallToolTypeNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.ChunkingStrategyJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.ChunkingStrategyNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.ConditionOperatorJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.ConditionOperatorNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.DataSourceAuthParamsVariant1DiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.DataSourceAuthParamsVariant1DiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.DataSourceTypeJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.DataSourceTypeNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.ElementTypeJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.ElementTypeNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.EncodingFormat3JsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.EncodingFormat3NullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.ImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.ImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.LinearDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.LinearDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.ModeJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.ModeNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.MultiModalQueryVariant2DiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.MultiModalQueryVariant2DiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.ParsingJobStatusJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.ParsingJobStatusNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.QueryEnhanceQueryItemFilterModeJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.QueryEnhanceQueryItemFilterModeNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.QueryEnhanceResultsItemDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.QueryEnhanceResultsItemDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.QueryEnhanceSortItemFilterModeJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.QueryEnhanceSortItemFilterModeNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.QueryEnhanceSortItemDirectionJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.QueryEnhanceSortItemDirectionNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.RegexFlagJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.RegexFlagNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.ReturnFormatJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.ReturnFormatNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.ScopeMethodJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.ScopeMethodNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.StoreChunkGrepTargetJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.StoreChunkGrepTargetNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.StoreEventHistogramBucketTypeJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.StoreEventHistogramBucketTypeNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.StoreEventHistogramParamsEventTypesVariant1ItemJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.StoreEventHistogramParamsEventTypesVariant1ItemNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.StoreEventListResponseDataItemDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.StoreEventListResponseDataItemDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.StoreFileChunksVariant1ItemDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.StoreFileChunksVariant1ItemDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.StoreFileParsingStrategyJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.StoreFileParsingStrategyNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.StoreFileStatusJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.StoreFileStatusNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.StoreGrepResponseDataItemDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.StoreGrepResponseDataItemDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.StoreListChunksResponseDataItemDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.StoreListChunksResponseDataItemDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.StoreQAResultsSourceDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.StoreQAResultsSourceDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.StoreSearchEventRewriteRankDirection2JsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.StoreSearchEventRewriteRankDirection2NullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.StoreSearchEventRewriteRankMode2JsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.StoreSearchEventRewriteRankMode2NullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.StoreSearchEventResultFirstStageSource2JsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.StoreSearchEventResultFirstStageSource2NullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.StoreSearchResponseDataItemDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.StoreSearchResponseDataItemDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.StoreStatusJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.StoreStatusNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.SyncStatusJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.SyncStatusNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.TextInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.TextInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.VectorStoreFileChunksVariant1ItemDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.VectorStoreFileChunksVariant1ItemDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.VectorStoreFileStatusJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.VectorStoreFileStatusNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.VectorStoreQAResultsSourceDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.VectorStoreQAResultsSourceDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.VectorStoreSearchResponseDataItemDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.VectorStoreSearchResponseDataItemDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleCreateParamsRuleDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleCreateParamsRuleDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleResponseRuleDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleResponseRuleDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeletedDeletedRuleDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeletedDeletedRuleDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleCreateParamsRuleDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleCreateParamsRuleDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleResponseRuleDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleResponseRuleDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeletedDeletedRuleDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeletedDeletedRuleDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.ListStoreEventsEventTypeJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.ListStoreEventsEventTypeNullableJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.GeneratedMetadataVariant1JsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AuthParamsVariant1JsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.EmbeddingItemJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.GeneratedMetadataVariant12JsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AuthParamsVariant12JsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.MultiModalQueryJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.MultiModalQueryVariant2JsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AuthParamsVariant13JsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.ItemsItemJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.DataItemJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.ChunksVariant1ItemJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.DataItem2JsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.DataItem3JsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.SourcesItemJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.DataItem4JsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.GeneratedMetadataVariant13JsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.ChunksVariant1Item2JsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.SourcesItem2JsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.DataItem5JsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.GeneratedMetadataVariant14JsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.GeneratedMetadataVariant15JsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.GeneratedMetadataVariant16JsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.GeneratedMetadataVariant17JsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.GeneratedMetadataVariant18JsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.RulesItemJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.RulesItem2JsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.RuleJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.DeletedRuleJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.RulesVariant1ItemJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.RulesItem3JsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.RulesItem4JsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.Rule2JsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.DeletedRule2JsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.RulesVariant1Item2JsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.GeneratedMetadataVariant19JsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.GeneratedMetadataVariant110JsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.GeneratedMetadataVariant111JsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.GeneratedMetadataVariant112JsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<bool?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.EncodingFormat3?, global::System.Collections.Generic.IList<global::Mixedbread.EncodingFormat3>>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Mixedbread.Embedding>, global::System.Collections.Generic.IList<global::Mixedbread.MultiEncodingEmbedding>>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.EncodingFormat3?, global::System.Collections.Generic.IList<global::Mixedbread.EncodingFormat3>>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.TextInput, global::Mixedbread.ImageUrlInput2>>>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.TextInput, global::Mixedbread.ImageUrlInput2>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>>, object>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>>, object>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>>, global::System.Collections.Generic.IList<global::System.Guid>, object>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<string, int?, double?, bool?>>, object>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>>, object>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>>, global::System.Collections.Generic.IList<global::System.Guid>, object>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<bool?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<object>>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?, object>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>>, object>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition>>, object>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>>, object>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>>, global::System.Collections.Generic.IList<global::System.Guid>, object>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<string, bool?>>, object>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, bool?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>>, object>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>>, global::System.Collections.Generic.IList<global::System.Guid>, object>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<bool?, global::Mixedbread.RerankConfig, object>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<bool?, global::Mixedbread.AgenticSearchConfig, object>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>>, object>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>>, global::System.Collections.Generic.IList<global::System.Guid>, object>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<bool?, global::Mixedbread.ContextualizationConfig>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>>, object>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>>, global::System.Collections.Generic.IList<global::System.Guid>, object>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition>>, object>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition>>, object>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<bool?, global::Mixedbread.RerankConfig, object>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<bool?, global::Mixedbread.AgenticSearchConfig, object>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>>, object>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>>, global::System.Collections.Generic.IList<global::System.Guid>, object>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>>, object>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>>, global::System.Collections.Generic.IList<global::System.Guid>, object>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.NotionDataSourceCreateOrUpdateParams, global::Mixedbread.LinearDataSourceCreateOrUpdateParams>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.NotionDataSourceCreateOrUpdateParams, global::Mixedbread.LinearDataSourceCreateOrUpdateParams>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<bool?, global::System.Collections.Generic.IList<int>>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.UnixTimestampJsonConverter());

            return options;
        }
    }
}