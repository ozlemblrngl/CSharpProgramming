internal class Program
{
    //************************ Liskov's Substitution Prensibi **************************

    // aşağıdaki örnek hatalı bir kullanımdır ve bu prensibe aykırıdır.
    // Bir şirketin müşterileri gerçek kişi de olabilir tüzel kişi de olabilir. Bu birbirlerinin yerine geçecekleri anlamına gelmez. 
    // sırf birbirine benziyor diye birbirlerinin yerine geçemezler.
    // aksi halde aşağıdaki gibi sıkıntılar olur. Çünkü gerçek kişilerin isim ve soyisimleri varken şirketlerin ünvanları vardır.
    // gerçek kişilerin tc nosu varken şirketlerin vergi nosu vardır
    private static void Main(string[] args)
    {
        Customer customer = new Customer()
        {
            Id = 1,
            FirstName = "özlem",
            LastName = "Belörenoğlu",
            TcNo = "11111111111"
        };

        Customer firm = new Customer()
        {
            Id = 1,
            FirstName = "ABC kozmetik",
            LastName = null,
            TcNo = null     
        };
    }
}

class Customer
{
    public int Id { get; set; }
 
}


// doğru şekilde ilkeye uygun kodu yazmak için aşağıdaki iki sınıf eklenmelidir. Not yukarıdaki main kısmı hatalı şekildeki haliyledir. düzeltilmemiştir. hatayi görmek adına.

class IndividualCustomer : Customer // isimlendirme bana ait
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string TcNo { get; set; }
}

class LegalEntityCustomer : Customer // isimlendirme bana ait
{

    public string TaxNumber { get; set; }

    public string Title { get; set; }
}