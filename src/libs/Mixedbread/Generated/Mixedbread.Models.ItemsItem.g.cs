#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ItemsItem : global::System.IEquatable<ItemsItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Mixedbread.QueryEnhanceResultsItemDiscriminatorType? Type { get; }

        /// <summary>
        /// Enhanced semantic search query with optional filters.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mixedbread.QueryEnhanceQueryItem? Query { get; init; }
#else
        public global::Mixedbread.QueryEnhanceQueryItem? Query { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Query))]
#endif
        public bool IsQuery => Query != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickQuery(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Mixedbread.QueryEnhanceQueryItem? value)
        {
            value = Query;
            return IsQuery;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Mixedbread.QueryEnhanceQueryItem PickQuery() => IsQuery
            ? Query!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Query' but the value was {ToString()}.");

        /// <summary>
        /// Ranking request based on metadata.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mixedbread.QueryEnhanceSortItem? Sort { get; init; }
#else
        public global::Mixedbread.QueryEnhanceSortItem? Sort { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sort))]
#endif
        public bool IsSort => Sort != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSort(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Mixedbread.QueryEnhanceSortItem? value)
        {
            value = Sort;
            return IsSort;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Mixedbread.QueryEnhanceSortItem PickSort() => IsSort
            ? Sort!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sort' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ItemsItem(global::Mixedbread.QueryEnhanceQueryItem value) => new ItemsItem((global::Mixedbread.QueryEnhanceQueryItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mixedbread.QueryEnhanceQueryItem?(ItemsItem @this) => @this.Query;

        /// <summary>
        /// 
        /// </summary>
        public ItemsItem(global::Mixedbread.QueryEnhanceQueryItem? value)
        {
            Query = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ItemsItem FromQuery(global::Mixedbread.QueryEnhanceQueryItem? value) => new ItemsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ItemsItem(global::Mixedbread.QueryEnhanceSortItem value) => new ItemsItem((global::Mixedbread.QueryEnhanceSortItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mixedbread.QueryEnhanceSortItem?(ItemsItem @this) => @this.Sort;

        /// <summary>
        /// 
        /// </summary>
        public ItemsItem(global::Mixedbread.QueryEnhanceSortItem? value)
        {
            Sort = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ItemsItem FromSort(global::Mixedbread.QueryEnhanceSortItem? value) => new ItemsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public ItemsItem(
            global::Mixedbread.QueryEnhanceResultsItemDiscriminatorType? type,
            global::Mixedbread.QueryEnhanceQueryItem? query,
            global::Mixedbread.QueryEnhanceSortItem? sort
            )
        {
            Type = type;

            Query = query;
            Sort = sort;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Sort as object ??
            Query as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Query?.ToString() ??
            Sort?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsQuery && !IsSort || !IsQuery && IsSort;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mixedbread.QueryEnhanceQueryItem, TResult>? query = null,
            global::System.Func<global::Mixedbread.QueryEnhanceSortItem, TResult>? sort = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsQuery && query != null)
            {
                return query(Query!);
            }
            else if (IsSort && sort != null)
            {
                return sort(Sort!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mixedbread.QueryEnhanceQueryItem>? query = null,

            global::System.Action<global::Mixedbread.QueryEnhanceSortItem>? sort = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsQuery)
            {
                query?.Invoke(Query!);
            }
            else if (IsSort)
            {
                sort?.Invoke(Sort!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Mixedbread.QueryEnhanceQueryItem>? query = null,
            global::System.Action<global::Mixedbread.QueryEnhanceSortItem>? sort = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsQuery)
            {
                query?.Invoke(Query!);
            }
            else if (IsSort)
            {
                sort?.Invoke(Sort!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Query,
                typeof(global::Mixedbread.QueryEnhanceQueryItem),
                Sort,
                typeof(global::Mixedbread.QueryEnhanceSortItem),
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
        public bool Equals(ItemsItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mixedbread.QueryEnhanceQueryItem?>.Default.Equals(Query, other.Query) &&
                global::System.Collections.Generic.EqualityComparer<global::Mixedbread.QueryEnhanceSortItem?>.Default.Equals(Sort, other.Sort) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ItemsItem obj1, ItemsItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ItemsItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ItemsItem obj1, ItemsItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ItemsItem o && Equals(o);
        }
    }
}
