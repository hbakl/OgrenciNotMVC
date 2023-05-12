﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OgrenciNotMVC.Models.EntityFramework;


namespace OgrenciNotMVC.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default

        DbMvcOkulEntities db = new DbMvcOkulEntities();

        //listeleme kodunun controllerdeki ayağı
        public ActionResult Index()
        {
            var dersler = db.TBLDERSLER.ToList();
            return View(dersler);
        }


        [HttpGet]
        public ActionResult YeniDers()
        {
            return View();
        }


        [HttpPost]
        public ActionResult YeniDers(TBLDERSLER p)
        {
            db.TBLDERSLER.Add(p);
            db.SaveChanges();
            return View();
        }
    }
}