namespace lms_librarian.View
{
    partial class BookForm
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
            labelISBN = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxISBN = new TextBox();
            textBoxTitle = new TextBox();
            textBoxAuthor = new TextBox();
            textBoxQty = new TextBox();
            listView = new ListView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // labelISBN
            // 
            labelISBN.AutoSize = true;
            labelISBN.Location = new Point(34, 64);
            labelISBN.Name = "labelISBN";
            labelISBN.Size = new Size(88, 20);
            labelISBN.TabIndex = 0;
            labelISBN.Text = "ISBN           :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 150);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 1;
            label2.Text = "Title           :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 229);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 2;
            label3.Text = "Author       :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 309);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 3;
            label4.Text = "Qty            :";
            // 
            // textBoxISBN
            // 
            textBoxISBN.Location = new Point(152, 61);
            textBoxISBN.Name = "textBoxISBN";
            textBoxISBN.Size = new Size(215, 27);
            textBoxISBN.TabIndex = 4;
            textBoxISBN.TextChanged += textBoxISBN_TextChanged;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(152, 147);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(215, 27);
            textBoxTitle.TabIndex = 5;
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Location = new Point(152, 226);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(215, 27);
            textBoxAuthor.TabIndex = 6;
            // 
            // textBoxQty
            // 
            textBoxQty.Location = new Point(152, 306);
            textBoxQty.Name = "textBoxQty";
            textBoxQty.Size = new Size(215, 27);
            textBoxQty.TabIndex = 7;
            // 
            // listView
            // 
            listView.Location = new Point(451, 55);
            listView.Name = "listView";
            listView.Size = new Size(508, 340);
            listView.TabIndex = 8;
            listView.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.Location = new Point(34, 426);
            button1.Name = "button1";
            button1.Size = new Size(80, 28);
            button1.TabIndex = 9;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(162, 426);
            button2.Name = "button2";
            button2.Size = new Size(80, 28);
            button2.TabIndex = 10;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(287, 426);
            button3.Name = "button3";
            button3.Size = new Size(80, 28);
            button3.TabIndex = 11;
            button3.Text = "Remove";
            button3.UseVisualStyleBackColor = true;
            // 
            // Book
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView);
            Controls.Add(textBoxQty);
            Controls.Add(textBoxAuthor);
            Controls.Add(textBoxTitle);
            Controls.Add(textBoxISBN);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(labelISBN);
            Name = "Book";
            Text = "Book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelISBN;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxISBN;
        private TextBox textBoxTitle;
        private TextBox textBoxAuthor;
        private TextBox textBoxQty;
        private ListView listView;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}