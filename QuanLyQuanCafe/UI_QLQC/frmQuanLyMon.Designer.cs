namespace QuanLyQuanCafe
{
	partial class frmQuanLyMon
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.buttonThemMon = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 100);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1120, 445);
			this.dataGridView1.TabIndex = 0;
			// 
			// buttonThemMon
			// 
			this.buttonThemMon.AutoSize = true;
			this.buttonThemMon.BackColor = System.Drawing.Color.White;
			this.buttonThemMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.buttonThemMon.ForeColor = System.Drawing.Color.OrangeRed;
			this.buttonThemMon.Location = new System.Drawing.Point(1019, 551);
			this.buttonThemMon.Name = "buttonThemMon";
			this.buttonThemMon.Size = new System.Drawing.Size(113, 30);
			this.buttonThemMon.TabIndex = 1;
			this.buttonThemMon.Text = "Thêm món";
			this.buttonThemMon.UseVisualStyleBackColor = false;
			this.buttonThemMon.Click += new System.EventHandler(this.buttonThemMon_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 72);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(253, 22);
			this.textBox1.TabIndex = 2;
			this.textBox1.Text = "<Nhập tên món>";
			// 
			// button2
			// 
			this.button2.AutoSize = true;
			this.button2.BackColor = System.Drawing.Color.White;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.button2.ForeColor = System.Drawing.Color.OrangeRed;
			this.button2.Location = new System.Drawing.Point(811, 551);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(98, 30);
			this.button2.TabIndex = 4;
			this.button2.Text = "Xóa";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.AutoSize = true;
			this.button3.BackColor = System.Drawing.Color.White;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.button3.ForeColor = System.Drawing.Color.OrangeRed;
			this.button3.Location = new System.Drawing.Point(915, 551);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(98, 30);
			this.button3.TabIndex = 5;
			this.button3.Text = "Sửa";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = global::QuanLyQuanCafe.Properties.Resources.loupe;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(271, 72);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(26, 22);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// frmQuanLyMon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1144, 593);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.buttonThemMon);
			this.Controls.Add(this.dataGridView1);
			this.Name = "frmQuanLyMon";
			this.Text = "frmQuanLyMon";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button buttonThemMon;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
	}
}