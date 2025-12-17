using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_PhongKham.DTO
{
	public class ThietBiDTO
	{
		public int ThietBiID { get; set; }
		public string TenTB { get; set; }
		public string LoaiTB { get; set; }
		public string TinhTrang { get; set; }
		public DateTime NgayNhap { get; set; }
	}
}
