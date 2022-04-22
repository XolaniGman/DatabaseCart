using DatabaseCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CartExample.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            ////ProductModel productModel = new ProductModel();
            ////ViewBag.products = productModel.findAll();
            return View(db.Products.ToList());
        }
        // GET: Artists/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Artists/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Price,Photo")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(product);
        }
    }
}