﻿namespace SkillCourse.PanelComponents
{
    partial class Component_BriefСourse_Subscription
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
            panel2 = new Panel();
            picture_imageCourse = new PictureBox();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label_DescriptionCourse = new Label();
            label_NameCourse = new Label();
            button_SubCourse = new yt_DesignUI.NewButton();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_imageCourse).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(panel1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(935, 81);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(picture_imageCourse);
            panel2.Location = new Point(1, 11);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 0, 20, 0);
            panel2.Size = new Size(103, 67);
            panel2.TabIndex = 5;
            // 
            // picture_imageCourse
            // 
            picture_imageCourse.Image = Properties.Resources.image008;
            picture_imageCourse.Location = new Point(0, 0);
            picture_imageCourse.Name = "picture_imageCourse";
            picture_imageCourse.Size = new Size(98, 68);
            picture_imageCourse.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_imageCourse.TabIndex = 1;
            picture_imageCourse.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(button_SubCourse);
            panel1.Location = new Point(105, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(829, 68);
            panel1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label_DescriptionCourse, 0, 1);
            tableLayoutPanel1.Controls.Add(label_NameCourse, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(674, 68);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // label_DescriptionCourse
            // 
            label_DescriptionCourse.AutoSize = true;
            label_DescriptionCourse.ForeColor = SystemColors.ControlDark;
            label_DescriptionCourse.Location = new Point(3, 37);
            label_DescriptionCourse.Margin = new Padding(3, 1, 3, 0);
            label_DescriptionCourse.Name = "label_DescriptionCourse";
            label_DescriptionCourse.Size = new Size(614, 20);
            label_DescriptionCourse.TabIndex = 6;
            label_DescriptionCourse.Text = "Мета вивчення: надати студентам можливості щодо самостійного розроблення прог...";
            // 
            // label_NameCourse
            // 
            label_NameCourse.AutoSize = true;
            label_NameCourse.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label_NameCourse.ForeColor = SystemColors.Control;
            label_NameCourse.Location = new Point(3, 5);
            label_NameCourse.Margin = new Padding(3, 5, 3, 0);
            label_NameCourse.Name = "label_NameCourse";
            label_NameCourse.Size = new Size(459, 31);
            label_NameCourse.TabIndex = 5;
            label_NameCourse.Text = "Об'єктно-орієнтоване програмування (КР)";
            // 
            // button_SubCourse
            // 
            button_SubCourse.BackColor = Color.FromArgb(220, 50, 80);
            button_SubCourse.BackColorAdditional = Color.Gray;
            button_SubCourse.BackColorGradientEnabled = false;
            button_SubCourse.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            button_SubCourse.BorderColor = Color.FromArgb(80, 175, 138);
            button_SubCourse.BorderColorEnabled = false;
            button_SubCourse.BorderColorOnHover = Color.FromArgb(80, 175, 138);
            button_SubCourse.BorderColorOnHoverEnabled = false;
            button_SubCourse.Dock = DockStyle.Right;
            button_SubCourse.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button_SubCourse.ForeColor = Color.White;
            button_SubCourse.Location = new Point(674, 0);
            button_SubCourse.Margin = new Padding(0);
            button_SubCourse.Name = "button_SubCourse";
            button_SubCourse.RippleColor = Color.Black;
            button_SubCourse.RoundingEnable = false;
            button_SubCourse.Size = new Size(155, 68);
            button_SubCourse.TabIndex = 2;
            button_SubCourse.Text = "Subscribe";
            button_SubCourse.TextHover = null;
            button_SubCourse.UseDownPressEffectOnClick = false;
            button_SubCourse.UseMainGradientEffect = false;
            button_SubCourse.UseRippleEffect = false;
            button_SubCourse.UseVisualStyleBackColor = false;
            button_SubCourse.UseZoomEffectOnHover = false;
            button_SubCourse.Click += button_SubCourse_Click;
            // 
            // Component_BriefСourse_Subscription
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 49, 60);
            Controls.Add(groupBox1);
            MaximumSize = new Size(3500, 81);
            MinimumSize = new Size(500, 81);
            Name = "Component_BriefСourse_Subscription";
            Size = new Size(935, 81);
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picture_imageCourse).EndInit();
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label_DescriptionCourse;
        private Label label_NameCourse;
        private yt_DesignUI.NewButton button_SubCourse;
        private Panel panel2;
        private PictureBox picture_imageCourse;
    }
}
