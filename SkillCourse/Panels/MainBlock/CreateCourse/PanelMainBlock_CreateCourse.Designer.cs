namespace SkillCourse.Panels.MainBlock
{
    partial class PanelMainBlock_CreateCourse
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
            panel1 = new Panel();
            panel2 = new Panel();
            panelMainBlock = new Panel();
            panel4 = new Panel();
            newButtonNext = new yt_DesignUI.NewButton();
            panel3 = new Panel();
            labelNameType = new Label();
            newButtonBack = new yt_DesignUI.NewButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1012, 673);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(panelMainBlock);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 73);
            panel2.Name = "panel2";
            panel2.Size = new Size(1012, 519);
            panel2.TabIndex = 11;
            // 
            // panelMainBlock
            // 
            panelMainBlock.Dock = DockStyle.Fill;
            panelMainBlock.Location = new Point(0, 0);
            panelMainBlock.Name = "panelMainBlock";
            panelMainBlock.Size = new Size(1012, 519);
            panelMainBlock.TabIndex = 14;
            // 
            // panel4
            // 
            panel4.Controls.Add(newButtonBack);
            panel4.Controls.Add(newButtonNext);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 592);
            panel4.Name = "panel4";
            panel4.Size = new Size(1012, 81);
            panel4.TabIndex = 48;
            // 
            // newButtonNext
            // 
            newButtonNext.BackColor = Color.FromArgb(91, 111, 136);
            newButtonNext.BackColorAdditional = Color.Gray;
            newButtonNext.BackColorGradientEnabled = false;
            newButtonNext.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            newButtonNext.BorderColor = Color.FromArgb(33, 39, 46);
            newButtonNext.BorderColorEnabled = false;
            newButtonNext.BorderColorOnHover = Color.FromArgb(35, 42, 50);
            newButtonNext.BorderColorOnHoverEnabled = false;
            newButtonNext.FlatAppearance.BorderColor = Color.FromArgb(35, 42, 50);
            newButtonNext.FlatAppearance.BorderSize = 4;
            newButtonNext.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            newButtonNext.ForeColor = SystemColors.ControlLight;
            newButtonNext.Location = new Point(847, 21);
            newButtonNext.Name = "newButtonNext";
            newButtonNext.RippleColor = Color.Black;
            newButtonNext.Rounding = 30;
            newButtonNext.RoundingEnable = true;
            newButtonNext.Size = new Size(125, 40);
            newButtonNext.TabIndex = 9;
            newButtonNext.Text = "Next";
            newButtonNext.TextHover = null;
            newButtonNext.UseDownPressEffectOnClick = false;
            newButtonNext.UseMainGradientEffect = false;
            newButtonNext.UseRippleEffect = true;
            newButtonNext.UseVisualStyleBackColor = false;
            newButtonNext.UseZoomEffectOnHover = false;
            newButtonNext.Click += newButtonNext_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(labelNameType);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1012, 73);
            panel3.TabIndex = 47;
            // 
            // labelNameType
            // 
            labelNameType.AutoSize = true;
            labelNameType.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelNameType.ForeColor = SystemColors.Control;
            labelNameType.Location = new Point(61, 22);
            labelNameType.Name = "labelNameType";
            labelNameType.Size = new Size(156, 31);
            labelNameType.TabIndex = 2;
            labelNameType.Text = "Create Course";
            // 
            // newButtonBack
            // 
            newButtonBack.BackColor = Color.FromArgb(51, 58, 68);
            newButtonBack.BackColorAdditional = Color.Gray;
            newButtonBack.BackColorGradientEnabled = false;
            newButtonBack.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            newButtonBack.BorderColor = Color.FromArgb(33, 44, 54);
            newButtonBack.BorderColorEnabled = false;
            newButtonBack.BorderColorOnHover = Color.FromArgb(35, 42, 50);
            newButtonBack.BorderColorOnHoverEnabled = false;
            newButtonBack.FlatAppearance.BorderColor = Color.FromArgb(35, 42, 50);
            newButtonBack.FlatAppearance.BorderSize = 4;
            newButtonBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            newButtonBack.ForeColor = SystemColors.ControlDark;
            newButtonBack.Location = new Point(42, 21);
            newButtonBack.Name = "newButtonBack";
            newButtonBack.RippleColor = Color.Black;
            newButtonBack.Rounding = 30;
            newButtonBack.RoundingEnable = true;
            newButtonBack.Size = new Size(125, 40);
            newButtonBack.TabIndex = 10;
            newButtonBack.Text = "Back";
            newButtonBack.TextHover = null;
            newButtonBack.UseDownPressEffectOnClick = false;
            newButtonBack.UseMainGradientEffect = false;
            newButtonBack.UseRippleEffect = true;
            newButtonBack.UseVisualStyleBackColor = false;
            newButtonBack.UseZoomEffectOnHover = false;
            // 
            // PanelMainBlock_CreateCourse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 49, 60);
            Controls.Add(panel1);
            Name = "PanelMainBlock_CreateCourse";
            Size = new Size(1012, 673);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private yt_DesignUI.NewButton newButtonNext;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private Label labelNameType;
        private Panel panelMainBlock;
        private yt_DesignUI.NewButton newButtonBack;
    }
}
