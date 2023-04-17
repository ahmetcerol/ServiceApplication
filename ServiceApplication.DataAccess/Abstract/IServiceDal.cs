using ServiceApplication.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApplication.DataAccess.Abstract
{
    public interface IServiceDal: ISqlRepository<Service>
    {
        void Add(Service service);
    }
}
