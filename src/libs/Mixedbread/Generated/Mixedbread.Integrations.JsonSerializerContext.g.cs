
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.CursorPaginationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.DataSourceInstallation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.DataSourceInstallationListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.DataSourceInstallation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.IntegrationProviderManifestIngestionBacking), TypeInfoPropertyName = "IntegrationProviderManifestIngestionBacking2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.SlackChannel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.SlackChannelSyncStatus), TypeInfoPropertyName = "SlackChannelSyncStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.SlackChannelLastSyncStatus), TypeInfoPropertyName = "SlackChannelLastSyncStatus2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.IntegrationProviderManifestProvider?), TypeInfoPropertyName = "NullableIntegrationProviderManifestProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.IntegrationProviderManifestAuthType?), TypeInfoPropertyName = "NullableIntegrationProviderManifestAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.IntegrationProviderManifestCapabilitie?), TypeInfoPropertyName = "NullableIntegrationProviderManifestCapabilitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.IntegrationProviderManifestIngestionBacking?), TypeInfoPropertyName = "NullableIntegrationProviderManifestIngestionBacking2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.SlackChannelSyncStatus?), TypeInfoPropertyName = "NullableSlackChannelSyncStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.SlackChannelLastSyncStatus?), TypeInfoPropertyName = "NullableSlackChannelLastSyncStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.DataSourceInstallation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.GoogleDriveFolder>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.GoogleDriveInstallationOverview>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.IntegrationInstallation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.IntegrationProviderManifest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.IntegrationProviderManifestCapabilitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.SlackChannel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.SlackInstallationOverview>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.AnyOf<string, int?>>))]
    internal sealed partial class IntegrationsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IntegrationsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static IntegrationsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private IntegrationsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Mixedbread.IntegrationProviderManifestProvider)

                    || typeToConvert == typeof(global::Mixedbread.IntegrationProviderManifestProvider?)

                    || typeToConvert == typeof(global::Mixedbread.IntegrationProviderManifestAuthType)

                    || typeToConvert == typeof(global::Mixedbread.IntegrationProviderManifestAuthType?)

                    || typeToConvert == typeof(global::Mixedbread.IntegrationProviderManifestCapabilitie)

                    || typeToConvert == typeof(global::Mixedbread.IntegrationProviderManifestCapabilitie?)

                    || typeToConvert == typeof(global::Mixedbread.IntegrationProviderManifestIngestionBacking)

                    || typeToConvert == typeof(global::Mixedbread.IntegrationProviderManifestIngestionBacking?)

                    || typeToConvert == typeof(global::Mixedbread.SlackChannelSyncStatus)

                    || typeToConvert == typeof(global::Mixedbread.SlackChannelSyncStatus?)

                    || typeToConvert == typeof(global::Mixedbread.SlackChannelLastSyncStatus)

                    || typeToConvert == typeof(global::Mixedbread.SlackChannelLastSyncStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
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

                if (typeToConvert == typeof(global::Mixedbread.IntegrationProviderManifestIngestionBacking))
                {
                    return new global::Mixedbread.JsonConverters.IntegrationProviderManifestIngestionBackingJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.IntegrationProviderManifestIngestionBacking?))
                {
                    return new global::Mixedbread.JsonConverters.IntegrationProviderManifestIngestionBackingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.SlackChannelSyncStatus))
                {
                    return new global::Mixedbread.JsonConverters.SlackChannelSyncStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.SlackChannelSyncStatus?))
                {
                    return new global::Mixedbread.JsonConverters.SlackChannelSyncStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.SlackChannelLastSyncStatus))
                {
                    return new global::Mixedbread.JsonConverters.SlackChannelLastSyncStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.SlackChannelLastSyncStatus?))
                {
                    return new global::Mixedbread.JsonConverters.SlackChannelLastSyncStatusNullableJsonConverter();
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
                    0 => new IntegrationsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}