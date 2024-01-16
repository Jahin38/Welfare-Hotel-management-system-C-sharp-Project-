using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class VolunteerDetails : Form
    {
        private DataAccess Da
        {
            get; set;
        }

        private void PopulateGridView(string sql = "select * from VolunteerTable;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvVolunteerDetails.AutoGenerateColumns = false;
            this.dgvVolunteerDetails.DataSource = ds.Tables[0];
        }
        public VolunteerDetails()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void btnShowVD_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void btnLogoutVD_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void btnPreviousVolunteer_Click(object sender, EventArgs e)
        {
            new Category().Show();
            this.Hide();
        }

        private void VolunteerDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
