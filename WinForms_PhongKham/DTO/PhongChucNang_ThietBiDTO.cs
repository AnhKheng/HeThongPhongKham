using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_PhongKham.DTO
{
	public class PhongChucNang_ThietBiDTO
	{
		public int ID { get; set; }
		public int PhongChucNangID { get; set; }
		public int ThietBiID { get; set; }
		public int SoLuong { get; set; }
		public string GhiChu { get; set; }
	}
}
