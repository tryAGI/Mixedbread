
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScopeMethod
    {
        /// <summary>
        /// 
        /// </summary>
        Read,
        /// <summary>
        /// 
        /// </summary>
        Write,
        /// <summary>
        /// 
        /// </summary>
        Delete,
        /// <summary>
        /// 
        /// </summary>
        List,
        /// <summary>
        /// 
        /// </summary>
        Create,
        /// <summary>
        /// 
        /// </summary>
        Search,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScopeMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScopeMethod value)
        {
            return value switch
            {
                ScopeMethod.Read => "read",
                ScopeMethod.Write => "write",
                ScopeMethod.Delete => "delete",
                ScopeMethod.List => "list",
                ScopeMethod.Create => "create",
                ScopeMethod.Search => "search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScopeMethod? ToEnum(string value)
        {
            return value switch
            {
                "read" => ScopeMethod.Read,
                "write" => ScopeMethod.Write,
                "delete" => ScopeMethod.Delete,
                "list" => ScopeMethod.List,
                "create" => ScopeMethod.Create,
                "search" => ScopeMethod.Search,
                _ => null,
            };
        }
    }
}