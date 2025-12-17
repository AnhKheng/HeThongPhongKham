using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_PhongKham.DTO
{
	public class HoSoBenhAnDTO
	{
		public int HoSoBenhAnID { get; set; }
		public int BenhNhanID { get; set; }
		public string BenhNen { get; set; }
		public string DiUng { get; set; }
		public string TienSuBenh { get; set; }
		public string TienSuGiaDinh { get; set; }
		public string ThoiQuenSong { get; set; }
		public string ThongTinKhac { get; set; }
		public DateTime NgayTao { get; set; }
		public DateTime NgayCapNhat { get; set; }
	}
}
