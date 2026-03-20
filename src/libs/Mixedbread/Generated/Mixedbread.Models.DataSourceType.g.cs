
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// 
    /// </summary>
    public enum DataSourceType
    {
        /// <summary>
        /// 
        /// </summary>
        Notion,
        /// <summary>
        /// 
        /// </summary>
        Linear,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DataSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DataSourceType value)
        {
            return value switch
            {
                DataSourceType.Notion => "notion",
                DataSourceType.Linear => "linear",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DataSourceType? ToEnum(string value)
        {
            return value switch
            {
                "notion" => DataSourceType.Notion,
                "linear" => DataSourceType.Linear,
                _ => null,
            };
        }
    }
}