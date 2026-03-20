#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct GeneratedMetadataVariant12 : global::System.IEquatable<GeneratedMetadataVariant12>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Mixedbread.ImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mixedbread.MarkdownChunkGeneratedMetadata? Markdown { get; init; }
#else
        public global::Mixedbread.MarkdownChunkGeneratedMetadata? Markdown { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Markdown))]
#endif
        public bool IsMarkdown => Markdown != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mixedbread.TextChunkGeneratedMetadata? Text { get; init; }
#else
        public global::Mixedbread.TextChunkGeneratedMetadata? Text { get; }
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
        public global::Mixedbread.PDFChunkGeneratedMetadata? Pdf { get; init; }
#else
        public global::Mixedbread.PDFChunkGeneratedMetadata? Pdf { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Pdf))]
#endif
        public bool IsPdf => Pdf != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mixedbread.CodeChunkGeneratedMetadata? Code { get; init; }
#else
        public global::Mixedbread.CodeChunkGeneratedMetadata? Code { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Code))]
#endif
        public bool IsCode => Code != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mixedbread.AudioChunkGeneratedMetadata? Audio { get; init; }
#else
        public global::Mixedbread.AudioChunkGeneratedMetadata? Audio { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Audio))]
#endif
        public bool IsAudio => Audio != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mixedbread.VideoChunkGeneratedMetadata? Video { get; init; }
#else
        public global::Mixedbread.VideoChunkGeneratedMetadata? Video { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Video))]
#endif
        public bool IsVideo => Video != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mixedbread.ImageChunkGeneratedMetadata? Image { get; init; }
#else
        public global::Mixedbread.ImageChunkGeneratedMetadata? Image { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Image))]
