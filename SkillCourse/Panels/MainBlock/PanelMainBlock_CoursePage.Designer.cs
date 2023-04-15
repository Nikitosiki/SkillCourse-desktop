namespace SkillCourse.Panels.MainBlock
{
    partial class PanelMainBlock_CoursePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelMainBlock_CoursePage));
            panel3 = new Panel();
            panel4 = new Panel();
            textBoxDescription = new TextBox();
            panel5 = new Panel();
            panel1 = new Panel();
            pictureBoxImage = new PictureBox();
            newButton_Back = new Label();
            labelName = new Label();
            panelTasks = new Panel();
            label3 = new Label();
            panel15 = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            buttonPanelPeople = new Button();
            buttonPanelStream = new Button();
            buttonPanelClasswork = new Button();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).BeginInit();
            panel15.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(newButton_Back);
            panel3.Controls.Add(labelName);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1012, 221);
            panel3.TabIndex = 45;
            // 
            // panel4
            // 
            panel4.Controls.Add(textBoxDescription);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 63);
            panel4.Name = "panel4";
            panel4.Size = new Size(694, 158);
            panel4.TabIndex = 49;
            // 
            // textBoxDescription
            // 
            textBoxDescription.BackColor = Color.FromArgb(40, 49, 60);
            textBoxDescription.BorderStyle = BorderStyle.None;
            textBoxDescription.Dock = DockStyle.Fill;
            textBoxDescription.ForeColor = SystemColors.ControlDark;
            textBoxDescription.Location = new Point(53, 0);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.ReadOnly = true;
            textBoxDescription.Size = new Size(641, 158);
            textBoxDescription.TabIndex = 0;
            textBoxDescription.Text = resources.GetString("textBoxDescription.Text");
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(53, 158);
            panel5.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBoxImage);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(694, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(318, 221);
            panel1.TabIndex = 48;
            // 
            // pictureBoxImage
            // 
            pictureBoxImage.Dock = DockStyle.Fill;
            pictureBoxImage.Image = Properties.Resources.image008;
            pictureBoxImage.Location = new Point(0, 0);
            pictureBoxImage.Name = "pictureBoxImage";
            pictureBoxImage.Size = new Size(318, 221);
            pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImage.TabIndex = 0;
            pictureBoxImage.TabStop = false;
            // 
            // newButton_Back
            // 
            newButton_Back.AutoSize = true;
            newButton_Back.Font = new Font("Segoe UI", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            newButton_Back.ForeColor = SystemColors.Control;
            newButton_Back.Location = new Point(3, 14);
            newButton_Back.Name = "newButton_Back";
            newButton_Back.Size = new Size(49, 45);
            newButton_Back.TabIndex = 47;
            newButton_Back.Text = "🠔";
            newButton_Back.Click += newButton_Back_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.ForeColor = SystemColors.Control;
            labelName.Location = new Point(61, 22);
            labelName.Name = "labelName";
            labelName.Size = new Size(459, 31);
            labelName.TabIndex = 2;
            labelName.Text = "Об'єктно-орієнтоване програмування (КР)";
            // 
            // panelTasks
            // 
            panelTasks.AutoScroll = true;
            panelTasks.Dock = DockStyle.Fill;
            panelTasks.Location = new Point(0, 276);
            panelTasks.Name = "panelTasks";
            panelTasks.Size = new Size(1012, 397);
            panelTasks.TabIndex = 48;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLight;
            label3.Location = new Point(-10, 0);
            label3.Name = "label3";
            label3.Size = new Size(3933, 20);
            label3.TabIndex = 1;
            label3.Text = resources.GetString("label3.Text");
            // 
            // panel15
            // 
            panel15.Controls.Add(tableLayoutPanel5);
            panel15.Controls.Add(label3);
            panel15.Dock = DockStyle.Top;
            panel15.Location = new Point(0, 221);
            panel15.Name = "panel15";
            panel15.Size = new Size(1012, 55);
            panel15.TabIndex = 49;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 5;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(buttonPanelPeople, 3, 0);
            tableLayoutPanel5.Controls.Add(buttonPanelStream, 1, 0);
            tableLayoutPanel5.Controls.Add(buttonPanelClasswork, 2, 0);
            tableLayoutPanel5.Dock = DockStyle.Bottom;
            tableLayoutPanel5.Location = new Point(0, 13);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.Padding = new Padding(0, 4, 0, 0);
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(1012, 42);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // buttonPanelPeople
            // 
            buttonPanelPeople.Dock = DockStyle.Fill;
            buttonPanelPeople.FlatAppearance.BorderSize = 0;
            buttonPanelPeople.FlatStyle = FlatStyle.Flat;
            buttonPanelPeople.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPanelPeople.ForeColor = SystemColors.ButtonShadow;
            buttonPanelPeople.ImageAlign = ContentAlignment.MiddleLeft;
            buttonPanelPeople.Location = new Point(569, 7);
            buttonPanelPeople.Name = "buttonPanelPeople";
            buttonPanelPeople.Size = new Size(114, 32);
            buttonPanelPeople.TabIndex = 4;
            buttonPanelPeople.Text = "People";
            buttonPanelPeople.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonPanelPeople.UseVisualStyleBackColor = true;
            buttonPanelPeople.Click += buttonPanelPeople_Click;
            // 
            // buttonPanelStream
            // 
            buttonPanelStream.Dock = DockStyle.Fill;
            buttonPanelStream.FlatAppearance.BorderSize = 0;
            buttonPanelStream.FlatStyle = FlatStyle.Flat;
            buttonPanelStream.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPanelStream.ForeColor = SystemColors.ControlLight;
            buttonPanelStream.Location = new Point(329, 7);
            buttonPanelStream.Name = "buttonPanelStream";
            buttonPanelStream.Size = new Size(114, 32);
            buttonPanelStream.TabIndex = 2;
            buttonPanelStream.Text = "Stream";
            buttonPanelStream.UseVisualStyleBackColor = true;
            buttonPanelStream.Click += buttonPanelStream_Click;
            // 
            // buttonPanelClasswork
            // 
            buttonPanelClasswork.Dock = DockStyle.Fill;
            buttonPanelClasswork.FlatAppearance.BorderSize = 0;
            buttonPanelClasswork.FlatStyle = FlatStyle.Flat;
            buttonPanelClasswork.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPanelClasswork.ForeColor = SystemColors.ButtonShadow;
            buttonPanelClasswork.Location = new Point(449, 7);
            buttonPanelClasswork.Name = "buttonPanelClasswork";
            buttonPanelClasswork.Size = new Size(114, 32);
            buttonPanelClasswork.TabIndex = 3;
            buttonPanelClasswork.Text = "Classwork";
            buttonPanelClasswork.UseVisualStyleBackColor = true;
            buttonPanelClasswork.Click += buttonPanelClasswork_Click;
            // 
            // PanelMainBlock_CoursePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 49, 60);
            Controls.Add(panelTasks);
            Controls.Add(panel15);
            Controls.Add(panel3);
            Name = "PanelMainBlock_CoursePage";
            Size = new Size(1012, 673);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).EndInit();
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private Label labelName;
        private Label newButton_Back;
        private Panel panelTasks;
        private TextBox textBoxDescription;
        private Panel panel4;
        private Panel panel5;
        private Panel panel1;
        private PictureBox pictureBoxImage;
        private Label label3;
        private Panel panel15;
        private Button buttonPanelPeople;
        private Button buttonPanelClasswork;
        private Button buttonPanelStream;
        private TableLayoutPanel tableLayoutPanel5;
    }
}
