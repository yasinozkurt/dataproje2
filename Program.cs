using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsproje2
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] MahalleAdı = { "Özkanlar", "Evka 3", "Atatürk", "Erzene", "Kazımdirik", "Mevlana", "Doğanlar", "Ergene" };
            int[] TeslimatSayısı = { 5, 2, 7, 2, 7, 3, 0, 1 };

            //Aralarından random seçim yapılacak yemek türü listesi:

            string[] yemekCesidi = { "pizza", "pide", "kebap", "patlıcan musakka", "mantı", "sarma", "mercimek köftesi", "hamburger" };

            Random rnd = new Random(7);


            //Bir arraylist oluşturup  for döngüsü ile her indeksine birer mahallesınıfı objesi koyuyorum:
            ArrayList Moto_Kurye = new ArrayList();

            for (int i = 0; i < MahalleAdı.Length; i++)
            {
                int index = rnd.Next();

                MahalleSınıfı tempMh = new MahalleSınıfı(MahalleAdı[i]);

                for(int j = 0; j < TeslimatSayısı[i]; j++)
                {
                    
                    tempMh.liste.Add(new TeslimatSınıfı(yemekCesidi[rnd.Next(7)], rnd.Next(10)));


                }
                Moto_Kurye.Add(tempMh);
                Console.WriteLine(Moto_Kurye[i]);
                         
            }


            //KONTROL KISMI::





            ArrayList a = new ArrayList();
            TeslimatSınıfı t = new TeslimatSınıfı("et", 3);
            TeslimatSınıfı t2 = new TeslimatSınıfı("köfte", 4);
            MahalleSınıfı m = new MahalleSınıfı("erzene");
            m.liste.Add(t);
            m.liste.Add(t2);
            a.Add(m);

            Console.WriteLine(a[0].liste[0].yemekAdı);



            Console.ReadLine();


        }
    }

    class MahalleSınıfı
    {
        public string mahalleAdı;
        public List<TeslimatSınıfı> liste = new List<TeslimatSınıfı>();

        public MahalleSınıfı(string ma)
        {
            this.mahalleAdı = ma;
          
        }
        
    }

    class TeslimatSınıfı
    {
        public string yemekAdı;
        public int adet;

        public TeslimatSınıfı(string y,int a)
        {
            this.yemekAdı = y;
            this.adet = a;

        }
    }
}
