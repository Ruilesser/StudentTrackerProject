namespace StudentTracker
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UserLabel = new Label();
            userBox = new TextBox();
            label2 = new Label();
            PassBox = new TextBox();
            enterBtn = new Button();
            exitBtn = new Button();
            SuspendLayout();
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserLabel.Location = new Point(24, 36);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(156, 31);
            UserLabel.TabIndex = 0;
            UserLabel.Text = "User Number";
            // 
            // userBox
            // 
            userBox.Font = new Font("Segoe UI", 14F);
            userBox.Location = new Point(204, 33);
            userBox.Name = "userBox";
            userBox.Size = new Size(237, 39);
            userBox.TabIndex = 1;
            userBox.KeyPress += userBox_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 116);
            label2.Name = "label2";
            label2.Size = new Size(114, 31);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // PassBox
            // 
            PassBox.Font = new Font("Segoe UI", 14F);
            PassBox.Location = new Point(204, 116);
            PassBox.Name = "PassBox";
            PassBox.Size = new Size(237, 39);
            PassBox.TabIndex = 3;
            // 
            // enterBtn
            // 
            enterBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            enterBtn.Location = new Point(287, 213);
            enterBtn.Name = "enterBtn";
            enterBtn.Size = new Size(154, 70);
            enterBtn.TabIndex = 5;
            enterBtn.Text = "Enter";
            enterBtn.UseVisualStyleBackColor = true;
            // 
            // exitBtn
            // 
            exitBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitBtn.Location = new Point(24, 213);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(156, 70);
            exitBtn.TabIndex = 4;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 346);
            Controls.Add(exitBtn);
            Controls.Add(enterBtn);
            Controls.Add(PassBox);
            Controls.Add(label2);
            Controls.Add(userBox);
            Controls.Add(UserLabel);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UserLabel;
        private TextBox userBox;
        private Label label2;
        private TextBox PassBox;
        private Button enterBtn;
        private Button exitBtn;
    }
}
