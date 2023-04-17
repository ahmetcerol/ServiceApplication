using ServiceApplication.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApplication.Bussiness.Abstract
{
    public interface IServiceService
    {
        List<Service> GetAll();
        void Add(Service service);
    }
}
