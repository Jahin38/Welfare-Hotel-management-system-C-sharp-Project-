using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace HotelManagementSystem
{
    public partial class Category : Form
    {
        private DataAccess Da
        {
            get; set;
        }

        public Category()
        {
            InitializeComponent();
        }

        private void btnWorkhour_Click(object sender, EventArgs e)
        {
            
            

        }

        private void btnVolunteer_Click(object sender, EventArgs e)
        {
            new VolunteerDetails().Show();
            this.Hide();
        }

        private void btnFoodItem_Click(object sender, EventArgs e)
        {
            new FoodItemDetails().Show();
            this.Hide();

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            new OrderDetails().Show();
            this.Hide();

        }

        private void btnHelplessPeople_Click(object sender, EventArgs e)
        {
            new HelplessPeopleDetails().Show();
            this.Hide();

        }

        

        private void btnMember_Click(object sender, EventArgs e)
        {
            new Member().Show();
            this.Visible = false;


        }

        

        private void Category_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        

        /*private void btnMemberDetails_Click(object sender, EventArgs e)
        {
            new VolunteerDetails().Show();
            this.Hide();
        }
        */
        private void btnCatagoryLogout_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }


}