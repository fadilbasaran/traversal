using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramwork
{
	public class EfTestimonialDal : GenericRepository<Testimonial>, ITestimonialDal
    {
		
	}
}

