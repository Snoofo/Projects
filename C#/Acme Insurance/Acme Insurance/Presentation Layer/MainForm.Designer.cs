namespace Acme_Insurance
{
    partial class frmMainForm
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
            this.btnCustomersView = new System.Windows.Forms.Button();
            this.btnSalesView = new System.Windows.Forms.Button();
            this.btnCategoriesView = new System.Windows.Forms.Button();
            this.btnProductTypeView = new System.Windows.Forms.Button();
            this.btnProductView = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnTutorial = new System.Windows.Forms.Button();
            this.lvProductsDisplay = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnCustomersView
            // 
            this.btnCustomersView.Location = new System.Drawing.Point(23, 241);
            this.btnCustomersView.Name = "btnCustomersView";
            this.btnCustomersView.Size = new System.Drawing.Size(120, 23);
            this.btnCustomersView.TabIndex = 0;
            this.btnCustomersView.Text = "View &Customers ";
            this.btnCustomersView.UseVisualStyleBackColor = true;
            this.btnCustomersView.Click += new System.EventHandler(this.btnCustomersView_Click);
            // 
            // btnSalesView
            // 
            this.btnSalesView.Location = new System.Drawing.Point(23, 280);
            this.btnSalesView.Name = "btnSalesView";
            this.btnSalesView.Size = new System.Drawing.Size(120, 23);
            this.btnSalesView.TabIndex = 4;
            this.btnSalesView.Text = "View &Sales";
            this.btnSalesView.UseVisualStyleBackColor = true;
            this.btnSalesView.Click += new System.EventHandler(this.btnSalesView_Click);
            // 
            // btnCategoriesView
            // 
            this.btnCategoriesView.Location = new System.Drawing.Point(148, 241);
            this.btnCategoriesView.Name = "btnCategoriesView";
            this.btnCategoriesView.Size = new System.Drawing.Size(120, 23);
            this.btnCategoriesView.TabIndex = 1;
            this.btnCategoriesView.Text = "View C&ategories";
            this.btnCategoriesView.UseVisualStyleBackColor = true;
            this.btnCategoriesView.Click += new System.EventHandler(this.btnCategoriesView_Click);
            // 
            // btnProductTypeView
            // 
            this.btnProductTypeView.Location = new System.Drawing.Point(399, 241);
            this.btnProductTypeView.Name = "btnProductTypeView";
            this.btnProductTypeView.Size = new System.Drawing.Size(120, 23);
            this.btnProductTypeView.TabIndex = 3;
            this.btnProductTypeView.Text = "View Product &Types";
            this.btnProductTypeView.UseVisualStyleBackColor = true;
            this.btnProductTypeView.Click += new System.EventHandler(this.btnProductTypeView_Click);
            // 
            // btnProductView
            // 
            this.btnProductView.Location = new System.Drawing.Point(273, 241);
            this.btnProductView.Name = "btnProductView";
            this.btnProductView.Size = new System.Drawing.Size(120, 23);
            this.btnProductView.TabIndex = 2;
            this.btnProductView.Text = "View &Products";
            this.btnProductView.UseVisualStyleBackColor = true;
            this.btnProductView.Click += new System.EventHandler(this.btnProductView_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(398, 280);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(148, 280);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(120, 23);
            this.btnAbout.TabIndex = 5;
            this.btnAbout.Text = "A&bout";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnTutorial
            // 
            this.btnTutorial.Location = new System.Drawing.Point(273, 280);
            this.btnTutorial.Name = "btnTutorial";
            this.btnTutorial.Size = new System.Drawing.Size(120, 23);
            this.btnTutorial.TabIndex = 6;
            this.btnTutorial.Text = "T&utorial";
            this.btnTutorial.UseVisualStyleBackColor = true;
            this.btnTutorial.Click += new System.EventHandler(this.btnTutorial_Click);
            // 
            // lvProductsDisplay
            // 
            this.lvProductsDisplay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvProductsDisplay.Enabled = false;
            this.lvProductsDisplay.Location = new System.Drawing.Point(12, 12);
            this.lvProductsDisplay.Name = "lvProductsDisplay";
            this.lvProductsDisplay.Size = new System.Drawing.Size(519, 223);
            this.lvProductsDisplay.TabIndex = 8;
            this.lvProductsDisplay.UseCompatibleStateImageBehavior = false;
            this.lvProductsDisplay.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product";
            this.columnHeader1.Width = 280;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Product Type";
            this.columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Purchases";
            this.columnHeader3.Width = 70;
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 313);
            this.Controls.Add(this.lvProductsDisplay);
            this.Controls.Add(this.btnTutorial);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnProductView);
            this.Controls.Add(this.btnProductTypeView);
            this.Controls.Add(this.btnCategoriesView);
            this.Controls.Add(this.btnSalesView);
            this.Controls.Add(this.btnCustomersView);
            this.MinimumSize = new System.Drawing.Size(300, 289);
            this.Name = "frmMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainForm_FormClosing);
            this.Load += new System.EventHandler(this.frmMainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCustomersView;
        private System.Windows.Forms.Button btnSalesView;
        private System.Windows.Forms.Button btnCategoriesView;
        private System.Windows.Forms.Button btnProductTypeView;
        private System.Windows.Forms.Button btnProductView;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnTutorial;
        private System.Windows.Forms.ListView lvProductsDisplay;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

