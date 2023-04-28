namespace SkillCourse.Panels.MainBlock.CreateCourse
{
    partial class Component_CreateCourse_AddingTask
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new PanelComponents.BackRoundPanel();
            label1 = new Label();
            panel1 = new Panel();
            labelStemNumber = new Label();
            newButtonNext = new yt_DesignUI.NewButton();
            panel3 = new Panel();
            label2 = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            newToggleSwitch1 = new yt_DesignUI.NewToggleSwitch();
            label3 = new Label();
            textBoxText = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(38, 45, 52);
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel2, 1, 1);
            tableLayoutPanel1.Controls.Add(panel3, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1009, 519);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Autofocus = false;
            panel2.BackColor = Color.FromArgb(44, 51, 57);
            panel2.BackgroundColor = Color.FromArgb(44, 51, 57);
            panel2.BorderColor = Color.PaleVioletRed;
            panel2.BorderRadius = 10;
            panel2.BorderSize = 0;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel1);
            panel2.FocusBorderColor = Color.Gray;
            panel2.FocusBorderSize = 2;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(264, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(481, 124);
            panel2.TabIndex = 53;
            panel2.TextColor = Color.White;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(481, 36);
            label1.TabIndex = 50;
            label1.Text = "Add first task?";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelStemNumber);
            panel1.Controls.Add(newButtonNext);
            panel1.Location = new Point(67, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(347, 38);
            panel1.TabIndex = 52;
            // 
            // labelStemNumber
            // 
            labelStemNumber.Dock = DockStyle.Left;
            labelStemNumber.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelStemNumber.ForeColor = SystemColors.ActiveCaption;
            labelStemNumber.Location = new Point(0, 0);
            labelStemNumber.Name = "labelStemNumber";
            labelStemNumber.Padding = new Padding(0, 0, 0, 5);
            labelStemNumber.Size = new Size(135, 38);
            labelStemNumber.TabIndex = 52;
            labelStemNumber.Text = "Just skip";
            labelStemNumber.TextAlign = ContentAlignment.MiddleCenter;
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
            newButtonNext.Dock = DockStyle.Right;
            newButtonNext.FlatAppearance.BorderColor = Color.FromArgb(35, 42, 50);
            newButtonNext.FlatAppearance.BorderSize = 4;
            newButtonNext.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            newButtonNext.ForeColor = SystemColors.ControlLight;
            newButtonNext.Location = new Point(215, 0);
            newButtonNext.Name = "newButtonNext";
            newButtonNext.RippleColor = Color.Black;
            newButtonNext.Rounding = 30;
            newButtonNext.RoundingEnable = true;
            newButtonNext.Size = new Size(132, 38);
            newButtonNext.TabIndex = 51;
            newButtonNext.Text = "Yes";
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
            panel3.Controls.Add(label2);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(264, 179);
            panel3.Name = "panel3";
            panel3.Size = new Size(481, 290);
            panel3.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(22, 47);
            label2.Name = "label2";
            label2.Size = new Size(46, 28);
            label2.TabIndex = 13;
            label2.Text = "Text";
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(textBoxText);
            panel4.Location = new Point(112, 47);
            panel4.Name = "panel4";
            panel4.Size = new Size(338, 225);
            panel4.TabIndex = 16;
            // 
            // panel5
            // 
            panel5.Controls.Add(newToggleSwitch1);
            panel5.Controls.Add(label3);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 37);
            panel5.Name = "panel5";
            panel5.Size = new Size(338, 40);
            panel5.TabIndex = 13;
            // 
            // newToggleSwitch1
            // 
            newToggleSwitch1.BackColor = SystemColors.Control;
            newToggleSwitch1.BackColorOFF = Color.FromArgb(220, 50, 80);
            newToggleSwitch1.BackColorON = Color.FromArgb(80, 175, 138);
            newToggleSwitch1.Checked = false;
            newToggleSwitch1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            newToggleSwitch1.ForeColor = SystemColors.ControlLight;
            newToggleSwitch1.Location = new Point(3, 10);
            newToggleSwitch1.Name = "newToggleSwitch1";
            newToggleSwitch1.Size = new Size(156, 19);
            newToggleSwitch1.TabIndex = 15;
            newToggleSwitch1.Text = "Message Type";
            newToggleSwitch1.TextOnChecked = "";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonShadow;
            label3.Location = new Point(258, 10);
            label3.Name = "label3";
            label3.Size = new Size(83, 23);
            label3.TabIndex = 14;
            label3.Text = "0 / 300";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // textBoxText
            // 
            textBoxText.BackColor = Color.FromArgb(38, 45, 52);
            textBoxText.BorderStyle = BorderStyle.FixedSingle;
            textBoxText.Dock = DockStyle.Top;
            textBoxText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxText.ForeColor = SystemColors.ControlLight;
            textBoxText.Location = new Point(0, 0);
            textBoxText.MaxLength = 300;
            textBoxText.Multiline = true;
            textBoxText.Name = "textBoxText";
            textBoxText.Size = new Size(338, 37);
            textBoxText.TabIndex = 12;
            textBoxText.TextChanged += textBoxName_TextChanged;
            // 
            // Component_CreateCourse_AddingTask
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 45, 52);
            Controls.Add(tableLayoutPanel1);
            Name = "Component_CreateCourse_AddingTask";
            Size = new Size(1009, 519);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Panel panel1;
        private yt_DesignUI.NewButton newButtonNext;
        private Panel panel3;
        private Label labelStemNumber;
        private PanelComponents.BackRoundPanel panel2;
        private TextBox textBoxText;
        private Label label2;
        private Label label3;
        private yt_DesignUI.NewToggleSwitch newToggleSwitch1;
        private Panel panel4;
        private Panel panel5;
    }
}
