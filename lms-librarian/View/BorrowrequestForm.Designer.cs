namespace lms_librarian.View
{
    partial class BorrowrequestForm
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
            listView = new ListView();
            buttonApprove = new Button();
            buttonDisapprove = new Button();
            buttonRefresh = new Button();
            SuspendLayout();
            // 
            // listView
            // 
            listView.Location = new Point(38, 39);
            listView.Name = "listView";
            listView.Size = new Size(728, 251);
            listView.TabIndex = 0;
            listView.UseCompatibleStateImageBehavior = false;
            // 
            // buttonApprove
            // 
            buttonApprove.Location = new Point(297, 353);
            buttonApprove.Name = "buttonApprove";
            buttonApprove.Size = new Size(141, 40);
            buttonApprove.TabIndex = 1;
            buttonApprove.Text = "Approve";
            buttonApprove.UseVisualStyleBackColor = true;
            // 
            // buttonDisapprove
            // 
            buttonDisapprove.Location = new Point(461, 353);
            buttonDisapprove.Name = "buttonDisapprove";
            buttonDisapprove.Size = new Size(141, 40);
            buttonDisapprove.TabIndex = 2;
            buttonDisapprove.Text = "Disapprove";
            buttonDisapprove.UseVisualStyleBackColor = true;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(625, 353);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(141, 40);
            buttonRefresh.TabIndex = 3;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // Borrowrequest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonRefresh);
            Controls.Add(buttonDisapprove);
            Controls.Add(buttonApprove);
            Controls.Add(listView);
            Name = "Borrowrequest";
            Text = "Borrowrequest";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView;
        private Button buttonApprove;
        private Button buttonDisapprove;
        private Button buttonRefresh;
    }
}