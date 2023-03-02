namespace SkillCourse
{
    partial class MainForm
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
            this.panelNavbar = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.newButton_EditProfile = new System.Windows.Forms.Label();
            this.newButton_not_authorized2 = new System.Windows.Forms.Label();
            this.newButton_not_authorized = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.newButton_Teacher = new System.Windows.Forms.Label();
            this.newButton_Courses = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newButton1 = new yt_DesignUI.NewButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelNavbar.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNavbar
            // 
            this.panelNavbar.Controls.Add(this.groupBox2);
            this.panelNavbar.Controls.Add(this.groupBox1);
            this.panelNavbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavbar.Location = new System.Drawing.Point(0, 0);
            this.panelNavbar.Name = "panelNavbar";
            this.panelNavbar.Size = new System.Drawing.Size(250, 673);
            this.panelNavbar.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.newButton_EditProfile);
            this.groupBox2.Controls.Add(this.newButton_not_authorized2);
            this.groupBox2.Controls.Add(this.newButton_not_authorized);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.newButton_Teacher);
            this.groupBox2.Controls.Add(this.newButton_Courses);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 510);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // newButton_EditProfile
            // 
            this.newButton_EditProfile.AutoSize = true;
            this.newButton_EditProfile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newButton_EditProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(173)))), ((int)(((byte)(212)))));
            this.newButton_EditProfile.Location = new System.Drawing.Point(37, 303);
            this.newButton_EditProfile.Name = "newButton_EditProfile";
            this.newButton_EditProfile.Size = new System.Drawing.Size(108, 28);
            this.newButton_EditProfile.TabIndex = 7;
            this.newButton_EditProfile.Text = "Edit profile";
            this.newButton_EditProfile.Click += new System.EventHandler(this.newButton_EditProfile_Click);
            // 
            // newButton_not_authorized2
            // 
            this.newButton_not_authorized2.AutoSize = true;
            this.newButton_not_authorized2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newButton_not_authorized2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(173)))), ((int)(((byte)(212)))));
            this.newButton_not_authorized2.Location = new System.Drawing.Point(38, 241);
            this.newButton_not_authorized2.Name = "newButton_not_authorized2";
            this.newButton_not_authorized2.Size = new System.Drawing.Size(141, 28);
            this.newButton_not_authorized2.TabIndex = 6;
            this.newButton_not_authorized2.Text = "not authorized";
            // 
            // newButton_not_authorized
            // 
            this.newButton_not_authorized.AutoSize = true;
            this.newButton_not_authorized.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newButton_not_authorized.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(173)))), ((int)(((byte)(212)))));
            this.newButton_not_authorized.Location = new System.Drawing.Point(38, 179);
            this.newButton_not_authorized.Name = "newButton_not_authorized";
            this.newButton_not_authorized.Size = new System.Drawing.Size(141, 28);
            this.newButton_not_authorized.TabIndex = 5;
            this.newButton_not_authorized.Text = "not authorized";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(173)))), ((int)(((byte)(212)))));
            this.label4.Location = new System.Drawing.Point(37, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "not authorized";
            // 
            // newButton_Teacher
            // 
            this.newButton_Teacher.AutoSize = true;
            this.newButton_Teacher.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newButton_Teacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(173)))), ((int)(((byte)(212)))));
            this.newButton_Teacher.Location = new System.Drawing.Point(38, 117);
            this.newButton_Teacher.Name = "newButton_Teacher";
            this.newButton_Teacher.Size = new System.Drawing.Size(85, 28);
            this.newButton_Teacher.TabIndex = 2;
            this.newButton_Teacher.Text = "Teachers";
            this.newButton_Teacher.Click += new System.EventHandler(this.newButton_Teacher_Click);
            // 
            // newButton_Courses
            // 
            this.newButton_Courses.AutoSize = true;
            this.newButton_Courses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newButton_Courses.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.newButton_Courses.Location = new System.Drawing.Point(38, 55);
            this.newButton_Courses.Name = "newButton_Courses";
            this.newButton_Courses.Size = new System.Drawing.Size(80, 28);
            this.newButton_Courses.TabIndex = 1;
            this.newButton_Courses.Text = "Courses";
            this.newButton_Courses.Click += new System.EventHandler(this.newButton_Courses_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.newButton1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 163);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(15, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "not authorized";
            // 
            // newButton1
            // 
            this.newButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.newButton1.BackColorAdditional = System.Drawing.Color.Gray;
            this.newButton1.BackColorGradientEnabled = false;
            this.newButton1.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.newButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.newButton1.BorderColorEnabled = false;
            this.newButton1.BorderColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.newButton1.BorderColorOnHoverEnabled = false;
            this.newButton1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newButton1.ForeColor = System.Drawing.Color.White;
            this.newButton1.Location = new System.Drawing.Point(15, 88);
            this.newButton1.Name = "newButton1";
            this.newButton1.RippleColor = System.Drawing.Color.Black;
            this.newButton1.Rounding = 70;
            this.newButton1.RoundingEnable = true;
            this.newButton1.Size = new System.Drawing.Size(125, 38);
            this.newButton1.TabIndex = 1;
            this.newButton1.Text = "LogIn / RegIn";
            this.newButton1.TextHover = null;
            this.newButton1.UseDownPressEffectOnClick = false;
            this.newButton1.UseRippleEffect = true;
            this.newButton1.UseVisualStyleBackColor = false;
            this.newButton1.UseZoomEffectOnHover = false;
            this.newButton1.Click += new System.EventHandler(this.newButton1_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(250, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1012, 673);
            this.panel2.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelNavbar);
            this.MinimumSize = new System.Drawing.Size(700, 600);
            this.Name = "MainForm";
            this.Text = "SkillCourse";
            this.panelNavbar.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelNavbar;
        private yt_DesignUI.NewButton newButton1;
        private Label label1;
        private Panel panel2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label newButton_EditProfile;
        private Label newButton_not_authorized2;
        private Label newButton_not_authorized;
        private Label label4;
        private Label newButton_Teacher;
        private Label newButton_Courses;
    }
}