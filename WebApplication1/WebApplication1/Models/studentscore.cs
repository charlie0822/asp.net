using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace WebApplication1.Models
{
    public class studentscore
    {
        [Display(Name="學號")]
        public int ID { get; set; }
        [Display(Name = "名字")]
        public string Name { get; set; }
        [Display(Name = "國文")]
        public int Chinese { get; set; }
        [Display(Name = "數學")]
        public int math { get; set; }
        [Display(Name = "英文")]
        public int English { get; set; }
        [Display(Name = "總和")]
        public int Total { get; set; }

    }
}