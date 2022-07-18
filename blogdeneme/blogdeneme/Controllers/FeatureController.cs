using Microsoft.AspNetCore.Mvc;

namespace blogdeneme.Controllers
{
    public class FeatureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
