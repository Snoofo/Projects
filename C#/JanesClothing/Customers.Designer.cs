namespace JanesClothing
{
    partial class frmCustomers
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
            this.gbCustomerDetails = new System.Windows.Forms.GroupBox();
            this.gbOfficeUseOnly = new System.Windows.Forms.GroupBox();
            this.gbCustomerAddress = new System.Windows.Forms.GroupBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.cbCategoryID = new System.Windows.Forms.ComboBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblCategoryID = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.gbCustomerDetails.SuspendLayout();
            this.gbCustomerAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCustomerDetails
            // 
            this.gbCustomerDetails.Controls.Add(this.rbFemale);
            this.gbCustomerDetails.Controls.Add(this.rbMale);
            this.gbCustomerDetails.Controls.Add(this.lblGender);
            this.gbCustomerDetails.Controls.Add(this.cbCategoryID);
            this.gbCustomerDetails.Controls.Add(this.txtLastName);
            this.gbCustomerDetails.Controls.Add(this.lblCategoryID);
            this.gbCustomerDetails.Controls.Add(this.lblLastName);
            this.gbCustomerDetails.Controls.Add(this.txtFirstName);
            this.gbCustomerDetails.Controls.Add(this.lblFirstName);
            this.gbCustomerDetails.Location = new System.Drawing.Point(51, 35);
            this.gbCustomerDetails.Name = "gbCustomerDetails";
            this.gbCustomerDetails.Size = new System.Drawing.Size(315, 171);
            this.gbCustomerDetails.TabIndex = 0;
            this.gbCustomerDetails.TabStop = false;
            this.gbCustomerDetails.Text = "Customer Details ";
            // 
            // gbOfficeUseOnly
            // 
            this.gbOfficeUseOnly.Location = new System.Drawing.Point(400, 44);
            this.gbOfficeUseOnly.Name = "gbOfficeUseOnly";
            this.gbOfficeUseOnly.Size = new System.Drawing.Size(200, 100);
            this.gbOfficeUseOnly.TabIndex = 1;
            this.gbOfficeUseOnly.TabStop = false;
            this.gbOfficeUseOnly.Text = "Office Use Only";
            // 
            // gbCustomerAddress
            // 
            this.gbCustomerAddress.Controls.Add(this.cbState);
            this.gbCustomerAddress.Controls.Add(this.txtPostcode);
            this.gbCustomerAddress.Controls.Add(this.lblPostcode);
            this.gbCustomerAddress.Controls.Add(this.lblState);
            this.gbCustomerAddress.Controls.Add(this.txtSuburb);
            this.gbCustomerAddress.Controls.Add(this.txtAddress);
            this.gbCustomerAddress.Controls.Add(this.lblSuburb);
            this.gbCustomerAddress.Controls.Add(this.lblAddress);
            this.gbCustomerAddress.Location = new System.Drawing.Point(51, 236);
            this.gbCustomerAddress.Name = "gbCustomerAddress";
            this.gbCustomerAddress.Size = new System.Drawing.Size(412, 194);
            this.gbCustomerAddress.TabIndex = 2;
            this.gbCustomerAddress.TabStop = false;
            this.gbCustomerAddress.Text = "Customer Address";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(107, 36);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(181, 20);
            this.txtFirstName.TabIndex = 12;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(30, 36);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 11;
            this.lblFirstName.Text = "First Name:";
            // 
            // cbCategoryID
            // 
            this.cbCategoryID.FormattingEnabled = true;
            this.cbCategoryID.Location = new System.Drawing.Point(107, 135);
            this.cbCategoryID.Name = "cbCategoryID";
            this.cbCategoryID.Size = new System.Drawing.Size(181, 21);
            this.cbCategoryID.TabIndex = 25;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(107, 66);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(181, 20);
            this.txtLastName.TabIndex = 24;
            // 
            // lblCategoryID
            // 
            this.lblCategoryID.AutoSize = true;
            this.lblCategoryID.Location = new System.Drawing.Point(30, 135);
            this.lblCategoryID.Name = "lblCategoryID";
            this.lblCategoryID.Size = new System.Drawing.Size(52, 13);
            this.lblCategoryID.TabIndex = 23;
            this.lblCategoryID.Text = "Category:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(30, 69);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 22;
            this.lblLastName.Text = "Last Name:";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(161, 102);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 28;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(107, 102);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 27;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(30, 102);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 13);
            this.lblGender.TabIndex = 26;
            this.lblGender.Text = "Gender:";
            // 
            // txtSuburb
            // 
            this.txtSuburb.Location = new System.Drawing.Point(107, 65);
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(181, 20);
            this.txtSuburb.TabIndex = 16;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(107, 30);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(181, 20);
            this.txtAddress.TabIndex = 15;
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Location = new System.Drawing.Point(39, 65);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(44, 13);
            this.lblSuburb.TabIndex = 14;
            this.lblSuburb.Text = "Suburb:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(39, 30);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 13;
            this.lblAddress.Text = "Address:";
            // 
            // cbState
            // 
            this.cbState.FormattingEnabled = true;
            this.cbState.Location = new System.Drawing.Point(107, 100);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(121, 21);
            this.cbState.TabIndex = 24;
            // 
            // txtPostcode
            // 
            this.txtPostcode.Location = new System.Drawing.Point(107, 135);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(100, 20);
            this.txtPostcode.TabIndex = 23;
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Location = new System.Drawing.Point(39, 135);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(55, 13);
            this.lblPostcode.TabIndex = 22;
            this.lblPostcode.Text = "Postcode:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(39, 100);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(35, 13);
            this.lblState.TabIndex = 21;
            this.lblState.Text = "State:";
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 435);
            this.Controls.Add(this.gbCustomerAddress);
            this.Controls.Add(this.gbOfficeUseOnly);
            this.Controls.Add(this.gbCustomerDetails);
            this.Name = "frmCustomers";
            this.Text = "Add Customer Details";
            this.gbCustomerDetails.ResumeLayout(false);
            this.gbCustomerDetails.PerformLayout();
            this.gbCustomerAddress.ResumeLayout(false);
            this.gbCustomerAddress.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCustomerDetails;
        private System.Windows.Forms.GroupBox gbOfficeUseOnly;
        private System.Windows.Forms.GroupBox gbCustomerAddress;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.ComboBox cbCategoryID;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblCategoryID;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.Label lblState;
    }
}