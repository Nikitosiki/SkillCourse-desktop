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
            panelNavbar = new Panel();
            groupBox2 = new GroupBox();
            newButton_Certificate = new Label();
            newButton_EditProfile = new Label();
            newButton_AddCourses = new Label();
            newButton_Teacher = new Label();
            newButton_Courses = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            newButton1 = new yt_DesignUI.NewButton();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panelNavbar.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelNavbar
            // 
            panelNavbar.Controls.Add(groupBox2);
            panelNavbar.Controls.Add(groupBox1);
            panelNavbar.Dock = DockStyle.Fill;
            panelNavbar.Location = new Point(3, 3);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(244, 667);
            panelNavbar.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(newButton_Certificate);
            groupBox2.Controls.Add(newButton_EditProfile);
            groupBox2.Controls.Add(newButton_AddCourses);
            groupBox2.Controls.Add(newButton_Teacher);
            groupBox2.Controls.Add(newButton_Courses);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 163);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(244, 504);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // newButton_Certificate
            // 
            newButton_Certificate.AutoSize = true;
            newButton_Certificate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            newButton_Certificate.ForeColor = Color.FromArgb(142, 173, 212);
            newButton_Certificate.Location = new Point(38, 241);
            newButton_Certificate.Name = "newButton_Certificate";
            newButton_Certificate.Size = new Size(108, 28);
            newButton_Certificate.TabIndex = 7;
            newButton_Certificate.Text = "Certificates";
            newButton_Certificate.Click += newButton_Certificate_Click;
            // 
            // newButton_EditProfile
            // 
            newButton_EditProfile.AutoSize = true;
            newButton_EditProfile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            newButton_EditProfile.ForeColor = Color.FromArgb(142, 173, 212);
            newButton_EditProfile.Location = new Point(38, 303);
            newButton_EditProfile.Name = "newButton_EditProfile";
            newButton_EditProfile.Size = new Size(108, 28);
            newButton_EditProfile.TabIndex = 6;
            newButton_EditProfile.Text = "Edit profile";
            newButton_EditProfile.Click += newButton_EditProfile_Click;
            // 
            // newButton_AddCourses
            // 
            newButton_AddCourses.AutoSize = true;
            newButton_AddCourses.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            newButton_AddCourses.ForeColor = Color.FromArgb(142, 173, 212);
            newButton_AddCourses.Location = new Point(38, 179);
            newButton_AddCourses.Name = "newButton_AddCourses";
            newButton_AddCourses.Size = new Size(122, 28);
            newButton_AddCourses.TabIndex = 5;
            newButton_AddCourses.Text = "Add Courses";
            newButton_AddCourses.Click += newButton_AddCourses_Click;
            // 
            // newButton_Teacher
            // 
            newButton_Teacher.AutoSize = true;
            newButton_Teacher.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            newButton_Teacher.ForeColor = Color.FromArgb(142, 173, 212);
            newButton_Teacher.Location = new Point(38, 117);
            newButton_Teacher.Name = "newButton_Teacher";
            newButton_Teacher.Size = new Size(85, 28);
            newButton_Teacher.TabIndex = 2;
            newButton_Teacher.Text = "Teachers";
            newButton_Teacher.Click += newButton_Teacher_Click;
            // 
            // newButton_Courses
            // 
            newButton_Courses.AutoSize = true;
            newButton_Courses.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            newButton_Courses.ForeColor = SystemColors.ControlLight;
            newButton_Courses.Location = new Point(38, 55);
            newButton_Courses.Name = "newButton_Courses";
            newButton_Courses.Size = new Size(80, 28);
            newButton_Courses.TabIndex = 1;
            newButton_Courses.Text = "Courses";
            newButton_Courses.Click += newButton_Courses_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(newButton1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(244, 163);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(15, 45);
            label1.Name = "label1";
            label1.Size = new Size(163, 31);
            label1.TabIndex = 0;
            label1.Text = "not authorized";
            // 
            // newButton1
            // 
            newButton1.BackColor = Color.FromArgb(70, 82, 89);
            newButton1.BackColorAdditional = Color.Gray;
            newButton1.BackColorGradientEnabled = false;
            newButton1.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            newButton1.BorderColor = Color.FromArgb(70, 82, 89);
            newButton1.BorderColorEnabled = false;
            newButton1.BorderColorOnHover = Color.FromArgb(70, 82, 89);
            newButton1.BorderColorOnHoverEnabled = false;
            newButton1.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            newButton1.ForeColor = Color.White;
            newButton1.Location = new Point(15, 88);
            newButton1.Name = "newButton1";
            newButton1.RippleColor = Color.Black;
            newButton1.Rounding = 70;
            newButton1.RoundingEnable = true;
            newButton1.Size = new Size(125, 38);
            newButton1.TabIndex = 1;
            newButton1.Text = "LogIn / RegIn";
            newButton1.TextHover = null;
            newButton1.UseDownPressEffectOnClick = false;
            newButton1.UseMainGradientEffect = false;
            newButton1.UseRippleEffect = true;
            newButton1.UseVisualStyleBackColor = false;
            newButton1.UseZoomEffectOnHover = false;
            newButton1.Click += newButton1_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(253, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1006, 667);
            panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 1012F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panelNavbar, 1, 0);
            tableLayoutPanel1.Controls.Add(panel2, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1262, 673);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 49, 60);
            ClientSize = new Size(1262, 673);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(1280, 600);
            Name = "MainForm";
            Text = "SkillCourse";
            panelNavbar.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNavbar;
        private yt_DesignUI.NewButton newButton1;
        private Label label1;
        private Panel panel2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label newButton_EditProfile;
        private Label newButton_AddCourses;
        private Label newButton_Teacher;
        private Label newButton_Courses;
        private TableLayoutPanel tableLayoutPanel1;
        private Label newButton_Certificate;
    }
}