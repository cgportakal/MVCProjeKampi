using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SozlukUI.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager();
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetCategoryList()
        {
            var categoryValues = cm.GetAllBl();
            return View(categoryValues);//Bana View döndürürken de categoryValues içeriğini de getir.
        }
        public ActionResult AddCategory(Category p)
        {
            cm.CategoryAddBl(p);
            return RedirectToAction("GetCategoryList");
        }
    }
}