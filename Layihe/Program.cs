using Layihe;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
string myemail = "rubay";
string mypassword = "rubay";
int cehdsayi = 5;

bool finish = false;

Console.WriteLine("Sisteme xos geldiniz");

while (!finish && cehdsayi > 0)
{

    Console.WriteLine("Istifadeci adinizi qeyd edin:");
    string name = Console.ReadLine();
    Console.WriteLine("Sifrenizi daxil edin:");
    string password = Console.ReadLine();
    if (myemail == name && mypassword == password)
    {
        finish = true;
    }
    else
    {
        cehdsayi--;
        Console.WriteLine("Istifadeci adi ve ya sifre yanlisdir");
        Thread.Sleep(1000);
        Console.Clear();

    }


}
if (finish)
{
    Kitabxana kitabxana = new();
    Console.WriteLine(@"
    Secim edin: 
1. Kitablar.
2 .Səsli kitablar.
3.Jurnallar.
4. Kitab  əlavə etmək.
5. Istenilen kitabi kirayə vermək.
6 .Ataris etmek.
    "); 
    int secim = Convert.ToInt32(Console.ReadLine());
    switch (secim)
    {
        case 1:
            kitabxana.ElementleriGoster();

            break;
        case 2:
            Console.WriteLine("Jurnallarin siyahisi");

            break;
        case 3:
            Console.WriteLine("Kitab kiraye vermek");
            break;
        case 4:
            Console.WriteLine("search");
            break;
    }
}
else
{
    Console.WriteLine("Sisteme daxil ola bilmediniz");
}

