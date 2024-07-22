using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvCv.Models.Entity;
using MvCv.Repositories;

namespace MvCv.Controllers
{
    public class HobiController : Controller
    {
        // GET: Hobi
        GenericRepository<Hobiler> repo = new GenericRepository<Hobiler>();
        [HttpGet]
        public ActionResult Index()
        {
            var hobiler=repo.List();
            return View(hobiler);
        }
        [HttpPost]
        public ActionResult Index(Hobiler p)
        {
            var t = repo.Find(x => x.ID == 1);
            t.Aciklama1= p.Aciklama1;
            t.Aciklama2= p.Aciklama2;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}