
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Object-storage provider backing a bring-your-own bucket.
    /// </summary>
    public enum BucketProvider
    {
        /// <summary>
        /// 
        /// </summary>
        AwsS3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BucketProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BucketProvider value)
        {
            return value switch
            {
                BucketProvider.AwsS3 => "aws_s3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BucketProvider? ToEnum(string value)
        {
            return value switch
            {
                "aws_s3" => BucketProvider.AwsS3,
                _ => null,
            };
        }
    }
}