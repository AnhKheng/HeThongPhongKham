using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_PhongKham.DTO
{
	public class CaKhamDTO
	{
		public int CaKhamID { get; set; }
		public int LichLamViecID { get; set; }
		public int? PhongChucNangID { get; set; }
		public DateTime NgayKham { get; set; }
		public int KhungGioID { get; set; }
		public int? BenhNhanID { get; set; }
		public string LyDoKham { get; set; }
		public string TrangThai { get; set; }
		public DateTime NgayDat { get; set; }
		public string GhiChu { get; set; }
	}
}
