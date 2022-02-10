using System.Collections.Generic;
using DevCard.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevCard.Controllers
{
    public class HomeController : Controller
    {

        public List<Service> Services = new List<Service>()
        {
            new Service(1, "نقره"),
            new Service(3, "طلایی"),
            new Service(4, "پلاتینیوم"),
            new Service(5, "الماس")
        };

        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult Contact()
        {
            
            var model = new Contact()
            {
                Services = new SelectList(Services, "Id", "Name")
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Contact(Contact form)
        {    
            form.Services = new SelectList(Services, "Id", "Name");
        
            if (!ModelState.IsValid)
            {
                ViewBag.error = "اطلاعات وارد شده صحیح نمی باشد";
                return View(form);
            }

            ModelState.Clear();
            form = new Contact
            {
                Services = new SelectList(Services, "Id", "Name")
            };

            ViewBag.success = "عملیات با موفقینت انجام شد";
            return View(form);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
