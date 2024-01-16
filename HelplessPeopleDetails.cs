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
    public partial class HelplessPeopleDetails : Form
    {

        private DataAccess Da
        {
            get; set;
        }
        public HelplessPeopleDetails()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void PopulateGridView(string sql = "select * from HelplessPeopleTable;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvHelplessPeopleDetails.AutoGenerateColumns = false;
            this.dgvHelplessPeopleDetails.DataSource = ds.Tables[0];
        }

        private void btnShowHP_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void btnLogoutHP_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void btnPreviousHelplessPeople_Click(object sender, EventArgs e)
        {
            new Category().Show();
            this.Hide();
        }

        private void HelplessPeopleDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
