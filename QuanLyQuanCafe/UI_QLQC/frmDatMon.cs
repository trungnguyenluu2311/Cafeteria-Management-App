using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanCafe.BUS_QLQC;
using QuanLyQuanCafe.DTO_QCQC;
using Word = Microsoft.Office.Interop.Word;

namespace QuanLyQuanCafe
{
	public partial class frmDatMon : Form
	{
		long TongTien = 0;
		public DTO_NhanVien nv;
		DataTable DanhSachThucUong;
		DataTable DanhSachMonDat;
		List<DTO_ChiTietHoaDon> cthds;
		BUS_ThucUong busTU = new BUS_ThucUong();
		BUS_NhanVienPhucVu busNVPV = new BUS_NhanVienPhucVu();
		public frmDatMon()
		{
			InitializeComponent();
		}

		private void frmDatMon_Load(object sender, EventArgs e)
		{
			DanhSachThucUong = busTU.LayDanhSachThucUong();
			foreach (DataRow row in DanhSachThucUong.Rows)
			{
				ThucUong tu = new ThucUong();
				tu.MaTU = row["MATHUCUONG"].ToString();
				tu.label1.Text = row["TEN"].ToString();
				tu.label2.Text = row["GIA"].ToString();
                tu.Click += Tu_Click;
				flowLayoutPanel1.Controls.Add(tu);
			}
			label6.Text = DateTime.Now.ToShortDateString();
		}

        private void Tu_Click(object sender, EventArgs e)
        {
			ThucUong tu = (ThucUong)sender;
			UserControl1 us1 = new UserControl1();
			us1.MaTU = tu.MaTU;
			us1.label1.Text = tu.label1.Text;
			us1.label2.Text = tu.label2.Text;
            us1.numericUpDown1.ValueChanged += NumericUpDown1_ValueChanged;
			flowLayoutPanel2.Controls.Add(new UserControl1());
			UpdateTongTien();
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
			UpdateTongTien();
		}
		private void UpdateTongTien()
        {
			TongTien = 0;
			foreach (Control control in flowLayoutPanel2.Controls)
			{
				UserControl1 us1 = (UserControl1)control;
				TongTien += Convert.ToInt64(us1.label2.Text) * (int)us1.numericUpDown1.Value;
			}
			label4.Text = TongTien.ToString();
		}

        private void button1_Click(object sender, EventArgs e)
        {
			if (MessageBox.Show("Bạn có chắc đặt món?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				string DSMon = "";
				foreach (Control control in flowLayoutPanel2.Controls)
				{
					UserControl1 us1 = (UserControl1)control;
					DTO_ChiTietHoaDon cthd = new DTO_ChiTietHoaDon("", "", us1.MaTU, (int)us1.numericUpDown1.Value);
					cthds.Add(cthd);
					DSMon += String.Format("{0}x{1}\t{2}\n", us1.label1.Text, us1.numericUpDown1.Value.ToString(), (Convert.ToInt64(us1.label2.Text)* (int)us1.numericUpDown1.Value).ToString());
				}
				busNVPV.DatMon(nv, cthds);
				var words = new Dictionary<string, string>(); ;
				words.Add("<TenNV>", nv.Ten);
				words.Add("<DSMon>", DSMon);
				words.Add("<TongTien>", TongTien.ToString());
				ReplaceWord(words);
				MessageBox.Show("Đặt thành công.", "Thông báo");
				this.Close();
			}
		}
		private void ReplaceWord(Dictionary<string, string> words)
		{
			var WordApp = new Word.Application();
			WordApp.Visible = false;
			string FilePath = Application.StartupPath + @"/Mau/HoaDon.docx";
			Word.Document doc = WordApp.Documents.Open(FilePath);
			Word.Range range = doc.Content;
			foreach (KeyValuePair<string, string> word in words)
			{
				range.Find.ClearFormatting();
				range.Find.Execute(FindText: word.Key, ReplaceWith: word.Value, Replace: Word.WdReplace.wdReplaceAll);
			}
			doc.ExportAsFixedFormat(Application.StartupPath + @"/Mau/HoaDon/" + "TEST" + @"-HoaDon", Word.WdExportFormat.wdExportFormatPDF, OpenAfterExport: true);
			doc.Close(SaveChanges: Word.WdSaveOptions.wdDoNotSaveChanges);
		}
	}
}
