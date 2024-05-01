
using System;

namespace Layihe
{
    class JurnalElementi
    {
        
    }

    class Jurnal2 : KitabxanaElementi
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

     internal class Jurnal2
    {
        JurnalElementi[] KitabxanaElementi
            ;
        private object list;

        public Jurnal2()
        {
            JurnalElementleri = KitabxanaElementi;
            {
                new Kitab()
                {
                    Ad = "Azerbaijan International",
                    Muellif = "Betti Bleyer",

                    Kateqoriya = "Ictimai"

                };
                // Add more library elements if needed
            };
        }

        public Jurnal2(string ad, string muellif, int sehifesayi, string kateqoriya, JurnalElementi[] meqaleElementleri, object list, object jurnalElementleri)
        {
            Ad = ad;
            Muellif = muellif;
            Sehifesayi = sehifesayi;
            Kateqoriya = kateqoriya;
      
            this.list = list;
            JurnalElementleri = jurnalElementleri;
        }

        public object JurnalElementleri { get; }

    }
}
