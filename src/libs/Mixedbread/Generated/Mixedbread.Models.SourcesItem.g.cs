#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SourcesItem : global::System.IEquatable<SourcesItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Mixedbread.StoreQAResultsSourceDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunk? Text { get; init; }
#else
        public global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunk? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunk? ImageUrl { get; init; }
#else
        public global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunk? ImageUrl { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageUrl))]
#endif
        public bool IsImageUrl => ImageUrl != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunk? AudioUrl { get; init; }
#else
        public global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunk? AudioUrl { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AudioUrl))]
#endif
        public bool IsAudioUrl => AudioUrl != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunk? VideoUrl { get; init; }
#else
        public global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunk? VideoUrl { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VideoUrl))]
#endif
        public bool IsVideoUrl => VideoUrl != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SourcesItem(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunk value) => new SourcesItem((global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunk?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunk?(SourcesItem @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public SourcesItem(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunk? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SourcesItem(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunk value) => new SourcesItem((global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunk?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunk?(SourcesItem @this) => @this.ImageUrl;

        /// <summary>
        /// 
        /// </summary>
        public SourcesItem(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunk? value)
        {
            ImageUrl = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SourcesItem(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunk value) => new SourcesItem((global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunk?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunk?(SourcesItem @this) => @this.AudioUrl;

        /// <summary>
        /// 
        /// </summary>
        public SourcesItem(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunk? value)
        {
            AudioUrl = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SourcesItem(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunk value) => new SourcesItem((global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunk?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunk?(SourcesItem @this) => @this.VideoUrl;

        /// <summary>
        /// 
        /// </summary>
        public SourcesItem(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunk? value)
        {
            VideoUrl = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SourcesItem(
            global::Mixedbread.StoreQAResultsSourceDiscriminatorType? type,
            global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunk? text,
            global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunk? imageUrl,
            global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunk? audioUrl,
            global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunk? videoUrl
            )
        {
            Type = type;

            Text = text;
            ImageUrl = imageUrl;
            AudioUrl = audioUrl;
            VideoUrl = videoUrl;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            VideoUrl as object ??
            AudioUrl as object ??
            ImageUrl as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            ImageUrl?.ToString() ??
            AudioUrl?.ToString() ??
            VideoUrl?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsImageUrl && !IsAudioUrl && !IsVideoUrl || !IsText && IsImageUrl && !IsAudioUrl && !IsVideoUrl || !IsText && !IsImageUrl && IsAudioUrl && !IsVideoUrl || !IsText && !IsImageUrl && !IsAudioUrl && IsVideoUrl;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunk?, TResult>? text = null,
            global::System.Func<global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunk?, TResult>? imageUrl = null,
            global::System.Func<global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunk?, TResult>? audioUrl = null,
            global::System.Func<global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunk?, TResult>? videoUrl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsImageUrl && imageUrl != null)
            {
                return imageUrl(ImageUrl!);
            }
            else if (IsAudioUrl && audioUrl != null)
            {
                return audioUrl(AudioUrl!);
            }
            else if (IsVideoUrl && videoUrl != null)
            {
                return videoUrl(VideoUrl!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunk?>? text = null,
            global::System.Action<global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunk?>? imageUrl = null,
            global::System.Action<global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunk?>? audioUrl = null,
            global::System.Action<global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunk?>? videoUrl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsImageUrl)
            {
                imageUrl?.Invoke(ImageUrl!);
            }
            else if (IsAudioUrl)
            {
                audioUrl?.Invoke(AudioUrl!);
            }
            else if (IsVideoUrl)
            {
                videoUrl?.Invoke(VideoUrl!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunk),
                ImageUrl,
                typeof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunk),
                AudioUrl,
                typeof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunk),
                VideoUrl,
                typeof(global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunk),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(SourcesItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunk?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunk?>.Default.Equals(ImageUrl, other.ImageUrl) &&
                global::System.Collections.Generic.EqualityComparer<global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunk?>.Default.Equals(AudioUrl, other.AudioUrl) &&
                global::System.Collections.Generic.EqualityComparer<global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunk?>.Default.Equals(VideoUrl, other.VideoUrl) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SourcesItem obj1, SourcesItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SourcesItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SourcesItem obj1, SourcesItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SourcesItem o && Equals(o);
        }
    }
}
