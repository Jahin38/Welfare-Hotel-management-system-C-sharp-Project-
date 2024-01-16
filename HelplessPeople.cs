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
    public partial class HelplessPeople : Form
    {

        private DataAccess Da { get; set; }
        public HelplessPeople()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.GenerateID();
        }

        private void PopulateGridView(string sql = "select * from HelplessPeopleTable;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvHelplessPeople.AutoGenerateColumns = false;
            this.dgvHelplessPeople.DataSource = ds.Tables[0];
        }

        private void btnHelplesspeopleShow_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void btnHelplessPeoplePreviousMenu_Click(object sender, EventArgs e)
        {
            new MemberCatagory().Show();
            this.Visible = false;

        }

        private bool IsDataValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtHelplessPeopleID.Text) || String.IsNullOrEmpty(this.txtHelplesspeoplename.Text))

                return false;
            else
                return true;
        }



        private void HelplessPeople_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ClearAll()
        {
            this.txtHelplessPeopleID.Clear();
            this.txtHelplesspeoplename.Clear();
            this.dgvHelplessPeople.ClearSelection();
            this.dgvHelplessPeople.DataSource = null;
            this.GenerateID();
        }

        private void btnHelplessPeopleClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }


        private void btnHelplesspeopleAdd_Click(object sender, EventArgs e)
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

                    var sql = @"insert into HelplessPeopleTable values('" + this.txtHelplessPeopleID.Text + "', '" + this.txtHelplesspeoplename.Text + "');";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                    {
                        MessageBox.Show("Person insertion successful");

                    }

                    else
                        MessageBox.Show("Person insertion failed");


                }
                this.PopulateGridView();
                this.ClearAll();
            }

            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please try again.\n" + exc.Message);
            }


        }





        private void dgvHelplessPeople_DoubleClick(object sender, EventArgs e)
        {
            this.txtHelplessPeopleID.Text = this.dgvHelplessPeople.CurrentRow.Cells[0].Value.ToString();
            this.txtHelplesspeoplename.Text = this.dgvHelplessPeople.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnHelplessPeopleDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvHelplessPeople.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("Please select a row first to delete.");
                    return;
                }

                var id = this.dgvHelplessPeople.CurrentRow.Cells[0].Value.ToString();
                var name = this.dgvHelplessPeople.CurrentRow.Cells["HelplessPeopleName"].Value.ToString();

                var sql = "delete from HelplessPeopleTable where HelplessPeopleName = '" + name + "';";

                int count = this.Da.ExecuteDMLQuery(sql);



                if (count == 1)
                {
                    MessageBox.Show(" Person has been removed properly");
                }
                else

                {
                    MessageBox.Show("Person remove failed");
                }



                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please try again.\n" + exc.Message);
            }
        }

        private void btnHelplessPeopleUpdate_Click(object sender, EventArgs e)
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
                    var id = this.dgvHelplessPeople.CurrentRow.Cells[0].Value.ToString();
                    var name = this.dgvHelplessPeople.CurrentRow.Cells["HelplessPeopleName"].Value.ToString();

                    var query = "select * from HelplessPeopleTable where HelplessPeopleName = '" + name + "';";


                    var dst = this.Da.ExecuteQuery(query);


                    if (dst.Tables[0].Rows.Count == 1)
                    {

                        var kt = @"update HelplessPeopleTable
                               
                                
                                 set HelplessPeopleName = '" + this.txtHelplesspeoplename.Text + @"',
                                 HelplessPeopleID = '" + this.txtHelplessPeopleID.Text + @"'
                                 where HelplessPeopleID = '" + id + "';";


                        int count = this.Da.ExecuteDMLQuery(kt);

                        if (count == 1)
                            MessageBox.Show("Person Info updated properly");
                        else
                            MessageBox.Show("Person Info upgradation failed");
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

        private void txtHelplessPeopleSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string search = "select * from HelplessPeopleTable where HelplesspeopleName = '" + this.txtHelplessPeopleSearch.Text + "';";
                this.PopulateGridView(search);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please try again.\n" + exc.Message);
            }
        }

        private int newID
        {
            get; set;
        }

        private void GenerateID()
        {
            try
            {
                var sql = @"select HelplessPeopleID from HelplessPeopleTable Order by HelplessPeopleID DESC;";
                var ds = this.Da.ExecuteQuery(sql);
                string oldID = ds.Tables[0].Rows[0]["HelplessPeopleID"].ToString();


                var number = Convert.ToInt32(oldID);
                this.newID = (++number);

                this.txtHelplessPeopleID.Text = Convert.ToString(this.newID);


            }

            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please try again.\n" + exc.Message);
            }
        }


    }
}
