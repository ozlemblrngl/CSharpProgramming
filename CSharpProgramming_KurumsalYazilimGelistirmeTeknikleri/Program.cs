internal class Program
{
    private static void Main(string[] args)
    {
        /*********************** C# İLE KURUMSAL YAZILIM GELİŞTİRME TEKNİKLERİ ***********************
        
        1- Katmanlı Mimariler

        Nesne tabanlı mimariler.Projeler katmanlı bir mimari şeklinde yazılır. 
        Niye böyle yazılır? Katmanlı mimarilerin ortaya çıkış nedeni Reusability yani tekrar tekrar kullanılabilirliğidir.
        Yani yazılan bir kodun hem değiştirilebilirliğini sağlamak hem başka projelerde kullanılabilirliğini sağlamak hem de tak çıkar özelliği ile çalışabilmektir.
        Tak çıkar özelliği ise, örn arayüzümüzü geliştirmek istediğimizde o iş katmanında yazdıklarımızı ve veri tabanı katmanında yazdıklarımızı bir daha bir daha kodlamamamız gerekir.
        Bir proje minimum aşağıdaki 3 katmana sahip olmalıdır.

        Katmanlı mimarilerde 3 katman söz konusudur:

        1.1- Veri Erişim Katmanı

        Veri Erişim Katmanında veritabanına sadece insert, update, delete, select, truncate, alter gibi veri tabanına erişmek için gerekli kodları yazarız.
        Veri Erişim katmanında hiçbir zaman iş kodu yazılmaz, loglama yapılmaz. Sadece ve sadece veri tabanına erişiyoruz.
        Bunları çeşitli ORM ler ile yapıyoruz.
        ORM (Object-Relational Mapping), nesne yönelimli programlama (OOP) dillerinde kullanılan bir tekniktir. 
        Bu teknik, veritabanı ile nesne yönelimli programlama arasında veri alışverişi yapmayı kolaylaştırır.
        ORM, veritabanı tablolarını nesne olarak temsil eder ve veritabanı işlemlerini nesne yönelimli programlama dillerinde kullanılan nesne yönelimli kodla entegre eder.
        Yani, ORM, programcılara veritabanı işlemlerini gerçekleştirmek için SQL sorguları yerine doğrudan nesnelerle çalışma olanağı tanır.
        Bu, geliştiricilere daha doğal ve nesne odaklı bir yaklaşım sağlar, çünkü veritabanı tabloları ve alanları doğrudan program içinde nesne olarak temsil edilir.
        Birçok programlama dilinde ORM kütüphaneleri bulunmaktadır. Örneğin, C# dilinde Entity Framework, Java dilinde Hibernate ve Python dilinde SQLAlchemy gibi 
        popüler ORM kütüphaneleri mevcuttur.Bu kütüphaneler, geliştiricilere veritabanı işlemlerini nesne yönelimli programlama ile uyumlu bir şekilde gerçekleştirmelerine olanak tanır
        Bu şekilde, geliştiriciler veritabanı işlemleriyle uğraşırken daha az zaman harcar ve daha az hata yaparlar.


        1.2- İş Katmanı

        Sadece iş kodu yazarız üzerinde.Örn bir veriyi veritabanına ekleyeceğiz bu veri veritabanına eklemek için uygun mu kontrolü yaparız.Diyelim ki bir müşteri var
        ve bu müşteri daha önce kayıtlı mı değil mi kontrolu iş katmanında yapılır.
        İş Katmanı, veri erişim katmanıyla iletişim kurar.,

        1.3- Arayüz Katmanı

        Sadece kullanıcıyla etkileşim kodlarının yazıldığı yerdir.Burada kullanıcıya bir şeyler gösterir ve kullanıcıdan girdiler alırız.
        En çok suistimal edilen katmandır.Çoğu zaman yazılımcılar iş katmanında yazması gereken kodu arayüz katmanına yazmaktadır.
        Arayüz katmanında kod yazarken kendimize şunu sormamız gerekir:
        Şu an yazdığım kod sadece örn asp.net mvc arayüzünü mü ilgilendiriyor, yoksa şu an yazdığım kural hem bu projede hem de mobil geliştireceğim android projesinde de geçerli mi?
        Yani birden fazla arayüzde geçerli bir kuralı hiçbir şekilde arayüz katmanına yazmayacağız.Yani bir kural hem Windows form da geçerli, hem mobiilde hem mvc de geçerli o zaman 
        o kodun yeri burası değildir.Aksi halde yarın bir gün düzeltilmesi gerekse her yerde değişiklik yapmak gerekir.Bu kodun yeri iş katmanıdır burası değildir o nedenle.

        2- Mikro Servis Odaklı Mimariler

        Mikro Servis Odaklı mimariler, katmanlı mimarilerle birlikte kullanılırlar birbirlerinin alternatifi değildirler.Birbirlerinin tamamlayıcısıdırlar.
        Mikro servisler çok değişik yapılarda olabiliyor.Mikro servis gibi yapıları projelerimize dahil ederken şu yapılara dikkat etmemiz gerekli:

        -Değişim odaklı,sürdürülebilir yazılım geliştirmeye dikkat etmeliyiz.
        Pekş bu ne anlama gelmektedir?
        Gelişim odaklı yazılım, değişen koşulara adapte edilebilir kod yazmaktır. çalışıyorsa dokunma mantığı hatalıdır.
        Plug and play(Pnp) Solid yazılım prensiplerinin doğru şekilde uygulanması anlamına gelir. Solidi ezberlememek onun yerine plug and play yani soyutlama tekniklerimi öğrenmek gerekiir.
        
        *******************************************
        
        Cross-Cutting

        "Cross-cutting concern" (veya "cross-cutting aspect"), yazılım geliştirme sürecinde birden fazla bileşeni veya modülü etkileyen, 
        tüm sistemi yatay bir şekilde geçen endişeleri ifade eder. Yani, bir yazılım sistemi içinde birden fazla modül veya bileşen tarafından paylaşılan, 
        genel sistem davranışını etkileyen ve işlevsellikle doğrudan ilgili olmayan özelliklerdir.
        Cross-cutting concerns, yazılımın farklı parçalarında yaygın olarak tekrarlanabilir ve farklı modüller arasında etkileşimde bulunabilir. 

        */

        //IoC Container, Ninject, AutoFac. Bunlar kullanılmalıdır doğru kod için keza aşağıdaki kod yazımı tekniği olarak doğru değildir. 

        CustomerManager customerManager = 
            new CustomerManager(new CustomerDal(), new MainLoggerAdopter());
        //new DatabaseLogger() alternatifi, new EmailLogger() alteratifi, new FakeLogger() alternatifi yerine new MainLoggerAdapter alternatifi eklenebilir.
        customerManager.Save(new Customer());



    }
}

