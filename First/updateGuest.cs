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
    public partial class updateGuest : Form
    {
        private Database_Access Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        public updateGuest()
        {
            InitializeComponent();
            Da = new Database_Access();
        }
        private void SearchGuestByID(string guestID)
        {
            this.Sql = @"SELECT * FROM guestList WHERE id = '" + guestID + "';";
            DataTable dt = this.Da.ExecuteQueryTable(this.Sql);

            if (dt.Rows.Count == 1)
            {
                this.txtName.Text = dt.Rows[0]["name"].ToString();
                this.txtNum.Text = dt.Rows[0]["mobNum"].ToString();
                this.cmbGender.Text = dt.Rows[0]["gender"].ToString();
                this.cmbRType.Text = dt.Rows[0]["roomType"].ToString();
                this.cmbRNo.Text = dt.Rows[0]["roomno"].ToString();
                this.txtPayment.Text = dt.Rows[0]["payment"].ToString();
                this.txtNID.Text = dt.Rows[0]["nidNo"].ToString();
            }
            else
            {
                //this.txtID.ReadOnly = false;
                MessageBox.Show("No guest found with the provided ID.");
                //ClearAll();
            }
        }
        private void ClearAll()
        {
            this.txtID.Clear();
            //this.txtID.ReadOnly = true;
            this.txtName.Clear();
            this.txtNum.Clear();
            this.cmbGender.SelectedIndex = -1;
            this.cmbRType.SelectedIndex = -1;
            this.cmbRNo.SelectedIndex = -1;
            this.txtPayment.Clear();
            this.txtNID.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                this.Sql = "UPDATE guestList SET " +
                "name = '" + this.txtName.Text + "', " +
                "mobNum = '" + this.txtNum.Text + "', " +
                "gender = '" + this.cmbGender.Text + "', " +
                "roomType = '" + this.cmbRType.Text + "', " +
                "roomNo = '" + this.cmbRNo.Text + "', " +
                "payment = '" + this.txtPayment.Text + "', " +
                "nidNo = '" + this.txtNID.Text + "' " +
                "WHERE id = '" + this.txtID.Text + "';";

                int count = this.Da.ExecuteUpdateQuery(this.Sql);
                if (count == 1)
                {
                    MessageBox.Show(this.txtName.Text + " has been updated successfully");
                    this.ClearAll();
                }
                else
                {
                    MessageBox.Show("Guest update failed");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occurred during updating the guest data\n\n" + exc.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string guestID = this.txtID.Text.Trim();
            SearchGuestByID(guestID);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            this.Hide();
            d.Show();
        }

        private void Add_Click(object sender, EventArgs e)
        {

        }
    }
}
