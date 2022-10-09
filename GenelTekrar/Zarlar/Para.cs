using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenelTekrar.Zarlar
{
    public class Para
    {
        public string At()
        {
            Random random = new Random();
            //0 ~ 1 aralığında rastgele değer verir.
            if (random.Next(2) == 0)
            {
                return "Yazı";
            }
            else
            {
                return "Tura";
            }
        }
    }
}
