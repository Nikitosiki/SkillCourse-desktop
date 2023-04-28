using SkillCourse.DataBaseStructure;
using SkillCourse.DataBaseStructure.serialize;
using SkillCourse.DataBaseStructure.types;
using SkillCourse.handlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkillCourse.Panels.MainBlock
{
    public partial class PanelMainBlock_UserPage : UserControl
    {
        private Teather ThisTeather { get; set; }
        private Student ThisStudent { get; set; }
        public PanelMainBlock_UserPage(User user)
        {
            InitializeComponent();
            FillContactInfo(user);

            switch (user.UserType)
            {
                case UserType.Teacher:
                    OpenPageTeacher((Teather)user);
                    break;

                case UserType.Student:
                    OpenPageStudent((Student)user);
                    break;

                default:
                    throw new Exception("Selected user is not.");
            }

        }

        private void FillContactInfo(User user)
        {
            labelNameType.Text = user.UserType.ToString();
            labelFLName.Text = $"{user.FirstName} {user.LastName}";
            labelEmail.Text = user.Email;
            labelDateBirth.Text = $"+{(int)((DateTime.Now - user.DateOfBirth).TotalDays / 365)} ({user.DateOfBirth.ToString("D")})";
            labelGender.Text = user.Gender.ToString();
            labelLastLoginDate.Text =
                AccountHandler.Instance.UserLog == null || AccountHandler.Instance.UserLog.IdUser != user.IdUser
                ? $"{DateHelper.GetTimeDifferenceString(user.LastLoginDate)} ({user.LastLoginDate})" : "Online";

            if (user.ImagePath != null)
            {
                Image? image = LoadImage($"{SerializeSetting.Default.UserImages}/{user.ImagePath}");
                if (image != null)
                    pictureBoxIcon.Image = image;
            }
        }

        public static Image? LoadImage(string imagePath, Image? errorImage = null)
        {
            try
            {
                using (FileStream stream = new FileStream(imagePath, FileMode.Open))
                {
                    return Image.FromStream(stream);
                }
            }
            catch (Exception ex)
            {
                if (errorImage != null)
                {
                    return errorImage;
                }
                return null;
            }
        }

        private void OpenPageTeacher(Teather user)
        {
            ThisTeather = (Teather)user;

            labelCourses.Text = ThisTeather.MyCourses.Count.ToString();
            labelTasks.Text = ThisTeather.GetAllMyTasks().Count.ToString();
            labelStudents.Text = ThisTeather.GetAllStudents().Count.ToString();
        }

        private void OpenPageStudent(Student user)
        {
            ThisStudent = (Student)user;
            newButton1.Visible = false;
            backRoundPanel3.Visible = false;
        }

        private void newButton_Back_Click(object sender, EventArgs e)
        {
            NavigatePages.BackLactPage();
        }

        private void newButton1_Click(object sender, EventArgs e)
        {
            NavigatePages.OpenNewPage(new PanelMainBlock_Courses(ThisTeather, true, true));
        }
    }
}
