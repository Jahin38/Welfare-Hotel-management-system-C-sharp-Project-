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
    public partial class Order : Form
    {

        private DataAccess Da { get; set; }
        public Order()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.GenerateID();
        }


        private void PopulateGridView(string sql = "select * from OrderTable;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvOrderView.AutoGenerateColumns = false;
            this.dgvOrderView.DataSource = ds.Tables[0];
        }



        private void btnOrderShow_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void btnOrderPreviousMenu_Click(object sender, EventArgs e)
        {
            MemberCatagory cate = new MemberCatagory();
            cate.Show();
        }

        private void Order_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private bool IsDataValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtOrderID.Text) || String.IsNullOrEmpty(this.txtOrderName.Text))

                return false;
            else
                return true;
        }

        private void ClearAll()
        {
            this.txtOrderID.Clear();
            this.txtOrderName.Clear();

            this.dgvOrderView.ClearSelection();
            this.dgvOrderView.DataSource = null;

            this.GenerateID();
        }

        private void dgvOrderView_DoubleClick(object sender, EventArgs e)
        {
            this.txtOrderID.Text = this.dgvOrderView.CurrentRow.Cells[0].Value.ToString();
            this.txtOrderName.Text = this.dgvOrderView.CurrentRow.Cells[1].Value.ToString();
        }










        private void btnOrderUpdate_Click(object sender, EventArgs e)
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
                    var id = this.dgvOrderView.CurrentRow.Cells[0].Value.ToString();
                    var name = this.dgvOrderView.CurrentRow.Cells["OrderName"].Value.ToString();

                    var query = "select * from OrderTable where OrderName = '" + name + "';";


                    var dst = this.Da.ExecuteQuery(query);


                    if (dst.Tables[0].Rows.Count == 1)
                    {

                        var kt = @"update OrderTable
                                
                                set OrderName = '" + this.txtOrderName.Text + @"',
                                OrderID = '" + this.txtOrderID.Text + @"'
                                where OrderID = '" + id + "';";


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

        private void btnOrderClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void txtOrderSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string search = "select * from OrderTable where OrderName = '" + this.txtOrderSearch.Text + "';";
                this.PopulateGridView(search);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please try again.\n" + exc.Message);
            }
        }

        private void btnOrderAdd_Click(object sender, EventArgs e)
        {
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

                        var sql = @"insert into OrderTable values('" + this.txtOrderID.Text + "', '" + this.txtOrderName.Text + "');";
                        int count = this.Da.ExecuteDMLQuery(sql);

                        if (count == 1)
                        {
                            MessageBox.Show("Item insertion successful");

                        }

                        else
                            MessageBox.Show("Item insertion failed");


                    }
                    this.PopulateGridView();
                    this.ClearAll();
                }

                catch (Exception exc)
                {
                    MessageBox.Show("An error has occured, please try again.\n" + exc.Message);
                }
            }

        }

        private void btnOrderDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvOrderView.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("Please select a row first to delete.");
                    return;
                }

                var id = this.dgvOrderView.CurrentRow.Cells[0].Value.ToString();
                var name = this.dgvOrderView.CurrentRow.Cells["OrderName"].Value.ToString();

                var sql = "delete from OrderTable where OrderName = '" + name + "';";

                int count = this.Da.ExecuteDMLQuery(sql);



                if (count == 1)
                {
                    MessageBox.Show(name.ToUpper() + " Order has been removed properly");
                }
                else

                {
                    MessageBox.Show("Order remove failed");
                }



                this.PopulateGridView();
                this.ClearAll();
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
                var sql = @"select OrderID from OrderTable Order by OrderID DESC;";
                var ds = this.Da.ExecuteQuery(sql);
                string oldID = ds.Tables[0].Rows[0]["OrderID"].ToString();


                var number = Convert.ToInt32(oldID);
                this.newID = (++number);

                this.txtOrderID.Text = Convert.ToString(this.newID);


            }

            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please try again.\n" + exc.Message);
            }

        }
    }

}
