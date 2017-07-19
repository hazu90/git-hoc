using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperLib
{
    public enum SystemStatusCode
    {
        Error = 0,
        Success = 1,
        NotValid = 2,
        DataNull = 3
    }
    /// <summary>
    /// Thời điểm hoạt động của cửa hàng
    /// </summary>
    public enum ActiveLocationTime
    {
        /// <summary>
        /// Sáng
        /// </summary>
        Morning = 1,
        /// <summary>
        /// Trưa
        /// </summary>
        Noon    = 2,
        /// <summary>
        /// Chiều
        /// </summary>
        Afternoon = 3,
        /// <summary>
        /// Tối
        /// </summary>
        Evening    = 4,
        /// <summary>
        /// Nửa đêm
        /// </summary>
        Midnight    = 5
    }
}
