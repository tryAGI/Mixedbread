
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Type of the event
    /// </summary>
    public enum StoreEventHistogramBucketType
    {
        /// <summary>
        /// 
        /// </summary>
        InferenceEmbeddings,
        /// <summary>
        /// 
        /// </summary>
        InferenceReranking,
        /// <summary>
        /// 
        /// </summary>
        ModelRequest,
        /// <summary>
        /// 
        /// </summary>
        InternalError,
        /// <summary>
        /// 
        /// </summary>
        StoreCreated,
        /// <summary>
        /// 
        /// </summary>
        StoreDeleted,
        /// <summary>
        /// 
        /// </summary>
        StoreUpdated,
        /// <summary>
        /// 
        /// </summary>
        StoreSearch,
        /// <summary>
        /// 
        /// </summary>
        StoreWebSearch,
        /// <summary>
        /// 
        /// </summary>
        StoreFileCreated,
        /// <summary>
        /// 
        /// </summary>
        StoreFileDeleted,
        /// <summary>
        /// 
        /// </summary>
        StoreFileUpdated,
        /// <summary>
        /// 
        /// </summary>
        StoreFileSearch,
        /// <summary>
        /// 
        /// </summary>
        StoreQuestionAnswer,
        /// <summary>
        /// 
        /// </summary>
        StoreFileCompleted,
        /// <summary>
        /// 
        /// </summary>
        StoreFileCancelled,
        /// <summary>
        /// 
        /// </summary>
        StoreReingestionCompleted,
        /// <summary>
        /// 
        /// </summary>
        ParsingJobCreated,
        /// <summary>
        /// 
        /// </summary>
        ParsingJobDeleted,
        /// <summary>
        /// 
        /// </summary>
        ParsingJobCancelled,
        /// <summary>
        /// 
        /// </summary>
        ParsingJobCompleted,
        /// <summary>
        /// 
        /// </summary>
        ExtractionJobCreated,
        /// <summary>
        /// 
        /// </summary>
        ExtractionJobDeleted,
        /// <summary>
        /// 
        /// </summary>
        ExtractionJobCancelled,
        /// <summary>
        /// 
        /// </summary>
        ExtractionJobCompleted,
        /// <summary>
        /// 
        /// </summary>
        FileUploaded,
        /// <summary>
        /// 
        /// </summary>
        FileDeleted,
        /// <summary>
        /// 
        /// </summary>
        FileUpdated,
        /// <summary>
        /// 
        /// </summary>
        FileDownloaded,
        /// <summary>
        /// 
        /// </summary>
        ApiKeyCreated,
        /// <summary>
        /// 
        /// </summary>
        ApiKeyDeleted,
        /// <summary>
        /// 
        /// </summary>
        ApiKeyUpdated,
        /// <summary>
        /// 
        /// </summary>
        ApiKeyRevoked,
        /// <summary>
        /// 
        /// </summary>
        ApiKeyRerolled,
        /// <summary>
        /// 
        /// </summary>
        DataSourceCreated,
        /// <summary>
        /// 
        /// </summary>
        DataSourceUpdated,
        /// <summary>
        /// 
        /// </summary>
        DataSourceDeleted,
        /// <summary>
        /// 
        /// </summary>
        DataSourceOauth2Requested,
        /// <summary>
        /// 
        /// </summary>
        DataSourceOauth2Authorized,
        /// <summary>
        /// 
        /// </summary>
        DataSourceConnectorJobCompleted,
        /// <summary>
        /// 
        /// </summary>
        AuthInvalidToken,
        /// <summary>
        /// 
        /// </summary>
        AuthSuccess,
        /// <summary>
        /// 
        /// </summary>
        AuthError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StoreEventHistogramBucketTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StoreEventHistogramBucketType value)
        {
            return value switch
            {
                StoreEventHistogramBucketType.InferenceEmbeddings => "inference.embeddings",
                StoreEventHistogramBucketType.InferenceReranking => "inference.reranking",
                StoreEventHistogramBucketType.ModelRequest => "model_request",
                StoreEventHistogramBucketType.InternalError => "internal_error",
                StoreEventHistogramBucketType.StoreCreated => "store.created",
                StoreEventHistogramBucketType.StoreDeleted => "store.deleted",
                StoreEventHistogramBucketType.StoreUpdated => "store.updated",
                StoreEventHistogramBucketType.StoreSearch => "store.search",
                StoreEventHistogramBucketType.StoreWebSearch => "store.web_search",
                StoreEventHistogramBucketType.StoreFileCreated => "store.file.created",
                StoreEventHistogramBucketType.StoreFileDeleted => "store.file.deleted",
                StoreEventHistogramBucketType.StoreFileUpdated => "store.file.updated",
                StoreEventHistogramBucketType.StoreFileSearch => "store.file.search",
                StoreEventHistogramBucketType.StoreQuestionAnswer => "store.question_answer",
                StoreEventHistogramBucketType.StoreFileCompleted => "store.file.completed",
                StoreEventHistogramBucketType.StoreFileCancelled => "store.file.cancelled",
                StoreEventHistogramBucketType.StoreReingestionCompleted => "store.reingestion.completed",
                StoreEventHistogramBucketType.ParsingJobCreated => "parsing.job.created",
                StoreEventHistogramBucketType.ParsingJobDeleted => "parsing.job.deleted",
                StoreEventHistogramBucketType.ParsingJobCancelled => "parsing.job.cancelled",
                StoreEventHistogramBucketType.ParsingJobCompleted => "parsing.job.completed",
                StoreEventHistogramBucketType.ExtractionJobCreated => "extraction.job.created",
                StoreEventHistogramBucketType.ExtractionJobDeleted => "extraction.job.deleted",
                StoreEventHistogramBucketType.ExtractionJobCancelled => "extraction.job.cancelled",
                StoreEventHistogramBucketType.ExtractionJobCompleted => "extraction.job.completed",
                StoreEventHistogramBucketType.FileUploaded => "file.uploaded",
                StoreEventHistogramBucketType.FileDeleted => "file.deleted",
                StoreEventHistogramBucketType.FileUpdated => "file.updated",
                StoreEventHistogramBucketType.FileDownloaded => "file.downloaded",
                StoreEventHistogramBucketType.ApiKeyCreated => "api_key.created",
                StoreEventHistogramBucketType.ApiKeyDeleted => "api_key.deleted",
                StoreEventHistogramBucketType.ApiKeyUpdated => "api_key.updated",
                StoreEventHistogramBucketType.ApiKeyRevoked => "api_key.revoked",
                StoreEventHistogramBucketType.ApiKeyRerolled => "api_key.rerolled",
                StoreEventHistogramBucketType.DataSourceCreated => "data_source.created",
                StoreEventHistogramBucketType.DataSourceUpdated => "data_source.updated",
                StoreEventHistogramBucketType.DataSourceDeleted => "data_source.deleted",
                StoreEventHistogramBucketType.DataSourceOauth2Requested => "data_source.oauth2.requested",
                StoreEventHistogramBucketType.DataSourceOauth2Authorized => "data_source.oauth2.authorized",
                StoreEventHistogramBucketType.DataSourceConnectorJobCompleted => "data_source.connector.job.completed",
                StoreEventHistogramBucketType.AuthInvalidToken => "auth.invalid_token",
                StoreEventHistogramBucketType.AuthSuccess => "auth.success",
                StoreEventHistogramBucketType.AuthError => "auth.error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StoreEventHistogramBucketType? ToEnum(string value)
        {
            return value switch
            {
                "inference.embeddings" => StoreEventHistogramBucketType.InferenceEmbeddings,
                "inference.reranking" => StoreEventHistogramBucketType.InferenceReranking,
                "model_request" => StoreEventHistogramBucketType.ModelRequest,
                "internal_error" => StoreEventHistogramBucketType.InternalError,
                "store.created" => StoreEventHistogramBucketType.StoreCreated,
                "store.deleted" => StoreEventHistogramBucketType.StoreDeleted,
                "store.updated" => StoreEventHistogramBucketType.StoreUpdated,
                "store.search" => StoreEventHistogramBucketType.StoreSearch,
                "store.web_search" => StoreEventHistogramBucketType.StoreWebSearch,
                "store.file.created" => StoreEventHistogramBucketType.StoreFileCreated,
                "store.file.deleted" => StoreEventHistogramBucketType.StoreFileDeleted,
                "store.file.updated" => StoreEventHistogramBucketType.StoreFileUpdated,
                "store.file.search" => StoreEventHistogramBucketType.StoreFileSearch,
                "store.question_answer" => StoreEventHistogramBucketType.StoreQuestionAnswer,
                "store.file.completed" => StoreEventHistogramBucketType.StoreFileCompleted,
                "store.file.cancelled" => StoreEventHistogramBucketType.StoreFileCancelled,
                "store.reingestion.completed" => StoreEventHistogramBucketType.StoreReingestionCompleted,
                "parsing.job.created" => StoreEventHistogramBucketType.ParsingJobCreated,
                "parsing.job.deleted" => StoreEventHistogramBucketType.ParsingJobDeleted,
                "parsing.job.cancelled" => StoreEventHistogramBucketType.ParsingJobCancelled,
                "parsing.job.completed" => StoreEventHistogramBucketType.ParsingJobCompleted,
                "extraction.job.created" => StoreEventHistogramBucketType.ExtractionJobCreated,
                "extraction.job.deleted" => StoreEventHistogramBucketType.ExtractionJobDeleted,
                "extraction.job.cancelled" => StoreEventHistogramBucketType.ExtractionJobCancelled,
                "extraction.job.completed" => StoreEventHistogramBucketType.ExtractionJobCompleted,
                "file.uploaded" => StoreEventHistogramBucketType.FileUploaded,
                "file.deleted" => StoreEventHistogramBucketType.FileDeleted,
                "file.updated" => StoreEventHistogramBucketType.FileUpdated,
                "file.downloaded" => StoreEventHistogramBucketType.FileDownloaded,
                "api_key.created" => StoreEventHistogramBucketType.ApiKeyCreated,
                "api_key.deleted" => StoreEventHistogramBucketType.ApiKeyDeleted,
                "api_key.updated" => StoreEventHistogramBucketType.ApiKeyUpdated,
                "api_key.revoked" => StoreEventHistogramBucketType.ApiKeyRevoked,
                "api_key.rerolled" => StoreEventHistogramBucketType.ApiKeyRerolled,
                "data_source.created" => StoreEventHistogramBucketType.DataSourceCreated,
                "data_source.updated" => StoreEventHistogramBucketType.DataSourceUpdated,
                "data_source.deleted" => StoreEventHistogramBucketType.DataSourceDeleted,
                "data_source.oauth2.requested" => StoreEventHistogramBucketType.DataSourceOauth2Requested,
                "data_source.oauth2.authorized" => StoreEventHistogramBucketType.DataSourceOauth2Authorized,
                "data_source.connector.job.completed" => StoreEventHistogramBucketType.DataSourceConnectorJobCompleted,
                "auth.invalid_token" => StoreEventHistogramBucketType.AuthInvalidToken,
                "auth.success" => StoreEventHistogramBucketType.AuthSuccess,
                "auth.error" => StoreEventHistogramBucketType.AuthError,
                _ => null,
            };
        }
    }
}