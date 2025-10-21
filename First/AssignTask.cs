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
    public partial class AssignTask : Form
    {
        private Database_Access Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }

        public AssignTask()
        {
            InitializeComponent();
            Da = new Database_Access();
            txtTaskID.ReadOnly = true;
            PopulateGridView();
            GenerateTaskID();
        }

        private void GenerateTaskID()
        {
            this.Sql = "select * from assignTask order by TID desc;";
            DataTable Dt = this.Da.ExecuteQueryTable(this.Sql);
            string id = Dt.Rows[0]["TID"].ToString();
            string[] str = id.Split('T');
            int n = Convert.ToInt32(str[1]);
            string newId = "T" + (++n).ToString("d3");
            this.txtTaskID.Text = newId;
        }

        private void ClearAll()
        {
            txtTaskName.Clear();
            this.txtTaskID.Clear();
            this.txtTaskID.ReadOnly = true;
            this.txtTaskDescription.Clear();
            this.txtReportTime.Clear();
            this.cmbStaffName.SelectedIndex = -1;
            this.cmbStatus.SelectedIndex = -1;
            GenerateTaskID();
        }

        private void PopulateGridView(string sql = "SELECT * FROM assignTask;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvStaffTask.AutoGenerateColumns = false;
            this.dgvStaffTask.DataSource = this.Ds.Tables[0];
        }

        private void LoadStaffNames()
        {
            try
            {
                string sql = "SELECT ID, sName FROM sList";
                Database_Access da = new Database_Access();
                DataSet ds = da.ExecuteQuery(sql);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    ds.Tables[0].Columns.Add("DisplayText", typeof(string));

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        row["DisplayText"] = row["sName"].ToString() + " (" + row["ID"].ToString() + ")";
                    }

                    cmbStaffName.DataSource = ds.Tables[0];
                    cmbStaffName.DisplayMember = "DisplayText";  
                    cmbStaffName.ValueMember = "ID";              
                    cmbStaffName.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("No staff data found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading staff: " + ex.Message);
            }
        }
        private void ManageTask_Load(object sender, EventArgs e)
        {
            LoadStaffNames();
        }

        private void panelBottom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTaskDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdateTask_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTaskID.Text == "")
                {
                    MessageBox.Show("Please search a task to update.");
                    return;
                }

                if (txtTaskName.Text == "" || cmbStatus.Text == "")
                {
                    MessageBox.Show("Task Name and Status are required for update.");
                    return;
                }

                this.Sql = @"UPDATE assignTask SET
                          SNAME = '" + cmbStaffName.Text + @"',
                          TNAME ='" + txtTaskName.Text + @"',
                          TDESCRIPTION='" + txtTaskDescription.Text + @"',
                          TIME='" + txtReportTime.Text + @"',  
                          STATUS='" + cmbStatus.Text + @"'
                          WHERE TID='" + txtTaskID.Text + "';";

                int count = this.Da.ExecuteUpdateQuery(this.Sql);
                if (count == 1)
                {
                    MessageBox.Show(txtTaskID.Text + " has been updated successfully");
                    txtTaskID.ReadOnly = true;
                    PopulateGridView();
                }
                else
                {
                    MessageBox.Show("Task update failed");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error occurred during updating task data\n\n" + exc.Message);
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTaskName.Text == "" || cmbStatus.Text == "")
                {
                    MessageBox.Show("Task Name and Status are required.");
                    return;
                }

                this.Sql = "SELECT * FROM assignTask WHERE TID='" + txtTaskID.Text + "'";
                this.Ds = this.Da.ExecuteQuery(this.Sql);
                if (this.Ds.Tables[0].Rows.Count == 1)
                {
                    MessageBox.Show("Task ID already exists. Use search to update.");
                    return;
                }

                this.Sql = @"INSERT INTO assignTask (SNAME,TID,TNAME, TDESCRIPTION, TIME, STATUS)
                          VALUES ('" + cmbStaffName.Text + "', '" + txtTaskID.Text + "', '" + txtTaskName.Text + "','"+ txtTaskDescription.Text + "', '" + txtReportTime.Text + "','" + cmbStatus.Text + "');";

                int count = this.Da.ExecuteUpdateQuery(this.Sql);
                if (count == 1)
                {
                    MessageBox.Show(txtTaskID.Text + " has been added successfully");
                    ClearAll();
                    PopulateGridView();
                }
                else
                {
                    MessageBox.Show("Task Insertion Failed!!");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error occurred during saving task data\n\n" + exc.Message);
            }

        }

        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            try
            {
                string ID = dgvStaffTask.CurrentRow.Cells["TID"].Value.ToString();
                string NAME = dgvStaffTask.CurrentRow.Cells["SNAME"].Value.ToString();

                this.Sql = "DELETE FROM assignTask WHERE TID='" + ID + "'";
                int count = this.Da.ExecuteUpdateQuery(this.Sql);
                if (count == 1)
                    MessageBox.Show(NAME + " has been deleted");
                else
                    MessageBox.Show("Task deletion failed");

                ClearAll();
                PopulateGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error occurred during deletion\n" + exc.Message);
            }
        }

        private void btnClearTask_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            ClearAll();
            PopulateGridView();
        }

        private void cmbStaffName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtReportTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvStaffTask_DoubleClick(object sender, EventArgs e)
        {
            if (dgvStaffTask.CurrentRow != null)
            {
                try
                {
                    this.cmbStaffName.Text = dgvStaffTask.CurrentRow.Cells["SNAME"].Value?.ToString();
                    this.txtTaskID.ReadOnly = true;
                    this.txtTaskID.Text = dgvStaffTask.CurrentRow.Cells["TID"].Value?.ToString();
                    this.txtTaskName.Text = dgvStaffTask.CurrentRow.Cells["TNAME"].Value?.ToString();
                    this.txtTaskDescription.Text = dgvStaffTask.CurrentRow.Cells["TDESCRIPTION"].Value?.ToString();
                    this.txtReportTime.Text = dgvStaffTask.CurrentRow.Cells["TIME"].Value?.ToString();
                    this.cmbStatus.Text = dgvStaffTask.CurrentRow.Cells["STATUS"].Value?.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading Staff details: " + ex.Message);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            adminDashbord a = new adminDashbord();
            this.Hide();
            a.Show();
        }

        private void dgvStaffTask_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
