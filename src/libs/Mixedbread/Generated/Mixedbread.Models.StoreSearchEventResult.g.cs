
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// A single result captured on a search event.
    /// </summary>
    public sealed partial class StoreSearchEventResult
    {
        /// <summary>
        /// ID of the file the chunk belongs to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileId { get; set; }

        /// <summary>
        /// Name of the file the chunk belongs to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Index of the chunk within its file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ChunkIndex { get; set; }

        /// <summary>
        /// Final score assigned to the chunk
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Score { get; set; }

        /// <summary>
        /// Position of the chunk in the first-stage ranking
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_stage_position")]
        public int? FirstStagePosition { get; set; }

        /// <summary>
        /// Which first-stage retriever surfaced the chunk
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_stage_source")]
        public global::Mixedbread.StoreSearchEventResultFirstStageSource2? FirstStageSource { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreSearchEventResult" /> class.
        /// </summary>
        /// <param name="fileId">
        /// ID of the file the chunk belongs to
        /// </param>
        /// <param name="chunkIndex">
        /// Index of the chunk within its file
        /// </param>
        /// <param name="score">
        /// Final score assigned to the chunk
        /// </param>
        /// <param name="filename">
        /// Name of the file the chunk belongs to
        /// </param>
        /// <param name="firstStagePosition">
        /// Position of the chunk in the first-stage ranking
        /// </param>
        /// <param name="firstStageSource">
        /// Which first-stage retriever surfaced the chunk
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StoreSearchEventResult(
            string fileId,
            int chunkIndex,
            double score,
            string? filename,
            int? firstStagePosition,
            global::Mixedbread.StoreSearchEventResultFirstStageSource2? firstStageSource)
        {
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.Filename = filename;
            this.ChunkIndex = chunkIndex;
            this.Score = score;
            this.FirstStagePosition = firstStagePosition;
            this.FirstStageSource = firstStageSource;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreSearchEventResult" /> class.
        /// </summary>
        public StoreSearchEventResult()
        {
        }
    }
}