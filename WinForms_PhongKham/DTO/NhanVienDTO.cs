using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_PhongKham.DTO
{
	public class NhanVienDTO
	{
		public int NhanVienID { get; set; }
		public int ThongTinID { get; set; }
		public int ChucVuID { get; set; }
		public decimal? Luong { get; set; }
		public DateTime? NgayVaoLam { get; set; }
		public string BangCap { get; set; }
		public string KinhNghiem { get; set; }
	}
}
