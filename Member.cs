
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
    public partial class Member : Form
    {
       

        private DataAccess Da { get; set; }

        public Member()
        {

            InitializeComponent();
            this.Da = new DataAccess();
            this.GenerateID();

        }

        private void PopulateGridView(string sql = "select * from MemberTable;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvMembers.AutoGenerateColumns = false;
            this.dgvMembers.DataSource = ds.Tables[0];
        }

        private void btnMemberListCheck_Click(object sender, EventArgs e)
        {

            this.PopulateGridView();

        }

        private void btnMemberPrevious_Click(object sender, EventArgs e)
        {
            new Category().Show();
            this.Visible = false;

        }

        private void Member_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private bool IsDataValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtMemberID.Text)||String.IsNullOrEmpty(this.txtMemberName.Text) ||
                 String.IsNullOrEmpty(this.txtMemberSalary.Text) ||
                String.IsNullOrEmpty(this.txtMemberAddress.Text) || String.IsNullOrEmpty(this.txtMemberWorkHour.Text) ||
                String.IsNullOrEmpty(this.txtMemberBonus.Text))
                return false;
            else
                return true;
        }
        private void ClearAll()
        {
            this.txtMemberID.Clear();
            this.txtMemberName.Clear();
            this.txtMemberSalary.Clear();
            this.txtMemberAddress.Clear();
            this.txtMemberWorkHour.Clear();
            this.txtMemberBonus.Clear();

            this.dgvMembers.ClearSelection();
            this.dgvMembers.DataSource = null;

            this.GenerateID();
        }

        
private void dgvMembers_DoubleClick(object sender, EventArgs e)
        {
            this.txtMemberID.Text = this.dgvMembers.CurrentRow.Cells[0].Value.ToString();
            this.txtMemberName.Text = this.dgvMembers.CurrentRow.Cells[1].Value.ToString();
            this.txtMemberSalary.Text = this.dgvMembers.CurrentRow.Cells[2].Value.ToString();
            this.txtMemberAddress.Text = this.dgvMembers.CurrentRow.Cells[3].Value.ToString();
            this.txtMemberWorkHour.Text = this.dgvMembers.CurrentRow.Cells[4].Value.ToString();
            this.txtMemberBonus.Text = this.dgvMembers.CurrentRow.Cells[5].Value.ToString();
        }

        

        private void btnMemberAdd_Click_1(object sender, EventArgs e)
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
                   

                    var sql = @"insert into MemberTable values('" + this.newID + "', '" + this.txtMemberName.Text + "',  '" + this.txtMemberSalary.Text + "', '" + this.txtMemberAddress.Text + "', '" + this.txtMemberWorkHour.Text + "', '" + this.txtMemberBonus.Text + "');";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                    {
                        MessageBox.Show("Data insertion successful");

                        string passwordTracker = txtMemberName.Text;
                        AddPassword add = new AddPassword(passwordTracker);
                        add.Show();
                        this.Hide();
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

        private void btnMemberDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvMembers.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("Please select a row first to delete.");
                    return;
                }

                var id = this.dgvMembers.CurrentRow.Cells[0].Value.ToString();
                var user = this.dgvMembers.CurrentRow.Cells["MemberUsername"].Value.ToString();

                var sql = "delete from MemberTable where MemberID = '" + id + "';";
                var sqt = "delete from LoginInfoTable where AdminUsername = '" + user + "';";
                int count = this.Da.ExecuteDMLQuery(sql);
                var counter = this.Da.ExecuteDMLQuery(sqt);
                int inte = Convert.ToInt32(counter);

                if (count == 1)
                {
                    MessageBox.Show(user.ToUpper() + " has been removed properly");
                }
                else

                {
                    MessageBox.Show("Data remove failed");
                }

                if (inte == 1)
                {
                    MessageBox.Show("Data has been removed properly");
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

        private void btnMemberUpdate_Click_1(object sender, EventArgs e)
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
                    var id = this.dgvMembers.CurrentRow.Cells[0].Value.ToString();
                    var user = this.dgvMembers.CurrentRow.Cells["MemberUsername"].Value.ToString();

                    var query = "select * from MemberTable where MemberID = '" + id + "';";
                    var comma = "select * from LoginInfoTable where AdminUsername = '" + user + "';";

                    var dst = this.Da.ExecuteQuery(query);
                    var cst = this.Da.ExecuteQuery(comma);

                    if (dst.Tables[0].Rows.Count == 1)
                    {

                        var kt = @"update MemberTable
                                set MemberUsername = '" + this.txtMemberName.Text + @"',
                                MemberSalary = '" + this.txtMemberSalary.Text + @"',
                                MemberAddress = '" + this.txtMemberAddress.Text + @"',
                                MemberWorkHour = '" + this.txtMemberWorkHour.Text + @"',
                                MemberBonus = '" + this.txtMemberBonus.Text + @"'
                                where MemberID = '" + id + "';";

                        int count = this.Da.ExecuteDMLQuery(kt);

                        if (count == 1)
                            MessageBox.Show("Data updated properly");
                        else
                            MessageBox.Show("Data upgradation failed");
                    }

                    if (cst.Tables[0].Rows.Count == 1)
                    {
                        var mt = @"update LoginInfoTable
                                set AdminUsername = '" + this.txtMemberName.Text + @"'
                                where AdminUsername = '" + user + "';";
                        int count = this.Da.ExecuteDMLQuery(mt);
                        int inte = Convert.ToInt32(count);

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

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void dgvMembers_DoubleClick_1(object sender, EventArgs e)
        {
            this.txtMemberID.Text = this.dgvMembers.CurrentRow.Cells[0].Value.ToString();
            this.txtMemberName.Text = this.dgvMembers.CurrentRow.Cells[1].Value.ToString();
            this.txtMemberSalary.Text = this.dgvMembers.CurrentRow.Cells[2].Value.ToString();
            this.txtMemberAddress.Text = this.dgvMembers.CurrentRow.Cells[3].Value.ToString();
            this.txtMemberWorkHour.Text = this.dgvMembers.CurrentRow.Cells[4].Value.ToString();
            this.txtMemberBonus.Text = this.dgvMembers.CurrentRow.Cells[5].Value.ToString();
        }

        private void txtMemberSearch_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                string search = "select * from MemberTable where MemberUsername = '" + this.txtMemberSearch.Text + "';";
                this.PopulateGridView(search);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please try again.\n" + exc.Message);
            }
        }

        private void Member_FormClosing_1(object sender, FormClosingEventArgs e)
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
                var sql = @"select MemberID from MemberTable Order by MemberID DESC;";
                var ds = this.Da.ExecuteQuery(sql);
                string oldID = ds.Tables[0].Rows[0]["MemberID"].ToString(); 
               
               
                var number = Convert.ToInt32(oldID); 
                this.newID = (++number);
               
                this.txtMemberID.Text = Convert.ToString(this.newID);
               

            }

            catch(Exception exc)
            {
                MessageBox.Show("An error has occured, please try again.\n" + exc.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }

}