namespace SkillCourse.PanelComponents
{
    partial class Component_Task
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Component_Task));
            panel7 = new Panel();
            panel10 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label7 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            labelText = new Label();
            labelDate = new Label();
            panelIndex = new Panel();
            pictureBoxId = new PictureBox();
            labelId = new Label();
            panelButSend = new Panel();
            newButton3 = new yt_DesignUI.NewButton();
            labelBall = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panelIndex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxId).BeginInit();
            panelButSend.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(200, 100);
            panel7.TabIndex = 0;
            // 
            // panel10
            // 
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(200, 100);
            panel10.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(70, 0);
            label7.Name = "label7";
            label7.Size = new Size(59, 31);
            label7.TabIndex = 5;
            label7.Text = "0 / 5";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panelIndex);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1012, 124);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.Controls.Add(tableLayoutPanel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(175, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(651, 124);
            panel2.TabIndex = 9;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(labelText, 0, 1);
            tableLayoutPanel3.Controls.Add(labelDate, 0, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(651, 124);
            tableLayoutPanel3.TabIndex = 10;
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Dock = DockStyle.Fill;
            labelText.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelText.ForeColor = SystemColors.Control;
            labelText.Location = new Point(3, 20);
            labelText.Name = "labelText";
            labelText.Padding = new Padding(21, 0, 0, 0);
            labelText.Size = new Size(645, 186);
            labelText.TabIndex = 8;
            labelText.Text = resources.GetString("labelText.Text");
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI Variable Display", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelDate.ForeColor = SystemColors.ControlDark;
            labelDate.Location = new Point(5, 206);
            labelDate.Margin = new Padding(5, 0, 3, 0);
            labelDate.Name = "labelDate";
            labelDate.Padding = new Padding(21, 0, 0, 0);
            labelDate.Size = new Size(141, 22);
            labelDate.TabIndex = 9;
            labelDate.Text = "(22 мая 2023г.)";
            // 
            // panelIndex
            // 
            panelIndex.AutoSize = true;
            panelIndex.Controls.Add(pictureBoxId);
            panelIndex.Controls.Add(labelId);
            panelIndex.Dock = DockStyle.Left;
            panelIndex.Location = new Point(0, 0);
            panelIndex.Name = "panelIndex";
            panelIndex.Size = new Size(175, 124);
            panelIndex.TabIndex = 8;
            // 
            // pictureBoxId
            // 
            pictureBoxId.Dock = DockStyle.Left;
            pictureBoxId.Image = (Image)resources.GetObject("pictureBoxId.Image");
            pictureBoxId.Location = new Point(83, 0);
            pictureBoxId.MinimumSize = new Size(92, 101);
            pictureBoxId.Name = "pictureBoxId";
            pictureBoxId.Size = new Size(92, 124);
            pictureBoxId.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxId.TabIndex = 5;
            pictureBoxId.TabStop = false;
            pictureBoxId.Visible = false;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Dock = DockStyle.Left;
            labelId.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelId.ForeColor = SystemColors.Control;
            labelId.Location = new Point(0, 0);
            labelId.MinimumSize = new Size(83, 0);
            labelId.Name = "labelId";
            labelId.Padding = new Padding(0, 30, 0, 0);
            labelId.Size = new Size(83, 71);
            labelId.TabIndex = 4;
            labelId.Text = "#1";
            labelId.TextAlign = ContentAlignment.MiddleCenter;
            labelId.Visible = false;
            // 
            // panelButSend
            // 
            panelButSend.AutoSize = true;
            panelButSend.Controls.Add(newButton3);
            panelButSend.Dock = DockStyle.Fill;
            panelButSend.Location = new Point(34, 31);
            panelButSend.MinimumSize = new Size(118, 31);
            panelButSend.Name = "panelButSend";
            panelButSend.Size = new Size(118, 31);
            panelButSend.TabIndex = 10;
            // 
            // newButton3
            // 
            newButton3.BackColor = Color.Tomato;
            newButton3.BackColorAdditional = Color.Gray;
            newButton3.BackColorGradientEnabled = false;
            newButton3.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            newButton3.BorderColor = Color.Tomato;
            newButton3.BorderColorEnabled = false;
            newButton3.BorderColorOnHover = Color.Tomato;
            newButton3.BorderColorOnHoverEnabled = false;
            newButton3.Dock = DockStyle.Top;
            newButton3.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            newButton3.ForeColor = Color.White;
            newButton3.Location = new Point(0, 0);
            newButton3.Name = "newButton3";
            newButton3.RippleColor = Color.Black;
            newButton3.RoundingEnable = false;
            newButton3.Size = new Size(118, 29);
            newButton3.TabIndex = 6;
            newButton3.Text = "Send";
            newButton3.TextHover = null;
            newButton3.UseDownPressEffectOnClick = false;
            newButton3.UseMainGradientEffect = false;
            newButton3.UseRippleEffect = true;
            newButton3.UseVisualStyleBackColor = false;
            newButton3.UseZoomEffectOnHover = false;
            newButton3.Visible = false;
            // 
            // labelBall
            // 
            labelBall.Dock = DockStyle.Fill;
            labelBall.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelBall.ForeColor = SystemColors.Control;
            labelBall.Location = new Point(34, 65);
            labelBall.Name = "labelBall";
            labelBall.Size = new Size(118, 31);
            labelBall.TabIndex = 7;
            labelBall.Text = "0 / 5";
            labelBall.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(labelBall, 1, 2);
            tableLayoutPanel1.Controls.Add(panelButSend, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Right;
            tableLayoutPanel1.Location = new Point(826, 0);
            tableLayoutPanel1.MinimumSize = new Size(186, 101);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(186, 124);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // Component_Task
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(40, 49, 60);
            Controls.Add(panel1);
            MaximumSize = new Size(1012, 1000);
            MinimumSize = new Size(0, 101);
            Name = "Component_Task";
            Size = new Size(1012, 124);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panelIndex.ResumeLayout(false);
            panelIndex.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxId).EndInit();
            panelButSend.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel7;
        private Panel panel10;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label7;
        private Panel panel1;
        private Panel panel2;
        private Label labelDate;
        private Panel panelIndex;
        private Label labelText;
        private Label labelId;
        private PictureBox pictureBoxId;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelBall;
        private Panel panelButSend;
        private yt_DesignUI.NewButton newButton3;
    }
}
