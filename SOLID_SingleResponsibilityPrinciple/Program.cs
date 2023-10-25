internal class Program
{
    private static void Main(string[] args)
    {
      
    }
}
// ********************************* AŞAĞIDA SINGLE RESPONSIBILITY İLKESİNE AYKIRILIK GÖSTERİLMİŞTİR ******************************

class CustomerManager
{

    // Aspect Orieented Programming burada devreye giriyor.
    public void TransactionalOperation()
    {
        // loglama
        // validation
        // caching
        // Authorization kodu
        // Performance check 
        // programcı burada yukarıdaki işlemleri yapabiliyor bu durumda single responsibility kuralını bir güzel çiğnemiş oluyor. Bunlar yapılmaması gereken şeyler.

        Insert();
        Update(); // doğru şekli budur.Aşağıdaki gibi ayrı metodlarda yazıp buraya almak.

        //MyContext context = new MyContext();
        //context.Update();
        //context.Insert();
        // (yukarıdaki 3 satır)Bir metodun içerisinde iki ayrı görev yüklenmesi yazdığımız kodda sıkıntı çıkarıyor. Aşağıdaki sınıfta daha net görülüyor. Bu durum single responsibility ilkesine uygun değil.

    }

    // Yukarıdaki metot yerine doğru olarak yazılacak metot kodları aşağıdaki gibidir ve her biri birbirinden ayrı görevi tekil olarak üstlenmektedir. Doğrusu da budur.

    public void Insert()
    {
        MyContext context = new MyContext();
        context.Insert();
    }

    public void Update()
    {
        MyContext context = new MyContext();
        context.Update();

    }

}

class PersonManager
{
    public void Add()
    {
        CustomerManager customerManagar = new CustomerManager();

        // customerManagar.TransactionalOperation();  

        // (tek yorum satırı) Yukarıda TransactionalOpration metodunda hem update hem insert iki ayrı metodu kullandığımız için eğer sadece insert edeceksek burada sıkıntı yaşıyoruz. 
        // ekleme fonksiyonunda sadece insert i kullanmak isterken aynı metoda iki ayrı görev yüklemiş olmamız nedeniyle sıkıntı oluyor.
        // bu durumda SOLID'in single Responsibility ilkesine aykırılık teşkil ediyor.

        // doğru hali yukarıda ayrı metotlara alınmış hali doğrultusunda sadece insert etme amaçlı olarak aşağıdaki gibidir.

        customerManagar.Insert();
    }
}

class MyContext
{
    public void Update()
    {

    }

    public void Insert()
    {

    }
}
    