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

    public partial class AddPassword : Form
    {
        private DataAccess Da { get; set; }
        public AddPassword(string addpass)
        {
            InitializeComponent();

            this.Da = new DataAccess();

            if (addpass != null && txtUserName.Text != null)
            {
                txtUserName.Text = addpass;
            }
        }

        


        private bool IsDataValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtUserName.Text) || String.IsNullOrEmpty(this.txtAddPassword.Text))

            {
                return false;

            }
            else
                return true;
        }

        private void btnDone_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!IsDataValidToSave())
                {
                    MessageBox.Show("Please Fill all the Data.");
                    return;
                }
                else
                {

                    var sql = @"insert into LoginInfoTable values('" + this.txtUserName.Text + "', '" + this.txtAddPassword.Text + "',  'Member');";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                    {
                        MessageBox.Show("Data insertion successful");

                        new Member().Show();
                    }
                    else
                    {
                        MessageBox.Show("Data insertion failed");
                    }

                }

            }

            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please try again.\n" + exc.Message);
            }
        }

        private void AddPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}