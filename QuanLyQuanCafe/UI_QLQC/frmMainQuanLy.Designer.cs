namespace QuanLyQuanCafe
{
	partial class frmMainQuanLy
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonQuanLyMon = new System.Windows.Forms.Button();
            this.buttonQuanLyNguyenLieu = new System.Windows.Forms.Button();
            this.buttonQuanLyNhanVien = new System.Windows.Forms.Button();
            this.buttonBaoCao = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1667, 124);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(686, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(546, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ BÁN HÀNG QUÁN CAFE";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.buttonQuanLyMon);
            this.flowLayoutPanel1.Controls.Add(this.buttonQuanLyNguyenLieu);
            this.flowLayoutPanel1.Controls.Add(this.buttonQuanLyNhanVien);
            this.flowLayoutPanel1.Controls.Add(this.buttonBaoCao);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 124);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(292, 755);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // buttonQuanLyMon
            // 
            this.buttonQuanLyMon.BackColor = System.Drawing.Color.White;
            this.buttonQuanLyMon.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonQuanLyMon.Location = new System.Drawing.Point(3, 4);
            this.buttonQuanLyMon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonQuanLyMon.Name = "buttonQuanLyMon";
            this.buttonQuanLyMon.Size = new System.Drawing.Size(284, 116);
            this.buttonQuanLyMon.TabIndex = 5;
            this.buttonQuanLyMon.Text = "Quản lý món";
            this.buttonQuanLyMon.UseVisualStyleBackColor = false;
            this.buttonQuanLyMon.Click += new System.EventHandler(this.buttonQuanLyMon_Click);
            // 
            // buttonQuanLyNguyenLieu
            // 
            this.buttonQuanLyNguyenLieu.BackColor = System.Drawing.Color.White;
            this.buttonQuanLyNguyenLieu.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonQuanLyNguyenLieu.Location = new System.Drawing.Point(3, 128);
            this.buttonQuanLyNguyenLieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonQuanLyNguyenLieu.Name = "buttonQuanLyNguyenLieu";
            this.buttonQuanLyNguyenLieu.Size = new System.Drawing.Size(284, 116);
            this.buttonQuanLyNguyenLieu.TabIndex = 1;
            this.buttonQuanLyNguyenLieu.Text = "Quản lý nguyên liệu";
            this.buttonQuanLyNguyenLieu.UseVisualStyleBackColor = false;
            this.buttonQuanLyNguyenLieu.Click += new System.EventHandler(this.buttonQuanLyNguyenLieu_Click);
            // 
            // buttonQuanLyNhanVien
            // 
            this.buttonQuanLyNhanVien.BackColor = System.Drawing.Color.White;
            this.buttonQuanLyNhanVien.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonQuanLyNhanVien.Location = new System.Drawing.Point(3, 252);
            this.buttonQuanLyNhanVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonQuanLyNhanVien.Name = "buttonQuanLyNhanVien";
            this.buttonQuanLyNhanVien.Size = new System.Drawing.Size(284, 116);
            this.buttonQuanLyNhanVien.TabIndex = 4;
            this.buttonQuanLyNhanVien.Text = "Quản lý nhân viên";
            this.buttonQuanLyNhanVien.UseVisualStyleBackColor = false;
            this.buttonQuanLyNhanVien.Click += new System.EventHandler(this.buttonQuanLyNhanVien_Click);
            // 
            // buttonBaoCao
            // 
            this.buttonBaoCao.BackColor = System.Drawing.Color.White;
            this.buttonBaoCao.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonBaoCao.Location = new System.Drawing.Point(3, 376);
            this.buttonBaoCao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBaoCao.Name = "buttonBaoCao";
            this.buttonBaoCao.Size = new System.Drawing.Size(284, 116);
            this.buttonBaoCao.TabIndex = 3;
            this.buttonBaoCao.Text = "Báo cáo";
            this.buttonBaoCao.UseVisualStyleBackColor = false;
            this.buttonBaoCao.Click += new System.EventHandler(this.buttonBaoCao_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(292, 124);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1375, 755);
            this.panel2.TabIndex = 3;
            // 
            // frmMainQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1667, 879);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMainQuanLy";
            this.Text = "Form1";
            this.AutoSizeChanged += new System.EventHandler(this.buttonQuanLyNguyenLieu_Click);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button buttonQuanLyNguyenLieu;
		private System.Windows.Forms.Button buttonBaoCao;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button buttonQuanLyMon;
		private System.Windows.Forms.Button buttonQuanLyNhanVien;
	}
}

