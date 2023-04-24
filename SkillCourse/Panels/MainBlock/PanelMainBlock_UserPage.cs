using SkillCourse.DataBaseStructure;
using SkillCourse.DataBaseStructure.types;
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
        public PanelMainBlock_UserPage(User user)
        {
            InitializeComponent();

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

        private void OpenPageTeacher(Teather user)
        {
            ThisTeather = (Teather)user;
            labelNameType.Text = user.UserType.ToString();

            labelName.Text = $"{user.FirstName} {user.LastName}";
            labelEmail.Text = user.Email;
            labelDateBirth.Text = $"+{(int)((DateTime.Now - user.DateOfBirth).TotalDays / 365)} ({user.DateOfBirth.ToString("D")})";
        }

        private void OpenPageStudent(Student user)
        {

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
