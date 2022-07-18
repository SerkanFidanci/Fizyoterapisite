using BussinesLayer.Concrate;
using DataAccesLayer.EntitiyFreamwork;
using EntitiyLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace blogdeneme.Controllers
{
    public class ExperinceController : Controller
    {  
        ExperienceManeger experienceManeger= new ExperienceManeger(new EfExperienceDal());
       
        public IActionResult Index()
        {
         var values = experienceManeger.TGetList();
            return View(values);
        }
        public IActionResult AddExperience()
        {
            return View();  
        }
        [HttpPost]
        public IActionResult AddExperience(Experience blog)
        {
            blog.Date = "şimdi";
            experienceManeger.TADD(blog);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteExperience(int id)
        {
            var values = experienceManeger.TGetByID(id);
            experienceManeger.TDelete(values);
            return RedirectToAction("Index");
        }
    }
}
