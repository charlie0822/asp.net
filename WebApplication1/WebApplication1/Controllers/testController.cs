using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class testController : Controller
    {
        // GET: test
        public ActionResult Index()
        {
            ViewData["Name"] = "charlie";
            ViewData["age"] = 22;
            ViewData["single"] = true;
            List<string> petlist = new List<string>();
            petlist.Add("鸚鵡");
            petlist.Add("貓");
            petlist.Add("狗");
            petlist.Add("魚");
            ViewData.Model = petlist;
            return View();
        }
        public ActionResult Passmassage()
        {
            TempData["errormassage"] = "發生錯誤";
            TempData["username"] = "charlie";
            TempData["time"] = DateTime.Now.ToLongTimeString();
            return RedirectToAction(" Errormassage");            
        }
        public ActionResult Errormassage()
        {
           /* if(!TempData.ContainsKey("errormassage"))
            {
                return new EmptyResult();
            }*/
            TempData.Keep();
            return View();
        }
    }
}