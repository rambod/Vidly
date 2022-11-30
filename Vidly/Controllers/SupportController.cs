using Microsoft.AspNetCore.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class SupportController : Controller
    {
        public IActionResult Index()
        {
            var support = new Support() {Name = "Rambod" ,Description="Nadarim hichi toosh" };
            return View(support);
        }
    }
}
