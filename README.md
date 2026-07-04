# 🏥 Veteriner Kliniği Yönetim Sistemi

C# ve Windows Forms kullanılarak geliştirilmiş, veteriner kliniklerinin günlük operasyonlarını yönetmek için tasarlanmış masaüstü uygulaması.

## 🖥️ Uygulama Hakkında

Veteriner Kliniği Yönetim Sistemi; sahip kayıtları, hayvan takibi ve muayene geçmişi gibi klinik süreçlerini tek bir arayüzden yönetmenizi sağlar. N-Tier mimari ile geliştirilmiş olup katmanlı yapısı sayesinde sürdürülebilir ve genişletilebilir bir kod tabanına sahiptir.

## 🏗️ Proje Mimarisi
VeterinerKlinigi/
├── VeterinerKlinigi.Entities/      → Veri modelleri (Sahip, Hayvan, Muayene)
├── VeterinerKlinigi.DataAccess/    → Veritabanı işlemleri (DAL sınıfları, SqlHelper)
└── VeterinerKlinigi/               → Windows Forms arayüzü (Formlar, ThemeHelper)
## 🛠️ Kullanılan Teknolojiler

- **Dil:** C# / .NET 8
- **Arayüz:** Windows Forms
- **Veritabanı:** SQL Server LocalDB
- **Veri Erişimi:** ADO.NET
- **Mimari:** N-Tier (Entities, DataAccess, UI)

## 📦 Özellikler

- 👤 Sahip kaydı oluşturma, düzenleme ve silme
- 🐾 Hayvanlara ait detaylı profil ve geçmiş takibi
- 🩺 Muayene kaydı ekleme ve listeleme
- 🔍 Kayıtlar arasında arama ve filtreleme
- 💾 LocalDB ile kurulum gerektirmeyen taşınabilir veritabanı
- 📦 .msi Setup paketi ile tek tıkla kurulum

## 🚀 Kurulum

1. [Releases](../../releases) sayfasından `.msi` dosyasını indirin
2. Kurulum sihirbazını takip edin
3. Masaüstündeki kısayoldan uygulamayı başlatın
