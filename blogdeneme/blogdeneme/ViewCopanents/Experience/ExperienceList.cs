using BussinesLayer.Concrate;
using DataAccesLayer.EntitiyFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace blogdeneme.ViewCopanents.Experience
{
    public class ExperienceList:ViewComponent
    {
        ExperienceManeger experienceDal = new ExperienceManeger(new EfExperienceDal());
        public IViewComponentResult Invoke()
        {
            var values = experienceDal.TGetList();
            return View(values);  
        }
    }
}
