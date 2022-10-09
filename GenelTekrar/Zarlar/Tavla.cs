using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenelTekrar.Zarlar
{
    public class Tavla
    {
        public int At()
        {
            Random random = new Random();
            //0 ~ 5 aralığında rastgele değer verir. Sonuc 1 eklenir.
            return random.Next(6) + 1;
        }
    }
}
