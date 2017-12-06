using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CF.BL
{
    public class ProcessDataBL
    {
        public string ProcessData(string data)
        {
            data = data.Replace("'", "[ABCXYZ]");
            data = data.Replace("[ABCXYZ]", "''");
            return data;
        }
    }
}
