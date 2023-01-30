using BussinessLayer.Concrete;
using DataAccsessLayer.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _Feature : ViewComponent
    {
        FeatureManager featureManager = new FeatureManager(new  EfFeatureDal());


        public IViewComponentResult Invoke()
        {
          var values= featureManager.TGetList();
            return View(values);
        } 

    }
}
