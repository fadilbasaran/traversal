using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramwork
{
	public class EfFeature2Dal : GenericRepository<Feature2>, IFeature2Dal
    {
	}
}