#endif
        public bool IsImage => Image != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GeneratedMetadataVariant12(global::Mixedbread.MarkdownChunkGeneratedMetadata value) => new GeneratedMetadataVariant12((global::Mixedbread.MarkdownChunkGeneratedMetadata?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mixedbread.MarkdownChunkGeneratedMetadata?(GeneratedMetadataVariant12 @this) => @this.Markdown;

        /// <summary>
        /// 
        /// </summary>
        public GeneratedMetadataVariant12(global::Mixedbread.MarkdownChunkGeneratedMetadata? value)
        {
            Markdown = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GeneratedMetadataVariant12(global::Mixedbread.TextChunkGeneratedMetadata value) => new GeneratedMetadataVariant12((global::Mixedbread.TextChunkGeneratedMetadata?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mixedbread.TextChunkGeneratedMetadata?(GeneratedMetadataVariant12 @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public GeneratedMetadataVariant12(global::Mixedbread.TextChunkGeneratedMetadata? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GeneratedMetadataVariant12(global::Mixedbread.PDFChunkGeneratedMetadata value) => new GeneratedMetadataVariant12((global::Mixedbread.PDFChunkGeneratedMetadata?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mixedbread.PDFChunkGeneratedMetadata?(GeneratedMetadataVariant12 @this) => @this.Pdf;

        /// <summary>
        /// 
        /// </summary>
        public GeneratedMetadataVariant12(global::Mixedbread.PDFChunkGeneratedMetadata? value)
        {
            Pdf = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GeneratedMetadataVariant12(global::Mixedbread.CodeChunkGeneratedMetadata value) => new GeneratedMetadataVariant12((global::Mixedbread.CodeChunkGeneratedMetadata?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mixedbread.CodeChunkGeneratedMetadata?(GeneratedMetadataVariant12 @this) => @this.Code;

        /// <summary>
        /// 
        /// </summary>
        public GeneratedMetadataVariant12(global::Mixedbread.CodeChunkGeneratedMetadata? value)
        {
            Code = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GeneratedMetadataVariant12(global::Mixedbread.AudioChunkGeneratedMetadata value) => new GeneratedMetadataVariant12((global::Mixedbread.AudioChunkGeneratedMetadata?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mixedbread.AudioChunkGeneratedMetadata?(GeneratedMetadataVariant12 @this) => @this.Audio;

        /// <summary>
        /// 
        /// </summary>
        public GeneratedMetadataVariant12(global::Mixedbread.AudioChunkGeneratedMetadata? value)
        {
            Audio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GeneratedMetadataVariant12(global::Mixedbread.VideoChunkGeneratedMetadata value) => new GeneratedMetadataVariant12((global::Mixedbread.VideoChunkGeneratedMetadata?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mixedbread.VideoChunkGeneratedMetadata?(GeneratedMetadataVariant12 @this) => @this.Video;

        /// <summary>
        /// 
        /// </summary>
        public GeneratedMetadataVariant12(global::Mixedbread.VideoChunkGeneratedMetadata? value)
        {
            Video = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GeneratedMetadataVariant12(global::Mixedbread.ImageChunkGeneratedMetadata value) => new GeneratedMetadataVariant12((global::Mixedbread.ImageChunkGeneratedMetadata?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mixedbread.ImageChunkGeneratedMetadata?(GeneratedMetadataVariant12 @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public GeneratedMetadataVariant12(global::Mixedbread.ImageChunkGeneratedMetadata? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public GeneratedMetadataVariant12(
            global::Mixedbread.ImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType? type,
            global::Mixedbread.MarkdownChunkGeneratedMetadata? markdown,
            global::Mixedbread.TextChunkGeneratedMetadata? text,
            global::Mixedbread.PDFChunkGeneratedMetadata? pdf,
            global::Mixedbread.CodeChunkGeneratedMetadata? code,
            global::Mixedbread.AudioChunkGeneratedMetadata? audio,
            global::Mixedbread.VideoChunkGeneratedMetadata? video,
            global::Mixedbread.ImageChunkGeneratedMetadata? image
            )
        {
            Type = type;

            Markdown = markdown;
            Text = text;
            Pdf = pdf;
            Code = code;
            Audio = audio;
            Video = video;
            Image = image;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Image as object ??
            Video as object ??
            Audio as object ??
            Code as object ??
            Pdf as object ??
            Text as object ??
            Markdown as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Markdown?.ToString() ??
            Text?.ToString() ??
            Pdf?.ToString() ??
            Code?.ToString() ??
            Audio?.ToString() ??
            Video?.ToString() ??
            Image?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMarkdown && !IsText && !IsPdf && !IsCode && !IsAudio && !IsVideo && !IsImage || !IsMarkdown && IsText && !IsPdf && !IsCode && !IsAudio && !IsVideo && !IsImage || !IsMarkdown && !IsText && IsPdf && !IsCode && !IsAudio && !IsVideo && !IsImage || !IsMarkdown && !IsText && !IsPdf && IsCode && !IsAudio && !IsVideo && !IsImage || !IsMarkdown && !IsText && !IsPdf && !IsCode && IsAudio && !IsVideo && !IsImage || !IsMarkdown && !IsText && !IsPdf && !IsCode && !IsAudio && IsVideo && !IsImage || !IsMarkdown && !IsText && !IsPdf && !IsCode && !IsAudio && !IsVideo && IsImage;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mixedbread.MarkdownChunkGeneratedMetadata?, TResult>? markdown = null,
            global::System.Func<global::Mixedbread.TextChunkGeneratedMetadata?, TResult>? text = null,
            global::System.Func<global::Mixedbread.PDFChunkGeneratedMetadata?, TResult>? pdf = null,
            global::System.Func<global::Mixedbread.CodeChunkGeneratedMetadata?, TResult>? code = null,
            global::System.Func<global::Mixedbread.AudioChunkGeneratedMetadata?, TResult>? audio = null,
            global::System.Func<global::Mixedbread.VideoChunkGeneratedMetadata?, TResult>? video = null,
            global::System.Func<global::Mixedbread.ImageChunkGeneratedMetadata?, TResult>? image = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMarkdown && markdown != null)
            {
                return markdown(Markdown!);
            }
            else if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsPdf && pdf != null)
            {
                return pdf(Pdf!);
            }
            else if (IsCode && code != null)
            {
                return code(Code!);
            }
            else if (IsAudio && audio != null)
            {
                return audio(Audio!);
            }
            else if (IsVideo && video != null)
            {
                return video(Video!);
            }
            else if (IsImage && image != null)
            {
                return image(Image!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mixedbread.MarkdownChunkGeneratedMetadata?>? markdown = null,
            global::System.Action<global::Mixedbread.TextChunkGeneratedMetadata?>? text = null,
            global::System.Action<global::Mixedbread.PDFChunkGeneratedMetadata?>? pdf = null,
            global::System.Action<global::Mixedbread.CodeChunkGeneratedMetadata?>? code = null,
            global::System.Action<global::Mixedbread.AudioChunkGeneratedMetadata?>? audio = null,
            global::System.Action<global::Mixedbread.VideoChunkGeneratedMetadata?>? video = null,
            global::System.Action<global::Mixedbread.ImageChunkGeneratedMetadata?>? image = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMarkdown)
            {
                markdown?.Invoke(Markdown!);
            }
            else if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsPdf)
            {
                pdf?.Invoke(Pdf!);
            }
            else if (IsCode)
            {
                code?.Invoke(Code!);
            }
            else if (IsAudio)
            {
                audio?.Invoke(Audio!);
            }
            else if (IsVideo)
            {
                video?.Invoke(Video!);
            }
            else if (IsImage)
            {
                image?.Invoke(Image!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Markdown,
                typeof(global::Mixedbread.MarkdownChunkGeneratedMetadata),
                Text,
                typeof(global::Mixedbread.TextChunkGeneratedMetadata),
                Pdf,
                typeof(global::Mixedbread.PDFChunkGeneratedMetadata),
                Code,
                typeof(global::Mixedbread.CodeChunkGeneratedMetadata),
                Audio,
                typeof(global::Mixedbread.AudioChunkGeneratedMetadata),
                Video,
                typeof(global::Mixedbread.VideoChunkGeneratedMetadata),
                Image,
                typeof(global::Mixedbread.ImageChunkGeneratedMetadata),
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
        public bool Equals(GeneratedMetadataVariant12 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mixedbread.MarkdownChunkGeneratedMetadata?>.Default.Equals(Markdown, other.Markdown) &&
                global::System.Collections.Generic.EqualityComparer<global::Mixedbread.TextChunkGeneratedMetadata?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Mixedbread.PDFChunkGeneratedMetadata?>.Default.Equals(Pdf, other.Pdf) &&
                global::System.Collections.Generic.EqualityComparer<global::Mixedbread.CodeChunkGeneratedMetadata?>.Default.Equals(Code, other.Code) &&
                global::System.Collections.Generic.EqualityComparer<global::Mixedbread.AudioChunkGeneratedMetadata?>.Default.Equals(Audio, other.Audio) &&
                global::System.Collections.Generic.EqualityComparer<global::Mixedbread.VideoChunkGeneratedMetadata?>.Default.Equals(Video, other.Video) &&
                global::System.Collections.Generic.EqualityComparer<global::Mixedbread.ImageChunkGeneratedMetadata?>.Default.Equals(Image, other.Image) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(GeneratedMetadataVariant12 obj1, GeneratedMetadataVariant12 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GeneratedMetadataVariant12>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(GeneratedMetadataVariant12 obj1, GeneratedMetadataVariant12 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GeneratedMetadataVariant12 o && Equals(o);
        }
    }
}
