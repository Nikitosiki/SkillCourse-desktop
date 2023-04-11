using SkillCourse.Panels;
using SkillCourse.Panels.MainBlock;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NikitosikSUI;
using SkillCourse.DataBaseStructure;
using SkillCourse.DataBaseStructure.types;
using System.IO;
using Microsoft.VisualBasic.ApplicationServices;
using SkillCourse.PanelComponents;
using Microsoft.VisualBasic.Devices;
using SkillCourse.Panels.MainBlock.Navbar;

namespace SkillCourse
{
    public partial class MainForm : Form
    {
        public DataBaseStructure.User? User { get; private set; }


        public MainForm()
        {
            InitializeComponent();
            AccountHandler.Instance.subscribeOnChange(updateUser);

            //--- NavigateBar

            //panelMain.Controls.Add(new PanelMainBlock_Courses());
            panelNavbarBut.Controls.Add(new PanelMainBlock_Navbar((User != null ? User.UserType : null), panelMain));
            //AddButtonToNavbar();

            //--- endNavigateBar

        }

        private void newButtonAuthorization_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "LogIn / RegIn")
            {
                Authorization LoadForm = new Authorization();
                LoadForm.ShowDialog();
            }
            else
            {
                AccountHandler.Instance.LogOut();
            }

        }

        public void updateUser(DataBaseStructure.User? user)
        {
            if (user == null)
            {
                //Все настройки для Не авторизированного пользователя


                User = null;
                labelAuthorization.Location = new Point(labelAuthorization.Location.X, labelAuthorization.Location.Y + 25);
                labelAuthorization.Font = new Font(labelAuthorization.Font.FontFamily, 14);
                labelAuthorization.Text = "\nnot authorized";

                newButtonAuthorization.Text = "LogIn / RegIn";

                ((PanelMainBlock_Navbar)panelNavbarBut.Controls[0]).Redraw(null);
            }
            else
            {

                if (user.UserType == UserType.Teacher)
                {
                    //Все настройки для авторизированного учителя


                }
                else
                {
                    //Все настройки для авторизированного студента


                }


                User = user;
                labelAuthorization.Location = new Point(labelAuthorization.Location.X, labelAuthorization.Location.Y - 25);
                labelAuthorization.Font = new Font(labelAuthorization.Font.FontFamily, 12);
                labelAuthorization.Text = user.FirstName + "\n" + user.LastName;

                newButtonAuthorization.Text = "Go Out";

                ((PanelMainBlock_Navbar)panelNavbarBut.Controls[0]).Redraw(user.UserType);
            }
        }


        #region Navbar
        //private void AddButtonToNavbar()
        //{
        //    panelNavbarBut.Controls.Add(
        //        new Component_NavigationBut("Edit profile",
        //        Properties.Resources.ResourceManager.GetObject("view_cozy_FILL0_wght400_GRAD0_opsz48-32.png") as Image,
        //        false, () =>
        //        {
        //            NavigatePages.openPage(new PanelMainBlock_EditProfile(), panelMain);
        //            UpdateStateButtons("Edit profile");
        //        }, null));


        //    panelNavbarBut.Controls.Add(
        //        new Component_NavigationBut("Certificates",
        //        Properties.Resources.ResourceManager.GetObject("view_cozy_FILL0_wght400_GRAD0_opsz48-32.png") as Image,
        //        false, () =>
        //        {
        //            NavigatePages.openPage(new PanelMainBlock_Certificates(), panelMain);
        //            UpdateStateButtons("Certificates");
        //        }, null));


        //    panelNavbarBut.Controls.Add(
        //        new Component_NavigationBut("Add Courses",
        //        Properties.Resources.ResourceManager.GetObject("view_cozy_FILL0_wght400_GRAD0_opsz48-32.png") as Image,
        //        false, () =>
        //        {
        //            NavigatePages.openPage(new PanelMainBlock_AddCourses(), panelMain);
        //            UpdateStateButtons("Add Courses");
        //        }, null));


        //    panelNavbarBut.Controls.Add(
        //        new Component_NavigationBut("Teachers",
        //        Properties.Resources.ResourceManager.GetObject("view_cozy_FILL0_wght400_GRAD0_opsz48-32.png") as Image,
        //        false, () =>
        //        {
        //            NavigatePages.openPage(new PanelMainBlock_Teachers(), panelMain);
        //            UpdateStateButtons("Teachers");
        //        }, null));


        //    List<Component_NavigationDopBut> CourseDopButtons = new List<Component_NavigationDopBut>()
        //    {
        //        //new Component_NavigationDopBut("Info"),
        //        //new Component_NavigationDopBut("Tasks"),
        //        new Component_NavigationDopBut("All"),
        //        new Component_NavigationDopBut("Subscribed")
        //    };
        //    CourseDopButtons.Reverse();

        //    panelNavbarBut.Controls.Add(
        //        new Component_NavigationBut("Courses",
        //        Properties.Resources.ResourceManager.GetObject("view_cozy_FILL0_wght400_GRAD0_opsz48-32.png") as Image,
        //        true, () =>
        //        {
        //            NavigatePages.openPage(new PanelMainBlock_Courses(), panelMain);
        //            UpdateStateButtons("Courses");
        //        }, CourseDopButtons));
        //}


        //private void UpdateStateButtons(string nameButtonActive)
        //{
        //    foreach (Control item in panelNavbarBut.Controls)
        //    {
        //        Component_NavigationBut objectPan = (Component_NavigationBut)item;
        //        if (objectPan.name == nameButtonActive)
        //            objectPan.ChangeStateDopButton(true);
        //        else
        //            objectPan.ChangeStateDopButton(false);
        //    }
        //}

        #endregion

        #region randomFilling

        //public void Random()
        //{
        //    RandomAddUserToUserCollection();
        //    RandomAddCourseToCourseCollection();

        //    SkillCourseDB DataBase = SkillCourseDB.Instance;
        //    DataBase.Users.Add(new Student("Nik", "Tas", "tas.nk@gmail.com", PasswordEncryptor.Encrypt("000000001"), DateTime.Now.AddDays(-8000), GenderType.Female));
        //    DataBase.Subscriptions.Add(new SubscriptionCourse(2, 5));
        //    DataBase.Tasks.Add(new DataBaseStructure.Task("bla-bla-blabalalala", 5));
        //    DataBase.AnswerTasks.Add(new AnswerTask(StateTask.Done, 2, 1, 2));
        //    DataBase.Certificates.Add(new Certificate("You>!", DateTime.Now, 1, 2, 3));
        //}

        //public void RandomAddUserToUserCollection()
        //{
        //    SkillCourseDB DataBase = SkillCourseDB.Instance;

        //    DataBase.Users.Add(new Teather("Kir", "Leir", "leir.k@gmail.com", PasswordEncryptor.Encrypt("123456789"), DateTime.Now.AddDays(-8000), GenderType.Male));
        //}

        //public void RandomAddCourseToCourseCollection()
        //{
        //    SkillCourseDB DataBase = SkillCourseDB.Instance;
        //    string image = "image008";

        //    for (int i = 0; i < 100; i++)
        //    {
        //        string nameCourse = $"{i} - ый курс, по программированию!";
        //        string descriptionCourse = "Description: Это...";

        //        int idTeather = DataBase.Users.Teathers()[0].IdUser;
        //        Course course = new Course(nameCourse, descriptionCourse, image, idTeather);
        //        DataBase.Courses.Add(course);
        //    }
        //}

        #endregion
    }
}
