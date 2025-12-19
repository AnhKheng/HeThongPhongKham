using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
	public class TaiKhoanBUS
	{
		private static TaiKhoanDAO tk = new TaiKhoanDAO();
		public static DataTable LayDanhSachTaiKhoan()
		{
			return tk.LayDanhSachTaiKhoan();
		}
	}
}
