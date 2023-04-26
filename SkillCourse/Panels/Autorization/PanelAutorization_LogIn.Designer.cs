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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
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
            newButton2.Dock = DockStyle.Fill;
            newButton2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            newButton2.ForeColor = Color.White;
            newButton2.Location = new Point(45, 3);
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
            newGoogleTextBox4.Location = new Point(0, 67);
            newGoogleTextBox4.Name = "newGoogleTextBox4";
            newGoogleTextBox4.SelectionStart = 0;
            newGoogleTextBox4.Size = new Size(462, 44);
            newGoogleTextBox4.TabIndex = 14;
            newGoogleTextBox4.TextInput = "12345678d";
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
            newGoogleTextBox3.Location = new Point(0, 3);
            newGoogleTextBox3.Name = "newGoogleTextBox3";
            newGoogleTextBox3.SelectionStart = 0;
            newGoogleTextBox3.Size = new Size(462, 44);
            newGoogleTextBox3.TabIndex = 13;
            newGoogleTextBox3.TextInput = "v_-369nmd@gmail.com";
            newGoogleTextBox3.TextPreview = "Email Address";
            newGoogleTextBox3.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 2, 0, 0);
            label1.Size = new Size(553, 87);
            label1.TabIndex = 10;
            label1.Text = "Log In";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelMesError
            // 
            labelMesError.AutoSize = true;
            labelMesError.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelMesError.ForeColor = Color.Brown;
            labelMesError.Location = new Point(0, 123);
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
            buttonHidePassword.Location = new Point(417, 75);
            buttonHidePassword.Name = "buttonHidePassword";
            buttonHidePassword.Size = new Size(44, 35);
            buttonHidePassword.TabIndex = 17;
            buttonHidePassword.UseVisualStyleBackColor = true;
            buttonHidePassword.Click += buttonHidePassword_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 87);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(553, 147);
            tableLayoutPanel1.TabIndex = 18;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(newGoogleTextBox3);
            panel1.Controls.Add(buttonHidePassword);
            panel1.Controls.Add(newGoogleTextBox4);
            panel1.Controls.Add(labelMesError);
            panel1.Location = new Point(44, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(465, 141);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(newButton2, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Bottom;
            tableLayoutPanel2.Location = new Point(0, 405);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.Size = new Size(553, 95);
            tableLayoutPanel2.TabIndex = 19;
            // 
            // PanelAutorization_LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(40, 49, 60);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "PanelAutorization_LogIn";
            Size = new Size(553, 500);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
