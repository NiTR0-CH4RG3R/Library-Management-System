namespace lms_client.View
{
    partial class BorrowRequestForm
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
            this.listView = new System.Windows.Forms.ListView();
            this.RequestedUser = new System.Windows.Forms.ColumnHeader();
            this.RequestedBook = new System.Windows.Forms.ColumnHeader();
            this.RequestDate = new System.Windows.Forms.ColumnHeader();
            this.ReviewDate = new System.Windows.Forms.ColumnHeader();
            this.Approved = new System.Windows.Forms.ColumnHeader();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RequestedUser,
            this.RequestedBook,
            this.RequestDate,
            this.ReviewDate,
            this.Approved});
            this.listView.FullRowSelect = true;
            this.listView.Location = new System.Drawing.Point(37, 25);
            this.listView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(636, 218);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // RequestedUser
            // 
            this.RequestedUser.Text = "RequestedUser";
            // 
            // RequestedBook
            // 
            this.RequestedBook.Text = "RequestedBook";
            // 
            // RequestDate
            // 
            this.RequestDate.Text = "RequestDate";
            // 
            // ReviewDate
            // 
            this.ReviewDate.Text = "ReviewDate";
            // 
            // Approved
            // 
            this.Approved.Text = "Approved";
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(536, 278);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(136, 28);
            this.buttonRemove.TabIndex = 1;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // BorrowRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.listView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BorrowRequestForm";
            this.Text = "BorrowRequestForm";
            this.Load += new System.EventHandler(this.BorrowRequestForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listView;
        private Button buttonRemove;
        private ColumnHeader RequestedUser;
        private ColumnHeader RequestedBook;
        private ColumnHeader RequestDate;
        private ColumnHeader ReviewDate;
        private ColumnHeader Approved;
    }
}