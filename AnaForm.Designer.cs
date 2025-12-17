namespace Samur_Rent_a_Car
{
    partial class AnaForm
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
            this.btn_araclar = new System.Windows.Forms.Button();
            this.btn_kullaniciler = new System.Windows.Forms.Button();
            this.btn_musteriler = new System.Windows.Forms.Button();
            this.btn_arac_ve_musteri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_araclar
            // 
            this.btn_araclar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_araclar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_araclar.ForeColor = System.Drawing.Color.Black;
            this.btn_araclar.Location = new System.Drawing.Point(142, 48);
            this.btn_araclar.Name = "btn_araclar";
            this.btn_araclar.Size = new System.Drawing.Size(638, 157);
            this.btn_araclar.TabIndex = 0;
            this.btn_araclar.Text = "Araçlar ve Kiralama ";
            this.btn_araclar.UseVisualStyleBackColor = false;
            this.btn_araclar.Click += new System.EventHandler(this.btn_araclar_Click);
            // 
            // btn_kullaniciler
            // 
            this.btn_kullaniciler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_kullaniciler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kullaniciler.ForeColor = System.Drawing.Color.Black;
            this.btn_kullaniciler.Location = new System.Drawing.Point(142, 228);
            this.btn_kullaniciler.Name = "btn_kullaniciler";
            this.btn_kullaniciler.Size = new System.Drawing.Size(638, 128);
            this.btn_kullaniciler.TabIndex = 1;
            this.btn_kullaniciler.Text = "Kullanıcılar";
            this.btn_kullaniciler.UseVisualStyleBackColor = false;
            this.btn_kullaniciler.Click += new System.EventHandler(this.btn_kullaniciler_Click);
            // 
            // btn_musteriler
            // 
            this.btn_musteriler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_musteriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_musteriler.ForeColor = System.Drawing.Color.Black;
            this.btn_musteriler.Location = new System.Drawing.Point(142, 530);
            this.btn_musteriler.Name = "btn_musteriler";
            this.btn_musteriler.Size = new System.Drawing.Size(642, 128);
            this.btn_musteriler.TabIndex = 0;
            this.btn_musteriler.Text = "İletişim Ve Yardım ";
            this.btn_musteriler.UseVisualStyleBackColor = false;
            this.btn_musteriler.Click += new System.EventHandler(this.btn_musteriler_Click);
            // 
            // btn_arac_ve_musteri
            // 
            this.btn_arac_ve_musteri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_arac_ve_musteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_arac_ve_musteri.ForeColor = System.Drawing.Color.Black;
            this.btn_arac_ve_musteri.Location = new System.Drawing.Point(142, 376);
            this.btn_arac_ve_musteri.Name = "btn_arac_ve_musteri";
            this.btn_arac_ve_musteri.Size = new System.Drawing.Size(638, 128);
            this.btn_arac_ve_musteri.TabIndex = 1;
            this.btn_arac_ve_musteri.Text = "İstatistikler";
            this.btn_arac_ve_musteri.UseVisualStyleBackColor = false;
            this.btn_arac_ve_musteri.Click += new System.EventHandler(this.btn_arac_ve_musteri_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(882, 753);
            this.Controls.Add(this.btn_arac_ve_musteri);
            this.Controls.Add(this.btn_kullaniciler);
            this.Controls.Add(this.btn_musteriler);
            this.Controls.Add(this.btn_araclar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(900, 800);
            this.MinimumSize = new System.Drawing.Size(900, 800);
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Araç Kiralama  ";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_araclar;
        private System.Windows.Forms.Button btn_kullaniciler;
        private System.Windows.Forms.Button btn_musteriler;
        private System.Windows.Forms.Button btn_arac_ve_musteri;
    }
}