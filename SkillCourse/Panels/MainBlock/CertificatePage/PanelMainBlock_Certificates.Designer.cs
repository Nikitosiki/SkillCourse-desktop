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
            labelNumber = new Label();
            buttonScrollRight = new Button();
            buttonScrollLeft = new Button();
            panelThisCertificates = new FlowLayoutPanel();
            panelBlockScroll.SuspendLayout();
            SuspendLayout();
            // 
            // panelBlockScroll
            // 
            panelBlockScroll.Controls.Add(labelNumber);
            panelBlockScroll.Location = new Point(46, 644);
            panelBlockScroll.Name = "panelBlockScroll";
            panelBlockScroll.Size = new Size(914, 54);
            panelBlockScroll.TabIndex = 1;
            // 
            // labelNumber
            // 
            labelNumber.Dock = DockStyle.Fill;
            labelNumber.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelNumber.ForeColor = SystemColors.Control;
            labelNumber.Location = new Point(0, 0);
            labelNumber.Margin = new Padding(0);
            labelNumber.Name = "labelNumber";
            labelNumber.Padding = new Padding(0, 10, 0, 0);
            labelNumber.Size = new Size(914, 54);
            labelNumber.TabIndex = 0;
            labelNumber.Text = "1 / 1";
            labelNumber.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonScrollRight
            // 
            buttonScrollRight.Dock = DockStyle.Right;
            buttonScrollRight.FlatAppearance.BorderSize = 0;
            buttonScrollRight.FlatStyle = FlatStyle.Flat;
            buttonScrollRight.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonScrollRight.ForeColor = SystemColors.Control;
            buttonScrollRight.Location = new Point(966, 0);
            buttonScrollRight.Name = "buttonScrollRight";
            buttonScrollRight.Padding = new Padding(0, 320, 0, 0);
            buttonScrollRight.Size = new Size(46, 701);
            buttonScrollRight.TabIndex = 2;
            buttonScrollRight.Text = ">";
            buttonScrollRight.TextAlign = ContentAlignment.TopCenter;
            buttonScrollRight.UseVisualStyleBackColor = true;
            buttonScrollRight.Click += buttonScrollRight_Click;
            // 
            // buttonScrollLeft
            // 
            buttonScrollLeft.Dock = DockStyle.Left;
            buttonScrollLeft.FlatAppearance.BorderSize = 0;
            buttonScrollLeft.FlatStyle = FlatStyle.Flat;
            buttonScrollLeft.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonScrollLeft.ForeColor = SystemColors.Control;
            buttonScrollLeft.Location = new Point(0, 0);
            buttonScrollLeft.Name = "buttonScrollLeft";
            buttonScrollLeft.Padding = new Padding(0, 320, 0, 0);
            buttonScrollLeft.Size = new Size(46, 701);
            buttonScrollLeft.TabIndex = 3;
            buttonScrollLeft.Text = "<";
            buttonScrollLeft.TextAlign = ContentAlignment.TopCenter;
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
            AutoSize = true;
            BackColor = Color.FromArgb(40, 49, 60);
            Controls.Add(panelBlockScroll);
            Controls.Add(buttonScrollRight);
            Controls.Add(buttonScrollLeft);
            Controls.Add(panelThisCertificates);
            Name = "PanelMainBlock_Certificates";
            Size = new Size(1012, 701);
            panelBlockScroll.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelBlockScroll;
        private Button buttonScrollRight;
        private Button buttonScrollLeft;
        private FlowLayoutPanel panelThisCertificates;
        private Label labelNumber;
    }
}
