namespace lms_client.View
{
    partial class BrowseForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxISBN = new TextBox();
            textBoxAuthor = new TextBox();
            textBoxTitle = new TextBox();
            buttonSearch = new Button();
            listView = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 28);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 0;
            label1.Text = "ISBN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(589, 28);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 1;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(282, 28);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 2;
            label3.Text = "Author";
            // 
            // textBoxISBN
            // 
            textBoxISBN.Location = new Point(29, 74);
            textBoxISBN.Name = "textBoxISBN";
            textBoxISBN.Size = new Size(200, 27);
            textBoxISBN.TabIndex = 3;
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Location = new Point(282, 74);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(253, 27);
            textBoxAuthor.TabIndex = 4;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(589, 74);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(350, 27);
            textBoxTitle.TabIndex = 5;
            // 
            // buttonSearch
            // 
            buttonSearch.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSearch.Location = new Point(778, 120);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(161, 31);
            buttonSearch.TabIndex = 6;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            // 
            // listView
            // 
            listView.Location = new Point(31, 207);
            listView.Name = "listView";
            listView.Size = new Size(908, 298);
            listView.TabIndex = 7;
            listView.UseCompatibleStateImageBehavior = false;
            // 
            // BrowseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(listView);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxTitle);
            Controls.Add(textBoxAuthor);
            Controls.Add(textBoxISBN);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BrowseForm";
            Text = "BrowseForm";
            Load += BrowseForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxISBN;
        private TextBox textBoxAuthor;
        private TextBox textBoxTitle;
        private Button buttonSearch;
        private ListView listView;
    }
}