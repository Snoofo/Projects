namespace Acme_Insurance.Presentation_Layer
{
    partial class frmSalesSearch
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
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.rbPayable = new System.Windows.Forms.RadioButton();
            this.rbCustomerID = new System.Windows.Forms.RadioButton();
            this.rbSaleID = new System.Windows.Forms.RadioButton();
            this.rbYearly = new System.Windows.Forms.RadioButton();
            this.rbMonthly = new System.Windows.Forms.RadioButton();
            this.rbFortnightly = new System.Windows.Forms.RadioButton();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtSaleID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lvSearchResult = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.Location = new System.Drawing.Point(21, 29);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(54, 17);
            this.rbAll.TabIndex = 0;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "List all";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.rbPayable);
            this.gbSearch.Controls.Add(this.rbCustomerID);
            this.gbSearch.Controls.Add(this.rbSaleID);
            this.gbSearch.Controls.Add(this.rbAll);
            this.gbSearch.Location = new System.Drawing.Point(13, 13);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(180, 187);
            this.gbSearch.TabIndex = 0;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search by";
            // 
            // rbPayable
            // 
            this.rbPayable.AutoSize = true;
            this.rbPayable.Location = new System.Drawing.Point(21, 144);
            this.rbPayable.Name = "rbPayable";
            this.rbPayable.Size = new System.Drawing.Size(113, 17);
            this.rbPayable.TabIndex = 3;
            this.rbPayable.Text = "Search by payable";
            this.rbPayable.UseVisualStyleBackColor = true;
            this.rbPayable.CheckedChanged += new System.EventHandler(this.rbPayable_CheckedChanged);
            // 
            // rbCustomerID
            // 
            this.rbCustomerID.AutoSize = true;
            this.rbCustomerID.Location = new System.Drawing.Point(21, 104);
            this.rbCustomerID.Name = "rbCustomerID";
            this.rbCustomerID.Size = new System.Drawing.Size(134, 17);
            this.rbCustomerID.TabIndex = 2;
            this.rbCustomerID.Text = "Search by Customer ID";
            this.rbCustomerID.UseVisualStyleBackColor = true;
            this.rbCustomerID.CheckedChanged += new System.EventHandler(this.rbCustomerID_CheckedChanged);
            // 
            // rbSaleID
            // 
            this.rbSaleID.AutoSize = true;
            this.rbSaleID.Location = new System.Drawing.Point(21, 66);
            this.rbSaleID.Name = "rbSaleID";
            this.rbSaleID.Size = new System.Drawing.Size(111, 17);
            this.rbSaleID.TabIndex = 1;
            this.rbSaleID.Text = "Search by Sale ID";
            this.rbSaleID.UseVisualStyleBackColor = true;
            this.rbSaleID.CheckedChanged += new System.EventHandler(this.rbSaleID_CheckedChanged);
            // 
            // rbYearly
            // 
            this.rbYearly.AutoSize = true;
            this.rbYearly.Checked = true;
            this.rbYearly.Enabled = false;
            this.rbYearly.Location = new System.Drawing.Point(222, 157);
            this.rbYearly.Name = "rbYearly";
            this.rbYearly.Size = new System.Drawing.Size(54, 17);
            this.rbYearly.TabIndex = 5;
            this.rbYearly.TabStop = true;
            this.rbYearly.Text = "Yearly";
            this.rbYearly.UseVisualStyleBackColor = true;
            // 
            // rbMonthly
            // 
            this.rbMonthly.AutoSize = true;
            this.rbMonthly.Enabled = false;
            this.rbMonthly.Location = new System.Drawing.Point(287, 157);
            this.rbMonthly.Name = "rbMonthly";
            this.rbMonthly.Size = new System.Drawing.Size(62, 17);
            this.rbMonthly.TabIndex = 6;
            this.rbMonthly.Text = "Monthly";
            this.rbMonthly.UseVisualStyleBackColor = true;
            // 
            // rbFortnightly
            // 
            this.rbFortnightly.AutoSize = true;
            this.rbFortnightly.Enabled = false;
            this.rbFortnightly.Location = new System.Drawing.Point(355, 157);
            this.rbFortnightly.Name = "rbFortnightly";
            this.rbFortnightly.Size = new System.Drawing.Size(73, 17);
            this.rbFortnightly.TabIndex = 7;
            this.rbFortnightly.Text = "Fortnightly";
            this.rbFortnightly.UseVisualStyleBackColor = true;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Enabled = false;
            this.txtCustomerID.Location = new System.Drawing.Point(222, 117);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(127, 20);
            this.txtCustomerID.TabIndex = 4;
            // 
            // txtSaleID
            // 
            this.txtSaleID.Enabled = false;
            this.txtSaleID.Location = new System.Drawing.Point(222, 79);
            this.txtSaleID.Name = "txtSaleID";
            this.txtSaleID.Size = new System.Drawing.Size(127, 20);
            this.txtSaleID.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(13, 470);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(118, 470);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lvSearchResult
            // 
            this.lvSearchResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvSearchResult.Location = new System.Drawing.Point(13, 207);
            this.lvSearchResult.Name = "lvSearchResult";
            this.lvSearchResult.Size = new System.Drawing.Size(415, 246);
            this.lvSearchResult.TabIndex = 8;
            this.lvSearchResult.UseCompatibleStateImageBehavior = false;
            this.lvSearchResult.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sale ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Customer ID";
            this.columnHeader2.Width = 72;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Product ID";
            this.columnHeader3.Width = 63;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Payable";
            this.columnHeader4.Width = 108;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Date";
            this.columnHeader5.Width = 107;
            // 
            // frmSalesSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 505);
            this.Controls.Add(this.lvSearchResult);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSaleID);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.rbFortnightly);
            this.Controls.Add(this.rbMonthly);
            this.Controls.Add(this.rbYearly);
            this.Controls.Add(this.gbSearch);
            this.Name = "frmSalesSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Sales";
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.RadioButton rbCustomerID;
        private System.Windows.Forms.RadioButton rbSaleID;
        private System.Windows.Forms.RadioButton rbPayable;
        private System.Windows.Forms.RadioButton rbYearly;
        private System.Windows.Forms.RadioButton rbMonthly;
        private System.Windows.Forms.RadioButton rbFortnightly;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtSaleID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListView lvSearchResult;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}