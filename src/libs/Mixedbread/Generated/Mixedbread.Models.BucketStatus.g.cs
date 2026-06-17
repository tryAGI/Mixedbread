
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Validation lifecycle of a customer bucket.
    /// </summary>
    public enum BucketStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BucketStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BucketStatus value)
        {
            return value switch
            {
                BucketStatus.Active => "active",
                BucketStatus.Error => "error",
                BucketStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BucketStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => BucketStatus.Active,
                "error" => BucketStatus.Error,
                "pending" => BucketStatus.Pending,
                _ => null,
            };
        }
    }
}