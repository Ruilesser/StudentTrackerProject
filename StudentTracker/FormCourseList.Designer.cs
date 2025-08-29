namespace StudentTracker
{
    partial class FormCourseList
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
            searchBtn = new Button();
            clearBtn = new Button();
            groupBox1 = new GroupBox();
            lessThreeBtn = new RadioButton();
            equalThreeButton = new RadioButton();
            moreThreeBtn = new RadioButton();
            comboBox1 = new ComboBox();
            label7 = new Label();
            yearBox = new TextBox();
            label6 = new Label();
            courseBox = new TextBox();
            label5 = new Label();
            adminPanel = new Panel();
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
            panel2 = new Panel();
            closeBtn = new Button();
            deleteBtn = new Button();
            updateBtn = new Button();
            addBtn = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            adminPanel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(searchBtn);
            panel1.Controls.Add(clearBtn);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(yearBox);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(courseBox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(adminPanel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(925, 283);
            panel1.TabIndex = 0;
            // 
            // searchBtn
            // 
            searchBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchBtn.Location = new Point(655, 188);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(122, 59);
            searchBtn.TabIndex = 5;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            // 
            // clearBtn
            // 
            clearBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearBtn.Location = new Point(783, 188);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(122, 59);
            clearBtn.TabIndex = 6;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lessThreeBtn);
            groupBox1.Controls.Add(equalThreeButton);
            groupBox1.Controls.Add(moreThreeBtn);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(742, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(163, 150);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            groupBox1.Text = "Credits";
            // 
            // lessThreeBtn
            // 
            lessThreeBtn.AutoSize = true;
            lessThreeBtn.Location = new Point(6, 109);
            lessThreeBtn.Name = "lessThreeBtn";
            lessThreeBtn.Size = new Size(64, 32);
            lessThreeBtn.TabIndex = 2;
            lessThreeBtn.TabStop = true;
            lessThreeBtn.Text = "< 3";
            lessThreeBtn.UseVisualStyleBackColor = true;
            // 
            // equalThreeButton
            // 
            equalThreeButton.AutoSize = true;
            equalThreeButton.Location = new Point(8, 71);
            equalThreeButton.Name = "equalThreeButton";
            equalThreeButton.Size = new Size(64, 32);
            equalThreeButton.TabIndex = 1;
            equalThreeButton.TabStop = true;
            equalThreeButton.Text = "= 3";
            equalThreeButton.UseVisualStyleBackColor = true;
            equalThreeButton.CheckedChanged += equalThreeButton_CheckedChanged;
            // 
            // moreThreeBtn
            // 
            moreThreeBtn.AutoSize = true;
            moreThreeBtn.Location = new Point(8, 33);
            moreThreeBtn.Name = "moreThreeBtn";
            moreThreeBtn.Size = new Size(64, 32);
            moreThreeBtn.TabIndex = 0;
            moreThreeBtn.TabStop = true;
            moreThreeBtn.Text = "> 3";
            moreThreeBtn.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(529, 128);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(180, 39);
            comboBox1.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(417, 131);
            label7.Name = "label7";
            label7.Size = new Size(87, 31);
            label7.TabIndex = 31;
            label7.Text = "Month";
            // 
            // yearBox
            // 
            yearBox.Font = new Font("Segoe UI", 14F);
            yearBox.Location = new Point(529, 68);
            yearBox.Name = "yearBox";
            yearBox.Size = new Size(180, 39);
            yearBox.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(417, 68);
            label6.Name = "label6";
            label6.Size = new Size(59, 31);
            label6.TabIndex = 30;
            label6.Text = "Year";
            // 
            // courseBox
            // 
            courseBox.Font = new Font("Segoe UI", 14F);
            courseBox.Location = new Point(529, 12);
            courseBox.Name = "courseBox";
            courseBox.Size = new Size(180, 39);
            courseBox.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(417, 12);
            label5.Name = "label5";
            label5.Size = new Size(87, 31);
            label5.TabIndex = 29;
            label5.Text = "Course";
            // 
            // adminPanel
            // 
            adminPanel.Controls.Add(positionCmb);
            adminPanel.Controls.Add(label4);
            adminPanel.Controls.Add(facultyCmb);
            adminPanel.Controls.Add(label3);
            adminPanel.Controls.Add(surnameBox);
            adminPanel.Controls.Add(label2);
            adminPanel.Controls.Add(nameBox);
            adminPanel.Controls.Add(label1);
            adminPanel.Controls.Add(userBox);
            adminPanel.Controls.Add(UserLabel);
            adminPanel.Dock = DockStyle.Left;
            adminPanel.Location = new Point(0, 0);
            adminPanel.Name = "adminPanel";
            adminPanel.Size = new Size(397, 283);
            adminPanel.TabIndex = 1;
            // 
            // positionCmb
            // 
            positionCmb.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            positionCmb.FormattingEnabled = true;
            positionCmb.Location = new Point(192, 226);
            positionCmb.Name = "positionCmb";
            positionCmb.Size = new Size(180, 39);
            positionCmb.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 229);
            label4.Name = "label4";
            label4.Size = new Size(102, 31);
            label4.TabIndex = 36;
            label4.Text = "Position";
            // 
            // facultyCmb
            // 
            facultyCmb.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            facultyCmb.FormattingEnabled = true;
            facultyCmb.Location = new Point(192, 173);
            facultyCmb.Name = "facultyCmb";
            facultyCmb.Size = new Size(180, 39);
            facultyCmb.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 176);
            label3.Name = "label3";
            label3.Size = new Size(90, 31);
            label3.TabIndex = 35;
            label3.Text = "Faculty";
            // 
            // surnameBox
            // 
            surnameBox.Font = new Font("Segoe UI", 14F);
            surnameBox.Location = new Point(192, 118);
            surnameBox.Name = "surnameBox";
            surnameBox.Size = new Size(180, 39);
            surnameBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 118);
            label2.Name = "label2";
            label2.Size = new Size(109, 31);
            label2.TabIndex = 34;
            label2.Text = "Surname";
            // 
            // nameBox
            // 
            nameBox.Font = new Font("Segoe UI", 14F);
            nameBox.Location = new Point(192, 59);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(180, 39);
            nameBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 59);
            label1.Name = "label1";
            label1.Size = new Size(77, 31);
            label1.TabIndex = 33;
            label1.Text = "Name";
            // 
            // userBox
            // 
            userBox.Font = new Font("Segoe UI", 14F);
            userBox.Location = new Point(192, 6);
            userBox.Name = "userBox";
            userBox.Size = new Size(180, 39);
            userBox.TabIndex = 0;
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserLabel.Location = new Point(12, 9);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(156, 31);
            UserLabel.TabIndex = 32;
            UserLabel.Text = "User Number";
            // 
            // panel2
            // 
            panel2.Controls.Add(closeBtn);
            panel2.Controls.Add(deleteBtn);
            panel2.Controls.Add(updateBtn);
            panel2.Controls.Add(addBtn);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 517);
            panel2.Name = "panel2";
            panel2.Size = new Size(925, 119);
            panel2.TabIndex = 1;
            // 
            // closeBtn
            // 
            closeBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeBtn.Location = new Point(632, 37);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(172, 59);
            closeBtn.TabIndex = 11;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteBtn.Location = new Point(454, 37);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(172, 59);
            deleteBtn.TabIndex = 10;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            // 
            // updateBtn
            // 
            updateBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateBtn.Location = new Point(276, 37);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(172, 59);
            updateBtn.TabIndex = 9;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addBtn.Location = new Point(98, 37);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(172, 59);
            addBtn.TabIndex = 8;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 283);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(925, 234);
            dataGridView1.TabIndex = 2;
            // 
            // FormCourseList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 636);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormCourseList";
            Text = "FormCourseList";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            adminPanel.ResumeLayout(false);
            adminPanel.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Panel adminPanel;
        private Button closeBtn;
        private Button deleteBtn;
        private Button updateBtn;
        private Button addBtn;
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
        private GroupBox groupBox1;
        private RadioButton moreThreeBtn;
        private ComboBox comboBox1;
        private Label label7;
        private TextBox yearBox;
        private Label label6;
        private TextBox courseBox;
        private Label label5;
        private RadioButton equalThreeButton;
        private RadioButton lessThreeBtn;
        private Button searchBtn;
        private Button clearBtn;
    }
}