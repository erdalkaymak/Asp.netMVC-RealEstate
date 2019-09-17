using DataAccesLayer;
using DataAccesLayer.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmlakMvc.Controllers
{
    public class AdresController : Controller
    {
        // GET: Adres
        AdresRepository rep = new AdresRepository();

        public ActionResult Listele()
        {
            var list= rep.GetAll();
            return View(list);
        }

        public ActionResult AdresEkle()
        {

            return View();
        }

        [HttpPost]
        public ActionResult AdresEkle(Adres adres)
        {
            var model = rep.Add(adres);
            return View();
        }

        public ActionResult AdresSil(int id )
        {
            rep.Delete(id);
            return RedirectToAction("Listele");
        }

        public ActionResult AdresGuncelle(int id)
        {
            var adres = rep.Find(id);
            return View(adres);
        }

        [HttpPost]
        public ActionResult AdresGuncelle(Adres adres)
        {
            rep.Update(adres);
            return RedirectToAction("Listele");
        }

    }
}