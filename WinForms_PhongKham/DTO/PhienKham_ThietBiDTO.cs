using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_PhongKham.DTO
{
	public class PhienKham_ThietBiDTO
	{
		public int PhienKham_ThietBiID { get; set; }
		public int PhienKhamID { get; set; }
		public int ThietBiID { get; set; }
		public int SoLuong { get; set; }
		public string GhiChu { get; set; }
	}
}
