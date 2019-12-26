using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rentacar
{
	public partial class ayarlar : Form
	{
		public ayarlar()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		void alanlarıTemizle()
		{
			txt_kullaniciadi.Text = string.Empty;
			txt_sifre.Text = string.Empty;
			cb_rol.Text = string.Empty;
		}

		void tumkayitlarilistele()
		{
			OtomasyonEntities vt = new OtomasyonEntities();
			dataGridView1.DataSource = vt.kullanicis.ToList();
		}

		private void ayarlar_Load(object sender, EventArgs e)
		{
			OtomasyonEntities vt = new OtomasyonEntities();
			dataGridView1.DataSource = vt.kullanicis.ToList();
		}

		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			alanlarıTemizle();
			DataGridViewRow str = dataGridView1.Rows[e.RowIndex];
			kullaniciid.Text = str.Cells[0].Value.ToString();
			txt_kullaniciadi.Text = str.Cells[1].Value.ToString();
			txt_sifre.Text = str.Cells[2].Value.ToString();
			cb_rol.SelectedText = str.Cells[4].Value.ToString();
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			kullanici k = new kullanici();
			k.kullaniciAd = txt_kullaniciadi.Text;
			k.rolAd =cb_rol.SelectedItem.ToString();
			k.sifre = txt_sifre.Text;
			OtomasyonEntities vt = new OtomasyonEntities();
			vt.kullanicis.Add(k);
			int sonuc = vt.SaveChanges();
			if (sonuc>0)
			{
				tumkayitlarilistele();
				MessageBox.Show("Kayıt Başarılı");
			}
			else
			{
				MessageBox.Show("Kayıt Başarısız");
			}

		}

		private void button2_Click(object sender, EventArgs e)
		{
			int secilenKullaniciİd = Convert.ToInt32(kullaniciid.Text);
			OtomasyonEntities vt = new OtomasyonEntities();
			kullanici k = vt.kullanicis.FirstOrDefault(p => p.kullaniciId == secilenKullaniciİd);
			k.kullaniciAd = txt_kullaniciadi.Text;
			k.sifre = txt_sifre.Text;
			k.rolAd = cb_rol.SelectedItem.ToString();

			vt.SaveChanges();
			tumkayitlarilistele();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			int secilenKullaniciİd = Convert.ToInt32(kullaniciid.Text);
			OtomasyonEntities vt = new OtomasyonEntities();
			kullanici k = vt.kullanicis.FirstOrDefault(p => p.kullaniciId == secilenKullaniciİd);
			vt.kullanicis.Remove(k);
			vt.SaveChanges();
			tumkayitlarilistele();
			MessageBox.Show("Kayıt Başarıyla Silindi");
		}
	}
}
