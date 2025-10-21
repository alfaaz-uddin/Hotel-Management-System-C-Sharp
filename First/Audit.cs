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
    public partial class Audit : Form
    {
        private Database_Access Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }

        public Audit()
        {
            InitializeComponent();
            Da = new Database_Access();
            txtReportID.ReadOnly = true;
            PopulateGridView();
            GenerateReportID();
        }

        private void PopulateGridView(string sql = "SELECT * FROM Auditor;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvAuditor.AutoGenerateColumns = false;
            this.dgvAuditor.DataSource = this.Ds.Tables[0];
        }
        private void GenerateReportID()
        {
            this.Sql = "select * from Auditor order by ID desc;";
            DataTable Dt = this.Da.ExecuteQueryTable(this.Sql);

            if (Dt.Rows.Count == 0)
            {
                this.txtReportID.Text = "A001";
            }
            else
            {
                string id = Dt.Rows[0]["ID"].ToString();
                string[] str = id.Split('A');
                int n = Convert.ToInt32(str[1]);
                string newId = "A" + (++n).ToString("d3");
                this.txtReportID.Text = newId;
            }
        }

        private void ClearAll()
        {
            txtReportID.Clear();
            this.txtTitle.Clear();
            this.txtReportID.ReadOnly = true;
            this.txtDescription.Clear();
            this.cmbStatus.SelectedIndex = -1;
            this.txtSearchID.Clear();
            GenerateReportID();
        }

        private void panelBottom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Audit_Load(object sender, EventArgs e)
        {

        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void panelSearch_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtReportID.Text == "" || txtTitle.Text == "" || cmbStatus.Text == "")
                {
                    MessageBox.Show("Report ID, Title and Status are required.");
                    return;
                }


                this.Sql = "select * from Auditor where ID = '" + this.txtReportID.Text + "'";
                this.Ds = this.Da.ExecuteQuery(this.Sql);

                if (this.Ds.Tables[0].Rows.Count == 1)
                {
                    MessageBox.Show("Report ID already exists. Please use a different one or Update instead.");
                }
                else
                {

                    this.Sql = @"insert into Auditor(ID, Title, Description, Status)
                         values ('" + this.txtReportID.Text + "', '" + this.txtTitle.Text + "', " +
                                 (string.IsNullOrEmpty(this.txtDescription.Text) ? "NULL" : "'" + this.txtDescription.Text + "'") +
                                 ", '" + this.cmbStatus.Text + "');";

                    int count = this.Da.ExecuteUpdateQuery(this.Sql);
                    if (count == 1)
                    {
                        MessageBox.Show(this.txtReportID.Text + " has been added properly");
                        this.PopulateGridView();
                        this.ClearAll();
                        this.GenerateReportID();
                    }
                    else
                    {
                        MessageBox.Show("Report insertion failed");
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occurred during adding the report\n\n" + exc.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtReportID.Text == "" || txtTitle.Text == "" || cmbStatus.Text == "")
                {
                    MessageBox.Show("Report ID, Title and Status are required for update.");
                    return;
                }


                this.Sql = "select * from Auditor where ID = '" + this.txtReportID.Text + "'";
                this.Ds = this.Da.ExecuteQuery(this.Sql);

                if (this.Ds.Tables[0].Rows.Count == 1)
                {

                    this.Sql = @"update Auditor
                         set Title = '" + this.txtTitle.Text + @"',
                             Description = " + (string.IsNullOrEmpty(this.txtDescription.Text) ? "NULL" : "'" + this.txtDescription.Text + @"'") + @",
                             Status = '" + this.cmbStatus.Text + @"'
                         where ID = '" + this.txtReportID.Text + "';";

                    int count = this.Da.ExecuteUpdateQuery(this.Sql);
                    if (count == 1)
                    {
                        MessageBox.Show(this.txtReportID.Text + " has been updated properly");
                        this.PopulateGridView();
                        this.ClearAll();
                    }
                    else
                    {
                        MessageBox.Show("Report update failed");
                    }
                }
                else
                {
                    MessageBox.Show("No report found with this ID to update.");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error occurred during updating the report\n\n" + exc.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtReportID.Text == "")
                {
                    MessageBox.Show("Please enter a Report ID to remove.");
                    return;
                }


                this.Sql = "select * from Auditor where ID = '" + this.txtReportID.Text + "'";
                this.Ds = this.Da.ExecuteQuery(this.Sql);

                if (this.Ds.Tables[0].Rows.Count == 1)
                {

                    DialogResult result = MessageBox.Show("Are you sure you want to delete report " + this.txtReportID.Text + " ?",
                                                          "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        this.Sql = "delete from Auditor where ID = '" + this.txtReportID.Text + "'";
                        int count = this.Da.ExecuteUpdateQuery(this.Sql);

                        if (count == 1)
                        {
                            MessageBox.Show(this.txtReportID.Text + " has been removed successfully");
                            this.PopulateGridView();
                            this.ClearAll();
                        }
                        else
                        {
                            MessageBox.Show("Report deletion failed");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No report found with this ID to delete.");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error occurred during deleting the report\n\n" + exc.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchID.Text == "")
                {
                    MessageBox.Show("Please enter a Report ID to search.");
                    return;
                }

                this.Sql = "select * from Auditor where ID = '" + this.txtSearchID.Text + "'";
                this.Ds = this.Da.ExecuteQuery(this.Sql);

                if (this.Ds.Tables[0].Rows.Count == 1)
                {

                    txtTitle.Text = this.Ds.Tables[0].Rows[0]["Title"].ToString();
                    txtDescription.Text = this.Ds.Tables[0].Rows[0]["Description"].ToString();
                    cmbStatus.Text = this.Ds.Tables[0].Rows[0]["Status"].ToString();

                    MessageBox.Show("Report found and loaded.");
                }
                else
                {
                    MessageBox.Show("No report found with this ID.");
                    this.ClearAll();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error occurred during searching the report\n\n" + exc.Message);
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LginForm l = new LginForm();
            this.Hide();
            l.Show();
        }

        private void btnGuestReport_Click(object sender, EventArgs e)
        {
            guestReport gr = new guestReport();
            this.Hide();
            gr.Show();
        }
    }
}
