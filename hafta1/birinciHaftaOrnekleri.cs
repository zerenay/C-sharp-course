//********************** 1.Gün ***********************//

/*
int cap;
Console.Write("bir sayı giriniz");
cap = Convert.ToInt32(Console.ReadLine);
const double pi = 3.14;
double alan, cevre;
alan = (double)pi * Math.Pow(cap, 2);
cevre = (double)2 * pi * cap;
Console.WriteLine("dairenin alanı:" + alan);
Console.WriteLine("dairenin cevresi" + cevre);
Console.ReadLine();
Console.ReadKey();

*/

/*
git:
int sayi1, sayi2;
double toplam, cikarma, bolme, carpma, us, kalan;
Console.Write("1.sayiyi giriniz");
sayi1 = Convert.ToInt32(Console.ReadLine());
Console.Write("2.sayiyi giriniz");
sayi2 = Convert.ToInt32(Console.ReadLine());
toplam = sayi1 + sayi2;
cikarma = sayi1 - sayi2;
carpma = sayi1 * sayi2;
bolme = (double)sayi1 / sayi2;
us = Math.Pow(sayi1, sayi2);
kalan = sayi1 % sayi2;
Console.WriteLine("toplama sonucu:" + toplam);
Console.WriteLine("cıkarma sonucu:"+cikarma);
Console.WriteLine("bolme sonucu:"+bolme);
Console.WriteLine("carpma sonucu:"+carpma);
Console.WriteLine("us sonucu:"+us);
Console.WriteLine("kalan sonucu:"+kalan);
Console.ReadKey();
goto git;
*/


//********************* 2.Gün **********************//

/*
double vize, final, yilSonuNot;

Console.WriteLine("vize notlarını giriniz");
vize = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("final notlarını giriniz");
final = Convert.ToInt32(Console.ReadLine());

    yilSonuNot = (double) vize * 0.4 + final * 0.6;

if (yilSonuNot <=49 )
    Console.WriteLine(yilSonuNot + " FF");

else if( yilSonuNot <=59)
    Console.WriteLine(yilSonuNot + " DC");

else if (yilSonuNot <= 69)
    Console.WriteLine(yilSonuNot + " DD");

else if(yilSonuNot <=79)
    Console.WriteLine(yilSonuNot + " CC");

else if(yilSonuNot <= 89)
    Console.WriteLine(yilSonuNot + " BB");

else
    Console.WriteLine(yilSonuNot + " AA");

Console.ReadKey();
*/

/*
git:
int sinav, saat;

Console.WriteLine("Sınav notunu giriniz");
sinav = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Devamsızlık saatini giriniz.");
saat = Convert.ToInt32(Console.ReadLine());

if (saat > 16)
    Console.WriteLine(saat + "Devamsızlıktan kaldınız.");

else if (sinav < 50)
    Console.WriteLine("Üzgünüm! Sınav notundan kaldnız.");

else
    Console.WriteLine("Tebrikler! Geçtiniz.");

Console.ReadKey();

goto git;
*/

/*
int gun;
Console.Write("1 ile 7 arasında bi sayı giriniz:");
gun = Convert.ToInt32(Console.ReadLine());
switch (gun)
    {
    case 1:
        Console.WriteLine("Bugün Pazartesi");
            break;
    case 2:
        Console.WriteLine("Bugün Salı");
            break;
    case 3:
        Console.WriteLine("Bugün Çarşamba");
            break;
    case 4:
        Console.WriteLine("Bugün Perşembe");
            break;
    case 5:
        Console.WriteLine("Bugün Cuma");
            break;
    case 6:
        Console.WriteLine("Bugün Cumartesi");
            break;
    case 7:
        Console.WriteLine("Bugün Pazar");
            break;
    default:
        Console.WriteLine("Haftanın gününü yanlış girdiniz");
        break;
}
Console.ReadKey();
*/

/*
uint tek = 0;
uint cift = 0;
for (uint i = 0; i < 100; i++)
{
    if (i % 2 == 0)
    {
        cift += i;
    }
    else
    {
        tek += i;
    }
}
Console.WriteLine("tek sayıların toplamı:" + tek);
Console.WriteLine("cift sayıların toplamı" + cift);

Console.ReadKey();
*/

/*
for (int satir = 1; satir <= 10; satir++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.Write(satir +"x"+ j +"="+ satir * j );
        Console.Write("\t");
    }
    Console.WriteLine(); 
}
*/