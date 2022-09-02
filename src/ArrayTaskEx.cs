namespace MyNihongo.LinqAsync;

public static class ArrayTaskEx
{
	#region ToArray

	public static async Task<ImmutableArray<T>> ToImmutableArrayAsync<T>(this Task<T[]> @this)
	{
		var source = await @this.ConfigureAwait(false);
		return source.ToImmutableArray();
	}

	#endregion

	#region ToDictionary

	public static async Task<IDictionary<TKey, TSource>> ToDictionaryAsync<TSource, TKey>(this Task<TSource[]> @this, Func<TSource, TKey> keySelector)
		where TKey : notnull
	{
		var source = await @this.ConfigureAwait(false);
		return source.ToDictionary(keySelector);
	}

	public static async Task<IDictionary<TKey, TSource>> ToDictionaryAsync<TSource, TKey>(this Task<TSource[]> @this, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> keyComparer)
		where TKey : notnull
	{
		var source = await @this.ConfigureAwait(false);
		return source.ToDictionary(keySelector, keyComparer);
	}

	public static async Task<IDictionary<TKey, TElement>> ToDictionaryAsync<TSource, TKey, TElement>(this Task<TSource[]> @this, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
		where TKey : notnull
	{
		var source = await @this.ConfigureAwait(false);
		return source.ToDictionary(keySelector, elementSelector);
	}

	public static async Task<IDictionary<TKey, TElement>> ToDictionaryAsync<TSource, TKey, TElement>(this Task<TSource[]> @this, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> keyComparer)
		where TKey : notnull
	{
		var source = await @this.ConfigureAwait(false);
		return source.ToDictionary(keySelector, elementSelector, keyComparer);
	}

	public static async Task<IImmutableDictionary<TKey, TSource>> ToImmutableDictionaryAsync<TSource, TKey>(this Task<TSource[]> @this, Func<TSource, TKey> keySelector)
		where TKey : notnull
	{
		var source = await @this.ConfigureAwait(false);
		return source.ToImmutableDictionary(keySelector);
	}

	public static async Task<IImmutableDictionary<TKey, TSource>> ToImmutableDictionaryAsync<TSource, TKey>(this Task<TSource[]> @this, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> keyComparer)
		where TKey : notnull
	{
		var source = await @this.ConfigureAwait(false);
		return source.ToImmutableDictionary(keySelector, keyComparer);
	}

	public static async Task<IImmutableDictionary<TKey, TElement>> ToImmutableDictionaryAsync<TSource, TKey, TElement>(this Task<TSource[]> @this, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
		where TKey : notnull
	{
		var source = await @this.ConfigureAwait(false);
		return source.ToImmutableDictionary(keySelector, elementSelector);
	}

	public static async Task<IImmutableDictionary<TKey, TElement>> ToImmutableDictionaryAsync<TSource, TKey, TElement>(this Task<TSource[]> @this, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> keyComparer)
		where TKey : notnull
	{
		var source = await @this.ConfigureAwait(false);
		return source.ToImmutableDictionary(keySelector, elementSelector, keyComparer);
	}

	public static async Task<IImmutableDictionary<TKey, TElement>> ToImmutableDictionaryAsync<TSource, TKey, TElement>(this Task<TSource[]> @this, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> keyComparer, IEqualityComparer<TElement> valueComparer)
		where TKey : notnull
	{
		var source = await @this.ConfigureAwait(false);
		return source.ToImmutableDictionary(keySelector, elementSelector, keyComparer, valueComparer);
	}

	public static async Task<IImmutableDictionary<TKey, TElement>> ToImmutableSortedDictionaryAsync<TSource, TKey, TElement>(this Task<TSource[]> @this, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
		where TKey : notnull
	{
		var source = await @this.ConfigureAwait(false);
		return source.ToImmutableSortedDictionary(keySelector, elementSelector);
	}

	public static async Task<IImmutableDictionary<TKey, TElement>> ToImmutableSortedDictionaryAsync<TSource, TKey, TElement>(this Task<TSource[]> @this, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IComparer<TKey> keyComparer)
		where TKey : notnull
	{
		var source = await @this.ConfigureAwait(false);
		return source.ToImmutableSortedDictionary(keySelector, elementSelector, keyComparer);
	}

	public static async Task<IImmutableDictionary<TKey, TElement>> ToImmutableSortedDictionaryAsync<TSource, TKey, TElement>(this Task<TSource[]> @this, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IComparer<TKey> keyComparer, IEqualityComparer<TElement> valueComparer)
		where TKey : notnull
	{
		var source = await @this.ConfigureAwait(false);
		return source.ToImmutableSortedDictionary(keySelector, elementSelector, keyComparer, valueComparer);
	}

	#endregion

	#region ToLookup

	public static async Task<ILookup<TKey, TElement>> ToLookupAsync<TSource, TKey, TElement>(this Task<TSource[]> @this, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
	{
		var source = await @this.ConfigureAwait(false);
		return source.ToLookup(keySelector, elementSelector);
	}

	#endregion

	#region Select

	public static async Task<IEnumerable<TResult>> Select<TSource, TResult>(this Task<TSource[]> @this, Func<TSource, TResult> selector)
	{
		var source = await @this.ConfigureAwait(false);
		return source.Select(selector);
	}

	#endregion
}
