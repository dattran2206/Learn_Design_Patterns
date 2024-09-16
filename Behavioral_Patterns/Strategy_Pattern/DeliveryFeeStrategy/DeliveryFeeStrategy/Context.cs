using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryFeeStrategy
{
    public class Context
    {
        IShippingStrategy _shippingStrategy;

        public void SetShippingStrategy (IShippingStrategy shippingStrategy)
        {
            _shippingStrategy = shippingStrategy;
        }

        public int TinhChiPhiVanChuyen()
        {
            return _shippingStrategy.ChiPhiGiaoHang();
        }
    }
}
