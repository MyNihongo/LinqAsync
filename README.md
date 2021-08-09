[![Version](https://img.shields.io/nuget/v/MyNihongo.LinqAsync?style=plastic)](https://www.nuget.org/packages/MyNihongo.LinqAsync/)
[![NuGet downloads](https://img.shields.io/nuget/dt/MyNihongo.LinqAsync?label=nuget%20downloads&logo=nuget&style=plastic)](https://www.nuget.org/packages/MyNihongo.LinqAsync/)  
LINQ extension methods for `Task<IEnumerable<T>>` and `ValueTask<IEnumerable<T>>`.
```cs
var enumerableTask = Task.FromResult(new [] { 1, 2, 3, 4, 5});

var newEnumerable = await enumerableTask
	.Select(x => x * 2)
	.ToImmutableArrayAsync();
```
Available extensions:
- ToArrayAsync(), ToImmutableArrayAsync()
- ToListAsync(), ToImmutableListAsync()
- ToLookupAsync()
- ToHashSetAsync(), ToImmutableHashSetAsync()
- ToDictionaryAsync()
- Select(), SelectMany()