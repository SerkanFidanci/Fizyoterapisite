using BussinesLayer.Concrate;
using DataAccesLayer.EntitiyFreamwork;
using EntitiyLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace blogdeneme.Controllers
{
    public class DefultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult HeadPartial()
        {
            return PartialView();   
        }
        public PartialViewResult FooterPartial()
        {
            return PartialView();   
        }
        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }
        public PartialViewResult SendMessage(Message p)
        {
            MeesageManeger messageManeger = new MeesageManeger(new EfMessageDal());
            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.Status = true;
            messageManeger.TADD(p);
            return PartialView();
        }
    }
}
