using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using StackExchange.Redis;

namespace MVC.Weather.API.Cache
{
    public class RedisSharedConnection
    {
        private static Lazy<ConnectionMultiplexer> lazyConnection = new Lazy<ConnectionMultiplexer>(() =>
        {
            ConnectionMultiplexer connectionMultiplexer = ConnectionMultiplexer.Connect(ConfigurationManager.ConnectionStrings["RedisConnectionString"].ConnectionString);
            connectionMultiplexer.PreserveAsyncOrder = false;
            return connectionMultiplexer;
        });

        public static ConnectionMultiplexer Connection => lazyConnection.Value;
    }
}