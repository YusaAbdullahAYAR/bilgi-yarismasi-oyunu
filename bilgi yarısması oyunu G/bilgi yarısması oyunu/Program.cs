Console.WriteLine("**********************");
Console.WriteLine("Yarışmaya Hoş geldiniz");
Console.Title = "Bilgi Yarışması";
string ad, soyad;
Console.WriteLine("Adınız: ");
ad =Convert.ToString(Console.ReadLine());
Console.WriteLine("Soyadınız: ");
soyad = Convert.ToString(Console.ReadLine());

Console.WriteLine("Başlıyoruz Enter Tuşuna Basın...");

Console.WriteLine("Her Yanıttan Sonra Enter Tuşuna Basmayı Unutmayın...");

Console.WriteLine("Cevapları Büyük Harflerle Verin...");

Console.ReadLine();

int dogru, yanlis, para;
dogru = 0;
yanlis = 0;
para = 0;

string s1;
Console.WriteLine("Soru 1 - Cumhuriyet kaç yılında ilan edilmiştir?");
s1 = Convert.ToString(Console.ReadLine());
string c1;
Console.WriteLine(" A-1920\n B-1923\n C-1924\n D-1926\n  Cevabınız: ");
c1 = Console.ReadLine();
if (c1 == "B")
{
    dogru = dogru + 1;
    para = para + 1000;
    Console.WriteLine("Tebrikler cevap doğru enter tuşuna basın");
}
else
{
    yanlis = yanlis + 1;
    Console.WriteLine("Maalesef cevap yanlış enter tuşuna basın");
    Console.ReadLine();
}
string s2;
Console.WriteLine("Soru 2- Türkiye'nin başkenti hangi şehirdir?");
s2 = Convert.ToString(Console.ReadLine());

string c2;
Console.WriteLine(" A-İstanbul\n B-İzmir\n C-Ankara\n D-Konya Cevabınız:");
c2 = Console.ReadLine();
if (c2 =="C")
{
    dogru++;
    para = para + 1000;
    Console.WriteLine("Tebrikler cevap doğru enter tuşuna basın");
    Console.ReadLine();
}
else
{
    yanlis = yanlis + 1;
    Console.WriteLine("Maalesef cevap yanlış enter tuşuna basın");
    Console.ReadLine();
}


string s3;
Console.WriteLine("Soru 2- Maki hangi bölgenin bitki örtüsüdür?");
s3 = Convert.ToString(Console.ReadLine());

string c3;
Console.WriteLine(" A-Akdeniz\n B-Ege\n C-Marmara\n D-Karadeniz Cevabınız:");
c3 = Console.ReadLine();
if (c3 == "A")
{
    dogru++;
    para = para + 1000;
    Console.WriteLine("Tebrikler cevap doğru enter tuşuna basın");
    Console.ReadLine();
}
else
{
    yanlis = yanlis + 1;
    Console.WriteLine("Maalesef cevap yanlış enter tuşuna basın");
    Console.ReadLine();
}
string s4;
Console.WriteLine("Soru 4- Hangisi İstanbul'da bulunan bir semt değildir?");
s4 = Convert.ToString(Console.ReadLine());

string c4;
Console.WriteLine(" A-Üsküdar\n B-Urla\n C-Sarıyer\n D-Kartal Cevabınız:");
c4 = Console.ReadLine();
if (c4 == "B")
{
    dogru++;
    para = para + 1000;
    Console.WriteLine("Tebrikler cevap doğru enter tuşuna basın");
    Console.ReadLine();
}
else
{
    yanlis = yanlis + 1;
    Console.WriteLine("Maalesef cevap yanlış enter tuşuna basın");
    Console.ReadLine();
}


string s5;
Console.WriteLine("Soru 5- Hangisi programlamanın temel renklerinden değildir?");
s5 = Convert.ToString(Console.ReadLine());

string c5;
Console.WriteLine(" A-Mavi\n B-Yeşil\n C-Kırmızı\n D-Sarı Cevabınız:");
c5 = Console.ReadLine();
if (c5 == "D")
{
    dogru++;
    para = para + 1000;
    Console.WriteLine("Tebrikler cevap doğru enter tuşuna basın");
    Console.ReadLine();
}
else
{
    yanlis = yanlis + 1;
    Console.WriteLine("Maalesef cevap yanlış enter tuşuna basın");
    Console.ReadLine();
}

