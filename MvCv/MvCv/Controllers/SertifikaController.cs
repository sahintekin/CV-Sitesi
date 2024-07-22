using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using MvCv.Models.Entity;
using MvCv.Repositories;

namespace MvCv.Controllers
{
    public class SertifikaController : Controller
    {
        // GET: Sertifika
        GenericRepository<Sertifikalar> repo = new GenericRepository<Sertifikalar>();
        public ActionResult Index()
        {
            var sertifika = repo.List();
            return View(sertifika);
        }
        [HttpGet]
        public ActionResult SertifikaGetir(int id)
        {
            var sertifika=repo.Find(x=>x.ID==id);
            ViewBag.d = id;
            return View(sertifika);

        }
        [HttpPost]
        public ActionResult SertifikaGetir(Sertifikalar t)
        {
            var sertifika = repo.Find(x => x.ID == t.ID);
            sertifika.Aciklama = t.Aciklama;
            sertifika.Tarih=t.Tarih;
            repo.TUpdate(sertifika);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult SertifikaYeni()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SertifikaYeni(Sertifikalar p)
        {
            repo.Tadd(p);
            return RedirectToAction("Index");
        }
        public ActionResult SertifikaSil(int id)
        {
            var sertifika=repo.Find(x=>x.ID==id);
            repo.TDelete(sertifika);
            return RedirectToAction("Index");
        }
    }
}