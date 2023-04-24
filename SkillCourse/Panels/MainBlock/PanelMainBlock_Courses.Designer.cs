namespace SkillCourse.Panels.MainBlock
{
    partial class PanelMainBlock_Courses
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
            label15 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            textBoxSearcher = new PanelComponents.CustomTextBox();
            customComboBox1 = new PanelComponents.CustomComboBox();
            panel4 = new Panel();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label15
            // 
            label15.Dock = DockStyle.Fill;
            label15.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = SystemColors.Control;
            label15.Location = new Point(0, 0);
            label15.Name = "label15";
            label15.Size = new Size(85, 42);
            label15.TabIndex = 8;
            label15.Text = "Search";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(20, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(979, 42);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(85, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(860, 42);
            panel3.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 1F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 1F));
            tableLayoutPanel2.Controls.Add(textBoxSearcher, 1, 1);
            tableLayoutPanel2.Controls.Add(customComboBox1, 2, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 2F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(860, 42);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // textBoxSearcher
            // 
            textBoxSearcher.AutoScroll = true;
            textBoxSearcher.BackColor = Color.FromArgb(40, 49, 60);
            textBoxSearcher.BorderColor = Color.FromArgb(80, 175, 138);
            textBoxSearcher.BorderRadius = 0;
            textBoxSearcher.BorderSize = 1;
            textBoxSearcher.Dock = DockStyle.Fill;
            textBoxSearcher.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearcher.ForeColor = SystemColors.Control;
            textBoxSearcher.Location = new Point(1, 7);
            textBoxSearcher.Margin = new Padding(0);
            textBoxSearcher.Multiline = false;
            textBoxSearcher.Name = "textBoxSearcher";
            textBoxSearcher.Padding = new Padding(8, 6, 8, 6);
            textBoxSearcher.PasswordChar = false;
            textBoxSearcher.PlaceholderColor = Color.DarkGray;
            textBoxSearcher.PlaceholderText = "";
            textBoxSearcher.Size = new Size(724, 33);
            textBoxSearcher.TabIndex = 0;
            textBoxSearcher.Texts = "";
            textBoxSearcher.UnderlinedStyle = false;
            textBoxSearcher._TextChanged += textBoxSearcher_TextChanged;
            // 
            // customComboBox1
            // 
            customComboBox1.BackColor = Color.FromArgb(40, 49, 60);
            customComboBox1.BorderColor = Color.FromArgb(80, 175, 138);
            customComboBox1.BorderRadius = 0;
            customComboBox1.BorderSize = 1;
            customComboBox1.Dock = DockStyle.Fill;
            customComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            customComboBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            customComboBox1.ForeColor = SystemColors.Control;
            customComboBox1.IconColor = SystemColors.Control;
            customComboBox1.Items.AddRange(new object[] { " A -> W", "W -> A", "Last", "First", "Only Sub", "Only UnS" });
            customComboBox1.ListBackColor = Color.FromArgb(40, 49, 60);
            customComboBox1.ListTextColor = Color.Silver;
            customComboBox1.Location = new Point(732, 7);
            customComboBox1.Margin = new Padding(7, 0, 0, 0);
            customComboBox1.MinimumSize = new Size(100, 20);
            customComboBox1.Name = "customComboBox1";
            customComboBox1.Padding = new Padding(1);
            customComboBox1.Size = new Size(127, 33);
            customComboBox1.TabIndex = 9;
            customComboBox1.Texts = "First";
            customComboBox1.OnSelectedIndexChanged += customComboBox1_OnSelectedIndexChanged;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(945, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(34, 42);
            panel4.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.Controls.Add(label15);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(85, 42);
            panel2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 17F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tableLayoutPanel1.Size = new Size(1012, 673);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(20, 51);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(979, 614);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // PanelMainBlock_Courses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 49, 60);
            Controls.Add(tableLayoutPanel1);
            Name = "PanelMainBlock_Courses";
            Size = new Size(1012, 673);
            Load += PanelMainBlock_Courses_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label15;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private PanelComponents.CustomTextBox textBoxSearcher;
        private Panel panel3;
        private Panel panel4;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel2;
        private PanelComponents.CustomComboBox customComboBox1;
    }
}
