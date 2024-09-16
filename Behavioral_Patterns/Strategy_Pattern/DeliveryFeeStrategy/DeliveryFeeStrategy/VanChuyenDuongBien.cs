using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryFeeStrategy
{
    public class VanChuyenDuongBien : IShippingStrategy
    {
        public int ChiPhiGiaoHang()
        {
            return 30000;
        }
    }
}
