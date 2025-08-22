namespace StudentTracker
{
    partial class FormSchedule
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
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            positionCmb = new ComboBox();
            label4 = new Label();
            facultyCmb = new ComboBox();
            label3 = new Label();
            surnameBox = new TextBox();
            label2 = new Label();
            nameBox = new TextBox();
            label1 = new Label();
            userBox = new TextBox();
            UserLabel = new Label();
            statusCmb = new ComboBox();
            label8 = new Label();
            courseNameBox = new TextBox();
            label5 = new Label();
            contentBox = new TextBox();
            label6 = new Label();
            closeBtn = new Button();
            updateBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(478, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(289, 532);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 197);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(289, 335);
            dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(positionCmb);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(facultyCmb);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(289, 197);
            panel2.TabIndex = 0;
            // 
            // positionCmb
            // 
            positionCmb.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            positionCmb.FormattingEnabled = true;
            positionCmb.Location = new Point(13, 143);
            positionCmb.Name = "positionCmb";
            positionCmb.Size = new Size(180, 39);
            positionCmb.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(13, 99);
            label4.Name = "label4";
            label4.Size = new Size(102, 31);
            label4.TabIndex = 20;
            label4.Text = "Position";
            label4.Click += label4_Click;
            // 
            // facultyCmb
            // 
            facultyCmb.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            facultyCmb.FormattingEnabled = true;
            facultyCmb.Location = new Point(13, 49);
            facultyCmb.Name = "facultyCmb";
            facultyCmb.Size = new Size(180, 39);
            facultyCmb.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 9);
            label3.Name = "label3";
            label3.Size = new Size(90, 31);
            label3.TabIndex = 19;
            label3.Text = "Faculty";
            // 
            // surnameBox
            // 
            surnameBox.Font = new Font("Segoe UI", 14F);
            surnameBox.Location = new Point(192, 118);
            surnameBox.Name = "surnameBox";
            surnameBox.ReadOnly = true;
            surnameBox.Size = new Size(180, 39);
            surnameBox.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 108);
            label2.Name = "label2";
            label2.Size = new Size(109, 31);
            label2.TabIndex = 12;
            label2.Text = "Surname";
            // 
            // nameBox
            // 
            nameBox.Font = new Font("Segoe UI", 14F);
            nameBox.Location = new Point(192, 59);
            nameBox.Name = "nameBox";
            nameBox.ReadOnly = true;
            nameBox.Size = new Size(180, 39);
            nameBox.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 59);
            label1.Name = "label1";
            label1.Size = new Size(77, 31);
            label1.TabIndex = 11;
            label1.Text = "Name";
            // 
            // userBox
            // 
            userBox.Font = new Font("Segoe UI", 14F);
            userBox.Location = new Point(192, 6);
            userBox.Name = "userBox";
            userBox.ReadOnly = true;
            userBox.Size = new Size(180, 39);
            userBox.TabIndex = 7;
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserLabel.Location = new Point(12, 9);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(156, 31);
            UserLabel.TabIndex = 10;
            UserLabel.Text = "User Number";
            // 
            // statusCmb
            // 
            statusCmb.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusCmb.FormattingEnabled = true;
            statusCmb.Location = new Point(192, 178);
            statusCmb.Name = "statusCmb";
            statusCmb.Size = new Size(180, 39);
            statusCmb.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(10, 178);
            label8.Name = "label8";
            label8.Size = new Size(80, 31);
            label8.TabIndex = 20;
            label8.Text = "Status";
            // 
            // courseNameBox
            // 
            courseNameBox.Font = new Font("Segoe UI", 14F);
            courseNameBox.Location = new Point(192, 230);
            courseNameBox.Name = "courseNameBox";
            courseNameBox.Size = new Size(180, 39);
            courseNameBox.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(10, 230);
            label5.Name = "label5";
            label5.Size = new Size(156, 31);
            label5.TabIndex = 22;
            label5.Text = "Course Name";
            // 
            // contentBox
            // 
            contentBox.Font = new Font("Segoe UI", 14F);
            contentBox.Location = new Point(190, 282);
            contentBox.Multiline = true;
            contentBox.Name = "contentBox";
            contentBox.Size = new Size(270, 156);
            contentBox.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 282);
            label6.Name = "label6";
            label6.Size = new Size(100, 31);
            label6.TabIndex = 24;
            label6.Text = "Content";
            // 
            // closeBtn
            // 
            closeBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeBtn.Location = new Point(343, 461);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(117, 59);
            closeBtn.TabIndex = 26;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateBtn.Location = new Point(192, 461);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(125, 59);
            updateBtn.TabIndex = 25;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            // 
            // FormSchedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 532);
            Controls.Add(closeBtn);
            Controls.Add(updateBtn);
            Controls.Add(contentBox);
            Controls.Add(label6);
            Controls.Add(courseNameBox);
            Controls.Add(label5);
            Controls.Add(statusCmb);
            Controls.Add(label8);
            Controls.Add(surnameBox);
            Controls.Add(label2);
            Controls.Add(nameBox);
            Controls.Add(label1);
            Controls.Add(userBox);
            Controls.Add(UserLabel);
            Controls.Add(panel1);
            Name = "FormSchedule";
            Text = "FormSchedule";
            Load += FormSchedule_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private ComboBox positionCmb;
        private Label label4;
        private ComboBox facultyCmb;
        private Label label3;
        private TextBox surnameBox;
        private Label label2;
        private TextBox nameBox;
        private Label label1;
        private TextBox userBox;
        private Label UserLabel;
        private ComboBox statusCmb;
        private Label label8;
        private TextBox courseNameBox;
        private Label label5;
        private TextBox contentBox;
        private Label label6;
        private Button closeBtn;
        private Button updateBtn;
    }
}