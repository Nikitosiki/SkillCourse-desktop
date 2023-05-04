namespace SkillCourse.PanelComponents.AnswerTaskComponent
{
    partial class Component_AssignmentScore
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            backRoundPanel1 = new BackRoundPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel4 = new Panel();
            buttonMinus1 = new yt_DesignUI.NewButton();
            buttonMinus2 = new yt_DesignUI.NewButton();
            labelGrade = new Label();
            panel2 = new Panel();
            buttonPlus1 = new yt_DesignUI.NewButton();
            buttonPlus2 = new yt_DesignUI.NewButton();
            backRoundPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
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
            backRoundPanel1.Controls.Add(tableLayoutPanel4);
            backRoundPanel1.Dock = DockStyle.Fill;
            backRoundPanel1.FocusBorderColor = Color.Gray;
            backRoundPanel1.FocusBorderSize = 2;
            backRoundPanel1.ForeColor = Color.White;
            backRoundPanel1.Location = new Point(0, 0);
            backRoundPanel1.Margin = new Padding(3, 4, 3, 4);
            backRoundPanel1.Name = "backRoundPanel1";
            backRoundPanel1.Size = new Size(286, 50);
            backRoundPanel1.TabIndex = 5;
            backRoundPanel1.TextColor = Color.White;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(panel4, 0, 0);
            tableLayoutPanel4.Controls.Add(labelGrade, 1, 0);
            tableLayoutPanel4.Controls.Add(panel2, 2, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(286, 50);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(buttonMinus1);
            panel4.Controls.Add(buttonMinus2);
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(124, 50);
            panel4.TabIndex = 2;
            // 
            // buttonMinus1
            // 
            buttonMinus1.BackColor = Color.FromArgb(162, 54, 73);
            buttonMinus1.BackColorAdditional = Color.Gray;
            buttonMinus1.BackColorGradientEnabled = false;
            buttonMinus1.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            buttonMinus1.BorderColor = Color.FromArgb(80, 175, 138);
            buttonMinus1.BorderColorEnabled = false;
            buttonMinus1.BorderColorOnHover = Color.FromArgb(80, 175, 138);
            buttonMinus1.BorderColorOnHoverEnabled = false;
            buttonMinus1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMinus1.ForeColor = Color.White;
            buttonMinus1.Location = new Point(68, 8);
            buttonMinus1.Name = "buttonMinus1";
            buttonMinus1.RippleColor = Color.Black;
            buttonMinus1.Rounding = 90;
            buttonMinus1.RoundingEnable = true;
            buttonMinus1.Size = new Size(35, 35);
            buttonMinus1.TabIndex = 4;
            buttonMinus1.Text = "-1";
            buttonMinus1.TextHover = null;
            buttonMinus1.UseDownPressEffectOnClick = false;
            buttonMinus1.UseMainGradientEffect = false;
            buttonMinus1.UseRippleEffect = true;
            buttonMinus1.UseVisualStyleBackColor = false;
            buttonMinus1.UseZoomEffectOnHover = false;
            buttonMinus1.Click += buttonMinus1_Click;
            // 
            // buttonMinus2
            // 
            buttonMinus2.BackColor = Color.FromArgb(239, 80, 108);
            buttonMinus2.BackColorAdditional = Color.Gray;
            buttonMinus2.BackColorGradientEnabled = false;
            buttonMinus2.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            buttonMinus2.BorderColor = Color.FromArgb(239, 80, 108);
            buttonMinus2.BorderColorEnabled = false;
            buttonMinus2.BorderColorOnHover = Color.FromArgb(239, 80, 108);
            buttonMinus2.BorderColorOnHoverEnabled = false;
            buttonMinus2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMinus2.ForeColor = Color.White;
            buttonMinus2.Location = new Point(17, 5);
            buttonMinus2.Name = "buttonMinus2";
            buttonMinus2.RippleColor = Color.Black;
            buttonMinus2.Rounding = 90;
            buttonMinus2.RoundingEnable = true;
            buttonMinus2.Size = new Size(40, 40);
            buttonMinus2.TabIndex = 3;
            buttonMinus2.Text = "-2";
            buttonMinus2.TextHover = null;
            buttonMinus2.UseDownPressEffectOnClick = false;
            buttonMinus2.UseMainGradientEffect = false;
            buttonMinus2.UseRippleEffect = true;
            buttonMinus2.UseVisualStyleBackColor = false;
            buttonMinus2.UseZoomEffectOnHover = false;
            buttonMinus2.Click += buttonMinus2_Click;
            // 
            // labelGrade
            // 
            labelGrade.AutoSize = true;
            labelGrade.Dock = DockStyle.Fill;
            labelGrade.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelGrade.ForeColor = SystemColors.ControlLightLight;
            labelGrade.Location = new Point(127, 0);
            labelGrade.Name = "labelGrade";
            labelGrade.Padding = new Padding(0, 0, 0, 2);
            labelGrade.Size = new Size(32, 50);
            labelGrade.TabIndex = 0;
            labelGrade.Text = "5";
            labelGrade.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonPlus1);
            panel2.Controls.Add(buttonPlus2);
            panel2.Location = new Point(162, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(124, 50);
            panel2.TabIndex = 1;
            // 
            // buttonPlus1
            // 
            buttonPlus1.BackColor = Color.FromArgb(56, 124, 97);
            buttonPlus1.BackColorAdditional = Color.Gray;
            buttonPlus1.BackColorGradientEnabled = false;
            buttonPlus1.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            buttonPlus1.BorderColor = Color.FromArgb(80, 175, 138);
            buttonPlus1.BorderColorEnabled = false;
            buttonPlus1.BorderColorOnHover = Color.FromArgb(80, 175, 138);
            buttonPlus1.BorderColorOnHoverEnabled = false;
            buttonPlus1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPlus1.ForeColor = Color.White;
            buttonPlus1.Location = new Point(22, 8);
            buttonPlus1.Name = "buttonPlus1";
            buttonPlus1.RippleColor = Color.Black;
            buttonPlus1.Rounding = 90;
            buttonPlus1.RoundingEnable = true;
            buttonPlus1.Size = new Size(35, 35);
            buttonPlus1.TabIndex = 4;
            buttonPlus1.Text = "+1";
            buttonPlus1.TextHover = null;
            buttonPlus1.UseDownPressEffectOnClick = false;
            buttonPlus1.UseMainGradientEffect = false;
            buttonPlus1.UseRippleEffect = true;
            buttonPlus1.UseVisualStyleBackColor = false;
            buttonPlus1.UseZoomEffectOnHover = false;
            buttonPlus1.Click += buttonPlus1_Click;
            // 
            // buttonPlus2
            // 
            buttonPlus2.BackColor = Color.FromArgb(80, 175, 138);
            buttonPlus2.BackColorAdditional = Color.Gray;
            buttonPlus2.BackColorGradientEnabled = false;
            buttonPlus2.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            buttonPlus2.BorderColor = Color.FromArgb(80, 175, 138);
            buttonPlus2.BorderColorEnabled = false;
            buttonPlus2.BorderColorOnHover = Color.FromArgb(80, 175, 138);
            buttonPlus2.BorderColorOnHoverEnabled = false;
            buttonPlus2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPlus2.ForeColor = Color.White;
            buttonPlus2.Location = new Point(68, 5);
            buttonPlus2.Name = "buttonPlus2";
            buttonPlus2.RippleColor = Color.Black;
            buttonPlus2.Rounding = 90;
            buttonPlus2.RoundingEnable = true;
            buttonPlus2.Size = new Size(40, 40);
            buttonPlus2.TabIndex = 3;
            buttonPlus2.Text = "+2";
            buttonPlus2.TextHover = null;
            buttonPlus2.UseDownPressEffectOnClick = false;
            buttonPlus2.UseMainGradientEffect = false;
            buttonPlus2.UseRippleEffect = true;
            buttonPlus2.UseVisualStyleBackColor = false;
            buttonPlus2.UseZoomEffectOnHover = false;
            buttonPlus2.Click += buttonPlus2_Click;
            // 
            // Component_AssignmentScore
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(backRoundPanel1);
            Name = "Component_AssignmentScore";
            Size = new Size(286, 50);
            backRoundPanel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BackRoundPanel backRoundPanel1;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel4;
        private yt_DesignUI.NewButton buttonMinus1;
        private yt_DesignUI.NewButton buttonMinus2;
        private Label labelGrade;
        private Panel panel2;
        private yt_DesignUI.NewButton buttonPlus1;
        private yt_DesignUI.NewButton buttonPlus2;
    }
}
