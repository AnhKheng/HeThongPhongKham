using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_PhongKham.DTO
{
	public class ToaThuocDTO
	{
		public int ToaThuocID { get; set; }
		public int PhienKhamID { get; set; }
		public int NhanVienKeDonID { get; set; }
		public DateTime NgayLap { get; set; }
		public decimal? TongTien { get; set; }
		public string TrangThai { get; set; }
		public string GhiChu { get; set; }
	}
}
