
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// 
    /// </summary>
    public enum StoreGrepResponseDataItemDiscriminatorType
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
    public static class StoreGrepResponseDataItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StoreGrepResponseDataItemDiscriminatorType value)
        {
            return value switch
            {
                StoreGrepResponseDataItemDiscriminatorType.AudioUrl => "audio_url",
                StoreGrepResponseDataItemDiscriminatorType.ImageUrl => "image_url",
                StoreGrepResponseDataItemDiscriminatorType.Text => "text",
                StoreGrepResponseDataItemDiscriminatorType.VideoUrl => "video_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StoreGrepResponseDataItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "audio_url" => StoreGrepResponseDataItemDiscriminatorType.AudioUrl,
                "image_url" => StoreGrepResponseDataItemDiscriminatorType.ImageUrl,
                "text" => StoreGrepResponseDataItemDiscriminatorType.Text,
                "video_url" => StoreGrepResponseDataItemDiscriminatorType.VideoUrl,
                _ => null,
            };
        }
    }
}