using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceApplication.UI
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private Form activateForm;
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activateForm != null)
            {
                activateForm.Close();
            }
            activateForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlChildForms.Controls.Add(childForm);
            this.pnlChildForms.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBackMain_Click(object sender, EventArgs e)
        {
            if (activateForm != null)
            {
                activateForm.Close();

            }
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ServiceInformationPage(), sender);
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ServiceInformationPage(), sender);
        }
    }
}
