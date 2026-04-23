#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct DataItem : global::System.IEquatable<DataItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Mixedbread.StoreEventListResponseDataItemDiscriminatorType? Type { get; }

        /// <summary>
        /// Represents an ingestion event in a vector store.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mixedbread.StoreIngestionEvent? Ingestion { get; init; }
#else
        public global::Mixedbread.StoreIngestionEvent? Ingestion { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Ingestion))]
#endif
        public bool IsIngestion => Ingestion != null;

        /// <summary>
        /// Represents a search event in a vector store.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mixedbread.StoreSearchEvent? Search { get; init; }
#else
        public global::Mixedbread.StoreSearchEvent? Search { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Search))]
#endif
        public bool IsSearch => Search != null;

        /// <summary>
        /// Represents an agentic search trace in a vector store.<br/>
        /// Unlike StoreSearchEvent, this captures the full sequence of tool calls the<br/>
        /// agent issued (name, arguments, result) so developers can inspect what the<br/>
        /// agent did, along with the token usage and cost.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mixedbread.StoreAgenticSearchEvent? AgenticSearch { get; init; }
#else
        public global::Mixedbread.StoreAgenticSearchEvent? AgenticSearch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgenticSearch))]
#endif
        public bool IsAgenticSearch => AgenticSearch != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DataItem(global::Mixedbread.StoreIngestionEvent value) => new DataItem((global::Mixedbread.StoreIngestionEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mixedbread.StoreIngestionEvent?(DataItem @this) => @this.Ingestion;

        /// <summary>
        /// 
        /// </summary>
        public DataItem(global::Mixedbread.StoreIngestionEvent? value)
        {
            Ingestion = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DataItem(global::Mixedbread.StoreSearchEvent value) => new DataItem((global::Mixedbread.StoreSearchEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mixedbread.StoreSearchEvent?(DataItem @this) => @this.Search;

        /// <summary>
        /// 
        /// </summary>
        public DataItem(global::Mixedbread.StoreSearchEvent? value)
        {
            Search = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DataItem(global::Mixedbread.StoreAgenticSearchEvent value) => new DataItem((global::Mixedbread.StoreAgenticSearchEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mixedbread.StoreAgenticSearchEvent?(DataItem @this) => @this.AgenticSearch;

        /// <summary>
        /// 
        /// </summary>
        public DataItem(global::Mixedbread.StoreAgenticSearchEvent? value)
        {
            AgenticSearch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DataItem(
            global::Mixedbread.StoreEventListResponseDataItemDiscriminatorType? type,
            global::Mixedbread.StoreIngestionEvent? ingestion,
            global::Mixedbread.StoreSearchEvent? search,
            global::Mixedbread.StoreAgenticSearchEvent? agenticSearch
            )
        {
            Type = type;

            Ingestion = ingestion;
            Search = search;
            AgenticSearch = agenticSearch;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AgenticSearch as object ??
            Search as object ??
            Ingestion as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Ingestion?.ToString() ??
            Search?.ToString() ??
            AgenticSearch?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsIngestion && !IsSearch && !IsAgenticSearch || !IsIngestion && IsSearch && !IsAgenticSearch || !IsIngestion && !IsSearch && IsAgenticSearch;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mixedbread.StoreIngestionEvent?, TResult>? ingestion = null,
            global::System.Func<global::Mixedbread.StoreSearchEvent?, TResult>? search = null,
            global::System.Func<global::Mixedbread.StoreAgenticSearchEvent?, TResult>? agenticSearch = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsIngestion && ingestion != null)
            {
                return ingestion(Ingestion!);
            }
            else if (IsSearch && search != null)
            {
                return search(Search!);
            }
            else if (IsAgenticSearch && agenticSearch != null)
            {
                return agenticSearch(AgenticSearch!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mixedbread.StoreIngestionEvent?>? ingestion = null,
            global::System.Action<global::Mixedbread.StoreSearchEvent?>? search = null,
            global::System.Action<global::Mixedbread.StoreAgenticSearchEvent?>? agenticSearch = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsIngestion)
            {
                ingestion?.Invoke(Ingestion!);
            }
            else if (IsSearch)
            {
                search?.Invoke(Search!);
            }
            else if (IsAgenticSearch)
            {
                agenticSearch?.Invoke(AgenticSearch!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Ingestion,
                typeof(global::Mixedbread.StoreIngestionEvent),
                Search,
                typeof(global::Mixedbread.StoreSearchEvent),
                AgenticSearch,
                typeof(global::Mixedbread.StoreAgenticSearchEvent),
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
        public bool Equals(DataItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mixedbread.StoreIngestionEvent?>.Default.Equals(Ingestion, other.Ingestion) &&
                global::System.Collections.Generic.EqualityComparer<global::Mixedbread.StoreSearchEvent?>.Default.Equals(Search, other.Search) &&
                global::System.Collections.Generic.EqualityComparer<global::Mixedbread.StoreAgenticSearchEvent?>.Default.Equals(AgenticSearch, other.AgenticSearch) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DataItem obj1, DataItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DataItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DataItem obj1, DataItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DataItem o && Equals(o);
        }
    }
}
