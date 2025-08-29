namespace StudentTracker
{
    partial class FormSettings
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
            userBox = new TextBox();
            UserLabel = new Label();
            dateTimePicker1 = new DateTimePicker();
            startDp = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            dayEarningsBox = new TextBox();
            label1 = new Label();
            explanationTxt = new TextBox();
            label2 = new Label();
            closeBtn = new Button();
            updateBtn = new Button();
            SuspendLayout();
            // 
            // userBox
            // 
            userBox.Font = new Font("Segoe UI", 14F);
            userBox.Location = new Point(192, 27);
            userBox.Name = "userBox";
            userBox.ReadOnly = true;
            userBox.Size = new Size(190, 39);
            userBox.TabIndex = 14;
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserLabel.Location = new Point(12, 30);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(156, 31);
            UserLabel.TabIndex = 17;
            UserLabel.Text = "User Number";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(132, 139);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 1;
            // 
            // startDp
            // 
            startDp.Location = new Point(132, 84);
            startDp.Name = "startDp";
            startDp.Size = new Size(250, 27);
            startDp.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 139);
            label7.Name = "label7";
            label7.Size = new Size(54, 31);
            label7.TabIndex = 19;
            label7.Text = "End";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 80);
            label6.Name = "label6";
            label6.Size = new Size(66, 31);
            label6.TabIndex = 18;
            label6.Text = "Start";
            label6.Click += label6_Click;
            // 
            // dayEarningsBox
            // 
            dayEarningsBox.Font = new Font("Segoe UI", 14F);
            dayEarningsBox.Location = new Point(192, 183);
            dayEarningsBox.Name = "dayEarningsBox";
            dayEarningsBox.ReadOnly = true;
            dayEarningsBox.Size = new Size(190, 39);
            dayEarningsBox.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 186);
            label1.Name = "label1";
            label1.Size = new Size(153, 31);
            label1.TabIndex = 21;
            label1.Text = "Day Earnings";
            // 
            // explanationTxt
            // 
            explanationTxt.Font = new Font("Segoe UI", 14F);
            explanationTxt.Location = new Point(192, 237);
            explanationTxt.Multiline = true;
            explanationTxt.Name = "explanationTxt";
            explanationTxt.Size = new Size(404, 164);
            explanationTxt.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 240);
            label2.Name = "label2";
            label2.Size = new Size(142, 31);
            label2.TabIndex = 23;
            label2.Text = "Explanation";
            // 
            // closeBtn
            // 
            closeBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeBtn.Location = new Point(340, 423);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(117, 59);
            closeBtn.TabIndex = 4;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateBtn.Location = new Point(189, 423);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(125, 59);
            updateBtn.TabIndex = 3;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            // 
            // FormSettings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 505);
            Controls.Add(closeBtn);
            Controls.Add(updateBtn);
            Controls.Add(explanationTxt);
            Controls.Add(label2);
            Controls.Add(dayEarningsBox);
            Controls.Add(label1);
            Controls.Add(userBox);
            Controls.Add(UserLabel);
            Controls.Add(dateTimePicker1);
            Controls.Add(startDp);
            Controls.Add(label7);
            Controls.Add(label6);
            Name = "FormSettings";
            Text = "FormSettings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userBox;
        private Label UserLabel;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker startDp;
        private Label label7;
        private Label label6;
        private TextBox dayEarningsBox;
        private Label label1;
        private TextBox explanationTxt;
        private Label label2;
        private Button closeBtn;
        private Button updateBtn;
    }
}