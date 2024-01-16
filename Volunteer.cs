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
    public partial class Volunteer : Form
    {
        private DataAccess Da { get; set; }

        public Volunteer()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.GenerateID();
        }

        private void PopulateGridView(string sql = "select * from VolunteerTable;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvVolunteers.AutoGenerateColumns = false;
            this.dgvVolunteers.DataSource = ds.Tables[0];
        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void btnVolunteerPreviousMenu_Click(object sender, EventArgs e)
        {
            new MemberCatagory().Show();
            this.Visible = false;
        }


        private bool IsDataValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtVolunteerID.Text) || String.IsNullOrEmpty(this.txtVolunteerName.Text) ||
                 String.IsNullOrEmpty(this.txtVolunteerAddress.Text) || String.IsNullOrEmpty(this.txtVolunteerPhone.Text))
                return false;
            else
                return true;
        }

        private void ClearAll()
        {
            this.txtVolunteerID.Clear();
            this.txtVolunteerName.Clear();
            this.txtVolunteerAddress.Clear();
            this.txtVolunteerPhone.Clear();

            this.dgvVolunteers.ClearSelection();
            this.dgvVolunteers.DataSource = null;

            this.GenerateID();
        }



        private void btnVolunteerAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsDataValidToSave())
                {
                    MessageBox.Show("Please Fill out the data");
                    return;
                }

                else
                {
                    var sql = @"insert into VolunteerTable values('" + this.newID + "', '" + this.txtVolunteerName.Text + "',  '" + this.txtVolunteerAddress.Text + "', '" + this.txtVolunteerPhone.Text + "');";

                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                    {
                        MessageBox.Show("Data insertion successful");



                    }

                    else
                        MessageBox.Show("Data insertion failed");
                }

                this.PopulateGridView();
                this.ClearAll();

            }

            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please try again.\n" + exc.Message);
            }
        }

        private void btnVolunteerDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvVolunteers.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("Please select a row first to delete.");
                    return;
                }

                var id = this.dgvVolunteers.CurrentRow.Cells[0].Value.ToString();
                var user = this.dgvVolunteers.CurrentRow.Cells["VolunteerName"].Value.ToString();

                var sql = "delete from VolunteerTable where VolunteerID = '" + id + "';";

                int count = this.Da.ExecuteDMLQuery(sql);


                if (count == 1)
                {
                    MessageBox.Show(user.ToUpper() + " has been removed properly");
                }
                else

                {
                    MessageBox.Show("Data remove failed");
                }



                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please try again.\n" + exc.Message);
            }

        }

        private void btnVolunteerUpdate_Click(object sender, EventArgs e)
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
                    var id = this.dgvVolunteers.CurrentRow.Cells[0].Value.ToString();
                    var user = this.dgvVolunteers.CurrentRow.Cells["VolunteerName"].Value.ToString();

                    var query = "select * from VolunteerTable where VolunteerID = '" + id + "';";


                    var dst = this.Da.ExecuteQuery(query);


                    if (dst.Tables[0].Rows.Count == 1)
                    {

                        var kt = @"update VolunteerTable
                                set VolunteerName = '" + this.txtVolunteerName.Text + @"',
                                VolunteerAddress = '" + this.txtVolunteerAddress.Text + @"',
                                VolunteerPhoneNumber = '" + this.txtVolunteerPhone.Text + @"'
                                where VolunteerID = '" + id + "';";

                        int count = this.Da.ExecuteDMLQuery(kt);

                        if (count == 1)
                            MessageBox.Show("Data updated properly");
                        else
                            MessageBox.Show("Data upgradation failed");
                    }



                }

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please try again.\n" + exc.Message);
            }
        }

        private void btnVolunteerClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void dgvVolunteers_DoubleClick_1(object sender, EventArgs e)
        {
            this.txtVolunteerID.Text = this.dgvVolunteers.CurrentRow.Cells[0].Value.ToString();
            this.txtVolunteerName.Text = this.dgvVolunteers.CurrentRow.Cells[1].Value.ToString();
            this.txtVolunteerAddress.Text = this.dgvVolunteers.CurrentRow.Cells[2].Value.ToString();
            this.txtVolunteerPhone.Text = this.dgvVolunteers.CurrentRow.Cells[3].Value.ToString();
        }

        private void dgvVolunteers_DoubleClick(object sender, EventArgs e)
        {

            this.txtVolunteerID.Text = this.dgvVolunteers.CurrentRow.Cells[0].Value.ToString();
            this.txtVolunteerName.Text = this.dgvVolunteers.CurrentRow.Cells[1].Value.ToString();
            this.txtVolunteerAddress.Text = this.dgvVolunteers.CurrentRow.Cells[2].Value.ToString();
            this.txtVolunteerPhone.Text = this.dgvVolunteers.CurrentRow.Cells[3].Value.ToString();

        }

        private void txtVolunteerSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string search = "select * from VolunteerTable where VolunteerName = '" + this.txtVolunteerSearch.Text + "';";
                this.PopulateGridView(search);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please try again.\n" + exc.Message);
            }
        }

        private void Volunteer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private int newID
        {
            get; set;
        }

        private void GenerateID()
        {
            try
            {
                var sql = @"select VolunteerID from VolunteerTable Order by VolunteerID DESC;";
                var ds = this.Da.ExecuteQuery(sql);
                string oldID = ds.Tables[0].Rows[0]["VolunteerID"].ToString();


                var number = Convert.ToInt32(oldID);
                this.newID = (++number);

                this.txtVolunteerID.Text = Convert.ToString(this.newID);


            }

            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please try again.\n" + exc.Message);
            }


        }

    }
}


    
