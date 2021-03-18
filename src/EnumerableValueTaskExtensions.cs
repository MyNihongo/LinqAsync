using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading.Tasks;

namespace MyNihongo.LinqAsync
{
	public static class EnumerableValueTaskExtensions
	{
		#region ToArray

		public static async ValueTask<T[]> ToArrayAsync<T>(this ValueTask<IEnumerable<T>> @this)
		{
			var source = await @this.ConfigureAwait(false);
			return source.ToArray();
		}

		public static async ValueTask<ImmutableArray<T>> ToImmutableArrayAsync<T>(this ValueTask<IEnumerable<T>> @this)
		{
			var source = await @this.ConfigureAwait(false);
			return source.ToImmutableArray();
		}

		#endregion

		#region ToList

		public static async ValueTask<IList<T>> ToListAsync<T>(this ValueTask<IEnumerable<T>> @this)
		{
			var source = await @this.ConfigureAwait(false);
			return source.ToList();
		}

		public static async ValueTask<IImmutableList<T>> ToImmutableListAsync<T>(this ValueTask<IEnumerable<T>> @this)
		{
			var source = await @this.ConfigureAwait(false);
			return source.ToImmutableList();
		}

		#endregion

		#region ToLookup

		public static async ValueTask<ILookup<TKey, TSource>> ToLookupAsync<TSource, TKey>(this ValueTask<IEnumerable<TSource>> @this, Func<TSource, TKey> keySelector)
		{
			var source = await @this.ConfigureAwait(false);
			return source.ToLookup(keySelector);
		}

		public static async ValueTask<ILookup<TKey, TSource>> ToLookupAsync<TSource, TKey>(this ValueTask<IEnumerable<TSource>> @this, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer)
		{
			var source = await @this.ConfigureAwait(false);
			return source.ToLookup(keySelector, comparer);
		}

