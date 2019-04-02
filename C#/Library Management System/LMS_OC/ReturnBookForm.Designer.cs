namespace LMS_OC
{
    partial class frmReturnBook
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
            this.lblReturnBook = new System.Windows.Forms.Label();
            this.gbReturnDetails = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.cbStudentID = new System.Windows.Forms.ComboBox();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.cbBookID = new System.Windows.Forms.ComboBox();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblBookID = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbReturnDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblReturnBook
            // 
            this.lblReturnBook.AutoSize = true;
            this.lblReturnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnBook.Location = new System.Drawing.Point(127, 14);
            this.lblReturnBook.Name = "lblReturnBook";
            this.lblReturnBook.Size = new System.Drawing.Size(136, 20);
            this.lblReturnBook.TabIndex = 0;
            this.lblReturnBook.Text = "RETURN BOOK";
            // 
            // gbReturnDetails
            // 
            this.gbReturnDetails.Controls.Add(this.btnSubmit);
            this.gbReturnDetails.Controls.Add(this.dtpReturnDate);
            this.gbReturnDetails.Controls.Add(this.cbStudentID);
            this.gbReturnDetails.Controls.Add(this.lblReturnDate);
            this.gbReturnDetails.Controls.Add(this.cbBookID);
            this.gbReturnDetails.Controls.Add(this.lblStudentID);
            this.gbReturnDetails.Controls.Add(this.lblBookID);
            this.gbReturnDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbReturnDetails.Location = new System.Drawing.Point(13, 44);
            this.gbReturnDetails.Name = "gbReturnDetails";
            this.gbReturnDetails.Size = new System.Drawing.Size(363, 222);
            this.gbReturnDetails.TabIndex = 1;
            this.gbReturnDetails.TabStop = false;
            this.gbReturnDetails.Text = "Return Details";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(246, 172);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(103, 35);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReturnDate.Location = new System.Drawing.Point(156, 136);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(193, 20);
            this.dtpReturnDate.TabIndex = 5;
            // 
            // cbStudentID
            // 
            this.cbStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStudentID.FormattingEnabled = true;
            this.cbStudentID.Location = new System.Drawing.Point(156, 91);
            this.cbStudentID.Name = "cbStudentID";
            this.cbStudentID.Size = new System.Drawing.Size(77, 24);
            this.cbStudentID.TabIndex = 4;
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnDate.Location = new System.Drawing.Point(19, 136);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(79, 16);
            this.lblReturnDate.TabIndex = 3;
            this.lblReturnDate.Text = "Return Date";
            // 
            // cbBookID
            // 
            this.cbBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBookID.FormattingEnabled = true;
            this.cbBookID.Location = new System.Drawing.Point(156, 48);
            this.cbBookID.Name = "cbBookID";
            this.cbBookID.Size = new System.Drawing.Size(77, 24);
            this.cbBookID.TabIndex = 2;
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.Location = new System.Drawing.Point(19, 91);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(69, 16);
            this.lblStudentID.TabIndex = 1;
            this.lblStudentID.Text = "Student ID";
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookID.Location = new System.Drawing.Point(19, 48);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(56, 16);
            this.lblBookID.TabIndex = 0;
            this.lblBookID.Text = "Book ID";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(259, 288);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 32);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 341);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbReturnDetails);
            this.Controls.Add(this.lblReturnBook);
            this.Name = "frmReturnBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Return Book";
            this.Load += new System.EventHandler(this.frmReturnBook_Load);
            this.gbReturnDetails.ResumeLayout(false);
            this.gbReturnDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReturnBook;
        private System.Windows.Forms.GroupBox gbReturnDetails;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.ComboBox cbBookID;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.ComboBox cbStudentID;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
    }
}