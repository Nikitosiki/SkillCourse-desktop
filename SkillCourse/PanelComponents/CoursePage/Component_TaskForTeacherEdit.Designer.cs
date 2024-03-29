﻿namespace SkillCourse.PanelComponents.CoursePage
{
    partial class Component_TaskForTeacherEdit
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
            panelIndex = new Panel();
            labelId = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            labelDate = new Label();
            panelText = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            labelText = new Label();
            tableLayoutPanelAdmin = new TableLayoutPanel();
            roundedButtonEdit = new CPProject.components.ui.CustomRoundedButton();
            roundedButtonDelete = new CPProject.components.ui.CustomRoundedButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            labelBall = new Label();
            panelButSend = new Panel();
            newButtonSend = new yt_DesignUI.NewButton();
            panelIndex.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panelText.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanelAdmin.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panelButSend.SuspendLayout();
            SuspendLayout();
            // 
            // panelIndex
            // 
            panelIndex.AutoSize = true;
            panelIndex.Controls.Add(labelId);
            panelIndex.Dock = DockStyle.Left;
            panelIndex.Location = new Point(0, 0);
            panelIndex.Name = "panelIndex";
            panelIndex.Size = new Size(83, 123);
            panelIndex.TabIndex = 9;
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
            labelId.TabIndex = 4;
            labelId.Text = "#1";
            labelId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(labelDate, 0, 2);
            tableLayoutPanel3.Controls.Add(panelText, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(83, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(747, 123);
            tableLayoutPanel3.TabIndex = 11;
            tableLayoutPanel3.Resize += tableLayoutPanel3_Resize;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI Variable Display", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelDate.ForeColor = SystemColors.ControlDark;
            labelDate.Location = new Point(5, 74);
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
            panelText.Size = new Size(741, 48);
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
            tableLayoutPanel4.Size = new Size(741, 31);
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
            labelText.Size = new Size(735, 31);
            labelText.TabIndex = 10;
            labelText.Text = "Пояснювальна записка до курсової роботи\r\n";
            labelText.TextChanged += labelText_TextChanged;
            // 
            // tableLayoutPanelAdmin
            // 
            tableLayoutPanelAdmin.AutoSize = true;
            tableLayoutPanelAdmin.ColumnCount = 5;
            tableLayoutPanelAdmin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelAdmin.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelAdmin.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 21F));
            tableLayoutPanelAdmin.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelAdmin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelAdmin.Controls.Add(roundedButtonEdit, 1, 1);
            tableLayoutPanelAdmin.Controls.Add(roundedButtonDelete, 3, 1);
            tableLayoutPanelAdmin.Dock = DockStyle.Right;
            tableLayoutPanelAdmin.Location = new Point(830, 0);
            tableLayoutPanelAdmin.MinimumSize = new Size(186, 101);
            tableLayoutPanelAdmin.Name = "tableLayoutPanelAdmin";
            tableLayoutPanelAdmin.RowCount = 3;
            tableLayoutPanelAdmin.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelAdmin.RowStyles.Add(new RowStyle());
            tableLayoutPanelAdmin.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelAdmin.Size = new Size(186, 123);
            tableLayoutPanelAdmin.TabIndex = 12;
            tableLayoutPanelAdmin.Visible = false;
            // 
            // roundedButtonEdit
            // 
            roundedButtonEdit.Autofocus = false;
            roundedButtonEdit.BackColor = Color.FromArgb(50, 65, 80);
            roundedButtonEdit.BackgroundColor = Color.FromArgb(50, 65, 80);
            roundedButtonEdit.BorderColor = Color.PaleVioletRed;
            roundedButtonEdit.BorderRadius = 10;
            roundedButtonEdit.BorderSize = 0;
            roundedButtonEdit.FlatAppearance.BorderSize = 0;
            roundedButtonEdit.FlatStyle = FlatStyle.Flat;
            roundedButtonEdit.FocusBorderColor = Color.Gray;
            roundedButtonEdit.FocusBorderSize = 2;
            roundedButtonEdit.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            roundedButtonEdit.ForeColor = SystemColors.Control;
            roundedButtonEdit.Image = Properties.Resources.outline_edit_white_24dp;
            roundedButtonEdit.Location = new Point(42, 41);
            roundedButtonEdit.Margin = new Padding(0);
            roundedButtonEdit.Name = "roundedButtonEdit";
            roundedButtonEdit.Size = new Size(40, 40);
            roundedButtonEdit.TabIndex = 3;
            roundedButtonEdit.TextColor = SystemColors.Control;
            roundedButtonEdit.TextImageRelation = TextImageRelation.TextBeforeImage;
            roundedButtonEdit.UseVisualStyleBackColor = false;
            roundedButtonEdit.Click += roundedButtonEdit_Click;
            // 
            // roundedButtonDelete
            // 
            roundedButtonDelete.Autofocus = false;
            roundedButtonDelete.BackColor = Color.FromArgb(220, 50, 80);
            roundedButtonDelete.BackgroundColor = Color.FromArgb(220, 50, 80);
            roundedButtonDelete.BorderColor = Color.PaleVioletRed;
            roundedButtonDelete.BorderRadius = 10;
            roundedButtonDelete.BorderSize = 0;
            roundedButtonDelete.FlatAppearance.BorderSize = 0;
            roundedButtonDelete.FlatStyle = FlatStyle.Flat;
            roundedButtonDelete.FocusBorderColor = Color.Gray;
            roundedButtonDelete.FocusBorderSize = 2;
            roundedButtonDelete.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            roundedButtonDelete.ForeColor = SystemColors.Control;
            roundedButtonDelete.Image = Properties.Resources.close_white_24dp;
            roundedButtonDelete.Location = new Point(103, 41);
            roundedButtonDelete.Margin = new Padding(0);
            roundedButtonDelete.Name = "roundedButtonDelete";
            roundedButtonDelete.Size = new Size(40, 40);
            roundedButtonDelete.TabIndex = 4;
            roundedButtonDelete.TextColor = SystemColors.Control;
            roundedButtonDelete.TextImageRelation = TextImageRelation.TextBeforeImage;
            roundedButtonDelete.UseVisualStyleBackColor = false;
            roundedButtonDelete.Click += roundedButtonDelete_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(labelBall, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Right;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.MinimumSize = new Size(186, 101);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(200, 101);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // labelBall
            // 
            labelBall.Dock = DockStyle.Fill;
            labelBall.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelBall.ForeColor = SystemColors.Control;
            labelBall.Location = new Point(41, 40);
            labelBall.Name = "labelBall";
            labelBall.Padding = new Padding(3, 0, 0, 0);
            labelBall.Size = new Size(118, 20);
            labelBall.TabIndex = 7;
            labelBall.Text = "0 / 5";
            labelBall.TextAlign = ContentAlignment.MiddleCenter;
            labelBall.Visible = false;
            // 
            // panelButSend
            // 
            panelButSend.AutoSize = true;
            panelButSend.Controls.Add(newButtonSend);
            panelButSend.Dock = DockStyle.Fill;
            panelButSend.Location = new Point(41, 3);
            panelButSend.MinimumSize = new Size(118, 31);
            panelButSend.Name = "panelButSend";
            panelButSend.Size = new Size(118, 35);
            panelButSend.TabIndex = 10;
            panelButSend.Visible = false;
            // 
            // newButtonSend
            // 
            newButtonSend.BackColor = Color.FromArgb(80, 175, 138);
            newButtonSend.BackColorAdditional = Color.Gray;
            newButtonSend.BackColorGradientEnabled = false;
            newButtonSend.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            newButtonSend.BorderColor = Color.FromArgb(80, 175, 138);
            newButtonSend.BorderColorEnabled = false;
            newButtonSend.BorderColorOnHover = Color.FromArgb(80, 175, 138);
            newButtonSend.BorderColorOnHoverEnabled = false;
            newButtonSend.Dock = DockStyle.Top;
            newButtonSend.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            newButtonSend.ForeColor = SystemColors.Control;
            newButtonSend.Location = new Point(0, 0);
            newButtonSend.Name = "newButtonSend";
            newButtonSend.RippleColor = Color.Black;
            newButtonSend.Rounding = 20;
            newButtonSend.RoundingEnable = true;
            newButtonSend.Size = new Size(118, 35);
            newButtonSend.TabIndex = 6;
            newButtonSend.Text = "Send";
            newButtonSend.TextHover = null;
            newButtonSend.UseDownPressEffectOnClick = false;
            newButtonSend.UseMainGradientEffect = false;
            newButtonSend.UseRippleEffect = true;
            newButtonSend.UseVisualStyleBackColor = false;
            newButtonSend.UseZoomEffectOnHover = false;
            // 
            // Component_TaskForTeacherEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(40, 49, 60);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanelAdmin);
            Controls.Add(panelIndex);
            Name = "Component_TaskForTeacherEdit";
            Size = new Size(1016, 123);
            panelIndex.ResumeLayout(false);
            panelIndex.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panelText.ResumeLayout(false);
            panelText.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanelAdmin.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panelButSend.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelIndex;
        private Label labelId;
        private TableLayoutPanel tableLayoutPanel3;
        private Label labelDate;
        private Panel panelText;
        private TableLayoutPanel tableLayoutPanel4;
        private Label labelText;
        private TableLayoutPanel tableLayoutPanelAdmin;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelBall;
        private Panel panelButSend;
        private yt_DesignUI.NewButton newButtonSend;
        private CPProject.components.ui.CustomRoundedButton roundedButtonEdit;
        private CPProject.components.ui.CustomRoundedButton roundedButtonDelete;
    }
}
