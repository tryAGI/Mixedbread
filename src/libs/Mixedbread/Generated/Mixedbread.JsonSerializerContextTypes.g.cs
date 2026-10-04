
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Mixedbread
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.AgenticSearchConfig? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.AgenticSearchConfigMediaContent? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.AgenticSearchTokenUsage? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.AgenticToolCall? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.AgenticToolCallToolType? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.ApiKey? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.Scope>? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.Scope? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.ApiKeyCreateOrUpdateParams? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.ApiKeyCreateParams? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.ApiKeyCreated? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.ApiKeyDeleted? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.ApiKeyListResponse? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.PaginationWithTotal? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.ApiKey>? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.ApiKeyUpdateParams? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.AudioChunkGeneratedMetadata? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.AudioUrl? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.AudioUrlInputChunk? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.GeneratedMetadataVariant1? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MarkdownChunkGeneratedMetadata? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.TextChunkGeneratedMetadata? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.PDFChunkGeneratedMetadata? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.CodeChunkGeneratedMetadata? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.VideoChunkGeneratedMetadata? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.ImageChunkGeneratedMetadata? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.AudioUrlInputChunkGeneratedMetadataVariant1Discriminator? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.AudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.BalanceInfo? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.BillingPeriodSummary? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.Period? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.CostInfo? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Mixedbread.UsageInfo>? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.UsageInfo? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.BodyCreateFile? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.BodyUpdateFile? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.BodyUploadStoreFile? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.Bucket? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.BucketProvider? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.BucketAuthType? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.BucketStatus? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.BucketAccessKeyCredentials? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.BucketAssumeRoleCredentials? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.BucketCreateParams? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.Credentials? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.BucketCreateParamsCredentialsDiscriminator? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.BucketCreateParamsCredentialsDiscriminatorType? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.BucketListResponse? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.CursorPaginationResponse? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.Bucket>? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.BucketRotateCredentialsParams? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.Chunk? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.ChunkElement>? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.ChunkElement? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.ElementType? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.ChunkSearchResultRule? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.ChunkingStrategy? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.CompleteMultipartUploadRequest? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.MultipartUploadPart>? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MultipartUploadPart? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.ConditionOperator? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.ConnectorListResponse? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.DataSourceConnector>? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.DataSourceConnector? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.ContextualizationConfig? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.AnyOf<bool?, global::System.Collections.Generic.IList<string>>? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.CostHistogramResponse? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.DailyCostBucket>? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.DailyCostBucket? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.PhaseCostInfo>? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.PhaseCostInfo? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.ProductCostInfo>? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.ProductCostInfo? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.CreateMultipartUploadRequest? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.CreateMultipartUploadResponse? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.MultipartUploadPartUrl>? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MultipartUploadPartUrl? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.CreatedJsonSchema? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.DataSource? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.DataSourceType? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.AuthParamsVariant1? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.DataSourceOAuth2Params? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.DataSourceApiKeyParams? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.DataSourceAuthParamsVariant1Discriminator? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.DataSourceAuthParamsVariant1DiscriminatorType? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.SyncStatus? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.DataSourceConnectorCreateParams? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.AnyOf<int?, string>? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.DataSourceConnectorDeleted? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.DataSourceConnectorUpdateParams? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.DataSourceDeleted? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.DataSourceInstallation? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.DataSourceInstallationListResponse? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.DataSourceInstallation>? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.DataSourceListResponse? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.DataSource>? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.DeprecatedStoreFileUpsertParams? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.StoreFileConfig? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.DocumentParserResult? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.ReturnFormat? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.ElementType>? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.Chunk>? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.Embedding? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.EmbeddingItem? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.EmbeddingCreateParams? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.AnyOf<string, global::System.Collections.Generic.IList<string>>? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.AnyOf<global::Mixedbread.EncodingFormat3?, global::System.Collections.Generic.IList<global::Mixedbread.EncodingFormat3>>? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.EncodingFormat3? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.EncodingFormat3>? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.EmbeddingCreateResponse? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.Usage? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.AnyOf<global::System.Collections.Generic.IList<global::Mixedbread.Embedding>, global::System.Collections.Generic.IList<global::Mixedbread.MultiEncodingEmbedding>>? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.Embedding>? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.MultiEncodingEmbedding>? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MultiEncodingEmbedding? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.EnhancedJsonSchema? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.ErrorResponse? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.InnerErrorResponse? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.ExpiresAfter? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.ExtractContentCreateParams? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.AnyOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.TextInput, global::Mixedbread.ImageUrlInput2>>>? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.TextInput, global::Mixedbread.ImageUrlInput2>>? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.AnyOf<global::Mixedbread.TextInput, global::Mixedbread.ImageUrlInput2>? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.TextInput? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.ImageUrlInput2? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.ExtractJobCreateParams? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.ExtractionJob? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.ParsingJobStatus? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.ExtractionResult? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.FileCounts? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.FileDeleted? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.FileListResponse? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.FileObject>? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.FileObject? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.FileSearchResultRule? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.GoogleDriveFolder? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.GoogleDriveFolderSelection? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.GoogleDriveFolder>? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.GoogleDriveFolderSelectionResponse? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.GoogleDriveFolderSelectionUpdate? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.GoogleDriveFolderSelectionUpdateParams? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.GoogleDriveFolderSelectionUpdateResponse? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.GoogleDriveInstallationConfigUpdateBody? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.GoogleDriveInstallationOverview? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.GoogleDriveInstallationOverviewListResponse? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.GoogleDriveInstallationOverview>? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.GoogleDriveSync? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.GoogleDriveSyncParams? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.GoogleDriveSyncResponse? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.HTTPValidationError? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.ValidationError>? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.ValidationError? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.ImageUrlInput? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.ImageUrlOutput? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.ImageUrlInputChunk? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.GeneratedMetadataVariant12? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.ImageUrlInputChunkGeneratedMetadataVariant1Discriminator? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.ImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.InfoResponse? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.IntegrationInstallation? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.IntegrationInstallationListResponse? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.IntegrationInstallation>? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.IntegrationInstallationResponse? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.IntegrationProviderListResponse? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.IntegrationProviderManifest>? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.IntegrationProviderManifest? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.IntegrationProviderManifestProvider? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.IntegrationProviderManifestAuthType? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.IntegrationProviderManifestCapabilitie>? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.IntegrationProviderManifestCapabilitie? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.IntegrationProviderManifestIngestionBacking? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.JsonSchemaCreateParams? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.JsonSchemaEnhanceParams? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.JsonSchemaValidateParams? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.LinearDataSourceCreateOrUpdateParams? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.AuthParamsVariant12? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.OAuth2CreateOrUpdateParams? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.LinearDataSourceCreateOrUpdateParamsAuthParamsVariant1Discriminator? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.LinearDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.MarkdownHeading>? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MarkdownHeading? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MetadataCursorPagination? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.StoreFileStatus>? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.StoreFileStatus? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>>>? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.SearchFilterInput? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.SearchFilterCondition? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>>? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MetadataFacets? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MetadataFacetsParams? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<string, global::System.Guid?>>? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.AnyOf<string, global::System.Guid?>? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.AnyOf<global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>>, global::System.Collections.Generic.IList<global::System.Guid>>? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>>? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.AnyOf<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Guid>? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.StoreChunkSearchOptions? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.Mode? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MultipleEncodingsEmbeddingItem? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MultiModalQuery? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MultiModalQueryVariant2? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MultiModalQueryVariant2Discriminator? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MultiModalQueryVariant2DiscriminatorType? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MultipartUploadDetailResponse? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MultipartUploadListResponse? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.MultipartUploadObject>? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MultipartUploadObject? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.NotionDataSourceCreateOrUpdateParams? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.AuthParamsVariant13? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1Discriminator? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.ParsingJob? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.ParsingJobCreateParams? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.ParsingJobDeleted? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.ParsingJobListItem? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.ParsingJobListResponse? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.ParsingJobListItem>? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.QueryEnhanceMetadataFilter? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.AnyOf<string, int?, double?, bool?, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<string, int?, double?, bool?>>>? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<string, int?, double?, bool?>>? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.AnyOf<string, int?, double?, bool?>? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.QueryEnhanceParams? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.QueryEnhanceQueryItem? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.QueryEnhanceMetadataFilter>? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.QueryEnhanceQueryItemFilterMode? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.QueryEnhanceResults? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.ItemsItem>? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.ItemsItem? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.QueryEnhanceSortItem? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.QueryEnhanceResultsItemDiscriminator? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.QueryEnhanceResultsItemDiscriminatorType? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.QueryEnhanceSortItemFilterMode? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.QueryEnhanceSortItemDirection? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.QueryRegexSubstitutionRule? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.RegexFlag>? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.RegexFlag? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.QueryStringSubstitutionRule? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.QuestionAnsweringOptions? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.RankedDocument? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.RerankConfig? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.RerankParams? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<string, object, global::System.Collections.Generic.IList<object>>>? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.AnyOf<string, object, global::System.Collections.Generic.IList<object>>? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.RerankResponse? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.RankedDocument>? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.ScopeMethod? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.SearchCursorPagination? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.SearchFilterOutput? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition>>? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition>? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.SlackChannel? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.SlackChannelSyncStatus? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.SlackChannelLastSyncStatus? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.SlackChannelSelection? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.SlackChannel>? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.SlackChannelSelectionResponse? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.SlackChannelSelectionUpdate? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.SlackChannelSelectionUpdateParams? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.SlackChannelSelectionUpdateResponse? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.SlackChannelSync? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.SlackChannelSyncParams? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.SlackChannelSyncResponse? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.SlackInstallationConfigUpdateBody? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.SlackInstallationOverview? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.SlackInstallationOverviewListResponse? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.SlackInstallationOverview>? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.SlackManifestResponse? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.SlackManualConnectBody? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.Store? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.StoreConfig? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.StoreStatus? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.StoreAgenticSearchEvent? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition>>>? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.AgenticToolCall>? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.StoreSearchEventResult>? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.StoreSearchEventResult? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.StoreChunkFilterParams? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.AnyOf<string, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<string, bool?>>>? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<string, bool?>>? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.AnyOf<string, bool?>? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.StoreChunkGrepParams? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.StoreChunkGrepTarget>? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.StoreChunkGrepTarget? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.AnyOf<bool?, global::Mixedbread.RerankConfig>? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.AnyOf<bool?, global::Mixedbread.AgenticSearchConfig>? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.StoreChunkSearchParams? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.AnyOf<bool?, global::Mixedbread.ContextualizationConfig>? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.StoreCostInfo? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.StoreCostListResponse? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.StoreCostInfo>? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.StoreCreateParams? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.StoreDeleted? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.StoreEventHistogramBucket? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.StoreEventHistogramBucketType? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.StoreEventHistogramParams? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.StoreEventHistogramParamsEventTypesVariant1Item>? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.StoreEventHistogramParamsEventTypesVariant1Item? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.StoreEventHistogramResponse? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.StoreEventHistogramBucket>? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.StoreEventListResponse? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.DataItem>? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.DataItem? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.StoreIngestionEvent? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.StoreSearchEvent? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.StoreGrepEvent? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.StoreEventListResponseDataItemDiscriminator? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.StoreEventListResponseDataItemDiscriminatorType? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.StoreFile? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.ChunksVariant1Item>? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.ChunksVariant1Item? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.TextInputChunk? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.VideoUrlInputChunk? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.StoreFileChunksVariant1ItemDiscriminator? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.StoreFileChunksVariant1ItemDiscriminatorType? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.StoreFileParsingStrategy? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.StoreFileDeleted? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.StoreFileListResponse? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.StoreFile>? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.StoreFileMetadataUpdateParams? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.StoreGrepResponse? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.DataItem2>? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.DataItem2? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunk? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunk? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunk? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunk? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.StoreGrepResponseDataItemDiscriminator? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.StoreGrepResponseDataItemDiscriminatorType? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.StoreListChunksResponse? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.DataItem3>? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.DataItem3? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.StoreListChunksResponseDataItemDiscriminator? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.StoreListChunksResponseDataItemDiscriminatorType? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.StoreListResponse? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.Store>? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.StoreQAParams? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.StoreQAResults? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.SourcesItem>? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.SourcesItem? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.StoreQAResultsSourceDiscriminator? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.StoreQAResultsSourceDiscriminatorType? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.StoreSearchEventRewriteRankDirection? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.StoreSearchEventRewriteRankMode? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.StoreSearchEventResultFirstStageSource? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.StoreSearchResponse? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.DataItem4>? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.DataItem4? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.StoreSearchResponseDataItemDiscriminator? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.StoreSearchResponseDataItemDiscriminatorType? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.StoreUpdateParams? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.GeneratedMetadataVariant13? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.TextInputChunkGeneratedMetadataVariant1Discriminator? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.TextInputChunkGeneratedMetadataVariant1DiscriminatorType? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.ValidatedJsonSchema? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<string, int?>>? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.AnyOf<string, int?>? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.VectorStore? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.VectorStoreChunkSearchOptions? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.VectorStoreChunkSearchParams? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.VectorStoreCreateParams? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.VectorStoreDeleted? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.VectorStoreFile? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.ChunksVariant1Item2>? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.ChunksVariant1Item2? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.VectorStoreFileChunksVariant1ItemDiscriminator? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.VectorStoreFileChunksVariant1ItemDiscriminatorType? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.VectorStoreFileDeleted? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.VectorStoreFileListResponse? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.VectorStoreFile>? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.VectorStoreFileStatus? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.VectorStoreListResponse? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.VectorStore>? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.VectorStoreQAParams? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.VectorStoreQAResults? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.SourcesItem2>? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.SourcesItem2? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunk? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunk? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunk? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunk? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.VectorStoreQAResultsSourceDiscriminator? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.VectorStoreQAResultsSourceDiscriminatorType? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.VectorStoreSearchResponse? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.DataItem5>? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.DataItem5? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.VectorStoreSearchResponseDataItemDiscriminator? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.VectorStoreSearchResponseDataItemDiscriminatorType? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.VectorStoreUpdateParams? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.VideoUrl? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.GeneratedMetadataVariant14? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.VideoUrlInputChunkGeneratedMetadataVariant1Discriminator? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.GeneratedMetadataVariant15? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunkGeneratedMetadataVariant1Discriminator? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.GeneratedMetadataVariant16? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunkGeneratedMetadataVariant1Discriminator? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.GeneratedMetadataVariant17? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunkGeneratedMetadataVariant1Discriminator? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorType? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.GeneratedMetadataVariant18? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunkGeneratedMetadataVariant1Discriminator? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleCreateParams? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.RulesItem>? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.RulesItem? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleCreateParamsRuleDiscriminator? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleCreateParamsRuleDiscriminatorType? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleDeleted? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleResponse? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.RulesItem2>? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.RulesItem2? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleResponseRuleDiscriminator? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleResponseRuleDiscriminatorType? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeleteParams? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.Rule? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeleteParamsRuleDiscriminator? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorType? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeleted? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.DeletedRule? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeletedDeletedRuleDiscriminator? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeletedDeletedRuleDiscriminatorType? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleUpdateParams? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.RulesVariant1Item>? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.RulesVariant1Item? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminator? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorType? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleCreateParams? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.RulesItem3>? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.RulesItem3? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleCreateParamsRuleDiscriminator? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleCreateParamsRuleDiscriminatorType? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleDeleted? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleResponse? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.RulesItem4>? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.RulesItem4? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleResponseRuleDiscriminator? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleResponseRuleDiscriminatorType? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParams? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.Rule2? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParamsRuleDiscriminator? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorType? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleted? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.DeletedRule2? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeletedDeletedRuleDiscriminator? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeletedDeletedRuleDiscriminatorType? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleUpdateParams? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.RulesVariant1Item2>? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.RulesVariant1Item2? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminator? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorType? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.GeneratedMetadataVariant19? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunkGeneratedMetadataVariant1Discriminator? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.GeneratedMetadataVariant110? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunkGeneratedMetadataVariant1Discriminator? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.GeneratedMetadataVariant111? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunkGeneratedMetadataVariant1Discriminator? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorType? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.GeneratedMetadataVariant112? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunkGeneratedMetadataVariant1Discriminator? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.AnyOf<global::Mixedbread.NotionDataSourceCreateOrUpdateParams, global::Mixedbread.LinearDataSourceCreateOrUpdateParams>? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.VectorStoreFileStatus>? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.ListStoreEventsEventType? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.AnyOf<bool?, global::System.Collections.Generic.IList<int>>? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mixedbread.ParsingJobStatus>? Type482 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.Scope>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.ApiKey>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.Bucket>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.ChunkElement>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.MultipartUploadPart>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.DataSourceConnector>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.AnyOf<bool?, global::System.Collections.Generic.List<string>>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.DailyCostBucket>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.PhaseCostInfo>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.ProductCostInfo>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.MultipartUploadPartUrl>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.DataSourceInstallation>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.DataSource>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.ElementType>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.Chunk>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.AnyOf<string, global::System.Collections.Generic.List<string>>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.AnyOf<global::Mixedbread.EncodingFormat3?, global::System.Collections.Generic.List<global::Mixedbread.EncodingFormat3>>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.EncodingFormat3>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.AnyOf<global::System.Collections.Generic.List<global::Mixedbread.Embedding>, global::System.Collections.Generic.List<global::Mixedbread.MultiEncodingEmbedding>>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.Embedding>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.MultiEncodingEmbedding>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.AnyOf<string, global::System.Collections.Generic.List<string>, global::System.Collections.Generic.List<global::Mixedbread.AnyOf<global::Mixedbread.TextInput, global::Mixedbread.ImageUrlInput2>>>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.AnyOf<global::Mixedbread.TextInput, global::Mixedbread.ImageUrlInput2>>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.FileObject>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.GoogleDriveFolder>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.GoogleDriveInstallationOverview>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.ValidationError>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.IntegrationInstallation>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.IntegrationProviderManifest>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.IntegrationProviderManifestCapabilitie>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.MarkdownHeading>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.StoreFileStatus>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.List<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>>>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.AnyOf<string, global::System.Guid?>>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.AnyOf<global::System.Collections.Generic.List<global::Mixedbread.AnyOf<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.List<global::System.Guid>>>, global::System.Collections.Generic.List<global::System.Guid>>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.AnyOf<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.List<global::System.Guid>>>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.AnyOf<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.List<global::System.Guid>>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Guid>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.MultipartUploadObject>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.ParsingJobListItem>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.AnyOf<string, int?, double?, bool?, global::System.Collections.Generic.List<global::Mixedbread.AnyOf<string, int?, double?, bool?>>>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.AnyOf<string, int?, double?, bool?>>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.QueryEnhanceMetadataFilter>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.ItemsItem>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.RegexFlag>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.AnyOf<string, object, global::System.Collections.Generic.List<object>>>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.AnyOf<string, object, global::System.Collections.Generic.List<object>>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.RankedDocument>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition>>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.SlackChannel>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.SlackInstallationOverview>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.List<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition>>>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.AgenticToolCall>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.StoreSearchEventResult>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.AnyOf<string, global::System.Collections.Generic.List<global::Mixedbread.AnyOf<string, bool?>>>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.AnyOf<string, bool?>>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.StoreChunkGrepTarget>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.StoreCostInfo>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.StoreEventHistogramParamsEventTypesVariant1Item>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.StoreEventHistogramBucket>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.DataItem>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.ChunksVariant1Item>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.StoreFile>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.DataItem2>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.DataItem3>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.Store>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.SourcesItem>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.DataItem4>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.AnyOf<string, int?>>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.ChunksVariant1Item2>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.VectorStoreFile>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.VectorStore>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.SourcesItem2>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.DataItem5>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.RulesItem>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.RulesItem2>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.RulesVariant1Item>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.RulesItem3>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.RulesItem4>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.RulesVariant1Item2>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.VectorStoreFileStatus>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.AnyOf<bool?, global::System.Collections.Generic.List<int>>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Mixedbread.ParsingJobStatus>? ListType88 { get; set; }
    }
}