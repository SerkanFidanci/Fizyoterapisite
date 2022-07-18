using BussinesLayer.Concrate;
using DataAccesLayer.EntitiyFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace blogdeneme.ViewCopanents.Contact
{
    public class ContactDetails: ViewComponent
    {
        ContactManeger contactManeger = new ContactManeger(new EfContactDal());

        public IViewComponentResult Invoke()
        {
            var values = contactManeger.TGetList();

            return View(values);
        }
    }
}
