namespace SkillCourse.PanelComponents
{
    partial class Component_NavigationBut
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
            panelDopButton = new Panel();
            button1 = new Button();
            SuspendLayout();
            // 
            // panelDopButton
            // 
            panelDopButton.AutoSize = true;
            panelDopButton.Dock = DockStyle.Bottom;
            panelDopButton.Location = new Point(0, 64);
            panelDopButton.Name = "panelDopButton";
            panelDopButton.Size = new Size(211, 0);
            panelDopButton.TabIndex = 0;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLight;
            button1.Image = Properties.Resources.view_cozy_FILL0_wght400_GRAD0_opsz48_32;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(211, 64);
            button1.TabIndex = 1;
            button1.Text = "Courses";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Component_NavigationBut
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 49, 60);
            Controls.Add(button1);
            Controls.Add(panelDopButton);
            Name = "Component_NavigationBut";
            Size = new Size(211, 64);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelDopButton;
        private Button button1;
    }
}
