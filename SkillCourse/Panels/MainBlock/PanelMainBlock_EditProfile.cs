using SkillCourse.DataBaseStructure;
using SkillCourse.DataBaseStructure.serialize;
using SkillCourse.DataBaseStructure.types;
using SkillCourse.helperConfig;
using SkillCourse.helpers;
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
        private User handler = AccountHandler.Instance.UserLog;
        private Image? NewImageUser { get; set; }

        public PanelMainBlock_EditProfile()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;

            textBoxLastName.Text = handler.LastName;
            textBoxFirstName.Text = handler.FirstName;
            textBoxPhone.Text = handler.PhoneNumber;
            textBoxEmail.Text = handler.Email;
            dateTimePicker1.Value = handler.DateOfBirth;
            string path = SerializeSetting.Default.UserImages + handler.ImagePath;
            if (ImageSaveHelper.LoadUserImageFromFile(path) is Image image)
                pictureBoxIcon.Image = image;

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
            if (buttonChangePassword.Visible == false)
                if (!PanelAutorization_SingUp.ValidityCheckPassword(textBoxPassword, false))
                    return;

            try
            {
                User thisChengeUser = SkillCourseDB.Instance.Users.FindLast(user => user.IdUser == handler.IdUser);
                if (thisChengeUser == null)
                    throw new Exception("Error user change");

                if (CheckChangedFields(ref thisChengeUser))
                {
                    if (buttonChangePassword.Visible == true)
                        AccountHandler.Instance.ChangedUserFields(thisChengeUser);
                    else
                        AccountHandler.Instance.ChangedUserFields(thisChengeUser, textBoxPassword.Text);
                }
            }
            catch (Exception ex)
            {
                labelMes.Text = ex.Message;
                labelMes.Visible = true;
            }
        }

        private void customRoundedButton1_Click(object sender, EventArgs e)
        {
            buttonChangePassword.Hide();
            textBoxPassword.Show();
        }

        private bool CheckChangedFields(ref User user)
        {
            bool change = false;

            if (NewImageUser != null)
            {
                ChangeUserImageFile(user);
                change = true;
            }
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
            if (buttonChangePassword.Visible == false && textBoxPassword.Text != "")
            {
                //user.Password = textBoxPassword.Text;
                change = true;
            }
            if (!(user.PhoneNumber == null || user.PhoneNumber == "") && !(textBoxPhone.Text == null || textBoxPhone.Text == ""))
            {
                if (user.PhoneNumber != textBoxPhone.Text)
                {
                    user.PhoneNumber = textBoxPhone.Text;
                    change = true;
                }
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

        private void ChangeUserImageFile(User user)
        {
            if (NewImageUser == null)
                return;

            string imagePath = "";
            if (user.ImagePath == "" || user.ImagePath == null)
            {
                imagePath = user.FirstName + user.LastName + "_" + user.IdUser + ".png";
                user.ImagePath = imagePath;
                AccountHandler.Instance.ChangedUserFields(user, false);          //только присваиваю новое назнание картинки пользователю, в случае его утсутствия
            }
            else
            {
                imagePath = user.ImagePath;
            }

            ImageSaveHelper.SaveImageToFile(ImageSaveHelper.TypeImage.User, imagePath, NewImageUser);
            NewImageUser = null;

            //Image? image = ImageSaveHelper.SelectDialogAndSaveImage(ImageSaveHelper.TypeImage.User, imagePath);
            //if (image != null)
            //{
            //    if (pictureBoxIcon.Image != null)
            //        pictureBoxIcon.Image.Dispose();
            //    pictureBoxIcon.Image = image;
            //    // Здесь может быть обновление картинки на главной страници пользователя z-z-z-zzzzz
            //}
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
            PanelAutorization_SingUp.ValidityCheckPassword(textBoxPassword, false);
        }

        private void roundedButtonEditImage_Click(object sender, EventArgs e)
        {
            if (ImageSaveHelper.SelectDialogImage() is Image image)
            {
                image = ImageSaveHelper.ResizeImageWithCrop(image, CustomImageSize.User.targetWidth, CustomImageSize.User.targetHeight);
                if (pictureBoxIcon.Image != null)
                    pictureBoxIcon.Image.Dispose();
                pictureBoxIcon.Image = image;
                NewImageUser = image;
            }
        }
    }
}
