namespace rentacar
{
	partial class ayarlar
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.txt_kullaniciadi = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_sifre = new System.Windows.Forms.TextBox();
			this.cb_rol = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.kullaniciid = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(40, 7);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(135, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Kullanıcı İşlemleri ";
			// 
			// txt_kullaniciadi
			// 
			this.txt_kullaniciadi.Location = new System.Drawing.Point(123, 79);
			this.txt_kullaniciadi.Margin = new System.Windows.Forms.Padding(2);
			this.txt_kullaniciadi.Name = "txt_kullaniciadi";
			this.txt_kullaniciadi.Size = new System.Drawing.Size(121, 20);
			this.txt_kullaniciadi.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(9, 77);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(99, 19);
			this.label2.TabIndex = 2;
			this.label2.Text = "Kullanıcı Adı:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(9, 128);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 19);
			this.label3.TabIndex = 3;
			this.label3.Text = "Şifre:";
			// 
			// txt_sifre
			// 
			this.txt_sifre.Location = new System.Drawing.Point(123, 128);
			this.txt_sifre.Margin = new System.Windows.Forms.Padding(2);
			this.txt_sifre.Name = "txt_sifre";
			this.txt_sifre.Size = new System.Drawing.Size(121, 20);
			this.txt_sifre.TabIndex = 4;
			// 
			// cb_rol
			// 
			this.cb_rol.FormattingEnabled = true;
			this.cb_rol.Items.AddRange(new object[] {
            "Yönetici",
            "Personel"});
			this.cb_rol.Location = new System.Drawing.Point(123, 175);
			this.cb_rol.Margin = new System.Windows.Forms.Padding(2);
			this.cb_rol.Name = "cb_rol";
			this.cb_rol.Size = new System.Drawing.Size(121, 21);
			this.cb_rol.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(9, 176);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 19);
			this.label4.TabIndex = 6;
			this.label4.Text = "Rol:";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(167, 228);
			this.button2.Margin = new System.Windows.Forms.Padding(2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(60, 41);
			this.button2.TabIndex = 8;
			this.button2.Text = "Güncelle";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 228);
			this.button1.Margin = new System.Windows.Forms.Padding(2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(60, 41);
			this.button1.TabIndex = 9;
			this.button1.Text = "Ekle";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(89, 228);
			this.button3.Margin = new System.Windows.Forms.Padding(2);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(60, 41);
			this.button3.TabIndex = 10;
			this.button3.Text = "Sil";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(248, 7);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(549, 262);
			this.dataGridView1.TabIndex = 11;
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
			// 
			// kullaniciid
			// 
			this.kullaniciid.AutoSize = true;
			this.kullaniciid.Location = new System.Drawing.Point(10, 36);
			this.kullaniciid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.kullaniciid.Name = "kullaniciid";
			this.kullaniciid.Size = new System.Drawing.Size(56, 13);
			this.kullaniciid.TabIndex = 12;
			this.kullaniciid.Text = "kullaniciİD";
			this.kullaniciid.Visible = false;
			// 
			// ayarlar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(807, 284);
			this.Controls.Add(this.kullaniciid);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cb_rol);
			this.Controls.Add(this.txt_sifre);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txt_kullaniciadi);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "ayarlar";
			this.Text = "ayarlar";
			this.Load += new System.EventHandler(this.ayarlar_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_kullaniciadi;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_sifre;
		private System.Windows.Forms.ComboBox cb_rol;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label kullaniciid;
	}
}