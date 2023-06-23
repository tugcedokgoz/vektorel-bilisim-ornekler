using System;
using System.Collections.Generic;

namespace emlak
{
    public class Program
    {
        static void Main(string[] args)
        {
            Sehir sehir = new Sehir(06, "Ankara");
            Semt semt = new Semt(120, "Çankaya", sehir);
            Adres adres1 = new Adres(semt, "523", "254", "19");
            DateTime ilanTarihi = DateTime.Now;
            IletisimBilgileri iletisimBilgileri = new IletisimBilgileri("00000000", "satici@emlak.com");
            Satici satici1 = new Satici("Ahmet", "Öztürk", iletisimBilgileri);


            KiralikEmlakBilgisi kiralikEmlakBilgisi1 = new KiralikEmlakBilgisi(2000, 12, "Mehmet", 1500); //kefil
            SatilikEmlakBilgisi satilikEmlakBilgisi1 = new SatilikEmlakBilgisi(2000);

            Emlak emlak1 = new Emlak(adres1, DateTime.Now, satici1); //emlak bilgisi
            //Konut konut1 = new Konut(adres1, DateTime.Now, satici1, 150, 3); //konut bilgisi
            //Arsa arsa1 = new Arsa(adres1, DateTime.Now, satici1, true, 1000); //arsa bilgisi
            //Villa villa1 = new Villa(adres1, DateTime.Now, satici1, 200, 4, true, true);
            //Ev ev1 = new Ev(adres1, DateTime.Now, satici1, 120, 2, 4);
            KiralikVilla kiralikVilla1 = new KiralikVilla(adres1, DateTime.Now, satici1, 4, 500, true, true, kiralikEmlakBilgisi1);
            SatilikVilla satilikVilla1 = new SatilikVilla(adres1, DateTime.Now, satici1, 300, 6, true, true, satilikEmlakBilgisi1);
            KiralikEv kiralikEv1 = new KiralikEv(adres1, DateTime.Now, satici1, 150, 3, 2, kiralikEmlakBilgisi1);
            SatilikEv satilikEv1 = new SatilikEv(adres1, DateTime.Now, satici1, 200, 4, 3, satilikEmlakBilgisi1);
            SatilikArsa satilikArsa1 = new SatilikArsa(adres1, DateTime.Now, satici1, true, 500, satilikEmlakBilgisi1);
            KiralikArsa kiralikArsa1 = new KiralikArsa(adres1, DateTime.Now, satici1, true, 1000, kiralikEmlakBilgisi1);

            emlak1.BilgileriGoster();
            kiralikVilla1.BilgileriGoster();
            //satilikVilla1.BilgileriGoster();
            //kiralikEv1.BilgileriGoster();
            //satilikEv1.BilgileriGoster();
            //satilikArsa1.BilgileriGoster();
            //kiralikArsa1.BilgileriGoster();
            Console.ReadLine();
        }
    }
}
