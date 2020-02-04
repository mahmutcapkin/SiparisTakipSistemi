namespace ProjeOrijinal
{
    partial class FormSiparis
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
            this.label7 = new System.Windows.Forms.Label();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.listboxFiyat = new System.Windows.Forms.ListBox();
            this.listboxVergiOrani = new System.Windows.Forms.ListBox();
            this.listboxKargoAgirligi = new System.Windows.Forms.ListBox();
            this.listboxUrunAgirlik = new System.Windows.Forms.ListBox();
            this.listboxUrun = new System.Windows.Forms.ListBox();
            this.BtnSepeteEkle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lwSepet = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.btnOdeme = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1005, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 97;
            this.label7.Text = "ADET";
            // 
            // nudAdet
            // 
            this.nudAdet.Location = new System.Drawing.Point(1056, 226);
            this.nudAdet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(53, 22);
            this.nudAdet.TabIndex = 96;
            // 
            // listboxFiyat
            // 
            this.listboxFiyat.FormattingEnabled = true;
            this.listboxFiyat.ItemHeight = 16;
            this.listboxFiyat.Location = new System.Drawing.Point(848, 52);
            this.listboxFiyat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listboxFiyat.Name = "listboxFiyat";
            this.listboxFiyat.Size = new System.Drawing.Size(151, 244);
            this.listboxFiyat.TabIndex = 95;
            this.listboxFiyat.SelectedIndexChanged += new System.EventHandler(this.listboxFiyat_SelectedIndexChanged);
            // 
            // listboxVergiOrani
            // 
            this.listboxVergiOrani.FormattingEnabled = true;
            this.listboxVergiOrani.ItemHeight = 16;
            this.listboxVergiOrani.Location = new System.Drawing.Point(664, 52);
            this.listboxVergiOrani.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listboxVergiOrani.Name = "listboxVergiOrani";
            this.listboxVergiOrani.Size = new System.Drawing.Size(151, 244);
            this.listboxVergiOrani.TabIndex = 94;
            this.listboxVergiOrani.SelectedIndexChanged += new System.EventHandler(this.listboxVergiOrani_SelectedIndexChanged);
            // 
            // listboxKargoAgirligi
            // 
            this.listboxKargoAgirligi.FormattingEnabled = true;
            this.listboxKargoAgirligi.ItemHeight = 16;
            this.listboxKargoAgirligi.Location = new System.Drawing.Point(459, 52);
            this.listboxKargoAgirligi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listboxKargoAgirligi.Name = "listboxKargoAgirligi";
            this.listboxKargoAgirligi.Size = new System.Drawing.Size(157, 244);
            this.listboxKargoAgirligi.TabIndex = 93;
            this.listboxKargoAgirligi.SelectedIndexChanged += new System.EventHandler(this.listboxKargoAgirligi_SelectedIndexChanged);
            // 
            // listboxUrunAgirlik
            // 
            this.listboxUrunAgirlik.FormattingEnabled = true;
            this.listboxUrunAgirlik.ItemHeight = 16;
            this.listboxUrunAgirlik.Location = new System.Drawing.Point(243, 52);
            this.listboxUrunAgirlik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listboxUrunAgirlik.Name = "listboxUrunAgirlik";
            this.listboxUrunAgirlik.Size = new System.Drawing.Size(159, 244);
            this.listboxUrunAgirlik.TabIndex = 92;
            this.listboxUrunAgirlik.SelectedIndexChanged += new System.EventHandler(this.listboxUrunAgirlik_SelectedIndexChanged);
            // 
            // listboxUrun
            // 
            this.listboxUrun.FormattingEnabled = true;
            this.listboxUrun.ItemHeight = 16;
            this.listboxUrun.Location = new System.Drawing.Point(17, 52);
            this.listboxUrun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listboxUrun.Name = "listboxUrun";
            this.listboxUrun.Size = new System.Drawing.Size(159, 244);
            this.listboxUrun.TabIndex = 91;
            this.listboxUrun.SelectedIndexChanged += new System.EventHandler(this.listboxUrun_SelectedIndexChanged);
            // 
            // BtnSepeteEkle
            // 
            this.BtnSepeteEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSepeteEkle.Location = new System.Drawing.Point(1008, 254);
            this.BtnSepeteEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSepeteEkle.Name = "BtnSepeteEkle";
            this.BtnSepeteEkle.Size = new System.Drawing.Size(101, 33);
            this.BtnSepeteEkle.TabIndex = 90;
            this.BtnSepeteEkle.Text = "EKLE";
            this.BtnSepeteEkle.UseVisualStyleBackColor = true;
            this.BtnSepeteEkle.Click += new System.EventHandler(this.BtnSepeteEkle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(881, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 87;
            this.label5.Text = "FİYAT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(676, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 86;
            this.label4.Text = "VERGİ ORANI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(460, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 25);
            this.label3.TabIndex = 85;
            this.label3.Text = "KARGO AĞIRLIĞI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(245, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 25);
            this.label2.TabIndex = 84;
            this.label2.Text = "ÜRÜN AĞIRLIĞI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 83;
            this.label1.Text = "ÜRÜNLER";
            // 
            // lwSepet
            // 
            this.lwSepet.CheckBoxes = true;
            this.lwSepet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14});
            this.lwSepet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lwSepet.FullRowSelect = true;
            this.lwSepet.GridLines = true;
            this.lwSepet.Location = new System.Drawing.Point(-1, 361);
            this.lwSepet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lwSepet.Name = "lwSepet";
            this.lwSepet.Size = new System.Drawing.Size(1489, 340);
            this.lwSepet.TabIndex = 98;
            this.lwSepet.UseCompatibleStateImageBehavior = false;
            this.lwSepet.View = System.Windows.Forms.View.Details;
            this.lwSepet.SelectedIndexChanged += new System.EventHandler(this.lwSepet_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Adı Soyadı";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ürün Adı";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ürün Adedi";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Sipariş Tarihi";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Adet Fiyatı";
            this.columnHeader5.Width = 110;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mail Adresi";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Kargo Adresi";
            this.columnHeader7.Width = 250;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "GSM";
            this.columnHeader8.Width = 120;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "KDV";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Ara Toplam";
            this.columnHeader10.Width = 120;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Ürün Ağırlığı";
            this.columnHeader12.Width = 120;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Toplam Ağırlık";
            this.columnHeader13.Width = 120;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Genel Toplam";
            this.columnHeader14.Width = 120;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(12, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 29);
            this.label8.TabIndex = 99;
            this.label8.Text = "SEPET";
            // 
            // btnOdeme
            // 
            this.btnOdeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdeme.Location = new System.Drawing.Point(636, 705);
            this.btnOdeme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOdeme.Name = "btnOdeme";
            this.btnOdeme.Size = new System.Drawing.Size(148, 34);
            this.btnOdeme.TabIndex = 101;
            this.btnOdeme.Text = "Ödemeye Geç";
            this.btnOdeme.UseVisualStyleBackColor = true;
            this.btnOdeme.Click += new System.EventHandler(this.btnOdeme_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(1178, 43);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(151, 244);
            this.listBox1.TabIndex = 102;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1056, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 103;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1493, 750);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnOdeme);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lwSepet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.listboxFiyat);
            this.Controls.Add(this.listboxVergiOrani);
            this.Controls.Add(this.listboxKargoAgirligi);
            this.Controls.Add(this.listboxUrunAgirlik);
            this.Controls.Add(this.listboxUrun);
            this.Controls.Add(this.BtnSepeteEkle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormSiparis";
            this.Text = "FormSiparis";
            this.Load += new System.EventHandler(this.FormSiparis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudAdet;
        public System.Windows.Forms.ListBox listboxFiyat;
        public System.Windows.Forms.ListBox listboxVergiOrani;
        public System.Windows.Forms.ListBox listboxKargoAgirligi;
        public System.Windows.Forms.ListBox listboxUrunAgirlik;
        public System.Windows.Forms.ListBox listboxUrun;
        private System.Windows.Forms.Button BtnSepeteEkle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.Button btnOdeme;
        public System.Windows.Forms.ListView lwSepet;
        public System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
    }
}