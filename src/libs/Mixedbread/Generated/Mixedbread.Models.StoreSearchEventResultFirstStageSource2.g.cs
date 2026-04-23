
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// 
    /// </summary>
    public enum StoreSearchEventResultFirstStageSource2
    {
        /// <summary>
        /// 
        /// </summary>
        Both,
        /// <summary>
        /// 
        /// </summary>
        Dense,
        /// <summary>
        /// 
        /// </summary>
        Sparse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StoreSearchEventResultFirstStageSource2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StoreSearchEventResultFirstStageSource2 value)
        {
            return value switch
            {
                StoreSearchEventResultFirstStageSource2.Both => "both",
                StoreSearchEventResultFirstStageSource2.Dense => "dense",
                StoreSearchEventResultFirstStageSource2.Sparse => "sparse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StoreSearchEventResultFirstStageSource2? ToEnum(string value)
        {
            return value switch
            {
                "both" => StoreSearchEventResultFirstStageSource2.Both,
                "dense" => StoreSearchEventResultFirstStageSource2.Dense,
                "sparse" => StoreSearchEventResultFirstStageSource2.Sparse,
                _ => null,
            };
        }
    }
}