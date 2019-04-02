namespace LMS_OC
{
    partial class frmSearchBook
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
            this.components = new System.ComponentModel.Container();
            this.gbSearchTitle = new System.Windows.Forms.GroupBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnSearchTitle = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbSearchAuthor = new System.Windows.Forms.GroupBox();
            this.cbAuthor = new System.Windows.Forms.ComboBox();
            this.authorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lMSDBDataSet = new LMS_OC.LMSDBDataSet();
            this.btnSearchAuthor = new System.Windows.Forms.Button();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.gbResults = new System.Windows.Forms.GroupBox();
            this.lvResults = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblSearchBook = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.authorTableAdapter = new LMS_OC.LMSDBDataSetTableAdapters.AuthorTableAdapter();
            this.gbSearchTitle.SuspendLayout();
            this.gbSearchAuthor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMSDBDataSet)).BeginInit();
            this.gbResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSearchTitle
            // 
            this.gbSearchTitle.Controls.Add(this.txtTitle);
            this.gbSearchTitle.Controls.Add(this.btnSearchTitle);
            this.gbSearchTitle.Controls.Add(this.lblTitle);
            this.gbSearchTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSearchTitle.Location = new System.Drawing.Point(12, 51);
            this.gbSearchTitle.Name = "gbSearchTitle";
            this.gbSearchTitle.Size = new System.Drawing.Size(228, 100);
            this.gbSearchTitle.TabIndex = 0;
            this.gbSearchTitle.TabStop = false;
            this.gbSearchTitle.Text = "Search Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(47, 33);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(175, 26);
            this.txtTitle.TabIndex = 2;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // btnSearchTitle
            // 
            this.btnSearchTitle.Enabled = false;
            this.btnSearchTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchTitle.Location = new System.Drawing.Point(117, 65);
            this.btnSearchTitle.Name = "btnSearchTitle";
            this.btnSearchTitle.Size = new System.Drawing.Size(105, 30);
            this.btnSearchTitle.TabIndex = 1;
            this.btnSearchTitle.Text = "Search &Title";
            this.btnSearchTitle.UseVisualStyleBackColor = true;
            this.btnSearchTitle.Click += new System.EventHandler(this.btnSearchTitle_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(7, 39);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(34, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // gbSearchAuthor
            // 
            this.gbSearchAuthor.Controls.Add(this.cbAuthor);
            this.gbSearchAuthor.Controls.Add(this.btnSearchAuthor);
            this.gbSearchAuthor.Controls.Add(this.lblAuthor);
            this.gbSearchAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSearchAuthor.Location = new System.Drawing.Point(246, 52);
            this.gbSearchAuthor.Name = "gbSearchAuthor";
            this.gbSearchAuthor.Size = new System.Drawing.Size(243, 99);
            this.gbSearchAuthor.TabIndex = 1;
            this.gbSearchAuthor.TabStop = false;
            this.gbSearchAuthor.Text = "Search Author";
            // 
            // cbAuthor
            // 
            this.cbAuthor.DataSource = this.authorBindingSource;
            this.cbAuthor.DisplayMember = "authorName";
            this.cbAuthor.FormattingEnabled = true;
            this.cbAuthor.Location = new System.Drawing.Point(59, 32);
            this.cbAuthor.Name = "cbAuthor";
            this.cbAuthor.Size = new System.Drawing.Size(177, 28);
            this.cbAuthor.TabIndex = 2;
            this.cbAuthor.ValueMember = "authorName";
            // 
            // authorBindingSource
            // 
            this.authorBindingSource.DataMember = "Author";
            this.authorBindingSource.DataSource = this.lMSDBDataSet;
            // 
            // lMSDBDataSet
            // 
            this.lMSDBDataSet.DataSetName = "LMSDBDataSet";
            this.lMSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSearchAuthor
            // 
            this.btnSearchAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchAuthor.Location = new System.Drawing.Point(133, 66);
            this.btnSearchAuthor.Name = "btnSearchAuthor";
            this.btnSearchAuthor.Size = new System.Drawing.Size(104, 28);
            this.btnSearchAuthor.TabIndex = 1;
            this.btnSearchAuthor.Text = "Search &Author";
            this.btnSearchAuthor.UseVisualStyleBackColor = true;
            this.btnSearchAuthor.Click += new System.EventHandler(this.btnSearchAuthor_Click);
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(7, 38);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(46, 16);
            this.lblAuthor.TabIndex = 0;
            this.lblAuthor.Text = "Author";
            // 
            // gbResults
            // 
            this.gbResults.Controls.Add(this.lvResults);
            this.gbResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResults.Location = new System.Drawing.Point(12, 158);
            this.gbResults.Name = "gbResults";
            this.gbResults.Size = new System.Drawing.Size(477, 135);
            this.gbResults.TabIndex = 2;
            this.gbResults.TabStop = false;
            this.gbResults.Text = "Search Results";
            // 
            // lvResults
            // 
            this.lvResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvResults.Location = new System.Drawing.Point(6, 26);
            this.lvResults.Name = "lvResults";
            this.lvResults.Size = new System.Drawing.Size(465, 103);
            this.lvResults.TabIndex = 0;
            this.lvResults.UseCompatibleStateImageBehavior = false;
            this.lvResults.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Title";
            this.columnHeader1.Width = 83;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Author";
            this.columnHeader2.Width = 84;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Available";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Rack No";
            this.columnHeader4.Width = 56;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Borrowed";
            this.columnHeader5.Width = 58;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ISBN";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Price";
            // 
            // lblSearchBook
            // 
            this.lblSearchBook.AutoSize = true;
            this.lblSearchBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBook.Location = new System.Drawing.Point(182, 18);
            this.lblSearchBook.Name = "lblSearchBook";
            this.lblSearchBook.Size = new System.Drawing.Size(137, 20);
            this.lblSearchBook.TabIndex = 3;
            this.lblSearchBook.Text = "SEARCH BOOK";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(379, 300);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(109, 28);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // authorTableAdapter
            // 
            this.authorTableAdapter.ClearBeforeFill = true;
            // 
            // frmSearchBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 340);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblSearchBook);
            this.Controls.Add(this.gbResults);
            this.Controls.Add(this.gbSearchAuthor);
            this.Controls.Add(this.gbSearchTitle);
            this.Name = "frmSearchBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Search Book";
            this.Load += new System.EventHandler(this.frmSearchBook_Load);
            this.gbSearchTitle.ResumeLayout(false);
            this.gbSearchTitle.PerformLayout();
            this.gbSearchAuthor.ResumeLayout(false);
            this.gbSearchAuthor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMSDBDataSet)).EndInit();
            this.gbResults.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSearchTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbSearchAuthor;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.GroupBox gbResults;
        private System.Windows.Forms.ListView lvResults;
        private System.Windows.Forms.Label lblSearchBook;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnSearchTitle;
        private System.Windows.Forms.ComboBox cbAuthor;
        private System.Windows.Forms.Button btnSearchAuthor;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btnClose;
        private LMSDBDataSet lMSDBDataSet;
        private System.Windows.Forms.BindingSource authorBindingSource;
        private LMSDBDataSetTableAdapters.AuthorTableAdapter authorTableAdapter;
    }
}