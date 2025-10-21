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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            AddGuest ag = new AddGuest(this);
            this.Hide();
            ag.Show();
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            updateGuest ug = new updateGuest();
            this.Hide();
            ug.Show();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            checkOut c = new checkOut(this);
            this.Hide();
            c.Show();
        }

        private void btnGuestList_Click(object sender, EventArgs e)
        {
            GuestList gl = new GuestList();
            this.Hide();
            gl.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LginForm l = new LginForm();
            this.Hide();
            l.Show();
        }

    }
}
