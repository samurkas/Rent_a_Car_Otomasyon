using System;
using System.Drawing;
using System.Windows.Forms;

namespace Samur_Rent_a_Car
{
    public partial class istatistikler : Form
    {
        public istatistikler()
        {
            InitializeComponent();
            this.Load += Istatistikler_Load;
        }

        private void Istatistikler_Load(object sender, EventArgs e)
        {
            LoadVehicleStats();
            LoadUserStats();
        }

        private void LoadVehicleStats()
        {
            using (var conn = VeriTabani.GetConnection())
            {
                conn.Open();
                string query = "SELECT Arac_Cesidi, COUNT(*) as KiralamaSayisi FROM Kiralama GROUP BY Arac_Cesidi ORDER BY KiralamaSayisi DESC";
                using (var cmd = new System.Data.SQLite.SQLiteCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        chartAraclar.Series["Kiralanma Sayısı"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                        chartAraclar.Series["Kiralanma Sayısı"].Points.Clear();
                        chartAraclar.Titles.Clear();
                        chartAraclar.Titles.Add("Araç Tipine Göre Kiralama Yoğunluğu");

                        Color[] renkler = new Color[] 
                        { 
                            Color.FromArgb(255, 99, 132),
                            Color.FromArgb(54, 162, 235),
                            Color.FromArgb(255, 206, 86),
                            Color.FromArgb(75, 192, 192)
                        };

                        int renkIndex = 0;
                        while (reader.Read())
                        {
                            string aracTipi = reader["Arac_Cesidi"] != DBNull.Value ? reader["Arac_Cesidi"].ToString() : "Belirsiz";
                            int count = Convert.ToInt32(reader["KiralamaSayisi"]);
                                
                            int pointIndex = chartAraclar.Series["Kiralanma Sayısı"].Points.AddXY(aracTipi, count);
                                
                            if (renkIndex < renkler.Length)
                            {
                                chartAraclar.Series["Kiralanma Sayısı"].Points[pointIndex].Color = renkler[renkIndex];
                            }
                                
                            chartAraclar.Series["Kiralanma Sayısı"].Points[pointIndex].Label = "#PERCENT{P1}";
                            chartAraclar.Series["Kiralanma Sayısı"].Points[pointIndex].LegendText = aracTipi + " (#VALX: #VAL)";
                                
                            renkIndex++;
                        }
                    }
                }
            }
        }

        private void LoadUserStats()
        {
            using (var conn = VeriTabani.GetConnection())
            {
                conn.Open();
                    
                string query = "SELECT Ad || ' ' || Soyad as AdSoyad, COUNT(*) as KiralamaSayisi FROM Kiralama GROUP BY Tc_Kimlik, Ad, Soyad ORDER BY KiralamaSayisi DESC";
                using (var cmd = new System.Data.SQLite.SQLiteCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        chartKullanicilar.Series["Kiralama Sayısı"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                        chartKullanicilar.Series["Kiralama Sayısı"].Points.Clear();
                        chartKullanicilar.Titles.Clear();
                        chartKullanicilar.Titles.Add("Kullanıcı Kiralama Sayıları");

                        chartKullanicilar.Series["Kiralama Sayısı"].Color = Color.FromArgb(54, 162, 235);
                        chartKullanicilar.Series["Kiralama Sayısı"]["PointWidth"] = "0.6";

                        while (reader.Read())
                        {
                            string adSoyad = reader["AdSoyad"] != DBNull.Value ? reader["AdSoyad"].ToString() : "Bilinmeyen Kullanıcı";
                            int count = Convert.ToInt32(reader["KiralamaSayisi"]);
                                
                            int pointIndex = chartKullanicilar.Series["Kiralama Sayısı"].Points.AddXY(adSoyad, count);
                                
                            chartKullanicilar.Series["Kiralama Sayısı"].Points[pointIndex].Label = count.ToString();
                        }

                        chartKullanicilar.ChartAreas[0].AxisY.Title = "Kiralanan araÇ";
                        chartKullanicilar.ChartAreas[0].AxisX.Title = "kİRALAYANLAR";
                        chartKullanicilar.ChartAreas[0].AxisX.Interval = 1;
                        chartKullanicilar.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
                        chartKullanicilar.ChartAreas[0].AxisX.LabelStyle.IsEndLabelVisible = true;
                    }
                }
            }
        }
        
        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chartAraclar_Click(object sender, EventArgs e)
        {

        }
    }
}
