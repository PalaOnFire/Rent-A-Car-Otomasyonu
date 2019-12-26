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
	public partial class musterilistele : Form
	{
		public musterilistele()
		{
			InitializeComponent();
		}

		private void musterilistele_Load(object sender, EventArgs e)
		{
				OtomasyonEntities vt = new OtomasyonEntities();
				dataGridView1.DataSource = vt.musterilers.ToList();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
