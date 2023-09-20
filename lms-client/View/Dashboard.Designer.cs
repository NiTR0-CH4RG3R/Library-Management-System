namespace lms_client.View
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
            this.labelGreeting = new System.Windows.Forms.Label();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonBurrowRequest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelGreeting
            // 
            this.labelGreeting.AutoSize = true;
            this.labelGreeting.Location = new System.Drawing.Point(126, 39);
            this.labelGreeting.Name = "labelGreeting";
            this.labelGreeting.Size = new System.Drawing.Size(38, 15);
            this.labelGreeting.TabIndex = 0;
            this.labelGreeting.Text = "label1";
            this.labelGreeting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(49, 109);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(81, 53);
            this.buttonBrowse.TabIndex = 1;
            this.buttonBrowse.Text = "Browse Books";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonBurrowRequest
            // 
            this.buttonBurrowRequest.Location = new System.Drawing.Point(146, 109);
            this.buttonBurrowRequest.Name = "buttonBurrowRequest";
            this.buttonBurrowRequest.Size = new System.Drawing.Size(114, 53);
            this.buttonBurrowRequest.TabIndex = 2;
            this.buttonBurrowRequest.Text = "Show Your Burrow Requests";
            this.buttonBurrowRequest.UseVisualStyleBackColor = true;
            this.buttonBurrowRequest.Click += new System.EventHandler(this.buttonBurrowRequest_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 192);
            this.Controls.Add(this.buttonBurrowRequest);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.labelGreeting);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelGreeting;
        private Button buttonBrowse;
        private Button buttonBurrowRequest;
    }
}