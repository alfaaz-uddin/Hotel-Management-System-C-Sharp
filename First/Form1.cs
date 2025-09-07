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
    public partial class LginForm : Form
    {
        public LginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userCheckCase = this.txtUsername.Text.ToUpper().Trim();
            string sql = "SELECT UPPER(username), password, role FROM users WHERE username= '" + userCheckCase + "' AND password='" + this.txtPassword.Text + "';";

            Database_Access da = new Database_Access();
            DataSet ds = da.ExecuteQuery(sql);

            //DataTable table = ds.Tables[0]; 

            if (ds.Tables[0].Rows.Count == 1)
            {
                string role = Convert.ToString(ds.Tables[0].Rows[0]["role"]);

                if (role == "admin")
                {
                    Form2 d = new Form2();
                    this.Hide();
                    d.Show();
                }
                else if (role == "audit")
                {
                    audit_dashboard ad = new audit_dashboard();
                    this.Hide();
                    ad.Show();
                }
            }

            else if (txtUsername.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Username and Password cannot be empty.");
            }

            else if (txtUsername.Text == "")
            {
                MessageBox.Show("Username cannot be empty.");

            }

            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Password cannot be empty.");

            }

            else
            {
                MessageBox.Show("Login Failed!");
            }
        }
    }
}
