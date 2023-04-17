namespace SkillCourse.Forms
{
    partial class AnswerToTask
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
            newButtonAuthorization = new yt_DesignUI.NewButton();
            newButton1 = new yt_DesignUI.NewButton();
            SuspendLayout();
            // 
            // newButtonAuthorization
            // 
            newButtonAuthorization.BackColor = Color.FromArgb(80, 175, 138);
            newButtonAuthorization.BackColorAdditional = Color.Gray;
            newButtonAuthorization.BackColorGradientEnabled = false;
            newButtonAuthorization.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            newButtonAuthorization.BorderColor = Color.FromArgb(80, 175, 138);
            newButtonAuthorization.BorderColorEnabled = false;
            newButtonAuthorization.BorderColorOnHover = Color.FromArgb(80, 175, 138);
            newButtonAuthorization.BorderColorOnHoverEnabled = false;
            newButtonAuthorization.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            newButtonAuthorization.ForeColor = Color.White;
            newButtonAuthorization.Location = new Point(554, 370);
            newButtonAuthorization.Name = "newButtonAuthorization";
            newButtonAuthorization.RippleColor = Color.Black;
            newButtonAuthorization.Rounding = 70;
            newButtonAuthorization.RoundingEnable = true;
            newButtonAuthorization.Size = new Size(125, 39);
            newButtonAuthorization.TabIndex = 2;
            newButtonAuthorization.Text = "Apply";
            newButtonAuthorization.TextHover = null;
            newButtonAuthorization.UseDownPressEffectOnClick = false;
            newButtonAuthorization.UseMainGradientEffect = false;
            newButtonAuthorization.UseRippleEffect = true;
            newButtonAuthorization.UseVisualStyleBackColor = false;
            newButtonAuthorization.UseZoomEffectOnHover = false;
            // 
            // newButton1
            // 
            newButton1.BackColor = Color.FromArgb(70, 82, 89);
            newButton1.BackColorAdditional = Color.Gray;
            newButton1.BackColorGradientEnabled = false;
            newButton1.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            newButton1.BorderColor = Color.FromArgb(70, 82, 89);
            newButton1.BorderColorEnabled = false;
            newButton1.BorderColorOnHover = Color.FromArgb(70, 82, 89);
            newButton1.BorderColorOnHoverEnabled = false;
            newButton1.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            newButton1.ForeColor = Color.White;
            newButton1.Location = new Point(405, 370);
            newButton1.Name = "newButton1";
            newButton1.RippleColor = Color.Black;
            newButton1.Rounding = 70;
            newButton1.RoundingEnable = true;
            newButton1.Size = new Size(125, 39);
            newButton1.TabIndex = 3;
            newButton1.Text = "Cancel";
            newButton1.TextHover = null;
            newButton1.UseDownPressEffectOnClick = false;
            newButton1.UseMainGradientEffect = false;
            newButton1.UseRippleEffect = true;
            newButton1.UseVisualStyleBackColor = false;
            newButton1.UseZoomEffectOnHover = false;
            // 
            // AnswerToTask
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 49, 60);
            ClientSize = new Size(711, 435);
            Controls.Add(newButton1);
            Controls.Add(newButtonAuthorization);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AnswerToTask";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AnswerToTask";
            ResumeLayout(false);
        }

        #endregion

        private yt_DesignUI.NewButton newButtonAuthorization;
        private yt_DesignUI.NewButton newButton1;
        private PanelComponents.BackRoundPanel panel1;
    }
}