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
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
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
        private bool IsValidEmail(string email)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
        private async Task DelayMethod()
        {
            await Task.Delay(2000);
            lblControlText.Text = "";
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (tbxAddress.Text == String.Empty || tbxName.Text == String.Empty || tbxPriceDay.Text == String.Empty || 
                tbxProperty.Text == String.Empty || tbxSurname.Text == String.Empty)
            {
                MessageBox.Show("Please fill in all fields");}
            else if (IsValidEmail(tbxEmail.Text))
            {
                lblControlText.Text = "E-mail is not valid";
            }
            else
            {
                lblControlText.Text = "E-mail is  valid";
                btnCalculate_Click(sender,e);
                DelayMethod();
                _serviceService.Add(new Service
                { 
                    CUSTOMER_NAME = tbxName.Text,
                    CUSTOMER_SURNAME = tbxName.Text,
                    CUSTOMER_TELEPHONE = Convert.ToInt32(txTelephoneNumber.Text),
                    CUSTOMER_EMAIL = tbxEmail.Text,
                    CUSTOMER_ADRESS = tbxAddress.Text,
                    PERSON_OF_CONTACT = tbxPersonofContact.Text,
                    DETAILS_OF_PROPERTY = tbxProperty.Text,
                    PRICE_OF_DAY = Convert.ToInt32(tbxPriceDay.Text),
                    JOB_KIND = cbxJobs.Text,
                    START_DATE = Convert.ToDateTime(dtpStartDate.Value),
                    CUT_DATE = Convert.ToDateTime(dtpNextCutDate.Value),
                    START_ACT_DATE = Convert.ToDateTime(dtpActualStartDate.Value),
                    DATE_OF_SER_ACT =Convert.ToDateTime( tbxActuallyPerformed.Text),
                    SERVICE_CHARGE = Convert.ToInt32(tbxServiceCharge.Text),
                    SPECIAL_NOTE = rbxSpecialNote.Text,

                });
            }
        }
        private void btnSelectPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog file= new OpenFileDialog();
            file.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            file.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
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

 
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (dtpActualStartDate.Value > dtpNextCutDate.Value)
            {
                MessageBox.Show("Enter a correct Date");
            }
            else if (dtpStartDate.Value > dtpActualStartDate.Value)
            {
                MessageBox.Show("Enter a correct Date");
            }
            else
            {
                DateTime actualOfStartDate = dtpActualStartDate.Value;
                DateTime nextCutDate = dtpNextCutDate.Value;
                DateTime startDate= dtpStartDate.Value;
                int DayCount = Convert.ToInt32(tbxPriceDay.Text);
                tbxActuallyPerformed.Text= GecenGunSayisi(actualOfStartDate, nextCutDate).ToString();
                tbxServiceCharge.Text = ServiceCharge(startDate, nextCutDate,DayCount).ToString();



            }
        }

        public int GecenGunSayisi(DateTime ilkTarihSecici, DateTime ikinciTarihSecici)
        {
            DateTime ilkTarih = ilkTarihSecici;
            DateTime ikinciTarih = ikinciTarihSecici;

            TimeSpan fark = ikinciTarih - ilkTarih;

            return (int)fark.TotalDays;
        }

        public int ServiceCharge(DateTime dateTime, DateTime dateTimeEnd,int DayCount) {

            DateTime ilkTarih = dateTime;
            DateTime ilkTarihEnd = dateTimeEnd;
            TimeSpan fark = ilkTarih - ilkTarihEnd;
            return (int)fark.TotalDays*DayCount;

        }
    }
}
