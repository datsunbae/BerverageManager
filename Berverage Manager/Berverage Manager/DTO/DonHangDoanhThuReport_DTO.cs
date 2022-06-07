using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berverage_Manager.DTO
{
    internal class DonHangDoanhThuReport_DTO
    {
        public int MAHD { get; set; }
        public DateTime NgayLap { get; set; }
        public string TenNhanVien { get; set; }
        public string TenKhachHang { get; set; }
        public double TongTien { get; set; }
    }
}
