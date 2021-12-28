using FilmKutuphanesi.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmKutuphanesi.Models
{
    public static class DatabaseProcesses
    {
        public static void YeniKayit(string yeniKullaniciAdi, string yeniSifre)
        {
            using (var DB = new GloriaContext())
            {
                var yeniKullanici = new Kullanici()
                {
                    KullaniciAdi = yeniKullaniciAdi,
                    Sifre = yeniSifre
                };
                
                DB.Kullanicilar.Add(yeniKullanici);
                DB.SaveChanges();

                //DB.Kullanicilar.Add(new Kullanici() { KullaniciAdi = yeniKullaniciAdi, Sifre = yeniSifre });
            }
        }

        public static bool GirisKontrol(string yeniKullaniciAdi, string yeniSifre)
        {
            bool sonuc = false;

            using (var DB = new GloriaContext())
            {
                var daKullanici = DB.Kullanicilar.Where(k => k.KullaniciAdi == yeniKullaniciAdi).FirstOrDefault();

                if(daKullanici != null)
                {
                    if(daKullanici.Sifre == yeniSifre)
                    {
                        sonuc = true;
                    }
                    else
                    {
                        sonuc = false;
                    }
                }
                else
                {
                    sonuc = false;
                }
            }
            return sonuc;
        }
              
    }
}