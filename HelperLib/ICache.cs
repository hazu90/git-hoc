using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperLib
{
    public interface ICache
    {
        T Get<T>(string key);
        void Set(string key, object value);
        void Set(string key, object value, DateTime expire);
        void Remove(string key);
    }
}
