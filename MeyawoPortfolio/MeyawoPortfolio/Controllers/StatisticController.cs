﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class StatisticController : Controller
    {
        DbMyPortfolyoEntities db = new DbMyPortfolyoEntities();
       
        public ActionResult Index()
        {
            ViewBag.v1 = db.TblCategory.Count();
            ViewBag.v2 =  db.TblProject.Count();
            ViewBag.messageCount = db.TblContact.Count();
            ViewBag.CProjectCount = db.TblProject.Where(x => x.ProjectCategory == 1).Count();
            ViewBag.isNotReadMessageCount = db.TblContact.Where(x => x.IsRead == false).Count();
            ViewBag.serviceCount = db.TblService.Count();
            ViewBag.testimonialCount = db.TblTestimonial.Count();

            return View();
        }
    }
}