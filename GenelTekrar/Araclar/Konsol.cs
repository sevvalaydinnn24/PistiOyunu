using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenelTekrar.Araclar
{
    public class Konsol
    {
        public long SayiOku()
        {
            Console.Write("Bir sayı giriniz:");
            Int64.TryParse(Console.ReadLine(), out long sayi);
            return sayi;
        }
    }
}
