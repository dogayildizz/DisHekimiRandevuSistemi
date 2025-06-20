# 🦷 Diş Hekimi Randevu Yönetim Sistemi

## 📌 Proje Amacı
Bu proje, bir diş hekiminin hastalarıyla olan randevu süreçlerini çevrimiçi olarak yönetmesini sağlayan bir web uygulamasıdır.  
ASP.NET Core MVC teknolojisi kullanılarak geliştirilmiştir ve gerçek bir kurumsal senaryoya uygun şekilde tasarlanmıştır.  

## 👥 Kullanıcı Rollerimiz
- **Diş Hekimi (Doctor)**: Gelen randevu taleplerini yönetir (onaylar / reddeder), randevu listesini görür.
- **Hasta (Patient)**: Randevu talebi oluşturur, kendi taleplerinin durumunu takip eder.  

## ⚙️ Temel Özellikler
- Hasta randevu talep edebilir (tarih ve saat seçerek).
- Doktor talepleri listeleyip onaylayabilir veya reddedebilir.
- Rol bazlı sayfa erişimi (Hasta ve Doktor için farklı sayfalar ve layout).
- Geçmiş ve gelecek randevuların takibi.
- Form validasyonları (ör. ileri tarih seçimi zorunluluğu).
- Basit kullanıcı girişi (tek bir login ekranından doktor/hasta ayrımı).

## 🏗 Kullanılan Teknolojiler ve Yapılar
- **ASP.NET Core MVC**
- **Entity Framework Core**
- **Dependency Injection (DI)**
- **Razor View Engine ve TagHelpers**
- **Partial Views ve ViewComponents**
- **Session ve Cookie Yönetimi**
- **Custom Middleware**
- **Action Filters**
- **Data Annotations ile Validations**


