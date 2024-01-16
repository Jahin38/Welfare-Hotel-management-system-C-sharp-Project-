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
    public partial class ResetPassword : Form

    {
        

        private DataAccess Da
        {
            get; set;
        }
        public ResetPassword(string ResetPass)
        {
            InitializeComponent();
            this.Da = new DataAccess();

            if (ResetPass != null && txtResetUsername.Text != null)
            {
                txtResetUsername.Text = ResetPass;
            }

        }



        private void ResetPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
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
                    var query = "select * from LoginInfoTable where AdminUserName = '" + this.txtResetUsername.Text + "';";
                    var dst = this.Da.ExecuteQuery(query);

                    if (dst.Tables[0].Rows.Count == 1)
                    {




                        var kt = @"update LoginInfoTable
                                set AdminPassword = '" + this.txtNewPassword.Text + @"'    
                                where AdminUserName = '" + this.txtResetUsername.Text + "';";


                        int count = this.Da.ExecuteDMLQuery(kt);

                        if (count == 1)

                        {
                            MessageBox.Show("Password updated properly");
                            new Login().Show();
                        }
                        else
                            MessageBox.Show("Password upgradation failed! PLEASE TRY AGAIN");
                    }
                }

            }

            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please try again.\n" + exc.Message);
            }
        }

        private bool IsDataValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtResetUsername.Text) || String.IsNullOrEmpty(this.txtNewPassword.Text))
            {
                return false;
            }

            else
                return true;
        }

        
        
    }
}
