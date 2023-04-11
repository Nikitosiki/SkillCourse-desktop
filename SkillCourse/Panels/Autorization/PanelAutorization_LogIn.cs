using SkillCourse.DataBaseStructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yt_DesignUI;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SkillCourse.Panels
{
    public partial class PanelAutorization_LogIn : UserControl
    {
        private Form parentForm;


        public PanelAutorization_LogIn(Form parentForm)
        {
            this.parentForm = parentForm;
            InitializeComponent();
            ResetLabelErrorMes();
        }

        public PanelAutorization_LogIn(Form parentForm, string userEmail)
        {
            this.parentForm = parentForm;
            InitializeComponent();
            ResetLabelErrorMes();

            newGoogleTextBox3.Text = userEmail;

            // Установить курсор в конец поля ввода
            newGoogleTextBox3.SelectionStart = newGoogleTextBox3.Text.Length;
        }

        private void newButton2_Click(object sender, EventArgs e)
        {
            ResetLabelErrorMes();

            try
            {
                if (AccountHandler.Instance.LogIn(newGoogleTextBox3.Text.ToLower(), newGoogleTextBox4.Text))
                    parentForm.Hide();


                newGoogleTextBox4.Text = "";
                labelMesError.Visible = true;
            }
            catch (Exception exMes)
            {
                newGoogleTextBox4.Text = "";
                labelMesError.Text = exMes.Message;
                labelMesError.Visible = true;
            }
        }
        private void ResetLabelErrorMes()
        {
            labelMesError.Visible = false;
            labelMesError.Text = "Incorrect password or email.";
        }

        private void buttonHidePassword_Click(object sender, EventArgs e)
        {
            if (newGoogleTextBox4.UseSystemPasswordChar == false)
            {
                newGoogleTextBox4.UseSystemPasswordChar = true;
                buttonHidePassword.Image = Properties.Resources.outline_visibility_off_grey_24dp;
                buttonHidePassword.Refresh();
            }
            else
            {
                newGoogleTextBox4.UseSystemPasswordChar = false;
                buttonHidePassword.Image = Properties.Resources.outline_visibility_grey_24dp;
                buttonHidePassword.Refresh();
            }
        }
    }
}
