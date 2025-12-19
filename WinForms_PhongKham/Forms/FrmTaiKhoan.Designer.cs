namespace WinForms_PhongKham.Forms
{
	partial class FrmTaiKhoan
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pnlHeader = new System.Windows.Forms.Panel();
			this.lblTitle = new System.Windows.Forms.Label();
			this.pnlContent = new System.Windows.Forms.Panel();
			this.tabCtrlQuanLiTaiKhoan = new System.Windows.Forms.TabControl();
			this.tpDSTaiKhoan = new System.Windows.Forms.TabPage();
			this.dgvDSTaiKhoan = new System.Windows.Forms.DataGridView();
			this.pnlAction = new System.Windows.Forms.Panel();
			this.tpThemTaiKhoan = new System.Windows.Forms.TabPage();
			this.pnlHeader.SuspendLayout();
			this.pnlContent.SuspendLayout();
			this.tabCtrlQuanLiTaiKhoan.SuspendLayout();
			this.tpDSTaiKhoan.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDSTaiKhoan)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlHeader
			// 
			this.pnlHeader.Controls.Add(this.lblTitle);
			this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlHeader.Location = new System.Drawing.Point(0, 0);
			this.pnlHeader.Name = "pnlHeader";
			this.pnlHeader.Size = new System.Drawing.Size(1300, 44);
			this.pnlHeader.TabIndex = 0;
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
			this.lblTitle.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(0, 0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(238, 37);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Quản lí tài khoản";
			// 
			// pnlContent
			// 
			this.pnlContent.Controls.Add(this.tabCtrlQuanLiTaiKhoan);
			this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlContent.Location = new System.Drawing.Point(0, 44);
			this.pnlContent.Name = "pnlContent";
			this.pnlContent.Size = new System.Drawing.Size(1300, 756);
			this.pnlContent.TabIndex = 1;
			// 
			// tabCtrlQuanLiTaiKhoan
			// 
			this.tabCtrlQuanLiTaiKhoan.Controls.Add(this.tpDSTaiKhoan);
			this.tabCtrlQuanLiTaiKhoan.Controls.Add(this.tpThemTaiKhoan);
			this.tabCtrlQuanLiTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabCtrlQuanLiTaiKhoan.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabCtrlQuanLiTaiKhoan.Location = new System.Drawing.Point(0, 0);
			this.tabCtrlQuanLiTaiKhoan.Name = "tabCtrlQuanLiTaiKhoan";
			this.tabCtrlQuanLiTaiKhoan.SelectedIndex = 0;
			this.tabCtrlQuanLiTaiKhoan.Size = new System.Drawing.Size(1300, 756);
			this.tabCtrlQuanLiTaiKhoan.TabIndex = 0;
			// 
			// tpDSTaiKhoan
			// 
			this.tpDSTaiKhoan.Controls.Add(this.dgvDSTaiKhoan);
			this.tpDSTaiKhoan.Controls.Add(this.pnlAction);
			this.tpDSTaiKhoan.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tpDSTaiKhoan.Location = new System.Drawing.Point(4, 35);
			this.tpDSTaiKhoan.Name = "tpDSTaiKhoan";
			this.tpDSTaiKhoan.Padding = new System.Windows.Forms.Padding(3);
			this.tpDSTaiKhoan.Size = new System.Drawing.Size(1292, 717);
			this.tpDSTaiKhoan.TabIndex = 0;
			this.tpDSTaiKhoan.Text = "Danh Sách Tài Khoản";
			this.tpDSTaiKhoan.UseVisualStyleBackColor = true;
			// 
			// dgvDSTaiKhoan
			// 
			this.dgvDSTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDSTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvDSTaiKhoan.Location = new System.Drawing.Point(3, 66);
			this.dgvDSTaiKhoan.Name = "dgvDSTaiKhoan";
			this.dgvDSTaiKhoan.Size = new System.Drawing.Size(1286, 648);
			this.dgvDSTaiKhoan.TabIndex = 2;
			// 
			// pnlAction
			// 
			this.pnlAction.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlAction.Location = new System.Drawing.Point(3, 3);
			this.pnlAction.Name = "pnlAction";
			this.pnlAction.Size = new System.Drawing.Size(1286, 63);
			this.pnlAction.TabIndex = 1;
			// 
			// tpThemTaiKhoan
			// 
			this.tpThemTaiKhoan.Location = new System.Drawing.Point(4, 35);
			this.tpThemTaiKhoan.Name = "tpThemTaiKhoan";
			this.tpThemTaiKhoan.Padding = new System.Windows.Forms.Padding(3);
			this.tpThemTaiKhoan.Size = new System.Drawing.Size(1292, 717);
			this.tpThemTaiKhoan.TabIndex = 1;
			this.tpThemTaiKhoan.Text = "Thêm Tài Khoản";
			this.tpThemTaiKhoan.UseVisualStyleBackColor = true;
			// 
			// FrmTaiKhoan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1300, 800);
			this.Controls.Add(this.pnlContent);
			this.Controls.Add(this.pnlHeader);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmTaiKhoan";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "FrmTaiKhoan";
			this.Load += new System.EventHandler(this.FrmTaiKhoan_Load);
			this.pnlHeader.ResumeLayout(false);
			this.pnlHeader.PerformLayout();
			this.pnlContent.ResumeLayout(false);
			this.tabCtrlQuanLiTaiKhoan.ResumeLayout(false);
			this.tpDSTaiKhoan.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvDSTaiKhoan)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlHeader;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Panel pnlContent;
		private System.Windows.Forms.TabControl tabCtrlQuanLiTaiKhoan;
		private System.Windows.Forms.TabPage tpDSTaiKhoan;
		private System.Windows.Forms.TabPage tpThemTaiKhoan;
		private System.Windows.Forms.DataGridView dgvDSTaiKhoan;
		private System.Windows.Forms.Panel pnlAction;
	}
}