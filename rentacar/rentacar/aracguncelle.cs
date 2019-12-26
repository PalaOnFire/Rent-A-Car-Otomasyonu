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
	public partial class aracguncelle : Form
	{
		public aracguncelle()
		{
			InitializeComponent();
		}

		void alanlarıTemizle()
		{
			aracid.Text = string.Empty;
			txt_marka.Text = string.Empty;
			txt_km.Text = string.Empty;
			txt_model.Text = string.Empty;
			txt_myili.Text = string.Empty;
			txt_plaka.Text = string.Empty;
			txt_seri.Text = string.Empty;
			txt_vites.Text = string.Empty;
			txt_yakit.Text = string.Empty;
			
			pictureBox1.Image = null;
		}

		void TumKayitlariListele()
		{
			OtomasyonEntities vt = new OtomasyonEntities();
			dataGridView1.DataSource = vt.araclars.ToList();
		}

		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			alanlarıTemizle();
			DataGridViewRow str = dataGridView1.Rows[e.RowIndex];
			aracid.Text = str.Cells[0].Value.ToString();
			txt_marka.Text = str.Cells[1].Value.ToString();
			txt_model.Text = str.Cells[2].Value.ToString();
			txt_myili.Text = str.Cells[4].Value.ToString();
			txt_plaka.Text = str.Cells[10].Value.ToString();
			txt_seri.Text = str.Cells[3].Value.ToString();
			txt_vites.Text = str.Cells[7].Value.ToString();
			txt_yakit.Text = str.Cells[6].Value.ToString();
			txt_km.Text = str.Cells[5].Value.ToString();
			cmbx_ktipi.SelectedText = str.Cells[8].Value.ToString();
			if (str.Cells[9].Value.ToString() == "Var")
			{
				rb_Var.Checked = true;
			}
			else
			{
				rb_Yok.Checked = true;
			}

			byte[] rsmbyt = (byte[])str.Cells[11].Value;
			if (rsmbyt != null)
			{
				MemoryStream ms = new MemoryStream();
				pictureBox1.Image = Image.FromStream(ms);
			}



		}

		private void btn_güncelle_Click(object sender, EventArgs e)
		{
			int secilenAracid = Convert.ToInt32(aracid.Text);
			OtomasyonEntities vt = new OtomasyonEntities();
			araclar a = vt.araclars.FirstOrDefault(p => p.aracId == secilenAracid);
			a.marka = txt_marka.Text;
			a.model = txt_model.Text;
			a.seri = txt_seri.Text;
			a.mYılı = txt_myili.Text;
			a.km = txt_km.Text;
			a.yakıt = txt_yakit.Text;
			a.vites = txt_vites.Text;
			a.kasatipi = cmbx_ktipi.SelectedText;
			a.plaka = txt_plaka.Text;
			a.klima = rb_Var.Checked ? "Var" : "Yok";

			if (pictureBox1.Image != null)
			{
				MemoryStream ms = new MemoryStream();
				pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
				a.Resim = ms.ToArray();
			}

			vt.SaveChanges();
			TumKayitlariListele();
		}


		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void aracguncelle_Load(object sender, EventArgs e)
		{
			TumKayitlariListele();
		}
	}
}
