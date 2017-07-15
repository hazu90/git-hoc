using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackExchange.Redis;

namespace MvcApplication1.Tests
{
    [TestClass]
    public class RedisCacheTest
    {
        [TestMethod]
        public void RedisConnection_BasicUsage()
        {
            // Chuỗi kết nối đến Redis
            var redis = ConnectionMultiplexer.Connect("127.0.0.1:6379");
            //Kết nối đến db của Redis
            IDatabase db = redis.GetDatabase();
        }
    }
}
