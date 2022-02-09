using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevCard.Controllers
{
    public class TestController : Controller
    {
        // public IActionResult Index()
        // {
        //     return View("Footer");
        // }

        //public ViewResult Index()
        //{
        //    return View("Footer");
        //}

        // public IActionResult Index()
        // {
        //     return PartialView("Footer");
        // }

        // public IActionResult Index()
        // {
        //     return Content("Footer");
        // }


        //public ContentResult Index()
        //{
        //    return Content("Footer");
        //}

        // public IActionResult Index()
        // {
        //     return new EmptyResult();
        //     //return null;
        // }

        // public EmptyResult Index()
        // {
        //     return new EmptyResult();
        // }




        //در این حالت عکس دانلود می شود
        //public IActionResult Index()
        //{

        //    var filebyte = System.IO.File.ReadAllBytes("wwwroot/amir.jpeg");
        //    const string filename = "amir.jpeg";

        //    return File("~/amir.jpeg", MediaTypeNames.Image.Jpeg);
        //}


        // public IActionResult Index()
        // {
        //     var filebyte = System.IO.File.ReadAllBytes("wwwroot/amir.jpeg");
        //     const string filename = "amir.jpeg";
        //     return File(filebyte, MediaTypeNames.Image.Jpeg, filename);
        // }

        // public JavascriptResult Index()
        // {
        //     return new JavascriptResult("alert('heeeeeee sheeeeee meeeeedfjajf')");
        // }



    }

    // public class JavascriptResult : ContentResult
    // {
    //     public JavascriptResult(string data)
    //     {
    //         Content = data;
    //         ContentType = "Application/javascript";
    //     }
    // }
}
