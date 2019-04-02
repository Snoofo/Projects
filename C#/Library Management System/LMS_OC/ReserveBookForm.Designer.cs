namespace LMS_OC
{
    partial class frmReserveBook
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
            this.lblReserveBook = new System.Windows.Forms.Label();
            this.gbReserve = new System.Windows.Forms.GroupBox();
            this.cbStudentID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpReserveDate = new System.Windows.Forms.DateTimePicker();
            this.lblReserveDate = new System.Windows.Forms.Label();
            this.lvIssuesList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnReserveBook = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lMSDBDataSet = new LMS_OC.LMSDBDataSet();
            this.lMSDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lMSDBDataSet1 = new LMS_OC.LMSDBDataSet1();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new LMS_OC.LMSDBDataSet1TableAdapters.StudentTableAdapter();
            this.gbReserve.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lMSDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMSDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMSDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReserveBook
            // 
            this.lblReserveBook.AutoSize = true;
            this.lblReserveBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReserveBook.Location = new System.Drawing.Point(138, 18);
            this.lblReserveBook.Name = "lblReserveBook";
            this.lblReserveBook.Size = new System.Drawing.Size(149, 20);
            this.lblReserveBook.TabIndex = 0;
            this.lblReserveBook.Text = "RESERVE BOOK";
            // 
            // gbReserve
            // 
            this.gbReserve.Controls.Add(this.cbStudentID);
            this.gbReserve.Controls.Add(this.label1);
            this.gbReserve.Controls.Add(this.dtpReserveDate);
            this.gbReserve.Controls.Add(this.lblReserveDate);
            this.gbReserve.Controls.Add(this.lvIssuesList);
            this.gbReserve.Controls.Add(this.btnReserveBook);
            this.gbReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbReserve.Location = new System.Drawing.Point(20, 49);
            this.gbReserve.Name = "gbReserve";
            this.gbReserve.Size = new System.Drawing.Size(385, 301);
            this.gbReserve.TabIndex = 1;
            this.gbReserve.TabStop = false;
            // 
            // cbStudentID
            // 
            this.cbStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStudentID.FormattingEnabled = true;
            this.cbStudentID.Location = new System.Drawing.Point(131, 190);
            this.cbStudentID.Name = "cbStudentID";
            this.cbStudentID.Size = new System.Drawing.Size(85, 24);
            this.cbStudentID.TabIndex = 5;
            this.cbStudentID.SelectedIndexChanged += new System.EventHandler(this.cbStudentID_SelectedIndexChanged);
            this.cbStudentID.TextUpdate += new System.EventHandler(this.cbStudentID_TextUpdate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Student ID";
            // 
            // dtpReserveDate
            // 
            this.dtpReserveDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReserveDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReserveDate.Location = new System.Drawing.Point(131, 224);
            this.dtpReserveDate.Name = "dtpReserveDate";
            this.dtpReserveDate.Size = new System.Drawing.Size(248, 22);
            this.dtpReserveDate.TabIndex = 3;
            // 
            // lblReserveDate
            // 
            this.lblReserveDate.AutoSize = true;
            this.lblReserveDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReserveDate.Location = new System.Drawing.Point(21, 224);
            this.lblReserveDate.Name = "lblReserveDate";
            this.lblReserveDate.Size = new System.Drawing.Size(104, 16);
            this.lblReserveDate.TabIndex = 2;
            this.lblReserveDate.Text = "Date for reserve";
            // 
            // lvIssuesList
            // 
            this.lvIssuesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvIssuesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvIssuesList.Location = new System.Drawing.Point(7, 26);
            this.lvIssuesList.MultiSelect = false;
            this.lvIssuesList.Name = "lvIssuesList";
            this.lvIssuesList.Size = new System.Drawing.Size(372, 142);
            this.lvIssuesList.TabIndex = 1;
            this.lvIssuesList.UseCompatibleStateImageBehavior = false;
            this.lvIssuesList.View = System.Windows.Forms.View.Details;
            this.lvIssuesList.SelectedIndexChanged += new System.EventHandler(this.lvIssuesList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Title";
            this.columnHeader1.Width = 162;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Return Date";
            this.columnHeader2.Width = 139;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Book ID";
            this.columnHeader3.Width = 67;
            // 
            // btnReserveBook
            // 
            this.btnReserveBook.Enabled = false;
            this.btnReserveBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserveBook.Location = new System.Drawing.Point(232, 262);
            this.btnReserveBook.Name = "btnReserveBook";
            this.btnReserveBook.Size = new System.Drawing.Size(147, 33);
            this.btnReserveBook.TabIndex = 0;
            this.btnReserveBook.Text = "Reserve Book";
            this.btnReserveBook.UseVisualStyleBackColor = true;
            this.btnReserveBook.Click += new System.EventHandler(this.btnReserveBook_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(303, 356);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 34);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lMSDBDataSet
            // 
            this.lMSDBDataSet.DataSetName = "LMSDBDataSet";
            this.lMSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lMSDBDataSetBindingSource
            // 
            this.lMSDBDataSetBindingSource.DataSource = this.lMSDBDataSet;
            this.lMSDBDataSetBindingSource.Position = 0;
            // 
            // lMSDBDataSet1
            // 
            this.lMSDBDataSet1.DataSetName = "LMSDBDataSet1";
            this.lMSDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.lMSDBDataSet1;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // frmReserveBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 402);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbReserve);
            this.Controls.Add(this.lblReserveBook);
            this.Name = "frmReserveBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Reserve Book";
            this.Load += new System.EventHandler(this.frmReserveBook_Load);
            this.gbReserve.ResumeLayout(false);
            this.gbReserve.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lMSDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMSDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMSDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReserveBook;
        private System.Windows.Forms.GroupBox gbReserve;
        private System.Windows.Forms.Button btnReserveBook;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListView lvIssuesList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.DateTimePicker dtpReserveDate;
        private System.Windows.Forms.Label lblReserveDate;
        private System.Windows.Forms.ComboBox cbStudentID;
        private System.Windows.Forms.Label label1;
        private LMSDBDataSet lMSDBDataSet;
        private System.Windows.Forms.BindingSource lMSDBDataSetBindingSource;
        private LMSDBDataSet1 lMSDBDataSet1;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private LMSDBDataSet1TableAdapters.StudentTableAdapter studentTableAdapter;
    }
}