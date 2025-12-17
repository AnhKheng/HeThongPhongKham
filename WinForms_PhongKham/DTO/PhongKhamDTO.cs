using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_PhongKham.DTO
{
	public class PhongKhamDTO
	{
		public int PhongKhamID { get; set; }
		public string TenPhongKham { get; set; }
		public string GioiThieu { get; set; }
		public string DiaChi { get; set; }
		public string Hotline { get; set; }
		public string Email { get; set; }
		public string Website { get; set; }
		public string GioMoCua { get; set; }
		public string HinhAnhBanner { get; set; }
		public DateTime NgayCapNhat { get; set; }
	}
}
