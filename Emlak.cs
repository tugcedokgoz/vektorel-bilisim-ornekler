using System;

namespace emlak
{
    public class Emlak
    {
        private Adres Adres;
        private DateTime IlanTarihi;
        private Satici Satici;

        public Adres _adres
        {
            get { return Adres; }
            set { Adres = value; }
        }
        public DateTime _ilanTarihi
        {
            get { return IlanTarihi; }
            set { IlanTarihi = value; }
        }
        public Satici _satici
        {
            get { return Satici; }
            set { Satici = value; }
        }
        public Emlak(Adres Adres, DateTime IlanTarihi, Satici Satici)
        {
            this.Adres = Adres;
            this.IlanTarihi = IlanTarihi;
            this.Satici = Satici;
        }

        public void BilgileriGoster()
        {
            Console.WriteLine("Adres:" +
                "Şehir:" + Adres.Semt.Sehir._sehirAd + " " +
                "Semt:" + Adres.Semt._semtAd + " " +
                "Cadde:" + " " + Adres._cadde + " " + 
                "Sokak:" + " " + Adres._sokak + " " + 
                "Bina No:" + Adres._binaNo);
            Console.WriteLine("İlan Tarihi:" + IlanTarihi.ToShortDateString());
            Console.WriteLine("Satıcı:" + Satici._saticiAd +" "+ Satici._saticiSoyad);
        }

    }
    public class Konut : Emlak
    {
        private decimal M2;
        private int OdaSayisi;

        public decimal _m2
        {
            get { return M2; }
            set { M2 = value; }
        }
        public int _odaSayisi
        {
            get { return OdaSayisi; }
            set { OdaSayisi = value; }
        }
        public Konut(Adres Adres, DateTime IlanTarihi, Satici Satici, decimal M2, int OdaSayisi) : base(Adres, IlanTarihi, Satici)
        {
            this.M2 = M2;
            this.OdaSayisi = OdaSayisi;
        }
        public new void BilgileriGoster()
        {
            Console.WriteLine("Ev Büyüklüğü:" + M2 + "m2");
            Console.WriteLine("Oda Sayısı:" + OdaSayisi);
        }

    }
    public class Arsa : Emlak
    {
        private bool TapuluMu;
        private decimal M2;

        public bool _tapuluMu
        {
            get { return TapuluMu; }
            set { TapuluMu = value; }
        }
        public decimal _m2
        {
            get { return M2; }
            set { M2 = value; }
        }

        public Arsa(Adres Adres, DateTime IlanTarihi, Satici Satici, bool TapuluMu, decimal M2) : base(Adres, IlanTarihi, Satici)
        {
            this.TapuluMu = TapuluMu;
            this.M2 = M2;
        }
        public new void BilgileriGoster()
        {
            base.BilgileriGoster();
            Console.WriteLine("Tapu Var Mı?" + TapuluMu);
            Console.WriteLine("Arsa Büyüklüğü" + M2);
        }


    }
    public class Villa : Konut
    {
        private bool HavuzVarMi;
        private bool BahceVarMi;

        public bool _havuzVarMi
        {
            get { return HavuzVarMi; }
            set { HavuzVarMi = value; }
        }
        public bool _bahceVarMi
        {
            get { return BahceVarMi; }
            set { BahceVarMi = value; }
        }

