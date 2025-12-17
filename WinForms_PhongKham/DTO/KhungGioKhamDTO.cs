using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_PhongKham.DTO
{
	public class KhungGioKhamDTO
	{
		public int KhungGioID { get; set; }
		public TimeSpan GioBatDau { get; set; }
		public TimeSpan GioKetThuc { get; set; }
		public string TenKhung { get; set; }
		public int MaxSlot { get; set; }
	}
}
