namespace JanesClothing
{
    partial class frmProductsEdit
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
            this.chkColourfasdt = new System.Windows.Forms.CheckBox();
            this.rbUnisex = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.lblColourfast = new System.Windows.Forms.Label();
            this.lblGenderType = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkColourfasdt
            // 
            this.chkColourfasdt.AutoSize = true;
            this.chkColourfasdt.Enabled = false;
            this.chkColourfasdt.Location = new System.Drawing.Point(114, 261);
            this.chkColourfasdt.Name = "chkColourfasdt";
            this.chkColourfasdt.Size = new System.Drawing.Size(15, 14);
            this.chkColourfasdt.TabIndex = 47;
            this.chkColourfasdt.UseVisualStyleBackColor = true;
            // 
            // rbUnisex
            // 
            this.rbUnisex.AutoSize = true;
            this.rbUnisex.Enabled = false;
            this.rbUnisex.Location = new System.Drawing.Point(246, 215);
            this.rbUnisex.Name = "rbUnisex";
            this.rbUnisex.Size = new System.Drawing.Size(57, 17);
            this.rbUnisex.TabIndex = 46;
            this.rbUnisex.TabStop = true;
            this.rbUnisex.Text = "Unisex";
            this.rbUnisex.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Enabled = false;
            this.rbFemale.Location = new System.Drawing.Point(181, 215);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 45;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Enabled = false;
            this.rbMale.Location = new System.Drawing.Point(114, 215);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 44;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(379, 251);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 43;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(379, 205);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 42;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(114, 169);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 41;
            // 
            // txtDescription
            // 
            this.txtDescription.Enabled = false;
            this.txtDescription.Location = new System.Drawing.Point(114, 123);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(146, 20);
            this.txtDescription.TabIndex = 40;
            // 
            // cbBrand
            // 
            this.cbBrand.Enabled = false;
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Location = new System.Drawing.Point(114, 77);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(146, 21);
            this.cbBrand.TabIndex = 39;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(114, 31);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(100, 20);
            this.txtProductID.TabIndex = 38;
            // 
            // lblColourfast
            // 
            this.lblColourfast.AutoSize = true;
            this.lblColourfast.Location = new System.Drawing.Point(33, 261);
            this.lblColourfast.Name = "lblColourfast";
            this.lblColourfast.Size = new System.Drawing.Size(57, 13);
            this.lblColourfast.TabIndex = 37;
            this.lblColourfast.Text = "Colourfast:";
            // 
            // lblGenderType
            // 
            this.lblGenderType.AutoSize = true;
            this.lblGenderType.Location = new System.Drawing.Point(33, 215);
            this.lblGenderType.Name = "lblGenderType";
            this.lblGenderType.Size = new System.Drawing.Size(72, 13);
            this.lblGenderType.TabIndex = 36;
            this.lblGenderType.Text = "Gender Type:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(33, 169);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 35;
            this.lblPrice.Text = "Price:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(33, 123);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 34;
            this.lblDescription.Text = "Description:";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(33, 77);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(38, 13);
            this.lblBrand.TabIndex = 33;
            this.lblBrand.Text = "Brand:";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(33, 31);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(61, 13);
            this.lblProductID.TabIndex = 32;
            this.lblProductID.Text = "Product ID:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(246, 31);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 48;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(379, 158);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 49;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // frmProductsEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 313);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.chkColourfasdt);
            this.Controls.Add(this.rbUnisex);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.cbBrand);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.lblColourfast);
            this.Controls.Add(this.lblGenderType);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblProductID);
            this.Name = "frmProductsEdit";
            this.Text = "Edit Product Details";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductEdit_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkColourfasdt;
        private System.Windows.Forms.RadioButton rbUnisex;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cbBrand;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lblColourfast;
        private System.Windows.Forms.Label lblGenderType;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
    }
}