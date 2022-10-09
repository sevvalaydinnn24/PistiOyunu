using GenelTekrar.Araclar;
using GenelTekrar.Matematik;
using GenelTekrar.Oyunlar;
using System;
using System.Collections.Generic;

//namespace: Çalışma alanı, çalışma grubu gibi isimler de alır. Birden fazla nesne kullanım durumunda bu yapı nesneler arası iletişimi kolaylaştırır. Aynı alan altındaki nesneler birbirlerini direk görür.
namespace GenelTekrar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Shortcuts (Kısayollar):
            ///Alt+Enter, Ctrl+.: Benim için VS yapısının önerilerini gösterir.
            ///Ctrl+K,C: Bulunduğu veya seçilen alanı yorum satırı haline getirir.
            ///Ctrl+K,U: Bulunduğu veya seçilen alanı yorum satırından normal haline getirir.
            ///Ctrl+K,D: Bulunduğumuz dosyanın formatını uygun hale getirir. Girintileri düzenler.
            ///Ctrl+S: Bulunduğumuz dosyadaki değişiklikleri kayıt altına alır.
            ///Ctrl+Shift+S: Açık olan bütün dosyalardaki değişiklikleri kayıt altına alır.
            ///Ctrl+E,W: Word-Wrap, satırları ekrana sığacak şekilde kaydırır.
            ///Ctrl+D: Dublicate, bulunduğumuz satırın kopyasını alt satıra alır.
            ///F5: Start debug, hata ayıklama moduyla çalıştır.
            ///Ctrl+F5: Start without debug, hata ayıklama modu olmadan çalıştır.
            ///Ctrl+F/Ctrl+H: Bul/Değiştir
            #endregion

            #region Oyunlar:
            {
                Oyun oyun = new Oyun();
                int[] tavla_sonuc = oyun.TavlaOyna();
                string[] para_sonuc = oyun.YaziTuraOyna(5);

                foreach (var item in tavla_sonuc)
                {
                    Console.Write(item + ", ");
                }
                Console.WriteLine();
                foreach (var item in para_sonuc)
                {
                    Console.Write(item + ", ");
                }
                Console.WriteLine('\n');
            }
            #endregion

            #region Kontroller:
            {
                Kontroller kontrol = new Kontroller();
                Konsol konsol = new Konsol();
                long sayi = konsol.SayiOku();
                bool sonuc = kontrol.AsalMi(sayi);
                Console.WriteLine(sayi + (sonuc ? " asaldır." : " asal değildir."));

                long[] sayilar = new long[5];
                for (int i = 0; i < 5; i++)
                {
                    sayilar[i] = konsol.SayiOku();
                }
                
                Dictionary<long, bool> sonuclar = kontrol.AsallarMi(sayilar);
                foreach (var item in sonuclar)
                {
                    Console.WriteLine(item);
                }
            }
            #endregion
        }
    }
}
