﻿using System;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.Default
{
	public class _TestimonialPartial:ViewComponent
	{

        TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialDal());

        public IViewComponentResult Invoke()
        {

            var values = testimonialManager.TGetList();
            return View(values);
        }
    }
}

