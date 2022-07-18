using BussinesLayer.Concrate;
using DataAccesLayer.EntitiyFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace blogdeneme.ViewCopanents.Portfolio
{
    public class PortfolioList:ViewComponent
    {
        PortfolioManeger portfolioDal = new PortfolioManeger(new EfPortfolioDal());
        public IViewComponentResult Invoke()
        {
            var values = portfolioDal.TGetList();   
            return View(values);  
        }
    }
}
