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
    public partial class FoodItem : Form
    {

        private DataAccess Da { get; set; }
        public FoodItem()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void PopulateGridView(string sql = "select * from FoodItemTable;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvFoodItem.AutoGenerateColumns = false;
            this.dgvFoodItem.DataSource = ds.Tables[0];
        }



        private void btnfooditemshow_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void btnfooditempreviousmenu_Click(object sender, EventArgs e)
        {
            MemberCatagory cate = new MemberCatagory();
            cate.Show();
        }

        private void FoodItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private bool IsDataValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtfoodName.Text) || String.IsNullOrEmpty(this.txtFoodQuantity.Text) ||
                 
                
                String.IsNullOrEmpty(this.txtFoodBarCode.Text))
                return false;
            else
                return true;
        }

        private void ClearAll()
        {
            this.txtfoodName.Clear();
            this.txtFoodQuantity.Clear();
            this.txtFoodBarCode.Clear();
          

            this.dgvFoodItem.ClearSelection();
            this.dgvFoodItem.DataSource = null;

            //this.AutoIdGenerate();
        }



        

        private void dgvFoodItem_DoubleClick(object sender, EventArgs e)
        {
            this.txtfoodName.Text = this.dgvFoodItem.CurrentRow.Cells[0].Value.ToString();
            this.txtFoodQuantity.Text = this.dgvFoodItem.CurrentRow.Cells[1].Value.ToString();
            this.txtFoodBarCode.Text = this.dgvFoodItem.CurrentRow.Cells[2].Value.ToString();

        }

        private void btnFoodItemAdd_Click(object sender, EventArgs e)
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

                    var sql = @"insert into FoodItemTable values('" + this.txtfoodName.Text + "', '" + this.txtFoodQuantity.Text + "',  '" + this.txtFoodBarCode.Text + "');";
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

        private void btnFoodItemDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvFoodItem.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("Please select a row first to delete.");
                    return;
                }

                var name = this.dgvFoodItem.CurrentRow.Cells[0].Value.ToString();
                var item = this.dgvFoodItem.CurrentRow.Cells["ItemName"].Value.ToString();

                var sql = "delete from FoodItemTable where ItemName = '" + name + "';";
               
                int count = this.Da.ExecuteDMLQuery(sql);
          
                

                if (count == 1)
                {
                    MessageBox.Show(item.ToUpper() + " Item has been removed properly");
                }
                else

                {
                    MessageBox.Show("Item remove failed");
                }

                

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please try again.\n" + exc.Message);
            }
        }

        private void btnfooditemupdate_Click(object sender, EventArgs e)
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
                    var name = this.dgvFoodItem.CurrentRow.Cells[0].Value.ToString();
                    var item = this.dgvFoodItem.CurrentRow.Cells["ItemName"].Value.ToString();

                    var query = "select * from FoodItemTable where ItemName = '" + name + "';";
                    

                    var dst = this.Da.ExecuteQuery(query);
                    

                    if (dst.Tables[0].Rows.Count == 1)
                    {

                        var kt = @"update FoodItemTable
                                set BarCode = '" + this.txtFoodBarCode.Text + @"',
                                ItemQuantity = '" + this.txtFoodQuantity.Text + @"',
                                ItemName = '" + this.txtfoodName.Text + @"'
                                where ItemName = '" + name + "';";


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

        private void btnFoodItemClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void txtFooditemSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string search = "select * from FoodItemTable where ItemName = '" + this.txtFooditemSearch.Text + "';";
                this.PopulateGridView(search);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please try again.\n" + exc.Message);
            }
        }


    }
}
