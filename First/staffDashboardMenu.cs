using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First
{
    public partial class staffDashboardMenu : Form
    {
        public staffDashboardMenu()
        {
            InitializeComponent();
        }

        private void btnManageTask_Click(object sender, EventArgs e)
        {
           /* ManageTask d = new ManageTask();
            this.Hide();
            d.Show();*/
        }

        private void pictureManageTask_Click(object sender, EventArgs e)
        {
           /* ManageTask d = new ManageTask();
            this.Hide();
            d.Show();*/
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LginForm l = new LginForm();
            this.Hide();
            l.Show();
        }

        private void btnManageStaff_Click(object sender, EventArgs e)
        {
            staffDashbord sd = new staffDashbord();
            this.Hide();
            sd.Show();
        }

        private void pictureCheckTask_Click(object sender, EventArgs e)
        {
            staffDashbord sd = new staffDashbord();
            this.Hide();
            sd.Show();
        }
    }
}
