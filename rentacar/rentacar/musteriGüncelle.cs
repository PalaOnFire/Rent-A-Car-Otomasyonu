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
using System.Drawing.Imaging;

namespace rentacar
{
	public partial class musteriGüncelle : Form
	{
		public musteriGüncelle()
		{
			InitializeComponent();
		}

		void alanlarıTemizle()
		{
			musteriid.Text = string.Empty;
			txt_TcNo.Text = string.Empty;
			txt_Ad.Text = string.Empty;
			txt_Soyad.Text = string.Empty;
			txt_DYeri.Text = string.Empty;
			dt_DTarihi.Value = DateTime.Now;
			pictureBox1.Image = null;
		}


		void TumKayitlariListele()
		{
			OtomasyonEntities vt = new OtomasyonEntities();
			dataGridView1.DataSource = vt.musterilers.ToList();
		}

		private void btn_anaSayfa_Click(object sender, EventArgs e)
		{
			anasayfa a = new anasayfa();
			a.Show();
			this.Hide();

		}

		private void btn_listele_Click(object sender, EventArgs e)
		{
			TumKayitlariListele();
		}

		private void btn_güncelle_Click(object sender, EventArgs e)
		{
			int secilenKisiid = Convert.ToInt32(musteriid.Text);
			OtomasyonEntities vt = new OtomasyonEntities();
			musteriler m = vt.musterilers.FirstOrDefault(p => p.musteriId == secilenKisiid);
			m.tcno = txt_TcNo.Text;
			m.adı = txt_Ad.Text;
			m.soyadı = txt_Soyad.Text;
			m.dYeri = txt_DYeri.Text;
			m.dTarihi = dt_DTarihi.Value;
			m.gsm = txt_gsm.Text;
			m.adres = txt_adres.Text;
			m.Cinsiyet = rb_Erkek.Checked ? "Erkek" : "Kadın";

			if (pictureBox1.Image != null)
			{
				MemoryStream ms = new MemoryStream();
				pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
				m.resim = ms.ToArray();
			}

			vt.SaveChanges();
			TumKayitlariListele();
		}

		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			alanlarıTemizle();
			DataGridViewRow str = dataGridView1.Rows[e.RowIndex];
			musteriid.Text = str.Cells[0].Value.ToString();
			txt_TcNo.Text = str.Cells[10].Value.ToString();
			txt_Ad.Text = str.Cells[1].Value.ToString();
			txt_Soyad.Text = str.Cells[2].Value.ToString();
			txt_DYeri.Text = str.Cells[7].Value.ToString();
			txt_gsm.Text = str.Cells[4].Value.ToString();
			txt_mail.Text = str.Cells[5].Value.ToString();
			txt_adres.Text = str.Cells[6].Value.ToString();
			if (str.Cells[3].Value !=null)
			{
				dt_DTarihi.Value = (DateTime)str.Cells[3].Value;
			}
			if (str.Cells[8].Value.ToString() == "Erkek")
			{
				rb_Erkek.Checked = true;
			}
			else
			{
				rb_Kadin.Checked = true;
			}

			byte[] rsmbyt = (byte[])str.Cells[9].Value;
			if (rsmbyt != null)
			{
				MemoryStream ms = new MemoryStream(rsmbyt);
				pictureBox1.Image = Image.FromStream(ms);
			}
			
			
		}
	}
}