class CustomerDal : ICustomerDal // veri eirişim katmanıdır
{
    public void Save()
    {
        Console.WriteLine("Customer Added");
    }
}

interface ICustomerDal
{
    void Save();
}

// hiçbir zaman çıplak bir class kalmamalıdır yani sadece tek başına class olmamalıdır bir interface i, inheritance i olmalıdır.
// Eğer yalın yani çıplak kalıyorsa orada bir hata var demektir.

class CustomerManager : ICustomerService // iş katmanıdır.
{
    private ICustomerDal _customerDal; //construction
    private ILogger _logger;

    public CustomerManager(ICustomerDal customerDal, ILogger logger) //construction
    {
        _customerDal = customerDal;
        _logger = logger;
    }
    public void Save(Customer customer)
    {
        // kurallar yazılacak
        // DİKKAT BİR SINIF BAĞIMLI OLDUĞU BAŞKA BİR SINIFI NEW LEYEMEZ. O NEDENLE AŞAĞIDAKİ YILDIZLI KOD HATALIDIR.

        //****CustomerDal customerDal = new CustomerDal();
       //***alternatif doğru kullanım customerDal.Save();
        _customerDal.Save();
        _logger.Log();
        
    }
}


internal interface ICustomerService // default değer internal'dır. başına yazmazsak da sıkıntı olmaz. // iş katmanıdır.
{
    // buraya operationlar yazılır.

    void Save(Customer customer);

}

class Customer // iş katmanıdır.
{
    public int Id { get; set; }
    public string FirstName { get; set; }
}

interface ILogger
{
    void Log();
}

class DatabaseLogger : ILogger
{
    public void Log()
    {
        Console.WriteLine("Logged to db");
    }
}

class EmailLogger : ILogger
{
    public void Log()
    {
        Console.WriteLine("Email to db");
    }
}

class FakeLogger : ILogger
{
    public void Log()
    {
        
    }
}
class MainLoggerAdopter : ILogger // burası ile mikroservisi kendi projemize dahil ediyoruz.
{
    public void Log()
    {
        MainLogger mainlogger = new MainLogger();
        mainlogger.LogToMain();
    }
}

//Microservis
// bir mikroservisi projemize nasıl dahil ederiz?
class MainLogger
{
    public void LogToMain()
    {
        Console.WriteLine("logged to main");
    }
}