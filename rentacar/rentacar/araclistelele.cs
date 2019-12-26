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
	public partial class araclistelele : Form
	{
		public araclistelele()
		{
			InitializeComponent();
		}

		void TumKayitlariListele()
		{
			OtomasyonEntities vt = new OtomasyonEntities();
			dataGridView1.DataSource = vt.araclars.ToList();
		}

		private void araclistelele_Load(object sender, EventArgs e)
		{
			TumKayitlariListele();

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
