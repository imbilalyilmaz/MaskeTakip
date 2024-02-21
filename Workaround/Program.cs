internal class Program
{
    private static void Main(string[] args)
    {
        SelamVer();
        SelamVer("Bilal");

        int sonuc = Topla(6, 58);

        Console.ReadLine();
    }

    static void SelamVer(string isim="isimsiz")
    {
        Console.WriteLine("Merhaba" + isim);
    }
    static int Topla(int sayi1 = 5, int sayi2 = 10)
    {
        int sonuc = sayi1 + sayi2;
        Console.WriteLine("Toplam" +  sonuc);
        return sonuc;
    }
     
  
}