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
            this.panel_Header = new System.Windows.Forms.Panel();
            this.newButton_LogIn = new yt_DesignUI.NewButton();
            this.newButton_SingUp = new yt_DesignUI.NewButton();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.panel_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Header
            // 
            this.panel_Header.Controls.Add(this.newButton_LogIn);
            this.panel_Header.Controls.Add(this.newButton_SingUp);
            resources.ApplyResources(this.panel_Header, "panel_Header");
            this.panel_Header.Name = "panel_Header";
            // 
            // newButton_LogIn
            // 
            this.newButton_LogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(175)))), ((int)(((byte)(138)))));
            this.newButton_LogIn.BackColorAdditional = System.Drawing.Color.Gray;
            this.newButton_LogIn.BackColorGradientEnabled = false;
            this.newButton_LogIn.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.newButton_LogIn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(175)))), ((int)(((byte)(138)))));
            this.newButton_LogIn.BorderColorEnabled = false;
            this.newButton_LogIn.BorderColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(175)))), ((int)(((byte)(138)))));
            this.newButton_LogIn.BorderColorOnHoverEnabled = false;
            resources.ApplyResources(this.newButton_LogIn, "newButton_LogIn");
            this.newButton_LogIn.ForeColor = System.Drawing.Color.White;
            this.newButton_LogIn.Name = "newButton_LogIn";
            this.newButton_LogIn.RippleColor = System.Drawing.Color.Black;
            this.newButton_LogIn.RoundingEnable = false;
            this.newButton_LogIn.TextHover = null;
            this.newButton_LogIn.UseDownPressEffectOnClick = false;
            this.newButton_LogIn.UseRippleEffect = true;
            this.newButton_LogIn.UseVisualStyleBackColor = false;
            this.newButton_LogIn.UseZoomEffectOnHover = false;
            this.newButton_LogIn.Click += new System.EventHandler(this.newButton_LogIn_Click);
            // 
            // newButton_SingUp
            // 
            this.newButton_SingUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.newButton_SingUp.BackColorAdditional = System.Drawing.Color.Gray;
            this.newButton_SingUp.BackColorGradientEnabled = false;
            this.newButton_SingUp.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.newButton_SingUp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.newButton_SingUp.BorderColorEnabled = false;
            this.newButton_SingUp.BorderColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.newButton_SingUp.BorderColorOnHoverEnabled = false;
            resources.ApplyResources(this.newButton_SingUp, "newButton_SingUp");
            this.newButton_SingUp.ForeColor = System.Drawing.Color.White;
            this.newButton_SingUp.Name = "newButton_SingUp";
            this.newButton_SingUp.RippleColor = System.Drawing.Color.Black;
            this.newButton_SingUp.RoundingEnable = false;
            this.newButton_SingUp.TextHover = null;
            this.newButton_SingUp.UseDownPressEffectOnClick = false;
            this.newButton_SingUp.UseRippleEffect = true;
            this.newButton_SingUp.UseVisualStyleBackColor = false;
            this.newButton_SingUp.UseZoomEffectOnHover = false;
            this.newButton_SingUp.Click += new System.EventHandler(this.newButton_SingUp_Click);
            // 
            // panel_Main
            // 
            resources.ApplyResources(this.panel_Main, "panel_Main");
            this.panel_Main.Name = "panel_Main";
            // 
            // Authorization
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.panel_Main);
            this.Controls.Add(this.panel_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Authorization";
            this.TopMost = true;
            this.panel_Header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_Header;
        private Panel panel_Main;
        private yt_DesignUI.NewButton newButton_SingUp;
        private yt_DesignUI.NewButton newButton_LogIn;
    }
}