		public static async ValueTask<ILookup<TKey, TElement>> ToLookupAsync<TSource, TKey, TElement>(this ValueTask<IEnumerable<TSource>> @this, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
		{
			var source = await @this.ConfigureAwait(false);
			return source.ToLookup(keySelector, elementSelector);
		}

		public static async ValueTask<ILookup<TKey, TElement>> ToLookupAsync<TSource, TKey, TElement>(this ValueTask<IEnumerable<TSource>> @this, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
		{
			var source = await @this.ConfigureAwait(false);
			return source.ToLookup(keySelector, elementSelector, comparer);
		}

		#endregion

		#region ToSet

		public static async ValueTask<ISet<TSource>> ToHashSetAsync<TSource>(this ValueTask<IEnumerable<TSource>> @this)
		{
			var source = await @this.ConfigureAwait(false);
			return source.ToHashSet();
		}

		public static async ValueTask<ISet<TSource>> ToHashSetAsync<TSource>(this ValueTask<IEnumerable<TSource>> @this, IEqualityComparer<TSource> comparer)
		{
			var source = await @this.ConfigureAwait(false);
			return source.ToHashSet(comparer);
		}

		public static async ValueTask<IImmutableSet<TSource>> ToImmutableHashSetAsync<TSource>(this ValueTask<IEnumerable<TSource>> @this)
		{
			var source = await @this.ConfigureAwait(false);
			return source.ToImmutableHashSet();
		}

		public static async ValueTask<IImmutableSet<TSource>> ToImmutableHashSetAsync<TSource>(this ValueTask<IEnumerable<TSource>> @this, IEqualityComparer<TSource> comparer)
		{
			var source = await @this.ConfigureAwait(false);
			return source.ToImmutableHashSet(comparer);
		}

		public static async ValueTask<IImmutableSet<TSource>> ToImmutableSortedSetAsync<TSource>(this ValueTask<IEnumerable<TSource>> @this)
		{
			var source = await @this.ConfigureAwait(false);
			return source.ToImmutableSortedSet();
		}

		public static async ValueTask<IImmutableSet<TSource>> ToImmutableSortedSetAsync<TSource>(this ValueTask<IEnumerable<TSource>> @this, IComparer<TSource> comparer)
		{
			var source = await @this.ConfigureAwait(false);
			return source.ToImmutableSortedSet(comparer);
		}

		#endregion

		#region ToDictionary

		public static async ValueTask<IDictionary<TKey, TSource>> ToDictionaryAsync<TSource, TKey>(this ValueTask<IEnumerable<TSource>> @this, Func<TSource, TKey> keySelector)
			where TKey : notnull
		{
			var source = await @this.ConfigureAwait(false);
			return source.ToDictionary(keySelector);
		}

		public static async ValueTask<IDictionary<TKey, TSource>> ToDictionaryAsync<TSource, TKey>(this ValueTask<IEnumerable<TSource>> @this, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> keyComparer)
			where TKey : notnull
		{
			var source = await @this.ConfigureAwait(false);
			return source.ToDictionary(keySelector, keyComparer);
		}

		public static async ValueTask<IDictionary<TKey, TElement>> ToDictionaryAsync<TSource, TKey, TElement>(this ValueTask<IEnumerable<TSource>> @this, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
			where TKey : notnull
		{
			var source = await @this.ConfigureAwait(false);
			return source.ToDictionary(keySelector, elementSelector);
		}

		public static async ValueTask<IDictionary<TKey, TElement>> ToDictionaryAsync<TSource, TKey, TElement>(this ValueTask<IEnumerable<TSource>> @this, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> keyComparer)
			where TKey : notnull
		{
			var source = await @this.ConfigureAwait(false);
			return source.ToDictionary(keySelector, elementSelector, keyComparer);
		}

		public static async ValueTask<IImmutableDictionary<TKey, TSource>> ToImmutableDictionaryAsync<TSource, TKey>(this ValueTask<IEnumerable<TSource>> @this, Func<TSource, TKey> keySelector)
			where TKey : notnull
		{
			var source = await @this.ConfigureAwait(false);
			return source.ToImmutableDictionary(keySelector);
		}

		public static async ValueTask<IImmutableDictionary<TKey, TSource>> ToImmutableDictionaryAsync<TSource, TKey>(this ValueTask<IEnumerable<TSource>> @this, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> keyComparer)
			where TKey : notnull
		{
			var source = await @this.ConfigureAwait(false);
			return source.ToImmutableDictionary(keySelector, keyComparer);
		}

		public static async ValueTask<IImmutableDictionary<TKey, TElement>> ToImmutableDictionaryAsync<TSource, TKey, TElement>(this ValueTask<IEnumerable<TSource>> @this, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
			where TKey : notnull
		{
			var source = await @this.ConfigureAwait(false);
			return source.ToImmutableDictionary(keySelector, elementSelector);
		}

		public static async ValueTask<IImmutableDictionary<TKey, TElement>> ToImmutableDictionaryAsync<TSource, TKey, TElement>(this ValueTask<IEnumerable<TSource>> @this, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> keyComparer)
			where TKey : notnull
		{
			var source = await @this.ConfigureAwait(false);
			return source.ToImmutableDictionary(keySelector, elementSelector, keyComparer);
		}

		public static async ValueTask<IImmutableDictionary<TKey, TElement>> ToImmutableDictionaryAsync<TSource, TKey, TElement>(this ValueTask<IEnumerable<TSource>> @this, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> keyComparer, IEqualityComparer<TElement> valueComparer)
			where TKey : notnull
		{
			var source = await @this.ConfigureAwait(false);
			return source.ToImmutableDictionary(keySelector, elementSelector, keyComparer, valueComparer);
		}

		public static async ValueTask<IImmutableDictionary<TKey, TElement>> ToImmutableSortedDictionaryAsync<TSource, TKey, TElement>(this ValueTask<IEnumerable<TSource>> @this, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
			where TKey : notnull
		{
			var source = await @this.ConfigureAwait(false);
			return source.ToImmutableSortedDictionary(keySelector, elementSelector);
		}

		public static async ValueTask<IImmutableDictionary<TKey, TElement>> ToImmutableSortedDictionaryAsync<TSource, TKey, TElement>(this ValueTask<IEnumerable<TSource>> @this, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IComparer<TKey> keyComparer)
			where TKey : notnull
		{
			var source = await @this.ConfigureAwait(false);
			return source.ToImmutableSortedDictionary(keySelector, elementSelector, keyComparer);
		}

		public static async ValueTask<IImmutableDictionary<TKey, TElement>> ToImmutableSortedDictionaryAsync<TSource, TKey, TElement>(this ValueTask<IEnumerable<TSource>> @this, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IComparer<TKey> keyComparer, IEqualityComparer<TElement> valueComparer)
			where TKey : notnull
		{
			var source = await @this.ConfigureAwait(false);
			return source.ToImmutableSortedDictionary(keySelector, elementSelector, keyComparer, valueComparer);
		}

		#endregion

		#region Select

		public static async ValueTask<IEnumerable<TResult>> Select<TSource, TResult>(this ValueTask<IEnumerable<TSource>> @this, Func<TSource, TResult> selector)
		{
			var source = await @this.ConfigureAwait(false);
			return source.Select(selector);
		}

		public static async ValueTask<IEnumerable<TResult>> Select<TSource, TResult>(this ValueTask<IEnumerable<TSource>> @this, Func<TSource, int, TResult> selector)
		{
			var source = await @this.ConfigureAwait(false);
			return source.Select(selector);
		}

		#endregion

		#region SelectMany

		public static async ValueTask<IEnumerable<TResult>> SelectMany<TSource, TResult>(this ValueTask<IEnumerable<TSource>> @this, Func<TSource, IEnumerable<TResult>> selector)
		{
			var source = await @this.ConfigureAwait(false);
			return source.SelectMany(selector);
		}

		public static async ValueTask<IEnumerable<TResult>> SelectMany<TSource, TResult>(this ValueTask<IEnumerable<TSource>> @this, Func<TSource, int, IEnumerable<TResult>> selector)
		{
			var source = await @this.ConfigureAwait(false);
			return source.SelectMany(selector);
		}

		public static async ValueTask<IEnumerable<TResult>> SelectMany<TSource, TCollection, TResult>(this ValueTask<IEnumerable<TSource>> @this, Func<TSource, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector)
		{
			var source = await @this.ConfigureAwait(false);
			return source.SelectMany(collectionSelector, resultSelector);
		}

		public static async ValueTask<IEnumerable<TResult>> SelectMany<TSource, TCollection, TResult>(this ValueTask<IEnumerable<TSource>> @this, Func<TSource, int, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector)
		{
			var source = await @this.ConfigureAwait(false);
			return source.SelectMany(collectionSelector, resultSelector);
		}

		#endregion
	}
}
