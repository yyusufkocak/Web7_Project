
namespace WithClassSql_Crud2
{
    partial class FormRandevu
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
            this.cmbBolumler = new System.Windows.Forms.ComboBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHastalar = new System.Windows.Forms.TextBox();
            this.dgvHastalar = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lstDoktorlar = new System.Windows.Forms.ListBox();
            this.lblDoktor = new System.Windows.Forms.Label();
            this.btnRandevu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHastalar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bölüm";
            // 
            // cmbBolumler
            // 
            this.cmbBolumler.FormattingEnabled = true;
            this.cmbBolumler.Location = new System.Drawing.Point(53, 28);
            this.cmbBolumler.Name = "cmbBolumler";
            this.cmbBolumler.Size = new System.Drawing.Size(121, 21);
            this.cmbBolumler.TabIndex = 1;
            this.cmbBolumler.SelectedIndexChanged += new System.EventHandler(this.cmbBolumler_SelectedIndexChanged);
            // 
            // dtpTarih
            // 
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Location = new System.Drawing.Point(234, 24);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(121, 20);
            this.dtpTarih.TabIndex = 2;
            this.dtpTarih.ValueChanged += new System.EventHandler(this.dtpTarih_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tarih";
            // 
            // txtHastalar
            // 
            this.txtHastalar.Location = new System.Drawing.Point(53, 65);
            this.txtHastalar.Name = "txtHastalar";
            this.txtHastalar.Size = new System.Drawing.Size(121, 20);
            this.txtHastalar.TabIndex = 4;
            // 
            // dgvHastalar
            // 
            this.dgvHastalar.AllowUserToAddRows = false;
            this.dgvHastalar.AllowUserToDeleteRows = false;
            this.dgvHastalar.AllowUserToResizeColumns = false;
            this.dgvHastalar.AllowUserToResizeRows = false;
            this.dgvHastalar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHastalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHastalar.Location = new System.Drawing.Point(15, 114);
            this.dgvHastalar.Name = "dgvHastalar";
            this.dgvHastalar.Size = new System.Drawing.Size(159, 238);
            this.dgvHastalar.TabIndex = 5;
            this.dgvHastalar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hasta";
            // 
            // lstDoktorlar
            // 
            this.lstDoktorlar.FormattingEnabled = true;
            this.lstDoktorlar.Location = new System.Drawing.Point(209, 114);
            this.lstDoktorlar.Name = "lstDoktorlar";
            this.lstDoktorlar.Size = new System.Drawing.Size(146, 238);
            this.lstDoktorlar.TabIndex = 7;
            // 
            // lblDoktor
            // 
            this.lblDoktor.AutoSize = true;
            this.lblDoktor.Location = new System.Drawing.Point(193, 72);
            this.lblDoktor.Name = "lblDoktor";
            this.lblDoktor.Size = new System.Drawing.Size(39, 13);
            this.lblDoktor.TabIndex = 8;
            this.lblDoktor.Text = "Doktor";
            // 
            // btnRandevu
            // 
            this.btnRandevu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRandevu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRandevu.Location = new System.Drawing.Point(0, 358);
            this.btnRandevu.Name = "btnRandevu";
            this.btnRandevu.Size = new System.Drawing.Size(457, 92);
            this.btnRandevu.TabIndex = 9;
            this.btnRandevu.Text = "Randevu Oluştur";
            this.btnRandevu.UseVisualStyleBackColor = true;
            this.btnRandevu.Click += new System.EventHandler(this.btnRandevu_Click);
            // 
            // FormRandevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 450);
            this.Controls.Add(this.btnRandevu);
            this.Controls.Add(this.lblDoktor);
            this.Controls.Add(this.lstDoktorlar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvHastalar);
            this.Controls.Add(this.txtHastalar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.cmbBolumler);
            this.Controls.Add(this.label1);
            this.Name = "FormRandevu";
            this.Text = "FormRandevu";
            this.Load += new System.EventHandler(this.FormRandevu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHastalar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBolumler;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHastalar;
        private System.Windows.Forms.DataGridView dgvHastalar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstDoktorlar;
        private System.Windows.Forms.Label lblDoktor;
        private System.Windows.Forms.Button btnRandevu;
    }
}