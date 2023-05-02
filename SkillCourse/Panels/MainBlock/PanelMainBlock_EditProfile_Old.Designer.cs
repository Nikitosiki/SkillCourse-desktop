namespace SkillCourse.Panels.MainBlock
{
    partial class PanelMainBlock_EditProfile_Old
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
            label1 = new Label();
            panel1 = new Panel();
            textBoxLastName = new yt_DesignUI.NewGoogleTextBox();
            label7 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel9 = new Panel();
            dateTimePicker1 = new PanelComponents.CustomDateTimePicker();
            label5 = new Label();
            panel6 = new Panel();
            textBoxPassword = new yt_DesignUI.NewGoogleTextBox();
            label9 = new Label();
            panel5 = new Panel();
            textBoxPhone = new yt_DesignUI.NewGoogleTextBox();
            label8 = new Label();
            panel4 = new Panel();
            textBoxEmail = new yt_DesignUI.NewGoogleTextBox();
            label3 = new Label();
            panel2 = new Panel();
            textBoxFirstName = new yt_DesignUI.NewGoogleTextBox();
            label2 = new Label();
            labelMes = new Label();
            panel10 = new Panel();
            newRadioButtonMale = new yt_DesignUI.NewRadioButton();
            newRadioButtonNone = new yt_DesignUI.NewRadioButton();
            newRadioButtonFemale = new yt_DesignUI.NewRadioButton();
            newRadioButtonOther = new yt_DesignUI.NewRadioButton();
            label4 = new Label();
            newButtonSave = new yt_DesignUI.NewButton();
            panel3 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel9.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel10.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(29, 28);
            label1.Name = "label1";
            label1.Size = new Size(125, 31);
            label1.TabIndex = 0;
            label1.Text = "Edit Profile";
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxLastName);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(275, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(462, 64);
            panel1.TabIndex = 39;
            // 
            // textBoxLastName
            // 
            textBoxLastName.BackColor = Color.FromArgb(40, 49, 60);
            textBoxLastName.BorderColor = SystemColors.ControlDarkDark;
            textBoxLastName.BorderColorNotActive = Color.FromArgb(127, 140, 141);
            textBoxLastName.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLastName.FontTextPreview = new Font("Arial", 7F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxLastName.ForeColor = SystemColors.ControlLightLight;
            textBoxLastName.Location = new Point(0, 24);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.SelectionStart = 0;
            textBoxLastName.Size = new Size(462, 40);
            textBoxLastName.TabIndex = 34;
            textBoxLastName.TextInput = "";
            textBoxLastName.TextPreview = "";
            textBoxLastName.UseSystemPasswordChar = false;
            textBoxLastName.TextChanged += textBoxLastName_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.LightGray;
            label7.Location = new Point(0, -2);
            label7.Name = "label7";
            label7.Size = new Size(91, 23);
            label7.TabIndex = 33;
            label7.Text = "Last Name";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel9, 1, 6);
            tableLayoutPanel1.Controls.Add(panel6, 1, 5);
            tableLayoutPanel1.Controls.Add(panel5, 1, 4);
            tableLayoutPanel1.Controls.Add(panel4, 1, 3);
            tableLayoutPanel1.Controls.Add(panel2, 1, 2);
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Controls.Add(labelMes, 2, 5);
            tableLayoutPanel1.Controls.Add(panel10, 1, 7);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 63);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.Size = new Size(1012, 544);
            tableLayoutPanel1.TabIndex = 40;
            // 
            // panel9
            // 
            panel9.Controls.Add(dateTimePicker1);
            panel9.Controls.Add(label5);
            panel9.Location = new Point(275, 401);
            panel9.Name = "panel9";
            panel9.Size = new Size(462, 64);
            panel9.TabIndex = 42;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.BorderColor = Color.FromArgb(83, 95, 100);
            dateTimePicker1.BorderSize = 1;
            dateTimePicker1.CalendarMonthBackground = Color.FromArgb(127, 140, 141);
            dateTimePicker1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(3, 19);
            dateTimePicker1.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.MinimumSize = new Size(0, 35);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(456, 35);
            dateTimePicker1.SkinColor = Color.FromArgb(40, 49, 60);
            dateTimePicker1.TabIndex = 31;
            dateTimePicker1.TextColor = Color.FromArgb(127, 140, 141);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.LightGray;
            label5.Location = new Point(0, -2);
            label5.Name = "label5";
            label5.Size = new Size(108, 23);
            label5.TabIndex = 34;
            label5.Text = "Date of Birth";
            // 
            // panel6
            // 
            panel6.Controls.Add(textBoxPassword);
            panel6.Controls.Add(label9);
            panel6.Location = new Point(275, 321);
            panel6.Name = "panel6";
            panel6.Size = new Size(462, 64);
            panel6.TabIndex = 41;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.FromArgb(40, 49, 60);
            textBoxPassword.BorderColor = SystemColors.ControlDarkDark;
            textBoxPassword.BorderColorNotActive = Color.FromArgb(127, 140, 141);
            textBoxPassword.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.FontTextPreview = new Font("Arial", 7F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxPassword.ForeColor = SystemColors.ControlLightLight;
            textBoxPassword.Location = new Point(0, 24);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.SelectionStart = 0;
            textBoxPassword.Size = new Size(462, 40);
            textBoxPassword.TabIndex = 34;
            textBoxPassword.TextInput = "";
            textBoxPassword.TextPreview = "";
            textBoxPassword.UseSystemPasswordChar = false;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.LightGray;
            label9.Location = new Point(0, -2);
            label9.Name = "label9";
            label9.Size = new Size(82, 23);
            label9.TabIndex = 33;
            label9.Text = "Password";
            // 
            // panel5
            // 
            panel5.Controls.Add(textBoxPhone);
            panel5.Controls.Add(label8);
            panel5.Location = new Point(275, 241);
            panel5.Name = "panel5";
            panel5.Size = new Size(462, 64);
            panel5.TabIndex = 41;
            // 
            // textBoxPhone
            // 
            textBoxPhone.BackColor = Color.FromArgb(40, 49, 60);
            textBoxPhone.BorderColor = SystemColors.ControlDarkDark;
            textBoxPhone.BorderColorNotActive = Color.FromArgb(127, 140, 141);
            textBoxPhone.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPhone.FontTextPreview = new Font("Arial", 7F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxPhone.ForeColor = SystemColors.ControlLightLight;
            textBoxPhone.Location = new Point(0, 24);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.SelectionStart = 0;
            textBoxPhone.Size = new Size(462, 40);
            textBoxPhone.TabIndex = 34;
            textBoxPhone.TextInput = "";
            textBoxPhone.TextPreview = "";
            textBoxPhone.UseSystemPasswordChar = false;
            textBoxPhone.TextChanged += textBoxPhone_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.LightGray;
            label8.Location = new Point(0, -2);
            label8.Name = "label8";
            label8.Size = new Size(145, 23);
            label8.TabIndex = 33;
            label8.Text = "Contacts Number";
            // 
            // panel4
            // 
            panel4.Controls.Add(textBoxEmail);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(275, 161);
            panel4.Name = "panel4";
            panel4.Size = new Size(462, 64);
            panel4.TabIndex = 41;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.FromArgb(40, 49, 60);
            textBoxEmail.BorderColor = SystemColors.ControlDarkDark;
            textBoxEmail.BorderColorNotActive = Color.FromArgb(127, 140, 141);
            textBoxEmail.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.FontTextPreview = new Font("Arial", 7F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxEmail.ForeColor = SystemColors.ControlLightLight;
            textBoxEmail.Location = new Point(0, 24);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.SelectionStart = 0;
            textBoxEmail.Size = new Size(462, 40);
            textBoxEmail.TabIndex = 34;
            textBoxEmail.TextInput = "";
            textBoxEmail.TextPreview = "";
            textBoxEmail.UseSystemPasswordChar = false;
            textBoxEmail.TextChanged += textBoxEmail_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(0, -2);
            label3.Name = "label3";
            label3.Size = new Size(116, 23);
            label3.TabIndex = 33;
            label3.Text = "Email Address";
            // 
            // panel2
            // 
            panel2.Controls.Add(textBoxFirstName);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(275, 81);
            panel2.Name = "panel2";
            panel2.Size = new Size(462, 64);
            panel2.TabIndex = 40;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.BackColor = Color.FromArgb(40, 49, 60);
            textBoxFirstName.BorderColor = SystemColors.ControlDarkDark;
            textBoxFirstName.BorderColorNotActive = Color.FromArgb(127, 140, 141);
            textBoxFirstName.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFirstName.FontTextPreview = new Font("Arial", 7F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxFirstName.ForeColor = SystemColors.ControlLightLight;
            textBoxFirstName.Location = new Point(0, 24);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.SelectionStart = 0;
            textBoxFirstName.Size = new Size(462, 40);
            textBoxFirstName.TabIndex = 34;
            textBoxFirstName.TextInput = "";
            textBoxFirstName.TextPreview = "";
            textBoxFirstName.UseSystemPasswordChar = false;
            textBoxFirstName.TextChanged += textBoxFirstName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(0, -2);
            label2.Name = "label2";
            label2.Size = new Size(93, 23);
            label2.TabIndex = 33;
            label2.Text = "First Name";
            // 
            // labelMes
            // 
            labelMes.AutoSize = true;
            labelMes.Dock = DockStyle.Left;
            labelMes.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelMes.ForeColor = Color.Brown;
            labelMes.Location = new Point(743, 318);
            labelMes.Margin = new Padding(3, 0, 3, 3);
            labelMes.Name = "labelMes";
            labelMes.Padding = new Padding(0, 0, 0, 10);
            labelMes.Size = new Size(264, 77);
            labelMes.TabIndex = 43;
            labelMes.Text = "Do not write if you do not want to change your password";
            labelMes.TextAlign = ContentAlignment.BottomLeft;
            // 
            // panel10
            // 
            panel10.Controls.Add(newRadioButtonMale);
            panel10.Controls.Add(newRadioButtonNone);
            panel10.Controls.Add(newRadioButtonFemale);
            panel10.Controls.Add(newRadioButtonOther);
            panel10.Controls.Add(label4);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(275, 481);
            panel10.Name = "panel10";
            panel10.Size = new Size(462, 74);
            panel10.TabIndex = 44;
            // 
            // newRadioButtonMale
            // 
            newRadioButtonMale.AutoSize = true;
            newRadioButtonMale.BackColor = Color.White;
            newRadioButtonMale.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            newRadioButtonMale.ForeColor = SystemColors.Control;
            newRadioButtonMale.Location = new Point(300, 5);
            newRadioButtonMale.Name = "newRadioButtonMale";
            newRadioButtonMale.Size = new Size(63, 22);
            newRadioButtonMale.TabIndex = 38;
            newRadioButtonMale.TabStop = true;
            newRadioButtonMale.Text = "Male";
            newRadioButtonMale.UseVisualStyleBackColor = false;
            // 
            // newRadioButtonNone
            // 
            newRadioButtonNone.AutoSize = true;
            newRadioButtonNone.BackColor = Color.White;
            newRadioButtonNone.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            newRadioButtonNone.ForeColor = SystemColors.Control;
            newRadioButtonNone.Location = new Point(174, 5);
            newRadioButtonNone.Name = "newRadioButtonNone";
            newRadioButtonNone.Size = new Size(68, 22);
            newRadioButtonNone.TabIndex = 37;
            newRadioButtonNone.TabStop = true;
            newRadioButtonNone.Text = "None";
            newRadioButtonNone.UseVisualStyleBackColor = false;
            // 
            // newRadioButtonFemale
            // 
            newRadioButtonFemale.AutoSize = true;
            newRadioButtonFemale.BackColor = Color.White;
            newRadioButtonFemale.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            newRadioButtonFemale.ForeColor = SystemColors.Control;
            newRadioButtonFemale.Location = new Point(300, 36);
            newRadioButtonFemale.Name = "newRadioButtonFemale";
            newRadioButtonFemale.Size = new Size(83, 22);
            newRadioButtonFemale.TabIndex = 36;
            newRadioButtonFemale.TabStop = true;
            newRadioButtonFemale.Text = "Female";
            newRadioButtonFemale.UseVisualStyleBackColor = false;
            // 
            // newRadioButtonOther
            // 
            newRadioButtonOther.AutoSize = true;
            newRadioButtonOther.BackColor = Color.White;
            newRadioButtonOther.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            newRadioButtonOther.ForeColor = SystemColors.Control;
            newRadioButtonOther.Location = new Point(174, 36);
            newRadioButtonOther.Name = "newRadioButtonOther";
            newRadioButtonOther.Size = new Size(71, 22);
            newRadioButtonOther.TabIndex = 35;
            newRadioButtonOther.TabStop = true;
            newRadioButtonOther.Text = "Other";
            newRadioButtonOther.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.LightGray;
            label4.Location = new Point(0, -2);
            label4.Name = "label4";
            label4.Size = new Size(66, 23);
            label4.TabIndex = 34;
            label4.Text = "Gender";
            // 
            // newButtonSave
            // 
            newButtonSave.BackColor = Color.FromArgb(80, 175, 138);
            newButtonSave.BackColorAdditional = Color.Gray;
            newButtonSave.BackColorGradientEnabled = false;
            newButtonSave.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            newButtonSave.BorderColor = Color.FromArgb(80, 175, 138);
            newButtonSave.BorderColorEnabled = false;
            newButtonSave.BorderColorOnHover = Color.FromArgb(80, 175, 138);
            newButtonSave.BorderColorOnHoverEnabled = false;
            newButtonSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            newButtonSave.ForeColor = Color.White;
            newButtonSave.Location = new Point(34, 9);
            newButtonSave.Name = "newButtonSave";
            newButtonSave.RippleColor = Color.Black;
            newButtonSave.Rounding = 25;
            newButtonSave.RoundingEnable = true;
            newButtonSave.Size = new Size(156, 40);
            newButtonSave.TabIndex = 41;
            newButtonSave.Text = "Save";
            newButtonSave.TextHover = null;
            newButtonSave.UseDownPressEffectOnClick = false;
            newButtonSave.UseMainGradientEffect = false;
            newButtonSave.UseRippleEffect = false;
            newButtonSave.UseVisualStyleBackColor = false;
            newButtonSave.UseZoomEffectOnHover = false;
            newButtonSave.Click += newButtonSave_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1012, 63);
            panel3.TabIndex = 42;
            // 
            // panel7
            // 
            panel7.Controls.Add(panel8);
            panel7.Dock = DockStyle.Bottom;
            panel7.Location = new Point(0, 607);
            panel7.Name = "panel7";
            panel7.Size = new Size(1012, 66);
            panel7.TabIndex = 43;
            // 
            // panel8
            // 
            panel8.Controls.Add(newButtonSave);
            panel8.Dock = DockStyle.Right;
            panel8.Location = new Point(784, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(228, 66);
            panel8.TabIndex = 42;
            // 
            // PanelMainBlock_EditProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 49, 60);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel3);
            Controls.Add(panel7);
            Name = "PanelMainBlock_EditProfile";
            Size = new Size(1012, 673);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private yt_DesignUI.NewButton newButton6;
        private Panel panel1;
        private yt_DesignUI.NewGoogleTextBox textBoxLastName;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private yt_DesignUI.NewGoogleTextBox textBoxFirstName;
        private Label label2;
        private yt_DesignUI.NewButton newButtonSave;
        private Panel panel3;
        private Panel panel6;
        private yt_DesignUI.NewGoogleTextBox textBoxPassword;
        private Label label9;
        private Panel panel5;
        private yt_DesignUI.NewGoogleTextBox textBoxPhone;
        private Label label8;
        private Panel panel4;
        private yt_DesignUI.NewGoogleTextBox textBoxEmail;
        private Label label3;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Label labelMes;
        private Panel panel10;
        private yt_DesignUI.NewRadioButton newRadioButtonMale;
        private yt_DesignUI.NewRadioButton newRadioButtonNone;
        private yt_DesignUI.NewRadioButton newRadioButtonFemale;
        private yt_DesignUI.NewRadioButton newRadioButtonOther;
        private Label label4;
        private PanelComponents.CustomDateTimePicker dateTimePicker1;
        private Label label5;
    }
}
