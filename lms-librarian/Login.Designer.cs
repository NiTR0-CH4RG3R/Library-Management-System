namespace lms_librarian
{
    partial class Login
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
            label1=new Label();
            label2=new Label();
            textBoxUsername=new TextBox();
            textBoxPassword=new TextBox();
            label3=new Label();
            buttonCancel=new Button();
            buttonLogin=new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(17, 62);
            label1.Margin=new Padding(4, 0, 4, 0);
            label1.Name="label1";
            label1.Size=new Size(98, 25);
            label1.TabIndex=0;
            label1.Text="username :";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(20, 110);
            label2.Margin=new Padding(4, 0, 4, 0);
            label2.Name="label2";
            label2.Size=new Size(98, 25);
            label2.TabIndex=1;
            label2.Text="password :";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location=new Point(119, 57);
            textBoxUsername.Margin=new Padding(4, 5, 4, 5);
            textBoxUsername.Name="textBoxUsername";
            textBoxUsername.Size=new Size(141, 31);
            textBoxUsername.TabIndex=2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location=new Point(119, 105);
            textBoxPassword.Margin=new Padding(4, 5, 4, 5);
            textBoxPassword.Name="textBoxPassword";
            textBoxPassword.Size=new Size(141, 31);
            textBoxPassword.TabIndex=3;
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(17, 15);
            label3.Margin=new Padding(4, 0, 4, 0);
            label3.Name="label3";
            label3.Size=new Size(56, 25);
            label3.TabIndex=4;
            label3.Text="Login";
            // 
            // buttonCancel
            // 
            buttonCancel.Location=new Point(39, 180);
            buttonCancel.Margin=new Padding(4, 5, 4, 5);
            buttonCancel.Name="buttonCancel";
            buttonCancel.Size=new Size(107, 38);
            buttonCancel.TabIndex=5;
            buttonCancel.Text="Cancel";
            buttonCancel.UseVisualStyleBackColor=true;
            // 
            // buttonLogin
            // 
            buttonLogin.Location=new Point(154, 180);
            buttonLogin.Margin=new Padding(4, 5, 4, 5);
            buttonLogin.Name="buttonLogin";
            buttonLogin.Size=new Size(107, 38);
            buttonLogin.TabIndex=6;
            buttonLogin.Text="Login";
            buttonLogin.UseVisualStyleBackColor=true;
            buttonLogin.Click+=buttonLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions=new SizeF(10F, 25F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(291, 247);
            Controls.Add(buttonLogin);
            Controls.Add(buttonCancel);
            Controls.Add(label3);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            Margin=new Padding(4, 5, 4, 5);
            MaximizeBox=false;
            Name="Login";
            Text="Login";
            Load+=Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Label label3;
        private Button buttonCancel;
        private Button buttonLogin;
    }
}