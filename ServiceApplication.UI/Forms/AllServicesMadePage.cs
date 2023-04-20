using ServiceApplication.Bussiness.Abstract;
using ServiceApplication.Bussiness.Concrete;
using ServiceApplication.DataAccess.Concrete.SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceApplication.UI.Forms
{
    public partial class AllServicesMadePage : Form
    {
        private IServiceService _serviceService;
        public AllServicesMadePage()
        {
            _serviceService = new ServiceManager(new ServiceDal());
            InitializeComponent();
        }

        private void AllServicesMadePage_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgwAll.DataSource = _serviceService.GetAll();
            dgwAll.Columns[0].Visible = false;
        }

        private void btnRefreshData_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgwAll_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwAll.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgwAll.SelectedRows[0].Index;
                DataGridViewRow selectedRow = dgwAll.Rows[selectedRowIndex];

                byte[] imageData = (byte[])selectedRow.Cells["SELECTION_IMAGE_DATA"].Value;
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    pbxServicePhoto.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pbxServicePhoto.Image = null;
            }
        }
    }
}
