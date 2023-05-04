namespace SkillCourse.PanelComponents.AnswerTaskComponent
{
    partial class Component_Grade
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
            panelBall = new Panel();
            label1 = new Label();
            label2 = new Label();
            labelGrade = new Label();
            panelBall.SuspendLayout();
            SuspendLayout();
            // 
            // panelBall
            // 
            panelBall.Controls.Add(label1);
            panelBall.Controls.Add(label2);
            panelBall.Controls.Add(labelGrade);
            panelBall.Location = new Point(0, 0);
            panelBall.Name = "panelBall";
            panelBall.Size = new Size(63, 42);
            panelBall.TabIndex = 12;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(34, 17);
            label1.Name = "label1";
            label1.Size = new Size(13, 25);
            label1.TabIndex = 8;
            label1.Text = "/";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(40, 19);
            label2.Name = "label2";
            label2.Size = new Size(15, 20);
            label2.TabIndex = 9;
            label2.Text = "5";
            // 
            // labelGrade
            // 
            labelGrade.AutoSize = true;
            labelGrade.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            labelGrade.ForeColor = SystemColors.Control;
            labelGrade.Location = new Point(3, -5);
            labelGrade.Name = "labelGrade";
            labelGrade.Size = new Size(42, 50);
            labelGrade.TabIndex = 7;
            labelGrade.Text = "0";
            labelGrade.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Component_Grade
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panelBall);
            Margin = new Padding(0);
            MinimumSize = new Size(63, 42);
            Name = "Component_Grade";
            Size = new Size(63, 42);
            panelBall.ResumeLayout(false);
            panelBall.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBall;
        private Label label1;
        private Label label2;
        private Label labelGrade;
    }
}
