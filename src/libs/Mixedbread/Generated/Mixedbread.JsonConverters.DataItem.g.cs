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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.StoreEventListResponseDataItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.StoreEventListResponseDataItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mixedbread.StoreEventListResponseDataItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Mixedbread.StoreIngestionEvent? ingestion = default;
            if (discriminator?.Type == global::Mixedbread.StoreEventListResponseDataItemDiscriminatorType.Ingestion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.StoreIngestionEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.StoreIngestionEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mixedbread.StoreIngestionEvent)}");
                ingestion = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mixedbread.StoreSearchEvent? search = default;
            if (discriminator?.Type == global::Mixedbread.StoreEventListResponseDataItemDiscriminatorType.Search)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.StoreSearchEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.StoreSearchEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mixedbread.StoreSearchEvent)}");
                search = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mixedbread.StoreAgenticSearchEvent? agenticSearch = default;
            if (discriminator?.Type == global::Mixedbread.StoreEventListResponseDataItemDiscriminatorType.AgenticSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.StoreAgenticSearchEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.StoreAgenticSearchEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mixedbread.StoreAgenticSearchEvent)}");
                agenticSearch = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Mixedbread.DataItem(
                discriminator?.Type,
                ingestion,

                search,

                agenticSearch
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsIngestion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.StoreIngestionEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.StoreIngestionEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mixedbread.StoreIngestionEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Ingestion!, typeInfo);
            }
            else if (value.IsSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.StoreSearchEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.StoreSearchEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mixedbread.StoreSearchEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Search!, typeInfo);
            }
            else if (value.IsAgenticSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.StoreAgenticSearchEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.StoreAgenticSearchEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mixedbread.StoreAgenticSearchEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgenticSearch!, typeInfo);
            }
        }
    }
}