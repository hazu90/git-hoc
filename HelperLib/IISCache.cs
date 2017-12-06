using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace HelperLib
{
    public class IISCache : ICache
    {
        public T Get<T>(string key)
        {
            var obj = HttpRuntime.Cache[key];
            if (obj != null)
            {
                return (T)obj;
            }
            else
            {
                return default(T);
            }
        }

        public void Set(string key, object value)
        {
            if (value != null)
            {
                HttpRuntime.Cache.Insert(key, value, null, DateTime.Now.AddDays(1), System.Web.Caching.Cache.NoSlidingExpiration);
            }
        }

        public void Set(string key, object value, DateTime expire)
        {
            if (value != null)
            {
                HttpRuntime.Cache.Insert(key, value, null, expire, System.Web.Caching.Cache.NoSlidingExpiration);
            }
        }

        public void Remove(string key)
        {
            HttpRuntime.Cache.Remove(key);
        }
    }
}
