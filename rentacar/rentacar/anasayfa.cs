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
	public partial class anasayfa : Form
	{
		public anasayfa()
		{
			InitializeComponent();
		}

		public anasayfa(string rolAd)
		{
			InitializeComponent();
			menuYonetici.Visible = false;
			menuPersonel.Visible = false;
			switch(rolAd)
			{
				case "Yönetici":
					menuYonetici.Visible = true;
					break;
				case "Personel":
					menuPersonel.Visible = true;
					break;
			}
		}

		

		private void anasayfa_Load(object sender, EventArgs e)
		{

		}

		private void müşteriEkleToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			musteriekle mekle = new musteriekle();
			mekle.MdiParent = this;
			mekle.Show();
		}

		private void müşteriGüncelleToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			musteriGüncelle mGüncelle = new musteriGüncelle();
			mGüncelle.MdiParent = this;
			mGüncelle.Show();
		}

		private void müşteriSilToolStripMenuItem_Click(object sender, EventArgs e)
		{
			musteriSil mSil = new musteriSil();
			mSil.MdiParent = this;
			mSil.Show();
		}

		private void müşterilerToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void müşteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			musteriekle mekle = new musteriekle();
			mekle.MdiParent = this;
			mekle.Show();
		}

		private void müşteriSİlToolStripMenuItem_Click(object sender, EventArgs e)
		{
			musteriSil mSil = new musteriSil();
			mSil.MdiParent = this;
			mSil.Show();
		}

		private void müşteriGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			musteriGüncelle mGüncelle = new musteriGüncelle();
			mGüncelle.MdiParent = this;
			mGüncelle.Show();
		}

		private void müşteriListeleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			musterilistele ms = new musterilistele();
			ms.MdiParent = this;
			ms.Show();


		}

		private void araçEkleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			aracekle aekle = new aracekle();
			aekle.MdiParent = this;
			aekle.Show();
		}

		private void araçGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			aracguncelle aguncelle = new aracguncelle();
			aguncelle.MdiParent = this;
			aguncelle.Show();
		}

		private void araçSİlToolStripMenuItem_Click(object sender, EventArgs e)
		{
			aracsil asil = new aracsil();
			asil.MdiParent = this;
			asil.Show();
		}

		private void araçlarıListeleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			araclistelele alistele = new araclistelele();
			alistele.MdiParent = this;
			alistele.Show();
		}

		private void menuYonetici_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void çıkışToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void satışToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Satis s = new Satis();
			s.MdiParent = this;
			s.Show();
		}

		private void satışToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Satis s = new Satis();
			s.MdiParent = this;
			s.Show();
		}


		private void raporAlToolStripMenuItem_Click(object sender, EventArgs e)
		{
			raporal r = new raporal();
			r.MdiParent = this;
			r.Show();
		}

		private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ayarlar a = new ayarlar();
			a.MdiParent = this;
			a.Show();
		}

		private void müşteriListelelToolStripMenuItem_Click(object sender, EventArgs e)
		{
			musterilistele mlistele = new musterilistele();
			mlistele.MdiParent = this;
			mlistele.Show();
		}
	}
}
