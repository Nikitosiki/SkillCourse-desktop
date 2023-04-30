namespace SkillCourse.Forms
{
    partial class CreateTask
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
            tableLayoutPanel2 = new TableLayoutPanel();
            panel3 = new Panel();
            labelCounter = new Label();
            newButton1 = new yt_DesignUI.NewButton();
            newButtonApply = new yt_DesignUI.NewButton();
            backRoundPanel1 = new PanelComponents.BackRoundPanel();
            richTextBox1 = new RichTextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            newToggleSwitch1 = new yt_DesignUI.NewToggleSwitch();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            backRoundPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 22F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 22F));
            tableLayoutPanel2.Controls.Add(panel3, 1, 2);
            tableLayoutPanel2.Controls.Add(backRoundPanel1, 1, 1);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutPanel2.Size = new Size(711, 432);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(newToggleSwitch1);
            panel3.Controls.Add(labelCounter);
            panel3.Controls.Add(newButton1);
            panel3.Controls.Add(newButtonApply);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(25, 360);
            panel3.Name = "panel3";
            panel3.Size = new Size(661, 69);
            panel3.TabIndex = 7;
            // 
            // labelCounter
            // 
            labelCounter.AutoSize = true;
            labelCounter.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelCounter.ForeColor = SystemColors.ButtonShadow;
            labelCounter.Location = new Point(23, 0);
            labelCounter.Name = "labelCounter";
            labelCounter.Size = new Size(72, 23);
            labelCounter.TabIndex = 6;
            labelCounter.Text = "0 / 2000";
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
            newButton1.Location = new Point(382, 16);
            newButton1.Name = "newButton1";
            newButton1.RippleColor = Color.Black;
            newButton1.Rounding = 70;
            newButton1.RoundingEnable = true;
            newButton1.Size = new Size(125, 39);
            newButton1.TabIndex = 3;
            newButton1.Text = "Cancel";
            newButton1.TextHover = null;
            newButton1.UseDownPressEffectOnClick = false;
            newButton1.UseMainGradientEffect = false;
            newButton1.UseRippleEffect = true;
            newButton1.UseVisualStyleBackColor = false;
            newButton1.UseZoomEffectOnHover = false;
            newButton1.Click += newButton1_Click;
            // 
            // newButtonApply
            // 
            newButtonApply.BackColor = Color.FromArgb(80, 175, 138);
            newButtonApply.BackColorAdditional = Color.Gray;
            newButtonApply.BackColorGradientEnabled = false;
            newButtonApply.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            newButtonApply.BorderColor = Color.FromArgb(80, 175, 138);
            newButtonApply.BorderColorEnabled = false;
            newButtonApply.BorderColorOnHover = Color.FromArgb(80, 175, 138);
            newButtonApply.BorderColorOnHoverEnabled = false;
            newButtonApply.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            newButtonApply.ForeColor = Color.White;
            newButtonApply.Location = new Point(530, 16);
            newButtonApply.Name = "newButtonApply";
            newButtonApply.RippleColor = Color.Black;
            newButtonApply.Rounding = 70;
            newButtonApply.RoundingEnable = true;
            newButtonApply.Size = new Size(125, 39);
            newButtonApply.TabIndex = 2;
            newButtonApply.Text = "Apply";
            newButtonApply.TextHover = null;
            newButtonApply.UseDownPressEffectOnClick = false;
            newButtonApply.UseMainGradientEffect = false;
            newButtonApply.UseRippleEffect = true;
            newButtonApply.UseVisualStyleBackColor = false;
            newButtonApply.UseZoomEffectOnHover = false;
            newButtonApply.Click += newButtonApply_Click;
            // 
            // backRoundPanel1
            // 
            backRoundPanel1.Autofocus = false;
            backRoundPanel1.AutoSize = true;
            backRoundPanel1.BackColor = Color.FromArgb(30, 35, 40);
            backRoundPanel1.BackgroundColor = Color.FromArgb(30, 35, 40);
            backRoundPanel1.BorderColor = Color.PaleVioletRed;
            backRoundPanel1.BorderRadius = 15;
            backRoundPanel1.BorderSize = 0;
            backRoundPanel1.Controls.Add(richTextBox1);
            backRoundPanel1.Dock = DockStyle.Fill;
            backRoundPanel1.FocusBorderColor = Color.Gray;
            backRoundPanel1.FocusBorderSize = 2;
            backRoundPanel1.ForeColor = Color.White;
            backRoundPanel1.Location = new Point(25, 26);
            backRoundPanel1.Margin = new Padding(3, 4, 3, 4);
            backRoundPanel1.Name = "backRoundPanel1";
            backRoundPanel1.Padding = new Padding(20);
            backRoundPanel1.Size = new Size(661, 327);
            backRoundPanel1.TabIndex = 4;
            backRoundPanel1.TextColor = Color.White;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(30, 35, 40);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.ForeColor = SystemColors.Control;
            richTextBox1.Location = new Point(20, 20);
            richTextBox1.MaxLength = 2000;
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(621, 287);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(711, 432);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // newToggleSwitch1
            // 
            newToggleSwitch1.BackColor = SystemColors.Control;
            newToggleSwitch1.BackColorOFF = Color.FromArgb(220, 50, 80);
            newToggleSwitch1.BackColorON = Color.FromArgb(80, 175, 138);
            newToggleSwitch1.Checked = false;
            newToggleSwitch1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            newToggleSwitch1.ForeColor = SystemColors.ControlLight;
            newToggleSwitch1.Location = new Point(117, 4);
            newToggleSwitch1.Name = "newToggleSwitch1";
            newToggleSwitch1.Size = new Size(156, 19);
            newToggleSwitch1.TabIndex = 16;
            newToggleSwitch1.Text = "Message Type";
            newToggleSwitch1.TextOnChecked = "";
            // 
            // CreateTask
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 49, 60);
            ClientSize = new Size(711, 432);
            Controls.Add(tableLayoutPanel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(711, 235);
            Name = "CreateTask";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterParent;
            Text = "AnswerToTask";
            Load += AnswerToTask_Load;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            backRoundPanel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PanelComponents.BackRoundPanel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel3;
        private Label labelCounter;
        private yt_DesignUI.NewButton newButton1;
        private yt_DesignUI.NewButton newButtonApply;
        private PanelComponents.BackRoundPanel backRoundPanel1;
        private RichTextBox richTextBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private yt_DesignUI.NewToggleSwitch newToggleSwitch1;
    }
}