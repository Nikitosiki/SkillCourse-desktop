namespace SkillCourse.Panels.MainBlock.CertificatePage
{
    partial class Component_RowUserCertificate
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
            labelStudName = new Label();
            panelText = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            labelText = new Label();
            panelIndex = new Panel();
            labelId = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            labelStatus = new Label();
            panelButIssue = new Panel();
            newButtonIssue = new yt_DesignUI.NewButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panelText.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panelIndex.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panelButIssue.SuspendLayout();
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
            panel1.Size = new Size(1157, 145);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.Controls.Add(tableLayoutPanel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(83, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(888, 145);
            panel2.TabIndex = 9;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(labelStudName, 0, 1);
            tableLayoutPanel3.Controls.Add(panelText, 0, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(888, 145);
            tableLayoutPanel3.TabIndex = 10;
            tableLayoutPanel3.Resize += tableLayoutPanel3_Resize;
            // 
            // labelStudName
            // 
            labelStudName.AutoSize = true;
            labelStudName.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelStudName.ForeColor = Color.FromArgb(142, 173, 212);
            labelStudName.Location = new Point(5, 20);
            labelStudName.Margin = new Padding(5, 0, 3, 0);
            labelStudName.Name = "labelStudName";
            labelStudName.Padding = new Padding(21, 0, 0, 0);
            labelStudName.Size = new Size(241, 27);
            labelStudName.TabIndex = 9;
            labelStudName.Text = "Student: Nikita Savenko";
            // 
            // panelText
            // 
            panelText.Controls.Add(tableLayoutPanel4);
            panelText.Dock = DockStyle.Top;
            panelText.Location = new Point(3, 50);
            panelText.Name = "panelText";
            panelText.Size = new Size(882, 44);
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
            tableLayoutPanel4.Size = new Size(882, 31);
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
            labelText.Size = new Size(876, 31);
            labelText.TabIndex = 10;
            labelText.Text = "Course: \"fsdfsdfsd\"";
            labelText.TextChanged += labelText_TextChanged;
            // 
            // panelIndex
            // 
            panelIndex.AutoSize = true;
            panelIndex.Controls.Add(labelId);
            panelIndex.Dock = DockStyle.Left;
            panelIndex.Location = new Point(0, 0);
            panelIndex.MinimumSize = new Size(83, 0);
            panelIndex.Name = "panelIndex";
            panelIndex.Size = new Size(83, 145);
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
            labelId.Padding = new Padding(0, 29, 0, 0);
            labelId.Size = new Size(83, 70);
            labelId.TabIndex = 5;
            labelId.Text = "●";
            labelId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(labelStatus, 1, 2);
            tableLayoutPanel1.Controls.Add(panelButIssue, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Right;
            tableLayoutPanel1.Location = new Point(971, 0);
            tableLayoutPanel1.MinimumSize = new Size(186, 101);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(186, 145);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // labelStatus
            // 
            labelStatus.Dock = DockStyle.Fill;
            labelStatus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelStatus.ForeColor = SystemColors.Control;
            labelStatus.Location = new Point(34, 77);
            labelStatus.Name = "labelStatus";
            labelStatus.Padding = new Padding(3, 0, 0, 0);
            labelStatus.Size = new Size(118, 31);
            labelStatus.TabIndex = 7;
            labelStatus.Text = "Status";
            labelStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelButIssue
            // 
            panelButIssue.AutoSize = true;
            panelButIssue.Controls.Add(newButtonIssue);
            panelButIssue.Dock = DockStyle.Fill;
            panelButIssue.Location = new Point(34, 39);
            panelButIssue.MinimumSize = new Size(118, 31);
            panelButIssue.Name = "panelButIssue";
            panelButIssue.Size = new Size(118, 35);
            panelButIssue.TabIndex = 10;
            panelButIssue.Visible = false;
            // 
            // newButtonIssue
            // 
            newButtonIssue.BackColor = Color.FromArgb(80, 175, 138);
            newButtonIssue.BackColorAdditional = Color.Gray;
            newButtonIssue.BackColorGradientEnabled = false;
            newButtonIssue.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            newButtonIssue.BorderColor = Color.FromArgb(80, 175, 138);
            newButtonIssue.BorderColorEnabled = false;
            newButtonIssue.BorderColorOnHover = Color.FromArgb(80, 175, 138);
            newButtonIssue.BorderColorOnHoverEnabled = false;
            newButtonIssue.Dock = DockStyle.Top;
            newButtonIssue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            newButtonIssue.ForeColor = SystemColors.Control;
            newButtonIssue.Location = new Point(0, 0);
            newButtonIssue.Name = "newButtonIssue";
            newButtonIssue.RippleColor = Color.Black;
            newButtonIssue.Rounding = 20;
            newButtonIssue.RoundingEnable = true;
            newButtonIssue.Size = new Size(118, 35);
            newButtonIssue.TabIndex = 6;
            newButtonIssue.Text = "Issue";
            newButtonIssue.TextHover = null;
            newButtonIssue.UseDownPressEffectOnClick = false;
            newButtonIssue.UseMainGradientEffect = false;
            newButtonIssue.UseRippleEffect = true;
            newButtonIssue.UseVisualStyleBackColor = false;
            newButtonIssue.UseZoomEffectOnHover = false;
            newButtonIssue.Click += newButtonIssue_Click;
            // 
            // Component_RowUserCertificate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(40, 49, 60);
            Controls.Add(panel1);
            MinimumSize = new Size(0, 101);
            Name = "Component_RowUserCertificate";
            Size = new Size(1157, 145);
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
            panelButIssue.ResumeLayout(false);
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
        private Label labelStudName;
        private Panel panelIndex;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelStatus;
        private Panel panelButIssue;
        private yt_DesignUI.NewButton newButtonIssue;
        private Panel panelText;
        private TableLayoutPanel tableLayoutPanel4;
        private Label labelText;
        private Label labelId;
    }
}
