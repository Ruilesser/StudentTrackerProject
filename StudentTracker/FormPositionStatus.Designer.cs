namespace StudentTracker
{
    partial class FormPositionStatus
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
            label1 = new Label();
            positionText = new TextBox();
            label2 = new Label();
            facultyCmb = new ComboBox();
            closeBtn = new Button();
            updateBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(56, 111);
            label1.Name = "label1";
            label1.Size = new Size(102, 31);
            label1.TabIndex = 1;
            label1.Text = "Position";
            // 
            // positionText
            // 
            positionText.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            positionText.Location = new Point(228, 108);
            positionText.Name = "positionText";
            positionText.Size = new Size(215, 38);
            positionText.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(56, 43);
            label2.Name = "label2";
            label2.Size = new Size(90, 31);
            label2.TabIndex = 1;
            label2.Text = "Faculty";
            // 
            // facultyCmb
            // 
            facultyCmb.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            facultyCmb.FormattingEnabled = true;
            facultyCmb.Location = new Point(228, 40);
            facultyCmb.Name = "facultyCmb";
            facultyCmb.Size = new Size(215, 39);
            facultyCmb.TabIndex = 0;
            // 
            // closeBtn
            // 
            closeBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeBtn.Location = new Point(228, 181);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(147, 58);
            closeBtn.TabIndex = 3;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateBtn.Location = new Point(56, 181);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(147, 58);
            updateBtn.TabIndex = 2;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            // 
            // FormStatus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 285);
            Controls.Add(closeBtn);
            Controls.Add(updateBtn);
            Controls.Add(facultyCmb);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(positionText);
            Name = "FormStatus";
            Text = "Status";
            Load += FormStatus_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox positionText;
        private Label label2;
        private ComboBox facultyCmb;
        private Button closeBtn;
        private Button updateBtn;
    }
}