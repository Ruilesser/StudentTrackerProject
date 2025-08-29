namespace StudentTracker
{
    partial class FormUserList
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
            clearBtn = new Button();
            searchBtn = new Button();
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
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            closeBtn = new Button();
            deleteBtn = new Button();
            updateBtn = new Button();
            addBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(clearBtn);
            panel1.Controls.Add(searchBtn);
            panel1.Controls.Add(positionCmb);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(facultyCmb);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(surnameBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(nameBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(userBox);
            panel1.Controls.Add(UserLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 169);
            panel1.TabIndex = 0;
            // 
            // clearBtn
            // 
            clearBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearBtn.Location = new Point(765, 60);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(110, 39);
            clearBtn.TabIndex = 6;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            searchBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchBtn.Location = new Point(765, 7);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(110, 39);
            searchBtn.TabIndex = 5;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // positionCmb
            // 
            positionCmb.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            positionCmb.FormattingEnabled = true;
            positionCmb.Location = new Point(532, 60);
            positionCmb.Name = "positionCmb";
            positionCmb.Size = new Size(185, 39);
            positionCmb.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(403, 66);
            label4.Name = "label4";
            label4.Size = new Size(102, 31);
            label4.TabIndex = 11;
            label4.Text = "Position";
            // 
            // facultyCmb
            // 
            facultyCmb.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            facultyCmb.FormattingEnabled = true;
            facultyCmb.Location = new Point(532, 7);
            facultyCmb.Name = "facultyCmb";
            facultyCmb.Size = new Size(185, 39);
            facultyCmb.TabIndex = 3;
            facultyCmb.SelectedIndexChanged += facultyCmb_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(403, 13);
            label3.Name = "label3";
            label3.Size = new Size(90, 31);
            label3.TabIndex = 9;
            label3.Text = "Faculty";
            // 
            // surnameBox
            // 
            surnameBox.Font = new Font("Segoe UI", 14F);
            surnameBox.Location = new Point(184, 114);
            surnameBox.Name = "surnameBox";
            surnameBox.Size = new Size(180, 39);
            surnameBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(4, 114);
            label2.Name = "label2";
            label2.Size = new Size(109, 31);
            label2.TabIndex = 6;
            label2.Text = "Surname";
            // 
            // nameBox
            // 
            nameBox.Font = new Font("Segoe UI", 14F);
            nameBox.Location = new Point(184, 65);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(180, 39);
            nameBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(4, 65);
            label1.Name = "label1";
            label1.Size = new Size(77, 31);
            label1.TabIndex = 4;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // userBox
            // 
            userBox.Font = new Font("Segoe UI", 14F);
            userBox.Location = new Point(184, 12);
            userBox.Name = "userBox";
            userBox.Size = new Size(180, 39);
            userBox.TabIndex = 0;
            userBox.KeyPress += userBox_KeyPress;
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserLabel.Location = new Point(4, 15);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(156, 31);
            UserLabel.TabIndex = 2;
            UserLabel.Text = "User Number";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 169);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(900, 281);
            dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(closeBtn);
            panel2.Controls.Add(deleteBtn);
            panel2.Controls.Add(updateBtn);
            panel2.Controls.Add(addBtn);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 362);
            panel2.Name = "panel2";
            panel2.Size = new Size(900, 88);
            panel2.TabIndex = 1;
            // 
            // closeBtn
            // 
            closeBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeBtn.Location = new Point(637, 17);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(172, 59);
            closeBtn.TabIndex = 7;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteBtn.Location = new Point(459, 17);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(172, 59);
            deleteBtn.TabIndex = 6;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            // 
            // updateBtn
            // 
            updateBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateBtn.Location = new Point(281, 17);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(172, 59);
            updateBtn.TabIndex = 5;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addBtn.Location = new Point(103, 17);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(172, 59);
            addBtn.TabIndex = 4;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // FormUserList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 450);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "FormUserList";
            Text = "FormUserList";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Button closeBtn;
        private Button deleteBtn;
        private Button updateBtn;
        private Button addBtn;
        private TextBox userBox;
        private Label UserLabel;
        private TextBox surnameBox;
        private Label label2;
        private TextBox nameBox;
        private Label label1;
        private ComboBox positionCmb;
        private Label label4;
        private ComboBox facultyCmb;
        private Label label3;
        private Button clearBtn;
        private Button searchBtn;
    }
}