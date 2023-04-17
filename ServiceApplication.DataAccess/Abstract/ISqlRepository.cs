using ServiceApplication.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApplication.DataAccess.Abstract
{
    public interface ISqlRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll();   
    }
}
