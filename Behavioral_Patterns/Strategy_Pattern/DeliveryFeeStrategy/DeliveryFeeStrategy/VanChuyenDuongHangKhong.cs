using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryFeeStrategy
{
    public class VanChuyenDuongHangKhong : IShippingStrategy
    {
        public int ChiPhiGiaoHang()
        {
            return 20000;
        }
    }
}
