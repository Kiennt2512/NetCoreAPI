using System.ComponentModel.Design;
using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
namespace MVCApp.Controllers
{
    public class DemoController : Controller
    {
        //khai bao cac phuong thuc
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string fName)
        {
            //gui du lieu ve view su dung ViewBag
            ViewBag.message = "Hello " + fName;
            return View();
        }
    }
}