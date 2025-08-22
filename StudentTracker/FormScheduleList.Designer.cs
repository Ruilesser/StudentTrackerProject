namespace StudentTracker
{
    partial class FormScheduleList
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
            panel3 = new Panel();
            searchBtn = new Button();
            clearBtn = new Button();
            statusCmb = new ComboBox();
            label8 = new Label();
            groupBox1 = new GroupBox();
            endBtn = new RadioButton();
            startBtn = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            startDp = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            adminPnl = new Panel();
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
            highlightBtn = new Button();
            closeBtn = new Button();
            deleteBtn = new Button();
            updateBtn = new Button();
            addBtn = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            adminPnl.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(adminPnl);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1016, 293);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(searchBtn);
            panel3.Controls.Add(clearBtn);
            panel3.Controls.Add(statusCmb);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(groupBox1);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(startDp);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(404, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(612, 293);
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint;
            // 
            // searchBtn
            // 
            searchBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchBtn.Location = new Point(350, 174);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(122, 59);
            searchBtn.TabIndex = 3;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            // 
            // clearBtn
            // 
            clearBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearBtn.Location = new Point(478, 174);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(122, 59);
            clearBtn.TabIndex = 4;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            // 
            // statusCmb
            // 
            statusCmb.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusCmb.FormattingEnabled = true;
            statusCmb.Location = new Point(142, 185);
            statusCmb.Name = "statusCmb";
            statusCmb.Size = new Size(180, 39);
            statusCmb.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(38, 188);
            label8.Name = "label8";
            label8.Size = new Size(80, 31);
            label8.TabIndex = 18;
            label8.Text = "Status";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(endBtn);
            groupBox1.Controls.Add(startBtn);
            groupBox1.Location = new Point(415, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(185, 115);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            // 
            // endBtn
            // 
            endBtn.AutoSize = true;
            endBtn.Location = new Point(6, 84);
            endBtn.Name = "endBtn";
            endBtn.Size = new Size(91, 24);
            endBtn.TabIndex = 1;
            endBtn.TabStop = true;
            endBtn.Text = "End Date";
            endBtn.UseVisualStyleBackColor = true;
            // 
            // startBtn
            // 
            startBtn.AutoSize = true;
            startBtn.Location = new Point(6, 26);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(97, 24);
            startBtn.TabIndex = 0;
            startBtn.TabStop = true;
            startBtn.Text = "Start Date";
            startBtn.UseVisualStyleBackColor = true;
            startBtn.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(142, 130);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 1;
            // 
            // startDp
            // 
            startDp.Location = new Point(142, 75);
            startDp.Name = "startDp";
            startDp.Size = new Size(250, 27);
            startDp.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(38, 130);
            label7.Name = "label7";
            label7.Size = new Size(54, 31);
            label7.TabIndex = 13;
            label7.Text = "End";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(38, 71);
            label6.Name = "label6";
            label6.Size = new Size(66, 31);
            label6.TabIndex = 12;
            label6.Text = "Start";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(38, 21);
            label5.Name = "label5";
            label5.Size = new Size(190, 31);
            label5.TabIndex = 11;
            label5.Text = "Course Schedule";
            // 
            // adminPnl
            // 
            adminPnl.Controls.Add(positionCmb);
            adminPnl.Controls.Add(label4);
            adminPnl.Controls.Add(facultyCmb);
            adminPnl.Controls.Add(label3);
            adminPnl.Controls.Add(surnameBox);
            adminPnl.Controls.Add(label2);
            adminPnl.Controls.Add(nameBox);
            adminPnl.Controls.Add(label1);
            adminPnl.Controls.Add(userBox);
            adminPnl.Controls.Add(UserLabel);
            adminPnl.Dock = DockStyle.Left;
            adminPnl.Location = new Point(0, 0);
            adminPnl.Name = "adminPnl";
            adminPnl.Size = new Size(404, 293);
            adminPnl.TabIndex = 0;
            // 
            // positionCmb
            // 
            positionCmb.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            positionCmb.FormattingEnabled = true;
            positionCmb.Location = new Point(202, 238);
            positionCmb.Name = "positionCmb";
            positionCmb.Size = new Size(180, 39);
            positionCmb.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 241);
            label4.Name = "label4";
            label4.Size = new Size(102, 31);
            label4.TabIndex = 16;
            label4.Text = "Position";
            // 
            // facultyCmb
            // 
            facultyCmb.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            facultyCmb.FormattingEnabled = true;
            facultyCmb.Location = new Point(202, 185);
            facultyCmb.Name = "facultyCmb";
            facultyCmb.Size = new Size(180, 39);
            facultyCmb.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 188);
            label3.Name = "label3";
            label3.Size = new Size(90, 31);
            label3.TabIndex = 15;
            label3.Text = "Faculty";
            // 
            // surnameBox
            // 
            surnameBox.Font = new Font("Segoe UI", 14F);
            surnameBox.Location = new Point(202, 130);
            surnameBox.Name = "surnameBox";
            surnameBox.Size = new Size(180, 39);
            surnameBox.TabIndex = 2;
            surnameBox.TextChanged += surnameBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 130);
            label2.Name = "label2";
            label2.Size = new Size(109, 31);
            label2.TabIndex = 12;
            label2.Text = "Surname";
            // 
            // nameBox
            // 
            nameBox.Font = new Font("Segoe UI", 14F);
            nameBox.Location = new Point(202, 71);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(180, 39);
            nameBox.TabIndex = 1;
            nameBox.TextChanged += nameBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 71);
            label1.Name = "label1";
            label1.Size = new Size(77, 31);
            label1.TabIndex = 11;
            label1.Text = "Name";
            // 
            // userBox
            // 
            userBox.Font = new Font("Segoe UI", 14F);
            userBox.Location = new Point(202, 18);
            userBox.Name = "userBox";
            userBox.Size = new Size(180, 39);
            userBox.TabIndex = 0;
            userBox.KeyPress += userBox_KeyPress;
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserLabel.Location = new Point(22, 21);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(156, 31);
            UserLabel.TabIndex = 10;
            UserLabel.Text = "User Number";
            // 
            // panel2
            // 
            panel2.Controls.Add(highlightBtn);
            panel2.Controls.Add(closeBtn);
            panel2.Controls.Add(deleteBtn);
            panel2.Controls.Add(updateBtn);
            panel2.Controls.Add(addBtn);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 537);
            panel2.Name = "panel2";
            panel2.Size = new Size(1016, 107);
            panel2.TabIndex = 1;
            // 
            // highlightBtn
            // 
            highlightBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            highlightBtn.Location = new Point(54, 29);
            highlightBtn.Name = "highlightBtn";
            highlightBtn.Size = new Size(172, 59);
            highlightBtn.TabIndex = 0;
            highlightBtn.Text = "Highlight";
            highlightBtn.UseVisualStyleBackColor = true;
            // 
            // closeBtn
            // 
            closeBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeBtn.Location = new Point(766, 29);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(172, 59);
            closeBtn.TabIndex = 4;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteBtn.Location = new Point(588, 29);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(172, 59);
            deleteBtn.TabIndex = 3;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            // 
            // updateBtn
            // 
            updateBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateBtn.Location = new Point(410, 29);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(172, 59);
            updateBtn.TabIndex = 2;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            addBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addBtn.Location = new Point(232, 29);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(172, 59);
            addBtn.TabIndex = 1;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 293);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1016, 244);
            dataGridView1.TabIndex = 2;
            // 
            // FormScheduleList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 644);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormScheduleList";
            Text = "Schedule List";
            Load += FormScheduleList_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            adminPnl.ResumeLayout(false);
            adminPnl.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Button closeBtn;
        private Button deleteBtn;
        private Button updateBtn;
        private Button addBtn;
        private Button highlightBtn;
        private Panel panel3;
        private Panel adminPnl;
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
        private DateTimePicker dateTimePicker1;
        private DateTimePicker startDp;
        private Label label7;
        private Label label6;
        private Label label5;
        private GroupBox groupBox1;
        private RadioButton startBtn;
        private RadioButton endBtn;
        private ComboBox statusCmb;
        private Label label8;
        private Button searchBtn;
        private Button clearBtn;
    }
}