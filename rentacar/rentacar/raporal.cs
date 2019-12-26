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
	public partial class raporal : Form
	{
		public raporal()
		{
			InitializeComponent();
			OtomasyonEntities oto = new OtomasyonEntities();
			dataGridView1.DataSource = oto.araclars.ToList();
			dataGridView1.Columns[0].HeaderText = "Araba No";
			dataGridView1.Columns[1].HeaderText = "Marka";
			dataGridView1.Columns[2].HeaderText = "Model";
			dataGridView1.Columns[3].HeaderText = "Seri";
			dataGridView1.Columns[4].HeaderText = "Model Yılı";
			dataGridView1.Columns[5].HeaderText = "KM";
			dataGridView1.Columns[6].HeaderText = "Yakıt";
			dataGridView1.Columns[7].HeaderText = "Vites";
			dataGridView1.Columns[8].HeaderText = "Kasa Tipi";
			dataGridView1.Columns[9].HeaderText = "Klima";
			dataGridView1.Columns[10].HeaderText = "Plaka";
			dataGridView1.Columns[11].HeaderText = "Fotoğraf";
			dataGridView1.Columns[12].HeaderText = "Fiyat";
			dataGridView1.Columns[13].Visible = false;
		}

		private void copyAlltoClipboard()
		{
			//to remove the first blank column from datagridview
			dataGridView1.RowHeadersVisible = false;
			dataGridView1.SelectAll();
			DataObject dataObj = dataGridView1.GetClipboardContent();
			if (dataObj != null)
				Clipboard.SetDataObject(dataObj);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			copyAlltoClipboard();
			Microsoft.Office.Interop.Excel.Application xlexcel;
			Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
			Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
			object misValue = System.Reflection.Missing.Value;
			xlexcel = new Microsoft.Office.Interop.Excel.Application();
			xlexcel.Visible = true;
			xlWorkBook = xlexcel.Workbooks.Add(misValue);
			xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);


			for (int i = 0; i < dataGridView1.Columns.Count; i++)
			{
				xlWorkSheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
			}

			Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[2, 1];
			CR.Select();
			xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
		}
	}
}
