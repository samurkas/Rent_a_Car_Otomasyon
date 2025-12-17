namespace Samur_Rent_a_Car
{
    partial class istatistikler
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartAraclar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartKullanicilar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnGeriDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartAraclar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartKullanicilar)).BeginInit();
            this.SuspendLayout();
            // 
            // chartAraclar
            // 
            chartArea1.Name = "ChartArea1";
            this.chartAraclar.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartAraclar.Legends.Add(legend1);
            this.chartAraclar.Location = new System.Drawing.Point(21, 40);
            this.chartAraclar.Name = "chartAraclar";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Kiralanma Sayısı";
            this.chartAraclar.Series.Add(series1);
            this.chartAraclar.Size = new System.Drawing.Size(900, 350);
            this.chartAraclar.TabIndex = 0;
            this.chartAraclar.Text = "Araç Tipi Kiralama İstatistikleri";
            this.chartAraclar.Click += new System.EventHandler(this.chartAraclar_Click);
            // 
            // chartKullanicilar
            // 
            chartArea2.Name = "ChartArea1";
            this.chartKullanicilar.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartKullanicilar.Legends.Add(legend2);
            this.chartKullanicilar.Location = new System.Drawing.Point(40, 420);
            this.chartKullanicilar.Name = "chartKullanicilar";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Kiralama Sayısı";
            this.chartKullanicilar.Series.Add(series2);
            this.chartKullanicilar.Size = new System.Drawing.Size(900, 350);
            this.chartKullanicilar.TabIndex = 1;
            this.chartKullanicilar.Text = "Kullanıcı Kiralama İstatistikleri";
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.BackColor = System.Drawing.Color.Red;
            this.btnGeriDon.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeriDon.ForeColor = System.Drawing.Color.White;
            this.btnGeriDon.Location = new System.Drawing.Point(11, 0);
            this.btnGeriDon.Margin = new System.Windows.Forms.Padding(2);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(196, 35);
            this.btnGeriDon.TabIndex = 2;
            this.btnGeriDon.Text = "← Geri Dön";
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // istatistikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(980, 800);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.chartKullanicilar);
            this.Controls.Add(this.chartAraclar);
            this.Name = "istatistikler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "İstatistikler";
            ((System.ComponentModel.ISupportInitialize)(this.chartAraclar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartKullanicilar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartAraclar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartKullanicilar;
        private System.Windows.Forms.Button btnGeriDon;
    }
}