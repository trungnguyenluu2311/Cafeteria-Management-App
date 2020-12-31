namespace QuanLyQuanCafe
{
	partial class frmMain
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
			this.buttonQuanLyNguyenLieu = new System.Windows.Forms.Button();
			this.buttonDatMon = new System.Windows.Forms.Button();
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
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1482, 100);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.ForeColor = System.Drawing.Color.OrangeRed;
			this.label1.Location = new System.Drawing.Point(610, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(461, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "QUẢN LÝ BÁN HÀNG QUÁN CAFE";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
			this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.flowLayoutPanel1.Controls.Add(this.buttonQuanLyNguyenLieu);
			this.flowLayoutPanel1.Controls.Add(this.buttonDatMon);
			this.flowLayoutPanel1.Controls.Add(this.buttonBaoCao);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 100);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(260, 603);
			this.flowLayoutPanel1.TabIndex = 2;
			// 
			// buttonQuanLyNguyenLieu
			// 
			this.buttonQuanLyNguyenLieu.BackColor = System.Drawing.Color.White;
			this.buttonQuanLyNguyenLieu.ForeColor = System.Drawing.Color.OrangeRed;
			this.buttonQuanLyNguyenLieu.Location = new System.Drawing.Point(3, 3);
			this.buttonQuanLyNguyenLieu.Name = "buttonQuanLyNguyenLieu";
			this.buttonQuanLyNguyenLieu.Size = new System.Drawing.Size(252, 93);
			this.buttonQuanLyNguyenLieu.TabIndex = 1;
			this.buttonQuanLyNguyenLieu.Text = "Quản lý nguyên liệu";
			this.buttonQuanLyNguyenLieu.UseVisualStyleBackColor = false;
			this.buttonQuanLyNguyenLieu.Click += new System.EventHandler(this.buttonQuanLyNguyenLieu_Click);
			// 
			// buttonDatMon
			// 
			this.buttonDatMon.BackColor = System.Drawing.Color.White;
			this.buttonDatMon.ForeColor = System.Drawing.Color.OrangeRed;
			this.buttonDatMon.Location = new System.Drawing.Point(3, 102);
			this.buttonDatMon.Name = "buttonDatMon";
			this.buttonDatMon.Size = new System.Drawing.Size(252, 93);
			this.buttonDatMon.TabIndex = 2;
			this.buttonDatMon.Text = "Đặt món";
			this.buttonDatMon.UseVisualStyleBackColor = false;
			this.buttonDatMon.Click += new System.EventHandler(this.buttonDatMon_Click);
			// 
			// buttonBaoCao
			// 
			this.buttonBaoCao.BackColor = System.Drawing.Color.White;
			this.buttonBaoCao.ForeColor = System.Drawing.Color.OrangeRed;
			this.buttonBaoCao.Location = new System.Drawing.Point(3, 201);
			this.buttonBaoCao.Name = "buttonBaoCao";
			this.buttonBaoCao.Size = new System.Drawing.Size(252, 93);
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
			this.panel2.Location = new System.Drawing.Point(260, 100);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1222, 603);
			this.panel2.TabIndex = 3;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1482, 703);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.panel1);
			this.Name = "frmMain";
			this.Text = "Form1";
			this.AutoSizeChanged += new System.EventHandler(this.buttonQuanLyNguyenLieu_Click);
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
		private System.Windows.Forms.Button buttonDatMon;
		private System.Windows.Forms.Button buttonBaoCao;
		private System.Windows.Forms.Panel panel2;
	}
}

