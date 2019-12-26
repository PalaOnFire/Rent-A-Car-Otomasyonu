namespace rentacar
{
	partial class aracekle
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
			this.txt_vites = new System.Windows.Forms.TextBox();
			this.lbl_vites = new System.Windows.Forms.Label();
			this.txt_yakit = new System.Windows.Forms.TextBox();
			this.lbl_yakit = new System.Windows.Forms.Label();
			this.txt_myili = new System.Windows.Forms.TextBox();
			this.lbl_myili = new System.Windows.Forms.Label();
			this.btn_Kaydet = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btn_Resim = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.rb_Yok = new System.Windows.Forms.RadioButton();
			this.rb_Var = new System.Windows.Forms.RadioButton();
			this.txt_marka = new System.Windows.Forms.TextBox();
			this.txt_model = new System.Windows.Forms.TextBox();
			this.txt_seri = new System.Windows.Forms.TextBox();
			this.txt_km = new System.Windows.Forms.TextBox();
			this.lbl_Cinsiyet = new System.Windows.Forms.Label();
			this.lbl_kTipi = new System.Windows.Forms.Label();
			this.lbl_km = new System.Windows.Forms.Label();
			this.lbl_seri = new System.Windows.Forms.Label();
			this.lbl_model = new System.Windows.Forms.Label();
			this.lbl_marka = new System.Windows.Forms.Label();
			this.txt_plaka = new System.Windows.Forms.TextBox();
			this.lbl_plaka = new System.Windows.Forms.Label();
			this.cmbx_ktipi = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_aracfiyat = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// txt_vites
			// 
			this.txt_vites.Location = new System.Drawing.Point(477, 104);
			this.txt_vites.Name = "txt_vites";
			this.txt_vites.Size = new System.Drawing.Size(249, 27);
			this.txt_vites.TabIndex = 48;
			// 
			// lbl_vites
			// 
			this.lbl_vites.AutoSize = true;
			this.lbl_vites.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lbl_vites.Location = new System.Drawing.Point(355, 111);
			this.lbl_vites.Name = "lbl_vites";
			this.lbl_vites.Size = new System.Drawing.Size(46, 19);
			this.lbl_vites.TabIndex = 47;
			this.lbl_vites.Text = "Vites";
			// 
			// txt_yakit
			// 
			this.txt_yakit.Location = new System.Drawing.Point(477, 59);
			this.txt_yakit.Name = "txt_yakit";
			this.txt_yakit.Size = new System.Drawing.Size(249, 27);
			this.txt_yakit.TabIndex = 46;
			// 
			// lbl_yakit
			// 
			this.lbl_yakit.AutoSize = true;
			this.lbl_yakit.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lbl_yakit.Location = new System.Drawing.Point(355, 65);
			this.lbl_yakit.Name = "lbl_yakit";
			this.lbl_yakit.Size = new System.Drawing.Size(47, 19);
			this.lbl_yakit.TabIndex = 45;
			this.lbl_yakit.Text = "Yakıt";
			// 
			// txt_myili
			// 
			this.txt_myili.Location = new System.Drawing.Point(95, 146);
			this.txt_myili.MaxLength = 11;
			this.txt_myili.Name = "txt_myili";
			this.txt_myili.Size = new System.Drawing.Size(249, 27);
			this.txt_myili.TabIndex = 44;
			// 
			// lbl_myili
			// 
			this.lbl_myili.AutoSize = true;
			this.lbl_myili.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lbl_myili.Location = new System.Drawing.Point(4, 149);
			this.lbl_myili.Name = "lbl_myili";
			this.lbl_myili.Size = new System.Drawing.Size(89, 19);
			this.lbl_myili.TabIndex = 43;
			this.lbl_myili.Text = "Model Yılı";
			// 
			// btn_Kaydet
			// 
			this.btn_Kaydet.Location = new System.Drawing.Point(132, 221);
			this.btn_Kaydet.Name = "btn_Kaydet";
			this.btn_Kaydet.Size = new System.Drawing.Size(137, 56);
			this.btn_Kaydet.TabIndex = 42;
			this.btn_Kaydet.Text = "Kaydet";
			this.btn_Kaydet.UseVisualStyleBackColor = true;
			this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(15, 291);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(933, 350);
			this.dataGridView1.TabIndex = 41;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// btn_Resim
			// 
			this.btn_Resim.Location = new System.Drawing.Point(788, 197);
			this.btn_Resim.Name = "btn_Resim";
			this.btn_Resim.Size = new System.Drawing.Size(160, 45);
			this.btn_Resim.TabIndex = 40;
			this.btn_Resim.Text = "Resim Yükle";
			this.btn_Resim.UseVisualStyleBackColor = true;
			this.btn_Resim.Click += new System.EventHandler(this.btn_Resim_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(788, 11);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(160, 179);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 39;
			this.pictureBox1.TabStop = false;
			// 
			// rb_Yok
			// 
			this.rb_Yok.AutoSize = true;
			this.rb_Yok.Location = new System.Drawing.Point(645, 218);
			this.rb_Yok.Name = "rb_Yok";
			this.rb_Yok.Size = new System.Drawing.Size(57, 23);
			this.rb_Yok.TabIndex = 37;
			this.rb_Yok.TabStop = true;
			this.rb_Yok.Text = "Yok";
			this.rb_Yok.UseVisualStyleBackColor = true;
			// 
			// rb_Var
			// 
			this.rb_Var.AutoSize = true;
			this.rb_Var.Location = new System.Drawing.Point(477, 218);
			this.rb_Var.Name = "rb_Var";
			this.rb_Var.Size = new System.Drawing.Size(55, 23);
			this.rb_Var.TabIndex = 36;
			this.rb_Var.TabStop = true;
			this.rb_Var.Text = "Var";
			this.rb_Var.UseVisualStyleBackColor = true;
			// 
			// txt_marka
			// 
			this.txt_marka.Location = new System.Drawing.Point(95, 25);
			this.txt_marka.MaxLength = 11;
			this.txt_marka.Name = "txt_marka";
			this.txt_marka.Size = new System.Drawing.Size(249, 27);
			this.txt_marka.TabIndex = 35;
			// 
			// txt_model
			// 
			this.txt_model.Location = new System.Drawing.Point(95, 65);
			this.txt_model.Name = "txt_model";
			this.txt_model.Size = new System.Drawing.Size(249, 27);
			this.txt_model.TabIndex = 34;
			// 
			// txt_seri
			// 
			this.txt_seri.Location = new System.Drawing.Point(95, 104);
			this.txt_seri.Name = "txt_seri";
			this.txt_seri.Size = new System.Drawing.Size(249, 27);
			this.txt_seri.TabIndex = 33;
			// 
			// txt_km
			// 
			this.txt_km.Location = new System.Drawing.Point(477, 19);
			this.txt_km.Name = "txt_km";
			this.txt_km.Size = new System.Drawing.Size(249, 27);
			this.txt_km.TabIndex = 32;
			// 
			// lbl_Cinsiyet
			// 
			this.lbl_Cinsiyet.AutoSize = true;
			this.lbl_Cinsiyet.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lbl_Cinsiyet.Location = new System.Drawing.Point(355, 221);
			this.lbl_Cinsiyet.Name = "lbl_Cinsiyet";
			this.lbl_Cinsiyet.Size = new System.Drawing.Size(55, 19);
			this.lbl_Cinsiyet.TabIndex = 31;
			this.lbl_Cinsiyet.Text = "Klima";
			// 
			// lbl_kTipi
			// 
			this.lbl_kTipi.AutoSize = true;
			this.lbl_kTipi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lbl_kTipi.Location = new System.Drawing.Point(355, 146);
			this.lbl_kTipi.Name = "lbl_kTipi";
			this.lbl_kTipi.Size = new System.Drawing.Size(79, 19);
			this.lbl_kTipi.TabIndex = 30;
			this.lbl_kTipi.Text = "Kasa Tipi";
			// 
			// lbl_km
			// 
			this.lbl_km.AutoSize = true;
			this.lbl_km.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lbl_km.Location = new System.Drawing.Point(355, 25);
			this.lbl_km.Name = "lbl_km";
			this.lbl_km.Size = new System.Drawing.Size(35, 19);
			this.lbl_km.TabIndex = 29;
			this.lbl_km.Text = "Km";
			// 
			// lbl_seri
			// 
			this.lbl_seri.AutoSize = true;
			this.lbl_seri.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lbl_seri.Location = new System.Drawing.Point(8, 111);
			this.lbl_seri.Name = "lbl_seri";
			this.lbl_seri.Size = new System.Drawing.Size(40, 19);
			this.lbl_seri.TabIndex = 28;
			this.lbl_seri.Text = "Seri";
			// 
			// lbl_model
			// 
			this.lbl_model.AutoSize = true;
			this.lbl_model.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lbl_model.Location = new System.Drawing.Point(12, 69);
			this.lbl_model.Name = "lbl_model";
			this.lbl_model.Size = new System.Drawing.Size(57, 19);
			this.lbl_model.TabIndex = 27;
			this.lbl_model.Text = "Model";
			// 
			// lbl_marka
			// 
			this.lbl_marka.AutoSize = true;
			this.lbl_marka.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lbl_marka.Location = new System.Drawing.Point(8, 31);
			this.lbl_marka.Name = "lbl_marka";
			this.lbl_marka.Size = new System.Drawing.Size(58, 19);
			this.lbl_marka.TabIndex = 26;
			this.lbl_marka.Text = "Marka";
			// 
			// txt_plaka
			// 
			this.txt_plaka.Location = new System.Drawing.Point(477, 179);
			this.txt_plaka.Name = "txt_plaka";
			this.txt_plaka.Size = new System.Drawing.Size(249, 27);
			this.txt_plaka.TabIndex = 50;
			// 
			// lbl_plaka
			// 
			this.lbl_plaka.AutoSize = true;
			this.lbl_plaka.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lbl_plaka.Location = new System.Drawing.Point(355, 185);
			this.lbl_plaka.Name = "lbl_plaka";
			this.lbl_plaka.Size = new System.Drawing.Size(51, 19);
			this.lbl_plaka.TabIndex = 49;
			this.lbl_plaka.Text = "Plaka";
			// 
			// cmbx_ktipi
			// 
			this.cmbx_ktipi.FormattingEnabled = true;
			this.cmbx_ktipi.Items.AddRange(new object[] {
            "Sedan",
            "Hatchback",
            "Station Wagon",
            "Cabrio",
            "Pick Up",
            "SUV"});
			this.cmbx_ktipi.Location = new System.Drawing.Point(477, 144);
			this.cmbx_ktipi.Name = "cmbx_ktipi";
			this.cmbx_ktipi.Size = new System.Drawing.Size(249, 27);
			this.cmbx_ktipi.TabIndex = 51;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(4, 188);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 19);
			this.label1.TabIndex = 52;
			this.label1.Text = "Araç Fiyatı";
			// 
			// txt_aracfiyat
			// 
			this.txt_aracfiyat.Location = new System.Drawing.Point(95, 185);
			this.txt_aracfiyat.MaxLength = 11;
			this.txt_aracfiyat.Name = "txt_aracfiyat";
			this.txt_aracfiyat.Size = new System.Drawing.Size(249, 27);
			this.txt_aracfiyat.TabIndex = 53;
			// 
			// aracekle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(962, 651);
			this.Controls.Add(this.txt_aracfiyat);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbx_ktipi);
			this.Controls.Add(this.txt_plaka);
			this.Controls.Add(this.lbl_plaka);
			this.Controls.Add(this.txt_vites);
			this.Controls.Add(this.lbl_vites);
			this.Controls.Add(this.txt_yakit);
			this.Controls.Add(this.lbl_yakit);
			this.Controls.Add(this.txt_myili);
			this.Controls.Add(this.lbl_myili);
			this.Controls.Add(this.btn_Kaydet);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btn_Resim);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.rb_Yok);
			this.Controls.Add(this.rb_Var);
			this.Controls.Add(this.txt_marka);
			this.Controls.Add(this.txt_model);
			this.Controls.Add(this.txt_seri);
			this.Controls.Add(this.txt_km);
			this.Controls.Add(this.lbl_Cinsiyet);
			this.Controls.Add(this.lbl_kTipi);
			this.Controls.Add(this.lbl_km);
			this.Controls.Add(this.lbl_seri);
			this.Controls.Add(this.lbl_model);
			this.Controls.Add(this.lbl_marka);
			this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Name = "aracekle";
			this.Text = "aracekle";
			this.Load += new System.EventHandler(this.aracekle_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txt_vites;
		private System.Windows.Forms.Label lbl_vites;
		private System.Windows.Forms.TextBox txt_yakit;
		private System.Windows.Forms.Label lbl_yakit;
		private System.Windows.Forms.TextBox txt_myili;
		private System.Windows.Forms.Label lbl_myili;
		private System.Windows.Forms.Button btn_Kaydet;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btn_Resim;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.RadioButton rb_Yok;
		private System.Windows.Forms.RadioButton rb_Var;
		private System.Windows.Forms.TextBox txt_marka;
		private System.Windows.Forms.TextBox txt_model;
		private System.Windows.Forms.TextBox txt_seri;
		private System.Windows.Forms.TextBox txt_km;
		private System.Windows.Forms.Label lbl_Cinsiyet;
		private System.Windows.Forms.Label lbl_kTipi;
		private System.Windows.Forms.Label lbl_km;
		private System.Windows.Forms.Label lbl_seri;
		private System.Windows.Forms.Label lbl_model;
		private System.Windows.Forms.Label lbl_marka;
		private System.Windows.Forms.TextBox txt_plaka;
		private System.Windows.Forms.Label lbl_plaka;
		private System.Windows.Forms.ComboBox cmbx_ktipi;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_aracfiyat;
	}
}