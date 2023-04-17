using ServiceApplication.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApplication.Entities.Concrete
{
    public class Service:IEntity
    {
        public int SERVICE_ID { get; set; }
        public string CUSTOMER_NAME { get; set;}
        public string CUSTOMER_ADDRESS { get; set; }
        public string DESC_PROPERTY { get; set; }
        public DateTime DATE_SERTAKEPLACE { get; set; }
        public DateTime DATE_SERTOOKPLACE { get; set; } 
        public DateTime DATE_TWOWEEKS { get; set; }
        public int CHARGE_BEING { get; set; }   
        public int CHARGE_DONE { get; set; }
        public int PAID_ALONG { get; set; }
        public int BALANCE { get; set; }

    }
}
