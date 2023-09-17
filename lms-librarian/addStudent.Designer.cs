namespace lms_librarian
{
    partial class addStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addStudent));
            panel1=new Panel();
            label1=new Label();
            pictureBox1=new PictureBox();
            pictureBox2=new PictureBox();
            panel2=new Panel();
            btnExit=new Button();
            btnRegister=new Button();
            btnClear=new Button();
            txtDpt=new Button();
            txtEmail=new Button();
            txtNum=new Button();
            txtId=new Button();
            txtName=new Button();
            label6=new Label();
            label5=new Label();
            label4=new Label();
            label3=new Label();
            label2=new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor=SystemColors.ControlDark;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location=new Point(0, 2);
            panel1.Name="panel1";
            panel1.Size=new Size(904, 126);
            panel1.TabIndex=0;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location=new Point(398, 43);
            label1.Name="label1";
            label1.Size=new Size(182, 38);
            label1.TabIndex=1;
            label1.Text="Add Student";
            label1.Click+=label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image=(Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location=new Point(291, -3);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(123, 126);
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex=1;
            pictureBox1.TabStop=false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image=(Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location=new Point(0, 134);
            pictureBox2.Name="pictureBox2";
            pictureBox2.Size=new Size(321, 390);
            pictureBox2.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex=2;
            pictureBox2.TabStop=false;
            // 
            // panel2
            // 
            panel2.BackColor=Color.FromArgb(192, 255, 255);
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(btnRegister);
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(txtDpt);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(txtNum);
            panel2.Controls.Add(txtId);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location=new Point(327, 134);
            panel2.Name="panel2";
            panel2.Size=new Size(577, 390);
            panel2.TabIndex=3;
            // 
            // btnExit
            // 
            btnExit.Font=new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.Location=new Point(432, 327);
            btnExit.Name="btnExit";
            btnExit.Size=new Size(112, 34);
            btnExit.TabIndex=12;
            btnExit.Text="Exit";
            btnExit.UseVisualStyleBackColor=true;
            // 
            // btnRegister
            // 
            btnRegister.Font=new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.Location=new Point(269, 327);
            btnRegister.Name="btnRegister";
            btnRegister.Size=new Size(142, 34);
            btnRegister.TabIndex=11;
            btnRegister.Text="Register";
            btnRegister.UseVisualStyleBackColor=true;
            // 
            // btnClear
            // 
            btnClear.Font=new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location=new Point(141, 327);
            btnClear.Name="btnClear";
            btnClear.Size=new Size(112, 34);
            btnClear.TabIndex=10;
            btnClear.Text="Clear";
            btnClear.UseVisualStyleBackColor=true;
            // 
            // txtDpt
            // 
            txtDpt.Location=new Point(256, 251);
            txtDpt.Name="txtDpt";
            txtDpt.Size=new Size(259, 34);
            txtDpt.TabIndex=9;
            txtDpt.UseVisualStyleBackColor=true;
            // 
            // txtEmail
            // 
            txtEmail.Location=new Point(256, 193);
            txtEmail.Name="txtEmail";
            txtEmail.Size=new Size(259, 34);
            txtEmail.TabIndex=8;
            txtEmail.UseVisualStyleBackColor=true;
            // 
            // txtNum
            // 
            txtNum.Location=new Point(256, 129);
            txtNum.Name="txtNum";
            txtNum.Size=new Size(259, 34);
            txtNum.TabIndex=7;
            txtNum.UseVisualStyleBackColor=true;
            // 
            // txtId
            // 
            txtId.Location=new Point(256, 70);
            txtId.Name="txtId";
            txtId.Size=new Size(259, 34);
            txtId.TabIndex=6;
            txtId.UseVisualStyleBackColor=true;
            // 
            // txtName
            // 
            txtName.Location=new Point(256, 14);
            txtName.Name="txtName";
            txtName.Size=new Size(259, 34);
            txtName.TabIndex=5;
            txtName.UseVisualStyleBackColor=true;
            // 
            // label6
            // 
            label6.AutoSize=true;
            label6.Font=new Font("Berlin Sans FB", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location=new Point(31, 262);
            label6.Name="label6";
            label6.Size=new Size(114, 23);
            label6.TabIndex=4;
            label6.Text="Departmant";
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Font=new Font("Berlin Sans FB", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location=new Point(33, 204);
            label5.Name="label5";
            label5.Size=new Size(56, 23);
            label5.TabIndex=3;
            label5.Text="Email";
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Font=new Font("Berlin Sans FB", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location=new Point(31, 140);
            label4.Name="label4";
            label4.Size=new Size(149, 23);
            label4.TabIndex=2;
            label4.Text="Contact Number";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Font=new Font("Berlin Sans FB", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location=new Point(31, 81);
            label3.Name="label3";
            label3.Size=new Size(98, 23);
            label3.TabIndex=1;
            label3.Text="Student ID";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Berlin Sans FB", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location=new Point(31, 25);
            label2.Name="label2";
            label2.Size=new Size(131, 23);
            label2.TabIndex=0;
            label2.Text="Student Name";
            // 
            // addStudent
            // 
            AutoScaleDimensions=new SizeF(10F, 25F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(902, 527);
            Controls.Add(panel2);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Name="addStudent";
            StartPosition=FormStartPosition.CenterScreen;
            Text="addStudent";
            Load+=addStudent_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button txtName;
        private Button txtDpt;
        private Button txtEmail;
        private Button txtNum;
        private Button txtId;
        private Button btnExit;
        private Button btnRegister;
        private Button btnClear;
    }
}