using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using StackExchange.Redis;

namespace MVC.Weather.API.Cache
{
    public class RedisCacheClient
    {
        private readonly IDatabase _database;
        public RedisCacheClient()
        {
            _database = RedisSharedConnection.Connection.GetDatabase();
        }
        public T GetValue<T>(string key)
        {
            if (!_database.KeyExists(key))
                return default(T);
            var value = _database.StringGet(key);
            return JsonConvert.DeserializeObject<T>(value);

        }

        public async Task<T> GetValue<T>(string key, Func<Task<T>> getPredicate)
        {
            if (!_database.KeyExists(key))
            {
                var result = await getPredicate();
                SetValue(key, JsonConvert.SerializeObject(result));
                return result;
            }
            var value = _database.StringGet(key);
            await Task.Yield();
            return JsonConvert.DeserializeObject<T>(value);
        }

        public bool SetValue(string key, string value, int expirationInMinute = 5)
        {
            return _database.StringSet(key, value, expiry: new TimeSpan(0, 0, expirationInMinute, 0));
        }

        public bool SetValue<T>(string key, T value, int expirationInMinutes = 5)
        {
            return _database.StringSet(key, JsonConvert.SerializeObject(value),expiry: new TimeSpan(0, 0, expirationInMinutes, 0));
        }
    }
}