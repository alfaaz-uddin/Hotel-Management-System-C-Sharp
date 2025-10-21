using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static First.AddGuest;

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
            string username = this.txtUsername.Text.Trim();
            string password = this.txtPassword.Text.Trim();

            if (txtUsername.Text == "" && txtPassword.Text == "")
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
                Database_Access da = new Database_Access();
                string sql = "SELECT id, username, password, role FROM users WHERE UPPER(username)=UPPER('" + username + "') AND password='" + password + "';";
                DataSet ds = da.ExecuteQuery(sql);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    int userId = Convert.ToInt32(ds.Tables[0].Rows[0]["id"]);
                    string role = Convert.ToString(ds.Tables[0].Rows[0]["role"]).ToLower();

                    Session.CurrentReceptionistID = userId;
                    Session.CurrentReceptionist = username;

                    if (role == "receptionist")
                    {
                        Dashboard d = new Dashboard();
                        this.Hide();
                        d.Show();
                    }
                    else if (role == "audit")
                    {
                        Audit ad = new Audit();
                        this.Hide();
                        ad.Show();
                    }
                    else if (role == "admin")
                    {
                        adminDashbord ad = new adminDashbord();
                        this.Hide();
                        ad.Show();
                    }
                   /* else if (role == "staff")
                    {
                        staffDashboardMenu sd = new staffDashboardMenu();
                        this.Hide();
                        sd.Show();
                    } */
                }
                else
                {
                    string staffSql = "SELECT sName, Password, Designation FROM sList WHERE UPPER(sName)=UPPER('" + username + "') AND Password='" + password + "';";
                    DataSet dss = da.ExecuteQuery(staffSql);

                    if (dss.Tables[0].Rows.Count == 1)
                    {
                        string staffName = dss.Tables[0].Rows[0]["sName"].ToString();
                        ManageTask mt = new ManageTask(staffName);
                        this.Hide();
                        mt.Show();
                    }
                    else
                    {
                        MessageBox.Show("Login Failed!");
                    }
                }
            }
        }

    }
}
