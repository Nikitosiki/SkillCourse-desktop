namespace SkillCourse.PanelComponents.CoursePage
{
    partial class Component_TaskForTeacher
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
            panelIndex = new Panel();
            labelId = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            labelDate = new Label();
            panelText = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            labelText = new Label();
            panelIndex.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panelText.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // panelIndex
            // 
            panelIndex.AutoSize = true;
            panelIndex.Controls.Add(labelId);
            panelIndex.Dock = DockStyle.Left;
            panelIndex.Location = new Point(0, 0);
            panelIndex.Name = "panelIndex";
            panelIndex.Size = new Size(83, 112);
            panelIndex.TabIndex = 9;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Dock = DockStyle.Left;
            labelId.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelId.ForeColor = SystemColors.Control;
            labelId.Location = new Point(0, 0);
            labelId.MinimumSize = new Size(83, 0);
            labelId.Name = "labelId";
            labelId.Padding = new Padding(0, 30, 0, 0);
            labelId.Size = new Size(83, 71);
            labelId.TabIndex = 4;
            labelId.Text = "#1";
            labelId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(labelDate, 0, 2);
            tableLayoutPanel3.Controls.Add(panelText, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(83, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(929, 112);
            tableLayoutPanel3.TabIndex = 11;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI Variable Display", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelDate.ForeColor = SystemColors.ControlDark;
            labelDate.Location = new Point(5, 70);
            labelDate.Margin = new Padding(5, 0, 3, 0);
            labelDate.Name = "labelDate";
            labelDate.Padding = new Padding(21, 0, 0, 0);
            labelDate.Size = new Size(141, 22);
            labelDate.TabIndex = 9;
            labelDate.Text = "(22 мая 2023г.)";
            // 
            // panelText
            // 
            panelText.Controls.Add(tableLayoutPanel4);
            panelText.Dock = DockStyle.Top;
            panelText.Location = new Point(3, 23);
            panelText.Name = "panelText";
            panelText.Size = new Size(923, 44);
            panelText.TabIndex = 10;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.AutoSize = true;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(labelText, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Top;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.Size = new Size(923, 31);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Dock = DockStyle.Top;
            labelText.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelText.ForeColor = SystemColors.Control;
            labelText.Location = new Point(3, 0);
            labelText.Name = "labelText";
            labelText.Padding = new Padding(18, 0, 0, 0);
            labelText.Size = new Size(917, 31);
            labelText.TabIndex = 10;
            labelText.Text = "Пояснювальна записка до курсової роботи";
            labelText.TextChanged += labelText_TextChanged;
            // 
            // Component_TaskForTeacher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 49, 60);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(panelIndex);
            Name = "Component_TaskForTeacher";
            Size = new Size(1012, 112);
            panelIndex.ResumeLayout(false);
            panelIndex.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panelText.ResumeLayout(false);
            panelText.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelIndex;
        private Label labelId;
        private TableLayoutPanel tableLayoutPanel3;
        private Label labelDate;
        private Panel panelText;
        private TableLayoutPanel tableLayoutPanel4;
        private Label labelText;
    }
}
