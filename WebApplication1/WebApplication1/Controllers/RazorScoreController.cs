using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class RazorScoreController : Controller
    {
        protected List<studentscore> studentscores = new List<studentscore>
        {
            new studentscore{ID=1,Name="charlie",Chinese=60,math=87,English=69},
            new studentscore{ID=2,Name="john",Chinese=32,math=57,English=90},
            new studentscore{ID=3,Name="mary",Chinese=88,math=62,English=98},
            new studentscore{ID=4,Name="bonn",Chinese=78,math=98,English=59},
            new studentscore{ID=5,Name="lex",Chinese=79,math=55,English=42},
            new studentscore{ID=6,Name="fuxk",Chinese=90,math=8,English=77},
        };

        public ActionResult Totalscore()
        {
            int topid = 0;
            int topscore = 0;
            foreach(var student in studentscores)
            {
                student.Total = student.Chinese + student.math + student.English;

                if(student.Total>topscore)
                {
                    topscore = student.Total;
                    topid = student.ID;
                }
            }

            ViewBag.topid = Convert.ToInt32(topid);
            return View(studentscores);
        }
        // GET: RazorScore
        public ActionResult Index()
        {
            return View(studentscores);
        }
    }
}