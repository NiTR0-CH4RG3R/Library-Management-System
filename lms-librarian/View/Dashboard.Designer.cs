namespace lms_librarian.View
{
    partial class Dashboard
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
            this.buttonUsers = new System.Windows.Forms.Button();
            this.buttonBooks = new System.Windows.Forms.Button();
            this.buttonBurrowRequests = new System.Windows.Forms.Button();
            this.labelGreeting = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonUsers
            // 
            this.buttonUsers.Location = new System.Drawing.Point(11, 70);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(119, 66);
            this.buttonUsers.TabIndex = 0;
            this.buttonUsers.Text = "Manage Users";
            this.buttonUsers.UseVisualStyleBackColor = true;
            this.buttonUsers.Click += new System.EventHandler(this.buttonUsers_Click);
            // 
            // buttonBooks
            // 
            this.buttonBooks.Location = new System.Drawing.Point(136, 70);
            this.buttonBooks.Name = "buttonBooks";
            this.buttonBooks.Size = new System.Drawing.Size(119, 66);
            this.buttonBooks.TabIndex = 1;
            this.buttonBooks.Text = "Manage Books";
            this.buttonBooks.UseVisualStyleBackColor = true;
            this.buttonBooks.Click += new System.EventHandler(this.buttonBooks_Click);
            // 
            // buttonBurrowRequests
            // 
            this.buttonBurrowRequests.Location = new System.Drawing.Point(261, 70);
            this.buttonBurrowRequests.Name = "buttonBurrowRequests";
            this.buttonBurrowRequests.Size = new System.Drawing.Size(119, 66);
            this.buttonBurrowRequests.TabIndex = 2;
            this.buttonBurrowRequests.Text = "Manage Burrow Requests";
            this.buttonBurrowRequests.UseVisualStyleBackColor = true;
            this.buttonBurrowRequests.Click += new System.EventHandler(this.buttonBurrowRequests_Click);
            // 
            // labelGreeting
            // 
            this.labelGreeting.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelGreeting.AutoSize = true;
            this.labelGreeting.Location = new System.Drawing.Point(170, 22);
            this.labelGreeting.Name = "labelGreeting";
            this.labelGreeting.Size = new System.Drawing.Size(38, 15);
            this.labelGreeting.TabIndex = 3;
            this.labelGreeting.Text = "label1";
            this.labelGreeting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 151);
            this.Controls.Add(this.labelGreeting);
            this.Controls.Add(this.buttonBurrowRequests);
            this.Controls.Add(this.buttonBooks);
            this.Controls.Add(this.buttonUsers);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonUsers;
        private Button buttonBooks;
        private Button buttonBurrowRequests;
        private Label labelGreeting;
    }
}