using FoodyTekmerDataAccessLayer.Context;
using FoodyTekmerEntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace FoodyTekmerWebUı.Controllers
{
    public class CategoryController : Controller
    {
        FoodyContext context = new FoodyContext();  // sınıftan new ile nesne oluşturduk  
        public IActionResult Index()
        {
            var values = context.Categories.ToList();
            return View(values);   
        }
        [HttpGet]
        public IActionResult CreateCategory() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCategory(Category p)    //Aşırı yükleme aynı metodun birden fazla çalışması overload 
        {
            context.Categories.Add(p);
            context.SaveChanges();  // değişiklikleri kaydet
            return RedirectToAction("Index");
        }
        public IActionResult DeleteCategory(int id )   // parametrree göndereceksek mutlaka id olmalı 
        {
            var value = context.Categories.Find(id);
            context.Categories.Remove(value);
            context.SaveChanges(); 
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateCategory(int id)
        {
            var value = context.Categories.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateCategory(Category p)
        {
            context.Categories.Update(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
