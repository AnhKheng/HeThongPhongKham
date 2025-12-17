using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_PhongKham
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private Form _currentForm;

        private void OpenChildForm(Form childForm)
        {
            if (_currentForm != null)
            {
                _currentForm.Close();
            }

            _currentForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(childForm);

            childForm.Show();
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            OpenChildForm(null);
        }
    }
}
