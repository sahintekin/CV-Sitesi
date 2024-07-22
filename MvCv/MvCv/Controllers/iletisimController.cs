using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvCv.Models.Entity;
using MvCv.Repositories;


namespace MvCv.Controllers
{
    public class iletisimController : Controller
    {
        // GET: iletisim
        GenericRepository<İletişim> repo = new GenericRepository<İletişim>();
        public ActionResult Index()
        {
            var mesajlar =repo.List();
            return View(mesajlar);
        }
    }
}