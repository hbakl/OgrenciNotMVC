using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//aşağıdaki using ile entity framework bağlanıyor ve sql sorguları için bu lazım
using OgrenciNotMVC.Models.EntityFramework;

namespace OgrenciNotMVC.Controllers
{
    public class OgrencilerController : Controller
    {
        // GET: Ogrenciler
        //aşağıdaki oluşturulan "db" isimli nesne ile  oluşturulan db modeli bağlanıyor ve bu sayede db sorguları kolaylaşıyor
        DbMvcOkulEntities db = new DbMvcOkulEntities();
        public ActionResult Index()
        {
            //ogrenciler nesnesi oluşturulup, db nesnesinin oğrenciler tblosu tolist metodu ile listeleniyor.
            var Ogrenciler = db.TBLOGRENCILER.ToList();
            return View(Ogrenciler);
        }
    }
}