        public Villa(Adres Adres, DateTime IlanTarihi, Satici Satici, decimal M2, int OdaSayisi, bool HavuzVarMi, bool BahceVarMi)
            : base(Adres, IlanTarihi, Satici, M2, OdaSayisi)
        {
            this.HavuzVarMi = HavuzVarMi;
            this.BahceVarMi = BahceVarMi;
        }
        public new void BilgileriGoster()
        {
            base.BilgileriGoster();
            Console.WriteLine("Havuz Var Mı?" + HavuzVarMi);
            Console.WriteLine("Bahce Var Mı?" + BahceVarMi);
        }
    }
    public class Ev : Konut
    {
        private int KatNo;
        public int _katNo
        {
            get { return KatNo; }
            set { KatNo = value; }
        }
        public Ev(Adres Adres, DateTime IlanTarihi, Satici Satici, decimal M2, int OdaSayisi, int KatNo)
            : base(Adres, IlanTarihi, Satici, M2, OdaSayisi)
        {
            this.KatNo = KatNo;

        }
        public new void BilgileriGoster()
        {
            base.BilgileriGoster();
            Console.WriteLine("Kat No" + KatNo);
        }
    }
    public class KiralikVilla : Villa
    {
        private KiralikEmlakBilgisi kiralikBilgisi;
        public KiralikEmlakBilgisi _KiralikEmlakBilgisi
        {
            get { return kiralikBilgisi; }
            set { kiralikBilgisi = value; }
        }
        public KiralikVilla(Adres Adres, DateTime IlanTarihi, Satici Satici, int M2, int OdaSayisi, bool HavuzVarMi, bool BahceVarMi, KiralikEmlakBilgisi kiralikEmlakBilgisi)
            : base(Adres, IlanTarihi, Satici, OdaSayisi, M2, HavuzVarMi, BahceVarMi)
        {
            //this.kiralikBilgisi = kiralikBilgisi;
        }
        public new void BilgileriGoster()
        {
            base.BilgileriGoster();
            Console.WriteLine("Kiralık Villa Bilgileri:");
            Console.WriteLine("Deposito: " + kiralikBilgisi._deposito);
            Console.WriteLine("Kontrat Süresi: " + kiralikBilgisi._kontratSuresi + " Ay");
            Console.WriteLine("Kefil: " + kiralikBilgisi._kefil);
            Console.WriteLine("Aylık Kira: " + kiralikBilgisi._aylikKira);
        }
    }
    public class SatilikVilla : Villa
    {
        private SatilikEmlakBilgisi satilikEmlakBilgileri;
        public SatilikEmlakBilgisi _SatilikEmlakBilgisi
        {
            get { return satilikEmlakBilgileri; }
            set { satilikEmlakBilgileri = value; }
        }
        public SatilikVilla(Adres Adres, DateTime IlanTarihi, Satici Satici, int M2, int OdaSayisi, bool HavuzVarMi, bool BahceVarMi, SatilikEmlakBilgisi satilikEmlakBilgisi)
            : base(Adres, IlanTarihi, Satici, OdaSayisi, M2, HavuzVarMi, BahceVarMi)
        {
            //this.satilikEmlakBilgileri = satilikEmlakBilgileri;
        }
        public new void BilgileriGoster()
        {
            base.BilgileriGoster();
            Console.WriteLine("Satılık Villa Bilgileri:");
            Console.WriteLine("Fiyat: " + satilikEmlakBilgileri._fiyat);
        }
    }
    public class KiralikEv : Ev
    {
        private KiralikEmlakBilgisi kiralikBilgisi;
        public KiralikEmlakBilgisi _KiralikEmlakBilgisi
        {
            get { return kiralikBilgisi; }
            set { kiralikBilgisi = value; }
        }
        public KiralikEv(Adres Adres, DateTime IlanTarihi, Satici Satici, int M2, int OdaSayisi, int KatNo, KiralikEmlakBilgisi kiralikEmlakBilgisi)
            : base(Adres, IlanTarihi, Satici, OdaSayisi, M2, KatNo)
        {
            //
        }
        public new void BilgileriGoster()
        {
            base.BilgileriGoster();
            Console.WriteLine("Kiralık Ev Bilgileri:");
            Console.WriteLine("Deposito: " + kiralikBilgisi._deposito);
            Console.WriteLine("Kontrat Süresi: " + kiralikBilgisi._kontratSuresi + " Ay");
            Console.WriteLine("Kefil: " + kiralikBilgisi._kefil);
            Console.WriteLine("Aylık Kira: " + kiralikBilgisi._aylikKira);
        }
    }
    public class SatilikEv : Ev
    {
        private SatilikEmlakBilgisi satilikEmlakBilgileri;
        public SatilikEmlakBilgisi _SatilikEmlakBilgisi
        {
            get { return satilikEmlakBilgileri; }
            set { satilikEmlakBilgileri = value; }
        }
        public SatilikEv(Adres Adres, DateTime IlanTarihi, Satici Satici, int M2, int OdaSayisi, int KatNo, SatilikEmlakBilgisi satilikEmlakBilgisi)
         : base(Adres, IlanTarihi, Satici, OdaSayisi, M2, KatNo)
        {
            //
        }
        public new void BilgileriGoster()
        {
            base.BilgileriGoster();
            Console.WriteLine("Satılık Ev Bilgileri:");
            Console.WriteLine("Fiyat: " + satilikEmlakBilgileri._fiyat);
        }
    }
    public class SatilikArsa : Arsa
    {

        private SatilikEmlakBilgisi satilikEmlakBilgileri;
        public SatilikEmlakBilgisi _SatilikEmlakBilgisi
        {
            get { return satilikEmlakBilgileri; }
            set { satilikEmlakBilgileri = value; }
        }
        public SatilikArsa(Adres Adres, DateTime IlanTarihi, Satici Satici, bool TapuluMu, decimal M2, SatilikEmlakBilgisi satilikEmlakBilgisi)
            : base(Adres, IlanTarihi, Satici, TapuluMu, M2)
        {

        }
        public new void BilgileriGoster()
        {
            base.BilgileriGoster();
            Console.WriteLine("Satılık Arsa Bilgileri:");
            Console.WriteLine("Fiyat: " + satilikEmlakBilgileri._fiyat);
        }
    }
    public class KiralikArsa : Arsa
    {
        private KiralikEmlakBilgisi kiralikBilgisi;
        public KiralikEmlakBilgisi _KiralikEmlakBilgisi
        {
            get { return kiralikBilgisi; }
            set { kiralikBilgisi = value; }
        }
        public KiralikArsa(Adres Adres, DateTime IlanTarihi, Satici Satici, bool TapuluMu, decimal M2, KiralikEmlakBilgisi kiralikEmlakBilgisi)
           : base(Adres, IlanTarihi, Satici, TapuluMu, M2)
        {
            //
        }
        public new void BilgileriGoster()
        {
            base.BilgileriGoster();
            Console.WriteLine("Kiralık Arsa Bilgileri:");
            Console.WriteLine("Deposito: " + kiralikBilgisi._deposito);
            Console.WriteLine("Kontrat Süresi: " + kiralikBilgisi._kontratSuresi + " Ay");
            Console.WriteLine("Kefil: " + kiralikBilgisi._kefil);
            Console.WriteLine("Aylık Kira: " + kiralikBilgisi._aylikKira);
        }
    }

