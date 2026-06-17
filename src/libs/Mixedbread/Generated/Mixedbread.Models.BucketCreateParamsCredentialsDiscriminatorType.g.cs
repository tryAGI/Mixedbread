
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// 
    /// </summary>
    public enum BucketCreateParamsCredentialsDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        AccessKey,
        /// <summary>
        /// 
        /// </summary>
        AssumeRole,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BucketCreateParamsCredentialsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BucketCreateParamsCredentialsDiscriminatorType value)
        {
            return value switch
            {
                BucketCreateParamsCredentialsDiscriminatorType.AccessKey => "access_key",
                BucketCreateParamsCredentialsDiscriminatorType.AssumeRole => "assume_role",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BucketCreateParamsCredentialsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "access_key" => BucketCreateParamsCredentialsDiscriminatorType.AccessKey,
                "assume_role" => BucketCreateParamsCredentialsDiscriminatorType.AssumeRole,
                _ => null,
            };
        }
    }
}