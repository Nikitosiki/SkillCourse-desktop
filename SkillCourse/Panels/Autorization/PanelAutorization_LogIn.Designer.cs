namespace SkillCourse.Panels
{
    partial class PanelAutorization_LogIn
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
            newButton2 = new yt_DesignUI.NewButton();
            newGoogleTextBox4 = new yt_DesignUI.NewGoogleTextBox();
            newGoogleTextBox3 = new yt_DesignUI.NewGoogleTextBox();
            label1 = new Label();
            labelMesError = new Label();
            buttonHidePassword = new Button();
            SuspendLayout();
            // 
            // newButton2
            // 
            newButton2.BackColor = Color.FromArgb(80, 175, 138);
            newButton2.BackColorAdditional = Color.Gray;
            newButton2.BackColorGradientEnabled = false;
            newButton2.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            newButton2.BorderColor = Color.FromArgb(80, 175, 138);
            newButton2.BorderColorEnabled = false;
            newButton2.BorderColorOnHover = Color.FromArgb(80, 175, 138);
            newButton2.BorderColorOnHoverEnabled = false;
            newButton2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            newButton2.ForeColor = Color.White;
            newButton2.Location = new Point(44, 415);
            newButton2.Name = "newButton2";
            newButton2.RippleColor = Color.Black;
            newButton2.RoundingEnable = false;
            newButton2.Size = new Size(462, 59);
            newButton2.TabIndex = 15;
            newButton2.Text = "Log In";
            newButton2.TextHover = null;
            newButton2.UseDownPressEffectOnClick = false;
            newButton2.UseMainGradientEffect = false;
            newButton2.UseRippleEffect = true;
            newButton2.UseVisualStyleBackColor = false;
            newButton2.UseZoomEffectOnHover = false;
            newButton2.Click += newButton2_Click;
            // 
            // newGoogleTextBox4
            // 
            newGoogleTextBox4.BackColor = Color.FromArgb(40, 49, 60);
            newGoogleTextBox4.BorderColor = SystemColors.ControlDarkDark;
            newGoogleTextBox4.BorderColorNotActive = Color.FromArgb(127, 140, 141);
            newGoogleTextBox4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            newGoogleTextBox4.FontTextPreview = new Font("Arial", 7F, FontStyle.Bold, GraphicsUnit.Point);
            newGoogleTextBox4.ForeColor = SystemColors.ControlLight;
            newGoogleTextBox4.Location = new Point(44, 162);
            newGoogleTextBox4.Name = "newGoogleTextBox4";
            newGoogleTextBox4.SelectionStart = 0;
            newGoogleTextBox4.Size = new Size(462, 44);
            newGoogleTextBox4.TabIndex = 14;
            newGoogleTextBox4.TextInput = "";
            newGoogleTextBox4.TextPreview = "Set A Password";
            newGoogleTextBox4.UseSystemPasswordChar = true;
            // 
            // newGoogleTextBox3
            // 
            newGoogleTextBox3.BackColor = Color.FromArgb(40, 49, 60);
            newGoogleTextBox3.BorderColor = SystemColors.ControlDarkDark;
            newGoogleTextBox3.BorderColorNotActive = Color.FromArgb(127, 140, 141);
            newGoogleTextBox3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            newGoogleTextBox3.FontTextPreview = new Font("Arial", 7F, FontStyle.Bold, GraphicsUnit.Point);
            newGoogleTextBox3.ForeColor = SystemColors.ControlLight;
            newGoogleTextBox3.Location = new Point(44, 98);
            newGoogleTextBox3.Name = "newGoogleTextBox3";
            newGoogleTextBox3.SelectionStart = 0;
            newGoogleTextBox3.Size = new Size(462, 44);
            newGoogleTextBox3.TabIndex = 13;
            newGoogleTextBox3.TextInput = "";
            newGoogleTextBox3.TextPreview = "Email Address";
            newGoogleTextBox3.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(214, 26);
            label1.Name = "label1";
            label1.Size = new Size(93, 38);
            label1.TabIndex = 10;
            label1.Text = "Log In";
            // 
            // labelMesError
            // 
            labelMesError.AutoSize = true;
            labelMesError.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelMesError.ForeColor = Color.Brown;
            labelMesError.Location = new Point(44, 218);
            labelMesError.Name = "labelMesError";
            labelMesError.Size = new Size(217, 18);
            labelMesError.TabIndex = 16;
            labelMesError.Text = "Incorrect password or email";
            labelMesError.Visible = false;
            // 
            // buttonHidePassword
            // 
            buttonHidePassword.FlatAppearance.BorderSize = 0;
            buttonHidePassword.FlatStyle = FlatStyle.Flat;
            buttonHidePassword.Image = Properties.Resources.outline_visibility_off_grey_24dp;
            buttonHidePassword.Location = new Point(461, 170);
            buttonHidePassword.Name = "buttonHidePassword";
            buttonHidePassword.Size = new Size(44, 35);
            buttonHidePassword.TabIndex = 17;
            buttonHidePassword.UseVisualStyleBackColor = true;
            buttonHidePassword.Click += buttonHidePassword_Click;
            // 
            // PanelAutorization_LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 49, 60);
            Controls.Add(buttonHidePassword);
            Controls.Add(labelMesError);
            Controls.Add(newButton2);
            Controls.Add(newGoogleTextBox4);
            Controls.Add(newGoogleTextBox3);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "PanelAutorization_LogIn";
            Size = new Size(550, 500);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private yt_DesignUI.NewButton newButton2;
        private yt_DesignUI.NewGoogleTextBox newGoogleTextBox4;
        private yt_DesignUI.NewGoogleTextBox newGoogleTextBox3;
        private Label label1;
        private Label labelMesError;
        private Button buttonHidePassword;
    }
}
