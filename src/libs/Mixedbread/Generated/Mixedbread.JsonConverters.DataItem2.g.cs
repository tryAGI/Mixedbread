#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mixedbread.JsonConverters
{
    /// <inheritdoc />
    public class DataItem2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mixedbread.DataItem2>
    {
        /// <inheritdoc />
        public override global::Mixedbread.DataItem2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Mixedbread.StoreSearchResponseDataItemDiscriminator>(ref readerCopy, options);

            global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunk? text = default;
            if (discriminator?.Type == global::Mixedbread.StoreSearchResponseDataItemDiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunk>(ref reader, options);
            }
            global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunk? imageUrl = default;
            if (discriminator?.Type == global::Mixedbread.StoreSearchResponseDataItemDiscriminatorType.ImageUrl)
            {
                imageUrl = global::System.Text.Json.JsonSerializer.Deserialize<global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunk>(ref reader, options);
            }
            global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunk? audioUrl = default;
            if (discriminator?.Type == global::Mixedbread.StoreSearchResponseDataItemDiscriminatorType.AudioUrl)
            {
                audioUrl = global::System.Text.Json.JsonSerializer.Deserialize<global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunk>(ref reader, options);
            }
            global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunk? videoUrl = default;
            if (discriminator?.Type == global::Mixedbread.StoreSearchResponseDataItemDiscriminatorType.VideoUrl)
            {
                videoUrl = global::System.Text.Json.JsonSerializer.Deserialize<global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunk>(ref reader, options);
            }

            var __value = new global::Mixedbread.DataItem2(
                discriminator?.Type,
                text,

                imageUrl,

                audioUrl,

                videoUrl
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mixedbread.DataItem2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunk), options);
            }
            else if (value.IsImageUrl)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageUrl, typeof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunk), options);
            }
            else if (value.IsAudioUrl)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AudioUrl, typeof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunk), options);
            }
            else if (value.IsVideoUrl)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VideoUrl, typeof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunk), options);
            }
        }
    }
}