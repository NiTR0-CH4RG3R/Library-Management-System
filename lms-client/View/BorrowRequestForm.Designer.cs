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
            listView1 = new ListView();
            buttonRemove = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(42, 33);
            listView1.Name = "listView1";
            listView1.Size = new Size(726, 290);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(612, 370);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(156, 38);
            buttonRemove.TabIndex = 1;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = true;
            // 
            // BorrowRequestForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonRemove);
            Controls.Add(listView1);
            Name = "BorrowRequestForm";
            Text = "BorrowRequestForm";
            Load += BorrowRequestForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private Button buttonRemove;
    }
}