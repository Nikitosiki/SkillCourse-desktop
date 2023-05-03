namespace SkillCourse.PanelComponents.UsersPage
{
    partial class Component_ImageIconUser
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
            pictureBox1 = new PictureBox();
            backRoundPanel1 = new BackRoundPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            backRoundPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.imageDefaultCourse;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // backRoundPanel1
            // 
            backRoundPanel1.Autofocus = false;
            backRoundPanel1.BackColor = Color.Transparent;
            backRoundPanel1.BackgroundColor = Color.Transparent;
            backRoundPanel1.BorderColor = Color.PaleVioletRed;
            backRoundPanel1.BorderRadius = 25;
            backRoundPanel1.BorderSize = 0;
            backRoundPanel1.Controls.Add(pictureBox1);
            backRoundPanel1.FocusBorderColor = Color.Gray;
            backRoundPanel1.FocusBorderSize = 2;
            backRoundPanel1.ForeColor = Color.White;
            backRoundPanel1.Location = new Point(0, 0);
            backRoundPanel1.Name = "backRoundPanel1";
            backRoundPanel1.Size = new Size(50, 50);
            backRoundPanel1.TabIndex = 1;
            backRoundPanel1.TextColor = Color.White;
            // 
            // Component_ImageIconUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(backRoundPanel1);
            Name = "Component_ImageIconUser";
            Size = new Size(50, 50);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            backRoundPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private BackRoundPanel backRoundPanel1;
    }
}
