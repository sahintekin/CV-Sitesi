using MvCv.Models.Entity;
using MvCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvCv.Models.Entity;
using MvCv.Repositories;

namespace MvCv.Controllers
{
    public class HakkimdaController : Controller
    {
        // GET: Hakkimda
        GenericRepository<Hakkında> repo = new GenericRepository<Hakkında>();
        [HttpGet]
        public ActionResult Index()
        {
            var hakkinda = repo.List();
            return View(hakkinda);
        }
        [HttpPost]
        public ActionResult Index(Hakkında p)
        {
            var t = repo.Find(x => x.ID == 1);
            t.Ad = p.Ad;
            t.Soyad = p.Soyad;
            t.Adres= p.Adres;
            t.Telefon = p.Telefon;
            t.Mail= p.Mail;
            t.Aciklama= p.Aciklama;
            t.Resim= p.Resim;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}