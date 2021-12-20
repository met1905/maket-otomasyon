namespace MarketOtomasyon
{
    partial class FrmUrunisteleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunisteleme));
            this.LblMiktar = new System.Windows.Forms.Label();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.satis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.alis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.miktar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ad = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.barkod = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnUrunEkle = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Marka = new System.Windows.Forms.ComboBox();
            this.Kategori = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LblMiktar
            // 
            this.LblMiktar.AutoSize = true;
            this.LblMiktar.Location = new System.Drawing.Point(22, 365);
            this.LblMiktar.Name = "LblMiktar";
            this.LblMiktar.Size = new System.Drawing.Size(0, 20);
            this.LblMiktar.TabIndex = 43;
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackColor = System.Drawing.Color.DarkGreen;
            this.btnguncelle.Font = new System.Drawing.Font("Freestyle Script", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguncelle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnguncelle.Location = new System.Drawing.Point(267, 459);
            this.btnguncelle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(140, 55);
            this.btnguncelle.TabIndex = 40;
            this.btnguncelle.Text = "Update";
            this.btnguncelle.UseVisualStyleBackColor = false;
            this.btnguncelle.Click += new System.EventHandler(this.btnvarolan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Freestyle Script", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(98, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 37);
            this.label1.TabIndex = 39;
            this.label1.Text = "Brand:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Freestyle Script", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(65, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 37);
            this.label2.TabIndex = 38;
            this.label2.Text = "Category:";
            // 
            // satis
            // 
            this.satis.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.satis.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.satis.ForeColor = System.Drawing.Color.White;
            this.satis.Location = new System.Drawing.Point(181, 403);
            this.satis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.satis.Name = "satis";
            this.satis.Size = new System.Drawing.Size(226, 32);
            this.satis.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Freestyle Script", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(51, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 37);
            this.label3.TabIndex = 37;
            this.label3.Text = "Sale Price:";
            // 
            // alis
            // 
            this.alis.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.alis.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alis.ForeColor = System.Drawing.Color.White;
            this.alis.Location = new System.Drawing.Point(181, 364);
            this.alis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.alis.Name = "alis";
            this.alis.Size = new System.Drawing.Size(226, 32);
            this.alis.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Freestyle Script", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(9, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 37);
            this.label4.TabIndex = 35;
            this.label4.Text = "Purchase Price:";
            // 
            // miktar
            // 
            this.miktar.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.miktar.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miktar.ForeColor = System.Drawing.Color.White;
            this.miktar.Location = new System.Drawing.Point(181, 325);
            this.miktar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.miktar.Name = "miktar";
            this.miktar.Size = new System.Drawing.Size(226, 32);
            this.miktar.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Freestyle Script", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkGreen;
            this.label8.Location = new System.Drawing.Point(74, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 37);
            this.label8.TabIndex = 33;
            this.label8.Text = "Quantity:";
            // 
            // ad
            // 
            this.ad.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ad.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ad.ForeColor = System.Drawing.Color.White;
            this.ad.Location = new System.Drawing.Point(181, 286);
            this.ad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(226, 32);
            this.ad.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Freestyle Script", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkGreen;
            this.label13.Location = new System.Drawing.Point(21, 280);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(154, 37);
            this.label13.TabIndex = 31;
            this.label13.Text = "Product Name:";
            // 
            // barkod
            // 
            this.barkod.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.barkod.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barkod.ForeColor = System.Drawing.Color.White;
            this.barkod.Location = new System.Drawing.Point(181, 170);
            this.barkod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barkod.Name = "barkod";
            this.barkod.Size = new System.Drawing.Size(226, 32);
            this.barkod.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Freestyle Script", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkGreen;
            this.label14.Location = new System.Drawing.Point(42, 166);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 37);
            this.label14.TabIndex = 29;
            this.label14.Text = "Barcode No:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(493, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(513, 348);
            this.dataGridView1.TabIndex = 44;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // BtnUrunEkle
            // 
            this.BtnUrunEkle.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnUrunEkle.Font = new System.Drawing.Font("Freestyle Script", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUrunEkle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnUrunEkle.Location = new System.Drawing.Point(866, 550);
            this.BtnUrunEkle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnUrunEkle.Name = "BtnUrunEkle";
            this.BtnUrunEkle.Size = new System.Drawing.Size(140, 55);
            this.BtnUrunEkle.TabIndex = 45;
            this.BtnUrunEkle.Text = "Delete";
            this.BtnUrunEkle.UseVisualStyleBackColor = false;
            this.BtnUrunEkle.Click += new System.EventHandler(this.BtnUrunEkle_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox1.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(727, 157);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 32);
            this.textBox1.TabIndex = 46;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Freestyle Script", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(507, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 37);
            this.label5.TabIndex = 47;
            this.label5.Text = "Barcode No Search:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Freestyle Script", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(16, 3);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(452, 144);
            this.button1.TabIndex = 48;
            this.button1.Text = "Product Listing";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(493, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(771, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(211, 134);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            // 
            // Marka
            // 
            this.Marka.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Marka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Marka.ForeColor = System.Drawing.Color.DarkGreen;
            this.Marka.FormattingEnabled = true;
            this.Marka.Location = new System.Drawing.Point(181, 248);
            this.Marka.Name = "Marka";
            this.Marka.Size = new System.Drawing.Size(226, 33);
            this.Marka.TabIndex = 52;
            // 
            // Kategori
            // 
            this.Kategori.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Kategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kategori.ForeColor = System.Drawing.Color.DarkGreen;
            this.Kategori.FormattingEnabled = true;
            this.Kategori.Location = new System.Drawing.Point(181, 209);
            this.Kategori.Name = "Kategori";
            this.Kategori.Size = new System.Drawing.Size(226, 33);
            this.Kategori.TabIndex = 51;
            this.Kategori.SelectedIndexChanged += new System.EventHandler(this.Kategori_SelectedIndexChanged);
            // 
            // FrmUrunisteleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1047, 620);
            this.Controls.Add(this.Marka);
            this.Controls.Add(this.Kategori);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnUrunEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LblMiktar);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.satis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.alis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.miktar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.barkod);
            this.Controls.Add(this.label14);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUrunisteleme";
            this.Text = "PRODUCT LISTING";
            this.Load += new System.EventHandler(this.FrmUrunisteleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMiktar;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox satis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox alis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox miktar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox barkod;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnUrunEkle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox Marka;
        private System.Windows.Forms.ComboBox Kategori;
    }
}