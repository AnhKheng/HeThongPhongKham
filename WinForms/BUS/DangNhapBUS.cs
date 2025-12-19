using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Common;
using DTO;
using DAO;


namespace BUS
{
	public class DangNhapBUS
	{

		public static TaiKhoanDTO DangNhap(string Email, string PasswordHash, out string ErrorRpt)
		{
			ErrorRpt = "";
			if (string.IsNullOrWhiteSpace(Email))
			{
				ErrorRpt = "Email không được để trống";
				return null;
			}

			if (!Helper.IsEmail(Email))
			{
				ErrorRpt = "Email không đúng định dạng";
				return null;
			}

			if (string.IsNullOrEmpty(PasswordHash))
			{
				ErrorRpt = "Vui lòng nhập mật khẩu!";
				return null;
			}
			string hash = PasswordHasher.Hash(PasswordHash);
			TaiKhoanDTO tk = TaiKhoanDAO.DangNhap(Email, hash);
			if (tk != null)
			{
				Session.TaiKhoan = tk;
				return tk;
			}
			else
			{
				ErrorRpt = "Tài khoản hoặc mật khẩu không đúng!";
				return null;
			}
		}
	}
}
