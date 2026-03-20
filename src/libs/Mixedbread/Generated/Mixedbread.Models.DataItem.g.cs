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
        public DataItem(
            global::Mixedbread.StoreEventListResponseDataItemDiscriminatorType? type,
            global::Mixedbread.StoreIngestionEvent? ingestion,
            global::Mixedbread.StoreSearchEvent? search
            )
        {
            Type = type;

            Ingestion = ingestion;
            Search = search;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Search as object ??
            Ingestion as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Ingestion?.ToString() ??
            Search?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsIngestion && !IsSearch || !IsIngestion && IsSearch;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mixedbread.StoreIngestionEvent?, TResult>? ingestion = null,
            global::System.Func<global::Mixedbread.StoreSearchEvent?, TResult>? search = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mixedbread.StoreIngestionEvent?>? ingestion = null,
            global::System.Action<global::Mixedbread.StoreSearchEvent?>? search = null,
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
                global::System.Collections.Generic.EqualityComparer<global::Mixedbread.StoreSearchEvent?>.Default.Equals(Search, other.Search) 
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
