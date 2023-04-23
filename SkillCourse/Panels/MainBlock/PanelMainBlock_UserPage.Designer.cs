namespace SkillCourse.Panels.MainBlock
{
    partial class PanelMainBlock_UserPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelMainBlock_UserPage));
            panel3 = new Panel();
            newButton_Back = new Button();
            panel4 = new Panel();
            panel5 = new Panel();
            labelName = new Label();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(newButton_Back);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(labelName);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1012, 221);
            panel3.TabIndex = 46;
            // 
            // newButton_Back
            // 
            newButton_Back.Dock = DockStyle.Left;
            newButton_Back.FlatAppearance.BorderSize = 0;
            newButton_Back.FlatStyle = FlatStyle.Flat;
            newButton_Back.Image = (Image)resources.GetObject("newButton_Back.Image");
            newButton_Back.Location = new Point(0, 0);
            newButton_Back.Name = "newButton_Back";
            newButton_Back.Padding = new Padding(0, 12, 0, 0);
            newButton_Back.Size = new Size(52, 63);
            newButton_Back.TabIndex = 0;
            newButton_Back.UseVisualStyleBackColor = true;
            newButton_Back.Click += newButton_Back_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 63);
            panel4.Name = "panel4";
            panel4.Size = new Size(1012, 158);
            panel4.TabIndex = 49;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(53, 158);
            panel5.TabIndex = 0;
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
            // PanelMainBlock_UserPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 49, 60);
            Controls.Add(panel3);
            Name = "PanelMainBlock_UserPage";
            Size = new Size(1012, 673);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button newButton_Back;
        private Panel panel4;
        private Panel panel5;
        private Label labelName;
    }
}
