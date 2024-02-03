﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class TestimonialController : Controller
    {
        // GET: Testimonial
        DbMyPortfolyoEntities db = new DbMyPortfolyoEntities();
        public ActionResult Index()
        {
            var values = db.TblTestimonial.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateTestimonial()
        {

            return View();

        }
        [HttpPost]

        public ActionResult CreateTestimonial(TblTestimonial p)
        {

            db.TblTestimonial.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult DeleteTestimonial(int id)
        {

            var value = db.TblTestimonial.Find(id);
            db.TblTestimonial.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateTestimonial(int id)
        {
            var value = db.TblTestimonial.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateReference(TblTestimonial p)
        {

            var value = db.TblTestimonial.Find(p.TestimonialID);
            value.NameSurname = p.NameSurname;
            value.ImageUrl = p.ImageUrl;
            value.Description = p.Description;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}