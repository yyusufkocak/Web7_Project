
namespace OOP_01
{
    partial class KalitimOrnek
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
            this.dgvSepet = new System.Windows.Forms.DataGridView();
            this.UrunAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KDVHaricFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KDVDahilFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTekstil = new System.Windows.Forms.Button();
            this.btnCepTelefonu = new System.Windows.Forms.Button();
            this.btnEkmek = new System.Windows.Forms.Button();
            this.lblToplam = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSepet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSepet
            // 
            this.dgvSepet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSepet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UrunAd,
            this.KDVHaricFiyat,
            this.KDVDahilFiyat});
            this.dgvSepet.Location = new System.Drawing.Point(12, 12);
            this.dgvSepet.Name = "dgvSepet";
            this.dgvSepet.Size = new System.Drawing.Size(344, 235);
            this.dgvSepet.TabIndex = 0;
            // 
            // UrunAd
            // 
            this.UrunAd.HeaderText = "Ürün Adı";
            this.UrunAd.Name = "UrunAd";
            // 
            // KDVHaricFiyat
            // 
            this.KDVHaricFiyat.HeaderText = "KDV Hariç Fiyatı";
            this.KDVHaricFiyat.Name = "KDVHaricFiyat";
            // 
            // KDVDahilFiyat
            // 
            this.KDVDahilFiyat.HeaderText = "KDV Dahil Fiyatı";
            this.KDVDahilFiyat.Name = "KDVDahilFiyat";
            // 
            // btnTekstil
            // 
            this.btnTekstil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTekstil.Location = new System.Drawing.Point(426, 12);
            this.btnTekstil.Name = "btnTekstil";
            this.btnTekstil.Size = new System.Drawing.Size(140, 58);
            this.btnTekstil.TabIndex = 1;
            this.btnTekstil.Text = "Tekstil";
            this.btnTekstil.UseVisualStyleBackColor = true;
            this.btnTekstil.Click += new System.EventHandler(this.btnTekstil_Click);
            // 
            // btnCepTelefonu
            // 
            this.btnCepTelefonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCepTelefonu.Location = new System.Drawing.Point(426, 101);
            this.btnCepTelefonu.Name = "btnCepTelefonu";
            this.btnCepTelefonu.Size = new System.Drawing.Size(140, 58);
            this.btnCepTelefonu.TabIndex = 1;
            this.btnCepTelefonu.Text = "Cep Telefonu";
            this.btnCepTelefonu.UseVisualStyleBackColor = true;
            this.btnCepTelefonu.Click += new System.EventHandler(this.btnCepTelefonu_Click);
            // 
            // btnEkmek
            // 
            this.btnEkmek.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkmek.Location = new System.Drawing.Point(426, 189);
            this.btnEkmek.Name = "btnEkmek";
            this.btnEkmek.Size = new System.Drawing.Size(140, 58);
            this.btnEkmek.TabIndex = 1;
            this.btnEkmek.Text = "Ekmek";
            this.btnEkmek.UseVisualStyleBackColor = true;
            this.btnEkmek.Click += new System.EventHandler(this.btnEkmek_Click);
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Location = new System.Drawing.Point(321, 309);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(42, 13);
            this.lblToplam.TabIndex = 2;
            this.lblToplam.Text = "Toplam";
            // 
            // KalitimOrnek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.btnEkmek);
            this.Controls.Add(this.btnCepTelefonu);
            this.Controls.Add(this.btnTekstil);
            this.Controls.Add(this.dgvSepet);
            this.Name = "KalitimOrnek";
            this.Text = "KalitimOrnek";
            this.Load += new System.EventHandler(this.KalitimOrnek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSepet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSepet;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn KDVHaricFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn KDVDahilFiyat;
        private System.Windows.Forms.Button btnTekstil;
        private System.Windows.Forms.Button btnCepTelefonu;
        private System.Windows.Forms.Button btnEkmek;
        private System.Windows.Forms.Label lblToplam;
    }
}