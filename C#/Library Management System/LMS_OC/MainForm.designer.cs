namespace LMS_OC
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.newStudentEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reserveBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newStudentEntryToolStripMenuItem,
            this.bookMasterToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(984, 27);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // newStudentEntryToolStripMenuItem
            // 
            this.newStudentEntryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newStudentToolStripMenuItem,
            this.editStudentToolStripMenuItem});
            this.newStudentEntryToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.newStudentEntryToolStripMenuItem.Name = "newStudentEntryToolStripMenuItem";
            this.newStudentEntryToolStripMenuItem.Size = new System.Drawing.Size(116, 23);
            this.newStudentEntryToolStripMenuItem.Text = "Student Master";
            // 
            // newStudentToolStripMenuItem
            // 
            this.newStudentToolStripMenuItem.Name = "newStudentToolStripMenuItem";
            this.newStudentToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.newStudentToolStripMenuItem.Text = "New Student";
            this.newStudentToolStripMenuItem.Click += new System.EventHandler(this.newStudentToolStripMenuItem_Click);
            // 
            // editStudentToolStripMenuItem
            // 
            this.editStudentToolStripMenuItem.Name = "editStudentToolStripMenuItem";
            this.editStudentToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.editStudentToolStripMenuItem.Text = "Edit Student";
            this.editStudentToolStripMenuItem.Click += new System.EventHandler(this.editStudentToolStripMenuItem_Click);
            // 
            // bookMasterToolStripMenuItem
            // 
            this.bookMasterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBookToolStripMenuItem,
            this.editBookToolStripMenuItem,
            this.searchBookToolStripMenuItem,
            this.issueBookToolStripMenuItem,
            this.returnBookToolStripMenuItem,
            this.reserveBookToolStripMenuItem});
            this.bookMasterToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bookMasterToolStripMenuItem.Name = "bookMasterToolStripMenuItem";
            this.bookMasterToolStripMenuItem.Size = new System.Drawing.Size(99, 23);
            this.bookMasterToolStripMenuItem.Text = "Book Master";
            // 
            // newBookToolStripMenuItem
            // 
            this.newBookToolStripMenuItem.Name = "newBookToolStripMenuItem";
            this.newBookToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.newBookToolStripMenuItem.Text = "Add New Book";
            this.newBookToolStripMenuItem.Click += new System.EventHandler(this.newBookToolStripMenuItem_Click);
            // 
            // editBookToolStripMenuItem
            // 
            this.editBookToolStripMenuItem.Name = "editBookToolStripMenuItem";
            this.editBookToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.editBookToolStripMenuItem.Text = "Edit Book";
            this.editBookToolStripMenuItem.Click += new System.EventHandler(this.editBookToolStripMenuItem_Click);
            // 
            // searchBookToolStripMenuItem
            // 
            this.searchBookToolStripMenuItem.Name = "searchBookToolStripMenuItem";
            this.searchBookToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.searchBookToolStripMenuItem.Text = "Search Book";
            this.searchBookToolStripMenuItem.Click += new System.EventHandler(this.searchBookToolStripMenuItem_Click);
            // 
            // issueBookToolStripMenuItem
            // 
            this.issueBookToolStripMenuItem.Name = "issueBookToolStripMenuItem";
            this.issueBookToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.issueBookToolStripMenuItem.Text = "Issue Book";
            this.issueBookToolStripMenuItem.Click += new System.EventHandler(this.issueBookToolStripMenuItem_Click);
            // 
            // returnBookToolStripMenuItem
            // 
            this.returnBookToolStripMenuItem.Name = "returnBookToolStripMenuItem";
            this.returnBookToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.returnBookToolStripMenuItem.Text = "Return Book";
            this.returnBookToolStripMenuItem.Click += new System.EventHandler(this.returnBookToolStripMenuItem_Click);
            // 
            // reserveBookToolStripMenuItem
            // 
            this.reserveBookToolStripMenuItem.Name = "reserveBookToolStripMenuItem";
            this.reserveBookToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.reserveBookToolStripMenuItem.Text = "Reserve Book";
            this.reserveBookToolStripMenuItem.Click += new System.EventHandler(this.reserveBookToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(42, 23);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 740);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 21, 0);
            this.statusStrip.Size = new System.Drawing.Size(984, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 762);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management System";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem newStudentEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reserveBookToolStripMenuItem;
    }
}



