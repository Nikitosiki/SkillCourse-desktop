namespace SkillCourse.PanelComponents
{
    partial class Component_NavigationDopBut
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
            panel2 = new Panel();
            buttonThis = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonThis);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(211, 32);
            panel2.TabIndex = 1;
            // 
            // buttonThis
            // 
            buttonThis.Dock = DockStyle.Fill;
            buttonThis.FlatAppearance.BorderSize = 0;
            buttonThis.FlatStyle = FlatStyle.Flat;
            buttonThis.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonThis.ForeColor = SystemColors.ControlLight;
            buttonThis.ImageAlign = ContentAlignment.MiddleLeft;
            buttonThis.Location = new Point(0, 0);
            buttonThis.Name = "buttonThis";
            buttonThis.Padding = new Padding(45, 0, 0, 0);
            buttonThis.Size = new Size(211, 32);
            buttonThis.TabIndex = 2;
            buttonThis.Text = "All";
            buttonThis.TextAlign = ContentAlignment.MiddleLeft;
            buttonThis.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonThis.UseVisualStyleBackColor = true;
            buttonThis.Click += buttonThis_Click;
            // 
            // Component_NavigationDopBut
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 58, 72);
            Controls.Add(panel2);
            Name = "Component_NavigationDopBut";
            Size = new Size(211, 32);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        protected Button buttonThis;
    }
}
