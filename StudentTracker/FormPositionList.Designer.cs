namespace StudentTracker
{
    partial class FormPositionList
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
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            closeBtn = new Button();
            updateBtn = new Button();
            deleteBtn = new Button();
            addBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(734, 346);
            dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(closeBtn);
            panel1.Controls.Add(updateBtn);
            panel1.Controls.Add(deleteBtn);
            panel1.Controls.Add(addBtn);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 352);
            panel1.Name = "panel1";
            panel1.Size = new Size(734, 98);
            panel1.TabIndex = 1;
            // 
            // closeBtn
            // 
            closeBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeBtn.Location = new Point(546, 27);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(172, 59);
            closeBtn.TabIndex = 7;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateBtn.Location = new Point(190, 27);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(172, 59);
            updateBtn.TabIndex = 5;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += this.updateBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteBtn.Location = new Point(368, 27);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(172, 59);
            deleteBtn.TabIndex = 6;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addBtn.Location = new Point(12, 27);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(172, 59);
            addBtn.TabIndex = 4;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // FormPositionList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 450);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "FormPositionList";
            Text = "Position List";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Button closeBtn;
        private Button updateBtn;
        private Button deleteBtn;
        private Button addBtn;
    }
}