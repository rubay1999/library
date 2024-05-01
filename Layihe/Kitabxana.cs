using System;

namespace Layihe
{
    class KitabxanaElementi
    {
    }

    class Kitab : KitabxanaElementi
    {
        public string Ad { get; set; }
        public string Muellif { get; set; }
        public int Sehifesayi { get; set; }
        public string Kateqoriya { get; set; }

        public override string ToString()
        {
            return $"Ad: {Ad}\n Muellif: {Muellif}\n Sehifesayi:\n Kateqoriya: {Kateqoriya}";
        }
    }

    class Kitabxana
    {
        KitabxanaElementi[] KitabxanaElementleri;

        public Kitabxana()
        {
            KitabxanaElementleri = new KitabxanaElementi[]
            {
                new Kitab()
                {
                    Ad = "Ovod",
                    Muellif ="Etel Lilian Voyniç",
                    Kateqoriya ="Bestseller, Bədii ədəbiyyat, Dram, Klassiklər, Roman",
                     Sehifesayi=400
                  
                }
               
            };
        }

        public void ElementleriGoster()
        {
            foreach (var element in KitabxanaElementleri)
            {
                Console.WriteLine(element);
            }
        }
    }
}