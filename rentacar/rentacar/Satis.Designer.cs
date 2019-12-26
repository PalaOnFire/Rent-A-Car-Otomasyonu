namespace rentacar
{
	partial class Satis
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Satis));
			this.musteriler = new System.Windows.Forms.DataGridView();
			this.txt_tutar = new System.Windows.Forms.TextBox();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.araclar = new System.Windows.Forms.DataGridView();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.txt_yil = new System.Windows.Forms.TextBox();
			this.txt_model = new System.Windows.Forms.TextBox();
			this.txt_marka = new System.Windows.Forms.TextBox();
			this.txt_plaka = new System.Windows.Forms.TextBox();
			this.txt_adi = new System.Windows.Forms.TextBox();
			this.txt_soyadi = new System.Windows.Forms.TextBox();
			this.txt_telno = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_kirala = new System.Windows.Forms.Button();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.aracid = new System.Windows.Forms.Label();
			this.musteriİD = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.txt_tcno = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.lbl_fiyat = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.musteriler)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.araclar)).BeginInit();
			this.SuspendLayout();
			// 
			// musteriler
			// 
			this.musteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.musteriler.Location = new System.Drawing.Point(389, 233);
			this.musteriler.Margin = new System.Windows.Forms.Padding(4);
			this.musteriler.Name = "musteriler";
			this.musteriler.Size = new System.Drawing.Size(343, 185);
			this.musteriler.TabIndex = 36;
			this.musteriler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.musteriler_CellContentClick);
			this.musteriler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.musteriler_CellDoubleClick);
			// 
			// txt_tutar
			// 
			this.txt_tutar.Location = new System.Drawing.Point(318, 563);
			this.txt_tutar.Margin = new System.Windows.Forms.Padding(4);
			this.txt_tutar.Name = "txt_tutar";
			this.txt_tutar.Size = new System.Drawing.Size(194, 22);
			this.txt_tutar.TabIndex = 34;
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker2.Location = new System.Drawing.Point(318, 522);
			this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(194, 22);
			this.dateTimePicker2.TabIndex = 31;
			this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(318, 488);
			this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(194, 22);
			this.dateTimePicker1.TabIndex = 30;
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label3.Location = new System.Drawing.Point(130, 487);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(151, 23);
			this.label3.TabIndex = 25;
			this.label3.Text = "Başlangıç Tarihi:";
			// 
			// araclar
			// 
			this.araclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.araclar.Location = new System.Drawing.Point(12, 233);
			this.araclar.Margin = new System.Windows.Forms.Padding(4);
			this.araclar.Name = "araclar";
			this.araclar.Size = new System.Drawing.Size(346, 185);
			this.araclar.TabIndex = 23;
			this.araclar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.araclar_CellDoubleClick);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label4.Location = new System.Drawing.Point(130, 508);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(109, 23);
			this.label4.TabIndex = 37;
			this.label4.Text = "Bitiş Tarihi:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label5.Location = new System.Drawing.Point(130, 563);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(174, 23);
			this.label5.TabIndex = 38;
			this.label5.Text = "Toplam Tutar (TL):";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label6.Location = new System.Drawing.Point(159, 9);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(122, 23);
			this.label6.TabIndex = 39;
			this.label6.Text = "Araç Bilgileri";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label7.Location = new System.Drawing.Point(11, 188);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(40, 23);
			this.label7.TabIndex = 40;
			this.label7.Text = "Yıl:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label8.Location = new System.Drawing.Point(11, 150);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(70, 23);
			this.label8.TabIndex = 41;
			this.label8.Text = "Model:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label9.Location = new System.Drawing.Point(11, 113);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(74, 23);
			this.label9.TabIndex = 42;
			this.label9.Text = "Marka:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label10.ForeColor = System.Drawing.Color.Red;
			this.label10.Location = new System.Drawing.Point(11, 73);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(84, 23);
			this.label10.TabIndex = 43;
			this.label10.Text = "PLAKA:";
			// 
			// txt_yil
			// 
			this.txt_yil.BackColor = System.Drawing.SystemColors.Control;
			this.txt_yil.Location = new System.Drawing.Point(93, 188);
			this.txt_yil.Margin = new System.Windows.Forms.Padding(4);
			this.txt_yil.Name = "txt_yil";
			this.txt_yil.Size = new System.Drawing.Size(265, 22);
			this.txt_yil.TabIndex = 44;
			// 
			// txt_model
			// 
			this.txt_model.BackColor = System.Drawing.SystemColors.Control;
			this.txt_model.Location = new System.Drawing.Point(93, 152);
			this.txt_model.Margin = new System.Windows.Forms.Padding(4);
			this.txt_model.Name = "txt_model";
			this.txt_model.Size = new System.Drawing.Size(265, 22);
			this.txt_model.TabIndex = 45;
			// 
			// txt_marka
			// 
			this.txt_marka.BackColor = System.Drawing.SystemColors.Control;
			this.txt_marka.Location = new System.Drawing.Point(93, 113);
			this.txt_marka.Margin = new System.Windows.Forms.Padding(4);
			this.txt_marka.Name = "txt_marka";
			this.txt_marka.Size = new System.Drawing.Size(265, 22);
			this.txt_marka.TabIndex = 46;
			// 
			// txt_plaka
			// 
			this.txt_plaka.Location = new System.Drawing.Point(93, 73);
			this.txt_plaka.Margin = new System.Windows.Forms.Padding(4);
			this.txt_plaka.Name = "txt_plaka";
			this.txt_plaka.Size = new System.Drawing.Size(175, 22);
			this.txt_plaka.TabIndex = 47;
			// 
			// txt_adi
			// 
			this.txt_adi.BackColor = System.Drawing.SystemColors.Control;
			this.txt_adi.Location = new System.Drawing.Point(467, 113);
			this.txt_adi.Margin = new System.Windows.Forms.Padding(4);
			this.txt_adi.Name = "txt_adi";
			this.txt_adi.Size = new System.Drawing.Size(265, 22);
			this.txt_adi.TabIndex = 55;
			// 
			// txt_soyadi
			// 
			this.txt_soyadi.BackColor = System.Drawing.SystemColors.Control;
			this.txt_soyadi.Location = new System.Drawing.Point(467, 152);
			this.txt_soyadi.Margin = new System.Windows.Forms.Padding(4);
			this.txt_soyadi.Name = "txt_soyadi";
			this.txt_soyadi.Size = new System.Drawing.Size(265, 22);
			this.txt_soyadi.TabIndex = 54;
			// 
			// txt_telno
			// 
			this.txt_telno.BackColor = System.Drawing.SystemColors.Control;
			this.txt_telno.Location = new System.Drawing.Point(467, 188);
			this.txt_telno.Margin = new System.Windows.Forms.Padding(4);
			this.txt_telno.Name = "txt_telno";
			this.txt_telno.Size = new System.Drawing.Size(265, 22);
			this.txt_telno.TabIndex = 53;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label11.ForeColor = System.Drawing.Color.Red;
			this.label11.Location = new System.Drawing.Point(385, 73);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(73, 23);
			this.label11.TabIndex = 52;
			this.label11.Text = "TC No:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label12.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label12.Location = new System.Drawing.Point(385, 113);
			this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(46, 23);
			this.label12.TabIndex = 51;
			this.label12.Text = "Adı:";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label13.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label13.Location = new System.Drawing.Point(385, 150);
			this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(73, 23);
			this.label13.TabIndex = 50;
			this.label13.Text = "Soyadı:";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label14.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label14.Location = new System.Drawing.Point(385, 188);
			this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(72, 23);
			this.label14.TabIndex = 49;
			this.label14.Text = "Tel No:";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label15.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label15.Location = new System.Drawing.Point(512, 9);
			this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(148, 23);
			this.label15.TabIndex = 48;
			this.label15.Text = "Müşteri Bilgileri";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label1.Location = new System.Drawing.Point(311, 427);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(118, 23);
			this.label1.TabIndex = 57;
			this.label1.Text = "Kira Bilgileri";
			// 
			// btn_kirala
			// 
			this.btn_kirala.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_kirala.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btn_kirala.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_kirala.ImageIndex = 0;
			this.btn_kirala.ImageList = this.imageList1;
			this.btn_kirala.Location = new System.Drawing.Point(315, 602);
			this.btn_kirala.Name = "btn_kirala";
			this.btn_kirala.Size = new System.Drawing.Size(197, 56);
			this.btn_kirala.TabIndex = 58;
			this.btn_kirala.Text = "Kirala";
			this.btn_kirala.UseVisualStyleBackColor = true;
			this.btn_kirala.Click += new System.EventHandler(this.button1_Click);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "save.png");
			// 
			// aracid
			// 
			this.aracid.AutoSize = true;
			this.aracid.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.aracid.Location = new System.Drawing.Point(12, 14);
			this.aracid.Name = "aracid";
			this.aracid.Size = new System.Drawing.Size(57, 17);
			this.aracid.TabIndex = 59;
			this.aracid.Text = "Arac İD";
			this.aracid.Visible = false;
			// 
			// musteriİD
			// 
			this.musteriİD.AutoSize = true;
			this.musteriİD.Location = new System.Drawing.Point(384, 9);
			this.musteriİD.Name = "musteriİD";
			this.musteriİD.Size = new System.Drawing.Size(71, 17);
			this.musteriİD.TabIndex = 60;
			this.musteriİD.Text = "musteri İD";
			this.musteriİD.Visible = false;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button1.Location = new System.Drawing.Point(275, 72);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(83, 23);
			this.button1.TabIndex = 61;
			this.button1.Text = "Ara";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// txt_tcno
			// 
			this.txt_tcno.Location = new System.Drawing.Point(466, 72);
			this.txt_tcno.Margin = new System.Windows.Forms.Padding(4);
			this.txt_tcno.Name = "txt_tcno";
			this.txt_tcno.Size = new System.Drawing.Size(175, 22);
			this.txt_tcno.TabIndex = 62;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button2.Location = new System.Drawing.Point(648, 71);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(83, 23);
			this.button2.TabIndex = 63;
			this.button2.Text = "Ara";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// lbl_fiyat
			// 
			this.lbl_fiyat.AutoSize = true;
			this.lbl_fiyat.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lbl_fiyat.Location = new System.Drawing.Point(12, 47);
			this.lbl_fiyat.Name = "lbl_fiyat";
			this.lbl_fiyat.Size = new System.Drawing.Size(39, 17);
			this.lbl_fiyat.TabIndex = 64;
			this.lbl_fiyat.Text = "Fiyat";
			this.lbl_fiyat.Visible = false;
			// 
			// Satis
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(760, 672);
			this.Controls.Add(this.lbl_fiyat);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.txt_tcno);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.musteriİD);
			this.Controls.Add(this.aracid);
			this.Controls.Add(this.btn_kirala);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_adi);
			this.Controls.Add(this.txt_soyadi);
			this.Controls.Add(this.txt_telno);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.txt_plaka);
			this.Controls.Add(this.txt_marka);
			this.Controls.Add(this.txt_model);
			this.Controls.Add(this.txt_yil);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.musteriler);
			this.Controls.Add(this.txt_tutar);
			this.Controls.Add(this.dateTimePicker2);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.araclar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Satis";
			this.Text = "Satis";
			this.Load += new System.EventHandler(this.Satis_Load);
			((System.ComponentModel.ISupportInitialize)(this.musteriler)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.araclar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.DataGridView musteriler;
		private System.Windows.Forms.TextBox txt_tutar;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView araclar;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txt_yil;
		private System.Windows.Forms.TextBox txt_model;
		private System.Windows.Forms.TextBox txt_marka;
		private System.Windows.Forms.TextBox txt_plaka;
		private System.Windows.Forms.TextBox txt_adi;
		private System.Windows.Forms.TextBox txt_soyadi;
		private System.Windows.Forms.TextBox txt_telno;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_kirala;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Label aracid;
		private System.Windows.Forms.Label musteriİD;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txt_tcno;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label lbl_fiyat;
	}
}