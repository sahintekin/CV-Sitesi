﻿using MvCv.Models.Entity;
using MvCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvCv.Controllers
{
    [Authorize]
    public class EgitimController : Controller
    {
        // GET: Egitim
        GenericRepository<Egitimler> repo = new GenericRepository<Egitimler>();

       
        public ActionResult Index()
        {
            var egitim = repo.List();
            return View(egitim);
        }
        [HttpGet]
        public ActionResult EgitimEkle()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult EgitimEkle(Egitimler p)
        {
            if (!ModelState.IsValid)
            {
                return View("EgitimEkle");
            }
            repo.Tadd(p);
            return RedirectToAction("Index");
        }
        public ActionResult EgitimSil(int id) 
        {
            var egitim=repo.Find(x=>x.ID==id);
            repo.TDelete(egitim);
            return RedirectToAction("Index");            
        }
        [HttpGet]
        public ActionResult EgitimDuzenle (int id) 
        {
            var egitim=repo.Find(x=>x.ID== id);
            return View(egitim);
        }
        [HttpPost]  
        public ActionResult EgitimDuzenle(Egitimler t)
        {
            if (!ModelState.IsValid)
            {
                return View("EgitimDuzenle");
            }
            var egitim = repo.Find(x => x.ID == t.ID);
            egitim.Baslik=t.Baslik;
            egitim.AltBaslik1= t.AltBaslik1;
            egitim.AltBaslik2 = t.AltBaslik2;
            egitim.GNO=t.GNO;
            egitim.Tarih=t.Tarih;
            repo.TUpdate(egitim);
            return RedirectToAction("Index");

        }

    }
}