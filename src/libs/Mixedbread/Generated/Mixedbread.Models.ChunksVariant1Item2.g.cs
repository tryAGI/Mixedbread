#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChunksVariant1Item2 : global::System.IEquatable<ChunksVariant1Item2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Mixedbread.VectorStoreFileChunksVariant1ItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mixedbread.TextInputChunk? Text { get; init; }
#else
        public global::Mixedbread.TextInputChunk? Text { get; }
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
        public global::Mixedbread.ImageUrlInputChunk? ImageUrl { get; init; }
#else
        public global::Mixedbread.ImageUrlInputChunk? ImageUrl { get; }
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
        public global::Mixedbread.AudioUrlInputChunk? AudioUrl { get; init; }
#else
        public global::Mixedbread.AudioUrlInputChunk? AudioUrl { get; }
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
        public global::Mixedbread.VideoUrlInputChunk? VideoUrl { get; init; }
#else
        public global::Mixedbread.VideoUrlInputChunk? VideoUrl { get; }
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
        public static implicit operator ChunksVariant1Item2(global::Mixedbread.TextInputChunk value) => new ChunksVariant1Item2((global::Mixedbread.TextInputChunk?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mixedbread.TextInputChunk?(ChunksVariant1Item2 @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ChunksVariant1Item2(global::Mixedbread.TextInputChunk? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChunksVariant1Item2(global::Mixedbread.ImageUrlInputChunk value) => new ChunksVariant1Item2((global::Mixedbread.ImageUrlInputChunk?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mixedbread.ImageUrlInputChunk?(ChunksVariant1Item2 @this) => @this.ImageUrl;

        /// <summary>
        /// 
        /// </summary>
        public ChunksVariant1Item2(global::Mixedbread.ImageUrlInputChunk? value)
        {
            ImageUrl = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChunksVariant1Item2(global::Mixedbread.AudioUrlInputChunk value) => new ChunksVariant1Item2((global::Mixedbread.AudioUrlInputChunk?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mixedbread.AudioUrlInputChunk?(ChunksVariant1Item2 @this) => @this.AudioUrl;

        /// <summary>
        /// 
        /// </summary>
        public ChunksVariant1Item2(global::Mixedbread.AudioUrlInputChunk? value)
        {
            AudioUrl = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChunksVariant1Item2(global::Mixedbread.VideoUrlInputChunk value) => new ChunksVariant1Item2((global::Mixedbread.VideoUrlInputChunk?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mixedbread.VideoUrlInputChunk?(ChunksVariant1Item2 @this) => @this.VideoUrl;

        /// <summary>
        /// 
        /// </summary>
        public ChunksVariant1Item2(global::Mixedbread.VideoUrlInputChunk? value)
        {
            VideoUrl = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChunksVariant1Item2(
            global::Mixedbread.VectorStoreFileChunksVariant1ItemDiscriminatorType? type,
            global::Mixedbread.TextInputChunk? text,
            global::Mixedbread.ImageUrlInputChunk? imageUrl,
            global::Mixedbread.AudioUrlInputChunk? audioUrl,
            global::Mixedbread.VideoUrlInputChunk? videoUrl
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
            global::System.Func<global::Mixedbread.TextInputChunk?, TResult>? text = null,
            global::System.Func<global::Mixedbread.ImageUrlInputChunk?, TResult>? imageUrl = null,
            global::System.Func<global::Mixedbread.AudioUrlInputChunk?, TResult>? audioUrl = null,
            global::System.Func<global::Mixedbread.VideoUrlInputChunk?, TResult>? videoUrl = null,
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
            global::System.Action<global::Mixedbread.TextInputChunk?>? text = null,
            global::System.Action<global::Mixedbread.ImageUrlInputChunk?>? imageUrl = null,
            global::System.Action<global::Mixedbread.AudioUrlInputChunk?>? audioUrl = null,
            global::System.Action<global::Mixedbread.VideoUrlInputChunk?>? videoUrl = null,
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
                typeof(global::Mixedbread.TextInputChunk),
                ImageUrl,
                typeof(global::Mixedbread.ImageUrlInputChunk),
                AudioUrl,
                typeof(global::Mixedbread.AudioUrlInputChunk),
                VideoUrl,
                typeof(global::Mixedbread.VideoUrlInputChunk),
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
        public bool Equals(ChunksVariant1Item2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mixedbread.TextInputChunk?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Mixedbread.ImageUrlInputChunk?>.Default.Equals(ImageUrl, other.ImageUrl) &&
                global::System.Collections.Generic.EqualityComparer<global::Mixedbread.AudioUrlInputChunk?>.Default.Equals(AudioUrl, other.AudioUrl) &&
                global::System.Collections.Generic.EqualityComparer<global::Mixedbread.VideoUrlInputChunk?>.Default.Equals(VideoUrl, other.VideoUrl) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChunksVariant1Item2 obj1, ChunksVariant1Item2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChunksVariant1Item2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChunksVariant1Item2 obj1, ChunksVariant1Item2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChunksVariant1Item2 o && Equals(o);
        }
    }
}
