
namespace WithClassSql_Crud2
{
    partial class FormAna
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
            this.btnHastalar = new System.Windows.Forms.Button();
            this.btnBolumler = new System.Windows.Forms.Button();
            this.btnDoktorlar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHastalar
            // 
            this.btnHastalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHastalar.Location = new System.Drawing.Point(69, 33);
            this.btnHastalar.Name = "btnHastalar";
            this.btnHastalar.Size = new System.Drawing.Size(259, 59);
            this.btnHastalar.TabIndex = 0;
            this.btnHastalar.Text = "Hastalar";
            this.btnHastalar.UseVisualStyleBackColor = true;
            // 
            // btnBolumler
            // 
            this.btnBolumler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBolumler.Location = new System.Drawing.Point(69, 110);
            this.btnBolumler.Name = "btnBolumler";
            this.btnBolumler.Size = new System.Drawing.Size(259, 59);
            this.btnBolumler.TabIndex = 0;
            this.btnBolumler.Text = "Bölümler";
            this.btnBolumler.UseVisualStyleBackColor = true;
            // 
            // btnDoktorlar
            // 
            this.btnDoktorlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoktorlar.Location = new System.Drawing.Point(69, 186);
            this.btnDoktorlar.Name = "btnDoktorlar";
            this.btnDoktorlar.Size = new System.Drawing.Size(259, 59);
            this.btnDoktorlar.TabIndex = 0;
            this.btnDoktorlar.Text = "Doktorlar";
            this.btnDoktorlar.UseVisualStyleBackColor = true;
            // 
            // FormAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 297);
            this.Controls.Add(this.btnDoktorlar);
            this.Controls.Add(this.btnBolumler);
            this.Controls.Add(this.btnHastalar);
            this.Name = "FormAna";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHastalar;
        private System.Windows.Forms.Button btnBolumler;
        private System.Windows.Forms.Button btnDoktorlar;
    }
}

