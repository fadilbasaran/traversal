using System;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.Default
{
	public class _FeaturePartial:ViewComponent
	{
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());

        public IViewComponentResult Invoke()
        {
            //var values = featureManager.TGetList();
           // ViewBag.image1=featureManager.
            return View();
        }
    }
}

