
using DeliveryFeeStrategy;

Context context = new Context();

//Chi phí giao hàng đường bộ
context.SetShippingStrategy(new VanChuyenDuongBo());
Console.WriteLine("Chi phí giao hàng đường bộ {0}", context.TinhChiPhiVanChuyen());
//Chi phí giao hàng đường biển
context.SetShippingStrategy(new VanChuyenDuongBien());
Console.WriteLine("Chi phi giao hang đuong Bien {0}", context.TinhChiPhiVanChuyen());
//Chi phí giao hàng đường hàng không
context.SetShippingStrategy(new VanChuyenDuongHangKhong());
Console.WriteLine("Chi phi giao hang đuong Hang khong {0}", context.TinhChiPhiVanChuyen());