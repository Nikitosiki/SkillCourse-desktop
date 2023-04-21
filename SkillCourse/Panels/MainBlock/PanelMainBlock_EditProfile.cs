using SkillCourse.DataBaseStructure;
using SkillCourse.DataBaseStructure.types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkillCourse.Panels.MainBlock
{
    public partial class PanelMainBlock_EditProfile : UserControl
    {
        private Student handler = (Student)AccountHandler.Instance.UserLog;

        public PanelMainBlock_EditProfile()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;

            textBoxLastName.Text = handler.LastName;
            textBoxFirstName.Text = handler.FirstName;
            textBoxPhone.Text = handler.PhoneNumber;
            textBoxEmail.Text = handler.Email;
            dateTimePicker1.Value = handler.DateOfBirth;

            switch (handler.Gender)
            {
                case DataBaseStructure.types.GenderType.Male:
                    newRadioButtonMale.Checked = true;
                    break;
                case DataBaseStructure.types.GenderType.Female:
                    newRadioButtonFemale.Checked = true;
                    break;
                case DataBaseStructure.types.GenderType.Other:
                    newRadioButtonOther.Checked = true;
                    break;
                case DataBaseStructure.types.GenderType.None:
                    newRadioButtonNone.Checked = true;
                    break;
            }

            if (handler.UserType == DataBaseStructure.types.UserType.Teacher)
            {
                //Teacher
                dateTimePicker1.MaxDate = DateTime.Now.AddYears(-18);
            }
            else
            {
                //Student
                dateTimePicker1.MaxDate = DateTime.Now.AddYears(-6);
            }
            dateTimePicker1.Invalidate();
        }

        private void newButtonSave_Click(object sender, EventArgs e)
        {
            if (!PanelAutorization_SingUp.ValidityCheckEmail(textBoxEmail, false))
                return;
            if (!PanelAutorization_SingUp.ValidityCheckName(textBoxFirstName, false))
                return;
            if (!PanelAutorization_SingUp.ValidityCheckName(textBoxLastName, false))
                return;
            if (!PanelAutorization_SingUp.ValidityCheckPhone(textBoxPhone, true))
                return;
            if (!PanelAutorization_SingUp.ValidityCheckPassword(textBoxPassword, true))
                return;

            try
            {
                User thisChengeUser = SkillCourseDB.Instance.Users.FindLast(user => user.IdUser == handler.IdUser);
                if (thisChengeUser == null)
                    throw new Exception("Error user change");

                if (CheckChangedFields(ref thisChengeUser))
                {
                    AccountHandler.Instance.ChangedUserFields(thisChengeUser);
                }
            }
            catch (Exception ex)
            {
                labelMes.Text = ex.Message;
                labelMes.Visible = true;
            }
        }

        private bool CheckChangedFields(ref User user)
        {
            bool change = false;

            if (textBoxFirstName.Text != user.FirstName)
            {
                user.FirstName = textBoxFirstName.Text;
                change = true;
            }
            if (textBoxLastName.Text != user.LastName)
            {
                user.LastName = textBoxLastName.Text;
                change = true;
            }
            if (textBoxEmail.Text != user.Email)
            {
                user.Email = textBoxEmail.Text;
                change = true;
            }
            if (textBoxPassword.Text != user.Password)
            {
                user.Password = textBoxPassword.Text;
                change = true;
            }
            if (textBoxPhone.Text != user.PhoneNumber)
            {
                user.PhoneNumber = textBoxPhone.Text;
                change = true;
            }
            if (dateTimePicker1.Value != user.DateOfBirth)
            {
                user.DateOfBirth = dateTimePicker1.Value;
                change = true;
            }
            GenderType type =
                newRadioButtonNone.Checked == true ? GenderType.None :
                    (newRadioButtonOther.Checked == true ? GenderType.Other :
                        (newRadioButtonMale.Checked == true ? GenderType.Male :
                            GenderType.Female));

            if (type != user.Gender)
            {
                user.Gender = type;
                change = true;
            }

            return change;
        }


        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            PanelAutorization_SingUp.ValidityCheckEmail(textBoxEmail, false);
        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            PanelAutorization_SingUp.ToUpperFirstLetter(sender);
            PanelAutorization_SingUp.ValidityCheckName(textBoxFirstName, false);
        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {
            PanelAutorization_SingUp.ToUpperFirstLetter(sender);
            PanelAutorization_SingUp.ValidityCheckName(textBoxLastName, false);
        }

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {
            PanelAutorization_SingUp.ValidityCheckPhone(textBoxPhone, true);
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            PanelAutorization_SingUp.ValidityCheckPassword(textBoxPassword, true);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        { }
    }
}
