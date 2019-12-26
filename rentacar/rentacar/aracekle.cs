using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Drawing.Imaging;

namespace rentacar
{
	public partial class aracekle : Form
	{
		public aracekle()
		{
			InitializeComponent();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		void TumKayitlariListele()
		{
			OtomasyonEntities vt = new OtomasyonEntities();
			dataGridView1.DataSource = vt.araclars.ToList();
		}

		private void btn_Kaydet_Click(object sender, EventArgs e)
		{
			araclar a = new araclar();
			a.marka = txt_marka.Text;
			a.model = txt_model.Text;
			a.seri = txt_seri.Text;
			a.mYılı = txt_myili.Text;
			a.km = txt_km.Text;
			a.yakıt = txt_yakit.Text;
			a.vites = txt_vites.Text;
			a.kasatipi = cmbx_ktipi.SelectedText;
			a.plaka = txt_plaka.Text;
			a.aracfiyat = txt_aracfiyat.Text;
			a.klima = rb_Var.Checked ? "Var" : "Yok";

			if (pictureBox1.Image != null)
			{
				MemoryStream ms = new MemoryStream();
				pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
				a.Resim = ms.ToArray();
			}

			OtomasyonEntities vt = new OtomasyonEntities();
			vt.araclars.Add(a);
			int sonuc = vt.SaveChanges();
			if (sonuc>0)
			{
				MessageBox.Show("Kayıt Başarılı");
				TumKayitlariListele();
			}
			else
			{
				MessageBox.Show("Kayıt Başarısız");
			}

		}

		private void btn_Resim_Click(object sender, EventArgs e)
		{
			OpenFileDialog fd = new OpenFileDialog();
			fd.Filter = "Resim Dosyası|*.jpg";
			fd.ShowDialog();
			if (fd.CheckFileExists)
			{
				pictureBox1.Image = Image.FromFile(fd.FileName);
			}
		}

		private void aracekle_Load(object sender, EventArgs e)
		{
			TumKayitlariListele();
		}
	}
}
