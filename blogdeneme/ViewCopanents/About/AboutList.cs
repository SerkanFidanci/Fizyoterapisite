using BussinesLayer.Concrate;
using DataAccesLayer.EntitiyFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace blogdeneme.ViewCopanents.About
{

    public class AboutList:ViewComponent
    {
        AboutManeger aboutMeneger = new AboutManeger(new EfAboutDal());
        public IViewComponentResult Invoke()
        {
            var values = aboutMeneger.TGetList();
            return View(values);
        }
    }
}
