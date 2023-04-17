
using ServiceApplication.Bussiness.Abstract;
using ServiceApplication.DataAccess.Abstract;
using ServiceApplication.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApplication.Bussiness.Concrete
{
    public class ServiceManager : IServiceService
    {
        private IServiceDal _serviceDal;
        public ServiceManager(IServiceDal serviceDal) 
        {
            _serviceDal = serviceDal;

        }
        public void Add(Service service)
        {
            _serviceDal.Add(service);
        }

        public List<Service> GetAll()
        {
            return _serviceDal.GetAll();
        }
    }
}
