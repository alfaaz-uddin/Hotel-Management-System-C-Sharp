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
    public partial class staffDashbord : Form
    {
        private Database_Access Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }

        public staffDashbord()
        {
            InitializeComponent();
            Da = new Database_Access();
            PopulateGridView();
            GenerateStaffID();
        }

        private void PopulateGridView(string sql = "select * from sList;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvStaffList.AutoGenerateColumns = false;
            this.dgvStaffList.DataSource = this.Ds.Tables[0];

        }

        private void GenerateStaffID()
        {
            this.Sql = "select * from sList order by id desc;";
            DataTable Dt = this.Da.ExecuteQueryTable(this.Sql);
            string id = Dt.Rows[0]["id"].ToString();
            string[] str = id.Split('S');
            int n = Convert.ToInt32(str[1]);
            string newId = "S" + (++n).ToString("d3");
            this.textId.Text = newId;
        }

        private void ClearAll()
        {
            this.textId.Clear();
            this.textId.ReadOnly = true;
            this.textName.Clear();
            this.textNumber.Clear();
            this.textdesignation.Clear();
            this.textTask.Clear();
            this.textPassword.Clear();
            this.textSearch.Clear();
            GenerateStaffID();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(this.textId.Text) ||
                     string.IsNullOrWhiteSpace(this.textName.Text) ||
                     string.IsNullOrWhiteSpace(this.textNumber.Text) ||
                     string.IsNullOrWhiteSpace(this.textdesignation.Text) ||
                     string.IsNullOrWhiteSpace(this.textPassword.Text))
                {
                    MessageBox.Show("Anything is Missing! Please Check Again");
                    return;
                }


                if (!int.TryParse(this.textNumber.Text, out _) || this.textNumber.Text.Length != 11)
                {
                    MessageBox.Show("Mobile Number is Invalid!");
                    return;
                }


                this.Sql = @"insert into sList
                    values ('" + this.textId.Text + "', '" + this.textName.Text + "','" + this.textNumber.Text + "' ,'" + this.textdesignation.Text + "','" + this.textTask.Text + "', '" + this.textPassword.Text + "' );";

                int count = this.Da.ExecuteUpdateQuery(this.Sql);
                if (count == 1)
                {
                    MessageBox.Show(this.textName.Text + " has been added Added");
                    this.GenerateStaffID();
                }
                else
                {
                    MessageBox.Show("Staff data insertion failed");
                }

                this.PopulateGridView();
                this.ClearAll();

            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during saving the Staff data\n\n" + exc.Message);
            }
        }



        private void dgvStaffList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                string id = this.dgvStaffList.CurrentRow.Cells["ID"].Value.ToString();
                string name = this.dgvStaffList.CurrentRow.Cells["sName"].Value.ToString();

                this.Sql = @"delete from sList
                            where ID = '" + id + "';";
                int count = this.Da.ExecuteUpdateQuery(this.Sql);
                if (count == 1)
                {
                    MessageBox.Show(name + " has been removed");
                }
                else
                {
                    MessageBox.Show("Staff data deletion failed");
                }
                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during deletion\n" + exc.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.textSearch.Clear();
            PopulateGridView();
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            this.Sql = "select * from sList where ID like '" + this.textSearch.Text + "%';";
            this.PopulateGridView(this.Sql);
        }

        private void dgvStaffList_DoubleClick(object sender, EventArgs e)
        {
            if (dgvStaffList.CurrentRow != null)
            {
                try
                {
                    this.textId.ReadOnly = true;
                    this.textId.Text = dgvStaffList.CurrentRow.Cells["ID"].Value?.ToString();
                    this.textName.Text = dgvStaffList.CurrentRow.Cells["sName"].Value?.ToString();
                    this.textNumber.Text = dgvStaffList.CurrentRow.Cells["Number"].Value?.ToString();
                    this.textdesignation.Text = dgvStaffList.CurrentRow.Cells["Designation"].Value?.ToString();
                    this.textTask.Text = dgvStaffList.CurrentRow.Cells["Task"].Value?.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading Staff details: " + ex.Message);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            adminDashbord da = new adminDashbord();
            this.Hide();
            da.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(this.textId.Text) ||
                     string.IsNullOrWhiteSpace(this.textName.Text) ||
                     string.IsNullOrWhiteSpace(this.textNumber.Text) ||
                     string.IsNullOrWhiteSpace(this.textdesignation.Text))
                {
                    MessageBox.Show("Anything is Missing! Please Check Again!");
                    return;
                }


                if (!int.TryParse(this.textNumber.Text, out _) || this.textNumber.Text.Length != 11)
                {
                    MessageBox.Show("Mobaile Number is Invalid!");
                    return;
                }
                this.Sql = "select * from sList where id = '" + this.textId.Text + "'";
                this.Ds = this.Da.ExecuteQuery(this.Sql);
                if (this.Ds.Tables[0].Rows.Count == 1)
                {
                    this.Sql = @"update sList SET
                    sName = '" + this.textName.Text + @"',
                    Number = '" + this.textNumber.Text + @"',
                    Designation = '" + this.textdesignation.Text + @"',
                    Task = '" + this.textTask.Text + @"'
                    where ID = '" + this.textId.Text + "';";
                    int count = this.Da.ExecuteUpdateQuery(this.Sql);
                    if (count == 1)
                    {
                        MessageBox.Show(this.textName.Text + " has been updated properly");
                    }
                    else
                    {
                        MessageBox.Show("Staff data updation failed");
                    }
                    this.PopulateGridView();
                    this.ClearAll();
                }
            }

            catch (Exception exu)
            {
                MessageBox.Show("Error update Staff details: " + exu.Message);
            }
        }

        private void staffDashbord_Load(object sender, EventArgs e)
        {

        }
    }
}
