namespace Kütüphane_Otomasyonu
{
    partial class UyeSayfası
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
            this.btn_ara = new System.Windows.Forms.Button();
            this.btn_yenile = new System.Windows.Forms.Button();
            this.txt_kitapId = new System.Windows.Forms.TextBox();
            this.btn_cıkıs = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kitapId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapİsim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapYazar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapDili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayinEvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sayfaSayisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basimYili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ara
            // 
            this.btn_ara.Location = new System.Drawing.Point(12, 12);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(75, 23);
            this.btn_ara.TabIndex = 0;
            this.btn_ara.Text = "Ara";
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // btn_yenile
            // 
            this.btn_yenile.Location = new System.Drawing.Point(226, 12);
            this.btn_yenile.Name = "btn_yenile";
            this.btn_yenile.Size = new System.Drawing.Size(75, 23);
            this.btn_yenile.TabIndex = 0;
            this.btn_yenile.Text = "Yenile";
            this.btn_yenile.UseVisualStyleBackColor = true;
            this.btn_yenile.Click += new System.EventHandler(this.btn_yenile_Click);
            // 
            // txt_kitapId
            // 
            this.txt_kitapId.Location = new System.Drawing.Point(106, 14);
            this.txt_kitapId.Name = "txt_kitapId";
            this.txt_kitapId.Size = new System.Drawing.Size(100, 20);
            this.txt_kitapId.TabIndex = 1;
            // 
            // btn_cıkıs
            // 
            this.btn_cıkıs.Location = new System.Drawing.Point(12, 356);
            this.btn_cıkıs.Name = "btn_cıkıs";
            this.btn_cıkıs.Size = new System.Drawing.Size(93, 32);
            this.btn_cıkıs.TabIndex = 3;
            this.btn_cıkıs.Text = "Çıkış Yap";
            this.btn_cıkıs.UseVisualStyleBackColor = true;
            this.btn_cıkıs.Click += new System.EventHandler(this.btn_cıkıs_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kitapId,
            this.kitapİsim,
            this.kitapYazar,
            this.kitapDili,
            this.yayinEvi,
            this.tur,
            this.adet,
            this.sayfaSayisi,
            this.basimYili});
            this.dataGridView1.Location = new System.Drawing.Point(12, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(759, 267);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // kitapId
            // 
            this.kitapId.HeaderText = "KİTAP İD";
            this.kitapId.Name = "kitapId";
            this.kitapId.Width = 75;
            // 
            // kitapİsim
            // 
            this.kitapİsim.HeaderText = "KİTAP ADI";
            this.kitapİsim.Name = "kitapİsim";
            this.kitapİsim.Width = 75;
            // 
            // kitapYazar
            // 
            this.kitapYazar.HeaderText = "KİTAP YAZARI";
            this.kitapYazar.Name = "kitapYazar";
            this.kitapYazar.Width = 75;
            // 
            // kitapDili
            // 
            this.kitapDili.HeaderText = "KİTAP DİLİ";
            this.kitapDili.Name = "kitapDili";
            this.kitapDili.Width = 75;
            // 
            // yayinEvi
            // 
            this.yayinEvi.HeaderText = "YAYIN EVİ";
            this.yayinEvi.Name = "yayinEvi";
            this.yayinEvi.Width = 75;
            // 
            // tur
            // 
            this.tur.HeaderText = "KİTAP TÜRÜ";
            this.tur.Name = "tur";
            this.tur.Width = 75;
            // 
            // adet
            // 
            this.adet.HeaderText = "KİTAP ADETİ";
            this.adet.Name = "adet";
            this.adet.Width = 75;
            // 
            // sayfaSayisi
            // 
            this.sayfaSayisi.HeaderText = "SAYFA SAYISI";
            this.sayfaSayisi.Name = "sayfaSayisi";
            this.sayfaSayisi.Width = 75;
            // 
            // basimYili
            // 
            this.basimYili.HeaderText = "BASIM YILI";
            this.basimYili.Name = "basimYili";
            this.basimYili.Width = 75;
            // 
            // UyeSayfası
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 442);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_cıkıs);
            this.Controls.Add(this.txt_kitapId);
            this.Controls.Add(this.btn_yenile);
            this.Controls.Add(this.btn_ara);
            this.Name = "UyeSayfası";
            this.Text = "UyeSayfası";
            this.Load += new System.EventHandler(this.UyeSayfası_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.Button btn_yenile;
        private System.Windows.Forms.TextBox txt_kitapId;
        private System.Windows.Forms.Button btn_cıkıs;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapId;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapİsim;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapYazar;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapDili;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayinEvi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tur;
        private System.Windows.Forms.DataGridViewTextBoxColumn adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn sayfaSayisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn basimYili;
    }
}