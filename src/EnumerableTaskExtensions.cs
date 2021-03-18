using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading.Tasks;

namespace MyNihongo.LinqAsync
{
	public static class EnumerableTaskExtensions
	{
		#region ToArray

		public static async Task<T[]> ToArrayAsync<T>(this Task<IEnumerable<T>> @this)
		{
			var source = await @this.ConfigureAwait(false);
			return source.ToArray();
		}

		public static async Task<ImmutableArray<T>> ToImmutableArrayAsync<T>(this Task<IEnumerable<T>> @this)
		{
			var source = await @this.ConfigureAwait(false);
			return source.ToImmutableArray();
		}

		#endregion

		#region ToList

		public static async Task<IList<T>> ToListAsync<T>(this Task<IEnumerable<T>> @this)
		{
			var source = await @this.ConfigureAwait(false);
			return source.ToList();
		}

		public static async Task<IImmutableList<T>> ToImmutableListAsync<T>(this Task<IEnumerable<T>> @this)
		{
			var source = await @this.ConfigureAwait(false);
			return source.ToImmutableList();
		}

		#endregion

		#region ToLookup

		public static async Task<ILookup<TKey, TSource>> ToLookupAsync<TSource, TKey>(this Task<IEnumerable<TSource>> @this, Func<TSource, TKey> keySelector)
		{
			var source = await @this.ConfigureAwait(false);
			return source.ToLookup(keySelector);
		}

		public static async Task<ILookup<TKey, TSource>> ToLookupAsync<TSource, TKey>(this Task<IEnumerable<TSource>> @this, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer)
		{
			var source = await @this.ConfigureAwait(false);
			return source.ToLookup(keySelector, comparer);
		}

