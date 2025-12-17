using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_PhongKham.DTO
{
	public class BuoiDieuTri_CanLamSangDTO
	{
		public int ID { get; set; }
		public int BuoiDieuTriID { get; set; }
		public int CanLamSangID { get; set; }
		public string KetQua { get; set; }
		public string TrangThai { get; set; }
	}
}
