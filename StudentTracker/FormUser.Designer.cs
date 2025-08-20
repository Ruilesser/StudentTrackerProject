namespace StudentTracker
{
    partial class FormUser
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
            panel1 = new Panel();
            adminCh = new CheckBox();
            passwordBox = new TextBox();
            label1 = new Label();
            checkBtn = new Button();
            userBox = new TextBox();
            UserLabel = new Label();
            nameBox = new TextBox();
            label2 = new Label();
            surnameBox = new TextBox();
            label3 = new Label();
            imageBox = new TextBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            browseBtn = new Button();
            salaryBox = new TextBox();
            label5 = new Label();
            label6 = new Label();
            positionCmb = new ComboBox();
            label7 = new Label();
            facultyCmb = new ComboBox();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label9 = new Label();
            addressBox = new TextBox();
            closeBtn = new Button();
            updateBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(adminCh);
            panel1.Controls.Add(passwordBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(checkBtn);
            panel1.Controls.Add(userBox);
            panel1.Controls.Add(UserLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(827, 91);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // adminCh
            // 
            adminCh.AutoSize = true;
            adminCh.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adminCh.Location = new Point(660, 52);
            adminCh.Name = "adminCh";
            adminCh.Size = new Size(141, 35);
            adminCh.TabIndex = 3;
            adminCh.Text = "Is Admin?";
            adminCh.UseVisualStyleBackColor = true;
            // 
            // passwordBox
            // 
            passwordBox.Font = new Font("Segoe UI", 14F);
            passwordBox.Location = new Point(621, 7);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(180, 39);
            passwordBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(501, 10);
            label1.Name = "label1";
            label1.Size = new Size(114, 31);
            label1.TabIndex = 8;
            label1.Text = "Password";
            // 
            // checkBtn
            // 
            checkBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBtn.Location = new Point(368, 7);
            checkBtn.Name = "checkBtn";
            checkBtn.Size = new Size(110, 39);
            checkBtn.TabIndex = 1;
            checkBtn.Text = "Check";
            checkBtn.UseVisualStyleBackColor = true;
            // 
            // userBox
            // 
            userBox.Font = new Font("Segoe UI", 14F);
            userBox.Location = new Point(182, 12);
            userBox.Name = "userBox";
            userBox.Size = new Size(180, 39);
            userBox.TabIndex = 0;
            userBox.KeyPress += userBox_KeyPress;
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserLabel.Location = new Point(20, 15);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(156, 31);
            UserLabel.TabIndex = 4;
            UserLabel.Text = "User Number";
            // 
            // nameBox
            // 
            nameBox.Font = new Font("Segoe UI", 14F);
            nameBox.Location = new Point(182, 139);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(180, 39);
            nameBox.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 139);
            label2.Name = "label2";
            label2.Size = new Size(77, 31);
            label2.TabIndex = 10;
            label2.Text = "Name";
            label2.Click += label2_Click;
            // 
            // surnameBox
            // 
            surnameBox.Font = new Font("Segoe UI", 14F);
            surnameBox.Location = new Point(182, 184);
            surnameBox.Name = "surnameBox";
            surnameBox.Size = new Size(180, 39);
            surnameBox.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 184);
            label3.Name = "label3";
            label3.Size = new Size(109, 31);
            label3.TabIndex = 12;
            label3.Text = "Surname";
            // 
            // imageBox
            // 
            imageBox.Font = new Font("Segoe UI", 14F);
            imageBox.Location = new Point(182, 229);
            imageBox.Name = "imageBox";
            imageBox.Size = new Size(180, 39);
            imageBox.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(20, 229);
            label4.Name = "label4";
            label4.Size = new Size(134, 31);
            label4.TabIndex = 14;
            label4.Text = "Image Path";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(536, 104);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 213);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // browseBtn
            // 
            browseBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            browseBtn.Location = new Point(378, 229);
            browseBtn.Name = "browseBtn";
            browseBtn.Size = new Size(110, 39);
            browseBtn.TabIndex = 3;
            browseBtn.Text = "Browse";
            browseBtn.UseVisualStyleBackColor = true;
            // 
            // salaryBox
            // 
            salaryBox.Font = new Font("Segoe UI", 14F);
            salaryBox.Location = new Point(182, 278);
            salaryBox.Name = "salaryBox";
            salaryBox.Size = new Size(180, 39);
            salaryBox.TabIndex = 4;
            salaryBox.KeyPress += salaryBox_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(20, 278);
            label5.Name = "label5";
            label5.Size = new Size(80, 31);
            label5.TabIndex = 18;
            label5.Text = "Salary";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(20, 324);
            label6.Name = "label6";
            label6.Size = new Size(90, 31);
            label6.TabIndex = 19;
            label6.Text = "Faculty";
            // 
            // positionCmb
            // 
            positionCmb.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            positionCmb.FormattingEnabled = true;
            positionCmb.Location = new Point(182, 369);
            positionCmb.Name = "positionCmb";
            positionCmb.Size = new Size(180, 39);
            positionCmb.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(20, 369);
            label7.Name = "label7";
            label7.Size = new Size(102, 31);
            label7.TabIndex = 21;
            label7.Text = "Position";
            // 
            // facultyCmb
            // 
            facultyCmb.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            facultyCmb.FormattingEnabled = true;
            facultyCmb.Location = new Point(182, 323);
            facultyCmb.Name = "facultyCmb";
            facultyCmb.Size = new Size(180, 39);
            facultyCmb.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(20, 424);
            label8.Name = "label8";
            label8.Size = new Size(107, 31);
            label8.TabIndex = 23;
            label8.Text = "Birthday";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(182, 425);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(180, 30);
            dateTimePicker1.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(20, 469);
            label9.Name = "label9";
            label9.Size = new Size(99, 31);
            label9.TabIndex = 25;
            label9.Text = "Address";
            // 
            // addressBox
            // 
            addressBox.Font = new Font("Segoe UI", 14F);
            addressBox.Location = new Point(182, 469);
            addressBox.Multiline = true;
            addressBox.Name = "addressBox";
            addressBox.Size = new Size(352, 80);
            addressBox.TabIndex = 8;
            // 
            // closeBtn
            // 
            closeBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeBtn.Location = new Point(695, 479);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(120, 58);
            closeBtn.TabIndex = 10;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateBtn.Location = new Point(561, 479);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(120, 58);
            updateBtn.TabIndex = 9;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // FormUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 587);
            Controls.Add(closeBtn);
            Controls.Add(updateBtn);
            Controls.Add(addressBox);
            Controls.Add(label9);
            Controls.Add(dateTimePicker1);
            Controls.Add(label8);
            Controls.Add(facultyCmb);
            Controls.Add(positionCmb);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(salaryBox);
            Controls.Add(label5);
            Controls.Add(browseBtn);
            Controls.Add(pictureBox1);
            Controls.Add(imageBox);
            Controls.Add(label4);
            Controls.Add(surnameBox);
            Controls.Add(label3);
            Controls.Add(nameBox);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "FormUser";
            Text = "FormUser";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox userBox;
        private Label UserLabel;
        private TextBox passwordBox;
        private Label label1;
        private Button checkBtn;
        private CheckBox adminCh;
        private TextBox nameBox;
        private Label label2;
        private TextBox surnameBox;
        private Label label3;
        private TextBox imageBox;
        private Label label4;
        private PictureBox pictureBox1;
        private Button browseBtn;
        private TextBox salaryBox;
        private Label label5;
        private Label label6;
        private ComboBox positionCmb;
        private Label label7;
        private ComboBox facultyCmb;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private Label label9;
        private TextBox addressBox;
        private Button closeBtn;
        private Button updateBtn;
    }
}