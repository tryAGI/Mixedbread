#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mixedbread.JsonConverters
{
    /// <inheritdoc />
    public class DataItem3JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mixedbread.DataItem3>
    {
        /// <inheritdoc />
        public override global::Mixedbread.DataItem3 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Mixedbread.VectorStoreSearchResponseDataItemDiscriminator>(ref readerCopy, options);

            global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunk? text = default;
            if (discriminator?.Type == global::Mixedbread.VectorStoreSearchResponseDataItemDiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunk>(ref reader, options);
            }
            global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunk? imageUrl = default;
            if (discriminator?.Type == global::Mixedbread.VectorStoreSearchResponseDataItemDiscriminatorType.ImageUrl)
            {
                imageUrl = global::System.Text.Json.JsonSerializer.Deserialize<global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunk>(ref reader, options);
            }
            global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunk? audioUrl = default;
            if (discriminator?.Type == global::Mixedbread.VectorStoreSearchResponseDataItemDiscriminatorType.AudioUrl)
            {
                audioUrl = global::System.Text.Json.JsonSerializer.Deserialize<global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunk>(ref reader, options);
            }
            global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunk? videoUrl = default;
            if (discriminator?.Type == global::Mixedbread.VectorStoreSearchResponseDataItemDiscriminatorType.VideoUrl)
            {
                videoUrl = global::System.Text.Json.JsonSerializer.Deserialize<global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunk>(ref reader, options);
            }

            var __value = new global::Mixedbread.DataItem3(
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
            global::Mixedbread.DataItem3 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunk), options);
            }
            else if (value.IsImageUrl)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageUrl, typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunk), options);
            }
            else if (value.IsAudioUrl)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AudioUrl, typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunk), options);
            }
            else if (value.IsVideoUrl)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VideoUrl, typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunk), options);
            }
        }
    }
}