using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{

    public class DiziAdresBulma
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Diziniz kaç boyutlu olsun");
            int boyutSayisi = Convert.ToInt16(Console.ReadLine());
            int[] boyutDizisi = new int[boyutSayisi];
            for (int i = 0; i < boyutSayisi; i++)
            {
                Console.WriteLine((i + 1) + ". Boyutun uzunluğunu girin");
                int boyut = Convert.ToInt16(Console.ReadLine());
                boyutDizisi[i] = boyut;
            }
            int[] arananelemanDizisi = new int[boyutSayisi];
            Console.WriteLine("Adresini bulmak istediğiniz elemanın ; ");
            for (int i = 0; i < boyutSayisi; i++)
            {
                Console.WriteLine((i + 1) + ". Boyutttaki eleman numarasını  giriniz.");
                int arananeleman = Convert.ToInt16(Console.ReadLine());
                arananelemanDizisi[i] = arananeleman;
            }
            int adres = 0;
            int sayac = 1;
            for (int i = 0; i < boyutSayisi; i++)
            {
                int tempAdres = arananelemanDizisi[i];
                int tempSayac = sayac;
                for (int j = 0; j < (boyutSayisi - (i + 1)); j++)
                {
                    tempAdres = tempAdres * boyutDizisi[tempSayac];
                    tempSayac++;
                }
                sayac++;
                adres += tempAdres;
            }
            Console.WriteLine(adres * 4);
            Console.ReadKey();
        }
    }
    
}
