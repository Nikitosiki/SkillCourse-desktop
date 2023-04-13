namespace SkillCourse.Panels.MainBlock
{
    partial class PanelMainBlock_Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelMainBlock_Users));
            panelBack = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panelTeacherLabel = new Panel();
            label1 = new Label();
            label3 = new Label();
            panelStudentLabel = new Panel();
            label2 = new Label();
            label4 = new Label();
            panelTeachers = new Panel();
            label5 = new Label();
            panelStudents = new Panel();
            panelBack.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panelTeacherLabel.SuspendLayout();
            panelStudentLabel.SuspendLayout();
            panelTeachers.SuspendLayout();
            SuspendLayout();
            // 
            // panelBack
            // 
            panelBack.AutoScroll = true;
            panelBack.Controls.Add(tableLayoutPanel1);
            panelBack.Dock = DockStyle.Fill;
            panelBack.Location = new Point(0, 0);
            panelBack.Name = "panelBack";
            panelBack.Size = new Size(1012, 673);
            panelBack.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 53F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Controls.Add(panelTeacherLabel, 1, 0);
            tableLayoutPanel1.Controls.Add(panelStudentLabel, 1, 2);
            tableLayoutPanel1.Controls.Add(panelTeachers, 1, 1);
            tableLayoutPanel1.Controls.Add(panelStudents, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1012, 673);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panelTeacherLabel
            // 
            panelTeacherLabel.Controls.Add(label1);
            panelTeacherLabel.Controls.Add(label3);
            panelTeacherLabel.Dock = DockStyle.Fill;
            panelTeacherLabel.Location = new Point(56, 3);
            panelTeacherLabel.Name = "panelTeacherLabel";
            panelTeacherLabel.Size = new Size(913, 54);
            panelTeacherLabel.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Bottom;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(0, 13);
            label1.Name = "label1";
            label1.Size = new Size(102, 31);
            label1.TabIndex = 0;
            label1.Text = "Teachers\r\n";
            // 
            // label3
            // 
            label3.Dock = DockStyle.Bottom;
            label3.ForeColor = SystemColors.ControlLight;
            label3.Location = new Point(0, 44);
            label3.Name = "label3";
            label3.Size = new Size(913, 10);
            label3.TabIndex = 2;
            label3.Text = resources.GetString("label3.Text");
            // 
            // panelStudentLabel
            // 
            panelStudentLabel.Controls.Add(label2);
            panelStudentLabel.Controls.Add(label4);
            panelStudentLabel.Dock = DockStyle.Fill;
            panelStudentLabel.Location = new Point(56, 339);
            panelStudentLabel.Name = "panelStudentLabel";
            panelStudentLabel.Size = new Size(913, 54);
            panelStudentLabel.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Bottom;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(0, 13);
            label2.Name = "label2";
            label2.Size = new Size(103, 31);
            label2.TabIndex = 0;
            label2.Text = "Students";
            // 
            // label4
            // 
            label4.Dock = DockStyle.Bottom;
            label4.ForeColor = SystemColors.ControlLight;
            label4.Location = new Point(0, 44);
            label4.Name = "label4";
            label4.Size = new Size(913, 10);
            label4.TabIndex = 2;
            label4.Text = resources.GetString("label4.Text");
            // 
            // panelTeachers
            // 
            panelTeachers.AutoSize = true;
            panelTeachers.Controls.Add(label5);
            panelTeachers.Dock = DockStyle.Fill;
            panelTeachers.Location = new Point(56, 63);
            panelTeachers.Name = "panelTeachers";
            panelTeachers.Size = new Size(913, 270);
            panelTeachers.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(102, 31);
            label5.TabIndex = 1;
            label5.Text = "Teachers\r\n";
            // 
            // panelStudents
            // 
            panelStudents.AutoSize = true;
            panelStudents.Dock = DockStyle.Fill;
            panelStudents.Location = new Point(56, 399);
            panelStudents.Name = "panelStudents";
            panelStudents.Size = new Size(913, 271);
            panelStudents.TabIndex = 5;
            // 
            // PanelMainBlock_Users
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(40, 49, 60);
            Controls.Add(panelBack);
            Name = "PanelMainBlock_Users";
            Size = new Size(1012, 673);
            panelBack.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panelTeacherLabel.ResumeLayout(false);
            panelTeacherLabel.PerformLayout();
            panelStudentLabel.ResumeLayout(false);
            panelStudentLabel.PerformLayout();
            panelTeachers.ResumeLayout(false);
            panelTeachers.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBack;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Panel panelTeacherLabel;
        private Label label3;
        private Panel panelStudentLabel;
        private Label label2;
        private Label label4;
        private Panel panelTeachers;
        private Label label5;
        private Panel panelStudents;
    }
}
