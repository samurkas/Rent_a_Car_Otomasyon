using System;
using System.Windows.Forms;

namespace Samur_Rent_a_Car
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            if (UserSession.IsAdmin)
            {
                this.Text = "Ana Form - Yönetici: " + UserSession.KullaniciAdi;
            }
            else
            {
                this.Text = "Ana Form - Kullanıcı: " + UserSession.KullaniciAdi;
            }
            
            btn_kullaniciler.Enabled = true;
            btn_kullaniciler.Visible = true;
            btn_arac_ve_musteri.Enabled = true;
            btn_arac_ve_musteri.Visible = true;
        }

        private void btn_araclar_Click(object sender, EventArgs e)
        {
            Araclar araclarFormu = new Araclar();
            araclarFormu.ShowDialog();
        }

        private void btn_kullaniciler_Click(object sender, EventArgs e)
        {
            if (!UserSession.IsAdmin)
            {
                MessageBox.Show("Bu sayfaya erişmek için yönetici izni gereklidir!", "Yetki Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            Kullaniciler kullanicilarFormu = new Kullaniciler();
            kullanicilarFormu.ShowDialog();
        }

        private void btn_arac_ve_musteri_Click(object sender, EventArgs e)
        {
            if (!UserSession.IsAdmin)
            {
                MessageBox.Show("Bu sayfaya erişmek için yönetici izni gereklidir!", "Yetki Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            istatistikler istatistikler = new istatistikler();
            istatistikler.ShowDialog();
        }

        private void btn_musteriler_Click(object sender, EventArgs e)
        {
            iletisim_ve_yardım musterilerFormu = new iletisim_ve_yardım();
            musterilerFormu.ShowDialog();
        }
    }
}
