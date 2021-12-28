using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmKutuphanesi.Models.Database
{
    public class Kullanici
    {
        public int ID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
    }
}