using GenelTekrar.Zarlar;

namespace GenelTekrar.Oyunlar
{
    public class Oyun
    {
        public int[] TavlaOyna()
        {
            int[] sonuclar = new int[2];
            Tavla tavla = new Tavla();
            sonuclar[0] = tavla.At();
            sonuclar[1] = tavla.At();
            return sonuclar;
        }

        public string[] YaziTuraOyna(int atis_sayisi)
        {
            string[] sonuclar = new string[atis_sayisi];
            Para para = new Para();
            for (int i = 0; i < atis_sayisi; i++)
            {
                sonuclar[i] = para.At();
            }
            return sonuclar;
        }
    }
}
