using System;
using System.Collections.Generic;
using System.Text;

namespace emlak
{
   public class Emlak
    {
        public Adres Adres;
        public DateTime IlanTarihi;
        public Satici Satici;
    }
    public class Konut:Emlak
    {
        public decimal M2;
        public int OdaSayisi;
    }
    public class Arsa : Emlak
    {
        public bool TapuluMu;
        public decimal M2;
    }
    public class Villa : Konut
    {
        public bool HavuzVarMi;
        public bool BahceVarMi;
    }
    public class Ev : Konut
    {
        public int KatNo;
    }
    public class KiralikVilla : Villa
    {
        public KiralikEmlakBilgisi kiralikemlakbilgileri;
    }
    public class SatilikVilla : Villa
    {
        public SatilikEmlakBilgisi satilikEmlakBilgileri;
    }
    public class KiralikEv : Ev
    {
        public KiralikEmlakBilgisi kiralikemlakbilgileri;
    }
    public class SatilikEv : Ev
    {
        public SatilikEmlakBilgisi satilikEmlakBilgileri;
    }
    public class SatilikArsa : Arsa
    {
        public SatilikEmlakBilgisi satilikEmlakBilgileri;
    }
    public class KiralikArsa : Arsa
    {
        public KiralikEmlakBilgisi kiralikemlakbilgileri;
    }

    public class KiralikEmlakBilgisi
    {
        public decimal Deposito;
        public int KontratSuresi;
        public string Kefil;
        public decimal AylikKira;
    }
    public class SatilikEmlakBilgisi
    {
        public decimal Fiyat;
        public enum Kimden
        {
            Emlakci,
            Sahibinden
        }

    }
    public class Adres
    {
        public Semt semt;
        public string Cadde;
        public string Sokak;
        public string BinaNo;
    }
    public class Sehir
    {
        public int Kod;
        public string Ad;
    }
    public class Semt
    {
        public int Kod;
        public string Ad;
        public Sehir sehir;
    }
    public class Satici
    {
        public string Ad;
        public string Soyad;
        public IletisimBilgileri iletisimbilgileri;
    }
    public class IletisimBilgileri
    {
        public string TelNo;
        public string Email;
    }
}
