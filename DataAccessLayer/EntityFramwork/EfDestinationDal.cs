
using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramwork
{
	public class EfDestinationDal : GenericRepository<Destination>, IDestinationalDal
    {
		
	}
}

