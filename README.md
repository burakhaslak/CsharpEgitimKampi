# C# Eğitim Kampı Çalışmalarım
Bu repo, Murat Yücedağ’ın rehberliğinde geliştirdiğim 10 temel C# projesini içeriyor. Sıfırdan başladığım eğitimde, projeler ve somut örneklerle programlama kavramlarını pekiştirdiğim bir yolculuktu. Her proje detaylarını aşağıda bulabilirsiniz.

📍 Proje 1: Temel Konular (Main Subjects)

Bu projede C#’ta konsola yazı yazdırmayı ve değişkenlerle çalışmayı öğrendim. Console.Write() aynı satırda, Console.WriteLine() alt satıra geçerek yazdırma farkını keşfettim. String değişkenlerle müşteri bilgilerini, int değişkenlerle ürün fiyat ve adetlerini saklayıp hesaplamalar yaptım; böylece basit bir restoran menüsü ve sipariş toplamı programı oluşturdum.

📍Proje 2: Değişkenler (Variables)

Bu projede string, int, double ve char değişkenleri kullanmayı öğrendim.
  String ile isim, soyisim, şehir gibi yazıları sakladım ve ekrana yazdırdım.
  Int ile tam sayı verilerini depolayıp hesaplamalar yaptım (örn. ürün fiyatları × adet).
  Double ile ondalıklı sayılarla çalıştım, toplam fiyat ve sınav ortalamaları gibi hesaplamalar yaptım.
  Char ile tek karakterlik verileri (örn. cinsiyet) sakladım.
  Ayrıca Console.ReadLine() ile kullanıcıdan veri almayı ve int.Parse() veya double.Parse() ile uygun veri türüne dönüştürmeyi öğrendim.
  Bu proje ile değişkenleri tanımlama, değer atama ve kullanıcıdan veri alma becerilerimi geliştirdim.

📍Proje 3: Karar Yapıları (Making Decisions)

Bu projede if-else ve switch-case ile programın farklı koşullara göre nasıl karar verdiğini öğrendim. Kullanıcı girişlerine göre şifre doğrulama, sınav sonucu değerlendirme veya menü seçimi yaptırdım. Ayrıca mod işlemi ve char değişkenleri ile özel durumları kontrol etmeyi ve farklı çıktılar üretmeyi denedim.

📍Proje 4: Döngüler (Loops)

Bu projede for ve while döngüleri ile tekrarlayan işlemleri otomatik yaptırmayı öğrendim. Döngülerle sayı saydırma, toplam bulma, belirli şartlara göre filtreleme ve basamak hesaplama gibi işlemleri yaptım. Ayrıca if ile karar yapıları döngüler içinde kullanılarak daha karmaşık koşullar kontrol edildi.

📍Proje 5: Döngülerle Yıldızlar (Loops with Stars)

Bu projede for döngülerini kullanarak yıldızlarla şekiller oluşturmayı öğrendim. Döngülerle alt alta veya yan yana yıldız yazdırma, dik üçgen, ters üçgen, piramit ve baklava dilimi gibi şekiller oluşturdum. İç içe döngüler sayesinde satır ve sütun kontrolü yaparak şekil tasarlama mantığını pekiştirdim.

📍Proje 6: Diziler (Arrays)

Bu projede dizi (array) kavramını öğrendim. String, int ve char dizileri oluşturarak eleman atama ve okuma yaptım. For döngüsüyle dizideki tüm elemanları listeleme, koşullu seçimler yapma ve dizi metodları (Sort, Reverse, IndexOf, Max, Min) ile verileri yönetme pratiği yaptım. Ayrıca kullanıcıdan dizi elemanı alarak toplam, tek/çift sayı ve arama işlemleri gerçekleştirdim.

📍Proje 7: Foreach Döngüsü (Foreach Loops)

