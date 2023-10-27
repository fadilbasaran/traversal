using System;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.Default
{
	public class _PopularDestinationsPartial:ViewComponent
	{

		DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
		public IViewComponentResult Invoke()
		{
			var values = destinationManager.TGetList();

			return View(values);
		}
		
	}
}

