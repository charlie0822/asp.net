using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ChartsController : Controller
    {
        // GET: Charts
        public ActionResult Linetemperature()
        {
            return View();
        }

        public ActionResult Linetemperaturedata()
        {
            string[] month = { "1月", "2月", "3月", "4月", "5月", "6月", "7月", "8月", "9月", "10月", "11月", "12月" };
            ViewBag.Monthlabel = month;
            List<Location> locations = new List<Location>
            {
                new Location
                {
                    City="台北",
                    Temperate=new double[] {16.5,16.1,18.5,21.7,25.7,27.9,33.8,34.1,29.2,27.5,22.1,21.0}
                },
                new Location
                {
                    City="台中",
                    Temperate = new double[]{17.2,18.3,19.9,22.1,24.6,28.4,32.8,34.0,33.1,28.6,25.4,24.9}
                },
                new Location
                {
                    City="高雄",
                    Temperate = new double[]{19.2,20.3,22.2,23.5,27.3,29.9,33.8,36.1,34.1,30.5,27.2,25.3}
                }

            };
            return View(locations);
        }
    }
}