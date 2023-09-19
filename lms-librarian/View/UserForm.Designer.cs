namespace lms_librarian.View
{
    partial class UserForm
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
            label4 = new Label();
            textBoxName = new TextBox();
            textBoxNIC = new TextBox();
            textBoxContact = new TextBox();
            textBoxAddress = new TextBox();
            listView = new ListView();
            buttonAdd = new Button();
            buttonSearch = new Button();
            buttonRemove = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 52);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 0;
            label1.Text = "Name               :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 128);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 1;
            label2.Text = "NIC                   :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 199);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 2;
            label3.Text = "Contact No.     :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 274);
            label4.Name = "label4";
            label4.Size = new Size(109, 20);
            label4.TabIndex = 3;
            label4.Text = "Address           :";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(166, 49);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(225, 27);
            textBoxName.TabIndex = 4;
            // 
            // textBoxNIC
            // 
            textBoxNIC.Location = new Point(166, 125);
            textBoxNIC.Name = "textBoxNIC";
            textBoxNIC.Size = new Size(225, 27);
            textBoxNIC.TabIndex = 5;
            // 
            // textBoxContact
            // 
            textBoxContact.Location = new Point(166, 196);
            textBoxContact.Name = "textBoxContact";
            textBoxContact.Size = new Size(225, 27);
            textBoxContact.TabIndex = 6;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(166, 271);
            textBoxAddress.Multiline = true;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(225, 108);
            textBoxAddress.TabIndex = 7;
            // 
            // listView
            // 
            listView.Location = new Point(455, 49);
            listView.Name = "listView";
            listView.Size = new Size(486, 330);
            listView.TabIndex = 8;
            listView.UseCompatibleStateImageBehavior = false;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(26, 442);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(92, 29);
            buttonAdd.TabIndex = 9;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(166, 442);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(92, 29);
            buttonSearch.TabIndex = 10;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(299, 442);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(92, 29);
            buttonRemove.TabIndex = 11;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = true;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(buttonRemove);
            Controls.Add(buttonSearch);
            Controls.Add(buttonAdd);
            Controls.Add(listView);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxContact);
            Controls.Add(textBoxNIC);
            Controls.Add(textBoxName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "User";
            Text = "User";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxName;
        private TextBox textBoxNIC;
        private TextBox textBoxContact;
        private TextBox textBoxAddress;
        private ListView listView;
        private Button buttonAdd;
        private Button buttonSearch;
        private Button buttonRemove;
    }
}