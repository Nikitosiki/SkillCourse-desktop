﻿namespace SkillCourse.Panels.MainBlock.CertificatePage
{
    partial class Component_newCertificate
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
            components = new System.ComponentModel.Container();
            labelCEO = new Label();
            labelOwner = new Label();
            labelTeacher = new Label();
            panelLabelOwner = new Panel();
            panelTeacher = new Panel();
            panelTextCourse = new Panel();
            labelText = new Label();
            labelNumber = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            roundButtonPrint = new CPProject.components.ui.CustomRoundedButton();
            panelLabelOwner.SuspendLayout();
            panelTeacher.SuspendLayout();
            panelTextCourse.SuspendLayout();
            SuspendLayout();
            // 
            // labelCEO
            // 
            labelCEO.AutoSize = true;
            labelCEO.BackColor = Color.White;
            labelCEO.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCEO.ForeColor = SystemColors.ControlText;
            labelCEO.Location = new Point(169, 467);
            labelCEO.Name = "labelCEO";
            labelCEO.Size = new Size(131, 22);
            labelCEO.TabIndex = 0;
            labelCEO.Text = "Savenko Nikita";
            // 
            // labelOwner
            // 
            labelOwner.BackColor = Color.White;
            labelOwner.Dock = DockStyle.Fill;
            labelOwner.Font = new Font("Script MT Bold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelOwner.ForeColor = SystemColors.ControlText;
            labelOwner.Location = new Point(0, 0);
            labelOwner.Name = "labelOwner";
            labelOwner.Size = new Size(568, 49);
            labelOwner.TabIndex = 1;
            labelOwner.Text = "Taya Romanovskaya";
            labelOwner.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTeacher
            // 
            labelTeacher.BackColor = Color.White;
            labelTeacher.Dock = DockStyle.Fill;
            labelTeacher.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTeacher.ForeColor = SystemColors.ControlText;
            labelTeacher.Location = new Point(0, 0);
            labelTeacher.Name = "labelTeacher";
            labelTeacher.Size = new Size(148, 71);
            labelTeacher.TabIndex = 2;
            labelTeacher.Text = "Savenko Nikita";
            labelTeacher.TextAlign = ContentAlignment.BottomLeft;
            // 
            // panelLabelOwner
            // 
            panelLabelOwner.Controls.Add(labelOwner);
            panelLabelOwner.Location = new Point(146, 346);
            panelLabelOwner.Name = "panelLabelOwner";
            panelLabelOwner.Size = new Size(568, 49);
            panelLabelOwner.TabIndex = 3;
            // 
            // panelTeacher
            // 
            panelTeacher.Controls.Add(labelTeacher);
            panelTeacher.Location = new Point(566, 418);
            panelTeacher.Name = "panelTeacher";
            panelTeacher.Size = new Size(148, 71);
            panelTeacher.TabIndex = 5;
            // 
            // panelTextCourse
            // 
            panelTextCourse.Controls.Add(labelText);
            panelTextCourse.Location = new Point(146, 201);
            panelTextCourse.Name = "panelTextCourse";
            panelTextCourse.Size = new Size(568, 66);
            panelTextCourse.TabIndex = 6;
            // 
            // labelText
            // 
            labelText.Dock = DockStyle.Fill;
            labelText.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelText.Location = new Point(0, 0);
            labelText.Name = "labelText";
            labelText.Size = new Size(568, 66);
            labelText.TabIndex = 0;
            labelText.Text = "\"Обьектно ориентированное программирование\"\r\n\r\n\r\n";
            labelText.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelNumber
            // 
            labelNumber.AutoSize = true;
            labelNumber.Font = new Font("Verdana", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelNumber.Location = new Point(169, 543);
            labelNumber.Name = "labelNumber";
            labelNumber.Size = new Size(357, 16);
            labelNumber.TabIndex = 7;
            labelNumber.Text = "№ ABC1-VN23-JG99-SDSA-78QA-MN0P / 12.12.2023\r\n";
            // 
            // roundButtonPrint
            // 
            roundButtonPrint.Autofocus = false;
            roundButtonPrint.BackColor = Color.White;
            roundButtonPrint.BackgroundColor = Color.White;
            roundButtonPrint.BorderColor = Color.White;
            roundButtonPrint.BorderRadius = 10;
            roundButtonPrint.BorderSize = 0;
            roundButtonPrint.FlatAppearance.BorderSize = 0;
            roundButtonPrint.FlatStyle = FlatStyle.Flat;
            roundButtonPrint.FocusBorderColor = Color.Gray;
            roundButtonPrint.FocusBorderSize = 2;
            roundButtonPrint.ForeColor = Color.White;
            roundButtonPrint.Image = Properties.Resources.printer;
            roundButtonPrint.Location = new Point(747, 507);
            roundButtonPrint.Margin = new Padding(0);
            roundButtonPrint.Name = "roundButtonPrint";
            roundButtonPrint.Size = new Size(52, 43);
            roundButtonPrint.TabIndex = 9;
            roundButtonPrint.TextColor = Color.White;
            roundButtonPrint.UseVisualStyleBackColor = false;
            roundButtonPrint.Click += buttonPrint_Click;
            // 
            // Component_newCertificate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.CompressedCertificate_860x6112;
            Controls.Add(roundButtonPrint);
            Controls.Add(labelNumber);
            Controls.Add(panelTextCourse);
            Controls.Add(panelLabelOwner);
            Controls.Add(labelCEO);
            Controls.Add(panelTeacher);
            Name = "Component_newCertificate";
            Size = new Size(860, 611);
            MouseMove += Component_newCertificate_MouseMove;
            panelLabelOwner.ResumeLayout(false);
            panelTeacher.ResumeLayout(false);
            panelTextCourse.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCEO;
        private Label labelOwner;
        private Label labelTeacher;
        private Panel panelLabelOwner;
        private Panel panelTeacher;
        private Panel panelTextCourse;
        private Label labelText;
        private Label labelNumber;
        private System.Windows.Forms.Timer timer1;
        private CPProject.components.ui.CustomRoundedButton roundButtonPrint;
    }
}
