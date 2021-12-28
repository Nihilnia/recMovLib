using FilmKutuphanesi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilmKutuphanesi.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string kullaniciAdi, string sifre)
        {
            var girisSonuc = DatabaseProcesses.GirisKontrol(kullaniciAdi, sifre);
            if(girisSonuc == true)
            {
                return View("DogruGiris");
            }
            else
            {
                return View("YanlisGiris");
            }
            
        }

        [HttpGet]
        public ActionResult KayitOl()
        {
            return View();
        }

        [HttpPost]
        public ActionResult KayitOl(string kullaniciAdi, string sifre)
        {
            DatabaseProcesses.YeniKayit(kullaniciAdi, sifre);
            return View("Home/Index");
        }
    }
}