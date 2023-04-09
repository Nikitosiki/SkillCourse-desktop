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
            panelNavbarBut = new Panel();
            panel1 = new Panel();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            newButton1 = new yt_DesignUI.NewButton();
            panelMain = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panelNavbar.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
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
            groupBox2.Controls.Add(panelNavbarBut);
            groupBox2.Controls.Add(panel1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 163);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(244, 504);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // panelNavbarBut
            // 
            panelNavbarBut.Dock = DockStyle.Fill;
            panelNavbarBut.Location = new Point(3, 23);
            panelNavbarBut.Name = "panelNavbarBut";
            panelNavbarBut.Size = new Size(238, 441);
            panelNavbarBut.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 464);
            panel1.Name = "panel1";
            panel1.Size = new Size(238, 37);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(42, 11);
            label2.Name = "label2";
            label2.Size = new Size(184, 20);
            label2.TabIndex = 0;
            label2.Text = "SkillCourse  Apr 9 Version";
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
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(253, 3);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1006, 667);
            panelMain.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 1012F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panelNavbar, 1, 0);
            tableLayoutPanel1.Controls.Add(panelMain, 2, 0);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNavbar;
        private yt_DesignUI.NewButton newButton1;
        private Label label1;
        private Panel panelMain;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelNavbarBut;
        private Panel panel1;
        private Label label2;
    }
}