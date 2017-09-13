using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperLib
{
    public static class AppEnumDescriptionHelper
    {
        #region Trạng thái quan hệ
        private static readonly string[] RelationStatusNames = new[] { "", "Độc thân", "Đã cưới", "Phức tạp", "Đang hẹn hò", "Đã đính hôn", "Quan hệ mở", "Góa", "Ly dị", "Ly thân" };
        public static string ToRelationStatusName(this RelationStatus type)
        {
            return RelationStatusNames[type.GetHashCode()];
        }
        public static List<KeyValuePair<int, string>> ListRelationStatus()
        {
            Array arrStatus = Enum.GetValues(typeof(RelationStatus));
            return (from RelationStatus status in arrStatus select new KeyValuePair<int, string>(status.GetHashCode(), status.ToRelationStatusName())).ToList();
        }
        #endregion
        #region Trạng thái bảo mật
        private static readonly string[] PrivateStatusNames = new[] { "", "Mọi người", "Bạn bè", "Ẩn thông tin"};
        public static string ToPrivateStatusName(this PrivateStatus type)
        {
            return PrivateStatusNames[type.GetHashCode()];
        }
        public static List<KeyValuePair<int, string>> ListPrivateStatus()
        {
            Array arrItems = Enum.GetValues(typeof(PrivateStatus));
            return (from PrivateStatus item in arrItems select new KeyValuePair<int, string>(item.GetHashCode(), item.ToPrivateStatusName())).ToList();
        }
        #endregion
    }
}
