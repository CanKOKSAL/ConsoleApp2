
#region
Console.WriteLine("Ateş etmek için 1'e tıklayın");
Console.WriteLine("Cephanenin tamamını kullanmak için 2'ye tıklayın");
Console.WriteLine("Şarjör yenilemek için 3'e tıklayın");
Console.WriteLine("Ne kadar mermin kaldığını görmek için 4'e tıklayın");
Console.WriteLine("Oyundan çıkmak için 5'e tıklayın");
#endregion
int Mermi = 30;
int Görev = Int32.Parse(Console.ReadLine());

if (Görev > 5)
{
    Console.WriteLine("Oyuna devam edebilmek için 0-5 arası bir rakam giriniz");
}
if (Görev == 1)
    {
        do
        {
        Mermi-- ;
            Console.WriteLine(Mermi);
           
        }
        while (Mermi==0);
}
if (Görev == 2)
    { Console.WriteLine("3'e bas ve şarjörünü yenile"); 
}
if (Mermi== 0)
{
    Console.WriteLine("3 e bas ve şarjörü yenile");
}

switch (Görev)
{
    case 1:
        Console.WriteLine("Mermin bir azaldı");
        return;
    case 2:
        Console.WriteLine("Mermini harcadın");
        return;
    case 3:
        Console.WriteLine("Şarjör değiştin mermin tekrardan 30 oldu");
        return;
    case 4:
        Console.WriteLine(Mermi);
        return;
    case 5:
        Console.WriteLine("Oyundan çıktın");
        break;
}