		public static async Task<ILookup<TKey, TElement>> ToLookupAsync<TSource, TKey, TElement>(this Task<IEnumerable<TSource>> @this, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
		{
			var source = await @this.ConfigureAwait(false);
			return source.ToLookup(keySelector, elementSelector);
		}

		public static async Task<ILookup<TKey, TElement>> ToLookupAsync<TSource, TKey, TElement>(this Task<IEnumerable<TSource>> @this, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
		{
			var source = await @this.ConfigureAwait(false);
			return source.ToLookup(keySelector, elementSelector, comparer);
		}

		#endregion

		#region ToSet

		public static async Task<ISet<TSource>> ToHashSetAsync<TSource>(this Task<IEnumerable<TSource>> @this)
		{
			var source = await @this.ConfigureAwait(false);
			return source.ToHashSet();
		}

		public static async Task<ISet<TSource>> ToHashSetAsync<TSource>(this Task<IEnumerable<TSource>> @this, IEqualityComparer<TSource> comparer)
		{
			var source = await @this.ConfigureAwait(false);
			return source.ToHashSet(comparer);
		}

		public static async Task<IImmutableSet<TSource>> ToImmutableHashSetAsync<TSource>(this Task<IEnumerable<TSource>> @this)
		{
			var source = await @this.ConfigureAwait(false);
			return source.ToImmutableHashSet();
		}

		public static async Task<IImmutableSet<TSource>> ToImmutableHashSetAsync<TSource>(this Task<IEnumerable<TSource>> @this, IEqualityComparer<TSource> comparer)
		{
			var source = await @this.ConfigureAwait(false);
			return source.ToImmutableHashSet(comparer);
		}

		public static async Task<IImmutableSet<TSource>> ToImmutableSortedSetAsync<TSource>(this Task<IEnumerable<TSource>> @this)
		{
			var source = await @this.ConfigureAwait(false);
			return source.ToImmutableSortedSet();
		}

		public static async Task<IImmutableSet<TSource>> ToImmutableSortedSetAsync<TSource>(this Task<IEnumerable<TSource>> @this, IComparer<TSource> comparer)
		{
			var source = await @this.ConfigureAwait(false);
			return source.ToImmutableSortedSet(comparer);
		}

		#endregion

		#region ToDictionary

		public static async Task<IDictionary<TKey, TSource>> ToDictionaryAsync<TSource, TKey>(this Task<IEnumerable<TSource>> @this, Func<TSource, TKey> keySelector)
			where TKey : notnull
		{
			var source = await @this.ConfigureAwait(false);
			return source.ToDictionary(keySelector);
		}

		public static async Task<IDictionary<TKey, TSource>> ToDictionaryAsync<TSource, TKey>(this Task<IEnumerable<TSource>> @this, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> keyComparer)
			where TKey : notnull
		{
			var source = await @this.ConfigureAwait(false);
			return source.ToDictionary(keySelector, keyComparer);
		}

		public static async Task<IDictionary<TKey, TElement>> ToDictionaryAsync<TSource, TKey, TElement>(this Task<IEnumerable<TSource>> @this, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
			where TKey : notnull
		{
			var source = await @this.ConfigureAwait(false);
			return source.ToDictionary(keySelector, elementSelector);
		}

		public static async Task<IDictionary<TKey, TElement>> ToDictionaryAsync<TSource, TKey, TElement>(this Task<IEnumerable<TSource>> @this, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> keyComparer)
			where TKey : notnull
		{
			var source = await @this.ConfigureAwait(false);
			return source.ToDictionary(keySelector, elementSelector, keyComparer);
		}

		public static async Task<IImmutableDictionary<TKey, TSource>> ToImmutableDictionaryAsync<TSource, TKey>(this Task<IEnumerable<TSource>> @this, Func<TSource, TKey> keySelector)
			where TKey : notnull
		{
			var source = await @this.ConfigureAwait(false);
			return source.ToImmutableDictionary(keySelector);
		}

		public static async Task<IImmutableDictionary<TKey, TSource>> ToImmutableDictionaryAsync<TSource, TKey>(this Task<IEnumerable<TSource>> @this, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> keyComparer)
			where TKey : notnull
		{
			var source = await @this.ConfigureAwait(false);
			return source.ToImmutableDictionary(keySelector, keyComparer);
		}

		public static async Task<IImmutableDictionary<TKey, TElement>> ToImmutableDictionaryAsync<TSource, TKey, TElement>(this Task<IEnumerable<TSource>> @this, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
			where TKey : notnull
		{
			var source = await @this.ConfigureAwait(false);
			return source.ToImmutableDictionary(keySelector, elementSelector);
		}

		public static async Task<IImmutableDictionary<TKey, TElement>> ToImmutableDictionaryAsync<TSource, TKey, TElement>(this Task<IEnumerable<TSource>> @this, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> keyComparer)
			where TKey : notnull
		{
			var source = await @this.ConfigureAwait(false);
			return source.ToImmutableDictionary(keySelector, elementSelector, keyComparer);
		}

		public static async Task<IImmutableDictionary<TKey, TElement>> ToImmutableDictionaryAsync<TSource, TKey, TElement>(this Task<IEnumerable<TSource>> @this, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> keyComparer, IEqualityComparer<TElement> valueComparer)
			where TKey : notnull
		{
			var source = await @this.ConfigureAwait(false);
			return source.ToImmutableDictionary(keySelector, elementSelector, keyComparer, valueComparer);
		}

		public static async Task<IImmutableDictionary<TKey, TElement>> ToImmutableSortedDictionaryAsync<TSource, TKey, TElement>(this Task<IEnumerable<TSource>> @this, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
			where TKey : notnull
		{
			var source = await @this.ConfigureAwait(false);
			return source.ToImmutableSortedDictionary(keySelector, elementSelector);
		}

		public static async Task<IImmutableDictionary<TKey, TElement>> ToImmutableSortedDictionaryAsync<TSource, TKey, TElement>(this Task<IEnumerable<TSource>> @this, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IComparer<TKey> keyComparer)
			where TKey : notnull
		{
			var source = await @this.ConfigureAwait(false);
			return source.ToImmutableSortedDictionary(keySelector, elementSelector, keyComparer);
		}

		public static async Task<IImmutableDictionary<TKey, TElement>> ToImmutableSortedDictionaryAsync<TSource, TKey, TElement>(this Task<IEnumerable<TSource>> @this, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IComparer<TKey> keyComparer, IEqualityComparer<TElement> valueComparer)
			where TKey : notnull
		{
			var source = await @this.ConfigureAwait(false);
			return source.ToImmutableSortedDictionary(keySelector, elementSelector, keyComparer, valueComparer);
		}

		#endregion

		#region Select

		public static async Task<IEnumerable<TResult>> Select<TSource, TResult>(this Task<IEnumerable<TSource>> @this, Func<TSource, TResult> selector)
		{
			var source = await @this.ConfigureAwait(false);
			return source.Select(selector);
		}

		public static async Task<IEnumerable<TResult>> Select<TSource, TResult>(this Task<IEnumerable<TSource>> @this, Func<TSource, int, TResult> selector)
		{
			var source = await @this.ConfigureAwait(false);
			return source.Select(selector);
		}

		#endregion

		#region SelectMany

		public static async Task<IEnumerable<TResult>> SelectMany<TSource, TResult>(this Task<IEnumerable<TSource>> @this, Func<TSource, IEnumerable<TResult>> selector)
		{
			var source = await @this.ConfigureAwait(false);
			return source.SelectMany(selector);
		}

		public static async Task<IEnumerable<TResult>> SelectMany<TSource, TResult>(this Task<IEnumerable<TSource>> @this, Func<TSource, int, IEnumerable<TResult>> selector)
		{
			var source = await @this.ConfigureAwait(false);
			return source.SelectMany(selector);
		}

		public static async Task<IEnumerable<TResult>> SelectMany<TSource, TCollection, TResult>(this Task<IEnumerable<TSource>> @this, Func<TSource, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector)
		{
			var source = await @this.ConfigureAwait(false);
			return source.SelectMany(collectionSelector, resultSelector);
		}

		public static async Task<IEnumerable<TResult>> SelectMany<TSource, TCollection, TResult>(this Task<IEnumerable<TSource>> @this, Func<TSource, int, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector)
		{
			var source = await @this.ConfigureAwait(false);
			return source.SelectMany(collectionSelector, resultSelector);
		}

		#endregion
	}
}
