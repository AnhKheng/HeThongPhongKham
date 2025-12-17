using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_PhongKham.DTO
{
	public class PhongChucNangDTO
	{
		public int PhongChucNangID { get; set; }
		public string TenPhong { get; set; }
		public string LoaiPhong { get; set; }
		public string MoTa { get; set; }
		public string TrangThai { get; set; }
		public DateTime NgayNhap { get; set; }
	}
}
