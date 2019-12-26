namespace rentacar
{
	partial class anasayfa
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anasayfa));
			this.menuYonetici = new System.Windows.Forms.MenuStrip();
			this.müşterilerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.müşteriEkleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.müşteriGüncelleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.müşteriSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.müşteriListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.araçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.araçEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.araçGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.araçSİlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.araçlarıListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.satışToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.raporAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.çıkışToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuPersonel = new System.Windows.Forms.MenuStrip();
			this.müşterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.müşteriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.müşteriSİlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.müşteriGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.müşteriListelelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.satışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuYonetici.SuspendLayout();
			this.menuPersonel.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuYonetici
			// 
			this.menuYonetici.AutoSize = false;
			this.menuYonetici.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuYonetici.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşterilerToolStripMenuItem1,
            this.araçlarToolStripMenuItem,
            this.satışToolStripMenuItem1,
            this.raporAlToolStripMenuItem,
            this.ayarlarToolStripMenuItem,
            this.çıkışToolStripMenuItem1});
			this.menuYonetici.Location = new System.Drawing.Point(0, 71);
			this.menuYonetici.Name = "menuYonetici";
			this.menuYonetici.Size = new System.Drawing.Size(1215, 94);
			this.menuYonetici.TabIndex = 0;
			this.menuYonetici.Text = "menuStrip1";
			this.menuYonetici.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuYonetici_ItemClicked);
			// 
			// müşterilerToolStripMenuItem1
			// 
			this.müşterilerToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriEkleToolStripMenuItem1,
            this.müşteriGüncelleToolStripMenuItem1,
            this.müşteriSilToolStripMenuItem,
            this.müşteriListeleToolStripMenuItem});
			this.müşterilerToolStripMenuItem1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.müşterilerToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("müşterilerToolStripMenuItem1.Image")));
			this.müşterilerToolStripMenuItem1.Name = "müşterilerToolStripMenuItem1";
			this.müşterilerToolStripMenuItem1.Size = new System.Drawing.Size(151, 90);
			this.müşterilerToolStripMenuItem1.Text = "MÜŞTERİLER";
			// 
			// müşteriEkleToolStripMenuItem1
			// 
			this.müşteriEkleToolStripMenuItem1.Name = "müşteriEkleToolStripMenuItem1";
			this.müşteriEkleToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
			this.müşteriEkleToolStripMenuItem1.Text = "Müşteri Ekle";
			this.müşteriEkleToolStripMenuItem1.Click += new System.EventHandler(this.müşteriEkleToolStripMenuItem1_Click);
			// 
			// müşteriGüncelleToolStripMenuItem1
			// 
			this.müşteriGüncelleToolStripMenuItem1.Name = "müşteriGüncelleToolStripMenuItem1";
			this.müşteriGüncelleToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
			this.müşteriGüncelleToolStripMenuItem1.Text = "Müşteri Güncelle";
			this.müşteriGüncelleToolStripMenuItem1.Click += new System.EventHandler(this.müşteriGüncelleToolStripMenuItem1_Click);
			// 
			// müşteriSilToolStripMenuItem
			// 
			this.müşteriSilToolStripMenuItem.Name = "müşteriSilToolStripMenuItem";
			this.müşteriSilToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.müşteriSilToolStripMenuItem.Text = "Müşteri Sil ";
			this.müşteriSilToolStripMenuItem.Click += new System.EventHandler(this.müşteriSilToolStripMenuItem_Click);
			// 
			// müşteriListeleToolStripMenuItem
			// 
			this.müşteriListeleToolStripMenuItem.Name = "müşteriListeleToolStripMenuItem";
			this.müşteriListeleToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.müşteriListeleToolStripMenuItem.Text = "Müşteri Listele";
			this.müşteriListeleToolStripMenuItem.Click += new System.EventHandler(this.müşteriListeleToolStripMenuItem_Click);
			// 
			// araçlarToolStripMenuItem
			// 
			this.araçlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.araçEkleToolStripMenuItem,
            this.araçGüncelleToolStripMenuItem,
            this.araçSİlToolStripMenuItem,
            this.araçlarıListeleToolStripMenuItem});
			this.araçlarToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.araçlarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("araçlarToolStripMenuItem.Image")));
			this.araçlarToolStripMenuItem.Name = "araçlarToolStripMenuItem";
			this.araçlarToolStripMenuItem.Size = new System.Drawing.Size(121, 90);
			this.araçlarToolStripMenuItem.Text = "ARAÇLAR";
			// 
			// araçEkleToolStripMenuItem
			// 
			this.araçEkleToolStripMenuItem.Name = "araçEkleToolStripMenuItem";
			this.araçEkleToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
			this.araçEkleToolStripMenuItem.Text = "Araç Ekle";
			this.araçEkleToolStripMenuItem.Click += new System.EventHandler(this.araçEkleToolStripMenuItem_Click);
			// 
			// araçGüncelleToolStripMenuItem
			// 
			this.araçGüncelleToolStripMenuItem.Name = "araçGüncelleToolStripMenuItem";
			this.araçGüncelleToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
			this.araçGüncelleToolStripMenuItem.Text = "Araç Güncelle";
			this.araçGüncelleToolStripMenuItem.Click += new System.EventHandler(this.araçGüncelleToolStripMenuItem_Click);
			// 
			// araçSİlToolStripMenuItem
			// 
			this.araçSİlToolStripMenuItem.Name = "araçSİlToolStripMenuItem";
			this.araçSİlToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
			this.araçSİlToolStripMenuItem.Text = "Araç Sİl ";
			this.araçSİlToolStripMenuItem.Click += new System.EventHandler(this.araçSİlToolStripMenuItem_Click);
			// 
			// araçlarıListeleToolStripMenuItem
			// 
			this.araçlarıListeleToolStripMenuItem.Name = "araçlarıListeleToolStripMenuItem";
			this.araçlarıListeleToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
			this.araçlarıListeleToolStripMenuItem.Text = "Araçları Listele";
			this.araçlarıListeleToolStripMenuItem.Click += new System.EventHandler(this.araçlarıListeleToolStripMenuItem_Click);
			// 
			// satışToolStripMenuItem1
			// 
			this.satışToolStripMenuItem1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.satışToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("satışToolStripMenuItem1.Image")));
			this.satışToolStripMenuItem1.Name = "satışToolStripMenuItem1";
			this.satışToolStripMenuItem1.Size = new System.Drawing.Size(85, 90);
			this.satışToolStripMenuItem1.Text = "SATIŞ";
			this.satışToolStripMenuItem1.Click += new System.EventHandler(this.satışToolStripMenuItem1_Click);
			// 
			// raporAlToolStripMenuItem
			// 
			this.raporAlToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.raporAlToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
			this.raporAlToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("raporAlToolStripMenuItem.Image")));
			this.raporAlToolStripMenuItem.Name = "raporAlToolStripMenuItem";
			this.raporAlToolStripMenuItem.Size = new System.Drawing.Size(107, 90);
			this.raporAlToolStripMenuItem.Text = "Rapor Al";
			this.raporAlToolStripMenuItem.Click += new System.EventHandler(this.raporAlToolStripMenuItem_Click);
			// 
			// ayarlarToolStripMenuItem
			// 
			this.ayarlarToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.ayarlarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ayarlarToolStripMenuItem.Image")));
			this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
			this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(116, 90);
			this.ayarlarToolStripMenuItem.Text = "AYARLAR";
			this.ayarlarToolStripMenuItem.Click += new System.EventHandler(this.ayarlarToolStripMenuItem_Click);
			// 
			// çıkışToolStripMenuItem1
			// 
			this.çıkışToolStripMenuItem1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.çıkışToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("çıkışToolStripMenuItem1.Image")));
			this.çıkışToolStripMenuItem1.Name = "çıkışToolStripMenuItem1";
			this.çıkışToolStripMenuItem1.Size = new System.Drawing.Size(86, 90);
			this.çıkışToolStripMenuItem1.Text = "ÇIKIŞ";
			this.çıkışToolStripMenuItem1.Click += new System.EventHandler(this.çıkışToolStripMenuItem1_Click);
			// 
			// menuPersonel
			// 
			this.menuPersonel.AccessibleRole = System.Windows.Forms.AccessibleRole.Table;
			this.menuPersonel.AutoSize = false;
			this.menuPersonel.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuPersonel.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.menuPersonel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşterilerToolStripMenuItem,
            this.satışToolStripMenuItem,
            this.çıkışToolStripMenuItem});
			this.menuPersonel.Location = new System.Drawing.Point(0, 0);
			this.menuPersonel.Name = "menuPersonel";
			this.menuPersonel.Size = new System.Drawing.Size(1215, 71);
			this.menuPersonel.TabIndex = 1;
			this.menuPersonel.Text = "menuStrip1";
			// 
			// müşterilerToolStripMenuItem
			// 
			this.müşterilerToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
			this.müşterilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriEkleToolStripMenuItem,
            this.müşteriSİlToolStripMenuItem,
            this.müşteriGüncelleToolStripMenuItem,
            this.müşteriListelelToolStripMenuItem});
			this.müşterilerToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.müşterilerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
			this.müşterilerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("müşterilerToolStripMenuItem.Image")));
			this.müşterilerToolStripMenuItem.Name = "müşterilerToolStripMenuItem";
			this.müşterilerToolStripMenuItem.Size = new System.Drawing.Size(151, 67);
			this.müşterilerToolStripMenuItem.Text = "MÜŞTERİLER";
			this.müşterilerToolStripMenuItem.Click += new System.EventHandler(this.müşterilerToolStripMenuItem_Click);
			// 
			// müşteriEkleToolStripMenuItem
			// 
			this.müşteriEkleToolStripMenuItem.Name = "müşteriEkleToolStripMenuItem";
			this.müşteriEkleToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.müşteriEkleToolStripMenuItem.Text = "Müşteri Ekle";
			this.müşteriEkleToolStripMenuItem.Click += new System.EventHandler(this.müşteriEkleToolStripMenuItem_Click);
			// 
			// müşteriSİlToolStripMenuItem
			// 
			this.müşteriSİlToolStripMenuItem.Name = "müşteriSİlToolStripMenuItem";
			this.müşteriSİlToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.müşteriSİlToolStripMenuItem.Text = "Müşteri Sİl ";
			this.müşteriSİlToolStripMenuItem.Click += new System.EventHandler(this.müşteriSİlToolStripMenuItem_Click);
			// 
			// müşteriGüncelleToolStripMenuItem
			// 
			this.müşteriGüncelleToolStripMenuItem.Name = "müşteriGüncelleToolStripMenuItem";
			this.müşteriGüncelleToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.müşteriGüncelleToolStripMenuItem.Text = "Müşteri Güncelle";
			this.müşteriGüncelleToolStripMenuItem.Click += new System.EventHandler(this.müşteriGüncelleToolStripMenuItem_Click);
			// 
			// müşteriListelelToolStripMenuItem
			// 
			this.müşteriListelelToolStripMenuItem.Name = "müşteriListelelToolStripMenuItem";
			this.müşteriListelelToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.müşteriListelelToolStripMenuItem.Text = "Müşteri Listele";
			this.müşteriListelelToolStripMenuItem.Click += new System.EventHandler(this.müşteriListelelToolStripMenuItem_Click);
			// 
			// satışToolStripMenuItem
			// 
			this.satışToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.satışToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("satışToolStripMenuItem.Image")));
			this.satışToolStripMenuItem.Name = "satışToolStripMenuItem";
			this.satışToolStripMenuItem.Size = new System.Drawing.Size(85, 67);
			this.satışToolStripMenuItem.Text = "SATIŞ";
			this.satışToolStripMenuItem.Click += new System.EventHandler(this.satışToolStripMenuItem_Click);
			// 
			// çıkışToolStripMenuItem
			// 
			this.çıkışToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.çıkışToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("çıkışToolStripMenuItem.Image")));
			this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
			this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(86, 67);
			this.çıkışToolStripMenuItem.Text = "ÇIKIŞ";
			this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
			// 
			// anasayfa
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(1215, 715);
			this.Controls.Add(this.menuYonetici);
			this.Controls.Add(this.menuPersonel);
			this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.IsMdiContainer = true;
			this.Name = "anasayfa";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "Şengüller Rent A Car";
			this.Load += new System.EventHandler(this.anasayfa_Load);
			this.menuYonetici.ResumeLayout(false);
			this.menuYonetici.PerformLayout();
			this.menuPersonel.ResumeLayout(false);
			this.menuPersonel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuYonetici;
		private System.Windows.Forms.MenuStrip menuPersonel;
		private System.Windows.Forms.ToolStripMenuItem müşterilerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem satışToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem müşterilerToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem araçlarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem satışToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem müşteriEkleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem müşteriSİlToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem müşteriGüncelleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem müşteriEkleToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem müşteriGüncelleToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem müşteriSilToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem araçEkleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem araçGüncelleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem araçSİlToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem müşteriListelelToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem müşteriListeleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem araçlarıListeleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem raporAlToolStripMenuItem;
	}
}