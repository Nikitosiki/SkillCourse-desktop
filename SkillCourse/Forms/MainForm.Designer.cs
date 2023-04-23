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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelNavbar = new Panel();
            groupBox2 = new GroupBox();
            panelNavbarBut = new Panel();
            panel1 = new Panel();
            label2 = new Label();
            groupBox1 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            labelAuthorization = new Label();
            newButtonAuthorization = new yt_DesignUI.NewButton();
            panelMain = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panelNavbar.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
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
            panelNavbar.Size = new Size(244, 717);
            panelNavbar.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(panelNavbarBut);
            groupBox2.Controls.Add(panel1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 163);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(244, 554);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // panelNavbarBut
            // 
            panelNavbarBut.Dock = DockStyle.Fill;
            panelNavbarBut.Location = new Point(3, 23);
            panelNavbarBut.Name = "panelNavbarBut";
            panelNavbarBut.Size = new Size(238, 491);
            panelNavbarBut.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 514);
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
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(244, 163);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel2.Controls.Add(labelAuthorization, 1, 0);
            tableLayoutPanel2.Controls.Add(newButtonAuthorization, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 23);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(238, 137);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // labelAuthorization
            // 
            labelAuthorization.AutoSize = true;
            labelAuthorization.Dock = DockStyle.Fill;
            labelAuthorization.FlatStyle = FlatStyle.Flat;
            labelAuthorization.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelAuthorization.ForeColor = SystemColors.Control;
            labelAuthorization.Location = new Point(23, 0);
            labelAuthorization.Name = "labelAuthorization";
            labelAuthorization.Size = new Size(202, 72);
            labelAuthorization.TabIndex = 0;
            labelAuthorization.Text = " \r\nnot authorized\r\n";
            // 
            // newButtonAuthorization
            // 
            newButtonAuthorization.BackColor = Color.FromArgb(70, 82, 89);
            newButtonAuthorization.BackColorAdditional = Color.Gray;
            newButtonAuthorization.BackColorGradientEnabled = false;
            newButtonAuthorization.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            newButtonAuthorization.BorderColor = Color.FromArgb(70, 82, 89);
            newButtonAuthorization.BorderColorEnabled = false;
            newButtonAuthorization.BorderColorOnHover = Color.FromArgb(70, 82, 89);
            newButtonAuthorization.BorderColorOnHoverEnabled = false;
            newButtonAuthorization.Dock = DockStyle.Left;
            newButtonAuthorization.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            newButtonAuthorization.ForeColor = Color.White;
            newButtonAuthorization.Location = new Point(23, 75);
            newButtonAuthorization.Name = "newButtonAuthorization";
            newButtonAuthorization.RippleColor = Color.Black;
            newButtonAuthorization.Rounding = 70;
            newButtonAuthorization.RoundingEnable = true;
            newButtonAuthorization.Size = new Size(125, 39);
            newButtonAuthorization.TabIndex = 1;
            newButtonAuthorization.Text = "LogIn / RegIn";
            newButtonAuthorization.TextHover = null;
            newButtonAuthorization.UseDownPressEffectOnClick = false;
            newButtonAuthorization.UseMainGradientEffect = false;
            newButtonAuthorization.UseRippleEffect = true;
            newButtonAuthorization.UseVisualStyleBackColor = false;
            newButtonAuthorization.UseZoomEffectOnHover = false;
            newButtonAuthorization.Click += newButtonAuthorization_Click;
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(253, 3);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1006, 717);
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
            tableLayoutPanel1.Size = new Size(1262, 723);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 49, 60);
            ClientSize = new Size(1262, 723);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1280, 600);
            Name = "MainForm";
            Text = "SkillCourse";
            panelNavbar.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNavbar;
        private yt_DesignUI.NewButton newButtonAuthorization;
        private Panel panelMain;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelNavbarBut;
        private Panel panel1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label labelAuthorization;
    }
}