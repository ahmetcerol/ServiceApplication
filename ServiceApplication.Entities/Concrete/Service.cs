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
        public string CUSTOMER_SURNAME { get; set; }
        public string CUSTOMER_TELEPHONE { get; set; }
        public string CUSTOMER_EMAIL { get; set; }
        public string CUSTOMER_ADRESS { get; set; }
        public string PERSON_OF_CONTACT { get; set; }
        public string DETAILS_OF_PROPERTY { get; set; }
        public int PRICE_OF_DAY { get; set; }
        public string JOB_KIND { get; set; }
        public DateTime START_DATE { get; set; }
        public DateTime CUT_DATE { get; set; } 
        public DateTime START_ACT_DATE { get; set; }
        public string DATE_OF_SER_ACT { get; set; }   
        public int SERVICE_CHARGE { get; set; }
        public string SPECIAL_NOTE { get; set; }
        public byte[] SELECTED_IMAGE_DATA { get; set; } 
    }
}
