internal class Program
{
    private static void Main(string[] args)
    {
        /* ************************************ CLEAN CODE TEMİZ KOD YAZMA SANATI ********************************************
         
        Later equals never.

        Kodu daha sonra düzeltirim diyip bırakmamalıyız çünkü daha sonra bakıp düzeltme gerçekçi değildir. En baştan temiz yazmaya çalışmak önemlidir.
        Daha kodu yazarken temiz kod teknikleriyle yazarsak proje yazım sürecini kısaltırız.

        SonarQube, 29 programlama dilindeki hataları ve kod kokularını tespit etmek amacıyla kodun statik analiziyle otomatik incelemeler gerçekleştirmek amacıyla kod kalitesinin 
        sürekli denetimi için SonarSource tarafından geliştirilen açık kaynaklı bir platformdur.

        Code review yapmalı. Başkalarına kendi kodumuzu okutmalı ve açık kaynak kodları okumalıyız.
        Çalışıyorsa dokunma mantığı uzun vadede geçerli değildir.

        Temiz koddan kastımız okunabilir koddur.

        c# name convention ve diğer dillerin name conventionlarına bakılabilir yazım kuralları(standartlarını) görmek açısından.

        -----------------------------------------------------------------------------------------------------------------------------
        1- İSİMLENDİRME KURALLARI 
        -----------------------------------------------------------------------------------------------------------------------------

        Her dilin isimlendirme standartları farklıdır. çalıştığımız değişkenin ismi neyse onu açık açık yazmalıyız daha sonra dönüp baktığımızda anlamak için.
        Aksi halde ne anlama geldiğini çözümlemek için reverse engineering yani tersine mühendislik yapmak zorunda kalırız.
        Kısaltmalardan uzak durmalıyız. Açık açık uzun yazmaktan çekinmemeliyiz.

        Eski zamanlarda pascal ve fortrand gibi dillerde kısaltmalı şekilde yazılıyordu çünkü bilgisayarların hafıza kapasitesi çok daha sınırlıydı ve performanstan bir kazanç sağlıyordu.
        Ancak günümüzde kısa yazmamızın performans üzerinde belirgin bir etkisi yoktur, önemli olan kodun anlaşılırlığını sağlamaktır bu anlamda değişken adlarını vs uzun uzun yazabiliriz.

        metodu da isimlendirdiğimizde ne olduğunu anlayamayacak şekilde ve metodun tamamını okumak zorunda kalacak şekilde isimlendirmememiz lazım.
        -------------------
        COMMON LANGUAGE(Ortak dil)
        Değişkenblere verdiğimiz isim standartları, metotları yapılandırma şeklimiz, commentleri yazma şeklimiz, tüm bunlarda herkesin ortak aynı şeyi yapıyor olması lazım.
        Bu bağlamda ekip içerisindeki isimlendirme kurallarının ortak bir dile çekilmesi gerekiyor.
        -------------------

        kodu isimlendirirken o an aklımıza isim gelmeyebilir, yine de üzerinde düşünmemiz o an geçici bir isim koymamamız lazım, 
        çünkü daha sonra dönüp düzeltmemiz gereken onca şeyin arasında unutabiliriz ve daha sonra döndüğümüzde ne anlama geldiğini hatırlamakta zorlanıp 
        tersine mühendislik yapmak durumunda kalabiliriz.

        -----------------------------------------------------------------------------------------------------------------------------
        2- FONKSİYONLAR
        -----------------------------------------------------------------------------------------------------------------------------

        Single Responsibility Principle ve Code Refactoring
        Bir fonksiyon sadece bir iş yapabilir. Karmaşık ve her şeyi içeren kalabalık bir metottansa program içerisinde çok metot ve class olması iyidir bunun hiçbir zararı yoktur. 
        Bu arada aşırı derecede tasarım da zararlıdır(overdesign)

        -----------------------------------------------------------------------------------------------------------------------------
        3- YORUMLAR (COMMENTS)
        -----------------------------------------------------------------------------------------------------------------------------

        Software Development Methodology(Agile), ALM, SCRUM with TFS
        Fonksiyonun içerisine comment yazılmaz. Yapılan işlerin ayrı ayrı gösterilmesi yazılması doğru değildir yorumlarla.Yorum elbette yazılabilir fonksiyona ama bir yere kadar.

        -----------------------------------------------------------------------------------------------------------------------------
        4- SOYUTLAMA
        -----------------------------------------------------------------------------------------------------------------------------

        Çıplak class kalmasın
        Yazılım değişime direnç göstermemeli. Classlarda eğer herhangi bir soyutlama yoksa kod değişime direnç gösterir.

        -----------------------------------------------------------------------------------------------------------------------------
        5- SOLID
        -----------------------------------------------------------------------------------------------------------------------------

        BKZ. CSharpProgramming_SOLID_YazilimGelistirmePrensipleri

        S - Single Responsibility Principle (Tek Sorumluluk Prensibi): Bir sınıfın yalnızca bir sorumluluğu olmalıdır. 
        Yani, bir sınıfın değiştirilme nedeni yalnızca bir sorumluluğun değişmesi olmalıdır.

        O - Open/Closed Principle (Açık/Kapalı Prensibi): Yazılım varlıkları (sınıflar, modüller, fonksiyonlar, vb.), genişletilmeye açık ancak değişikliğe kapalı olmalıdır. 
        Yeni özellikler eklemek için mevcut kodu değiştirmek yerine, yeni kod eklenmelidir.

        L - Liskov Substitution Principle (Liskov Yerine Koyma Prensibi): Alt sınıflar, üst sınıfların yerine kullanılabilir olmalıdır. 
        Yani, bir üst sınıfın nesnesi her zaman bir alt sınıfın nesnesiyle yer değiştirebilmelidir.

        I - Interface Segregation Principle (Arayüz Ayırma Prensibi): İstemciler, ihtiyaçlarına özel olarak tasarlanmış arayüzleri kullanmalıdır. 
        Bir sınıf, kullanmayacağı yöntemlere sahip büyük arayüzler uygulamamalıdır.

        D - Dependency Inversion Principle (Bağımlılıkları Tersine Çevirme Prensibi): Üst seviye modüller, alt seviye modüllere bağımlı olmamalıdır. 
        Her iki seviye de soyutlamalara (interface veya abstract class gibi) dayanmalıdır. Bu prensip, yüksek seviyeli modüllerin, düşük seviyeli modüller tarafından belirlenmiş 
        olan ayrıntılara (detaylara) bağımlı olmamasını önerir.

        -----------------------------------------------------------------------------------------------------------------------------
        6- ASPECT ORIENTED PROGRAMMING (AOP)
        -----------------------------------------------------------------------------------------------------------------------------

        Temiz kod yazmak için inanılmaz bir tekniktir.
        Çok güzel bir alan. Detaylıca öğreten eğitimleri almakta fayda var.













         */
    }
}