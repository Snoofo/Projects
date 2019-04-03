namespace Acme_Insurance.Presentation_Layer
{
    partial class frmTutorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTutorial));
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTut1 = new System.Windows.Forms.Label();
            this.lblTut2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(137, 390);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTut1
            // 
            this.lblTut1.AutoSize = true;
            this.lblTut1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTut1.Location = new System.Drawing.Point(26, 26);
            this.lblTut1.Name = "lblTut1";
            this.lblTut1.Size = new System.Drawing.Size(296, 13);
            this.lblTut1.TabIndex = 1;
            this.lblTut1.Text = "This is a brief tutorial which will guide you through ";
            // 
            // lblTut2
            // 
            this.lblTut2.AutoSize = true;
            this.lblTut2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTut2.Location = new System.Drawing.Point(110, 51);
            this.lblTut2.Name = "lblTut2";
            this.lblTut2.Size = new System.Drawing.Size(128, 13);
            this.lblTut2.TabIndex = 2;
            this.lblTut2.Text = "navigating the menus";
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.Location = new System.Drawing.Point(55, 92);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 276);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmTutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 424);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTut2);
            this.Controls.Add(this.lblTut1);
            this.Controls.Add(this.btnClose);
            this.Name = "frmTutorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tutorial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTut1;
        private System.Windows.Forms.Label lblTut2;
        private System.Windows.Forms.TextBox textBox1;
    }
}