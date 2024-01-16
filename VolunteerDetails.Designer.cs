
namespace HotelManagementSystem
{
    partial class VolunteerDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VolunteerDetails));
            this.pnlVolunteerDetail = new System.Windows.Forms.Panel();
            this.btnPreviousVolunteer = new System.Windows.Forms.Button();
            this.btnShowVD = new System.Windows.Forms.Button();
            this.btnLogoutVD = new System.Windows.Forms.Button();
            this.dgvVolunteerDetails = new System.Windows.Forms.DataGridView();
            this.VolunteerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VolunteerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VolunteerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VolunteerPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlVolunteerDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVolunteerDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlVolunteerDetail
            // 
            this.pnlVolunteerDetail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlVolunteerDetail.BackgroundImage")));
            this.pnlVolunteerDetail.Controls.Add(this.btnPreviousVolunteer);
            this.pnlVolunteerDetail.Controls.Add(this.btnShowVD);
            this.pnlVolunteerDetail.Controls.Add(this.btnLogoutVD);
            this.pnlVolunteerDetail.Controls.Add(this.dgvVolunteerDetails);
            this.pnlVolunteerDetail.Location = new System.Drawing.Point(-1, 0);
            this.pnlVolunteerDetail.Name = "pnlVolunteerDetail";
            this.pnlVolunteerDetail.Size = new System.Drawing.Size(993, 618);
            this.pnlVolunteerDetail.TabIndex = 0;
            // 
            // btnPreviousVolunteer
            // 
            this.btnPreviousVolunteer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPreviousVolunteer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousVolunteer.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPreviousVolunteer.Location = new System.Drawing.Point(161, 334);
            this.btnPreviousVolunteer.Name = "btnPreviousVolunteer";
            this.btnPreviousVolunteer.Size = new System.Drawing.Size(91, 49);
            this.btnPreviousVolunteer.TabIndex = 5;
            this.btnPreviousVolunteer.Text = "Previous";
            this.btnPreviousVolunteer.UseVisualStyleBackColor = false;
            this.btnPreviousVolunteer.Click += new System.EventHandler(this.btnPreviousVolunteer_Click);
            // 
            // btnShowVD
            // 
            this.btnShowVD.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnShowVD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowVD.ForeColor = System.Drawing.Color.White;
            this.btnShowVD.Location = new System.Drawing.Point(220, 415);
            this.btnShowVD.Name = "btnShowVD";
            this.btnShowVD.Size = new System.Drawing.Size(97, 49);
            this.btnShowVD.TabIndex = 2;
            this.btnShowVD.Text = "ShowList";
            this.btnShowVD.UseVisualStyleBackColor = false;
            this.btnShowVD.Click += new System.EventHandler(this.btnShowVD_Click);
            // 
            // btnLogoutVD
            // 
            this.btnLogoutVD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLogoutVD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoutVD.ForeColor = System.Drawing.Color.White;
            this.btnLogoutVD.Location = new System.Drawing.Point(95, 415);
            this.btnLogoutVD.Name = "btnLogoutVD";
            this.btnLogoutVD.Size = new System.Drawing.Size(94, 49);
            this.btnLogoutVD.TabIndex = 1;
            this.btnLogoutVD.Text = "Logout";
            this.btnLogoutVD.UseVisualStyleBackColor = false;
            this.btnLogoutVD.Click += new System.EventHandler(this.btnLogoutVD_Click);
            // 
            // dgvVolunteerDetails
            // 
            this.dgvVolunteerDetails.AllowUserToAddRows = false;
            this.dgvVolunteerDetails.AllowUserToDeleteRows = false;
            this.dgvVolunteerDetails.BackgroundColor = System.Drawing.Color.OliveDrab;
            this.dgvVolunteerDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVolunteerDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VolunteerID,
            this.VolunteerName,
            this.VolunteerAddress,
            this.VolunteerPhoneNumber});
            this.dgvVolunteerDetails.GridColor = System.Drawing.Color.YellowGreen;
            this.dgvVolunteerDetails.Location = new System.Drawing.Point(405, 151);
            this.dgvVolunteerDetails.Name = "dgvVolunteerDetails";
            this.dgvVolunteerDetails.ReadOnly = true;
            this.dgvVolunteerDetails.RowHeadersWidth = 51;
            this.dgvVolunteerDetails.RowTemplate.Height = 24;
            this.dgvVolunteerDetails.Size = new System.Drawing.Size(577, 379);
            this.dgvVolunteerDetails.TabIndex = 0;
            // 
            // VolunteerID
            // 
            this.VolunteerID.DataPropertyName = "VolunteerID";
            this.VolunteerID.HeaderText = "Volunteer ID";
            this.VolunteerID.MinimumWidth = 6;
            this.VolunteerID.Name = "VolunteerID";
            this.VolunteerID.ReadOnly = true;
            this.VolunteerID.Width = 125;
            // 
            // VolunteerName
            // 
            this.VolunteerName.DataPropertyName = "VolunteerName";
            this.VolunteerName.HeaderText = "Volunteer Name";
            this.VolunteerName.MinimumWidth = 6;
            this.VolunteerName.Name = "VolunteerName";
            this.VolunteerName.ReadOnly = true;
            this.VolunteerName.Width = 125;
            // 
            // VolunteerAddress
            // 
            this.VolunteerAddress.DataPropertyName = "VolunteerAddress";
            this.VolunteerAddress.HeaderText = "Volunteer Address";
            this.VolunteerAddress.MinimumWidth = 6;
            this.VolunteerAddress.Name = "VolunteerAddress";
            this.VolunteerAddress.ReadOnly = true;
            this.VolunteerAddress.Width = 125;
            // 
            // VolunteerPhoneNumber
            // 
            this.VolunteerPhoneNumber.DataPropertyName = "VolunteerPhoneNumber";
            this.VolunteerPhoneNumber.HeaderText = "Volunteer Phone Number";
            this.VolunteerPhoneNumber.MinimumWidth = 6;
            this.VolunteerPhoneNumber.Name = "VolunteerPhoneNumber";
            this.VolunteerPhoneNumber.ReadOnly = true;
            this.VolunteerPhoneNumber.Width = 125;
            // 
            // VolunteerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 613);
            this.Controls.Add(this.pnlVolunteerDetail);
            this.Name = "VolunteerDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VolunteerDetails";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VolunteerDetails_FormClosing);
            this.pnlVolunteerDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVolunteerDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlVolunteerDetail;
        private System.Windows.Forms.DataGridView dgvVolunteerDetails;
        private System.Windows.Forms.Button btnShowVD;
        private System.Windows.Forms.Button btnLogoutVD;
        private System.Windows.Forms.DataGridViewTextBoxColumn VolunteerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VolunteerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn VolunteerAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn VolunteerPhoneNumber;
        private System.Windows.Forms.Button btnPreviousVolunteer;
    }
}