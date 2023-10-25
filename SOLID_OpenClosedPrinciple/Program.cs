internal class Program
{
    private static void Main(string[] args)
    {
        // aşağıdaki kodlama da tercih edilir doğru kodlama değil çünkü new kullanıyoruz. new kullanmadan yapmak lazım hoca yazılım geliştirme tekniklerinde doğrusunu gösterdi.
        //IoC Container kullanmamızı öneriyor.// IoC ye örnek: Ninject, AutoFac, Structure Map, Castle Windsor,

        CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
        customerManager.Add();
    }
}
// ***************************************** OPEN CLOSED PRINCIPLE *************************************

//Loosely Coupled
// Business, veri katmanlarıyla iletişim kurarken sadece soyutlama teknikleriyle yani interface ile iletişim kurmalı
class CustomerManager
{
    // public void Add()
    //  {

    //EfCustomerDal customerDal = new EfCustomerDal();
    //customerDal.Add();

    // yukarıdaki yorum satırındakiler kötü kod dahilinde yazılmıştır.

    // aşağıdaki gibi new le yazı yazmak çok tercih edilmez. Bu da doğru bir yazım değil aslında. İyi bir yazılımcı new kullanmaz genelde.

    /* EfCustomerDal customerDal = new EfCustomerDal(); 
    /* EfCustomerDal customerDal = new EfCustomerDal(); 
     customerDal.Add(); 

   }*/

    // en doğru yazım aşağıdaki gibidir

    private ICustomerDal _customerDal;
    public CustomerManager(ICustomerDal customerDal)
    {
        _customerDal = customerDal;
    }

    public void Add()
    {
        _customerDal.Add();
    }
}
   
    // Aşağıdaki kod kötü bir koddur. her yeni değişiklikte değişmesi, mevcuttaki kodların değiştirilmesi gerekir. Bu da open Closed ilkesine uygun değildir.
    // aşağısı full if bloğuyla dolar ve sürekli mevcuttakini de değiştirmek gerekir. Sürekli if bloğu yazmak da prensibe uygun değildir.
    // Bir de o if bloğunu içeren her yerde değişiklik yapmak gerekecektir. Open closed prinsibine aykırıdır bu durum.
    // zaten aşağıdaki işlemler birbirinin alternatifi için yapılmıştır ve if'ler birbirinin alternatifi olan işlemler için kullanılmaz. Koşullar için kullanılır.
    // Bu şekilde yazmak if kullanımını suistimal etmek anlamına gelir.İf mantıksal açıdan dallanmak için kullanılır birbirinin alternatifi olan işler için kullanılmaz.
    /*  public void Add(Database database)
     
  /* 

  class CustomerDal
  {

      {

          if (database == Database.Oracle)
          {
              Console.WriteLine("Added to Oracle Database");
          }
          else
          {
              Console.WriteLine("Added to Sql Database");
          }
          //Ef Code
          Console.WriteLine("Added to Database");
      }

  }

  internal enum Database
  {
      Oracle,
      SqlServer
  }

    */

    // KODUN OPEN CLOSED PRENSİBİNE UYGUN YAZIMI AŞAĞIDAKİ GİBİDİR.

    // "Entity Framework" için kullanılır. Entity Framework, Microsoft tarafından geliştirilen bir ORM (Object-Relational Mapping) teknolojisidir.
    // Entity Framework, veritabanı işlemlerini doğrudan programlama dili nesneleriyle gerçekleştirmenizi sağlar.
    // Bu, geliştiricilere veritabanı işlemlerini SQL sorguları yerine nesne yönelimli bir yaklaşımla yapma imkanı verir.
    // EfCustomerDal sınıf adındaki "Ef" muhtemelen bu sınıfın Entity Framework kullanılarak veritabanı işlemlerini gerçekleştirdiğini ifade eder.
    // CustomerDal kelimesi ise "Data Access Layer" yani Veri Erişim Katmanı'nın (DAL) bir kısaltmasıdır ve genellikle veritabanı işlemlerinin gerçekleştirildiği sınıflara
    // verilen isimlerden biridir.
    // Bu tür bir isimlendirme, genellikle yazılım mimarilerinde ve ORM teknolojilerinde kullanılır



    // Aşağıdakiler veri erişim katmanlarıdır. 
    class EfCustomerDal : ICustomerDal
{
    public void Add()
    {
        Console.WriteLine("Added by EF");
    }
}

class NhCustomerDal : ICustomerDal
{
    public void Add()
    {
        Console.WriteLine("Added by EF");
    }
}

class DapperCustomerDal : ICustomerDal
{
    public void Add()
    {
        Console.WriteLine("Added by EF");
    }
}
internal interface ICustomerDal
{
    void Add();
}

