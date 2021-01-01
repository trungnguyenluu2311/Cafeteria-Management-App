namespace QuanLyQuanCafe
{
	partial class frmQuanLyNhanVien
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.buttonSua = new System.Windows.Forms.Button();
			this.buttonXoa = new System.Windows.Forms.Button();
			this.buttonThemNhanVien = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Controls.Add(this.buttonSua);
			this.panel2.Controls.Add(this.buttonXoa);
			this.panel2.Controls.Add(this.buttonThemNhanVien);
			this.panel2.Controls.Add(this.dataGridView1);
			this.panel2.Controls.Add(this.textBox1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1144, 593);
			this.panel2.TabIndex = 2;
			// 
			// buttonSua
			// 
			this.buttonSua.AutoSize = true;
			this.buttonSua.BackColor = System.Drawing.Color.White;
			this.buttonSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.buttonSua.ForeColor = System.Drawing.Color.OrangeRed;
			this.buttonSua.Location = new System.Drawing.Point(898, 551);
			this.buttonSua.Name = "buttonSua";
			this.buttonSua.Size = new System.Drawing.Size(75, 30);
			this.buttonSua.TabIndex = 5;
			this.buttonSua.Text = "Sửa";
			this.buttonSua.UseVisualStyleBackColor = false;
			this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
			// 
			// buttonXoa
			// 
			this.buttonXoa.AutoSize = true;
			this.buttonXoa.BackColor = System.Drawing.Color.White;
			this.buttonXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.buttonXoa.ForeColor = System.Drawing.Color.OrangeRed;
			this.buttonXoa.Location = new System.Drawing.Point(817, 551);
			this.buttonXoa.Name = "buttonXoa";
			this.buttonXoa.Size = new System.Drawing.Size(75, 30);
			this.buttonXoa.TabIndex = 4;
			this.buttonXoa.Text = "Xóa";
			this.buttonXoa.UseVisualStyleBackColor = false;
			// 
			// buttonThemNhanVien
			// 
			this.buttonThemNhanVien.AutoSize = true;
			this.buttonThemNhanVien.BackColor = System.Drawing.Color.White;
			this.buttonThemNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.buttonThemNhanVien.ForeColor = System.Drawing.Color.OrangeRed;
			this.buttonThemNhanVien.Location = new System.Drawing.Point(979, 551);
			this.buttonThemNhanVien.Name = "buttonThemNhanVien";
			this.buttonThemNhanVien.Size = new System.Drawing.Size(153, 30);
			this.buttonThemNhanVien.TabIndex = 3;
			this.buttonThemNhanVien.Text = "Thêm nhân viên";
			this.buttonThemNhanVien.UseVisualStyleBackColor = false;
			this.buttonThemNhanVien.Click += new System.EventHandler(this.buttonThemNhanVien_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 81);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1120, 464);
			this.dataGridView1.TabIndex = 2;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 53);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(278, 22);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "<Nhập mã nhân viên hoặc tên nhân viên>";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = global::QuanLyQuanCafe.Properties.Resources.loupe;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(296, 53);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(23, 22);
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// frmQuanLyNhanVien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1144, 593);
			this.Controls.Add(this.panel2);
			this.Name = "frmQuanLyNhanVien";
			this.Text = "frmQuanLyNhanVien";
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button buttonSua;
		private System.Windows.Forms.Button buttonXoa;
		private System.Windows.Forms.Button buttonThemNhanVien;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}