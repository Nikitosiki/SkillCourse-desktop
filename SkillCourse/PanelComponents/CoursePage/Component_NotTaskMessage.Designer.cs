namespace SkillCourse.PanelComponents.CoursePage
{
    partial class Component_NotTaskMessage
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
            labelName = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.ForeColor = SystemColors.Control;
            labelName.Location = new Point(0, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(297, 31);
            labelName.TabIndex = 3;
            labelName.Text = "There's nothing here(";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1012, 407);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(labelName);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(356, 188);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 31);
            panel1.TabIndex = 0;
            // 
            // Component_NotTaskMessage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(40, 49, 60);
            Controls.Add(tableLayoutPanel1);
            MaximumSize = new Size(4000, 407);
            Name = "Component_NotTaskMessage";
            Size = new Size(1012, 407);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label labelName;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
    }
}
