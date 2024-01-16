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
    public partial class Login : Form
    {
        private DataAccess Da { get; set; }
        public Login()
        {
            InitializeComponent();
            this.Da = new DataAccess();


        }
        private bool IsDataValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtUsername.Text)||
                String.IsNullOrEmpty(this.txtPassword.Text))
                return false;
            else
                return true;
        }
        private void btnSignin_Click(object sender, EventArgs e)
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
                    string Qury = "select * from LoginInfoTable where AdminUsername = '" + this.txtUsername.Text + "' and AdminPassword = '" + this.txtPassword.Text + "';";

                    var ds = this.Da.ExecuteQuery(Qury);


                    if (ds.Tables[0].Rows.Count == 1)
                    {
                        MessageBox.Show("Valid User. Login Successful");
                        if (ds.Tables[0].Rows[0][2].ToString() == "Admin")
                            new Category().Show();
                        else if (ds.Tables[0].Rows[0][2].ToString() == "Member")
                            new MemberCatagory().Show();

                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Invalid Info! Please Try Again!!");
                        return;
                    }


                }
            }

            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please try again.\n" + exc.Message);
            }
        }

        

        private void Login_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lblForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

                string passwordTracker = txtUsername.Text;
                ResetPassword res = new ResetPassword(passwordTracker);
                res.Show();
                this.Hide();
            
        }
    }
}