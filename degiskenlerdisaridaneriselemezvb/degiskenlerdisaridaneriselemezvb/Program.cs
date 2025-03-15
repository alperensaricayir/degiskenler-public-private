/*
    📌 C# DİLİNDE ERİŞİM BELİRLEYİCİLER (ACCESS MODIFIERS)

    1) public:
        - Her yerden erişilebilir.
        - Gerçek Hayat Örneği: Bir banka şubesinin dışarıda bulunan müşteri hizmetleri numarası herkese açıktır.

    2) private:
        - Sadece tanımlandığı sınıf içinde erişilebilir.
        - Gerçek Hayat Örneği: Bir çalışanın kişisel şifresi sadece kendisine aittir, başkaları göremez.

    3) protected:
        - Sadece tanımlandığı sınıfta ve ondan türeyen (miras alan) sınıflarda erişilebilir.
        - Gerçek Hayat Örneği: Bir şirketin iç yazışmaları sadece çalışanları tarafından görülebilir, dışarıya kapalıdır.

    4) internal:
        - Aynı proje (assembly) içinde her yerden erişilebilir, ancak projeler arası erişim kapalıdır.
        - Gerçek Hayat Örneği: Bir şirket içi telefon rehberi sadece çalışanlar arasında kullanılabilir.

    📌 NESNE YÖNELİMLİ PROGRAMLAMADA (OOP) ERİŞİM BELİRLEYİCİLERİN ROLÜ:
        - Veriyi korur (encapsulation / kapsülleme).
        - Gereksiz veya tehlikeli veri erişimini engeller.
        - Karmaşık yapıları basitleştirir, sadece gereken kısımlara erişim sağlar.
*/
using System;

namespace ErisimBelirleyicilerVeDegiskenler
{
    // User (Kullanıcı) sınıfını oluşturuyoruz
    class User
    {
        // private değişkenler (dışarıdan erişilemez)
        private string adSoyad; // Ad ve Soyad
        private int yas; // Yaş

        // public özellik (her yerden erişilebilir)
        public string Email { get; set; } // Email

        // Getter ve Setter metotları (adSoyad için)
        public void SetAdSoyad(string adSoyad)
        {
            this.adSoyad = adSoyad; // this: sınıfın içindeki değişkeni ifade eder.
        }

        public string GetAdSoyad()
        {
            return adSoyad; // adSoyad'ı döndürür.
        }

        // Getter ve Setter metotları (yas için)
        public void SetYas(int yas)
        {
            if (yas >= 0) // Negatif yaş olmasın diye kontrol.
                this.yas = yas;
            else
                Console.WriteLine("Geçersiz yaş girdiniz!");
        }

        public int GetYas()
        {
            return yas;
        }

        // Bilgileri ekrana yazdıran metot (public)
        public void BilgileriGoster()
        {
            Console.WriteLine("Ad Soyad: " + adSoyad);
            Console.WriteLine("Yaş: " + yas);
            Console.WriteLine("Email: " + Email);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // User nesnesini oluşturuyoruz.
            User kullanici1 = new User();

            // Değer atamaları (setter metotları ve public özellik ile)
            kullanici1.SetAdSoyad("ALPEREN SARICAYIR");
            kullanici1.SetYas(22);
            kullanici1.Email = "alperen@example.com";

            // Bilgileri gösteriyoruz.
            kullanici1.BilgileriGoster();

            // Getter metotları ile ayrı ayrı verileri çekip ekrana yazdırma
            Console.WriteLine("\nAyrı Ayrı Bilgiler:");
            Console.WriteLine("Ad Soyad: " + kullanici1.GetAdSoyad());
            Console.WriteLine("Yaş: " + kullanici1.GetYas());
            Console.WriteLine("Email: " + kullanici1.Email);

            // Program kapanmasın diye bekliyoruz.
            Console.WriteLine("\nÇıkmak için bir tuşa basınız...");
            Console.ReadKey();
        }
    }
}
