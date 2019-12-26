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
	public partial class giris : Form
	{
		public giris()
		{
			InitializeComponent();
		}

		private void btnGiris_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtKullaniciAd.Text) || string.IsNullOrEmpty(txtKullaniciAd.Text))
			{
				MessageBox.Show("Lütfen Alanları Doldurunuz");
			}
			else
			{
				OtomasyonEntities vt = new OtomasyonEntities();
				string KullaniciAd = txtKullaniciAd.Text.Trim();
				string sifre = txtSifre.Text.Trim();
				kullanici kullanici = vt.kullanicis.FirstOrDefault
					(p => p.kullaniciAd == KullaniciAd && p.sifre == sifre);
				if (kullanici == null)
				{
					MessageBox.Show("Böyle bir kullanıcı yok");	
				}
				else
				{
					anasayfa a = new anasayfa(kullanici.roller.rolAd.Trim());
					a.Show();
					this.Hide();
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
