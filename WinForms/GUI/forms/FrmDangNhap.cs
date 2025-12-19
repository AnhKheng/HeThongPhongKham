using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using BUS;
using DTO;

namespace GUI
{
	public partial class FrmDangNhap : Form
	{
		public FrmDangNhap()
		{
			InitializeComponent();
		}

		[DllImport("user32.dll")]
		private static extern bool ReleaseCapture();

		[DllImport("user32.dll")]
		private static extern int SendMessage(
			IntPtr hWnd, int Msg, int wParam, int lParam);

		private const int WM_NCLBUTTONDOWN = 0xA1;
		private const int HTCAPTION = 0x2;




		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
			}
		}

		private void chkHienMK_CheckedChanged(object sender, EventArgs e)
		{
			txtMatKhau.UseSystemPasswordChar = !chkHienMK.Checked;
		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			lblErrorRpt.Text = "";
			string email = txtUsername.Text.Trim();
			string password = txtMatKhau.Text;
			string errorRpt;
			TaiKhoanDTO tk = DangNhapBUS.DangNhap(email, password,out errorRpt);
			if (tk != null)
			{
				FrmMain frmMain = new FrmMain(tk);
				frmMain.Show();
				this.Hide();
			}
			else
			{
				lblErrorRpt.Text = errorRpt;
			}
		}

		private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				btnSubmit.PerformClick();
			}
		}
	}
}
