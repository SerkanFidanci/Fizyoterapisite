

using BussinesLayer.Concrate;
using DataAccesLayer.EntitiyFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace blogdeneme.ViewCopanents.Feature
{
    public class FeatureList:ViewComponent
    {
        FeatureMeneger featureMeneger = new FeatureMeneger(new EfFeatureDal());
        public IViewComponentResult Invoke()
        {
            var values = featureMeneger.TGetList();
            return View(values);  
        }
    }
}
