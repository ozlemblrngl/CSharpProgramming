internal class Program
{
    private static void Main(string[] args)
    {
        /******************* SOLID ************************************************

        Yazılım geliştirici isek SOLID'e hakim olmamız gerekiyor. Solid ne sağlar? Yazılımda sürdürülebilirlik ve Clean Code dediğimiz süreçleri kapsar.
        Sürdürülebilir olmanın yazılımda karşılığı şudur, değişiklik yapılması gerektiğinde direnç göstermemektir.

        SOLID 5 adet prensibin ilk harflerinden oluşur.

        1- Single responsibity
        Tek sorumluluk; yazılım geliştirirken, her bloğun, her classın, her metodun, her katmanın vs sadece ve sadece bir görevi olmalıdır.
        Hiçbir şekilde bir tane metodun içinde iki tane iş yapılmaz. Bir classın içerisinde iki farklı nesne yönetilmez. Bir katmanda o katmanın dışında iş yapılmaz.
        Mvc de sadece arayüzü ilgilendiren kodlar yazılır. 



        2- Open Closed
        Programlar yeni özellikler, değişiklikler eklemeye açık fakat mevcut özellikleri değiştirmeye kapalı olmalıdır. Ysni projeye yeni bir özellik eklediğimizde, 
        mevcuttaki tek bir satır kodu dahi değiştiremeyiz.


        3- Liskov's Substitution
        İki şey sırf birbirine benziyor diye birbirinin yerine kullanılmamalı.

        4- Interface Segregation
        Her şeyi yani operasyonu interface içine koymamalıyız, nerede nasıl kullanılacaklarını öngörerek ayrı interfaceler oluşturmalı.

        5- Dependency Inversion
        Yani, Dependency Inversion Principle (DIP) temel olarak üst seviye modüllerin alt seviyeli detaylardan (concrete implementations) ziyade 
        soyutlamalara (abstract interfaces) dayanması gerektiğini belirtir.
        Bu sayede sistemde yapılan değişikliklerin diğer modüllere olan etkisi minimize edilmiş olur.

         */
    }
}
