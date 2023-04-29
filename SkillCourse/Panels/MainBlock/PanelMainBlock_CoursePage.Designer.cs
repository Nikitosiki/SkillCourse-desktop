using SkillCourse.PanelComponents;

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
            panelNaming = new Panel();
            labelName = new Label();
            panelEditName = new Panel();
            roundedButtonEditName = new CPProject.components.ui.CustomRoundedButton();
            panelButtonSetting = new Panel();
            roundedButtonSetting = new CPProject.components.ui.CustomRoundedButton();
            newButton_Back = new Button();
            panel4 = new Panel();
            roundedButtonEditDescription = new CPProject.components.ui.CustomRoundedButton();
            textBoxDescription = new TextBox();
            panel5 = new Panel();
            panel1 = new BackRoundPanel();
            roundedButtonEditImage = new CPProject.components.ui.CustomRoundedButton();
            pictureBoxImage = new PictureBox();
            panelTasks = new Panel();
            label3 = new Label();
            panel15 = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            buttonPanelPeople = new Button();
            buttonPanelStream = new Button();
            buttonPanelClasswork = new Button();
            buttonSortTasks = new Button();
            panel3.SuspendLayout();
            panelNaming.SuspendLayout();
            panelEditName.SuspendLayout();
            panelButtonSetting.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).BeginInit();
            panel15.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(panelNaming);
            panel3.Controls.Add(panelButtonSetting);
            panel3.Controls.Add(newButton_Back);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(panel1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1012, 221);
            panel3.TabIndex = 45;
            // 
            // panelNaming
            // 
            panelNaming.Controls.Add(labelName);
            panelNaming.Controls.Add(panelEditName);
            panelNaming.Dock = DockStyle.Fill;
            panelNaming.Location = new Point(52, 0);
            panelNaming.Name = "panelNaming";
            panelNaming.Size = new Size(436, 63);
            panelNaming.TabIndex = 51;
            // 
            // labelName
            // 
            labelName.Dock = DockStyle.Fill;
            labelName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.ForeColor = SystemColors.Control;
            labelName.ImageAlign = ContentAlignment.MiddleLeft;
            labelName.Location = new Point(0, 0);
            labelName.Margin = new Padding(3, 3, 3, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(378, 63);
            labelName.TabIndex = 2;
            labelName.Text = "Об'єктно-орієнтоване програмування (КР)\r\n\r\n\r\n";
            labelName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelEditName
            // 
            panelEditName.Controls.Add(roundedButtonEditName);
            panelEditName.Dock = DockStyle.Right;
            panelEditName.Location = new Point(378, 0);
            panelEditName.Name = "panelEditName";
            panelEditName.Size = new Size(58, 63);
            panelEditName.TabIndex = 0;
            panelEditName.Visible = false;
            // 
            // roundedButtonEditName
            // 
            roundedButtonEditName.Autofocus = false;
            roundedButtonEditName.BackColor = Color.FromArgb(50, 65, 80);
            roundedButtonEditName.BackgroundColor = Color.FromArgb(50, 65, 80);
            roundedButtonEditName.BorderColor = Color.PaleVioletRed;
            roundedButtonEditName.BorderRadius = 10;
            roundedButtonEditName.BorderSize = 0;
            roundedButtonEditName.FlatAppearance.BorderSize = 0;
            roundedButtonEditName.FlatStyle = FlatStyle.Flat;
            roundedButtonEditName.FocusBorderColor = Color.Gray;
            roundedButtonEditName.FocusBorderSize = 2;
            roundedButtonEditName.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            roundedButtonEditName.ForeColor = SystemColors.Control;
            roundedButtonEditName.Image = Properties.Resources.outline_edit_white_24dp;
            roundedButtonEditName.Location = new Point(9, 11);
            roundedButtonEditName.Margin = new Padding(0, 0, 10, 5);
            roundedButtonEditName.Name = "roundedButtonEditName";
            roundedButtonEditName.Size = new Size(40, 40);
            roundedButtonEditName.TabIndex = 3;
            roundedButtonEditName.TextColor = SystemColors.Control;
            roundedButtonEditName.TextImageRelation = TextImageRelation.TextBeforeImage;
            roundedButtonEditName.UseVisualStyleBackColor = false;
            roundedButtonEditName.Visible = false;
            roundedButtonEditName.Click += roundedButtonEditName_Click;
            // 
            // panelButtonSetting
            // 
            panelButtonSetting.Controls.Add(roundedButtonSetting);
            panelButtonSetting.Dock = DockStyle.Right;
            panelButtonSetting.Location = new Point(488, 0);
            panelButtonSetting.Name = "panelButtonSetting";
            panelButtonSetting.Size = new Size(206, 63);
            panelButtonSetting.TabIndex = 50;
            panelButtonSetting.Visible = false;
            // 
            // roundedButtonSetting
            // 
            roundedButtonSetting.Autofocus = false;
            roundedButtonSetting.BackColor = Color.FromArgb(50, 65, 80);
            roundedButtonSetting.BackgroundColor = Color.FromArgb(50, 65, 80);
            roundedButtonSetting.BorderColor = Color.PaleVioletRed;
            roundedButtonSetting.BorderRadius = 10;
            roundedButtonSetting.BorderSize = 0;
            roundedButtonSetting.FlatAppearance.BorderSize = 0;
            roundedButtonSetting.FlatStyle = FlatStyle.Flat;
            roundedButtonSetting.FocusBorderColor = Color.Gray;
            roundedButtonSetting.FocusBorderSize = 2;
            roundedButtonSetting.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            roundedButtonSetting.ForeColor = SystemColors.Control;
            roundedButtonSetting.Image = Properties.Resources.outline_settings_white_24dp;
            roundedButtonSetting.ImageAlign = ContentAlignment.MiddleLeft;
            roundedButtonSetting.Location = new Point(2, 11);
            roundedButtonSetting.Margin = new Padding(0, 0, 10, 5);
            roundedButtonSetting.Name = "roundedButtonSetting";
            roundedButtonSetting.Size = new Size(192, 40);
            roundedButtonSetting.TabIndex = 1;
            roundedButtonSetting.Text = "Course Settings";
            roundedButtonSetting.TextColor = SystemColors.Control;
            roundedButtonSetting.TextImageRelation = TextImageRelation.TextBeforeImage;
            roundedButtonSetting.UseVisualStyleBackColor = false;
            roundedButtonSetting.Click += roundedButtonSetting_Click;
            // 
            // newButton_Back
            // 
            newButton_Back.Dock = DockStyle.Left;
            newButton_Back.FlatAppearance.BorderSize = 0;
            newButton_Back.FlatStyle = FlatStyle.Flat;
            newButton_Back.Image = (Image)resources.GetObject("newButton_Back.Image");
            newButton_Back.Location = new Point(0, 0);
            newButton_Back.Name = "newButton_Back";
            newButton_Back.Padding = new Padding(0, 4, 0, 0);
            newButton_Back.Size = new Size(52, 63);
            newButton_Back.TabIndex = 0;
            newButton_Back.UseVisualStyleBackColor = true;
            newButton_Back.Click += newButton_Back_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(roundedButtonEditDescription);
            panel4.Controls.Add(textBoxDescription);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 63);
            panel4.Name = "panel4";
            panel4.Size = new Size(694, 158);
            panel4.TabIndex = 49;
            // 
            // roundedButtonEditDescription
            // 
            roundedButtonEditDescription.Autofocus = false;
            roundedButtonEditDescription.BackColor = Color.FromArgb(50, 65, 80);
            roundedButtonEditDescription.BackgroundColor = Color.FromArgb(50, 65, 80);
            roundedButtonEditDescription.BorderColor = Color.PaleVioletRed;
            roundedButtonEditDescription.BorderRadius = 10;
            roundedButtonEditDescription.BorderSize = 0;
            roundedButtonEditDescription.FlatAppearance.BorderSize = 0;
            roundedButtonEditDescription.FlatStyle = FlatStyle.Flat;
            roundedButtonEditDescription.FocusBorderColor = Color.Gray;
            roundedButtonEditDescription.FocusBorderSize = 2;
            roundedButtonEditDescription.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            roundedButtonEditDescription.ForeColor = SystemColors.Control;
            roundedButtonEditDescription.Image = Properties.Resources.outline_edit_white_24dp;
            roundedButtonEditDescription.Location = new Point(642, 110);
            roundedButtonEditDescription.Margin = new Padding(0, 0, 10, 5);
            roundedButtonEditDescription.Name = "roundedButtonEditDescription";
            roundedButtonEditDescription.Size = new Size(40, 40);
            roundedButtonEditDescription.TabIndex = 2;
            roundedButtonEditDescription.TextColor = SystemColors.Control;
            roundedButtonEditDescription.TextImageRelation = TextImageRelation.TextBeforeImage;
            roundedButtonEditDescription.UseVisualStyleBackColor = false;
            roundedButtonEditDescription.Visible = false;
            roundedButtonEditDescription.Click += roundedButtonEditDescription_Click;
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
            panel1.Autofocus = false;
            panel1.BackColor = Color.FromArgb(40, 49, 60);
            panel1.BackgroundColor = Color.FromArgb(40, 49, 60);
            panel1.BorderColor = Color.FromArgb(40, 49, 60);
            panel1.BorderRadius = 10;
            panel1.BorderSize = 0;
            panel1.Controls.Add(roundedButtonEditImage);
            panel1.Controls.Add(pictureBoxImage);
            panel1.Dock = DockStyle.Right;
            panel1.FocusBorderColor = Color.Gray;
            panel1.FocusBorderSize = 2;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(694, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(318, 221);
            panel1.TabIndex = 48;
            panel1.TextColor = Color.White;
            // 
            // roundedButtonEditImage
            // 
            roundedButtonEditImage.Autofocus = false;
            roundedButtonEditImage.BackColor = Color.FromArgb(50, 65, 80);
            roundedButtonEditImage.BackgroundColor = Color.FromArgb(50, 65, 80);
            roundedButtonEditImage.BorderColor = Color.FromArgb(50, 65, 80);
            roundedButtonEditImage.BorderRadius = 9;
            roundedButtonEditImage.BorderSize = 1;
            roundedButtonEditImage.FlatAppearance.BorderSize = 0;
            roundedButtonEditImage.FlatStyle = FlatStyle.Flat;
            roundedButtonEditImage.FocusBorderColor = Color.Gray;
            roundedButtonEditImage.FocusBorderSize = 0;
            roundedButtonEditImage.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            roundedButtonEditImage.ForeColor = SystemColors.Control;
            roundedButtonEditImage.Image = Properties.Resources.outline_brush_white_24dp;
            roundedButtonEditImage.Location = new Point(268, 13);
            roundedButtonEditImage.Margin = new Padding(0, 0, 10, 5);
            roundedButtonEditImage.Name = "roundedButtonEditImage";
            roundedButtonEditImage.Size = new Size(40, 40);
            roundedButtonEditImage.TabIndex = 3;
            roundedButtonEditImage.TextColor = SystemColors.Control;
            roundedButtonEditImage.TextImageRelation = TextImageRelation.TextBeforeImage;
            roundedButtonEditImage.UseVisualStyleBackColor = false;
            roundedButtonEditImage.Visible = false;
            roundedButtonEditImage.Click += roundedButtonEditImage_Click;
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
            tableLayoutPanel5.Controls.Add(buttonSortTasks, 0, 0);
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
            // buttonSortTasks
            // 
            buttonSortTasks.Dock = DockStyle.Left;
            buttonSortTasks.FlatAppearance.BorderSize = 0;
            buttonSortTasks.FlatStyle = FlatStyle.Flat;
            buttonSortTasks.Image = Properties.Resources.arrow_up_341_svgrepo_com_up;
            buttonSortTasks.Location = new Point(17, 9);
            buttonSortTasks.Margin = new Padding(17, 5, 3, 3);
            buttonSortTasks.Name = "buttonSortTasks";
            buttonSortTasks.Size = new Size(50, 30);
            buttonSortTasks.TabIndex = 5;
            buttonSortTasks.UseVisualStyleBackColor = true;
            buttonSortTasks.Click += buttonSortTasks_Click;
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
            VisibleChanged += PanelMainBlock_CoursePage_VisibleChanged;
            panel3.ResumeLayout(false);
            panelNaming.ResumeLayout(false);
            panelEditName.ResumeLayout(false);
            panelButtonSetting.ResumeLayout(false);
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
        private Panel panelTasks;
        private TextBox textBoxDescription;
        private Panel panel4;
        private Panel panel5;
        private BackRoundPanel panel1;
        private PictureBox pictureBoxImage;
        private Label label3;
        private Panel panel15;
        private Button buttonPanelPeople;
        private Button buttonPanelClasswork;
        private Button buttonPanelStream;
        private TableLayoutPanel tableLayoutPanel5;
        private Button buttonSortTasks;
        private Button newButton_Back;
        private CPProject.components.ui.CustomRoundedButton roundedButtonSetting;
        private Panel panelButtonSetting;
        private Panel panelNaming;
        private CPProject.components.ui.CustomRoundedButton roundedButtonEditDescription;
        private Panel panelEditName;
        private CPProject.components.ui.CustomRoundedButton roundedButtonEditName;
        private CPProject.components.ui.CustomRoundedButton roundedButtonEditImage;
    }
}
