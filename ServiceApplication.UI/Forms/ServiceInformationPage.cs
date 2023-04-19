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
        private string PictureFileName;
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
                    CUSTOMER_NAME = tbxName.Text,
                    CUSTOMER_ADDRESS = tbxAddress.Text,
                    CUSTOMER_TELEPHONE = Convert.ToInt32(txTelephoneNumber),
                    CUSTOMER_EMAİL = tbxEmail.Text,
                    PERSON_OF_CONTACT = tbxPersonofContact.Text,
                    DESC_PROPERTY = tbxProperty.Text,
                    SPECİAL_NOTE = rbxSpecialNote.Text,
                    ACTUALLY_PERFORMED = Convert.ToInt32(tbxActuallyPerformed.Text),
                    JOB_KİND = cbxJobs.SelectedItem.ToString(),
                    DATE_SERTAKEPLACE = Convert.ToDateTime(dtpStartDate.Value),
                    DATE_SERTOOKPLACE = Convert.ToDateTime(dtpActualStartDate.Value),
                    DATE_TWOWEEKS = Convert.ToDateTime(dtpNextCutDate.Value),
                   /*buraya fiyat charge falan gelmesi lazım fakat ben anlamadım o ksımını*/

                }) ;
            }
        }

        private void btnSelectPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog file= new OpenFileDialog();
            file.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            file.Filter = "*.png || *.jpg";
            file.CheckFileExists = false;
            file.Title = "Select a Picture...";
            file.ShowDialog();
            if (file.ShowDialog()==DialogResult.OK)
            {
                string FilePath = file.FileName;
                string NameofFile = file.SafeFileName;
            }
            pbxPicture.Image = Image.FromFile(file.FileName);
            PictureFileName = file.FileName;
        }
    }
}
