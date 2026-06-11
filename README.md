# ASP.NET Core MVC

ASP.NET Core MVC öğrenme ve örnek uygulama projelerini içeren .NET çözüm koleksiyonu.

## Bu Repo Ne İçin Var?
ASP.NET Core MVC mimarisini örnek projeler üzerinden öğrenmek ve farklı uygulama yapılarını karşılaştırmak için oluşturuldu.

Bu README'nin amacı; repoya ilk kez gelen birinin projenin neden açıldığını, içinde ne bulunduğunu ve nereden başlaması gerektiğini hızlıca anlamasını sağlamaktır.

## İçerik ve Kapsam
Bu repoda öne çıkan içerikler şunlardır:
- Birden fazla .NET solution/proje klasörü
- MVC ve temel web geliştirme pratikleri
- BTK Akademi çalışmaları için düzenli arşiv
- .NET solution/proje dosyaları ve katmanlı uygulama yapısı

## Kimler İçin Faydalı?
Frontend/web geliştirme pratiği yapmak, arayüz yapısını incelemek veya projeyi kişiselleştirmek isteyenler için uygundur.

## Kullanılan Teknolojiler
- HTML
- .NET
- C#
- CSS

## Kurulum
```bash
dotnet restore "ASP.Net8.sln"
```

## Çalıştırma
```bash
dotnet build "ASP.Net8.sln"
```

## Önemli Dosyalar
- `ASP.Net8.sln`
- `Basics/Basics.csproj`
- `BtkAkademiMvcGiris/BtkAkademiMvcGiris.csproj`
- `Store/Store.sln`
- `Store/StoreApp/StoreApp.csproj`

## Proje Yapısı
- `Basics` - 123 dosya
- `BtkAkademiMvcGiris` - 82 dosya
- `Store` - 7 dosya
- `.vscode` - 1 dosya
- `ASP.Net8.sln` - 1 dosya
- `version` - 1 dosya

## Geliştirme Notları
- README içeriği, repodaki mevcut dosya yapısı ve proje açıklamasına göre düzenlenmiştir.
- Yeni modül, veri seti veya servis eklendiğinde kurulum/çalıştırma bölümlerini güncelleyin.
- .NET projelerinde solution yapısı değişirse `dotnet restore` ve `dotnet build` adımlarını yeniden doğrulayın.

## Lisans
Bu repoda açık bir lisans dosyası yoksa tüm haklar varsayılan olarak proje sahibine aittir. Paylaşım veya kullanım koşulları için repo sahibine danışın.
