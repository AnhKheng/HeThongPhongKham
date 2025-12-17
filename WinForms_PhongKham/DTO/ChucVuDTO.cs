using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_PhongKham.DTO
{
	public class ChucVuDTO
	{
		public int ChucVuID { get; set; }
		public string TenChucVu { get; set; }
		public string MoTa { get; set; }
		public DateTime NgayTao { get; set; }
		public bool TrangThai { get; set; }
	}
}
