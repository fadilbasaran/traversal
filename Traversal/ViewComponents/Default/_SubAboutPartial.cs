﻿using System;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.Default
{
	public class _SubAboutPartial:ViewComponent
	{

        SubAboutManager subAboutManager = new SubAboutManager(new EfSubAboutDal());

        public IViewComponentResult Invoke()
        {

            var values = subAboutManager.TGetList();
            return View(values);
        }
    }
}

