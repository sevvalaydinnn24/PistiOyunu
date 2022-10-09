using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PistiOyunu
{
    public class Deste
    {
        private List<Kart> kartlar;
        //Rastgele sistemi bu satırı standart olarak kullanır. Next() metodunun her seferinde yeni değer vermesi için bu şekilde eklenir.
        private static readonly Random random = new Random();

        public Deste()
        {
            //Üzeirnde işlem yapmaya başlamadan List gibi nesnel yapıların boş hali oluşturulur.
            kartlar = new List<Kart>();
            string[] yuzler = { "Sinek", "Maça", "Karo", "Kupa" };
            string[] degerler = { "As", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Vale", "Kız", "Papaz" };

            foreach (var yuz in yuzler)
            {
                foreach (var deger in degerler)
                {
                    Kart kart = new Kart(yuz, deger);
                    kartlar.Add(kart);
                }
            }
        }

        public void Karistir()
        {
            for (int i = 0; i < 50; i++)
            {
                int ilkYariKartAdresi = random.Next(26);//0 ~ 25 arası rastgele bir değer üretir.
                int ikinciYariKartadresi = random.Next(26,52);//26 ~ 51 arası rastgele bir değer üretir.

                Kart bos = kartlar[ilkYariKartAdresi];
                kartlar[ilkYariKartAdresi] = kartlar[ikinciYariKartadresi];
                kartlar[ikinciYariKartadresi] = bos;

                //(kartlar[ikinciYariKartadresi], kartlar[ilkYariKartAdresi]) = (kartlar[ilkYariKartAdresi], kartlar[ikinciYariKartadresi]);
            }
        }

        public int KartSay()
        {
            return kartlar.Count;
        }

        public List<Kart> KartVer(int kart_sayisi)
        {
            List<Kart> verilecekler = kartlar.Take(kart_sayisi).ToList();
            kartlar.RemoveRange(0, kart_sayisi);
            return verilecekler;
        }

        public override string ToString()
        {
            return string.Join(", ", kartlar);
        }
    }
}