string s6;
Console.WriteLine("Soru 6- Avrupanın kullandığı ortak para birimi hangisidir?");
s6 = Convert.ToString(Console.ReadLine());

string c6;
Console.WriteLine(" A-Dolar\n B-Euro\n C-Zloty\n D-Ruble Cevabınız:");
c6 = Console.ReadLine();
if (c6 == "B")
{
    dogru++;
    para = para + 1000;
    Console.WriteLine("Tebrikler cevap doğru enter tuşuna basın");
    Console.ReadLine();
}
else
{
    yanlis = yanlis + 1;
    Console.WriteLine("Maalesef cevap yanlış enter tuşuna basın");
    Console.ReadLine();
}


string s7;
Console.WriteLine("Soru 7- Hangi ilimiz ege bölgemizde değildir?");
s7 = Convert.ToString(Console.ReadLine());

string c7;
Console.WriteLine(" A-İzmir\n B-Muğla\n C-Edirne\n D-Aydın Cevabınız:");
c7 = Console.ReadLine();
if (c7 == "C")
{
    dogru++;
    para = para + 1000;
    Console.WriteLine("Tebrikler cevap doğru enter tuşuna basın");
    Console.ReadLine();
}
else
{
    yanlis = yanlis + 1;
    Console.WriteLine("Maalesef cevap yanlış enter tuşuna basın");
    Console.ReadLine();
}

string s8;
Console.WriteLine("Soru 8- Sefiller kitabının yazarı kimdir?");
s8 = Convert.ToString(Console.ReadLine());

string c8;
Console.WriteLine(" A-Jules Verne\n B-Gogol\n C-Tolstoy\n D-Viktor Hugo Cevabınız:");
c8 = Console.ReadLine();
if (c8 == "D")
{
    dogru++;
    para = para + 1000;
    Console.WriteLine("Tebrikler cevap doğru enter tuşuna basın");
    Console.ReadLine();
}
else
{
    yanlis = yanlis + 1;
    Console.WriteLine("Maalesef cevap yanlış enter tuşuna basın");
    Console.ReadLine();
}

string s9;
Console.WriteLine("Soru 9- Mustafa Kemal Atatürk'ün nüfusa kayıtlı olduğu il hangisidir?");
s9 = Convert.ToString(Console.ReadLine());

string c9;
Console.WriteLine(" A-İstanbul\n B-İzmir\n C-Ankara\n D-Gaziantep Cevabınız:");
c9 = Console.ReadLine();
if (c9 == "D")
{
    dogru++;
    para = para + 1000;
    Console.WriteLine("Tebrikler cevap doğru enter tuşuna basın");
    Console.ReadLine();
}
else
{
    yanlis = yanlis + 1;
    Console.WriteLine("Maalesef cevap yanlış enter tuşuna basın");
    Console.ReadLine();
}

string s10;
Console.WriteLine("Soru 10- İstiklal Marşı şairiniz kimdir?");
s10 = Convert.ToString(Console.ReadLine());

string c10;
Console.WriteLine(" A-Ziya Gökalp\n B-Mehmet Akif Ersoy\n C-Orhan Veli\n D-Reşat Nuri Güntekin Cevabınız:");
c10 = Console.ReadLine();
if (c10 == "B")
{
    dogru++;
    para = para + 1000;
    Console.WriteLine("Tebrikler cevap doğru enter tuşuna basın");
    Console.ReadLine();
}
else
{
    yanlis = yanlis + 1;
    Console.WriteLine("Maalesef cevap yanlış enter tuşuna basın");
    Console.ReadLine();
}

Console.WriteLine("Adınız: " + ad);
Console.WriteLine("Soyadınız: " + soyad);
Console.WriteLine("Doğru Sayısı: " + dogru);
Console.WriteLine("Yanlış Sayısı: " + yanlis);
Console.WriteLine("Toplam kazandığınız para: " +para);
Console.WriteLine("Oyun Bitti...");

Console.Read();
