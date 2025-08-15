namespace StudentTracker
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            userBtn = new Button();
            imageList1 = new ImageList(components);
            scheduleBtn = new Button();
            courseBtn = new Button();
            settingsBtn = new Button();
            facultyBtn = new Button();
            statusBtn = new Button();
            logOutBtn = new Button();
            exitBtn = new Button();
            SuspendLayout();
            // 
            // userBtn
            // 
            userBtn.BackColor = Color.FromArgb(192, 255, 255);
            userBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userBtn.ImageAlign = ContentAlignment.TopCenter;
            userBtn.ImageIndex = 8;
            userBtn.ImageList = imageList1;
            userBtn.Location = new Point(12, 12);
            userBtn.Name = "userBtn";
            userBtn.Size = new Size(150, 102);
            userBtn.TabIndex = 0;
            userBtn.Text = "USER";
            userBtn.TextAlign = ContentAlignment.BottomCenter;
            userBtn.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "books-stack-of-three.png");
            imageList1.Images.SetKeyName(1, "clipboard.png");
            imageList1.Images.SetKeyName(2, "gears.png");
            imageList1.Images.SetKeyName(3, "logout.png");
            imageList1.Images.SetKeyName(4, "man-working-on-a-laptop-from-side-view.png");
            imageList1.Images.SetKeyName(5, "network.png");
            imageList1.Images.SetKeyName(6, "power-off.png");
            imageList1.Images.SetKeyName(7, "united.png");
            imageList1.Images.SetKeyName(8, "user.png");
            imageList1.Images.SetKeyName(9, "signal.png");
            // 
            // scheduleBtn
            // 
            scheduleBtn.BackColor = Color.FromArgb(192, 192, 255);
            scheduleBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scheduleBtn.ImageAlign = ContentAlignment.TopCenter;
            scheduleBtn.ImageIndex = 1;
            scheduleBtn.ImageList = imageList1;
            scheduleBtn.Location = new Point(168, 12);
            scheduleBtn.Name = "scheduleBtn";
            scheduleBtn.Size = new Size(150, 102);
            scheduleBtn.TabIndex = 1;
            scheduleBtn.Text = "SCHEDULE";
            scheduleBtn.TextAlign = ContentAlignment.BottomCenter;
            scheduleBtn.UseVisualStyleBackColor = false;
            // 
            // courseBtn
            // 
            courseBtn.BackColor = Color.FromArgb(255, 192, 255);
            courseBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            courseBtn.ImageAlign = ContentAlignment.TopCenter;
            courseBtn.ImageIndex = 0;
            courseBtn.ImageList = imageList1;
            courseBtn.Location = new Point(324, 12);
            courseBtn.Name = "courseBtn";
            courseBtn.Size = new Size(150, 102);
            courseBtn.TabIndex = 2;
            courseBtn.Text = "COURSES";
            courseBtn.TextAlign = ContentAlignment.BottomCenter;
            courseBtn.UseVisualStyleBackColor = false;
            // 
            // settingsBtn
            // 
            settingsBtn.BackColor = Color.FromArgb(255, 255, 192);
            settingsBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            settingsBtn.ImageAlign = ContentAlignment.TopCenter;
            settingsBtn.ImageIndex = 2;
            settingsBtn.ImageList = imageList1;
            settingsBtn.Location = new Point(12, 120);
            settingsBtn.Name = "settingsBtn";
            settingsBtn.Size = new Size(150, 102);
            settingsBtn.TabIndex = 3;
            settingsBtn.Text = "SETTINGS";
            settingsBtn.TextAlign = ContentAlignment.BottomCenter;
            settingsBtn.UseVisualStyleBackColor = false;
            // 
            // facultyBtn
            // 
            facultyBtn.BackColor = Color.FromArgb(128, 255, 255);
            facultyBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            facultyBtn.ImageAlign = ContentAlignment.TopCenter;
            facultyBtn.ImageIndex = 5;
            facultyBtn.ImageList = imageList1;
            facultyBtn.Location = new Point(168, 120);
            facultyBtn.Name = "facultyBtn";
            facultyBtn.Size = new Size(150, 102);
            facultyBtn.TabIndex = 4;
            facultyBtn.Text = "FACULTY";
            facultyBtn.TextAlign = ContentAlignment.BottomCenter;
            facultyBtn.UseVisualStyleBackColor = false;
            // 
            // statusBtn
            // 
            statusBtn.BackColor = Color.FromArgb(255, 128, 255);
            statusBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            statusBtn.ImageAlign = ContentAlignment.TopCenter;
            statusBtn.ImageIndex = 9;
            statusBtn.ImageList = imageList1;
            statusBtn.Location = new Point(324, 120);
            statusBtn.Name = "statusBtn";
            statusBtn.Size = new Size(150, 102);
            statusBtn.TabIndex = 5;
            statusBtn.Text = "STATUS";
            statusBtn.TextAlign = ContentAlignment.BottomCenter;
            statusBtn.UseVisualStyleBackColor = false;
            // 
            // logOutBtn
            // 
            logOutBtn.BackColor = Color.LightSalmon;
            logOutBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logOutBtn.ImageAlign = ContentAlignment.TopCenter;
            logOutBtn.ImageIndex = 3;
            logOutBtn.ImageList = imageList1;
            logOutBtn.Location = new Point(12, 228);
            logOutBtn.Name = "logOutBtn";
            logOutBtn.Size = new Size(150, 102);
            logOutBtn.TabIndex = 6;
            logOutBtn.Text = "LOG OUT";
            logOutBtn.TextAlign = ContentAlignment.BottomCenter;
            logOutBtn.UseVisualStyleBackColor = false;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.Red;
            exitBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitBtn.ImageAlign = ContentAlignment.TopCenter;
            exitBtn.ImageIndex = 6;
            exitBtn.ImageList = imageList1;
            exitBtn.Location = new Point(324, 228);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(150, 102);
            exitBtn.TabIndex = 7;
            exitBtn.Text = "EXIT";
            exitBtn.TextAlign = ContentAlignment.BottomCenter;
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 353);
            Controls.Add(exitBtn);
            Controls.Add(logOutBtn);
            Controls.Add(statusBtn);
            Controls.Add(facultyBtn);
            Controls.Add(settingsBtn);
            Controls.Add(courseBtn);
            Controls.Add(scheduleBtn);
            Controls.Add(userBtn);
            Name = "FormMain";
            Text = "Student Portal";
            Load += FormMain_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button userBtn;
        private ImageList imageList1;
        private Button scheduleBtn;
        private Button courseBtn;
        private Button settingsBtn;
        private Button facultyBtn;
        private Button statusBtn;
        private Button logOutBtn;
        private Button exitBtn;
    }
}