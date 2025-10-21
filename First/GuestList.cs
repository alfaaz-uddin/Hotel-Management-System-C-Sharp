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
    public partial class GuestList : Form
    {
        private Database_Access Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        public GuestList()
        {
            InitializeComponent();
            dvgGuestList.AllowUserToAddRows = false;
            Da = new Database_Access();
            PopulateGridView();
        }

        private void PopulateGridView(string sql = "select * from guestList;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dvgGuestList.AutoGenerateColumns = false;
            this.dvgGuestList.DataSource = this.Ds.Tables[0];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Sql = "select * from guestList where ID like '" + this.txtId.Text + "%';";
            this.PopulateGridView(this.Sql);
            if (this.Ds.Tables[0].Rows.Count > 0)
            {
                this.dvgGuestList.AutoGenerateColumns = true;
                this.dvgGuestList.DataSource = this.Ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Invalid Guest ID. Please try again.");
                this.dvgGuestList.DataSource = null;
                PopulateGridView();
            }
        }

        private void dvgGuestList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.txtId.Clear();
            PopulateGridView();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            this.Hide();
            d.Show();
        }

        private void GuestList_Load(object sender, EventArgs e)
        {

        }
    }
}
