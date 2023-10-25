using System.Runtime.ConstrainedExecution;

internal class Program
{

    //*************************************** Interface Segregation Principle *********************

    private static void Main(string[] args)
    {
        
    }
}

// aşağıdaki kodlar hatalı kullanımına örnektir.
// şöyle ki kendi firmamızın çlışanlarına maaş, yemek ve iş veriyoruz. Ancak dışardan çalışanlara sadece maaş ve iş veriyoruz yemek vermiyoruz.
// Bu durumda mevcut interface iki sınıfı da karşılamıyor.
// işler robotlar devreye girince bu kodda daha da karışıyor çünkü robota yemek ve maaş vermiyoruz, sadece iş veriyoruz.
//Her şeyi yani operasyonu interface içine koymamalıyız, nerede nasıl kullanılacaklarını öngörerek ayrı interfaceler oluşturmalı.

/*
interface IWorker
{
    void PaySalary();
    void ProvideFood();
    void work();

}
class CompanyWorker : IWorker
{
    public void PaySalary()
    {
        // bunu yazdık
    }

    public void ProvideFood()
    {
        // bunu yazdık
    }

    public void work()
    {
        // bunu yazdık
    }
}

class OutSourceWorker : IWorker
{
    public void PaySalary()
    {
        // bunu yazdık
    }

    public void ProvideFood()
    {
        // bunu silemiyoruz silersek program kızıyor.
        // return null diyip geçiyor belki de silemediği için
    }

    public void work()
    {
        // bunu yazdık
    }
}

class Robot : IWorker
{
    public void PaySalary()
    {
        // maaş da vermiyoruz.
    }

    public void ProvideFood()
    {
        // yemek vermiyoruz
    }

    public void work()
    {
        // Sadece iş verebiliyoruz.
    }
}

*/

// KODUN DOĞRU YAZIMI YANI INTERFACE LERIN DOĞRU KULLANIMI AŞAĞIDAKİ GİBİDİR.

interface IPayable
{
    void Pay();

}

interface IEatable
{
    void Eat();

}

interface IWorkable
{
    void work();

}
class CompanyWorker : IWorkable, IPayable, IEatable
{
    public void Eat()
    {
       
    }

    public void Pay()
    {
        
    }

    public void work()
    {
        
    }
}

class OutSourceWorker : IWorkable, IPayable
{
    public void Pay()
    {
        
    }

    public void work()
    {
        
    }
}

class Robot : IWorkable
{
    public void work()
    {
        
    }
}