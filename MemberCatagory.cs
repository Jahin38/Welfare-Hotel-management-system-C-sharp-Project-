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
    public partial class MemberCatagory : Form
    {
        public MemberCatagory()
        {
            InitializeComponent();
        }

        private void btnVolunteerWindow_Click(object sender, EventArgs e)
        {
            new Volunteer().Show();
            this.Visible = false; 
        }

        private void btnFoodItem_Click(object sender, EventArgs e)
        {
            new FoodItem().Show();
            this.Visible = false;
        }

        private void btnHelplessPeople_Click(object sender, EventArgs e)
        {
            new HelplessPeople().Show();
            this.Visible = false;
        }

        private void btnOrderForm_Click(object sender, EventArgs e)
        {
            new Order().Show();
            this.Visible = false;
        }

        

        private void MemberCatagory_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnMemberCatagory_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }
}
