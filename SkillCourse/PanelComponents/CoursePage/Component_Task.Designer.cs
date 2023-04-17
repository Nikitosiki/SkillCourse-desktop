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
            panel7 = new Panel();
            panel10 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label7 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            labelDate = new Label();
            panelText = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            labelText = new Label();
            panelIndex = new Panel();
            labelId = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            labelBall = new Label();
            panelButSend = new Panel();
            newButton3 = new yt_DesignUI.NewButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panelText.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panelIndex.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panelButSend.SuspendLayout();
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
            panel1.Size = new Size(1012, 112);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.Controls.Add(tableLayoutPanel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(83, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(743, 112);
            panel2.TabIndex = 9;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(labelDate, 0, 2);
            tableLayoutPanel3.Controls.Add(panelText, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(743, 112);
            tableLayoutPanel3.TabIndex = 10;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI Variable Display", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelDate.ForeColor = SystemColors.ControlDark;
            labelDate.Location = new Point(5, 70);
            labelDate.Margin = new Padding(5, 0, 3, 0);
            labelDate.Name = "labelDate";
            labelDate.Padding = new Padding(21, 0, 0, 0);
            labelDate.Size = new Size(141, 22);
            labelDate.TabIndex = 9;
            labelDate.Text = "(22 мая 2023г.)";
            // 
            // panelText
            // 
            panelText.Controls.Add(tableLayoutPanel4);
            panelText.Dock = DockStyle.Top;
            panelText.Location = new Point(3, 23);
            panelText.Name = "panelText";
            panelText.Size = new Size(737, 44);
            panelText.TabIndex = 10;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.AutoSize = true;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(labelText, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Top;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.Size = new Size(737, 31);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Dock = DockStyle.Top;
            labelText.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelText.ForeColor = SystemColors.Control;
            labelText.Location = new Point(3, 0);
            labelText.Name = "labelText";
            labelText.Padding = new Padding(18, 0, 0, 0);
            labelText.Size = new Size(731, 31);
            labelText.TabIndex = 10;
            labelText.Text = "Пояснювальна записка до курсової роботи";
            labelText.TextChanged += labelText_TextChanged;
            // 
            // panelIndex
            // 
            panelIndex.AutoSize = true;
            panelIndex.Controls.Add(labelId);
            panelIndex.Dock = DockStyle.Left;
            panelIndex.Location = new Point(0, 0);
            panelIndex.Name = "panelIndex";
            panelIndex.Size = new Size(83, 112);
            panelIndex.TabIndex = 8;
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
            tableLayoutPanel1.Size = new Size(186, 112);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // labelBall
            // 
            labelBall.Dock = DockStyle.Fill;
            labelBall.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelBall.ForeColor = SystemColors.Control;
            labelBall.Location = new Point(34, 59);
            labelBall.Name = "labelBall";
            labelBall.Size = new Size(118, 31);
            labelBall.TabIndex = 7;
            labelBall.Text = "0 / 5";
            labelBall.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelButSend
            // 
            panelButSend.AutoSize = true;
            panelButSend.Controls.Add(newButton3);
            panelButSend.Dock = DockStyle.Fill;
            panelButSend.Location = new Point(34, 25);
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
            Size = new Size(1012, 112);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panelText.ResumeLayout(false);
            panelText.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            panelIndex.ResumeLayout(false);
            panelIndex.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panelButSend.ResumeLayout(false);
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
        private Label labelId;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelBall;
        private Panel panelButSend;
        private yt_DesignUI.NewButton newButton3;
        private Panel panelText;
        private TableLayoutPanel tableLayoutPanel4;
        private Label labelText;
    }
}
