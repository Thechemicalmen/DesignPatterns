namespace Singletons
{
    public sealed class MemoryCache
    {
        private readonly Dictionary<string, object> _cachedObjects;
        private static readonly Lazy<MemoryCache> _cache = new(() => new());
        public static MemoryCache Instance => _cache.Value;

        private MemoryCache()
        {
            _cachedObjects = [];
        }

        public void Add(string key, object value) => _cachedObjects[key] = value;

        public object? Get(string key)
        {
            if(_cachedObjects.TryGetValue(key, out object? value))
                return value;
            return null;
        }
    }
}