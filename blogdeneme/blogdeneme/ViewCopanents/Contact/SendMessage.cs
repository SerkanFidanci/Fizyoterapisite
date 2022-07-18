using BussinesLayer.Concrate;
using DataAccesLayer.EntitiyFreamwork;
using EntitiyLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace blogdeneme.ViewCopanents.Contact
{
    public class SendMessage:ViewComponent
    {
        MeesageManeger messageManeger = new MeesageManeger(new EfMessageDal());

        [HttpGet]
        public IViewComponentResult Invoke()
        {
         
            return View();
        }
        //[HttpPost]
        //public IViewComponentResult Invoke(Message p)
        //{
        //    p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        //    p.Status = true;
        //    messageManeger.TADD(p);
        //    return View("Mesajınız Gönderildi");
        //}

    }
}
