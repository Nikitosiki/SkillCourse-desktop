namespace SkillCourse.PanelComponents.CoursePage
{
    partial class Component_AddTask
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
            customRoundedButton1 = new CPProject.components.ui.CustomRoundedButton();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // customRoundedButton1
            // 
            customRoundedButton1.Autofocus = false;
            customRoundedButton1.BackColor = Color.FromArgb(50, 65, 80);
            customRoundedButton1.BackgroundColor = Color.FromArgb(50, 65, 80);
            customRoundedButton1.BorderColor = Color.PaleVioletRed;
            customRoundedButton1.BorderRadius = 10;
            customRoundedButton1.BorderSize = 0;
            customRoundedButton1.FlatAppearance.BorderSize = 0;
            customRoundedButton1.FlatStyle = FlatStyle.Flat;
            customRoundedButton1.FocusBorderColor = Color.Gray;
            customRoundedButton1.FocusBorderSize = 2;
            customRoundedButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customRoundedButton1.ForeColor = SystemColors.Control;
            customRoundedButton1.Location = new Point(10, 0);
            customRoundedButton1.Margin = new Padding(0);
            customRoundedButton1.Name = "customRoundedButton1";
            customRoundedButton1.Size = new Size(167, 50);
            customRoundedButton1.TabIndex = 0;
            customRoundedButton1.Text = "Create Task";
            customRoundedButton1.TextColor = SystemColors.Control;
            customRoundedButton1.UseVisualStyleBackColor = false;
            customRoundedButton1.Click += customRoundedButton1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(customRoundedButton1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(826, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 50);
            panel1.TabIndex = 1;
            // 
            // Component_AddTask
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(40, 49, 60);
            Controls.Add(panel1);
            MinimumSize = new Size(0, 50);
            Name = "Component_AddTask";
            Size = new Size(1012, 50);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CPProject.components.ui.CustomRoundedButton customRoundedButton1;
        private Panel panel1;
    }
}
