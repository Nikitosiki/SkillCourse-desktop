namespace SkillCourse.PanelComponents.UsersPage
{
    partial class Component_UserText
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            labelText = new Label();
            labelLast = new Label();
            panel1 = new Panel();
            tableLayoutPanelImage = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(101, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(909, 70);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(labelText, 0, 0);
            tableLayoutPanel2.Controls.Add(labelLast, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(0, 0, 10, 0);
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(878, 41);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.BackColor = Color.Transparent;
            labelText.Dock = DockStyle.Bottom;
            labelText.FlatStyle = FlatStyle.Flat;
            labelText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelText.ForeColor = SystemColors.Control;
            labelText.Location = new Point(3, 0);
            labelText.Name = "labelText";
            labelText.Padding = new Padding(5, 13, 0, 0);
            labelText.Size = new Size(733, 41);
            labelText.TabIndex = 1;
            labelText.Text = "not";
            // 
            // labelLast
            // 
            labelLast.AutoSize = true;
            labelLast.BackColor = Color.Transparent;
            labelLast.Dock = DockStyle.Bottom;
            labelLast.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelLast.ForeColor = Color.Gainsboro;
            labelLast.Location = new Point(742, 21);
            labelLast.Name = "labelLast";
            labelLast.Size = new Size(123, 20);
            labelLast.TabIndex = 2;
            labelLast.Text = "Last: 10 aug 2023";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(22, 70);
            panel1.TabIndex = 4;
            // 
            // tableLayoutPanelImage
            // 
            tableLayoutPanelImage.BackColor = Color.Transparent;
            tableLayoutPanelImage.ColumnCount = 3;
            tableLayoutPanelImage.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanelImage.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 56F));
            tableLayoutPanelImage.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelImage.Dock = DockStyle.Left;
            tableLayoutPanelImage.Location = new Point(22, 0);
            tableLayoutPanelImage.Margin = new Padding(0);
            tableLayoutPanelImage.Name = "tableLayoutPanelImage";
            tableLayoutPanelImage.RowCount = 3;
            tableLayoutPanelImage.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelImage.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanelImage.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelImage.Size = new Size(79, 70);
            tableLayoutPanelImage.TabIndex = 5;
            // 
            // Component_UserText
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(40, 49, 60);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanelImage);
            Controls.Add(panel1);
            Name = "Component_UserText";
            Size = new Size(1010, 70);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label labelLast;
        private Label labelText;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanelImage;
    }
}
