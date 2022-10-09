using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenelTekrar.Matematik
{
    public class Kontroller
    {
        public bool AsalMi(long sayi)
        {
            bool sonuc = true;
            for (long i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    sonuc = false;
                    break;
                    //Sonucu alında geri kalanına ihtiyaç kalmaz. Döngü bitirilir.
                }
            }
            return sonuc;
        }

        public Dictionary<long,bool> AsallarMi(long[] sayilar)
        {
            Dictionary<long,bool> sonuc = new Dictionary<long,bool>();

            foreach (long sayi in sayilar)
            {
                sonuc.Add(sayi, AsalMi(sayi));
            }

            return sonuc;
        }
    }
}
