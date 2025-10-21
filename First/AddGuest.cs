using System;
using System.Data;
using System.Windows.Forms;

namespace First
{
    public partial class AddGuest : Form
    {
        private Database_Access Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        private Form previousForm { get; set; }

        public AddGuest(Form previousForm)
        {
            InitializeComponent();
            Da = new Database_Access();
            GenerateGuestID();
            this.previousForm = previousForm;
            //Session.CurrentReceptionist = receptionistNameFromDatabase;
        }

        private void GenerateGuestID()
        {
            this.Sql = "select * from guestList order by id desc;";
            DataTable Dt = this.Da.ExecuteQueryTable(this.Sql);

            if (Dt.Rows.Count > 0) 
            {
                string id = Dt.Rows[0]["id"].ToString();
                string[] str = id.Split('G');
                int n = Convert.ToInt32(str[1]);
                string newId = "G" + (++n).ToString("d4");
                this.txtID.Text = newId;
            }
            else
            {
                this.txtID.Text = "G0001";
            }
        }




        private void ClearAll()
        {
            this.txtID.Clear();
            this.txtID.ReadOnly = true;
            this.txtName.Clear();
            this.txtNum.Clear();
            this.cmbGender.SelectedIndex = -1;
            this.cmbRType.SelectedIndex = -1;
            this.cmbRNo.SelectedIndex = -1;
            this.txtPayment.Clear();
            this.txtNID.Clear();
            GenerateGuestID();
        }

        private void btnAdd(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(this.txtID.Text) ||
                    string.IsNullOrWhiteSpace(this.txtName.Text) ||
                     string.IsNullOrWhiteSpace(this.txtNum.Text) ||
                    string.IsNullOrWhiteSpace(this.cmbGender.Text) ||
                    string.IsNullOrWhiteSpace(this.cmbRNo.Text) ||
                    string.IsNullOrWhiteSpace(this.cmbRType.Text) ||
                    string.IsNullOrWhiteSpace(this.cmbRNo.Text) ||
                    string.IsNullOrWhiteSpace(this.txtPayment.Text) ||
                    string.IsNullOrWhiteSpace(this.txtNID.Text))
                {
                    MessageBox.Show("All fields are required. Please Check Again");
                    return;
                }

                
                if (!int.TryParse(this.txtNum.Text, out _) || this.txtNum.Text.Length != 11)
                {
                    MessageBox.Show("Mobile Number is Invalid!");
                    return;
                }

                this.Sql = @"INSERT INTO guestList
                VALUES ('" + this.txtID.Text + "', '" + this.txtName.Text + "', '" + this.txtNum.Text +  "', '" + this.cmbGender.Text + "', '" + this.cmbRType.Text + "', '" + this.cmbRNo.Text + "', '" + this.txtPayment.Text + "', '" + this.txtNID.Text + "', '" + Session.CurrentReceptionist + "', '" + Session.CurrentReceptionistID + "');";

                int count = this.Da.ExecuteUpdateQuery(this.Sql);
                if (count == 1)
                {
                    MessageBox.Show(this.txtName.Text + " has been added successfully");

                    PdfGenerator.GenerateInvoice(
                    this.txtID.Text,
                    this.txtName.Text,
                    this.cmbRNo.Text,
                    this.cmbRType.Text,
                    this.txtPayment.Text,
                    Session.CurrentReceptionist

                );
                }
                else
                {
                    MessageBox.Show("Guest adding failed");
                }
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during saving the student data\n\n" + exc.Message);
            }
        }



        private void btnBack(object sender, EventArgs e)
        {
            //Dashboard d = new Dashboard();
            this.Hide();
            previousForm.Show(); previousForm.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}
