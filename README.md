# 🚗 Samur Rent a Car - Araç Kiralama Yönetim Sistemi

Modern ve kullanıcı dostu bir **Araç Kiralama Yönetim Sistemi**. Windows Forms ve SQLite teknolojileri kullanılarak geliştirilmiş, tam özellikli bir masaüstü uygulaması.

## 📋 İçindekiler

- [Özellikler](#-özellikler)
- [Teknolojiler](#-teknolojiler)
- [Kurulum](#-kurulum)
- [Kullanım](#-kullanım)
- [Veritabanı Yapısı](#-veritabanı-yapısı)
- [Proje Yapısı](#-proje-yapısı)
- [Admin Girişi](#-admin-girişi)
- [Ekran Görüntüleri](#-ekran-görüntüleri)
- [Katkıda Bulunma](#-katkıda-bulunma)
- [Lisans](#-lisans)

## ✨ Özellikler

### 👤 Kullanıcı Yönetimi
- Kullanıcı kayıt ve giriş sistemi
- TC Kimlik doğrulama
- Kullanıcı profil bilgileri yönetimi
- Admin ve normal kullanıcı rolleri

### 🚙 Araç Yönetimi
- Farklı araç tipleri desteği (Otomobil, Motosiklet, Bisiklet, Kamyon)
- Araç kiralama işlemleri
- Plaka ve araç bilgileri yönetimi
- Kiralama tarihi ve ücret hesaplama

### 📊 İstatistikler ve Raporlama
- Araç tipi bazında kiralama istatistikleri (Pasta grafik)
- Kullanıcı bazında kiralama raporları (Sütun grafik)
- Görsel veri analizi
- Kiralama yoğunluğu takibi

### 💼 Diğer Özellikler
- İletişim ve yardım sayfası
- Modern ve kullanıcı dostu arayüz
- Veritabanı otomatik oluşturma
- SQLite ile hafif ve hızlı veri yönetimi

## 🛠 Teknolojiler

- **Dil:** C# (.NET Framework 4.7.2)
- **UI Framework:** Windows Forms
- **Veritabanı:** SQLite 3
- **Grafik/Chart:** System.Windows.Forms.DataVisualization.Charting
- **NuGet Paketleri:**
  - System.Data.SQLite.Core v1.0.119.0
  - System.Memory v4.5.5
  - System.Runtime.CompilerServices.Unsafe v6.0.0
  - System.Resources.Extensions v6.0.0

## 📥 Kurulum

### Gereksinimler
- Windows 7 veya üzeri
- .NET Framework 4.7.2 veya üzeri
- Visual Studio 2019 veya üzeri (geliştirme için)

### Adımlar

1. **Projeyi klonlayın:**
```bash
git clone https://github.com/kullaniciadi/Samur_Rent_a_Car.git
cd Samur_Rent_a_Car
```

2. **Visual Studio ile açın:**
   - `Samur_Rent_a_Car.slnx` dosyasını Visual Studio ile açın
   - Veya `Samur_Rent_a_Car.csproj` dosyasını açın

3. **NuGet paketlerini geri yükleyin:**
   - Visual Studio otomatik olarak gerekli paketleri yükleyecektir
   - Manuel olarak: `Tools > NuGet Package Manager > Restore NuGet Packages`

4. **Projeyi derleyin:**
   - `Build > Build Solution` (Ctrl+Shift+B)

5. **Uygulamayı çalıştırın:**
   - `Debug > Start Debugging` (F5)

### Direkt Çalıştırma
Derlenmiş sürümü kullanmak için:
1. `bin\Debug\Samur_Rent_a_Car.exe` dosyasını çalıştırın
2. Veritabanı otomatik olarak oluşturulacaktır

## 🎯 Kullanım

### İlk Çalıştırma
- Uygulama ilk açıldığında SQLite veritabanı otomatik olarak oluşturulur
- Varsayılan admin hesabı otomatik olarak eklenir

### Giriş Yapma
1. Uygulama açıldığında giriş ekranı görünür
2. Kullanıcı adı ve şifrenizi girin
3. "Giriş Yap" butonuna tıklayın
4. Yeni kullanıcılar "Kayıt Ol" butonunu kullanabilir

### Araç Kiralama
1. Ana menüden "Araçlar" seçeneğini seçin
2. Kiralamak istediğiniz araç tipini seçin
3. Kiralama bilgilerini doldurun (Plaka, Tarih, Ücret vb.)
4. "Kirala" butonuna tıklayın

### İstatistikleri Görüntüleme
1. Ana menüden "İstatistikler" seçeneğini seçin
2. Araç tipi bazında kiralama yoğunluğunu görün (Pasta grafik)
3. Kullanıcı bazında kiralama sayılarını görün (Sütun grafik)

## 🗄 Veritabanı Yapısı

### Kullaniciler Tablosu
| Sütun | Tip | Açıklama |
|-------|-----|----------|
| Id | INTEGER | Primary Key, Auto Increment |
| Tc_Kimlik | TEXT | TC Kimlik No |
| Ad | TEXT | Kullanıcı Adı |
| Soyad | TEXT | Kullanıcı Soyadı |
| Kullanici_Adi | TEXT | Kullanıcı Adı (Login) |
| Parola | TEXT | Şifre |
| Cinsiyet | TEXT | Cinsiyet |
| Tel | TEXT | Telefon |
| Mail | TEXT | E-posta |
| Dogum_Tarihi | TEXT | Doğum Tarihi |
| Kayit_Tarihi | TEXT | Kayıt Tarihi |
| Aciklama | TEXT | Açıklama |
| Admin | INTEGER | Admin Yetkisi (0/1) |

### Kiralama Tablosu
| Sütun | Tip | Açıklama |
|-------|-----|----------|
| Id | INTEGER | Primary Key, Auto Increment |
| Tc_Kimlik | TEXT | Kiralayan TC No |
| Ad | TEXT | Kiralayan Adı |
| Soyad | TEXT | Kiralayan Soyadı |
| Kullanici_Adi | TEXT | Kullanıcı Adı |
| Plaka | TEXT | Araç Plakası |
| Arac_Cesidi | TEXT | Araç Tipi |
| Tel | TEXT | Telefon |
| Ucret | TEXT | Kiralama Ücreti |
| Alis_Tarihi | TEXT | Kiralama Başlangıç |
| Teslim_Tarihi | TEXT | Kiralama Bitiş |

## 📁 Proje Yapısı

```
Samur_Rent_a_Car/
├── AnaForm.cs                 # Ana form
├── Araclar.cs                 # Araç yönetimi formu
├── Form1.cs                   # Giriş formu
├── kayıt_ol.cs               # Kayıt formu
├── Kullaniciler.cs           # Kullanıcı yönetimi
├── istatistikler.cs          # İstatistik grafikleri
├── iletisim_ve_yardım.cs    # İletişim formu
├── VeriTabani.cs             # Veritabanı yönetimi
├── Program.cs                # Ana program
├── RESİMLER/                 # Araç görselleri
│   ├── otomobil.png
│   ├── motosiklet.jpg
│   ├── bisiklet.jpg
│   ├── kamyon.jpg
│   └── LOGO.png
├── bin/Debug/                # Derlenmiş dosyalar
│   └── SamurRentACar.db     # SQLite veritabanı
└── README.md                 # Bu dosya
```

## 🔐 Admin Girişi

Varsayılan admin hesabı otomatik olarak oluşturulur:

- **Kullanıcı Adı:** `admin`
- **Şifre:** `123`
- **TC Kimlik:** `12218838160`

> ⚠️ **Güvenlik Uyarısı:** Üretim ortamında mutlaka admin şifresini değiştirin!

## 📸 Ekran Görüntüleri

_Ekran görüntüleri eklenecek_

## 👨‍💻 Geliştirici

- **İsmail SAMURKAŞ**
- E-posta: ismail@samurrentacar.com

## 🤝 Katkıda Bulunma

Katkıda bulunmak isterseniz:

1. Bu depoyu fork edin
2. Yeni bir branch oluşturun (`git checkout -b feature/yeniOzellik`)
3. Değişikliklerinizi commit edin (`git commit -am 'Yeni özellik eklendi'`)
4. Branch'inizi push edin (`git push origin feature/yeniOzellik`)
5. Pull Request oluşturun

## 📝 Lisans

Bu proje [MIT Lisansı](LICENSE) altında lisanslanmıştır.

## 📞 İletişim ve Destek

Sorularınız veya önerileriniz için:
- **GitHub Issues:** Proje sayfasından issue açabilirsiniz
- **E-posta:** ismail@samurrentacar.com

---

⭐ Bu projeyi beğendiyseniz yıldız vermeyi unutmayın!

**Geliştirme Tarihi:** 2025  
**Versiyon:** 1.0.0
