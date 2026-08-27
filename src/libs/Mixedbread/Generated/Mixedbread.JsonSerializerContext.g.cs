
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
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType?), TypeInfoPropertyName = "MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunkGeneratedMetadataVariant1Discri_3c2191d673db2d33")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType?), TypeInfoPropertyName = "MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunkGeneratedMetadataVariant1Discri_aff54a326955d8df")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType?), TypeInfoPropertyName = "MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunkGeneratedMetadataVariant1Discri_59284f7c8f26921d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AgenticSearchConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AgenticSearchConfigMediaContent), TypeInfoPropertyName = "AgenticSearchConfigMediaContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AgenticSearchTokenUsage))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.Bucket))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.BucketProvider), TypeInfoPropertyName = "BucketProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.BucketAuthType), TypeInfoPropertyName = "BucketAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.BucketStatus), TypeInfoPropertyName = "BucketStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.BucketAccessKeyCredentials))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.BucketAssumeRoleCredentials))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.BucketCreateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.Credentials), TypeInfoPropertyName = "Credentials2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.BucketCreateParamsCredentialsDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.BucketCreateParamsCredentialsDiscriminatorType), TypeInfoPropertyName = "BucketCreateParamsCredentialsDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.BucketListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.CursorPaginationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.Bucket>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.BucketRotateCredentialsParams))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.DataSourceInstallation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.DataSourceInstallationListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.DataSourceInstallation>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.GoogleDriveFolder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.GoogleDriveFolderSelection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.GoogleDriveFolder>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.GoogleDriveFolderSelectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.GoogleDriveFolderSelectionUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.GoogleDriveFolderSelectionUpdateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.GoogleDriveFolderSelectionUpdateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.GoogleDriveInstallationConfigUpdateBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.GoogleDriveInstallationOverview))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.GoogleDriveInstallationOverviewListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.GoogleDriveInstallationOverview>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.GoogleDriveSync))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.GoogleDriveSyncParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.GoogleDriveSyncResponse))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.IntegrationInstallation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.IntegrationInstallationListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.IntegrationInstallation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.IntegrationInstallationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.IntegrationProviderListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.IntegrationProviderManifest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.IntegrationProviderManifest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.IntegrationProviderManifestProvider), TypeInfoPropertyName = "IntegrationProviderManifestProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.IntegrationProviderManifestAuthType), TypeInfoPropertyName = "IntegrationProviderManifestAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.IntegrationProviderManifestCapabilitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.IntegrationProviderManifestCapabilitie), TypeInfoPropertyName = "IntegrationProviderManifestCapabilitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.IntegrationProviderManifestIngestionBacking2))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.SlackChannel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.SlackChannelSyncStatus), TypeInfoPropertyName = "SlackChannelSyncStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.SlackChannelLastSyncStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.SlackChannelSelection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.SlackChannel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.SlackChannelSelectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.SlackChannelSelectionUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.SlackChannelSelectionUpdateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.SlackChannelSelectionUpdateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.SlackChannelSync))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.SlackChannelSyncParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.SlackChannelSyncResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.SlackInstallationConfigUpdateBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.SlackInstallationOverview))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.SlackInstallationOverviewListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.SlackInstallationOverview>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.SlackManifestResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.SlackManualConnectBody))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreGrepEvent))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AgenticSearchConfigMediaContent?), TypeInfoPropertyName = "NullableAgenticSearchConfigMediaContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AgenticToolCallToolType?), TypeInfoPropertyName = "NullableAgenticToolCallToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.BucketProvider?), TypeInfoPropertyName = "NullableBucketProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.BucketAuthType?), TypeInfoPropertyName = "NullableBucketAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.BucketStatus?), TypeInfoPropertyName = "NullableBucketStatus2")]
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
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType?), TypeInfoPropertyName = "MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunkGeneratedMetadataVariant1Discri_3c2191d673db2d33")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType?), TypeInfoPropertyName = "MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunkGeneratedMetadataVariant1Discri_aff54a326955d8df")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType?), TypeInfoPropertyName = "MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunkGeneratedMetadataVariant1Discri_59284f7c8f26921d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.Credentials?), TypeInfoPropertyName = "NullableCredentials2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.BucketCreateParamsCredentialsDiscriminatorType?), TypeInfoPropertyName = "NullableBucketCreateParamsCredentialsDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ElementType?), TypeInfoPropertyName = "NullableElementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ChunkingStrategy?), TypeInfoPropertyName = "NullableChunkingStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ConditionOperator?), TypeInfoPropertyName = "NullableConditionOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<bool?, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableAnyOfBooleanIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.DataSourceType?), TypeInfoPropertyName = "NullableDataSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.DataSourceAuthParamsVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableDataSourceAuthParamsVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.SyncStatus?), TypeInfoPropertyName = "NullableSyncStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<int?, string, object>?), TypeInfoPropertyName = "NullableAnyOfInt32StringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ReturnFormat?), TypeInfoPropertyName = "NullableReturnFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.EmbeddingItem?), TypeInfoPropertyName = "NullableEmbeddingItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<string, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableAnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<global::Mixedbread.EncodingFormat3?, global::System.Collections.Generic.IList<global::Mixedbread.EncodingFormat3>>?), TypeInfoPropertyName = "NullableAnyOfEncodingFormat3IListEncodingFormat32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.EncodingFormat3?), TypeInfoPropertyName = "NullableEncodingFormat32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<global::System.Collections.Generic.IList<global::Mixedbread.Embedding>, global::System.Collections.Generic.IList<global::Mixedbread.MultiEncodingEmbedding>>?), TypeInfoPropertyName = "NullableAnyOfIListEmbeddingIListMultiEncodingEmbedding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.TextInput, global::Mixedbread.ImageUrlInput2>>>?), TypeInfoPropertyName = "NullableAnyOfStringIListStringIListAnyOfTextInputImageUrlInput22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<global::Mixedbread.TextInput, global::Mixedbread.ImageUrlInput2>?), TypeInfoPropertyName = "NullableAnyOfTextInputImageUrlInput22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ParsingJobStatus?), TypeInfoPropertyName = "NullableParsingJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.IntegrationProviderManifestProvider?), TypeInfoPropertyName = "NullableIntegrationProviderManifestProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.IntegrationProviderManifestAuthType?), TypeInfoPropertyName = "NullableIntegrationProviderManifestAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.IntegrationProviderManifestCapabilitie?), TypeInfoPropertyName = "NullableIntegrationProviderManifestCapabilitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.LinearDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableLinearDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreFileStatus?), TypeInfoPropertyName = "NullableStoreFileStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>>, object>?), TypeInfoPropertyName = "NullableAnyOfSearchFilterInputSearchFilterConditionIListAnyOfSearchFilterInputSearchFilterConditionObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>?), TypeInfoPropertyName = "NullableAnyOfSearchFilterInputSearchFilterCondition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<string, global::System.Guid?>?), TypeInfoPropertyName = "NullableAnyOfStringGuid2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>>, global::System.Collections.Generic.IList<global::System.Guid>, object>?), TypeInfoPropertyName = "NullableAnyOfIListAnyOfConditionOperatorIListGuidIListGuidObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>?), TypeInfoPropertyName = "NullableAnyOfConditionOperatorIListGuid2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.Mode?), TypeInfoPropertyName = "NullableMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MultiModalQuery?), TypeInfoPropertyName = "NullableMultiModalQuery2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MultiModalQueryVariant2?), TypeInfoPropertyName = "NullableMultiModalQueryVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MultiModalQueryVariant2DiscriminatorType?), TypeInfoPropertyName = "NullableMultiModalQueryVariant2DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableNotionDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<string, int?, double?, bool?, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<string, int?, double?, bool?>>, object>?), TypeInfoPropertyName = "NullableAnyOfStringInt32DoubleBooleanIListAnyOfStringInt32DoubleBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<string, int?, double?, bool?>?), TypeInfoPropertyName = "NullableAnyOfStringInt32DoubleBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.QueryEnhanceQueryItemFilterMode?), TypeInfoPropertyName = "NullableQueryEnhanceQueryItemFilterMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ItemsItem?), TypeInfoPropertyName = "NullableItemsItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.QueryEnhanceResultsItemDiscriminatorType?), TypeInfoPropertyName = "NullableQueryEnhanceResultsItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.QueryEnhanceSortItemFilterMode?), TypeInfoPropertyName = "NullableQueryEnhanceSortItemFilterMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.QueryEnhanceSortItemDirection?), TypeInfoPropertyName = "NullableQueryEnhanceSortItemDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.RegexFlag?), TypeInfoPropertyName = "NullableRegexFlag2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<string, object, global::System.Collections.Generic.IList<object>>?), TypeInfoPropertyName = "NullableAnyOfStringObjectIListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ScopeMethod?), TypeInfoPropertyName = "NullableScopeMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<string, global::System.Guid?, object>?), TypeInfoPropertyName = "NullableAnyOfStringGuidObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition>?), TypeInfoPropertyName = "NullableAnyOfSearchFilterOutputSearchFilterCondition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.SlackChannelSyncStatus?), TypeInfoPropertyName = "NullableSlackChannelSyncStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreStatus?), TypeInfoPropertyName = "NullableStoreStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition>>, object>?), TypeInfoPropertyName = "NullableAnyOfSearchFilterOutputSearchFilterConditionIListAnyOfSearchFilterOutputSearchFilterConditionObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<string, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<string, bool?>>, object>?), TypeInfoPropertyName = "NullableAnyOfStringIListAnyOfStringBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<string, bool?>?), TypeInfoPropertyName = "NullableAnyOfStringBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreChunkGrepTarget?), TypeInfoPropertyName = "NullableStoreChunkGrepTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<bool?, global::Mixedbread.RerankConfig, object>?), TypeInfoPropertyName = "NullableAnyOfBooleanRerankConfigObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<bool?, global::Mixedbread.AgenticSearchConfig, object>?), TypeInfoPropertyName = "NullableAnyOfBooleanAgenticSearchConfigObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<bool?, global::Mixedbread.ContextualizationConfig>?), TypeInfoPropertyName = "NullableAnyOfBooleanContextualizationConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreEventHistogramBucketType?), TypeInfoPropertyName = "NullableStoreEventHistogramBucketType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreEventHistogramParamsEventTypesVariant1Item?), TypeInfoPropertyName = "NullableStoreEventHistogramParamsEventTypesVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.DataItem?), TypeInfoPropertyName = "NullableDataItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreEventListResponseDataItemDiscriminatorType?), TypeInfoPropertyName = "NullableStoreEventListResponseDataItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ChunksVariant1Item?), TypeInfoPropertyName = "NullableChunksVariant1Item2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreFileChunksVariant1ItemDiscriminatorType?), TypeInfoPropertyName = "NullableStoreFileChunksVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreFileParsingStrategy?), TypeInfoPropertyName = "NullableStoreFileParsingStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.DataItem2?), TypeInfoPropertyName = "NullableDataItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreGrepResponseDataItemDiscriminatorType?), TypeInfoPropertyName = "NullableStoreGrepResponseDataItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.DataItem3?), TypeInfoPropertyName = "NullableDataItem32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreListChunksResponseDataItemDiscriminatorType?), TypeInfoPropertyName = "NullableStoreListChunksResponseDataItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.SourcesItem?), TypeInfoPropertyName = "NullableSourcesItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreQAResultsSourceDiscriminatorType?), TypeInfoPropertyName = "NullableStoreQAResultsSourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.DataItem4?), TypeInfoPropertyName = "NullableDataItem42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.StoreSearchResponseDataItemDiscriminatorType?), TypeInfoPropertyName = "NullableStoreSearchResponseDataItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.TextInputChunkGeneratedMetadataVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableTextInputChunkGeneratedMetadataVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ChunksVariant1Item2?), TypeInfoPropertyName = "NullableChunksVariant1Item22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.VectorStoreFileChunksVariant1ItemDiscriminatorType?), TypeInfoPropertyName = "NullableVectorStoreFileChunksVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.VectorStoreFileStatus?), TypeInfoPropertyName = "NullableVectorStoreFileStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.SourcesItem2?), TypeInfoPropertyName = "NullableSourcesItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.VectorStoreQAResultsSourceDiscriminatorType?), TypeInfoPropertyName = "NullableVectorStoreQAResultsSourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.DataItem5?), TypeInfoPropertyName = "NullableDataItem52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.VectorStoreSearchResponseDataItemDiscriminatorType?), TypeInfoPropertyName = "NullableVectorStoreSearchResponseDataItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableMxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.RulesItem?), TypeInfoPropertyName = "NullableRulesItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleCreateParamsRuleDiscriminatorType?), TypeInfoPropertyName = "NullableMxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleCreateParamsRuleDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.RulesItem2?), TypeInfoPropertyName = "NullableRulesItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleResponseRuleDiscriminatorType?), TypeInfoPropertyName = "NullableMxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleResponseRuleDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.Rule?), TypeInfoPropertyName = "NullableRule2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorType?), TypeInfoPropertyName = "NullableMxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.DeletedRule?), TypeInfoPropertyName = "NullableDeletedRule2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeletedDeletedRuleDiscriminatorType?), TypeInfoPropertyName = "NullableMxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeletedDeletedRuleDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.RulesVariant1Item?), TypeInfoPropertyName = "NullableRulesVariant1Item2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorType?), TypeInfoPropertyName = "NullableMxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.RulesItem3?), TypeInfoPropertyName = "NullableRulesItem32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleCreateParamsRuleDiscriminatorType?), TypeInfoPropertyName = "NullableMxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleCreateParamsRuleDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.RulesItem4?), TypeInfoPropertyName = "NullableRulesItem42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleResponseRuleDiscriminatorType?), TypeInfoPropertyName = "NullableMxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleResponseRuleDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.Rule2?), TypeInfoPropertyName = "NullableRule22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorType?), TypeInfoPropertyName = "NullableMxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.DeletedRule2?), TypeInfoPropertyName = "NullableDeletedRule22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeletedDeletedRuleDiscriminatorType?), TypeInfoPropertyName = "NullableMxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeletedDeletedRuleDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.RulesVariant1Item2?), TypeInfoPropertyName = "NullableRulesVariant1Item22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorType?), TypeInfoPropertyName = "NullableMxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableMxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableMxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableMxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableMxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<global::Mixedbread.NotionDataSourceCreateOrUpdateParams, global::Mixedbread.LinearDataSourceCreateOrUpdateParams>?), TypeInfoPropertyName = "NullableAnyOfNotionDataSourceCreateOrUpdateParamsLinearDataSourceCreateOrUpdateParams2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ListStoreEventsEventType?), TypeInfoPropertyName = "NullableListStoreEventsEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<bool?, global::System.Collections.Generic.IList<int>>?), TypeInfoPropertyName = "NullableAnyOfBooleanIListInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.Scope>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.ApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.Bucket>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.DataSourceInstallation>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.GoogleDriveFolder>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.GoogleDriveInstallationOverview>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.IntegrationInstallation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.IntegrationProviderManifest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.IntegrationProviderManifestCapabilitie>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.SlackChannel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.SlackInstallationOverview>))]
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
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

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
            options.Converters.Add(new global::Mixedbread.JsonConverters.GeneratedMetadataVariant1JsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.CredentialsJsonConverter());
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
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition>>, object>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition>());
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

            options.Converters.Add(new LazyEnumJsonConverterFactory());

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Mixedbread.AgenticSearchConfigMediaContent)

                    || typeToConvert == typeof(global::Mixedbread.AgenticSearchConfigMediaContent?)

                    || typeToConvert == typeof(global::Mixedbread.AgenticToolCallToolType)

                    || typeToConvert == typeof(global::Mixedbread.AgenticToolCallToolType?)

                    || typeToConvert == typeof(global::Mixedbread.AudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Mixedbread.AudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Mixedbread.BucketAuthType)

                    || typeToConvert == typeof(global::Mixedbread.BucketAuthType?)

                    || typeToConvert == typeof(global::Mixedbread.BucketCreateParamsCredentialsDiscriminatorType)

                    || typeToConvert == typeof(global::Mixedbread.BucketCreateParamsCredentialsDiscriminatorType?)

                    || typeToConvert == typeof(global::Mixedbread.BucketProvider)

                    || typeToConvert == typeof(global::Mixedbread.BucketProvider?)

                    || typeToConvert == typeof(global::Mixedbread.BucketStatus)

                    || typeToConvert == typeof(global::Mixedbread.BucketStatus?)

                    || typeToConvert == typeof(global::Mixedbread.ChunkingStrategy)

                    || typeToConvert == typeof(global::Mixedbread.ChunkingStrategy?)

                    || typeToConvert == typeof(global::Mixedbread.ConditionOperator)

                    || typeToConvert == typeof(global::Mixedbread.ConditionOperator?)

                    || typeToConvert == typeof(global::Mixedbread.DataSourceAuthParamsVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Mixedbread.DataSourceAuthParamsVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Mixedbread.DataSourceType)

                    || typeToConvert == typeof(global::Mixedbread.DataSourceType?)

                    || typeToConvert == typeof(global::Mixedbread.ElementType)

                    || typeToConvert == typeof(global::Mixedbread.ElementType?)

                    || typeToConvert == typeof(global::Mixedbread.EncodingFormat3)

                    || typeToConvert == typeof(global::Mixedbread.EncodingFormat3?)

                    || typeToConvert == typeof(global::Mixedbread.ImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Mixedbread.ImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Mixedbread.IntegrationProviderManifestProvider)

                    || typeToConvert == typeof(global::Mixedbread.IntegrationProviderManifestProvider?)

                    || typeToConvert == typeof(global::Mixedbread.IntegrationProviderManifestAuthType)

                    || typeToConvert == typeof(global::Mixedbread.IntegrationProviderManifestAuthType?)

                    || typeToConvert == typeof(global::Mixedbread.IntegrationProviderManifestCapabilitie)

                    || typeToConvert == typeof(global::Mixedbread.IntegrationProviderManifestCapabilitie?)

                    || typeToConvert == typeof(global::Mixedbread.IntegrationProviderManifestIngestionBacking2)

                    || typeToConvert == typeof(global::Mixedbread.IntegrationProviderManifestIngestionBacking2?)

                    || typeToConvert == typeof(global::Mixedbread.LinearDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Mixedbread.LinearDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Mixedbread.Mode)

                    || typeToConvert == typeof(global::Mixedbread.Mode?)

                    || typeToConvert == typeof(global::Mixedbread.MultiModalQueryVariant2DiscriminatorType)

                    || typeToConvert == typeof(global::Mixedbread.MultiModalQueryVariant2DiscriminatorType?)

                    || typeToConvert == typeof(global::Mixedbread.NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Mixedbread.NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Mixedbread.ParsingJobStatus)

                    || typeToConvert == typeof(global::Mixedbread.ParsingJobStatus?)

                    || typeToConvert == typeof(global::Mixedbread.QueryEnhanceQueryItemFilterMode)

                    || typeToConvert == typeof(global::Mixedbread.QueryEnhanceQueryItemFilterMode?)

                    || typeToConvert == typeof(global::Mixedbread.QueryEnhanceResultsItemDiscriminatorType)

                    || typeToConvert == typeof(global::Mixedbread.QueryEnhanceResultsItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Mixedbread.QueryEnhanceSortItemFilterMode)

                    || typeToConvert == typeof(global::Mixedbread.QueryEnhanceSortItemFilterMode?)

                    || typeToConvert == typeof(global::Mixedbread.QueryEnhanceSortItemDirection)

                    || typeToConvert == typeof(global::Mixedbread.QueryEnhanceSortItemDirection?)

                    || typeToConvert == typeof(global::Mixedbread.RegexFlag)

                    || typeToConvert == typeof(global::Mixedbread.RegexFlag?)

                    || typeToConvert == typeof(global::Mixedbread.ReturnFormat)

                    || typeToConvert == typeof(global::Mixedbread.ReturnFormat?)

                    || typeToConvert == typeof(global::Mixedbread.ScopeMethod)

                    || typeToConvert == typeof(global::Mixedbread.ScopeMethod?)

                    || typeToConvert == typeof(global::Mixedbread.SlackChannelSyncStatus)

                    || typeToConvert == typeof(global::Mixedbread.SlackChannelSyncStatus?)

                    || typeToConvert == typeof(global::Mixedbread.SlackChannelLastSyncStatus2)

                    || typeToConvert == typeof(global::Mixedbread.SlackChannelLastSyncStatus2?)

                    || typeToConvert == typeof(global::Mixedbread.StoreChunkGrepTarget)

                    || typeToConvert == typeof(global::Mixedbread.StoreChunkGrepTarget?)

                    || typeToConvert == typeof(global::Mixedbread.StoreEventHistogramBucketType)

                    || typeToConvert == typeof(global::Mixedbread.StoreEventHistogramBucketType?)

                    || typeToConvert == typeof(global::Mixedbread.StoreEventHistogramParamsEventTypesVariant1Item)

                    || typeToConvert == typeof(global::Mixedbread.StoreEventHistogramParamsEventTypesVariant1Item?)

                    || typeToConvert == typeof(global::Mixedbread.StoreEventListResponseDataItemDiscriminatorType)

                    || typeToConvert == typeof(global::Mixedbread.StoreEventListResponseDataItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Mixedbread.StoreFileChunksVariant1ItemDiscriminatorType)

                    || typeToConvert == typeof(global::Mixedbread.StoreFileChunksVariant1ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Mixedbread.StoreFileParsingStrategy)

                    || typeToConvert == typeof(global::Mixedbread.StoreFileParsingStrategy?)

                    || typeToConvert == typeof(global::Mixedbread.StoreFileStatus)

                    || typeToConvert == typeof(global::Mixedbread.StoreFileStatus?)

                    || typeToConvert == typeof(global::Mixedbread.StoreGrepResponseDataItemDiscriminatorType)

                    || typeToConvert == typeof(global::Mixedbread.StoreGrepResponseDataItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Mixedbread.StoreListChunksResponseDataItemDiscriminatorType)

                    || typeToConvert == typeof(global::Mixedbread.StoreListChunksResponseDataItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Mixedbread.StoreQAResultsSourceDiscriminatorType)

                    || typeToConvert == typeof(global::Mixedbread.StoreQAResultsSourceDiscriminatorType?)

                    || typeToConvert == typeof(global::Mixedbread.StoreSearchEventRewriteRankDirection2)

                    || typeToConvert == typeof(global::Mixedbread.StoreSearchEventRewriteRankDirection2?)

                    || typeToConvert == typeof(global::Mixedbread.StoreSearchEventRewriteRankMode2)

                    || typeToConvert == typeof(global::Mixedbread.StoreSearchEventRewriteRankMode2?)

                    || typeToConvert == typeof(global::Mixedbread.StoreSearchEventResultFirstStageSource2)

                    || typeToConvert == typeof(global::Mixedbread.StoreSearchEventResultFirstStageSource2?)

                    || typeToConvert == typeof(global::Mixedbread.StoreSearchResponseDataItemDiscriminatorType)

                    || typeToConvert == typeof(global::Mixedbread.StoreSearchResponseDataItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Mixedbread.StoreStatus)

                    || typeToConvert == typeof(global::Mixedbread.StoreStatus?)

                    || typeToConvert == typeof(global::Mixedbread.SyncStatus)

                    || typeToConvert == typeof(global::Mixedbread.SyncStatus?)

                    || typeToConvert == typeof(global::Mixedbread.TextInputChunkGeneratedMetadataVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Mixedbread.TextInputChunkGeneratedMetadataVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Mixedbread.VectorStoreFileChunksVariant1ItemDiscriminatorType)

                    || typeToConvert == typeof(global::Mixedbread.VectorStoreFileChunksVariant1ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Mixedbread.VectorStoreFileStatus)

                    || typeToConvert == typeof(global::Mixedbread.VectorStoreFileStatus?)

                    || typeToConvert == typeof(global::Mixedbread.VectorStoreQAResultsSourceDiscriminatorType)

                    || typeToConvert == typeof(global::Mixedbread.VectorStoreQAResultsSourceDiscriminatorType?)

                    || typeToConvert == typeof(global::Mixedbread.VectorStoreSearchResponseDataItemDiscriminatorType)

                    || typeToConvert == typeof(global::Mixedbread.VectorStoreSearchResponseDataItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Mixedbread.VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Mixedbread.VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleCreateParamsRuleDiscriminatorType)

                    || typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleCreateParamsRuleDiscriminatorType?)

                    || typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleResponseRuleDiscriminatorType)

                    || typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleResponseRuleDiscriminatorType?)

                    || typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorType)

                    || typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorType?)

                    || typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeletedDeletedRuleDiscriminatorType)

                    || typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeletedDeletedRuleDiscriminatorType?)

                    || typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorType)

                    || typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleCreateParamsRuleDiscriminatorType)

                    || typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleCreateParamsRuleDiscriminatorType?)

                    || typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleResponseRuleDiscriminatorType)

                    || typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleResponseRuleDiscriminatorType?)

                    || typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorType)

                    || typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorType?)

                    || typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeletedDeletedRuleDiscriminatorType)

                    || typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeletedDeletedRuleDiscriminatorType?)

                    || typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorType)

                    || typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Mixedbread.ListStoreEventsEventType)

                    || typeToConvert == typeof(global::Mixedbread.ListStoreEventsEventType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Mixedbread.AgenticSearchConfigMediaContent))
                {
                    return new global::Mixedbread.JsonConverters.AgenticSearchConfigMediaContentJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.AgenticSearchConfigMediaContent?))
                {
                    return new global::Mixedbread.JsonConverters.AgenticSearchConfigMediaContentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.AgenticToolCallToolType))
                {
                    return new global::Mixedbread.JsonConverters.AgenticToolCallToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.AgenticToolCallToolType?))
                {
                    return new global::Mixedbread.JsonConverters.AgenticToolCallToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.AudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType))
                {
                    return new global::Mixedbread.JsonConverters.AudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.AudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType?))
                {
                    return new global::Mixedbread.JsonConverters.AudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.BucketAuthType))
                {
                    return new global::Mixedbread.JsonConverters.BucketAuthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.BucketAuthType?))
                {
                    return new global::Mixedbread.JsonConverters.BucketAuthTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.BucketCreateParamsCredentialsDiscriminatorType))
                {
                    return new global::Mixedbread.JsonConverters.BucketCreateParamsCredentialsDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.BucketCreateParamsCredentialsDiscriminatorType?))
                {
                    return new global::Mixedbread.JsonConverters.BucketCreateParamsCredentialsDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.BucketProvider))
                {
                    return new global::Mixedbread.JsonConverters.BucketProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.BucketProvider?))
                {
                    return new global::Mixedbread.JsonConverters.BucketProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.BucketStatus))
                {
                    return new global::Mixedbread.JsonConverters.BucketStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.BucketStatus?))
                {
                    return new global::Mixedbread.JsonConverters.BucketStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.ChunkingStrategy))
                {
                    return new global::Mixedbread.JsonConverters.ChunkingStrategyJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.ChunkingStrategy?))
                {
                    return new global::Mixedbread.JsonConverters.ChunkingStrategyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.ConditionOperator))
                {
                    return new global::Mixedbread.JsonConverters.ConditionOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.ConditionOperator?))
                {
                    return new global::Mixedbread.JsonConverters.ConditionOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.DataSourceAuthParamsVariant1DiscriminatorType))
                {
                    return new global::Mixedbread.JsonConverters.DataSourceAuthParamsVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.DataSourceAuthParamsVariant1DiscriminatorType?))
                {
                    return new global::Mixedbread.JsonConverters.DataSourceAuthParamsVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.DataSourceType))
                {
                    return new global::Mixedbread.JsonConverters.DataSourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.DataSourceType?))
                {
                    return new global::Mixedbread.JsonConverters.DataSourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.ElementType))
                {
                    return new global::Mixedbread.JsonConverters.ElementTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.ElementType?))
                {
                    return new global::Mixedbread.JsonConverters.ElementTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.EncodingFormat3))
                {
                    return new global::Mixedbread.JsonConverters.EncodingFormat3JsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.EncodingFormat3?))
                {
                    return new global::Mixedbread.JsonConverters.EncodingFormat3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.ImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType))
                {
                    return new global::Mixedbread.JsonConverters.ImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.ImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType?))
                {
                    return new global::Mixedbread.JsonConverters.ImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.IntegrationProviderManifestProvider))
                {
                    return new global::Mixedbread.JsonConverters.IntegrationProviderManifestProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.IntegrationProviderManifestProvider?))
                {
                    return new global::Mixedbread.JsonConverters.IntegrationProviderManifestProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.IntegrationProviderManifestAuthType))
                {
                    return new global::Mixedbread.JsonConverters.IntegrationProviderManifestAuthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.IntegrationProviderManifestAuthType?))
                {
                    return new global::Mixedbread.JsonConverters.IntegrationProviderManifestAuthTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.IntegrationProviderManifestCapabilitie))
                {
                    return new global::Mixedbread.JsonConverters.IntegrationProviderManifestCapabilitieJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.IntegrationProviderManifestCapabilitie?))
                {
                    return new global::Mixedbread.JsonConverters.IntegrationProviderManifestCapabilitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.IntegrationProviderManifestIngestionBacking2))
                {
                    return new global::Mixedbread.JsonConverters.IntegrationProviderManifestIngestionBacking2JsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.IntegrationProviderManifestIngestionBacking2?))
                {
                    return new global::Mixedbread.JsonConverters.IntegrationProviderManifestIngestionBacking2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.LinearDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType))
                {
                    return new global::Mixedbread.JsonConverters.LinearDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.LinearDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType?))
                {
                    return new global::Mixedbread.JsonConverters.LinearDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.Mode))
                {
                    return new global::Mixedbread.JsonConverters.ModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.Mode?))
                {
                    return new global::Mixedbread.JsonConverters.ModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.MultiModalQueryVariant2DiscriminatorType))
                {
                    return new global::Mixedbread.JsonConverters.MultiModalQueryVariant2DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.MultiModalQueryVariant2DiscriminatorType?))
                {
                    return new global::Mixedbread.JsonConverters.MultiModalQueryVariant2DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType))
                {
                    return new global::Mixedbread.JsonConverters.NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType?))
                {
                    return new global::Mixedbread.JsonConverters.NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.ParsingJobStatus))
                {
                    return new global::Mixedbread.JsonConverters.ParsingJobStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.ParsingJobStatus?))
                {
                    return new global::Mixedbread.JsonConverters.ParsingJobStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.QueryEnhanceQueryItemFilterMode))
                {
                    return new global::Mixedbread.JsonConverters.QueryEnhanceQueryItemFilterModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.QueryEnhanceQueryItemFilterMode?))
                {
                    return new global::Mixedbread.JsonConverters.QueryEnhanceQueryItemFilterModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.QueryEnhanceResultsItemDiscriminatorType))
                {
                    return new global::Mixedbread.JsonConverters.QueryEnhanceResultsItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.QueryEnhanceResultsItemDiscriminatorType?))
                {
                    return new global::Mixedbread.JsonConverters.QueryEnhanceResultsItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.QueryEnhanceSortItemFilterMode))
                {
                    return new global::Mixedbread.JsonConverters.QueryEnhanceSortItemFilterModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.QueryEnhanceSortItemFilterMode?))
                {
                    return new global::Mixedbread.JsonConverters.QueryEnhanceSortItemFilterModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.QueryEnhanceSortItemDirection))
                {
                    return new global::Mixedbread.JsonConverters.QueryEnhanceSortItemDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.QueryEnhanceSortItemDirection?))
                {
                    return new global::Mixedbread.JsonConverters.QueryEnhanceSortItemDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.RegexFlag))
                {
                    return new global::Mixedbread.JsonConverters.RegexFlagJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.RegexFlag?))
                {
                    return new global::Mixedbread.JsonConverters.RegexFlagNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.ReturnFormat))
                {
                    return new global::Mixedbread.JsonConverters.ReturnFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.ReturnFormat?))
                {
                    return new global::Mixedbread.JsonConverters.ReturnFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.ScopeMethod))
                {
                    return new global::Mixedbread.JsonConverters.ScopeMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.ScopeMethod?))
                {
                    return new global::Mixedbread.JsonConverters.ScopeMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.SlackChannelSyncStatus))
                {
                    return new global::Mixedbread.JsonConverters.SlackChannelSyncStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.SlackChannelSyncStatus?))
                {
                    return new global::Mixedbread.JsonConverters.SlackChannelSyncStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.SlackChannelLastSyncStatus2))
                {
                    return new global::Mixedbread.JsonConverters.SlackChannelLastSyncStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.SlackChannelLastSyncStatus2?))
                {
                    return new global::Mixedbread.JsonConverters.SlackChannelLastSyncStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.StoreChunkGrepTarget))
                {
                    return new global::Mixedbread.JsonConverters.StoreChunkGrepTargetJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.StoreChunkGrepTarget?))
                {
                    return new global::Mixedbread.JsonConverters.StoreChunkGrepTargetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.StoreEventHistogramBucketType))
                {
                    return new global::Mixedbread.JsonConverters.StoreEventHistogramBucketTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.StoreEventHistogramBucketType?))
                {
                    return new global::Mixedbread.JsonConverters.StoreEventHistogramBucketTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.StoreEventHistogramParamsEventTypesVariant1Item))
                {
                    return new global::Mixedbread.JsonConverters.StoreEventHistogramParamsEventTypesVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.StoreEventHistogramParamsEventTypesVariant1Item?))
                {
                    return new global::Mixedbread.JsonConverters.StoreEventHistogramParamsEventTypesVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.StoreEventListResponseDataItemDiscriminatorType))
                {
                    return new global::Mixedbread.JsonConverters.StoreEventListResponseDataItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.StoreEventListResponseDataItemDiscriminatorType?))
                {
                    return new global::Mixedbread.JsonConverters.StoreEventListResponseDataItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.StoreFileChunksVariant1ItemDiscriminatorType))
                {
                    return new global::Mixedbread.JsonConverters.StoreFileChunksVariant1ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.StoreFileChunksVariant1ItemDiscriminatorType?))
                {
                    return new global::Mixedbread.JsonConverters.StoreFileChunksVariant1ItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.StoreFileParsingStrategy))
                {
                    return new global::Mixedbread.JsonConverters.StoreFileParsingStrategyJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.StoreFileParsingStrategy?))
                {
                    return new global::Mixedbread.JsonConverters.StoreFileParsingStrategyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.StoreFileStatus))
                {
                    return new global::Mixedbread.JsonConverters.StoreFileStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.StoreFileStatus?))
                {
                    return new global::Mixedbread.JsonConverters.StoreFileStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.StoreGrepResponseDataItemDiscriminatorType))
                {
                    return new global::Mixedbread.JsonConverters.StoreGrepResponseDataItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.StoreGrepResponseDataItemDiscriminatorType?))
                {
                    return new global::Mixedbread.JsonConverters.StoreGrepResponseDataItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.StoreListChunksResponseDataItemDiscriminatorType))
                {
                    return new global::Mixedbread.JsonConverters.StoreListChunksResponseDataItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.StoreListChunksResponseDataItemDiscriminatorType?))
                {
                    return new global::Mixedbread.JsonConverters.StoreListChunksResponseDataItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.StoreQAResultsSourceDiscriminatorType))
                {
                    return new global::Mixedbread.JsonConverters.StoreQAResultsSourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.StoreQAResultsSourceDiscriminatorType?))
                {
                    return new global::Mixedbread.JsonConverters.StoreQAResultsSourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.StoreSearchEventRewriteRankDirection2))
                {
                    return new global::Mixedbread.JsonConverters.StoreSearchEventRewriteRankDirection2JsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.StoreSearchEventRewriteRankDirection2?))
                {
                    return new global::Mixedbread.JsonConverters.StoreSearchEventRewriteRankDirection2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.StoreSearchEventRewriteRankMode2))
                {
                    return new global::Mixedbread.JsonConverters.StoreSearchEventRewriteRankMode2JsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.StoreSearchEventRewriteRankMode2?))
                {
                    return new global::Mixedbread.JsonConverters.StoreSearchEventRewriteRankMode2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.StoreSearchEventResultFirstStageSource2))
                {
                    return new global::Mixedbread.JsonConverters.StoreSearchEventResultFirstStageSource2JsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.StoreSearchEventResultFirstStageSource2?))
                {
                    return new global::Mixedbread.JsonConverters.StoreSearchEventResultFirstStageSource2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.StoreSearchResponseDataItemDiscriminatorType))
                {
                    return new global::Mixedbread.JsonConverters.StoreSearchResponseDataItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.StoreSearchResponseDataItemDiscriminatorType?))
                {
                    return new global::Mixedbread.JsonConverters.StoreSearchResponseDataItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.StoreStatus))
                {
                    return new global::Mixedbread.JsonConverters.StoreStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.StoreStatus?))
                {
                    return new global::Mixedbread.JsonConverters.StoreStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.SyncStatus))
                {
                    return new global::Mixedbread.JsonConverters.SyncStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.SyncStatus?))
                {
                    return new global::Mixedbread.JsonConverters.SyncStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.TextInputChunkGeneratedMetadataVariant1DiscriminatorType))
                {
                    return new global::Mixedbread.JsonConverters.TextInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.TextInputChunkGeneratedMetadataVariant1DiscriminatorType?))
                {
                    return new global::Mixedbread.JsonConverters.TextInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.VectorStoreFileChunksVariant1ItemDiscriminatorType))
                {
                    return new global::Mixedbread.JsonConverters.VectorStoreFileChunksVariant1ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.VectorStoreFileChunksVariant1ItemDiscriminatorType?))
                {
                    return new global::Mixedbread.JsonConverters.VectorStoreFileChunksVariant1ItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.VectorStoreFileStatus))
                {
                    return new global::Mixedbread.JsonConverters.VectorStoreFileStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.VectorStoreFileStatus?))
                {
                    return new global::Mixedbread.JsonConverters.VectorStoreFileStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.VectorStoreQAResultsSourceDiscriminatorType))
                {
                    return new global::Mixedbread.JsonConverters.VectorStoreQAResultsSourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.VectorStoreQAResultsSourceDiscriminatorType?))
                {
                    return new global::Mixedbread.JsonConverters.VectorStoreQAResultsSourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.VectorStoreSearchResponseDataItemDiscriminatorType))
                {
                    return new global::Mixedbread.JsonConverters.VectorStoreSearchResponseDataItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.VectorStoreSearchResponseDataItemDiscriminatorType?))
                {
                    return new global::Mixedbread.JsonConverters.VectorStoreSearchResponseDataItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType))
                {
                    return new global::Mixedbread.JsonConverters.VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType?))
                {
                    return new global::Mixedbread.JsonConverters.VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType))
                {
                    return new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType?))
                {
                    return new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType))
                {
                    return new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType?))
                {
                    return new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorType))
                {
                    return new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorType?))
                {
                    return new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType))
                {
                    return new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType?))
                {
                    return new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleCreateParamsRuleDiscriminatorType))
                {
                    return new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleCreateParamsRuleDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleCreateParamsRuleDiscriminatorType?))
                {
                    return new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleCreateParamsRuleDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleResponseRuleDiscriminatorType))
                {
                    return new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleResponseRuleDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleResponseRuleDiscriminatorType?))
                {
                    return new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleResponseRuleDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorType))
                {
                    return new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorType?))
                {
                    return new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeletedDeletedRuleDiscriminatorType))
                {
                    return new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeletedDeletedRuleDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeletedDeletedRuleDiscriminatorType?))
                {
                    return new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeletedDeletedRuleDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorType))
                {
                    return new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorType?))
                {
                    return new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleCreateParamsRuleDiscriminatorType))
                {
                    return new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleCreateParamsRuleDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleCreateParamsRuleDiscriminatorType?))
                {
                    return new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleCreateParamsRuleDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleResponseRuleDiscriminatorType))
                {
                    return new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleResponseRuleDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleResponseRuleDiscriminatorType?))
                {
                    return new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleResponseRuleDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorType))
                {
                    return new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorType?))
                {
                    return new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeletedDeletedRuleDiscriminatorType))
                {
                    return new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeletedDeletedRuleDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeletedDeletedRuleDiscriminatorType?))
                {
                    return new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeletedDeletedRuleDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorType))
                {
                    return new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorType?))
                {
                    return new global::Mixedbread.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType))
                {
                    return new global::Mixedbread.JsonConverters.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType?))
                {
                    return new global::Mixedbread.JsonConverters.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType))
                {
                    return new global::Mixedbread.JsonConverters.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType?))
                {
                    return new global::Mixedbread.JsonConverters.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorType))
                {
                    return new global::Mixedbread.JsonConverters.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorType?))
                {
                    return new global::Mixedbread.JsonConverters.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType))
                {
                    return new global::Mixedbread.JsonConverters.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType?))
                {
                    return new global::Mixedbread.JsonConverters.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.ListStoreEventsEventType))
                {
                    return new global::Mixedbread.JsonConverters.ListStoreEventsEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.ListStoreEventsEventType?))
                {
                    return new global::Mixedbread.JsonConverters.ListStoreEventsEventTypeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[2];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new SourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new SourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}