﻿using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Win32;
using SkillCourse.DataBaseStructure;
using SkillCourse.DataBaseStructure.types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using yt_DesignUI;
using User = SkillCourse.DataBaseStructure.User;

namespace SkillCourse.Panels
{
    public partial class PanelAutorization_SingUp : UserControl
    {
        private Form parentForm;

        //private string FirstName { get; set; }
        //private string LastName { get; set; }
        //private string Email { get; set; }
        //private string Password { get; set; }
        //private DateTime DateOfBirth { get; set; }
        private UserType userType { get; set; } = UserType.Student;


        public PanelAutorization_SingUp(Form parentForm)
        {
            this.parentForm = parentForm;
            InitializeComponent();

            ValidityCheckDateBirth(DateTimeBirth, false);
        }

        private void newButtonSingUp_Click(object sender, EventArgs e)
        {
            if (!ValidityCheckName(TextBoxLastName, false))
                return;
            if (!ValidityCheckName(TextBoxFirstName, false))
                return;
            if (!ValidityCheckEmail(TextBoxEmail, false))
                return;
            if (!ValidityCheckPassword(TextBoxPassword, false))
                return;

            AccountHandler.Instance.RegIn(
                    TextBoxFirstName.Text,
                    TextBoxLastName.Text,
                    TextBoxEmail.Text,
                    DateTimeBirth.Value,
                    userType,
                    TextBoxPassword.Text);

            ((Authorization)parentForm).SelectLogInWithRegistred(TextBoxEmail.Text);
        }



        private static bool ValidityCheckName(NewGoogleTextBox thisTextBox, bool ifEmptiness)
        {
            Regex regex = new Regex(@"^[\p{L}]+$", RegexOptions.Compiled);

            if ((thisTextBox.Text.Count() > 100 || thisTextBox.Text.Count() < 2 || !regex.IsMatch(thisTextBox.Text)) && (thisTextBox.Text != "" || !ifEmptiness))
            {
                if (!ifEmptiness)
                    thisTextBox.BorderColorNotActive = Color.Brown;

                thisTextBox.BorderColor = Color.Brown;
                thisTextBox.Refresh();
                return false;
            }
            else
            {
                thisTextBox.BorderColor = SystemColors.ControlDarkDark;
                thisTextBox.Refresh();
                return true;
            }
        }

        private static bool ValidityCheckEmail(NewGoogleTextBox thisTextBox, bool ifEmptiness)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            if ((thisTextBox.Text.Count() > 100 || !regex.IsMatch(thisTextBox.Text)) && (thisTextBox.Text != "" || !ifEmptiness))
            {
                if (!ifEmptiness)
                    thisTextBox.BorderColorNotActive = Color.Brown;

                thisTextBox.BorderColor = Color.Brown;
                thisTextBox.Refresh();
                return false;
            }
            else
            {
                thisTextBox.BorderColor = SystemColors.ControlDarkDark;
                thisTextBox.Refresh();
                return true;
            }

        }

        private static bool ValidityCheckPassword(NewGoogleTextBox thisTextBox, bool ifEmptiness)
        {
            Regex regex = new Regex(@"^(?=.*[a-zA-Z])(?=.*\d)[a-zA-Z\d]{8,}$");

            if ((thisTextBox.Text.Count() > 100 || !regex.IsMatch(thisTextBox.Text)) && (thisTextBox.Text != "" || !ifEmptiness))
            {
                if (!ifEmptiness)
                    thisTextBox.BorderColorNotActive = Color.Brown;

                thisTextBox.BorderColor = Color.Brown;
                thisTextBox.Refresh();
                return false;
            }
            else
            {
                thisTextBox.BorderColor = SystemColors.ControlDarkDark;
                thisTextBox.Refresh();
                return true;
            }
        }

        private static void ValidityCheckDateBirth(DateTimePicker thisTimePicker, bool typeTeather)
        {
            if (typeTeather)
            {
                //Teacher
                thisTimePicker.MaxDate = DateTime.Now.AddYears(-18);
            }
            else
            {
                //Student
                thisTimePicker.MaxDate = DateTime.Now.AddYears(-6);
            }

            thisTimePicker.Refresh();
        }


        private void TextBoxLastName_TextChanged(object sender, EventArgs e)
        {
            ValidityCheckName(TextBoxLastName, true);
        }
        private void TextBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            ValidityCheckName(TextBoxFirstName, true);
        }
        private void TextBoxEmail_TextChanged(object sender, EventArgs e)
        {
            ValidityCheckEmail(TextBoxEmail, true);
        }
        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {
            ValidityCheckPassword(TextBoxPassword, true);
        }
        private void DateTimeBirth_ValueChanged(object sender, EventArgs e)
        {
            NewRadioButton newRadioButton = (NewRadioButton)sender;
            if (newRadioButton.Name == "newRadioButtonT")
            {
                userType = UserType.Teacher;
                ValidityCheckDateBirth(DateTimeBirth, true);
            }
            else
            {
                userType = UserType.Student;
                ValidityCheckDateBirth(DateTimeBirth, false);
            }
        }
    }
}