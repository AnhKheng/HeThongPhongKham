using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
	public partial class FrmTaiKhoan : Form
	{
		public FrmTaiKhoan()
		{
			InitializeComponent();
		}
		private void LoadData()
		{
			DataTable dt = TaiKhoanBUS.LayDanhSachTaiKhoan();
			dgvDSTaiKhoan.DataSource = dt;

			dgvDSTaiKhoan.Columns["TaiKhoanID"].HeaderText = "Mã Tài Khoản";
			dgvDSTaiKhoan.Columns["Email"].HeaderText = "Email";
			dgvDSTaiKhoan.Columns["Role"].HeaderText = "Quyền";
			dgvDSTaiKhoan.Columns["Status"].HeaderText = "Trạng Thái";
			dgvDSTaiKhoan.Columns["NgayTao"].HeaderText = "Ngày Tạo";

			dgvDSTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvDSTaiKhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvDSTaiKhoan.ReadOnly = true;
		}
		private void FrmTaiKhoan_Load(object sender, EventArgs e)
		{
			LoadData();
		}
	}
}
