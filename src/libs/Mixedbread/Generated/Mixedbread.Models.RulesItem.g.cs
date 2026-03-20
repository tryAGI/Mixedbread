#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// The possible rules for a vector store search
    /// </summary>
    public readonly partial struct RulesItem : global::System.IEquatable<RulesItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleCreateParamsRuleDiscriminatorType? Type { get; }

        /// <summary>
        /// Represents a string query substitution rule for a vector store search.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mixedbread.QueryStringSubstitutionRule? QueryString { get; init; }
#else
        public global::Mixedbread.QueryStringSubstitutionRule? QueryString { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(QueryString))]
#endif
        public bool IsQueryString => QueryString != null;

        /// <summary>
        /// Represents a regex query substitution rule for a vector store search.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mixedbread.QueryRegexSubstitutionRule? QueryRegex { get; init; }
#else
        public global::Mixedbread.QueryRegexSubstitutionRule? QueryRegex { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(QueryRegex))]
#endif
        public bool IsQueryRegex => QueryRegex != null;

        /// <summary>
        /// Represents a chunk search result rule for a vector store search.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mixedbread.ChunkSearchResultRule? ChunkSearchResult { get; init; }
#else
        public global::Mixedbread.ChunkSearchResultRule? ChunkSearchResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChunkSearchResult))]
#endif
        public bool IsChunkSearchResult => ChunkSearchResult != null;

        /// <summary>
        /// Represents a file search result rule for a vector store search.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mixedbread.FileSearchResultRule? FileSearchResult { get; init; }
#else
        public global::Mixedbread.FileSearchResultRule? FileSearchResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileSearchResult))]
#endif
        public bool IsFileSearchResult => FileSearchResult != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RulesItem(global::Mixedbread.QueryStringSubstitutionRule value) => new RulesItem((global::Mixedbread.QueryStringSubstitutionRule?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mixedbread.QueryStringSubstitutionRule?(RulesItem @this) => @this.QueryString;

        /// <summary>
        /// 
        /// </summary>
        public RulesItem(global::Mixedbread.QueryStringSubstitutionRule? value)
        {
            QueryString = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RulesItem(global::Mixedbread.QueryRegexSubstitutionRule value) => new RulesItem((global::Mixedbread.QueryRegexSubstitutionRule?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mixedbread.QueryRegexSubstitutionRule?(RulesItem @this) => @this.QueryRegex;

        /// <summary>
        /// 
        /// </summary>
        public RulesItem(global::Mixedbread.QueryRegexSubstitutionRule? value)
        {
            QueryRegex = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RulesItem(global::Mixedbread.ChunkSearchResultRule value) => new RulesItem((global::Mixedbread.ChunkSearchResultRule?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mixedbread.ChunkSearchResultRule?(RulesItem @this) => @this.ChunkSearchResult;

        /// <summary>
        /// 
        /// </summary>
        public RulesItem(global::Mixedbread.ChunkSearchResultRule? value)
        {
            ChunkSearchResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RulesItem(global::Mixedbread.FileSearchResultRule value) => new RulesItem((global::Mixedbread.FileSearchResultRule?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mixedbread.FileSearchResultRule?(RulesItem @this) => @this.FileSearchResult;

        /// <summary>
        /// 
        /// </summary>
        public RulesItem(global::Mixedbread.FileSearchResultRule? value)
        {
            FileSearchResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RulesItem(
            global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleCreateParamsRuleDiscriminatorType? type,
            global::Mixedbread.QueryStringSubstitutionRule? queryString,
            global::Mixedbread.QueryRegexSubstitutionRule? queryRegex,
            global::Mixedbread.ChunkSearchResultRule? chunkSearchResult,
            global::Mixedbread.FileSearchResultRule? fileSearchResult
            )
        {
            Type = type;

            QueryString = queryString;
            QueryRegex = queryRegex;
            ChunkSearchResult = chunkSearchResult;
            FileSearchResult = fileSearchResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FileSearchResult as object ??
            ChunkSearchResult as object ??
            QueryRegex as object ??
            QueryString as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            QueryString?.ToString() ??
            QueryRegex?.ToString() ??
            ChunkSearchResult?.ToString() ??
            FileSearchResult?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsQueryString && !IsQueryRegex && !IsChunkSearchResult && !IsFileSearchResult || !IsQueryString && IsQueryRegex && !IsChunkSearchResult && !IsFileSearchResult || !IsQueryString && !IsQueryRegex && IsChunkSearchResult && !IsFileSearchResult || !IsQueryString && !IsQueryRegex && !IsChunkSearchResult && IsFileSearchResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mixedbread.QueryStringSubstitutionRule?, TResult>? queryString = null,
            global::System.Func<global::Mixedbread.QueryRegexSubstitutionRule?, TResult>? queryRegex = null,
            global::System.Func<global::Mixedbread.ChunkSearchResultRule?, TResult>? chunkSearchResult = null,
            global::System.Func<global::Mixedbread.FileSearchResultRule?, TResult>? fileSearchResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsQueryString && queryString != null)
            {
                return queryString(QueryString!);
            }
            else if (IsQueryRegex && queryRegex != null)
            {
                return queryRegex(QueryRegex!);
            }
            else if (IsChunkSearchResult && chunkSearchResult != null)
            {
                return chunkSearchResult(ChunkSearchResult!);
            }
            else if (IsFileSearchResult && fileSearchResult != null)
            {
                return fileSearchResult(FileSearchResult!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mixedbread.QueryStringSubstitutionRule?>? queryString = null,
            global::System.Action<global::Mixedbread.QueryRegexSubstitutionRule?>? queryRegex = null,
            global::System.Action<global::Mixedbread.ChunkSearchResultRule?>? chunkSearchResult = null,
            global::System.Action<global::Mixedbread.FileSearchResultRule?>? fileSearchResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsQueryString)
            {
                queryString?.Invoke(QueryString!);
            }
            else if (IsQueryRegex)
            {
                queryRegex?.Invoke(QueryRegex!);
            }
            else if (IsChunkSearchResult)
            {
                chunkSearchResult?.Invoke(ChunkSearchResult!);
            }
            else if (IsFileSearchResult)
            {
                fileSearchResult?.Invoke(FileSearchResult!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                QueryString,
                typeof(global::Mixedbread.QueryStringSubstitutionRule),
                QueryRegex,
                typeof(global::Mixedbread.QueryRegexSubstitutionRule),
                ChunkSearchResult,
                typeof(global::Mixedbread.ChunkSearchResultRule),
                FileSearchResult,
                typeof(global::Mixedbread.FileSearchResultRule),
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
        public bool Equals(RulesItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mixedbread.QueryStringSubstitutionRule?>.Default.Equals(QueryString, other.QueryString) &&
                global::System.Collections.Generic.EqualityComparer<global::Mixedbread.QueryRegexSubstitutionRule?>.Default.Equals(QueryRegex, other.QueryRegex) &&
                global::System.Collections.Generic.EqualityComparer<global::Mixedbread.ChunkSearchResultRule?>.Default.Equals(ChunkSearchResult, other.ChunkSearchResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Mixedbread.FileSearchResultRule?>.Default.Equals(FileSearchResult, other.FileSearchResult) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RulesItem obj1, RulesItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RulesItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RulesItem obj1, RulesItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RulesItem o && Equals(o);
        }
    }
}
