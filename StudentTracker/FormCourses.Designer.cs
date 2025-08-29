namespace StudentTracker
{
    partial class FormCourses
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
            courseBox = new TextBox();
            label5 = new Label();
            yearBox = new TextBox();
            label6 = new Label();
            comboBox1 = new ComboBox();
            label7 = new Label();
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
            panel1.Location = new Point(416, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(351, 486);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 208);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(351, 278);
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
            panel2.Size = new Size(351, 208);
            panel2.TabIndex = 0;
            // 
            // positionCmb
            // 
            positionCmb.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            positionCmb.FormattingEnabled = true;
            positionCmb.Location = new Point(15, 143);
            positionCmb.Name = "positionCmb";
            positionCmb.Size = new Size(210, 39);
            positionCmb.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 99);
            label4.Name = "label4";
            label4.Size = new Size(102, 31);
            label4.TabIndex = 24;
            label4.Text = "Position";
            // 
            // facultyCmb
            // 
            facultyCmb.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            facultyCmb.FormattingEnabled = true;
            facultyCmb.Location = new Point(15, 49);
            facultyCmb.Name = "facultyCmb";
            facultyCmb.Size = new Size(210, 39);
            facultyCmb.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 9);
            label3.Name = "label3";
            label3.Size = new Size(90, 31);
            label3.TabIndex = 23;
            label3.Text = "Faculty";
            // 
            // surnameBox
            // 
            surnameBox.Font = new Font("Segoe UI", 14F);
            surnameBox.Location = new Point(192, 118);
            surnameBox.Name = "surnameBox";
            surnameBox.ReadOnly = true;
            surnameBox.Size = new Size(180, 39);
            surnameBox.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 121);
            label2.Name = "label2";
            label2.Size = new Size(109, 31);
            label2.TabIndex = 18;
            label2.Text = "Surname";
            // 
            // nameBox
            // 
            nameBox.Font = new Font("Segoe UI", 14F);
            nameBox.Location = new Point(192, 59);
            nameBox.Name = "nameBox";
            nameBox.ReadOnly = true;
            nameBox.Size = new Size(180, 39);
            nameBox.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 62);
            label1.Name = "label1";
            label1.Size = new Size(77, 31);
            label1.TabIndex = 17;
            label1.Text = "Name";
            // 
            // userBox
            // 
            userBox.Font = new Font("Segoe UI", 14F);
            userBox.Location = new Point(192, 6);
            userBox.Name = "userBox";
            userBox.ReadOnly = true;
            userBox.Size = new Size(180, 39);
            userBox.TabIndex = 13;
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserLabel.Location = new Point(12, 9);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(156, 31);
            UserLabel.TabIndex = 16;
            UserLabel.Text = "User Number";
            // 
            // courseBox
            // 
            courseBox.Font = new Font("Segoe UI", 14F);
            courseBox.Location = new Point(192, 179);
            courseBox.Name = "courseBox";
            courseBox.Size = new Size(180, 39);
            courseBox.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 179);
            label5.Name = "label5";
            label5.Size = new Size(87, 31);
            label5.TabIndex = 20;
            label5.Text = "Course";
            // 
            // yearBox
            // 
            yearBox.Font = new Font("Segoe UI", 14F);
            yearBox.Location = new Point(192, 235);
            yearBox.Name = "yearBox";
            yearBox.Size = new Size(180, 39);
            yearBox.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 235);
            label6.Name = "label6";
            label6.Size = new Size(59, 31);
            label6.TabIndex = 22;
            label6.Text = "Year";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(192, 295);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(180, 39);
            comboBox1.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 298);
            label7.Name = "label7";
            label7.Size = new Size(87, 31);
            label7.TabIndex = 25;
            label7.Text = "Month";
            // 
            // closeBtn
            // 
            closeBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeBtn.Location = new Point(255, 361);
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
            updateBtn.Location = new Point(104, 361);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(125, 59);
            updateBtn.TabIndex = 3;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            // 
            // FormCourses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 486);
            Controls.Add(closeBtn);
            Controls.Add(updateBtn);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(yearBox);
            Controls.Add(label6);
            Controls.Add(courseBox);
            Controls.Add(label5);
            Controls.Add(surnameBox);
            Controls.Add(label2);
            Controls.Add(nameBox);
            Controls.Add(label1);
            Controls.Add(userBox);
            Controls.Add(UserLabel);
            Controls.Add(panel1);
            Name = "FormCourses";
            Text = "FormCourses";
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
        private TextBox surnameBox;
        private Label label2;
        private TextBox nameBox;
        private Label label1;
        private TextBox userBox;
        private Label UserLabel;
        private ComboBox positionCmb;
        private Label label4;
        private ComboBox facultyCmb;
        private Label label3;
        private TextBox courseBox;
        private Label label5;
        private TextBox yearBox;
        private Label label6;
        private ComboBox comboBox1;
        private Label label7;
        private Button closeBtn;
        private Button updateBtn;
    }
}