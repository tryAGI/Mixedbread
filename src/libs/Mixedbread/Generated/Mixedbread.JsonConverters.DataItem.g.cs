#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mixedbread.JsonConverters
{
    /// <inheritdoc />
    public class DataItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mixedbread.DataItem>
    {
        /// <inheritdoc />
        public override global::Mixedbread.DataItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Mixedbread.StoreEventListResponseDataItemDiscriminator>(ref readerCopy, options);

            global::Mixedbread.StoreIngestionEvent? ingestion = default;
            if (discriminator?.Type == global::Mixedbread.StoreEventListResponseDataItemDiscriminatorType.Ingestion)
            {
                ingestion = global::System.Text.Json.JsonSerializer.Deserialize<global::Mixedbread.StoreIngestionEvent>(ref reader, options);
            }
            global::Mixedbread.StoreSearchEvent? search = default;
            if (discriminator?.Type == global::Mixedbread.StoreEventListResponseDataItemDiscriminatorType.Search)
            {
                search = global::System.Text.Json.JsonSerializer.Deserialize<global::Mixedbread.StoreSearchEvent>(ref reader, options);
            }

            var __value = new global::Mixedbread.DataItem(
                discriminator?.Type,
                ingestion,

                search
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mixedbread.DataItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsIngestion)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Ingestion, typeof(global::Mixedbread.StoreIngestionEvent), options);
            }
            else if (value.IsSearch)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Search, typeof(global::Mixedbread.StoreSearchEvent), options);
            }
        }
    }
}