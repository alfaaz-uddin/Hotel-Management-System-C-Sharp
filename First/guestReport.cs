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
    public partial class guestReport : Form
    {
        private Database_Access Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        public guestReport()
        {
            InitializeComponent();
            dgvGuestReport.AllowUserToAddRows = false;
            Da = new Database_Access();
            PopulateGridView();
        }

        private void PopulateGridView(string sql = "SELECT g.id AS Guest_ID, g.name AS Guest_Name,  g.roomNO AS Room_NO, g.mobNum AS Mobile_Number, " +
            " g.nidNo AS NID, u.Username AS Added_By, g.receptionistID AS ID, u.role AS Role FROM guestList g LEFT JOIN users u ON g.receptionistID = u.id ;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvGuestReport.AutoGenerateColumns = true;
            this.dgvGuestReport.DataSource = this.Ds.Tables[0];
        }


        private void dgvGuestReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDownload(object sender, EventArgs e)
        {
            PdfGenerator.GenerateGuestReport(dgvGuestReport);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Audit a = new Audit();
            this.Hide();
            a.Show();
        }
    }
}
