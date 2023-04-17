using ServiceApplication.Bussiness.Abstract;
using ServiceApplication.Bussiness.Concrete;
using ServiceApplication.DataAccess.Concrete.SQL;
using ServiceApplication.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceApplication.UI.Forms
{
    public partial class ServiceInformationPage : Form
    {
        private IServiceService _serviceService;
        public ServiceInformationPage()
        {
            _serviceService = new ServiceManager(new ServiceDal());
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (tbxAddress.Text == String.Empty || tbxName.Text == String.Empty || tbxPriceDay.Text == String.Empty || 
                tbxProperty.Text == String.Empty || tbxSurname.Text == String.Empty)
            {
                MessageBox.Show("Please fill in all fields");}

            else
            {
                _serviceService.Add(new Service
                {
                    CUSTOMER_NAME = tbxName.Text + tbxSurname,
                    CUSTOMER_ADDRESS = tbxAddress.Text,
                    DATE_SERTAKEPLACE = Convert.ToDateTime(dtpStartDate.Text),
                    DATE_SERTOOKPLACE = Convert.ToDateTime(dtpActualStartDate.Text),
                    DATE_TWOWEEKS = Convert.ToDateTime(dtpActualStartDate.Text + 14),
                    DESC_PROPERTY = tbxProperty.Text,
                    //CHARGE_BEING =
                    //CHARGE_DONE =
                    //PAID_ALONG =
                    //BALANCE =
                });
            }
        }
    }
}
