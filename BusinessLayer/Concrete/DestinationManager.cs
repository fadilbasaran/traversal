using System;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
	public class DestinationManager:IDestinationService
	{
		IDestinationalDal _destinationalDal;

        public DestinationManager(IDestinationalDal destinationalDal)
        {
            _destinationalDal = destinationalDal;
        }


        public void TAdd(Destination t)
        {
            _destinationalDal.Insert(t);
        }

        public void TDelete(Destination t)
        {
            throw new NotImplementedException();
        }

        public Destination TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Destination> TGetList()
        {
            return _destinationalDal.GetList();
        }

        public void TUpdate(Destination t)
        {
            throw new NotImplementedException();
        }
    }
}

