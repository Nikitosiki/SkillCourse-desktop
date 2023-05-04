namespace SkillCourse
{
    partial class Authorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            panel_Header = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            newButton_SingUp = new yt_DesignUI.NewButton();
            newButton_LogIn = new yt_DesignUI.NewButton();
            panel_Main = new Panel();
            panel1 = new Panel();
            buttonExit = new Button();
            panel_Header.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel_Header
            // 
            panel_Header.Controls.Add(tableLayoutPanel1);
            resources.ApplyResources(panel_Header, "panel_Header");
            panel_Header.Name = "panel_Header";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
            tableLayoutPanel1.Controls.Add(newButton_SingUp, 3, 1);
            tableLayoutPanel1.Controls.Add(newButton_LogIn, 1, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // newButton_SingUp
            // 
            newButton_SingUp.BackColor = Color.FromArgb(70, 82, 89);
            newButton_SingUp.BackColorAdditional = Color.Gray;
            newButton_SingUp.BackColorGradientEnabled = false;
            newButton_SingUp.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            newButton_SingUp.BorderColor = Color.FromArgb(70, 82, 89);
            newButton_SingUp.BorderColorEnabled = false;
            newButton_SingUp.BorderColorOnHover = Color.FromArgb(70, 82, 89);
            newButton_SingUp.BorderColorOnHoverEnabled = false;
            resources.ApplyResources(newButton_SingUp, "newButton_SingUp");
            newButton_SingUp.ForeColor = Color.White;
            newButton_SingUp.Name = "newButton_SingUp";
            newButton_SingUp.RippleColor = Color.Black;
            newButton_SingUp.RoundingEnable = false;
            newButton_SingUp.TextHover = null;
            newButton_SingUp.UseDownPressEffectOnClick = false;
            newButton_SingUp.UseMainGradientEffect = false;
            newButton_SingUp.UseRippleEffect = true;
            newButton_SingUp.UseVisualStyleBackColor = false;
            newButton_SingUp.UseZoomEffectOnHover = false;
            newButton_SingUp.Click += newButton_SingUp_Click;
            // 
            // newButton_LogIn
            // 
            newButton_LogIn.BackColor = Color.FromArgb(80, 175, 138);
            newButton_LogIn.BackColorAdditional = Color.Gray;
            newButton_LogIn.BackColorGradientEnabled = false;
            newButton_LogIn.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            newButton_LogIn.BorderColor = Color.FromArgb(80, 175, 138);
            newButton_LogIn.BorderColorEnabled = false;
            newButton_LogIn.BorderColorOnHover = Color.FromArgb(80, 175, 138);
            newButton_LogIn.BorderColorOnHoverEnabled = false;
            resources.ApplyResources(newButton_LogIn, "newButton_LogIn");
            newButton_LogIn.ForeColor = Color.White;
            newButton_LogIn.Name = "newButton_LogIn";
            newButton_LogIn.RippleColor = Color.Black;
            newButton_LogIn.RoundingEnable = false;
            newButton_LogIn.TextHover = null;
            newButton_LogIn.UseDownPressEffectOnClick = false;
            newButton_LogIn.UseMainGradientEffect = false;
            newButton_LogIn.UseRippleEffect = true;
            newButton_LogIn.UseVisualStyleBackColor = false;
            newButton_LogIn.UseZoomEffectOnHover = false;
            newButton_LogIn.Click += newButton_LogIn_Click;
            // 
            // panel_Main
            // 
            resources.ApplyResources(panel_Main, "panel_Main");
            panel_Main.Name = "panel_Main";
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonExit);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // buttonExit
            // 
            buttonExit.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(buttonExit, "buttonExit");
            buttonExit.Name = "buttonExit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // Authorization
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 49, 60);
            Controls.Add(panel_Main);
            Controls.Add(panel_Header);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Authorization";
            panel_Header.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Header;
        private Panel panel_Main;
        private yt_DesignUI.NewButton newButton_SingUp;
        private yt_DesignUI.NewButton newButton_LogIn;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button buttonExit;
    }
}