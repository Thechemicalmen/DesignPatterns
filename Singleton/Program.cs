using Singletons;

var cache = MemoryCache.Instance;
var cache2 = MemoryCache.Instance;

cache.Add("test", DateTime.Now);
Console.WriteLine(cache2.Get("test"));

Console.WriteLine(object.ReferenceEquals(cache, cache2));