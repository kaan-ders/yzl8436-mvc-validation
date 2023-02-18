using Microsoft.AspNetCore.Mvc;
using MvcValidation.Models;

namespace MvcValidation.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.HataVarMi = false;
            return View();
        }

        [HttpPost]
        public IActionResult Index(Musteri musteri)
        {
            //kontrol et

            //old way - manuel kontrol
            //if(string.IsNullOrWhiteSpace(musteri.Adi) || musteri.SiparisSayisi == 0 || string.IsNullOrWhiteSpace(musteri.Email) || EmailDogruMu(musteri.Email) == false || musteri.KayitTarihi > DateTime.Now.AddDays(1))
            //{
            //    //hata ver
            //    ViewBag.HataVarMi = true;
            //}
            //else
            //{
            //    //dbye kaydet
            //}

            if (ModelState.IsValid)
            {
                //dbye kaydet
            }
            else
                ViewBag.HataVarMi = true;

            return View();
        }

        private bool EmailDogruMu(string email)
        {
            if (email.Contains("@") == true && email.Contains("."))
                return true;
            else
                return false;
        }
    }
}