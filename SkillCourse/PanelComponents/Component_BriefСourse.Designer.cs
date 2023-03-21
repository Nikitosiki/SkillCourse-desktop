namespace SkillCourse.PanelComponents
{
    partial class Component_BriefСourse
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
            label_DescriptionCourse = new Label();
            button_ViewCourse = new yt_DesignUI.NewButton();
            label_NameCourse = new Label();
            picture_imageCourse = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_imageCourse).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label_DescriptionCourse);
            groupBox1.Controls.Add(button_ViewCourse);
            groupBox1.Controls.Add(label_NameCourse);
            groupBox1.Controls.Add(picture_imageCourse);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(935, 81);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // label_DescriptionCourse
            // 
            label_DescriptionCourse.AutoSize = true;
            label_DescriptionCourse.ForeColor = SystemColors.ControlDark;
            label_DescriptionCourse.Location = new Point(160, 51);
            label_DescriptionCourse.Name = "label_DescriptionCourse";
            label_DescriptionCourse.Size = new Size(614, 20);
            label_DescriptionCourse.TabIndex = 3;
            label_DescriptionCourse.Text = "Мета вивчення: надати студентам можливості щодо самостійного розроблення прог...";
            // 
            // button_ViewCourse
            // 
            button_ViewCourse.BackColor = Color.FromArgb(80, 175, 138);
            button_ViewCourse.BackColorAdditional = Color.Gray;
            button_ViewCourse.BackColorGradientEnabled = false;
            button_ViewCourse.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            button_ViewCourse.BorderColor = Color.FromArgb(80, 175, 138);
            button_ViewCourse.BorderColorEnabled = false;
            button_ViewCourse.BorderColorOnHover = Color.FromArgb(80, 175, 138);
            button_ViewCourse.BorderColorOnHoverEnabled = false;
            button_ViewCourse.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button_ViewCourse.ForeColor = Color.White;
            button_ViewCourse.Location = new Point(780, 11);
            button_ViewCourse.Name = "button_ViewCourse";
            button_ViewCourse.RippleColor = Color.Black;
            button_ViewCourse.RoundingEnable = false;
            button_ViewCourse.Size = new Size(155, 69);
            button_ViewCourse.TabIndex = 2;
            button_ViewCourse.Text = "View";
            button_ViewCourse.TextHover = null;
            button_ViewCourse.UseDownPressEffectOnClick = false;
            button_ViewCourse.UseMainGradientEffect = false;
            button_ViewCourse.UseRippleEffect = false;
            button_ViewCourse.UseVisualStyleBackColor = false;
            button_ViewCourse.UseZoomEffectOnHover = false;
            button_ViewCourse.Click += button_ViewCourse_Click;
            // 
            // label_NameCourse
            // 
            label_NameCourse.AutoSize = true;
            label_NameCourse.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label_NameCourse.ForeColor = SystemColors.Control;
            label_NameCourse.Location = new Point(153, 13);
            label_NameCourse.Name = "label_NameCourse";
            label_NameCourse.Size = new Size(459, 31);
            label_NameCourse.TabIndex = 1;
            label_NameCourse.Text = "Об'єктно-орієнтоване програмування (КР)";
            // 
            // picture_imageCourse
            // 
            picture_imageCourse.Image = Properties.Resources.image008;
            picture_imageCourse.Location = new Point(6, 11);
            picture_imageCourse.Name = "picture_imageCourse";
            picture_imageCourse.Size = new Size(131, 68);
            picture_imageCourse.SizeMode = PictureBoxSizeMode.Zoom;
            picture_imageCourse.TabIndex = 0;
            picture_imageCourse.TabStop = false;
            // 
            // Component_BriefСourse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 49, 60);
            Controls.Add(groupBox1);
            MaximumSize = new Size(3500, 81);
            Name = "Component_BriefСourse";
            Size = new Size(935, 81);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picture_imageCourse).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label_DescriptionCourse;
        private yt_DesignUI.NewButton button_ViewCourse;
        private Label label_NameCourse;
        private PictureBox picture_imageCourse;
    }
}
