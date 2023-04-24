namespace SkillCourse.PanelComponents
{
    partial class Component_BriefСourse_Base
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
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            picture_imageCourse = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label_DescriptionCourse = new Label();
            label_NameCourse = new Label();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_imageCourse).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(935, 81);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(picture_imageCourse);
            panel1.Location = new Point(3, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(931, 68);
            panel1.TabIndex = 0;
            // 
            // picture_imageCourse
            // 
            picture_imageCourse.Dock = DockStyle.Left;
            picture_imageCourse.Image = Properties.Resources.image008;
            picture_imageCourse.Location = new Point(0, 0);
            picture_imageCourse.Name = "picture_imageCourse";
            picture_imageCourse.Size = new Size(131, 68);
            picture_imageCourse.SizeMode = PictureBoxSizeMode.Zoom;
            picture_imageCourse.TabIndex = 1;
            picture_imageCourse.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label_DescriptionCourse, 0, 1);
            tableLayoutPanel1.Controls.Add(label_NameCourse, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(131, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(800, 68);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // label_DescriptionCourse
            // 
            label_DescriptionCourse.AutoSize = true;
            label_DescriptionCourse.Dock = DockStyle.Fill;
            label_DescriptionCourse.ForeColor = SystemColors.ControlDark;
            label_DescriptionCourse.Location = new Point(3, 37);
            label_DescriptionCourse.Margin = new Padding(3, 1, 3, 0);
            label_DescriptionCourse.Name = "label_DescriptionCourse";
            label_DescriptionCourse.Padding = new Padding(0, 0, 5, 0);
            label_DescriptionCourse.Size = new Size(794, 31);
            label_DescriptionCourse.TabIndex = 6;
            label_DescriptionCourse.Text = "Мета вивчення: надати студентам можливості щодо самостійного розроблення прог...";
            // 
            // label_NameCourse
            // 
            label_NameCourse.AutoSize = true;
            label_NameCourse.Dock = DockStyle.Fill;
            label_NameCourse.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label_NameCourse.ForeColor = SystemColors.Control;
            label_NameCourse.Location = new Point(3, 5);
            label_NameCourse.Margin = new Padding(3, 5, 3, 0);
            label_NameCourse.Name = "label_NameCourse";
            label_NameCourse.Padding = new Padding(0, 0, 5, 0);
            label_NameCourse.Size = new Size(794, 31);
            label_NameCourse.TabIndex = 5;
            label_NameCourse.Text = "Об'єктно-орієнтоване програмування (КР)";
            // 
            // Component_BriefСourse_Base
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 49, 60);
            Controls.Add(groupBox1);
            MaximumSize = new Size(3500, 81);
            MinimumSize = new Size(500, 81);
            Name = "Component_BriefСourse_Base";
            Size = new Size(935, 81);
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picture_imageCourse).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Panel panel1;
        private PictureBox picture_imageCourse;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label_DescriptionCourse;
        private Label label_NameCourse;
    }
}
