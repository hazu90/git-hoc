using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcApplication1.Common
{
    public interface IDataValidator
    {
        bool Validate(string value);
    }
}
