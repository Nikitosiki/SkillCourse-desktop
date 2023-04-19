namespace SkillCourse.Forms
{
    partial class MessageYesNo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            panelText = new Panel();
            labelText = new Label();
            panel1 = new Panel();
            newButtonNo = new yt_DesignUI.NewButton();
            newButtonYes = new yt_DesignUI.NewButton();
            panel4 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2.SuspendLayout();
            panelText.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(panelText);
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(640, 250);
            panel2.TabIndex = 8;
            // 
            // panelText
            // 
            panelText.Controls.Add(labelText);
            panelText.Dock = DockStyle.Fill;
            panelText.Location = new Point(0, 0);
            panelText.Name = "panelText";
            panelText.Size = new Size(640, 179);
            panelText.TabIndex = 5;
            // 
            // labelText
            // 
            labelText.Dock = DockStyle.Fill;
            labelText.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelText.ForeColor = SystemColors.Control;
            labelText.Location = new Point(0, 0);
            labelText.Name = "labelText";
            labelText.Padding = new Padding(20, 40, 10, 0);
            labelText.Size = new Size(640, 179);
            labelText.TabIndex = 0;
            labelText.Text = "All your entries will be deleted. Are you sure you want to unsubscribe? \U0001f928";
            // 
            // panel1
            // 
            panel1.Controls.Add(newButtonNo);
            panel1.Controls.Add(newButtonYes);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 179);
            panel1.Name = "panel1";
            panel1.Size = new Size(640, 71);
            panel1.TabIndex = 4;
            // 
            // newButtonNo
            // 
            newButtonNo.BackColor = Color.FromArgb(70, 82, 89);
            newButtonNo.BackColorAdditional = Color.Gray;
            newButtonNo.BackColorGradientEnabled = false;
            newButtonNo.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            newButtonNo.BorderColor = Color.FromArgb(70, 82, 89);
            newButtonNo.BorderColorEnabled = false;
            newButtonNo.BorderColorOnHover = Color.FromArgb(70, 82, 89);
            newButtonNo.BorderColorOnHoverEnabled = false;
            newButtonNo.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            newButtonNo.ForeColor = Color.White;
            newButtonNo.Location = new Point(346, 14);
            newButtonNo.Name = "newButtonNo";
            newButtonNo.RippleColor = Color.Black;
            newButtonNo.Rounding = 70;
            newButtonNo.RoundingEnable = true;
            newButtonNo.Size = new Size(125, 39);
            newButtonNo.TabIndex = 3;
            newButtonNo.Text = "No";
            newButtonNo.TextHover = null;
            newButtonNo.UseDownPressEffectOnClick = false;
            newButtonNo.UseMainGradientEffect = false;
            newButtonNo.UseRippleEffect = true;
            newButtonNo.UseVisualStyleBackColor = false;
            newButtonNo.UseZoomEffectOnHover = false;
            newButtonNo.Click += newButtonNo_Click;
            // 
            // newButtonYes
            // 
            newButtonYes.BackColor = Color.FromArgb(80, 175, 138);
            newButtonYes.BackColorAdditional = Color.Gray;
            newButtonYes.BackColorGradientEnabled = false;
            newButtonYes.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            newButtonYes.BorderColor = Color.FromArgb(80, 175, 138);
            newButtonYes.BorderColorEnabled = false;
            newButtonYes.BorderColorOnHover = Color.FromArgb(80, 175, 138);
            newButtonYes.BorderColorOnHoverEnabled = false;
            newButtonYes.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            newButtonYes.ForeColor = Color.White;
            newButtonYes.Location = new Point(496, 14);
            newButtonYes.Name = "newButtonYes";
            newButtonYes.RippleColor = Color.Black;
            newButtonYes.Rounding = 70;
            newButtonYes.RoundingEnable = true;
            newButtonYes.Size = new Size(125, 39);
            newButtonYes.TabIndex = 2;
            newButtonYes.Text = "Yes";
            newButtonYes.TextHover = null;
            newButtonYes.UseDownPressEffectOnClick = false;
            newButtonYes.UseMainGradientEffect = false;
            newButtonYes.UseRippleEffect = true;
            newButtonYes.UseVisualStyleBackColor = false;
            newButtonYes.UseZoomEffectOnHover = false;
            newButtonYes.Click += newButtonYes_Click;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(313, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(327, 71);
            panel4.TabIndex = 4;
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
            tableLayoutPanel1.Size = new Size(640, 250);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // MessageYesNo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 49, 60);
            ClientSize = new Size(640, 250);
            Controls.Add(tableLayoutPanel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "MessageYesNo";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterParent;
            Text = "AnswerToTask";
            Load += AnswerToTask_Load;
            panel2.ResumeLayout(false);
            panelText.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private yt_DesignUI.NewButton newButtonNo;
        private yt_DesignUI.NewButton newButtonYes;
        private Panel panel4;
        private Label labelText;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelText;
    }
}