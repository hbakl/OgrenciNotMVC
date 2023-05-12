using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OgrenciNotMVC.Models.EntityFramework;

namespace OgrenciNotMVC.Controllers
{
    public class SinavlarController : Controller
    {
        // GET: Sinavlar
        DbMvcOkulEntities db = new DbMvcOkulEntities();
        public ActionResult Index()
        {
            var notlar = db.TBLNOTLAR.ToList();
            return View(notlar);
        }
    }
}