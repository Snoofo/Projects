namespace JanesClothing
{
    partial class frmProductsAdd
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
            this.btnAdd = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // chkColourfasdt
            // 
            this.chkColourfasdt.AutoSize = true;
            this.chkColourfasdt.Location = new System.Drawing.Point(117, 257);
            this.chkColourfasdt.Name = "chkColourfasdt";
            this.chkColourfasdt.Size = new System.Drawing.Size(15, 14);
            this.chkColourfasdt.TabIndex = 31;
            this.chkColourfasdt.UseVisualStyleBackColor = true;
            // 
            // rbUnisex
            // 
            this.rbUnisex.AutoSize = true;
            this.rbUnisex.Location = new System.Drawing.Point(249, 211);
            this.rbUnisex.Name = "rbUnisex";
            this.rbUnisex.Size = new System.Drawing.Size(57, 17);
            this.rbUnisex.TabIndex = 30;
            this.rbUnisex.TabStop = true;
            this.rbUnisex.Text = "Unisex";
            this.rbUnisex.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(184, 211);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 29;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(117, 211);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 28;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(382, 247);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(382, 201);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(117, 165);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 25;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(117, 119);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(146, 20);
            this.txtDescription.TabIndex = 24;
            // 
            // cbBrand
            // 
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Location = new System.Drawing.Point(117, 73);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(146, 21);
            this.cbBrand.TabIndex = 23;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(117, 27);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(100, 20);
            this.txtProductID.TabIndex = 22;
            // 
            // lblColourfast
            // 
            this.lblColourfast.AutoSize = true;
            this.lblColourfast.Location = new System.Drawing.Point(36, 257);
            this.lblColourfast.Name = "lblColourfast";
            this.lblColourfast.Size = new System.Drawing.Size(57, 13);
            this.lblColourfast.TabIndex = 21;
            this.lblColourfast.Text = "Colourfast:";
            // 
            // lblGenderType
            // 
            this.lblGenderType.AutoSize = true;
            this.lblGenderType.Location = new System.Drawing.Point(36, 211);
            this.lblGenderType.Name = "lblGenderType";
            this.lblGenderType.Size = new System.Drawing.Size(72, 13);
            this.lblGenderType.TabIndex = 20;
            this.lblGenderType.Text = "Gender Type:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(36, 165);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 19;
            this.lblPrice.Text = "Price:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(36, 119);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 18;
            this.lblDescription.Text = "Description:";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(36, 73);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(38, 13);
            this.lblBrand.TabIndex = 17;
            this.lblBrand.Text = "Brand:";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(36, 27);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(61, 13);
            this.lblProductID.TabIndex = 16;
            this.lblProductID.Text = "Product ID:";
            // 
            // frmProductsAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 309);
            this.Controls.Add(this.chkColourfasdt);
            this.Controls.Add(this.rbUnisex);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
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
            this.Name = "frmProductsAdd";
            this.Text = "Add Products Details";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductsAdd_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkColourfasdt;
        private System.Windows.Forms.RadioButton rbUnisex;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
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
    }
}