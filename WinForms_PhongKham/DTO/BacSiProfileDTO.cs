using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_PhongKham.DTO
{
	public class BacSiProfileDTO
	{
		public int BacSiProfileID { get; set; }
		public int NhanVienID { get; set; }
		public string GioiThieu { get; set; }
		public string ChuyenMon { get; set; }
		public string ThanhTuu { get; set; }
		public string HinhAnh { get; set; }
		public string KinhNghiem { get; set; }
		public DateTime NgayCapNhat { get; set; }
	}
}
