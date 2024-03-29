﻿namespace SkillCourse.Panels
{
    partial class PanelAutorization_SingUp
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
            newButtonSingUp = new yt_DesignUI.NewButton();
            TextBoxPassword = new yt_DesignUI.NewGoogleTextBox();
            TextBoxEmail = new yt_DesignUI.NewGoogleTextBox();
            TextBoxLastName = new yt_DesignUI.NewGoogleTextBox();
            TextBoxFirstName = new yt_DesignUI.NewGoogleTextBox();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            newRadioButtonT = new yt_DesignUI.NewRadioButton();
            newRadioButtonS = new yt_DesignUI.NewRadioButton();
            labelMesError = new Label();
            label3 = new Label();
            DateTimeBirthD = new PanelComponents.CustomDateTimePicker();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // newButtonSingUp
            // 
            newButtonSingUp.BackColor = Color.FromArgb(80, 175, 138);
            newButtonSingUp.BackColorAdditional = Color.Gray;
            newButtonSingUp.BackColorGradientEnabled = false;
            newButtonSingUp.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            newButtonSingUp.BorderColor = Color.FromArgb(80, 175, 138);
            newButtonSingUp.BorderColorEnabled = false;
            newButtonSingUp.BorderColorOnHover = Color.FromArgb(80, 175, 138);
            newButtonSingUp.BorderColorOnHoverEnabled = false;
            newButtonSingUp.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            newButtonSingUp.ForeColor = Color.White;
            newButtonSingUp.Location = new Point(42, 408);
            newButtonSingUp.Name = "newButtonSingUp";
            newButtonSingUp.RippleColor = Color.Black;
            newButtonSingUp.RoundingEnable = false;
            newButtonSingUp.Size = new Size(462, 59);
            newButtonSingUp.TabIndex = 22;
            newButtonSingUp.Text = "Sing Up";
            newButtonSingUp.TextHover = null;
            newButtonSingUp.UseDownPressEffectOnClick = false;
            newButtonSingUp.UseMainGradientEffect = false;
            newButtonSingUp.UseRippleEffect = true;
            newButtonSingUp.UseVisualStyleBackColor = false;
            newButtonSingUp.UseZoomEffectOnHover = false;
            newButtonSingUp.Click += newButtonSingUp_Click;
            // 
            // TextBoxPassword
            // 
            TextBoxPassword.BackColor = Color.FromArgb(40, 49, 60);
            TextBoxPassword.BorderColor = SystemColors.ControlDarkDark;
            TextBoxPassword.BorderColorNotActive = Color.FromArgb(127, 140, 141);
            TextBoxPassword.EnabledTextPreview = true;
            TextBoxPassword.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxPassword.FontTextPreview = new Font("Arial", 7F, FontStyle.Bold, GraphicsUnit.Point);
            TextBoxPassword.ForeColor = SystemColors.ControlLight;
            TextBoxPassword.Location = new Point(0, 211);
            TextBoxPassword.Name = "TextBoxPassword";
            TextBoxPassword.SelectionStart = 0;
            TextBoxPassword.Size = new Size(462, 44);
            TextBoxPassword.TabIndex = 21;
            TextBoxPassword.TextInput = "";
            TextBoxPassword.TextPreview = "Set A Password";
            TextBoxPassword.UseSystemPasswordChar = false;
            TextBoxPassword.TextChanged += TextBoxPassword_TextChanged;
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.BackColor = Color.FromArgb(40, 49, 60);
            TextBoxEmail.BorderColor = SystemColors.ControlDarkDark;
            TextBoxEmail.BorderColorNotActive = Color.FromArgb(127, 140, 141);
            TextBoxEmail.EnabledTextPreview = true;
            TextBoxEmail.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxEmail.FontTextPreview = new Font("Arial", 7F, FontStyle.Bold, GraphicsUnit.Point);
            TextBoxEmail.ForeColor = SystemColors.ControlLight;
            TextBoxEmail.Location = new Point(0, 152);
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.SelectionStart = 0;
            TextBoxEmail.Size = new Size(462, 44);
            TextBoxEmail.TabIndex = 20;
            TextBoxEmail.TextInput = "";
            TextBoxEmail.TextPreview = "Email Address";
            TextBoxEmail.UseSystemPasswordChar = false;
            TextBoxEmail.TextChanged += TextBoxEmail_TextChanged;
            // 
            // TextBoxLastName
            // 
            TextBoxLastName.BackColor = Color.FromArgb(40, 49, 60);
            TextBoxLastName.BorderColor = SystemColors.ControlDarkDark;
            TextBoxLastName.BorderColorNotActive = Color.FromArgb(127, 140, 141);
            TextBoxLastName.EnabledTextPreview = true;
            TextBoxLastName.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxLastName.FontTextPreview = new Font("Arial", 7F, FontStyle.Bold, GraphicsUnit.Point);
            TextBoxLastName.ForeColor = SystemColors.ControlLight;
            TextBoxLastName.Location = new Point(243, 87);
            TextBoxLastName.Name = "TextBoxLastName";
            TextBoxLastName.SelectionStart = 0;
            TextBoxLastName.Size = new Size(219, 44);
            TextBoxLastName.TabIndex = 19;
            TextBoxLastName.TextInput = "";
            TextBoxLastName.TextPreview = "Last Name";
            TextBoxLastName.UseSystemPasswordChar = false;
            TextBoxLastName.TextChanged += TextBoxLastName_TextChanged;
            // 
            // TextBoxFirstName
            // 
            TextBoxFirstName.BackColor = Color.FromArgb(40, 49, 60);
            TextBoxFirstName.BorderColor = SystemColors.ControlDarkDark;
            TextBoxFirstName.BorderColorNotActive = Color.FromArgb(127, 140, 141);
            TextBoxFirstName.EnabledTextPreview = true;
            TextBoxFirstName.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxFirstName.FontTextPreview = new Font("Arial", 7F, FontStyle.Bold, GraphicsUnit.Point);
            TextBoxFirstName.ForeColor = SystemColors.ControlLight;
            TextBoxFirstName.Location = new Point(0, 87);
            TextBoxFirstName.Name = "TextBoxFirstName";
            TextBoxFirstName.SelectionStart = 0;
            TextBoxFirstName.Size = new Size(218, 44);
            TextBoxFirstName.TabIndex = 18;
            TextBoxFirstName.TextInput = "";
            TextBoxFirstName.TextPreview = "First Name";
            TextBoxFirstName.UseSystemPasswordChar = false;
            TextBoxFirstName.TextChanged += TextBoxFirstName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(174, 21);
            label1.Name = "label1";
            label1.Size = new Size(114, 38);
            label1.TabIndex = 17;
            label1.Text = "Sing Up";
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.FromArgb(102, 104, 197);
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.FromArgb(102, 104, 197);
            linkLabel1.Location = new Point(320, 381);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(142, 20);
            linkLabel1.TabIndex = 24;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign up as a teacher";
            linkLabel1.Visible = false;
            linkLabel1.VisitedLinkColor = Color.FromArgb(102, 104, 197);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(127, 140, 141);
            label2.Location = new Point(11, 346);
            label2.Name = "label2";
            label2.Size = new Size(167, 23);
            label2.TabIndex = 25;
            label2.Text = "Select Your Position?";
            // 
            // newRadioButtonT
            // 
            newRadioButtonT.BackColor = Color.White;
            newRadioButtonT.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            newRadioButtonT.ForeColor = SystemColors.ControlLight;
            newRadioButtonT.Location = new Point(196, 346);
            newRadioButtonT.Name = "newRadioButtonT";
            newRadioButtonT.Size = new Size(103, 23);
            newRadioButtonT.TabIndex = 26;
            newRadioButtonT.Text = " Teacher";
            newRadioButtonT.UseVisualStyleBackColor = false;
            newRadioButtonT.CheckedChanged += DateTimeBirthD_ValueChanged;
            // 
            // newRadioButtonS
            // 
            newRadioButtonS.BackColor = Color.White;
            newRadioButtonS.Checked = true;
            newRadioButtonS.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            newRadioButtonS.ForeColor = SystemColors.ControlLight;
            newRadioButtonS.Location = new Point(311, 346);
            newRadioButtonS.Name = "newRadioButtonS";
            newRadioButtonS.Size = new Size(103, 23);
            newRadioButtonS.TabIndex = 27;
            newRadioButtonS.TabStop = true;
            newRadioButtonS.Text = " Student";
            newRadioButtonS.UseVisualStyleBackColor = false;
            newRadioButtonS.CheckedChanged += DateTimeBirthD_ValueChanged;
            // 
            // labelMesError
            // 
            labelMesError.AutoSize = true;
            labelMesError.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelMesError.ForeColor = Color.Brown;
            labelMesError.Location = new Point(11, 381);
            labelMesError.Name = "labelMesError";
            labelMesError.Size = new Size(75, 18);
            labelMesError.TabIndex = 28;
            labelMesError.Text = "Incorrect";
            labelMesError.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(127, 140, 141);
            label3.Location = new Point(0, 268);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 29;
            label3.Text = "Date of Birth";
            // 
            // DateTimeBirthD
            // 
            DateTimeBirthD.BorderColor = Color.FromArgb(83, 95, 100);
            DateTimeBirthD.BorderSize = 1;
            DateTimeBirthD.CalendarMonthBackground = Color.FromArgb(127, 140, 141);
            DateTimeBirthD.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            DateTimeBirthD.Format = DateTimePickerFormat.Long;
            DateTimeBirthD.Location = new Point(0, 289);
            DateTimeBirthD.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            DateTimeBirthD.MinimumSize = new Size(0, 35);
            DateTimeBirthD.Name = "DateTimeBirthD";
            DateTimeBirthD.Size = new Size(462, 35);
            DateTimeBirthD.SkinColor = Color.FromArgb(40, 49, 60);
            DateTimeBirthD.SpaceBeforeText = true;
            DateTimeBirthD.TabIndex = 30;
            DateTimeBirthD.TextColor = Color.FromArgb(127, 140, 141);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(newButtonSingUp, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.Size = new Size(550, 500);
            tableLayoutPanel1.TabIndex = 31;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(DateTimeBirthD);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(labelMesError);
            panel1.Controls.Add(TextBoxFirstName);
            panel1.Controls.Add(newRadioButtonS);
            panel1.Controls.Add(TextBoxLastName);
            panel1.Controls.Add(newRadioButtonT);
            panel1.Controls.Add(TextBoxEmail);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(TextBoxPassword);
            panel1.Controls.Add(linkLabel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(42, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(465, 401);
            panel1.TabIndex = 0;
            // 
            // PanelAutorization_SingUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(40, 49, 60);
            Controls.Add(tableLayoutPanel1);
            DoubleBuffered = true;
            Name = "PanelAutorization_SingUp";
            Size = new Size(550, 500);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker DateTimeBirth;
        private yt_DesignUI.NewButton newButtonSingUp;
        private yt_DesignUI.NewGoogleTextBox TextBoxPassword;
        private yt_DesignUI.NewGoogleTextBox TextBoxEmail;
        private yt_DesignUI.NewGoogleTextBox TextBoxLastName;
        private yt_DesignUI.NewGoogleTextBox TextBoxFirstName;
        private Label label1;
        private LinkLabel linkLabel1;
        private Label label2;
        private yt_DesignUI.NewRadioButton newRadioButtonT;
        private yt_DesignUI.NewRadioButton newRadioButtonS;
        private Label labelMesError;
        private Label label3;
        private PanelComponents.CustomDateTimePicker DateTimeBirthD;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
    }
}
