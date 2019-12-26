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
	public partial class musteriekle : Form
	{
		public musteriekle()
		{
			InitializeComponent();
		}

		void alanlarıTemizle()
		{
			txt_Ad.Text = string.Empty;
			txt_Soyad.Text = string.Empty;
			dt_DTarihi.Value = DateTime.Now;
			pictureBox1.Image = null;
			txt_DYeri.Text = string.Empty;
			txt_gsm.Text = string.Empty;
			txt_mail.Text = string.Empty;
			txt_adres.Text = string.Empty;
		}

		void TumKayitlariListele()
		{
			OtomasyonEntities vt = new OtomasyonEntities();
			dataGridView1.DataSource = vt.musterilers.ToList();
		}

		private void btn_Kaydet_Click(object sender, EventArgs e)
		{
			musteriler m1 = new musteriler();
			m1.adı = txt_Ad.Text;
			m1.soyadı = txt_Soyad.Text;
			m1.dTarihi = dt_DTarihi.Value;
			m1.tcno = txt_TcNo.Text;
			m1.dYeri = txt_DYeri.Text;
			m1.Cinsiyet = rb_Erkek.Checked ? "Erkek" : "Kadın";
			m1.gsm = txt_gsm.Text;
			m1.mail = txt_mail.Text;
			m1.adres = txt_adres.Text;

			if (pictureBox1.Image != null)
			{
				MemoryStream ms = new MemoryStream();
				pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
				m1.resim = ms.ToArray();
			}
			OtomasyonEntities vt = new OtomasyonEntities();
			vt.musterilers.Add(m1);
			int sonuc = vt.SaveChanges();
			if (sonuc > 0)
			{
				MessageBox.Show("Eyvallah biladerim kayıt oldu ");
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

		private void musteriekle_Load(object sender, EventArgs e)
		{
			TumKayitlariListele();
		}
	}
}
