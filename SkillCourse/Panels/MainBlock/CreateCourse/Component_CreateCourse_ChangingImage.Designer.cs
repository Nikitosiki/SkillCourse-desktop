namespace SkillCourse.Panels.MainBlock.CreateCourse
{
    partial class Component_CreateCourse_ChangingImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Component_CreateCourse_ChangingImage));
            panel2 = new Panel();
            backRoundPanel1 = new PanelComponents.BackRoundPanel();
            pictureBoxImage = new PictureBox();
            newButtonSelectImage = new yt_DesignUI.NewButton();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2.SuspendLayout();
            backRoundPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(backRoundPanel1);
            panel2.Controls.Add(newButtonSelectImage);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(264, 103);
            panel2.Name = "panel2";
            panel2.Size = new Size(481, 313);
            panel2.TabIndex = 0;
            // 
            // backRoundPanel1
            // 
            backRoundPanel1.Autofocus = false;
            backRoundPanel1.BackColor = Color.FromArgb(38, 45, 52);
            backRoundPanel1.BackgroundColor = Color.FromArgb(38, 45, 52);
            backRoundPanel1.BorderColor = Color.PaleVioletRed;
            backRoundPanel1.BorderRadius = 10;
            backRoundPanel1.BorderSize = 0;
            backRoundPanel1.Controls.Add(pictureBoxImage);
            backRoundPanel1.FocusBorderColor = Color.Gray;
            backRoundPanel1.FocusBorderSize = 2;
            backRoundPanel1.ForeColor = Color.White;
            backRoundPanel1.Location = new Point(3, 49);
            backRoundPanel1.Name = "backRoundPanel1";
            backRoundPanel1.Size = new Size(257, 180);
            backRoundPanel1.TabIndex = 51;
            backRoundPanel1.TextColor = Color.White;
            // 
            // pictureBoxImage
            // 
            pictureBoxImage.Dock = DockStyle.Fill;
            pictureBoxImage.Image = (Image)resources.GetObject("pictureBoxImage.Image");
            pictureBoxImage.Location = new Point(0, 0);
            pictureBoxImage.Name = "pictureBoxImage";
            pictureBoxImage.Size = new Size(257, 180);
            pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImage.TabIndex = 0;
            pictureBoxImage.TabStop = false;
            // 
            // newButtonSelectImage
            // 
            newButtonSelectImage.BackColor = Color.FromArgb(62, 72, 79);
            newButtonSelectImage.BackColorAdditional = Color.FromArgb(80, 175, 138);
            newButtonSelectImage.BackColorGradientEnabled = false;
            newButtonSelectImage.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            newButtonSelectImage.BorderColor = Color.FromArgb(80, 175, 138);
            newButtonSelectImage.BorderColorEnabled = false;
            newButtonSelectImage.BorderColorOnHover = Color.FromArgb(80, 175, 138);
            newButtonSelectImage.BorderColorOnHoverEnabled = false;
            newButtonSelectImage.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            newButtonSelectImage.ForeColor = Color.White;
            newButtonSelectImage.Location = new Point(297, 159);
            newButtonSelectImage.Name = "newButtonSelectImage";
            newButtonSelectImage.RippleColor = Color.Black;
            newButtonSelectImage.Rounding = 30;
            newButtonSelectImage.RoundingEnable = true;
            newButtonSelectImage.Size = new Size(140, 38);
            newButtonSelectImage.TabIndex = 0;
            newButtonSelectImage.Text = "Select";
            newButtonSelectImage.TextHover = null;
            newButtonSelectImage.UseDownPressEffectOnClick = false;
            newButtonSelectImage.UseMainGradientEffect = false;
            newButtonSelectImage.UseRippleEffect = true;
            newButtonSelectImage.UseVisualStyleBackColor = false;
            newButtonSelectImage.UseZoomEffectOnHover = false;
            newButtonSelectImage.Click += newButtonSelectImage_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(272, 83);
            label1.Name = "label1";
            label1.Size = new Size(201, 56);
            label1.TabIndex = 50;
            label1.Text = "Change the picture to\r\nyour own?";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel2, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1009, 519);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // Component_CreateCourse_ChangingImage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 45, 52);
            Controls.Add(tableLayoutPanel1);
            Name = "Component_CreateCourse_ChangingImage";
            Size = new Size(1009, 519);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            backRoundPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private PictureBox pictureBoxImage;
        private Label label1;
        private yt_DesignUI.NewButton newButtonSelectImage;
        private PanelComponents.BackRoundPanel backRoundPanel1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
