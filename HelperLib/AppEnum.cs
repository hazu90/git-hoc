using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperLib
{
    /// <summary>
    /// Tình trạng quan hệ
    /// </summary>
    public enum RelationStatus
    {
        /// <summary>
        /// Single
        /// </summary>
        Single = 1,
        /// <summary>
        /// Married
        /// </summary>
        Marriage =2,
        /// <summary>
        /// Phức tạp
        /// </summary>
        Complicate = 3,
        /// <summary>
        /// Đang hẹn hò
        /// </summary>
        Dating =4,
        /// <summary>
        /// Đính hôn
        /// </summary>
        Engaged =5 ,
        /// <summary>
        /// Quan hệ mở
        /// </summary>
        Open = 6,
        /// <summary>
        /// Góa phụ
        /// </summary>
        Relict = 7,
        /// <summary>
        /// Li hôn
        /// </summary>
        Divorce = 8,
        /// <summary>
        /// Li thân
        /// </summary>
        Separated = 9
    }
    /// <summary>
    /// Tình trạng 
    /// </summary>
    public enum PrivateStatus { 
        /// <summary>
        /// Mọi người
        /// </summary>
        Public = 1,
        /// <summary>
        /// Bạn bè
        /// </summary>
        Friendly = 2,
        /// <summary>
        /// Bảo mật
        /// </summary>
        Private = 3
    }
}
