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
            tableLayoutPanel1 = new TableLayoutPanel();
            backRoundPanel1 = new PanelComponents.BackRoundPanel();
            panelMainBlock = new Panel();
            panel4 = new Panel();
            labelStemNumber = new Label();
            panel5 = new Panel();
            newButtonNext = new yt_DesignUI.NewButton();
            panel2 = new Panel();
            newButtonBack = new yt_DesignUI.NewButton();
            labelStepName = new Label();
            panel3 = new Panel();
            labelNameType = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            backRoundPanel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1012, 673);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(backRoundPanel1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 73);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1012, 600);
            tableLayoutPanel1.TabIndex = 49;
            // 
            // backRoundPanel1
            // 
            backRoundPanel1.Autofocus = false;
            backRoundPanel1.BackColor = Color.FromArgb(38, 45, 52);
            backRoundPanel1.BackgroundColor = Color.FromArgb(38, 45, 52);
            backRoundPanel1.BorderColor = Color.PaleVioletRed;
            backRoundPanel1.BorderRadius = 5;
            backRoundPanel1.BorderSize = 0;
            backRoundPanel1.Controls.Add(panelMainBlock);
            backRoundPanel1.Controls.Add(panel4);
            backRoundPanel1.Controls.Add(labelStepName);
            backRoundPanel1.Dock = DockStyle.Fill;
            backRoundPanel1.FocusBorderColor = Color.Gray;
            backRoundPanel1.FocusBorderSize = 2;
            backRoundPanel1.ForeColor = Color.White;
            backRoundPanel1.Location = new Point(206, 80);
            backRoundPanel1.Name = "backRoundPanel1";
            backRoundPanel1.Size = new Size(600, 440);
            backRoundPanel1.TabIndex = 15;
            backRoundPanel1.TextColor = Color.White;
            // 
            // panelMainBlock
            // 
            panelMainBlock.AutoSize = true;
            panelMainBlock.Dock = DockStyle.Fill;
            panelMainBlock.Location = new Point(0, 49);
            panelMainBlock.Name = "panelMainBlock";
            panelMainBlock.Padding = new Padding(10, 0, 10, 10);
            panelMainBlock.Size = new Size(600, 325);
            panelMainBlock.TabIndex = 16;
            // 
            // panel4
            // 
            panel4.Controls.Add(labelStemNumber);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(panel2);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 374);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(15, 10, 15, 10);
            panel4.Size = new Size(600, 66);
            panel4.TabIndex = 48;
            // 
            // labelStemNumber
            // 
            labelStemNumber.Dock = DockStyle.Fill;
            labelStemNumber.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelStemNumber.ForeColor = SystemColors.ControlDark;
            labelStemNumber.Location = new Point(147, 10);
            labelStemNumber.Name = "labelStemNumber";
            labelStemNumber.Padding = new Padding(0, 0, 0, 5);
            labelStemNumber.Size = new Size(306, 46);
            labelStemNumber.TabIndex = 17;
            labelStemNumber.Text = "Step 1 / 4";
            labelStemNumber.TextAlign = ContentAlignment.BottomCenter;
            // 
            // panel5
            // 
            panel5.Controls.Add(newButtonNext);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(453, 10);
            panel5.Name = "panel5";
            panel5.Size = new Size(132, 46);
            panel5.TabIndex = 19;
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
            newButtonNext.Dock = DockStyle.Fill;
            newButtonNext.FlatAppearance.BorderColor = Color.FromArgb(35, 42, 50);
            newButtonNext.FlatAppearance.BorderSize = 4;
            newButtonNext.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            newButtonNext.ForeColor = SystemColors.ControlLight;
            newButtonNext.Location = new Point(0, 0);
            newButtonNext.Name = "newButtonNext";
            newButtonNext.RippleColor = Color.Black;
            newButtonNext.Rounding = 30;
            newButtonNext.RoundingEnable = true;
            newButtonNext.Size = new Size(132, 46);
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
            // panel2
            // 
            panel2.Controls.Add(newButtonBack);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(15, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(132, 46);
            panel2.TabIndex = 18;
            // 
            // newButtonBack
            // 
            newButtonBack.BackColor = Color.FromArgb(38, 45, 52);
            newButtonBack.BackColorAdditional = Color.Gray;
            newButtonBack.BackColorGradientEnabled = false;
            newButtonBack.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            newButtonBack.BorderColor = Color.FromArgb(33, 44, 54);
            newButtonBack.BorderColorEnabled = false;
            newButtonBack.BorderColorOnHover = Color.FromArgb(35, 42, 50);
            newButtonBack.BorderColorOnHoverEnabled = false;
            newButtonBack.Dock = DockStyle.Fill;
            newButtonBack.FlatAppearance.BorderColor = Color.FromArgb(35, 42, 50);
            newButtonBack.FlatAppearance.BorderSize = 4;
            newButtonBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            newButtonBack.ForeColor = SystemColors.ControlDark;
            newButtonBack.Location = new Point(0, 0);
            newButtonBack.Name = "newButtonBack";
            newButtonBack.RippleColor = Color.Black;
            newButtonBack.Rounding = 30;
            newButtonBack.RoundingEnable = true;
            newButtonBack.Size = new Size(132, 46);
            newButtonBack.TabIndex = 10;
            newButtonBack.Text = "Back";
            newButtonBack.TextHover = null;
            newButtonBack.UseDownPressEffectOnClick = false;
            newButtonBack.UseMainGradientEffect = false;
            newButtonBack.UseRippleEffect = true;
            newButtonBack.UseVisualStyleBackColor = false;
            newButtonBack.UseZoomEffectOnHover = false;
            newButtonBack.Click += newButtonBack_Click;
            // 
            // labelStepName
            // 
            labelStepName.Dock = DockStyle.Top;
            labelStepName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelStepName.ForeColor = SystemColors.Control;
            labelStepName.Location = new Point(0, 0);
            labelStepName.Name = "labelStepName";
            labelStepName.Padding = new Padding(0, 0, 0, 5);
            labelStepName.Size = new Size(600, 49);
            labelStepName.TabIndex = 16;
            labelStepName.Text = "Step 1";
            labelStepName.TextAlign = ContentAlignment.BottomCenter;
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
            labelNameType.Location = new Point(29, 28);
            labelNameType.Name = "labelNameType";
            labelNameType.Size = new Size(156, 31);
            labelNameType.TabIndex = 2;
            labelNameType.Text = "Create Course";
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
            tableLayoutPanel1.ResumeLayout(false);
            backRoundPanel1.ResumeLayout(false);
            backRoundPanel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private yt_DesignUI.NewButton newButtonNext;
        private Panel panel4;
        private Panel panel3;
        private Label labelNameType;
        private yt_DesignUI.NewButton newButtonBack;
        private PanelComponents.BackRoundPanel backRoundPanel1;
        private Panel panelMainBlock;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelStepName;
        private Label labelStemNumber;
        private Panel panel5;
        private Panel panel2;
    }
}
