using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_PhongKham.DTO
{
	public class NgayNghiNhanVienDTO
	{
		public int NgayNghiID { get; set; }
		public int NhanVienID { get; set; }
		public DateTime Ngay { get; set; }
		public string LyDo { get; set; }
	}
}
