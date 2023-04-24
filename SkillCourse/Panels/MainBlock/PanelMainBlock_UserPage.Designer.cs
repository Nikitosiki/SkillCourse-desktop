namespace SkillCourse.Panels.MainBlock
{
    partial class PanelMainBlock_UserPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelMainBlock_UserPage));
            panel3 = new Panel();
            newButton_Back = new Button();
            labelNameType = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            newButton1 = new yt_DesignUI.NewButton();
            backRoundPanel1 = new PanelComponents.BackRoundPanel();
            pictureBoxIcon = new PictureBox();
            panel6 = new Panel();
            labelDateBirth = new Label();
            labelEmail = new Label();
            labelName = new Label();
            panel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            backRoundPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(newButton_Back);
            panel3.Controls.Add(labelNameType);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1012, 63);
            panel3.TabIndex = 46;
            // 
            // newButton_Back
            // 
            newButton_Back.Dock = DockStyle.Left;
            newButton_Back.FlatAppearance.BorderSize = 0;
            newButton_Back.FlatStyle = FlatStyle.Flat;
            newButton_Back.Image = (Image)resources.GetObject("newButton_Back.Image");
            newButton_Back.Location = new Point(0, 0);
            newButton_Back.Name = "newButton_Back";
            newButton_Back.Padding = new Padding(0, 12, 0, 0);
            newButton_Back.Size = new Size(52, 63);
            newButton_Back.TabIndex = 0;
            newButton_Back.UseVisualStyleBackColor = true;
            newButton_Back.Click += newButton_Back_Click;
            // 
            // labelNameType
            // 
            labelNameType.AutoSize = true;
            labelNameType.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelNameType.ForeColor = SystemColors.Control;
            labelNameType.Location = new Point(61, 22);
            labelNameType.Name = "labelNameType";
            labelNameType.Size = new Size(105, 31);
            labelNameType.TabIndex = 2;
            labelNameType.Text = "User text";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel6, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 63);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1012, 610);
            tableLayoutPanel1.TabIndex = 47;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(backRoundPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(48, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(294, 584);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(newButton1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 398);
            panel2.Name = "panel2";
            panel2.Size = new Size(294, 186);
            panel2.TabIndex = 1;
            // 
            // newButton1
            // 
            newButton1.BackColor = Color.FromArgb(62, 72, 79);
            newButton1.BackColorAdditional = Color.FromArgb(80, 175, 138);
            newButton1.BackColorGradientEnabled = false;
            newButton1.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            newButton1.BorderColor = Color.FromArgb(80, 175, 138);
            newButton1.BorderColorEnabled = false;
            newButton1.BorderColorOnHover = Color.FromArgb(80, 175, 138);
            newButton1.BorderColorOnHoverEnabled = false;
            newButton1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            newButton1.ForeColor = Color.White;
            newButton1.Location = new Point(13, 15);
            newButton1.Name = "newButton1";
            newButton1.RippleColor = Color.Black;
            newButton1.Rounding = 30;
            newButton1.RoundingEnable = true;
            newButton1.Size = new Size(125, 38);
            newButton1.TabIndex = 0;
            newButton1.Text = "Its course";
            newButton1.TextHover = null;
            newButton1.UseDownPressEffectOnClick = false;
            newButton1.UseMainGradientEffect = false;
            newButton1.UseRippleEffect = true;
            newButton1.UseVisualStyleBackColor = false;
            newButton1.UseZoomEffectOnHover = false;
            newButton1.Click += newButton1_Click;
            // 
            // backRoundPanel1
            // 
            backRoundPanel1.Autofocus = false;
            backRoundPanel1.BackColor = Color.FromArgb(40, 49, 60);
            backRoundPanel1.BackgroundColor = Color.FromArgb(40, 49, 60);
            backRoundPanel1.BackgroundImageLayout = ImageLayout.Zoom;
            backRoundPanel1.BorderColor = Color.PaleVioletRed;
            backRoundPanel1.BorderRadius = 20;
            backRoundPanel1.BorderSize = 0;
            backRoundPanel1.Controls.Add(pictureBoxIcon);
            backRoundPanel1.Dock = DockStyle.Top;
            backRoundPanel1.FocusBorderColor = Color.Gray;
            backRoundPanel1.FocusBorderSize = 2;
            backRoundPanel1.ForeColor = Color.White;
            backRoundPanel1.Location = new Point(0, 0);
            backRoundPanel1.Name = "backRoundPanel1";
            backRoundPanel1.Size = new Size(294, 398);
            backRoundPanel1.TabIndex = 0;
            backRoundPanel1.TextColor = Color.White;
            // 
            // pictureBoxIcon
            // 
            pictureBoxIcon.Dock = DockStyle.Fill;
            pictureBoxIcon.Image = (Image)resources.GetObject("pictureBoxIcon.Image");
            pictureBoxIcon.Location = new Point(0, 0);
            pictureBoxIcon.Name = "pictureBoxIcon";
            pictureBoxIcon.Size = new Size(294, 398);
            pictureBoxIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxIcon.TabIndex = 3;
            pictureBoxIcon.TabStop = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(labelDateBirth);
            panel6.Controls.Add(labelEmail);
            panel6.Controls.Add(labelName);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(348, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(616, 584);
            panel6.TabIndex = 2;
            // 
            // labelDateBirth
            // 
            labelDateBirth.AutoSize = true;
            labelDateBirth.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelDateBirth.ForeColor = SystemColors.Control;
            labelDateBirth.Location = new Point(16, 124);
            labelDateBirth.Name = "labelDateBirth";
            labelDateBirth.Size = new Size(55, 23);
            labelDateBirth.TabIndex = 2;
            labelDateBirth.Text = "label1";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmail.ForeColor = SystemColors.Control;
            labelEmail.Location = new Point(16, 83);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(55, 23);
            labelEmail.TabIndex = 1;
            labelEmail.Text = "label1";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.ForeColor = SystemColors.Control;
            labelName.Location = new Point(16, 40);
            labelName.Name = "labelName";
            labelName.Size = new Size(55, 23);
            labelName.TabIndex = 0;
            labelName.Text = "label1";
            // 
            // PanelMainBlock_UserPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 49, 60);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel3);
            Name = "PanelMainBlock_UserPage";
            Size = new Size(1012, 673);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            backRoundPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button newButton_Back;
        private Panel panel4;
        private Panel panel5;
        private Label labelNameType;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private yt_DesignUI.NewButton newButton1;
        private PanelComponents.BackRoundPanel backRoundPanel1;
        private Panel panel6;
        private Label labelDateBirth;
        private Label labelEmail;
        private Label labelName;
        private PictureBox pictureBoxIcon;
    }
}
