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
            labelDate = new Label();
            panelIndex = new Panel();
            labelId = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            labelBall = new Label();
            newButton3 = new yt_DesignUI.NewButton();
            labelText = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panelIndex.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
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
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panelIndex);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1012, 101);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(labelDate);
            panel2.Controls.Add(labelText);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(89, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(737, 101);
            panel2.TabIndex = 9;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Dock = DockStyle.Top;
            labelDate.Font = new Font("Segoe UI Variable Display", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelDate.ForeColor = SystemColors.ControlDark;
            labelDate.Location = new Point(0, 50);
            labelDate.Margin = new Padding(5, 0, 3, 0);
            labelDate.Name = "labelDate";
            labelDate.Padding = new Padding(21, 0, 0, 0);
            labelDate.Size = new Size(141, 22);
            labelDate.TabIndex = 9;
            labelDate.Text = "(22 мая 2023г.)";
            // 
            // panelIndex
            // 
            panelIndex.Controls.Add(labelId);
            panelIndex.Dock = DockStyle.Left;
            panelIndex.Location = new Point(0, 0);
            panelIndex.Name = "panelIndex";
            panelIndex.Size = new Size(89, 101);
            panelIndex.TabIndex = 8;
            // 
            // labelId
            // 
            labelId.Dock = DockStyle.Fill;
            labelId.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelId.ForeColor = SystemColors.Control;
            labelId.Location = new Point(0, 0);
            labelId.Name = "labelId";
            labelId.Size = new Size(89, 101);
            labelId.TabIndex = 4;
            labelId.Text = "#1";
            labelId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel3, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Right;
            tableLayoutPanel1.Location = new Point(826, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(186, 101);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.Controls.Add(labelBall);
            panel3.Controls.Add(newButton3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(34, 20);
            panel3.MinimumSize = new Size(118, 31);
            panel3.Name = "panel3";
            panel3.Size = new Size(118, 60);
            panel3.TabIndex = 10;
            // 
            // labelBall
            // 
            labelBall.Dock = DockStyle.Top;
            labelBall.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelBall.ForeColor = SystemColors.Control;
            labelBall.Location = new Point(0, 29);
            labelBall.Name = "labelBall";
            labelBall.Size = new Size(118, 31);
            labelBall.TabIndex = 7;
            labelBall.Text = "0 / 5";
            labelBall.TextAlign = ContentAlignment.MiddleCenter;
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
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Dock = DockStyle.Top;
            labelText.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelText.ForeColor = SystemColors.Control;
            labelText.Location = new Point(0, 0);
            labelText.Name = "labelText";
            labelText.Padding = new Padding(21, 19, 0, 0);
            labelText.Size = new Size(490, 50);
            labelText.TabIndex = 8;
            labelText.Text = "Пояснювальна записка до курсової роботи";
            // 
            // Component_Task
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 49, 60);
            Controls.Add(panel1);
            MinimumSize = new Size(0, 101);
            Name = "Component_Task";
            Size = new Size(1012, 101);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelIndex.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel7;
        private Panel panel10;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label7;
        private Panel panel1;
        private yt_DesignUI.NewButton newButton3;
        private Panel panel2;
        private Panel panel3;
        private Label labelBall;
        private Label labelDate;
        private Panel panelIndex;
        private Label labelId;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelText;
    }
}
