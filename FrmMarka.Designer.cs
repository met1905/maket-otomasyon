namespace MarketOtomasyon
{
    partial class FrmMarka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMarka));
            this.BtnEkle = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.CmbKategori = new System.Windows.Forms.ComboBox();
            this.TxtMarka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnEkle
            // 
            this.BtnEkle.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnEkle.Font = new System.Drawing.Font("Freestyle Script", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEkle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnEkle.Location = new System.Drawing.Point(230, 111);
            this.BtnEkle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(140, 55);
            this.BtnEkle.TabIndex = 28;
            this.BtnEkle.Text = "Add";
            this.BtnEkle.UseVisualStyleBackColor = false;
            this.BtnEkle.Click += new System.EventHandler(this.button8_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Freestyle Script", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkGreen;
            this.label14.Location = new System.Drawing.Point(38, 64);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 37);
            this.label14.TabIndex = 27;
            this.label14.Text = "Brand Add:";
            // 
            // CmbKategori
            // 
            this.CmbKategori.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.CmbKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbKategori.ForeColor = System.Drawing.Color.DarkGreen;
            this.CmbKategori.FormattingEnabled = true;
            this.CmbKategori.Location = new System.Drawing.Point(167, 29);
            this.CmbKategori.Name = "CmbKategori";
            this.CmbKategori.Size = new System.Drawing.Size(203, 33);
            this.CmbKategori.TabIndex = 29;
            // 
            // TxtMarka
            // 
            this.TxtMarka.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TxtMarka.Font = new System.Drawing.Font("Freestyle Script", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMarka.ForeColor = System.Drawing.Color.DarkGreen;
            this.TxtMarka.Location = new System.Drawing.Point(167, 70);
            this.TxtMarka.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtMarka.Name = "TxtMarka";
            this.TxtMarka.Size = new System.Drawing.Size(203, 33);
            this.TxtMarka.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Freestyle Script", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(5, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 37);
            this.label1.TabIndex = 31;
            this.label1.Text = "Category Add:";
            // 
            // FrmMarka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 201);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtMarka);
            this.Controls.Add(this.CmbKategori);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.label14);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMarka";
            this.Text = "BRAND";
            this.Load += new System.EventHandler(this.FrmMarka_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox CmbKategori;
        private System.Windows.Forms.TextBox TxtMarka;
        private System.Windows.Forms.Label label1;
    }
}