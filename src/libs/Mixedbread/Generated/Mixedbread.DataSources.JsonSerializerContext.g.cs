
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ApiKeyCreateOrUpdateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.CursorPaginationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ConnectorListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.DataSourceConnector>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.DataSourceConnector))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.LinearDataSourceCreateOrUpdateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AuthParamsVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.OAuth2CreateOrUpdateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.LinearDataSourceCreateOrUpdateParamsAuthParamsVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.LinearDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType), TypeInfoPropertyName = "LinearDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.NotionDataSourceCreateOrUpdateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AuthParamsVariant13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType), TypeInfoPropertyName = "NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<global::Mixedbread.NotionDataSourceCreateOrUpdateParams, global::Mixedbread.LinearDataSourceCreateOrUpdateParams>), TypeInfoPropertyName = "AnyOfNotionDataSourceCreateOrUpdateParamsLinearDataSourceCreateOrUpdateParams2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.DataSourceType?), TypeInfoPropertyName = "NullableDataSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.DataSourceAuthParamsVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableDataSourceAuthParamsVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.SyncStatus?), TypeInfoPropertyName = "NullableSyncStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<int?, string, object>?), TypeInfoPropertyName = "NullableAnyOfInt32StringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.LinearDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableLinearDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableNotionDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<global::Mixedbread.NotionDataSourceCreateOrUpdateParams, global::Mixedbread.LinearDataSourceCreateOrUpdateParams>?), TypeInfoPropertyName = "NullableAnyOfNotionDataSourceCreateOrUpdateParamsLinearDataSourceCreateOrUpdateParams2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.DataSourceConnector>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.DataSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.AnyOf<string, int?>>))]
    internal sealed partial class DataSourcesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DataSourcesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static DataSourcesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private DataSourcesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Mixedbread.JsonConverters.AuthParamsVariant1JsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AuthParamsVariant12JsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AuthParamsVariant13JsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<bool?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<string, int?, double?, bool?>>, object>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<bool?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<object>>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?, object>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<string, bool?>>, object>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, bool?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
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
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Mixedbread.DataSourceAuthParamsVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Mixedbread.DataSourceAuthParamsVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Mixedbread.DataSourceType)

                    || typeToConvert == typeof(global::Mixedbread.DataSourceType?)

                    || typeToConvert == typeof(global::Mixedbread.LinearDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Mixedbread.LinearDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Mixedbread.NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Mixedbread.NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Mixedbread.SyncStatus)

                    || typeToConvert == typeof(global::Mixedbread.SyncStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
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

                if (typeToConvert == typeof(global::Mixedbread.LinearDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType))
                {
                    return new global::Mixedbread.JsonConverters.LinearDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.LinearDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType?))
                {
                    return new global::Mixedbread.JsonConverters.LinearDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType))
                {
                    return new global::Mixedbread.JsonConverters.NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType?))
                {
                    return new global::Mixedbread.JsonConverters.NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.SyncStatus))
                {
                    return new global::Mixedbread.JsonConverters.SyncStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.SyncStatus?))
                {
                    return new global::Mixedbread.JsonConverters.SyncStatusNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

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
                    0 => new DataSourcesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}