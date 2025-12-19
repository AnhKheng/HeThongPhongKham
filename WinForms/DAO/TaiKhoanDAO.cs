using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
	public class TaiKhoanDAO
	{
		public static TaiKhoanDTO DangNhap(string Email, string PasswordHash)
		{
			string sql = @"
				SELECT *
				FROM TaiKhoan
				WHERE Email = @Email AND PasswordHash = @PasswordHash AND Status = 'Active' AND Role IN ('Admin', 'employee')
			";
			SqlParameter[] parameters = {
				new SqlParameter("@Email", Email),
				new SqlParameter("@PasswordHash", PasswordHash)
			};
			DataTable dt = DataProvider.TruyVanDuLieu(sql, parameters);
			if (dt.Rows.Count > 0)
			{
				TaiKhoanDTO taiKhoan = new TaiKhoanDTO();
				taiKhoan.TaiKhoanID = Convert.ToInt32(dt.Rows[0]["TaiKhoanID"]);
				taiKhoan.Email = dt.Rows[0]["Email"].ToString();
				taiKhoan.PasswordHash = dt.Rows[0]["PasswordHash"].ToString();
				taiKhoan.Role = dt.Rows[0]["Role"].ToString();
				taiKhoan.Status = dt.Rows[0]["Status"].ToString();
				return taiKhoan;
			}
			else
			{
				return null;
			}
		}
		public static bool CheckEmailExists(string email)
		{ 
			string sql = @"
				SELECT COUNT(*) 
				FROM TaiKhoan 
				WHERE Email = @Email";
			SqlParameter[] parameters = { 
				new SqlParameter("@Email", email) 
			};
			int soLuong = (int)DataProvider.TruyVanDon(sql, parameters);
			if (soLuong > 0)
				return true;
			else
				return false;
		}
		public DataTable LayDanhSachTaiKhoan()
		{
			string sql = @"
				SELECT TaiKhoanID, Email, Role, Status, NgayTao
				FROM TaiKhoan
			";
			DataTable dt = DataProvider.TruyVanDuLieu(sql);
			return dt;
		}
	}
}
