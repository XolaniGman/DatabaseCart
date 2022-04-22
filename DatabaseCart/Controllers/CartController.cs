using DatabaseCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatabaseCart.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Buy(string id)
        {
            //Product product = new Product();
            Product product = db.Products.Find(id);
           
            
            if (Session["cart"] == null)
            {
                List<Items> cart = new List<Items>();
                cart.Add(new Items { Product = product, Quantity = 1 ,});
                
                Session["cart"] = cart;
            }
            else
            {
                List<Items> cart = (List<Items>)Session["cart"];
                int index = isExist(id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new Items { Product = product, Quantity = 1 });
                }
                Session["cart"] = cart;
            }
          return RedirectToAction("Index");
            
        }

        public ActionResult Remove(string id)
        {
            List<Items> cart = (List<Items>)Session["cart"];
            int index = isExist(id);
            cart.RemoveAt(index);
            Session["cart"] = cart;
            return RedirectToAction("Index");
        }

        private int isExist(string id)
        {
            List<Items> cart = (List<Items>)Session["cart"];
            for (int i = 0; i < cart.Count; i++)
                if (cart[i].Product.Id.Equals(id))
                    return i;
            return -1;
        }
    }
}