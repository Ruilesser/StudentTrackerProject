namespace StudentTracker
{
    partial class FormFaculty
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
            facultyTxt = new TextBox();
            Faculty = new Label();
            updateBtn = new Button();
            closeBtn = new Button();
            SuspendLayout();
            // 
            // facultyTxt
            // 
            facultyTxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            facultyTxt.Location = new Point(129, 66);
            facultyTxt.Name = "facultyTxt";
            facultyTxt.Size = new Size(198, 38);
            facultyTxt.TabIndex = 0;
            // 
            // Faculty
            // 
            Faculty.AutoSize = true;
            Faculty.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Faculty.Location = new Point(22, 66);
            Faculty.Name = "Faculty";
            Faculty.Size = new Size(90, 31);
            Faculty.TabIndex = 0;
            Faculty.Text = "Faculty";
            // 
            // updateBtn
            // 
            updateBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateBtn.Location = new Point(22, 153);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(147, 58);
            updateBtn.TabIndex = 1;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            // 
            // closeBtn
            // 
            closeBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeBtn.Location = new Point(211, 153);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(147, 58);
            closeBtn.TabIndex = 2;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // FormFaculty
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 230);
            Controls.Add(closeBtn);
            Controls.Add(updateBtn);
            Controls.Add(Faculty);
            Controls.Add(facultyTxt);
            Name = "FormFaculty";
            Text = "Faculty";
            Load += FormFaculty_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox facultyTxt;
        private Label Faculty;
        private Button updateBtn;
        private Button closeBtn;
    }
}