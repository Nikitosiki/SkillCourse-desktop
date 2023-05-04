namespace SkillCourse.Panels.MainBlock.Tasks
{
    partial class PanelMainBlock_TasksForTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelMainBlock_TasksForTeacher));
            tableLayoutPanel1 = new TableLayoutPanel();
            label3 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            customComboBoxCourse = new PanelComponents.CustomComboBox();
            label15 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            customComboBoxTask = new PanelComponents.CustomComboBox();
            label1 = new Label();
            panelMain = new Panel();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 17F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.Controls.Add(label3, 1, 2);
            tableLayoutPanel1.Controls.Add(panel3, 1, 1);
            tableLayoutPanel1.Controls.Add(panelMain, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tableLayoutPanel1.Size = new Size(1012, 673);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLight;
            label3.Location = new Point(20, 70);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 3, 0, 0);
            label3.Size = new Size(963, 20);
            label3.TabIndex = 12;
            label3.Text = resources.GetString("label3.Text");
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(20, 13);
            panel3.Name = "panel3";
            panel3.Size = new Size(964, 54);
            panel3.TabIndex = 10;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(label15);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(310, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(364, 54);
            panel4.TabIndex = 10;
            // 
            // panel5
            // 
            panel5.Controls.Add(customComboBoxCourse);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(73, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(291, 54);
            panel5.TabIndex = 9;
            // 
            // customComboBoxCourse
            // 
            customComboBoxCourse.BackColor = Color.FromArgb(40, 49, 60);
            customComboBoxCourse.BorderColor = Color.FromArgb(80, 175, 138);
            customComboBoxCourse.BorderRadius = 0;
            customComboBoxCourse.BorderSize = 1;
            customComboBoxCourse.Dock = DockStyle.Fill;
            customComboBoxCourse.DropDownStyle = ComboBoxStyle.DropDown;
            customComboBoxCourse.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            customComboBoxCourse.ForeColor = SystemColors.Control;
            customComboBoxCourse.IconColor = SystemColors.Control;
            customComboBoxCourse.ListBackColor = Color.FromArgb(40, 49, 60);
            customComboBoxCourse.ListTextColor = Color.Silver;
            customComboBoxCourse.Location = new Point(0, 0);
            customComboBoxCourse.Margin = new Padding(9, 6, 0, 0);
            customComboBoxCourse.MinimumSize = new Size(125, 25);
            customComboBoxCourse.Name = "customComboBoxCourse";
            customComboBoxCourse.Padding = new Padding(1);
            customComboBoxCourse.Size = new Size(291, 54);
            customComboBoxCourse.TabIndex = 9;
            customComboBoxCourse.Texts = "All";
            customComboBoxCourse.OnSelectedIndexChanged += customComboBoxCourse_OnSelectedIndexChanged;
            // 
            // label15
            // 
            label15.Dock = DockStyle.Left;
            label15.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = SystemColors.ControlLight;
            label15.Location = new Point(0, 0);
            label15.Name = "label15";
            label15.Size = new Size(73, 54);
            label15.TabIndex = 8;
            label15.Text = "Course";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(674, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(20, 54);
            panel2.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.Controls.Add(customComboBoxTask);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(694, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 54);
            panel1.TabIndex = 11;
            // 
            // customComboBoxTask
            // 
            customComboBoxTask.BackColor = Color.FromArgb(40, 49, 60);
            customComboBoxTask.BorderColor = Color.FromArgb(80, 175, 138);
            customComboBoxTask.BorderRadius = 0;
            customComboBoxTask.BorderSize = 1;
            customComboBoxTask.Dock = DockStyle.Fill;
            customComboBoxTask.DropDownStyle = ComboBoxStyle.DropDown;
            customComboBoxTask.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            customComboBoxTask.ForeColor = SystemColors.Control;
            customComboBoxTask.IconColor = SystemColors.Control;
            customComboBoxTask.ListBackColor = Color.FromArgb(40, 49, 60);
            customComboBoxTask.ListTextColor = Color.Silver;
            customComboBoxTask.Location = new Point(0, 0);
            customComboBoxTask.Margin = new Padding(9, 6, 0, 0);
            customComboBoxTask.MinimumSize = new Size(125, 25);
            customComboBoxTask.Name = "customComboBoxTask";
            customComboBoxTask.Padding = new Padding(1);
            customComboBoxTask.Size = new Size(270, 54);
            customComboBoxTask.TabIndex = 10;
            customComboBoxTask.Texts = "All Task";
            customComboBoxTask.OnSelectedIndexChanged += customComboBoxTask_OnSelectedIndexChanged;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(20, 0, 0, 0);
            label1.Size = new Size(220, 54);
            label1.TabIndex = 9;
            label1.Text = "Assigned";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelMain
            // 
            panelMain.AutoScroll = true;
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(20, 93);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(964, 572);
            panelMain.TabIndex = 11;
            // 
            // PanelMainBlock_TasksForTeacher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 49, 60);
            Controls.Add(tableLayoutPanel1);
            Name = "PanelMainBlock_TasksForTeacher";
            Size = new Size(1012, 673);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private PanelComponents.CustomComboBox customComboBoxCourse;
        private Label label15;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panelMain;
        private Label label3;
        private Panel panel2;
        private Panel panel1;
        private PanelComponents.CustomComboBox customComboBoxTask;
    }
}
