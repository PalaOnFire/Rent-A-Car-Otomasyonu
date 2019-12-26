using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace rentacar
{
	public partial class Satis : Form
	{
		public Satis()
		{
			InitializeComponent();
		}

		void alanlarıTemizle()
		{
			txt_adi.Text = string.Empty;
			txt_marka.Text = string.Empty;
			txt_model.Text = string.Empty;
			txt_plaka.Text = string.Empty;
			txt_soyadi.Text = string.Empty;
			txt_tcno.Text = string.Empty;
			txt_telno.Text = string.Empty;
			txt_yil.Text = string.Empty;

		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{

		}

		private void Satis_Load(object sender, EventArgs e)
		{
			OtomasyonEntities vt = new OtomasyonEntities();
			musteriler.DataSource = vt.musterilers.ToList();
			araclar.DataSource = vt.araclars.ToList();
		}

		private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			
		}

		private void musteriler_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void araclar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow str = araclar.Rows[e.RowIndex];
			aracid.Text = str.Cells[0].Value.ToString();
			txt_marka.Text = str.Cells[1].Value.ToString();
			txt_model.Text = str.Cells[2].Value.ToString();
			txt_yil.Text = str.Cells[4].Value.ToString();
			txt_plaka.Text = str.Cells[10].Value.ToString();
			lbl_fiyat.Text = str.Cells[12].Value.ToString();

		}

		private void musteriler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow str = musteriler.Rows[e.RowIndex];
			musteriİD.Text = str.Cells[0].Value.ToString();
			txt_adi.Text = str.Cells[1].Value.ToString();
			txt_soyadi.Text = str.Cells[2].Value.ToString();
			txt_telno.Text = str.Cells[4].Value.ToString();
			txt_tcno.Text = str.Cells[10].Value.ToString();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			sati s = new sati();
			s.tutar = txt_tutar.Text;
			s.musteriId = Convert.ToInt32(musteriİD.Text);
			s.aracId = Convert.ToInt32(aracid.Text);

			OtomasyonEntities vt = new OtomasyonEntities();
			vt.satis.Add(s);
			int sonuc = vt.SaveChanges();
			if (sonuc>0)
			{
				MessageBox.Show("Kayıt Başarılı");
			}
			else
			{
				MessageBox.Show("Kayıt Başarısız");
			}

			
	

		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
		{
			DateTime baslamaTarihi = Convert.ToDateTime(dateTimePicker1.Text);
			DateTime bitisTarihi = Convert.ToDateTime(dateTimePicker2.Text);
			TimeSpan sonuc = bitisTarihi - baslamaTarihi;

			int fiyat = sonuc.Days * Convert.ToInt32(lbl_fiyat.Text);

			txt_tutar.Text = (fiyat.ToString() + "TL");
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			OtomasyonEntities vt = new OtomasyonEntities();
			var liste = from s in vt.araclars where s.plaka == txt_plaka.Text select s;
			araclar.DataSource = liste.ToList();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			OtomasyonEntities vt = new OtomasyonEntities();
			var liste = from s in vt.musterilers where s.tcno == txt_tcno.Text select s;
			musteriler.DataSource = liste.ToList();
		}
	}
}
