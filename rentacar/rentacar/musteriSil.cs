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
	public partial class musteriSil : Form
	{
		public musteriSil()
		{
			InitializeComponent();
		}

		void TumKayitlariListele()
		{
			OtomasyonEntities vt = new OtomasyonEntities();
			dataGridView1.DataSource = vt.musterilers.ToList();
		}

		private void btn_listele_Click(object sender, EventArgs e)
		{
			TumKayitlariListele();
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


		private void btn_sil_Click(object sender, EventArgs e)
		{
			
		}

		private void musteriSil_Load(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
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
			if (str.Cells[3].Value != null)
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

		private void btn_listele_Click_1(object sender, EventArgs e)
		{
			TumKayitlariListele();
		}

		private void btn_sil_Click_1(object sender, EventArgs e)
		{
			int secilenKisiİD = Convert.ToInt32(musteriid.Text);
			OtomasyonEntities vt = new OtomasyonEntities();
			musteriler m = vt.musterilers.FirstOrDefault(p => p.musteriId == secilenKisiİD);
			vt.musterilers.Remove(m);
			vt.SaveChanges();
			TumKayitlariListele();
			MessageBox.Show("Kayıt Başarıyla Silindi");
		}
	}
}
