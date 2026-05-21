
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// 
    /// </summary>
    public enum StoreListChunksResponseDataItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        AudioUrl,
        /// <summary>
        /// 
        /// </summary>
        ImageUrl,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        VideoUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StoreListChunksResponseDataItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StoreListChunksResponseDataItemDiscriminatorType value)
        {
            return value switch
            {
                StoreListChunksResponseDataItemDiscriminatorType.AudioUrl => "audio_url",
                StoreListChunksResponseDataItemDiscriminatorType.ImageUrl => "image_url",
                StoreListChunksResponseDataItemDiscriminatorType.Text => "text",
                StoreListChunksResponseDataItemDiscriminatorType.VideoUrl => "video_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StoreListChunksResponseDataItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "audio_url" => StoreListChunksResponseDataItemDiscriminatorType.AudioUrl,
                "image_url" => StoreListChunksResponseDataItemDiscriminatorType.ImageUrl,
                "text" => StoreListChunksResponseDataItemDiscriminatorType.Text,
                "video_url" => StoreListChunksResponseDataItemDiscriminatorType.VideoUrl,
                _ => null,
            };
        }
    }
}