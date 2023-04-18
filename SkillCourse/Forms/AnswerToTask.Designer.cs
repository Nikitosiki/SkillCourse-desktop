namespace SkillCourse.Forms
{
    partial class AnswerToTask
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
            newButtonApply = new yt_DesignUI.NewButton();
            newButton1 = new yt_DesignUI.NewButton();
            backRoundPanel1 = new PanelComponents.BackRoundPanel();
            richTextBox1 = new RichTextBox();
            labelCounter = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
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
            newButtonApply.Location = new Point(555, 380);
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
            newButton1.Location = new Point(406, 380);
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
            // backRoundPanel1
            // 
            backRoundPanel1.Autofocus = false;
            backRoundPanel1.BackColor = Color.FromArgb(30, 35, 40);
            backRoundPanel1.BackgroundColor = Color.FromArgb(30, 35, 40);
            backRoundPanel1.BorderColor = Color.PaleVioletRed;
            backRoundPanel1.BorderRadius = 20;
            backRoundPanel1.BorderSize = 0;
            backRoundPanel1.FocusBorderColor = Color.Gray;
            backRoundPanel1.FocusBorderSize = 2;
            backRoundPanel1.ForeColor = Color.White;
            backRoundPanel1.Location = new Point(22, 22);
            backRoundPanel1.Margin = new Padding(3, 4, 3, 4);
            backRoundPanel1.Name = "backRoundPanel1";
            backRoundPanel1.Size = new Size(668, 338);
            backRoundPanel1.TabIndex = 4;
            backRoundPanel1.TextColor = Color.White;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(30, 35, 40);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.ForeColor = SystemColors.Control;
            richTextBox1.Location = new Point(45, 36);
            richTextBox1.MaxLength = 2000;
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(620, 306);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // labelCounter
            // 
            labelCounter.AutoSize = true;
            labelCounter.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelCounter.ForeColor = SystemColors.ButtonShadow;
            labelCounter.Location = new Point(45, 364);
            labelCounter.Name = "labelCounter";
            labelCounter.Size = new Size(72, 23);
            labelCounter.TabIndex = 6;
            labelCounter.Text = "0 / 2000";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel2, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(711, 435);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Controls.Add(richTextBox1);
            panel2.Controls.Add(backRoundPanel1);
            panel2.Controls.Add(labelCounter);
            panel2.Controls.Add(newButtonApply);
            panel2.Controls.Add(newButton1);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(711, 435);
            panel2.TabIndex = 8;
            // 
            // AnswerToTask
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 49, 60);
            ClientSize = new Size(711, 435);
            Controls.Add(tableLayoutPanel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(711, 435);
            Name = "AnswerToTask";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterParent;
            Text = "AnswerToTask";
            Load += AnswerToTask_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private yt_DesignUI.NewButton newButtonApply;
        private yt_DesignUI.NewButton newButton1;
        private PanelComponents.BackRoundPanel panel1;
        private PanelComponents.BackRoundPanel backRoundPanel1;
        private RichTextBox richTextBox1;
        private Label labelCounter;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
    }
}