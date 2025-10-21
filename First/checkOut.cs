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
    public partial class checkOut : Form
    {
        private Database_Access Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        private Form previousForm { get; set; }
        public checkOut(Form previousForm)
        {
            InitializeComponent();
            Da = new Database_Access();
            this.previousForm = previousForm;
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
                MessageBox.Show("No guest found with the provided ID.");
                //ClearAll();
            }
        }

        private void DeleteGuestByID(string guestID)
        {
            try
            {
                this.Sql = @"DELETE FROM guestList WHERE id = '" + guestID + "';";
                int count = this.Da.ExecuteUpdateQuery(this.Sql);

                if (count == 1)
                {
                    MessageBox.Show("Guest checked out successfully.");
                    ClearAll(); 
                }
                else
                {
                    MessageBox.Show("Failed to checkout guest. Please check the Guest ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the guest:\n\n" + ex.Message);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string guestID = this.txtID.Text.Trim(); 
            SearchGuestByID(guestID);
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            try
            {
                string guestID = this.txtID.Text.Trim();
                if (!string.IsNullOrEmpty(guestID))
                {
                    DeleteGuestByID(guestID);
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid Guest ID.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Dashboard d = new Dashboard();
            this.Hide();
            previousForm.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}
