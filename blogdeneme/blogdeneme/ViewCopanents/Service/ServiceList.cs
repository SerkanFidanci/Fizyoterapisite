using BussinesLayer.Concrate;
using DataAccesLayer.EntitiyFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace blogdeneme.ViewCopanents.Service
{
    public class ServiceList:ViewComponent
    {
        ServiceManeger serviceManeger = new ServiceManeger(new EfServiceDal());
        public IViewComponentResult Invoke()
        {
            var values = serviceManeger.TGetList();
            return View(values);
        }
    }
}
