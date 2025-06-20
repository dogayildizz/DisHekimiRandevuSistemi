# Diş Hekimi Randevu Yönetim Sistemi

## Proje Amacı
Bu proje, bir diş hekiminin hastalarıyla olan randevu süreçlerini çevrimiçi olarak yönetmesini sağlayan bir web uygulamasıdır.  
ASP.NET Core MVC teknolojisi ve **3 katmanlı mimari (UI, BLL, DAL)** kullanılarak geliştirilmiştir.  
Gerçek bir kurumsal senaryoya uygun, genişletilebilir ve sürdürülebilir bir yapı hedeflenmiştir.

## Kullanıcı Rollerimiz
- **Diş Hekimi (Doctor)**: Gelen randevu taleplerini yönetir (onaylar veya reddeder), randevu listesini görüntüler.
- **Hasta (Patient)**: Randevu talebi oluşturur ve kendi taleplerinin durumunu takip eder.

## Temel Özellikler
- Hasta, tarih ve saat seçerek randevu talebinde bulunabilir.
- Doktor, gelen talepleri listeleyip onaylayabilir veya reddedebilir.
- Rol bazlı sayfa erişimi (hasta ve doktor için farklı layout ve yetkilendirme).
- Geçmiş ve gelecek randevuların takibi.
- Form validasyonları (ör. ileri tarih seçimi zorunluluğu).
- Basit kullanıcı girişi (tek bir login ekranından doktor/hasta ayrımı).
- 3 Katmanlı Mimari:
  - **UI (Kullanıcı Arayüzü Katmanı)**: ASP.NET Core MVC Controller + View + Razor
  - **BLL (Business Logic Layer)**: İş kuralları ve servisler
  - **DAL (Data Access Layer)**: Entity Framework Core ile veri erişim işlemleri

## Kullanılan Teknolojiler ve Yapılar
- ASP.NET Core MVC
- Entity Framework Core
- 3 Katmanlı Mimari (UI / BLL / DAL)
- Dependency Injection (DI)
- Razor View Engine ve Tag Helpers
- Partial Views ve View Components
- Session ve Cookie Yönetimi
- Custom Middleware
- Action Filters
- Data Annotations ile Validation

