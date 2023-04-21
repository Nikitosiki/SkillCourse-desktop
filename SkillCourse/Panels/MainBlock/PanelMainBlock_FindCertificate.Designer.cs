namespace SkillCourse.Panels.MainBlock
{
    partial class PanelMainBlock_FindCertificate
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
            backRoundPanel1 = new PanelComponents.BackRoundPanel();
            panel1 = new Panel();
            maskedTextBoxInputKey = new MaskedTextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panelText = new Panel();
            newButtonApply = new yt_DesignUI.NewButton();
            label1 = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panelText.SuspendLayout();
            SuspendLayout();
            // 
            // backRoundPanel1
            // 
            backRoundPanel1.Autofocus = false;
            backRoundPanel1.BackColor = Color.FromArgb(30, 35, 40);
            backRoundPanel1.BackgroundColor = Color.FromArgb(30, 35, 40);
            backRoundPanel1.BorderColor = Color.PaleVioletRed;
            backRoundPanel1.BorderRadius = 30;
            backRoundPanel1.BorderSize = 0;
            backRoundPanel1.FocusBorderColor = Color.Gray;
            backRoundPanel1.FocusBorderSize = 2;
            backRoundPanel1.ForeColor = Color.White;
            backRoundPanel1.Location = new Point(0, 0);
            backRoundPanel1.Margin = new Padding(3, 4, 3, 4);
            backRoundPanel1.Name = "backRoundPanel1";
            backRoundPanel1.Size = new Size(644, 105);
            backRoundPanel1.TabIndex = 5;
            backRoundPanel1.TextColor = Color.White;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 35, 40);
            panel1.Controls.Add(maskedTextBoxInputKey);
            panel1.Location = new Point(30, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 35, 0, 0);
            panel1.Size = new Size(585, 105);
            panel1.TabIndex = 7;
            // 
            // maskedTextBoxInputKey
            // 
            maskedTextBoxInputKey.BackColor = Color.FromArgb(30, 35, 40);
            maskedTextBoxInputKey.BorderStyle = BorderStyle.None;
            maskedTextBoxInputKey.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBoxInputKey.ForeColor = SystemColors.ControlDark;
            maskedTextBoxInputKey.Location = new Point(0, 36);
            maskedTextBoxInputKey.Mask = "AAAA-AAAA-AAAA-AAAA-AAAA-AAAA";
            maskedTextBoxInputKey.Name = "maskedTextBoxInputKey";
            maskedTextBoxInputKey.PromptChar = 'X';
            maskedTextBoxInputKey.Size = new Size(585, 31);
            maskedTextBoxInputKey.TabIndex = 12;
            maskedTextBoxInputKey.TextAlign = HorizontalAlignment.Center;
            maskedTextBoxInputKey.TextChanged += maskedTextBoxInputKey_TextChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panelText, 1, 1);
            tableLayoutPanel1.Controls.Add(newButtonApply, 1, 3);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 45.45454F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 54.5454559F));
            tableLayoutPanel1.Size = new Size(1012, 673);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // panelText
            // 
            panelText.Controls.Add(panel1);
            panelText.Controls.Add(backRoundPanel1);
            panelText.Location = new Point(184, 222);
            panelText.Name = "panelText";
            panelText.Size = new Size(644, 105);
            panelText.TabIndex = 9;
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
            newButtonApply.Dock = DockStyle.Right;
            newButtonApply.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            newButtonApply.ForeColor = Color.White;
            newButtonApply.Location = new Point(703, 368);
            newButtonApply.Name = "newButtonApply";
            newButtonApply.RippleColor = Color.Black;
            newButtonApply.Rounding = 70;
            newButtonApply.RoundingEnable = true;
            newButtonApply.Size = new Size(125, 39);
            newButtonApply.TabIndex = 10;
            newButtonApply.Text = "Apply";
            newButtonApply.TextHover = null;
            newButtonApply.UseDownPressEffectOnClick = false;
            newButtonApply.UseMainGradientEffect = false;
            newButtonApply.UseRippleEffect = true;
            newButtonApply.UseVisualStyleBackColor = false;
            newButtonApply.UseZoomEffectOnHover = false;
            newButtonApply.Click += newButtonApply_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Bottom;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(201, 186);
            label1.Margin = new Padding(20, 0, 3, 5);
            label1.Name = "label1";
            label1.Size = new Size(627, 28);
            label1.TabIndex = 11;
            label1.Text = "Please enter the certificate number";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // PanelMainBlock_FindCertificate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 49, 60);
            Controls.Add(tableLayoutPanel1);
            Name = "PanelMainBlock_FindCertificate";
            Size = new Size(1012, 673);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panelText.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PanelComponents.BackRoundPanel backRoundPanel1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelText;
        private yt_DesignUI.NewButton newButtonApply;
        private Label label1;
        private MaskedTextBox maskedTextBoxInputKey;
    }
}
