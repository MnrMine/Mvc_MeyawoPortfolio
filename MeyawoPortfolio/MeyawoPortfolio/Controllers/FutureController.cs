using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class FutureController : Controller
    {
        // GET: Future
        DbMyPortfolyoEntities db = new DbMyPortfolyoEntities();
        public ActionResult Index()
        {
            var values = db.TblFuture.ToList();
            return View(values);
           
        }
    }
}