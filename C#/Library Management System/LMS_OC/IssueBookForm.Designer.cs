namespace LMS_OC
{
    partial class frmIssueBook
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
            this.lblIssueBook = new System.Windows.Forms.Label();
            this.gbIssue = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblBookID = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbIssue.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIssueBook
            // 
            this.lblIssueBook.AutoSize = true;
            this.lblIssueBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueBook.Location = new System.Drawing.Point(133, 16);
            this.lblIssueBook.Name = "lblIssueBook";
            this.lblIssueBook.Size = new System.Drawing.Size(118, 20);
            this.lblIssueBook.TabIndex = 0;
            this.lblIssueBook.Text = "ISSUE BOOK";
            // 
            // gbIssue
            // 
            this.gbIssue.Controls.Add(this.btnSubmit);
            this.gbIssue.Controls.Add(this.txtStudentID);
            this.gbIssue.Controls.Add(this.txtBookID);
            this.gbIssue.Controls.Add(this.lblStudentID);
            this.gbIssue.Controls.Add(this.lblBookID);
            this.gbIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIssue.Location = new System.Drawing.Point(71, 44);
            this.gbIssue.Name = "gbIssue";
            this.gbIssue.Size = new System.Drawing.Size(243, 151);
            this.gbIssue.TabIndex = 1;
            this.gbIssue.TabStop = false;
            this.gbIssue.Text = "Details";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(138, 117);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(99, 28);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtStudentID
            // 
            this.txtStudentID.AcceptsReturn = true;
            this.txtStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentID.Location = new System.Drawing.Point(102, 57);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(100, 22);
            this.txtStudentID.TabIndex = 5;
            this.txtStudentID.TextChanged += new System.EventHandler(this.txtStudentID_TextChanged);
            // 
            // txtBookID
            // 
            this.txtBookID.AcceptsReturn = true;
            this.txtBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookID.Location = new System.Drawing.Point(102, 25);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(100, 22);
            this.txtBookID.TabIndex = 4;
            this.txtBookID.TextChanged += new System.EventHandler(this.txtBookID_TextChanged);
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.Location = new System.Drawing.Point(17, 62);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(69, 16);
            this.lblStudentID.TabIndex = 3;
            this.lblStudentID.Text = "Student ID";
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookID.Location = new System.Drawing.Point(17, 31);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(56, 16);
            this.lblBookID.TabIndex = 2;
            this.lblBookID.Text = "Book ID";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(209, 201);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 28);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmIssueBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 246);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbIssue);
            this.Controls.Add(this.lblIssueBook);
            this.Name = "frmIssueBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Issue Book";
            this.gbIssue.ResumeLayout(false);
            this.gbIssue.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIssueBook;
        private System.Windows.Forms.GroupBox gbIssue;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.Button btnClose;
    }
}