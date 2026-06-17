
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// How omni authenticates against a customer bucket.<br/>
    /// ASSUME_ROLE is the recommended default for AWS: nothing secret is stored,<br/>
    /// every service assumes the customer's IAM role via STS on use. ACCESS_KEY<br/>
    /// remains for S3-compatible providers that have no STS.
    /// </summary>
    public enum BucketAuthType
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
    public static class BucketAuthTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BucketAuthType value)
        {
            return value switch
            {
                BucketAuthType.AccessKey => "access_key",
                BucketAuthType.AssumeRole => "assume_role",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BucketAuthType? ToEnum(string value)
        {
            return value switch
            {
                "access_key" => BucketAuthType.AccessKey,
                "assume_role" => BucketAuthType.AssumeRole,
                _ => null,
            };
        }
    }
}