    public class KiralikEmlakBilgisi
    {
        private decimal Deposito;
        private int KontratSuresi;
        private string Kefil;
        private decimal AylikKira;

        public decimal _deposito
        {
            get { return Deposito; }
            set { Deposito = value; }
        }
        public int _kontratSuresi
        {
            get { return KontratSuresi; }
            set { KontratSuresi = value; }
        }
        public string _kefil
        {
            get { return Kefil; }
            set { Kefil = value; }
        }
        public decimal _aylikKira
        {
            get { return AylikKira; }
            set { AylikKira = value; }
        }

        public KiralikEmlakBilgisi(decimal Deposito, int KontratSuresi, string Kefil, decimal AylikKira)
        {
            this.Deposito = Deposito;
            this.KontratSuresi = KontratSuresi;
            this.Kefil = Kefil;
            this.AylikKira = AylikKira;
        }

    }
    public class SatilikEmlakBilgisi
    {
        private decimal Fiyat;
        //public enum kimden
        //{
        //    Emlakci,
        //    Sahibinden
        //}

        public decimal _fiyat
        {
            get { return Fiyat; }
            set { Fiyat = value; }
        }
        public SatilikEmlakBilgisi(decimal Fiyat)
        {
            this.Fiyat = Fiyat;

        }

    }
    public class Adres
    {
        private Semt semt;
        private string Cadde;
        private string Sokak;
        private string BinaNo;

        public Semt Semt
        {
            get { return semt; }
            set { semt = value; }
        }
        public string _cadde
        {
            get { return Cadde; }
            set { Cadde = value; }
        }
        public string _sokak
        {
            get { return Sokak; }
            set { Sokak = value; }
        }
        public string _binaNo
        {
            get { return BinaNo; }
            set { BinaNo = value; }
        }
        public Adres(Semt semt, string Cadde, string Sokak, string BinaNo)
        {
            this.semt = semt;
            this.Cadde = Cadde;
            this.Sokak = Sokak;
            this.BinaNo = BinaNo;
        }
    }
    public class Sehir
    {
        private int SehirKod;
        private string SehirAd;

        public int _sehirKod
        {
            get { return SehirKod; }
            set { SehirKod = value; }
        }
        public string _sehirAd
        {
            get { return SehirAd; }
            set { SehirAd = value; }
        }
        public Sehir(int SehirKod, string SehirAd)
        {
            this.SehirKod = SehirKod;
            this.SehirAd = SehirAd;
        }
    }
    public class Semt
    {
        private int SemtKod;
        private string SemtAd;
        private Sehir sehir;

        public int _semtKod
        {
            get { return SemtKod; }
            set { SemtKod = value; }
        }
        public string _semtAd
        {
            get { return SemtAd; }
            set { SemtAd = value; }
        }
        public Sehir Sehir
        {
            get { return sehir; }
            set { sehir = value; }
        }
        public Semt(int SemtKod, string SemtAd, Sehir sehir)
        {
            this.SemtKod = SemtKod;
            this.SemtAd = SemtAd;
            this.sehir = sehir;

        }
    }
    public class Satici
    {
        private string SaticiAd;
        private string SaticiSoyad;
        public IletisimBilgileri iletisimbilgileri;

        public string _saticiAd
        {
            get { return SaticiAd; }
            set { SaticiAd = value; }
        }
        public string _saticiSoyad
        {
            get { return SaticiSoyad; }
            set { SaticiSoyad = value; }
        }
        public Satici(string SaticiAd, string SaticiSoyad, IletisimBilgileri iletisimBilgileri)
        {
            this.SaticiAd = SaticiAd;
            this.SaticiSoyad = SaticiSoyad;

        }
    }
    public class IletisimBilgileri
    {
        private string TelNo;
        private string Email;

        public string _telNo
        {
            get { return TelNo; }
            set { TelNo = value; }
        }
        public string _email
        {
            get { return Email; }
            set { Email = value; }
        }
        public IletisimBilgileri(string TelNo, string Email)
        {
            this.TelNo = TelNo;
            this.Email = Email;
        }

    }
}
