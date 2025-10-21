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
    public partial class ManageTask : Form
    {
        private Database_Access Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        private String CurrentStaffName { get; set; }

        public ManageTask(string staffName)
        {
            InitializeComponent();
            Da = new Database_Access();
            txtTaskID.ReadOnly = true;
            this.CurrentStaffName = staffName;
            PopulateGridView();
            GenerateTaskID();
        }

        private void PopulateGridView(string sql = "")
        {
            if (string.IsNullOrEmpty(sql))
            {
                sql = "SELECT * FROM assignTask WHERE UPPER(SNAME) LIKE UPPER('" + CurrentStaffName + "%');";
            }

            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvStaffTask.AutoGenerateColumns = false;
            this.dgvStaffTask.DataSource = this.Ds.Tables[0];
        }


        private void GenerateTaskID()
        {
            this.Sql = "select * from assignTask order by TID desc;";
            DataTable Dt = this.Da.ExecuteQueryTable(this.Sql);

            if (Dt.Rows.Count > 0)
            {
                string id = Dt.Rows[0]["TID"].ToString();
                string[] str = id.Split('T');
                int n = Convert.ToInt32(str[1]);
                string newId = "T" + (++n).ToString("d4");
                this.txtTaskID.Text = newId;
            }
            else
            {
                this.txtTaskID.Text = "T001";
            }
        }

        private void ClearAll()
        {
            txtTaskName.Clear();
            txtTaskDescription.Clear();
            cmbStatus.SelectedIndex = -1;
            GenerateTaskID();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LginForm f = new LginForm();
            this.Hide();
            f.Show();
        }

        private void  btnAddTask_Click(object sender, EventArgs e)
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

                this.Sql = @"INSERT INTO assignTask (ID, NAME, DESCRIPTION, STATUS)
                          VALUES ('" + txtTaskID.Text + "', '" + txtTaskName.Text + "', '" + txtTaskDescription.Text + "', '" + cmbStatus.Text + "');";

                int count = this.Da.ExecuteUpdateQuery(this.Sql);
                if (count == 1)
                {
                    MessageBox.Show(txtTaskID.Text + " has been added successfully");
                    ClearAll();
                    PopulateGridView();
                }
                else
                {
                    MessageBox.Show("Task insertion failed");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error occurred during saving task data\n\n" + exc.Message);
            }
        }

        private void dgvStaffTask_DoubleClick(object sender, EventArgs e)
        {
            if (dgvStaffTask.CurrentRow != null)
            {
                try
                {
                    txtTaskID.ReadOnly = true;
                    txtTaskID.Text = dgvStaffTask.CurrentRow.Cells["ID"].Value?.ToString();
                    txtTaskName.Text = dgvStaffTask.CurrentRow.Cells["NAME"].Value?.ToString();
                    txtTaskDescription.Text = dgvStaffTask.CurrentRow.Cells["DESCRIPTION"].Value?.ToString();
                    cmbStatus.Text = dgvStaffTask.CurrentRow.Cells["STATUS"].Value?.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading task details: " + ex.Message);
                }
            }
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
                          NAME='" + txtTaskName.Text + @"',
                          DESCRIPTION='" + txtTaskDescription.Text + @"',
                          STATUS='" + cmbStatus.Text + @"'
                          WHERE ID='" + txtTaskID.Text + "';";

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

        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            try
            {
                string ID = dgvStaffTask.CurrentRow.Cells["ID"].Value.ToString();
                string NAME = dgvStaffTask.CurrentRow.Cells["NAME"].Value.ToString();

                this.Sql = "DELETE FROM assignTask WHERE ID='" + ID + "'";
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
            PopulateGridView();
        }

        private void txtSearchID_TextChanged(object sender, EventArgs e)
        {

        }

        
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            String searchID = txtSearchID.Text.Trim();
            if (string.IsNullOrEmpty(searchID))
            {
                MessageBox.Show("Please enter a Task ID to search.");
                return;
            }

            this.Sql = "SELECT * FROM assignTask WHERE ID='" + searchID + "'";
            DataTable dt = this.Da.ExecuteQueryTable(this.Sql);

            if (dt.Rows.Count > 0)
            {

                txtTaskID.Text = dt.Rows[0]["ID"].ToString();
                txtTaskName.Text = dt.Rows[0]["NAME"].ToString();
                txtTaskDescription.Text = dt.Rows[0]["DESCRIPTION"].ToString();
                cmbStatus.Text = dt.Rows[0]["STATUS"].ToString();

                txtTaskID.ReadOnly = true;
                PopulateGridView(this.Sql);
            }
            else
            {
                MessageBox.Show("Task ID not found.");
                ClearAll();
                PopulateGridView();
            }
        }

       

        private void dgvStaffTask_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStaffTask.CurrentRow != null)
            {
                try
                {
                    this.txtTaskID.ReadOnly = true;
                    this.txtTaskID.Text = dgvStaffTask.CurrentRow.Cells["ID"].Value?.ToString();
                    this.txtTaskName.Text = dgvStaffTask.CurrentRow.Cells["NAME"].Value?.ToString();
                    this.txtTaskDescription.Text = dgvStaffTask.CurrentRow.Cells["DESCRIPTION"].Value?.ToString();
                    this.cmbStatus.Text = dgvStaffTask.CurrentRow.Cells["STATUS"].Value?.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading student details: " + ex.Message);
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            staffDashboardMenu sd = new staffDashboardMenu();
            this.Hide();
            sd.Show();
        }


        private void LoadStaffNames()
        {
           /* try
            {
                string sql = "SELECT ID, sName FROM sList";
                Database_Access da = new Database_Access();
                DataSet ds = da.ExecuteQuery(sql);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    // Add a new column for display
                    ds.Tables[0].Columns.Add("DisplayText", typeof(string));

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        row["DisplayText"] = row["sName"].ToString() + " (" + row["ID"].ToString() + ")";
                    }

                    cmbStaffID.DataSource = ds.Tables[0];
                    cmbStaffID.DisplayMember = "DisplayText";  // shows "Name (ID)"
                    cmbStaffID.ValueMember = "ID";              // underlying value is still ID
                    cmbStaffID.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading staff: " + ex.Message);
            }*/
        

        }

        private void ManageTask_Load(object sender, EventArgs e)
        {
           // LoadStaffNames();
        }

        private void dgvStaffTask_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbStaffID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }


}
