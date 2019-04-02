namespace JanesClothing
{
    partial class frmCustomersAdd
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
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.cbCategoryID = new System.Windows.Forms.ComboBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblCategoryID = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.gbOfficeUseOnly = new System.Windows.Forms.GroupBox();
            this.chkNo = new System.Windows.Forms.CheckBox();
            this.chkYes = new System.Windows.Forms.CheckBox();
            this.lblSendCatalogue = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.gbCustomerAddress = new System.Windows.Forms.GroupBox();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbCustomerDetails.SuspendLayout();
            this.gbOfficeUseOnly.SuspendLayout();
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
            // gbOfficeUseOnly
            // 
            this.gbOfficeUseOnly.Controls.Add(this.chkNo);
            this.gbOfficeUseOnly.Controls.Add(this.chkYes);
            this.gbOfficeUseOnly.Controls.Add(this.lblSendCatalogue);
            this.gbOfficeUseOnly.Controls.Add(this.txtCustomerID);
            this.gbOfficeUseOnly.Controls.Add(this.lblCustomerID);
            this.gbOfficeUseOnly.Location = new System.Drawing.Point(400, 44);
            this.gbOfficeUseOnly.Name = "gbOfficeUseOnly";
            this.gbOfficeUseOnly.Size = new System.Drawing.Size(234, 162);
            this.gbOfficeUseOnly.TabIndex = 1;
            this.gbOfficeUseOnly.TabStop = false;
            this.gbOfficeUseOnly.Text = "Office Use Only";
            // 
            // chkNo
            // 
            this.chkNo.AutoSize = true;
            this.chkNo.Location = new System.Drawing.Point(171, 64);
            this.chkNo.Name = "chkNo";
            this.chkNo.Size = new System.Drawing.Size(40, 17);
            this.chkNo.TabIndex = 22;
            this.chkNo.Text = "No";
            this.chkNo.UseVisualStyleBackColor = true;
            // 
            // chkYes
            // 
            this.chkYes.AutoSize = true;
            this.chkYes.Location = new System.Drawing.Point(111, 64);
            this.chkYes.Name = "chkYes";
            this.chkYes.Size = new System.Drawing.Size(44, 17);
            this.chkYes.TabIndex = 21;
            this.chkYes.Text = "Yes";
            this.chkYes.UseVisualStyleBackColor = true;
            // 
            // lblSendCatalogue
            // 
            this.lblSendCatalogue.AutoSize = true;
            this.lblSendCatalogue.Location = new System.Drawing.Point(19, 60);
            this.lblSendCatalogue.Name = "lblSendCatalogue";
            this.lblSendCatalogue.Size = new System.Drawing.Size(86, 13);
            this.lblSendCatalogue.TabIndex = 20;
            this.lblSendCatalogue.Text = "Send Catalogue:";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(111, 24);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerID.TabIndex = 17;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(19, 27);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(68, 13);
            this.lblCustomerID.TabIndex = 16;
            this.lblCustomerID.Text = "Customer ID:";
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
            this.gbCustomerAddress.Size = new System.Drawing.Size(315, 176);
            this.gbCustomerAddress.TabIndex = 2;
            this.gbCustomerAddress.TabStop = false;
            this.gbCustomerAddress.Text = "Customer Address";
            // 
            // cbState
            // 
            this.cbState.FormattingEnabled = true;
            this.cbState.Location = new System.Drawing.Point(107, 100);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(100, 21);
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
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(559, 236);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(559, 326);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(559, 281);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmCustomersAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 435);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbCustomerAddress);
            this.Controls.Add(this.gbOfficeUseOnly);
            this.Controls.Add(this.gbCustomerDetails);
            this.Name = "frmCustomersAdd";
            this.Text = "Add Customer Details";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCustomersAdd_FormClosing);
            this.gbCustomerDetails.ResumeLayout(false);
            this.gbCustomerDetails.PerformLayout();
            this.gbOfficeUseOnly.ResumeLayout(false);
            this.gbOfficeUseOnly.PerformLayout();
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
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.CheckBox chkNo;
        private System.Windows.Forms.CheckBox chkYes;
        private System.Windows.Forms.Label lblSendCatalogue;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
    }
}