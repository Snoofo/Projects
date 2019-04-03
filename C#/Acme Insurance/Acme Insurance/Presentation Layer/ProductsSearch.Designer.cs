namespace Acme_Insurance.Presentation_Layer
{
    partial class frmProductsSearch
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
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.rbProductType = new System.Windows.Forms.RadioButton();
            this.rbProductID = new System.Windows.Forms.RadioButton();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.cbProductType = new System.Windows.Forms.ComboBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbProductTypeID = new System.Windows.Forms.ListBox();
            this.lvSearchResult = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.rbProductType);
            this.gbSearch.Controls.Add(this.rbProductID);
            this.gbSearch.Controls.Add(this.rbAll);
            this.gbSearch.Location = new System.Drawing.Point(13, 13);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(212, 172);
            this.gbSearch.TabIndex = 0;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search by";
            // 
            // rbProductType
            // 
            this.rbProductType.AutoSize = true;
            this.rbProductType.Location = new System.Drawing.Point(25, 108);
            this.rbProductType.Name = "rbProductType";
            this.rbProductType.Size = new System.Drawing.Size(140, 17);
            this.rbProductType.TabIndex = 2;
            this.rbProductType.Text = "Search by Product Type";
            this.rbProductType.UseVisualStyleBackColor = true;
            this.rbProductType.CheckedChanged += new System.EventHandler(this.rbProductType_CheckedChanged);
            // 
            // rbProductID
            // 
            this.rbProductID.AutoSize = true;
            this.rbProductID.Location = new System.Drawing.Point(25, 72);
            this.rbProductID.Name = "rbProductID";
            this.rbProductID.Size = new System.Drawing.Size(127, 17);
            this.rbProductID.TabIndex = 1;
            this.rbProductID.Text = "Search by Product ID";
            this.rbProductID.UseVisualStyleBackColor = true;
            this.rbProductID.CheckedChanged += new System.EventHandler(this.rbProductID_CheckedChanged);
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.Location = new System.Drawing.Point(25, 36);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(54, 17);
            this.rbAll.TabIndex = 0;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "List all";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.All_CheckedChanged);
            // 
            // cbProductType
            // 
            this.cbProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductType.Enabled = false;
            this.cbProductType.FormattingEnabled = true;
            this.cbProductType.Location = new System.Drawing.Point(260, 121);
            this.cbProductType.Name = "cbProductType";
            this.cbProductType.Size = new System.Drawing.Size(121, 21);
            this.cbProductType.TabIndex = 1;
            // 
            // txtProductID
            // 
            this.txtProductID.Enabled = false;
            this.txtProductID.Location = new System.Drawing.Point(260, 85);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(121, 20);
            this.txtProductID.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(284, 379);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(387, 379);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbProductTypeID
            // 
            this.lbProductTypeID.FormattingEnabled = true;
            this.lbProductTypeID.Location = new System.Drawing.Point(387, 121);
            this.lbProductTypeID.Name = "lbProductTypeID";
            this.lbProductTypeID.Size = new System.Drawing.Size(11, 17);
            this.lbProductTypeID.TabIndex = 5;
            this.lbProductTypeID.Visible = false;
            // 
            // lvSearchResult
            // 
            this.lvSearchResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvSearchResult.Location = new System.Drawing.Point(12, 192);
            this.lvSearchResult.Name = "lvSearchResult";
            this.lvSearchResult.Size = new System.Drawing.Size(451, 181);
            this.lvSearchResult.TabIndex = 6;
            this.lvSearchResult.UseCompatibleStateImageBehavior = false;
            this.lvSearchResult.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product ID";
            this.columnHeader1.Width = 73;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Type ID";
            this.columnHeader2.Width = 52;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Product Name";
            this.columnHeader3.Width = 237;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Yearly Premium";
            this.columnHeader4.Width = 85;
            // 
            // frmProductsSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 414);
            this.Controls.Add(this.lvSearchResult);
            this.Controls.Add(this.lbProductTypeID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.cbProductType);
            this.Controls.Add(this.gbSearch);
            this.Name = "frmProductsSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products Search";
            this.Load += new System.EventHandler(this.frmProductsSearch_Load);
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.RadioButton rbProductType;
        private System.Windows.Forms.RadioButton rbProductID;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.ComboBox cbProductType;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox lbProductTypeID;
        private System.Windows.Forms.ListView lvSearchResult;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}