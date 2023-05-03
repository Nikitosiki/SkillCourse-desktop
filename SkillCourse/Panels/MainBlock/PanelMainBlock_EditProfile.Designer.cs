using yt_DesignUI;

namespace SkillCourse.Panels.MainBlock
{
    partial class PanelMainBlock_EditProfile
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
            newButtonSave = new NewButton();
            panel11 = new Panel();
            labelName = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            backRoundPanel1 = new PanelComponents.BackRoundPanel();
            roundedButtonEditImage = new CPProject.components.ui.CustomRoundedButton();
            pictureBoxIcon = new PictureBox();
            panel3 = new Panel();
            panel6 = new Panel();
            labelMes = new Label();
            backRoundPanel3 = new PanelComponents.BackRoundPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel7 = new Panel();
            buttonChangePassword = new CPProject.components.ui.CustomRoundedButton();
            textBoxPassword = new NewGoogleTextBox();
            textBoxLastName = new NewGoogleTextBox();
            textBoxFirstName = new NewGoogleTextBox();
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            label11 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxEmail = new NewGoogleTextBox();
            textBoxPhone = new NewGoogleTextBox();
            dateTimePicker1 = new PanelComponents.CustomDateTimePicker();
            panel5 = new Panel();
            newRadioButtonMale = new NewRadioButton();
            newRadioButtonNone = new NewRadioButton();
            newRadioButtonFemale = new NewRadioButton();
            newRadioButtonOther = new NewRadioButton();
            labelContactInfo = new Label();
            panel4 = new Panel();
            backRoundPanel2 = new PanelComponents.BackRoundPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            labelLastLoginDate = new Label();
            label12 = new Label();
            panel11.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            backRoundPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
            panel6.SuspendLayout();
            backRoundPanel3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
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
            newButtonSave.Location = new Point(70, 32);
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
            // panel11
            // 
            panel11.Controls.Add(labelName);
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(0, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(1012, 73);
            panel11.TabIndex = 47;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.ForeColor = SystemColors.Control;
            labelName.Location = new Point(61, 22);
            labelName.Name = "labelName";
            labelName.Size = new Size(125, 31);
            labelName.TabIndex = 2;
            labelName.Text = "Edit Profile";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.Controls.Add(panel1, 2, 0);
            tableLayoutPanel1.Controls.Add(panel6, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 73);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1012, 600);
            tableLayoutPanel1.TabIndex = 48;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(backRoundPanel1);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(680, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(294, 574);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(newButtonSave);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 408);
            panel2.Name = "panel2";
            panel2.Size = new Size(294, 166);
            panel2.TabIndex = 1;
            // 
            // backRoundPanel1
            // 
            backRoundPanel1.Autofocus = false;
            backRoundPanel1.BackColor = Color.FromArgb(40, 49, 60);
            backRoundPanel1.BackgroundColor = Color.FromArgb(40, 49, 60);
            backRoundPanel1.BackgroundImageLayout = ImageLayout.Zoom;
            backRoundPanel1.BorderColor = Color.PaleVioletRed;
            backRoundPanel1.BorderRadius = 15;
            backRoundPanel1.BorderSize = 0;
            backRoundPanel1.Controls.Add(roundedButtonEditImage);
            backRoundPanel1.Controls.Add(pictureBoxIcon);
            backRoundPanel1.Dock = DockStyle.Top;
            backRoundPanel1.FocusBorderColor = Color.Gray;
            backRoundPanel1.FocusBorderSize = 2;
            backRoundPanel1.ForeColor = Color.White;
            backRoundPanel1.Location = new Point(0, 10);
            backRoundPanel1.Name = "backRoundPanel1";
            backRoundPanel1.Size = new Size(294, 398);
            backRoundPanel1.TabIndex = 0;
            backRoundPanel1.TextColor = Color.White;
            // 
            // roundedButtonEditImage
            // 
            roundedButtonEditImage.Autofocus = false;
            roundedButtonEditImage.BackColor = Color.FromArgb(50, 65, 80);
            roundedButtonEditImage.BackgroundColor = Color.FromArgb(50, 65, 80);
            roundedButtonEditImage.BorderColor = Color.FromArgb(50, 65, 80);
            roundedButtonEditImage.BorderRadius = 9;
            roundedButtonEditImage.BorderSize = 1;
            roundedButtonEditImage.FlatAppearance.BorderSize = 0;
            roundedButtonEditImage.FlatStyle = FlatStyle.Flat;
            roundedButtonEditImage.FocusBorderColor = Color.Gray;
            roundedButtonEditImage.FocusBorderSize = 0;
            roundedButtonEditImage.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            roundedButtonEditImage.ForeColor = SystemColors.Control;
            roundedButtonEditImage.Image = Properties.Resources.outline_brush_white_24dp;
            roundedButtonEditImage.Location = new Point(244, 6);
            roundedButtonEditImage.Margin = new Padding(0, 0, 10, 5);
            roundedButtonEditImage.Name = "roundedButtonEditImage";
            roundedButtonEditImage.Size = new Size(40, 40);
            roundedButtonEditImage.TabIndex = 4;
            roundedButtonEditImage.TextColor = SystemColors.Control;
            roundedButtonEditImage.TextImageRelation = TextImageRelation.TextBeforeImage;
            roundedButtonEditImage.UseVisualStyleBackColor = false;
            roundedButtonEditImage.Click += roundedButtonEditImage_Click;
            // 
            // pictureBoxIcon
            // 
            pictureBoxIcon.BackColor = Color.FromArgb(50, 60, 69);
            pictureBoxIcon.Dock = DockStyle.Fill;
            pictureBoxIcon.Image = Properties.Resources.default_v1_1;
            pictureBoxIcon.Location = new Point(0, 0);
            pictureBoxIcon.Name = "pictureBoxIcon";
            pictureBoxIcon.Size = new Size(294, 398);
            pictureBoxIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxIcon.TabIndex = 3;
            pictureBoxIcon.TabStop = false;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(294, 10);
            panel3.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(labelMes);
            panel6.Controls.Add(backRoundPanel3);
            panel6.Controls.Add(panel4);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(38, 3);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(20, 0, 20, 0);
            panel6.Size = new Size(636, 574);
            panel6.TabIndex = 2;
            // 
            // labelMes
            // 
            labelMes.AutoSize = true;
            labelMes.Dock = DockStyle.Left;
            labelMes.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelMes.ForeColor = Color.Brown;
            labelMes.Location = new Point(20, 408);
            labelMes.Margin = new Padding(3);
            labelMes.Name = "labelMes";
            labelMes.Padding = new Padding(0, 10, 0, 10);
            labelMes.Size = new Size(438, 38);
            labelMes.TabIndex = 44;
            labelMes.Text = "Do not write if you do not want to change your password";
            labelMes.TextAlign = ContentAlignment.BottomLeft;
            labelMes.Visible = false;
            // 
            // backRoundPanel3
            // 
            backRoundPanel3.Autofocus = false;
            backRoundPanel3.BackColor = Color.FromArgb(50, 60, 69);
            backRoundPanel3.BackgroundColor = Color.FromArgb(50, 60, 69);
            backRoundPanel3.BorderColor = Color.PaleVioletRed;
            backRoundPanel3.BorderRadius = 15;
            backRoundPanel3.BorderSize = 0;
            backRoundPanel3.Controls.Add(tableLayoutPanel3);
            backRoundPanel3.Controls.Add(labelContactInfo);
            backRoundPanel3.Dock = DockStyle.Top;
            backRoundPanel3.FocusBorderColor = Color.Gray;
            backRoundPanel3.FocusBorderSize = 2;
            backRoundPanel3.ForeColor = Color.White;
            backRoundPanel3.Location = new Point(20, 10);
            backRoundPanel3.Name = "backRoundPanel3";
            backRoundPanel3.Size = new Size(596, 398);
            backRoundPanel3.TabIndex = 12;
            backRoundPanel3.TextColor = Color.White;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(panel7, 1, 4);
            tableLayoutPanel3.Controls.Add(textBoxLastName, 1, 1);
            tableLayoutPanel3.Controls.Add(textBoxFirstName, 1, 0);
            tableLayoutPanel3.Controls.Add(label6, 0, 1);
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(label2, 0, 4);
            tableLayoutPanel3.Controls.Add(label11, 0, 6);
            tableLayoutPanel3.Controls.Add(label3, 0, 5);
            tableLayoutPanel3.Controls.Add(label4, 0, 3);
            tableLayoutPanel3.Controls.Add(label5, 0, 2);
            tableLayoutPanel3.Controls.Add(textBoxEmail, 1, 2);
            tableLayoutPanel3.Controls.Add(textBoxPhone, 1, 3);
            tableLayoutPanel3.Controls.Add(dateTimePicker1, 1, 5);
            tableLayoutPanel3.Controls.Add(panel5, 1, 6);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 29);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.Padding = new Padding(15, 0, 15, 0);
            tableLayoutPanel3.RowCount = 8;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(596, 369);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // panel7
            // 
            panel7.AutoSize = true;
            panel7.Controls.Add(buttonChangePassword);
            panel7.Controls.Add(textBoxPassword);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(218, 163);
            panel7.Name = "panel7";
            panel7.Size = new Size(360, 68);
            panel7.TabIndex = 43;
            // 
            // buttonChangePassword
            // 
            buttonChangePassword.Autofocus = false;
            buttonChangePassword.BackColor = Color.FromArgb(45, 54, 64);
            buttonChangePassword.BackgroundColor = Color.FromArgb(45, 54, 64);
            buttonChangePassword.BorderColor = Color.FromArgb(40, 49, 60);
            buttonChangePassword.BorderRadius = 10;
            buttonChangePassword.BorderSize = 0;
            buttonChangePassword.Dock = DockStyle.Top;
            buttonChangePassword.FlatAppearance.BorderSize = 0;
            buttonChangePassword.FlatStyle = FlatStyle.Flat;
            buttonChangePassword.FocusBorderColor = Color.Gray;
            buttonChangePassword.FocusBorderSize = 0;
            buttonChangePassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonChangePassword.ForeColor = Color.White;
            buttonChangePassword.Location = new Point(0, 34);
            buttonChangePassword.Margin = new Padding(0);
            buttonChangePassword.Name = "buttonChangePassword";
            buttonChangePassword.Size = new Size(360, 34);
            buttonChangePassword.TabIndex = 13;
            buttonChangePassword.Text = "Change password";
            buttonChangePassword.TextColor = Color.White;
            buttonChangePassword.UseVisualStyleBackColor = false;
            buttonChangePassword.Click += customRoundedButton1_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.FromArgb(50, 60, 69);
            textBoxPassword.BorderColor = SystemColors.ControlDarkDark;
            textBoxPassword.BorderColorNotActive = SystemColors.ControlDarkDark;
            textBoxPassword.Dock = DockStyle.Top;
            textBoxPassword.EnabledTextPreview = false;
            textBoxPassword.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.FontTextPreview = new Font("Arial", 7F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxPassword.ForeColor = SystemColors.Control;
            textBoxPassword.Location = new Point(0, 0);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.SelectionStart = 0;
            textBoxPassword.Size = new Size(360, 34);
            textBoxPassword.TabIndex = 36;
            textBoxPassword.TextInput = "";
            textBoxPassword.TextPreview = "";
            textBoxPassword.UseSystemPasswordChar = false;
            textBoxPassword.Visible = false;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            // 
            // textBoxLastName
            // 
            textBoxLastName.BackColor = Color.FromArgb(50, 60, 69);
            textBoxLastName.BorderColor = SystemColors.ControlDarkDark;
            textBoxLastName.BorderColorNotActive = SystemColors.ControlDarkDark;
            textBoxLastName.EnabledTextPreview = false;
            textBoxLastName.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLastName.FontTextPreview = new Font("Arial", 7F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxLastName.ForeColor = SystemColors.Control;
            textBoxLastName.Location = new Point(218, 43);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.SelectionStart = 0;
            textBoxLastName.Size = new Size(360, 34);
            textBoxLastName.TabIndex = 45;
            textBoxLastName.TextInput = "Savenko";
            textBoxLastName.TextPreview = "";
            textBoxLastName.UseSystemPasswordChar = false;
            textBoxLastName.TextChanged += textBoxLastName_TextChanged;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.BackColor = Color.FromArgb(50, 60, 69);
            textBoxFirstName.BorderColor = SystemColors.ControlDarkDark;
            textBoxFirstName.BorderColorNotActive = SystemColors.ControlDarkDark;
            textBoxFirstName.EnabledTextPreview = false;
            textBoxFirstName.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFirstName.FontTextPreview = new Font("Arial", 7F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxFirstName.ForeColor = SystemColors.Control;
            textBoxFirstName.Location = new Point(218, 3);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.SelectionStart = 0;
            textBoxFirstName.Size = new Size(360, 34);
            textBoxFirstName.TabIndex = 44;
            textBoxFirstName.TextInput = "Nikita";
            textBoxFirstName.TextPreview = "";
            textBoxFirstName.UseSystemPasswordChar = false;
            textBoxFirstName.TextChanged += textBoxFirstName_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(18, 40);
            label6.Name = "label6";
            label6.Size = new Size(194, 40);
            label6.TabIndex = 43;
            label6.Text = "Last:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(18, 0);
            label1.Name = "label1";
            label1.Size = new Size(194, 40);
            label1.TabIndex = 42;
            label1.Text = "First:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(18, 160);
            label2.Name = "label2";
            label2.Size = new Size(194, 74);
            label2.TabIndex = 8;
            label2.Text = "Password:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Fill;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.Control;
            label11.Location = new Point(18, 274);
            label11.Name = "label11";
            label11.Padding = new Padding(0, 8, 0, 0);
            label11.Size = new Size(194, 120);
            label11.TabIndex = 6;
            label11.Text = "Gender:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(18, 234);
            label3.Name = "label3";
            label3.Size = new Size(194, 40);
            label3.TabIndex = 5;
            label3.Text = "Date Birth:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(18, 120);
            label4.Name = "label4";
            label4.Size = new Size(194, 40);
            label4.TabIndex = 3;
            label4.Text = "Phone:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(18, 80);
            label5.Name = "label5";
            label5.Size = new Size(194, 40);
            label5.TabIndex = 0;
            label5.Text = "E-mail:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.FromArgb(50, 60, 69);
            textBoxEmail.BorderColor = SystemColors.ControlDarkDark;
            textBoxEmail.BorderColorNotActive = SystemColors.ControlDarkDark;
            textBoxEmail.EnabledTextPreview = false;
            textBoxEmail.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.FontTextPreview = new Font("Arial", 7F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxEmail.ForeColor = SystemColors.Control;
            textBoxEmail.Location = new Point(218, 83);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.SelectionStart = 0;
            textBoxEmail.Size = new Size(360, 34);
            textBoxEmail.TabIndex = 0;
            textBoxEmail.TextInput = "nikita@dot.net";
            textBoxEmail.TextPreview = "";
            textBoxEmail.UseSystemPasswordChar = false;
            textBoxEmail.TextChanged += textBoxEmail_TextChanged;
            // 
            // textBoxPhone
            // 
            textBoxPhone.BackColor = Color.FromArgb(50, 60, 69);
            textBoxPhone.BorderColor = SystemColors.ControlDarkDark;
            textBoxPhone.BorderColorNotActive = SystemColors.ControlDarkDark;
            textBoxPhone.EnabledTextPreview = false;
            textBoxPhone.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPhone.FontTextPreview = new Font("Arial", 7F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxPhone.ForeColor = SystemColors.Control;
            textBoxPhone.Location = new Point(218, 123);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.SelectionStart = 0;
            textBoxPhone.Size = new Size(360, 34);
            textBoxPhone.TabIndex = 41;
            textBoxPhone.TextInput = "not indicated";
            textBoxPhone.TextPreview = "";
            textBoxPhone.UseSystemPasswordChar = false;
            textBoxPhone.TextChanged += textBoxPhone_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.BorderColor = Color.FromArgb(77, 82, 87);
            dateTimePicker1.BorderSize = 1;
            dateTimePicker1.CalendarMonthBackground = SystemColors.ControlDarkDark;
            dateTimePicker1.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(218, 237);
            dateTimePicker1.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.MinimumSize = new Size(0, 35);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(360, 35);
            dateTimePicker1.SkinColor = Color.FromArgb(50, 60, 69);
            dateTimePicker1.SpaceBeforeText = false;
            dateTimePicker1.TabIndex = 46;
            dateTimePicker1.TextColor = SystemColors.Control;
            // 
            // panel5
            // 
            panel5.Controls.Add(newRadioButtonMale);
            panel5.Controls.Add(newRadioButtonNone);
            panel5.Controls.Add(newRadioButtonFemale);
            panel5.Controls.Add(newRadioButtonOther);
            panel5.Location = new Point(218, 277);
            panel5.Name = "panel5";
            panel5.Size = new Size(360, 114);
            panel5.TabIndex = 47;
            // 
            // newRadioButtonMale
            // 
            newRadioButtonMale.AutoSize = true;
            newRadioButtonMale.BackColor = Color.White;
            newRadioButtonMale.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            newRadioButtonMale.ForeColor = SystemColors.Control;
            newRadioButtonMale.Location = new Point(7, 31);
            newRadioButtonMale.Name = "newRadioButtonMale";
            newRadioButtonMale.Size = new Size(63, 22);
            newRadioButtonMale.TabIndex = 42;
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
            newRadioButtonNone.Location = new Point(7, 3);
            newRadioButtonNone.Name = "newRadioButtonNone";
            newRadioButtonNone.Size = new Size(68, 22);
            newRadioButtonNone.TabIndex = 41;
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
            newRadioButtonFemale.Location = new Point(7, 59);
            newRadioButtonFemale.Name = "newRadioButtonFemale";
            newRadioButtonFemale.Size = new Size(83, 22);
            newRadioButtonFemale.TabIndex = 40;
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
            newRadioButtonOther.Location = new Point(7, 87);
            newRadioButtonOther.Name = "newRadioButtonOther";
            newRadioButtonOther.Size = new Size(71, 22);
            newRadioButtonOther.TabIndex = 39;
            newRadioButtonOther.TabStop = true;
            newRadioButtonOther.Text = "Other";
            newRadioButtonOther.UseVisualStyleBackColor = false;
            // 
            // labelContactInfo
            // 
            labelContactInfo.Dock = DockStyle.Top;
            labelContactInfo.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelContactInfo.ForeColor = SystemColors.AppWorkspace;
            labelContactInfo.Location = new Point(0, 0);
            labelContactInfo.Name = "labelContactInfo";
            labelContactInfo.Padding = new Padding(13, 0, 0, 0);
            labelContactInfo.Size = new Size(596, 29);
            labelContactInfo.TabIndex = 2;
            labelContactInfo.Text = "CONTACT INFORMATION";
            labelContactInfo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(20, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(596, 10);
            panel4.TabIndex = 11;
            // 
            // backRoundPanel2
            // 
            backRoundPanel2.Autofocus = false;
            backRoundPanel2.BackColor = Color.FromArgb(50, 60, 69);
            backRoundPanel2.BackgroundColor = Color.FromArgb(50, 60, 69);
            backRoundPanel2.BorderColor = Color.PaleVioletRed;
            backRoundPanel2.BorderRadius = 5;
            backRoundPanel2.BorderSize = 0;
            backRoundPanel2.FocusBorderColor = Color.Gray;
            backRoundPanel2.FocusBorderSize = 2;
            backRoundPanel2.ForeColor = Color.White;
            backRoundPanel2.Location = new Point(0, 0);
            backRoundPanel2.Name = "backRoundPanel2";
            backRoundPanel2.Size = new Size(150, 40);
            backRoundPanel2.TabIndex = 0;
            backRoundPanel2.TextColor = Color.White;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(labelLastLoginDate, 1, 4);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // labelLastLoginDate
            // 
            labelLastLoginDate.Dock = DockStyle.Fill;
            labelLastLoginDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelLastLoginDate.ForeColor = SystemColors.Control;
            labelLastLoginDate.Location = new Point(203, 0);
            labelLastLoginDate.Name = "labelLastLoginDate";
            labelLastLoginDate.Size = new Size(1, 100);
            labelLastLoginDate.TabIndex = 9;
            labelLastLoginDate.Text = "label1";
            labelLastLoginDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Fill;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.Control;
            label12.Location = new Point(3, 0);
            label12.Name = "label12";
            label12.Padding = new Padding(10, 0, 0, 0);
            label12.Size = new Size(194, 100);
            label12.TabIndex = 8;
            label12.Text = "Last seen:";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PanelMainBlock_EditProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 49, 60);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel11);
            Name = "PanelMainBlock_EditProfile";
            Size = new Size(1012, 673);
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            backRoundPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            backRoundPanel3.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel7.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private yt_DesignUI.NewButton newButton6;
        private yt_DesignUI.NewButton newButtonSave;
        private Panel panel11;
        private Label labelName;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private PanelComponents.BackRoundPanel backRoundPanel1;
        private CPProject.components.ui.CustomRoundedButton roundedButtonEditImage;
        private PictureBox pictureBoxIcon;
        private Panel panel3;
        private Panel panel6;
        private Panel panel4;
        private PanelComponents.BackRoundPanel backRoundPanel3;
        private PanelComponents.BackRoundPanel backRoundPanel2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label labelLastLoginDate;
        private Label label12;
        private Label labelContactInfo;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label11;
        private Label label3;
        private Label label4;
        private Label label5;
        private NewGoogleTextBox textBoxEmail;
        private NewGoogleTextBox textBoxPhone;
        private NewGoogleTextBox textBoxLastName;
        private NewGoogleTextBox textBoxFirstName;
        private Label label6;
        private Label label1;
        private Label label2;
        private NewGoogleTextBox textBoxPassword;
        private PanelComponents.CustomDateTimePicker dateTimePicker1;
        private Panel panel5;
        private NewRadioButton newRadioButtonMale;
        private NewRadioButton newRadioButtonNone;
        private NewRadioButton newRadioButtonFemale;
        private NewRadioButton newRadioButtonOther;
        private Panel panel7;
        private CPProject.components.ui.CustomRoundedButton buttonChangePassword;
        private Label labelMes;
    }
}
