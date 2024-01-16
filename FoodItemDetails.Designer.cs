
namespace HotelManagementSystem
{
    partial class FoodItemDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodItemDetails));
            this.pnlFoodItemDetail = new System.Windows.Forms.Panel();
            this.btnFoodPrevious = new System.Windows.Forms.Button();
            this.btnShowVD = new System.Windows.Forms.Button();
            this.btnLogoutVD = new System.Windows.Forms.Button();
            this.dgvFoodItemDetails = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFoodItemDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodItemDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFoodItemDetail
            // 
            this.pnlFoodItemDetail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlFoodItemDetail.BackgroundImage")));
            this.pnlFoodItemDetail.Controls.Add(this.btnFoodPrevious);
            this.pnlFoodItemDetail.Controls.Add(this.btnShowVD);
            this.pnlFoodItemDetail.Controls.Add(this.btnLogoutVD);
            this.pnlFoodItemDetail.Controls.Add(this.dgvFoodItemDetails);
            this.pnlFoodItemDetail.Location = new System.Drawing.Point(0, -3);
            this.pnlFoodItemDetail.Name = "pnlFoodItemDetail";
            this.pnlFoodItemDetail.Size = new System.Drawing.Size(993, 618);
            this.pnlFoodItemDetail.TabIndex = 1;
            // 
            // btnFoodPrevious
            // 
            this.btnFoodPrevious.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnFoodPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoodPrevious.ForeColor = System.Drawing.Color.White;
            this.btnFoodPrevious.Location = new System.Drawing.Point(280, 447);
            this.btnFoodPrevious.Name = "btnFoodPrevious";
            this.btnFoodPrevious.Size = new System.Drawing.Size(90, 47);
            this.btnFoodPrevious.TabIndex = 5;
            this.btnFoodPrevious.Text = "Previous";
            this.btnFoodPrevious.UseVisualStyleBackColor = false;
            this.btnFoodPrevious.Click += new System.EventHandler(this.btnFoodPrevious_Click);
            // 
            // btnShowVD
            // 
            this.btnShowVD.BackColor = System.Drawing.Color.Chocolate;
            this.btnShowVD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowVD.ForeColor = System.Drawing.Color.White;
            this.btnShowVD.Location = new System.Drawing.Point(366, 375);
            this.btnShowVD.Name = "btnShowVD";
            this.btnShowVD.Size = new System.Drawing.Size(93, 42);
            this.btnShowVD.TabIndex = 4;
            this.btnShowVD.Text = "ShowList";
            this.btnShowVD.UseVisualStyleBackColor = false;
            this.btnShowVD.Click += new System.EventHandler(this.btnShowVD_Click);
            // 
            // btnLogoutVD
            // 
            this.btnLogoutVD.BackColor = System.Drawing.Color.OliveDrab;
            this.btnLogoutVD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoutVD.ForeColor = System.Drawing.Color.White;
            this.btnLogoutVD.Location = new System.Drawing.Point(214, 375);
            this.btnLogoutVD.Name = "btnLogoutVD";
            this.btnLogoutVD.Size = new System.Drawing.Size(80, 42);
            this.btnLogoutVD.TabIndex = 3;
            this.btnLogoutVD.Text = "Logout";
            this.btnLogoutVD.UseVisualStyleBackColor = false;
            this.btnLogoutVD.Click += new System.EventHandler(this.btnLogoutVD_Click);
            // 
            // dgvFoodItemDetails
            // 
            this.dgvFoodItemDetails.AllowUserToAddRows = false;
            this.dgvFoodItemDetails.AllowUserToDeleteRows = false;
            this.dgvFoodItemDetails.BackgroundColor = System.Drawing.Color.PaleVioletRed;
            this.dgvFoodItemDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodItemDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.ItemQuantity,
            this.BarCode});
            this.dgvFoodItemDetails.GridColor = System.Drawing.Color.LavenderBlush;
            this.dgvFoodItemDetails.Location = new System.Drawing.Point(508, 168);
            this.dgvFoodItemDetails.Name = "dgvFoodItemDetails";
            this.dgvFoodItemDetails.ReadOnly = true;
            this.dgvFoodItemDetails.RowHeadersWidth = 51;
            this.dgvFoodItemDetails.RowTemplate.Height = 24;
            this.dgvFoodItemDetails.Size = new System.Drawing.Size(473, 379);
            this.dgvFoodItemDetails.TabIndex = 1;
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.MinimumWidth = 6;
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 125;
            // 
            // ItemQuantity
            // 
            this.ItemQuantity.DataPropertyName = "ItemQuantity";
            this.ItemQuantity.HeaderText = "Item Quantity";
            this.ItemQuantity.MinimumWidth = 6;
            this.ItemQuantity.Name = "ItemQuantity";
            this.ItemQuantity.ReadOnly = true;
            this.ItemQuantity.Width = 125;
            // 
            // BarCode
            // 
            this.BarCode.DataPropertyName = "BarCode";
            this.BarCode.HeaderText = "Bar Code";
            this.BarCode.MinimumWidth = 6;
            this.BarCode.Name = "BarCode";
            this.BarCode.ReadOnly = true;
            this.BarCode.Width = 125;
            // 
            // FoodItemDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(993, 613);
            this.Controls.Add(this.pnlFoodItemDetail);
            this.Name = "FoodItemDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FoodItemDetails";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FoodItemDetails_FormClosing);
            this.pnlFoodItemDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodItemDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFoodItemDetail;
        private System.Windows.Forms.DataGridView dgvFoodItemDetails;
        private System.Windows.Forms.Button btnShowVD;
        private System.Windows.Forms.Button btnLogoutVD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarCode;
        private System.Windows.Forms.Button btnFoodPrevious;
    }
}