Bu projede foreach döngüsü ile diziler, listeler ve stringler üzerinde tek tek elemanlara erişim yaptım. Döngü sayesinde sırasıyla tüm elemanları yazdırma, koşullu seçimler yapma, toplam alma gibi işlemleri kolayca gerçekleştirdim. Ayrıca sınav uygulaması örneğiyle, kullanıcıdan alınan öğrenci isimleri ve sınav notlarını saklayıp ortalama ve geçme/kalma durumlarını hesaplama pratiği yaptım.

📍Proje 8: Geriye Değer Döndürmeye ve Void Methodları

Bu projede metodlar ile kod tekrarını önlemeyi ve programı daha düzenli hâle getirmeyi öğrendim. Void ve geriye değer döndüren metodlar kullanarak hesaplama ve bilgi gösterme işlemlerini gerçekleştirdim. Örnek uygulamada öğrencilerin sınav notlarını alıp ortalamalarını hesaplayan metodlar yazarak gerçek bir senaryoda uygulama pratiği yaptım.

📍Proje 9: C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi (Database Project) 

Bu projede ADO.NET kullanarak SQL Server’daki tablolarla etkileşim sağladım. Kullanıcıdan alınan tablo seçimine göre verileri çekip ekrana listeledim ve DataTable ile verileri geçici olarak bellekte tutma pratiği yaptım. Böylece C# ile veritabanı işlemlerini temel düzeyde uygulama deneyimi kazandım.

📍Proje 10: Menü Sipariş İşlem Paneli (DatabaseCRUD Project)

Bu projede CRUD (Create, Read, Update, Delete) işlemlerini C# ile SQL Server üzerinde yaptım. Kullanıcıdan aldığım verilerle tabloya ekleme, listeleme, silme ve güncelleme işlemlerini gerçekleştirdim. Kod içinde kendi notlarımı da ekleyerek adım adım süreci belgeledim ve ADO.NET ile veri tabanı yönetimini uygulamalı olarak öğrendim.

📍Proje 11: Seyahat İstatistik Paneli Projesi

<img width="951" height="529" alt="image" src="https://github.com/user-attachments/assets/eb16ce35-3975-4bed-abc6-7abe4c24d0ca" />


Bu projede, Entity Framework kullanarak bir seyahat veri tabanındaki bilgileri sorgulayan ve sonuçları Windows Forms arayüzü üzerinden kullanıcıya görselleştiren bir istatistik paneli geliştirdim. Proje, veri tabanındaki tur, rehber ve lokasyon bilgilerini analiz ederek anlık istatistikler sunmayı amaçladı. 💻

Projede yer alan özellikler:
*Toplam lokasyon, kapasite ve rehber sayısı gibi genel bilgilerin hesaplanması,
*Ortalama kapasite ve ortalama tur fiyatının gösterilmesi,
*En son eklenen ülkenin dinamik olarak görüntülenmesi,
*Belirli şehirlerin (ör. Kapadokya, Roma) kapasite ve rehber bilgilerinin sorgulanması,
*En yüksek kapasiteli ve en pahalı turların tespit edilmesi,
*Belirli bir rehberin (ör. Ayşegül Çınar) sorumlu olduğu tur sayısının hesaplanması.

Kazanımlarım:
*Entity Framework kullanarak veri tabanı bağlantısı kurma, LINQ sorguları ile filtreleme ve veri çekme işlemlerini etkin şekilde uyguladım.
*Windows Forms arayüzünde dinamik olarak değişen istatistikleri renkli ve kullanıcı dostu bir şekilde görselleştirdim.
*Farklı tablo ilişkilerini yöneterek, rehber ve lokasyon bilgilerini ilişkisel olarak bağladım.
*Kodun okunabilirliğini artırmak için yorum satırları ekleyerek düzenli bir yapı oluşturdum. 📊
*Bu proje sayesinde C# dilinde veri tabanı yönetimi, Entity Framework mantığı ve arayüz tasarımı konularında önemli bir pratik kazandım. Gelecek projelerde bu temelleri daha ileri seviyede geliştirmeyi hedefliyorum.

