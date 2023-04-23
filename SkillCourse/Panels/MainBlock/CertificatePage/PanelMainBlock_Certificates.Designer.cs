namespace SkillCourse.Panels.MainBlock
{
    partial class PanelMainBlock_Certificates
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
            panelBlockScroll = new Panel();
            buttonScrollRight = new Button();
            buttonScrollLeft = new Button();
            panelThisCertificates = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // panelBlockScroll
            // 
            panelBlockScroll.Location = new Point(27, 646);
            panelBlockScroll.Name = "panelBlockScroll";
            panelBlockScroll.Size = new Size(936, 26);
            panelBlockScroll.TabIndex = 1;
            // 
            // buttonScrollRight
            // 
            buttonScrollRight.FlatAppearance.BorderSize = 0;
            buttonScrollRight.FlatStyle = FlatStyle.Flat;
            buttonScrollRight.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonScrollRight.ForeColor = SystemColors.Control;
            buttonScrollRight.Location = new Point(963, 270);
            buttonScrollRight.Name = "buttonScrollRight";
            buttonScrollRight.Size = new Size(46, 85);
            buttonScrollRight.TabIndex = 2;
            buttonScrollRight.Text = ">";
            buttonScrollRight.UseVisualStyleBackColor = true;
            buttonScrollRight.Click += buttonScrollRight_Click;
            // 
            // buttonScrollLeft
            // 
            buttonScrollLeft.FlatAppearance.BorderSize = 0;
            buttonScrollLeft.FlatStyle = FlatStyle.Flat;
            buttonScrollLeft.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonScrollLeft.ForeColor = SystemColors.Control;
            buttonScrollLeft.Location = new Point(0, 270);
            buttonScrollLeft.Name = "buttonScrollLeft";
            buttonScrollLeft.Size = new Size(46, 85);
            buttonScrollLeft.TabIndex = 3;
            buttonScrollLeft.Text = "<";
            buttonScrollLeft.UseVisualStyleBackColor = true;
            buttonScrollLeft.Click += buttonScrollLeft_Click;
            // 
            // panelThisCertificates
            // 
            panelThisCertificates.AutoScroll = true;
            panelThisCertificates.FlowDirection = FlowDirection.TopDown;
            panelThisCertificates.Location = new Point(73, 34);
            panelThisCertificates.Name = "panelThisCertificates";
            panelThisCertificates.Size = new Size(866, 638);
            panelThisCertificates.TabIndex = 5;
            // 
            // PanelMainBlock_Certificates
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 49, 60);
            Controls.Add(panelBlockScroll);
            Controls.Add(buttonScrollRight);
            Controls.Add(buttonScrollLeft);
            Controls.Add(panelThisCertificates);
            Name = "PanelMainBlock_Certificates";
            Size = new Size(1012, 673);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelBlockScroll;
        private Button buttonScrollRight;
        private Button buttonScrollLeft;
        private FlowLayoutPanel panelThisCertificates;
    }
}
