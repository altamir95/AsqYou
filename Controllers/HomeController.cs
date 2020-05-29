using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Asqyou.Models;
using AskDispaly.Models;

namespace Asqyou.Controllers
{
    public class HomeController : Controller
    {
        QuastionsContext db;
        public HomeController(QuastionsContext context)
        {
            db = context;
        }
        [Route("")]
        public IActionResult Index()
        {
            return View(db.quastions.ToList());
        }
        [Route("Privacy")]
        public IActionResult Privacy()
        {
            return View();
        }
        [Route("Privacy")]
        [HttpPost]
        public IActionResult Privacy(Asq order)
        {
            db.asqs.Add(order);
            // сохраняем в бд все изменения
            db.SaveChanges();
            return Redirect("~/Privacy");

        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
