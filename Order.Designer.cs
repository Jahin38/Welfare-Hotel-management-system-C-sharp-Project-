
namespace HotelManagementSystem
{
    partial class Order
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
            this.pnlOrder = new System.Windows.Forms.Panel();
            this.lblOrderSearch = new System.Windows.Forms.Label();
            this.btnOrderClear = new System.Windows.Forms.Button();
            this.btnOrderPreviousMenu = new System.Windows.Forms.Button();
            this.btnOrderShow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOrderName = new System.Windows.Forms.TextBox();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.txtOrderSearch = new System.Windows.Forms.TextBox();
            this.dgvOrderView = new System.Windows.Forms.DataGridView();
            this.btnOrderDelete = new System.Windows.Forms.Button();
            this.btnOrderAdd = new System.Windows.Forms.Button();
            this.btnOrderUpdate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOrder
            // 
            this.pnlOrder.Controls.Add(this.lblOrderSearch);
            this.pnlOrder.Controls.Add(this.btnOrderClear);
            this.pnlOrder.Controls.Add(this.btnOrderPreviousMenu);
            this.pnlOrder.Controls.Add(this.btnOrderShow);
            this.pnlOrder.Controls.Add(this.label1);
            this.pnlOrder.Controls.Add(this.label6);
            this.pnlOrder.Controls.Add(this.txtOrderName);
            this.pnlOrder.Controls.Add(this.txtOrderID);
            this.pnlOrder.Controls.Add(this.txtOrderSearch);
            this.pnlOrder.Controls.Add(this.dgvOrderView);
            this.pnlOrder.Controls.Add(this.btnOrderDelete);
            this.pnlOrder.Controls.Add(this.btnOrderAdd);
            this.pnlOrder.Controls.Add(this.btnOrderUpdate);
            this.pnlOrder.Controls.Add(this.panel1);
            this.pnlOrder.Location = new System.Drawing.Point(-1, 0);
            this.pnlOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlOrder.Name = "pnlOrder";
            this.pnlOrder.Size = new System.Drawing.Size(1059, 633);
            this.pnlOrder.TabIndex = 0;
            // 
            // lblOrderSearch
            // 
            this.lblOrderSearch.AutoSize = true;
            this.lblOrderSearch.Location = new System.Drawing.Point(718, 137);
            this.lblOrderSearch.Name = "lblOrderSearch";
            this.lblOrderSearch.Size = new System.Drawing.Size(53, 17);
            this.lblOrderSearch.TabIndex = 57;
            this.lblOrderSearch.Text = "Search";
            // 
            // btnOrderClear
            // 
            this.btnOrderClear.BackColor = System.Drawing.Color.IndianRed;
            this.btnOrderClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderClear.ForeColor = System.Drawing.Color.White;
            this.btnOrderClear.Location = new System.Drawing.Point(233, 510);
            this.btnOrderClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrderClear.Name = "btnOrderClear";
            this.btnOrderClear.Size = new System.Drawing.Size(85, 39);
            this.btnOrderClear.TabIndex = 56;
            this.btnOrderClear.Text = "Clear";
            this.btnOrderClear.UseVisualStyleBackColor = false;
            this.btnOrderClear.Click += new System.EventHandler(this.btnOrderClear_Click);
            // 
            // btnOrderPreviousMenu
            // 
            this.btnOrderPreviousMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOrderPreviousMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderPreviousMenu.ForeColor = System.Drawing.Color.White;
            this.btnOrderPreviousMenu.Location = new System.Drawing.Point(73, 569);
            this.btnOrderPreviousMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrderPreviousMenu.Name = "btnOrderPreviousMenu";
            this.btnOrderPreviousMenu.Size = new System.Drawing.Size(179, 43);
            this.btnOrderPreviousMenu.TabIndex = 55;
            this.btnOrderPreviousMenu.Text = "Go to form menu";
            this.btnOrderPreviousMenu.UseVisualStyleBackColor = false;
            this.btnOrderPreviousMenu.Click += new System.EventHandler(this.btnOrderPreviousMenu_Click);
            // 
            // btnOrderShow
            // 
            this.btnOrderShow.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnOrderShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderShow.ForeColor = System.Drawing.Color.White;
            this.btnOrderShow.Location = new System.Drawing.Point(43, 506);
            this.btnOrderShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrderShow.Name = "btnOrderShow";
            this.btnOrderShow.Size = new System.Drawing.Size(147, 43);
            this.btnOrderShow.TabIndex = 54;
            this.btnOrderShow.Text = "Show Orders";
            this.btnOrderShow.UseVisualStyleBackColor = false;
            this.btnOrderShow.Click += new System.EventHandler(this.btnOrderShow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(21, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 50;
            this.label1.Text = "Order ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label6.Location = new System.Drawing.Point(21, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 24);
            this.label6.TabIndex = 49;
            this.label6.Text = "Order Item Name";
            // 
            // txtOrderName
            // 
            this.txtOrderName.Location = new System.Drawing.Point(25, 423);
            this.txtOrderName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOrderName.Name = "txtOrderName";
            this.txtOrderName.Size = new System.Drawing.Size(265, 22);
            this.txtOrderName.TabIndex = 48;
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(25, 343);
            this.txtOrderID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(265, 22);
            this.txtOrderID.TabIndex = 47;
            // 
            // txtOrderSearch
            // 
            this.txtOrderSearch.Location = new System.Drawing.Point(781, 134);
            this.txtOrderSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOrderSearch.Name = "txtOrderSearch";
            this.txtOrderSearch.Size = new System.Drawing.Size(265, 22);
            this.txtOrderSearch.TabIndex = 46;
            this.txtOrderSearch.TextChanged += new System.EventHandler(this.txtOrderSearch_TextChanged);
            // 
            // dgvOrderView
            // 
            this.dgvOrderView.AllowUserToAddRows = false;
            this.dgvOrderView.AllowUserToDeleteRows = false;
            this.dgvOrderView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderID,
            this.OrderName});
            this.dgvOrderView.Location = new System.Drawing.Point(559, 216);
            this.dgvOrderView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvOrderView.Name = "dgvOrderView";
            this.dgvOrderView.ReadOnly = true;
            this.dgvOrderView.RowHeadersWidth = 51;
            this.dgvOrderView.RowTemplate.Height = 24;
            this.dgvOrderView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderView.Size = new System.Drawing.Size(365, 402);
            this.dgvOrderView.TabIndex = 45;
            this.dgvOrderView.DoubleClick += new System.EventHandler(this.dgvOrderView_DoubleClick);
            // 
            // btnOrderDelete
            // 
            this.btnOrderDelete.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnOrderDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderDelete.ForeColor = System.Drawing.Color.White;
            this.btnOrderDelete.Location = new System.Drawing.Point(850, 172);
            this.btnOrderDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrderDelete.Name = "btnOrderDelete";
            this.btnOrderDelete.Size = new System.Drawing.Size(173, 39);
            this.btnOrderDelete.TabIndex = 44;
            this.btnOrderDelete.Text = "Order Remove";
            this.btnOrderDelete.UseVisualStyleBackColor = false;
            this.btnOrderDelete.Click += new System.EventHandler(this.btnOrderDelete_Click);
            // 
            // btnOrderAdd
            // 
            this.btnOrderAdd.BackColor = System.Drawing.Color.IndianRed;
            this.btnOrderAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderAdd.ForeColor = System.Drawing.Color.White;
            this.btnOrderAdd.Location = new System.Drawing.Point(649, 172);
            this.btnOrderAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrderAdd.Name = "btnOrderAdd";
            this.btnOrderAdd.Size = new System.Drawing.Size(164, 39);
            this.btnOrderAdd.TabIndex = 43;
            this.btnOrderAdd.Text = "Place Order";
            this.btnOrderAdd.UseVisualStyleBackColor = false;
            this.btnOrderAdd.Click += new System.EventHandler(this.btnOrderAdd_Click);
            // 
            // btnOrderUpdate
            // 
            this.btnOrderUpdate.BackColor = System.Drawing.Color.Maroon;
            this.btnOrderUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderUpdate.ForeColor = System.Drawing.Color.White;
            this.btnOrderUpdate.Location = new System.Drawing.Point(441, 172);
            this.btnOrderUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrderUpdate.Name = "btnOrderUpdate";
            this.btnOrderUpdate.Size = new System.Drawing.Size(163, 39);
            this.btnOrderUpdate.TabIndex = 42;
            this.btnOrderUpdate.Text = "Order Update";
            this.btnOrderUpdate.UseVisualStyleBackColor = false;
            this.btnOrderUpdate.Click += new System.EventHandler(this.btnOrderUpdate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(1, 7);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 111);
            this.panel1.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Peru;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(322, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(371, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Order Receive and Collections";
            // 
            // OrderID
            // 
            this.OrderID.DataPropertyName = "OrderID";
            this.OrderID.HeaderText = "Order ID";
            this.OrderID.MinimumWidth = 6;
            this.OrderID.Name = "OrderID";
            this.OrderID.ReadOnly = true;
            this.OrderID.Width = 125;
            // 
            // OrderName
            // 
            this.OrderName.DataPropertyName = "OrderName";
            this.OrderName.HeaderText = "Order Item Name";
            this.OrderName.MinimumWidth = 6;
            this.OrderName.Name = "OrderName";
            this.OrderName.ReadOnly = true;
            this.OrderName.Width = 125;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 629);
            this.Controls.Add(this.pnlOrder);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Order_FormClosing);
            this.pnlOrder.ResumeLayout(false);
            this.pnlOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOrder;
        private System.Windows.Forms.Button btnOrderPreviousMenu;
        private System.Windows.Forms.Button btnOrderShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOrderName;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.TextBox txtOrderSearch;
        private System.Windows.Forms.DataGridView dgvOrderView;
        private System.Windows.Forms.Button btnOrderDelete;
        private System.Windows.Forms.Button btnOrderAdd;
        private System.Windows.Forms.Button btnOrderUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOrderClear;
        private System.Windows.Forms.Label lblOrderSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderName;
    }
}