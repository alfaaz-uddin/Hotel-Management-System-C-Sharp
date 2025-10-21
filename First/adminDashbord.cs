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
    public partial class adminDashbord : Form
    {
        public adminDashbord()
        {
            InitializeComponent();
        }

        private void btnManageStaff_Click(object sender, EventArgs e)
        {
            staffDashbord s = new staffDashbord();
            this.Hide();
            s.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LginForm l = new LginForm();
            this.Hide();
            l.Show();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            AddGuest ag = new AddGuest(this);
            this.Hide();
            ag.Show();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            checkOut c = new checkOut(this);
            this.Hide();
            c.Show();
        }

        private void btnManageTask_Click(object sender, EventArgs e)
        {
            AssignTask a = new AssignTask();
            this.Hide();
            a.Show();
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnGuestList_Click(object sender, EventArgs e)
        {

        }
    }
}
