using SkillCourse.DataBaseStructure;
using SkillCourse.DataBaseStructure.types;
using SkillCourse.PanelComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkillCourse.Panels.MainBlock.Navbar
{
    public partial class PanelMainBlock_Navbar : UserControl
    {
        public UserType? UserType { get; private set; }
        public Panel PanelParent { get; private set; }

        public PanelMainBlock_Navbar(UserType? userType, Panel panelParent)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;

            UserType = userType;
            PanelParent = panelParent;

            if (PanelParent == null)
                throw new ArgumentNullException("Error loading navigation bar!");

            AddButtonToNavbar(UserType);
            LoadDefaultPanel(UserType);
        }

        public void Redraw(UserType? userType)
        {
            UserType = userType;
            AddButtonToNavbar(UserType);
            LoadDefaultPanel(UserType);
        }

        //Установка дефолтной страници для разных ролей
        private void LoadDefaultPanel(UserType? userType)
        {
            if (userType == null)
            {
                NavigatePages.openPage(new PanelMainBlock_Courses(false, false), PanelParent);
                UpdateStateButtons("Courses");
            }

            if (userType == DataBaseStructure.types.UserType.Student)
            {
                NavigatePages.openPage(new PanelMainBlock_Courses(true, false), PanelParent);
                UpdateStateButtons("Courses", "Subscribed");
            }

            if (userType == DataBaseStructure.types.UserType.Teacher)
            {
                NavigatePages.openPage(new PanelMainBlock_Courses(true, false), PanelParent);
                UpdateStateButtons("Courses", "Created");
            }
        }

        private void AddButtonToNavbar(UserType? userType)
        {
            List<Component_NavigationBut> buttonControlsList = new List<Component_NavigationBut>();

            switch (userType)
            {
                case null:   // Гость
                    AddBNForGuest(ref buttonControlsList);
                    break;

                case DataBaseStructure.types.UserType.Student:
                    AddBNForStudent(ref buttonControlsList);
                    break;

                case DataBaseStructure.types.UserType.Teacher:
                    AddBNForTeacher(ref buttonControlsList);
                    break;
            }

            this.Controls.Clear();
            buttonControlsList.Reverse();
            foreach (Component_NavigationBut buttonControl in buttonControlsList)
            {
                this.Controls.Add(buttonControl);
            }
        }


        private void AddBNForGuest(ref List<Component_NavigationBut> listControls)
        {
            //------- Courses

            listControls.Add(
                new Component_NavigationBut("Courses",
                Properties.Resources.ResourceManager.GetObject("view_cozy_FILL0_wght400_GRAD0_opsz48-32.png") as Image,
                true, () =>
                {
                    NavigatePages.openPage(new PanelMainBlock_Courses(false, false), PanelParent);
                    UpdateStateButtons("Courses");
                }, null));



            //------- Teachers

            listControls.Add(
                new Component_NavigationBut("Teachers",
                Properties.Resources.ResourceManager.GetObject("view_cozy_FILL0_wght400_GRAD0_opsz48-32.png") as Image,
                false, () =>
                {
                    NavigatePages.openPage(new PanelMainBlock_Certificates(), PanelParent);
                    UpdateStateButtons("Teachers");
                }, null));



            //------- Certificates

            listControls.Add(
                new Component_NavigationBut("Certificates",
                Properties.Resources.ResourceManager.GetObject("view_cozy_FILL0_wght400_GRAD0_opsz48-32.png") as Image,
                false, () =>
                {
                    NavigatePages.openPage(new PanelMainBlock_Certificates(), PanelParent);
                    UpdateStateButtons("Certificates");
                }, null));
        }


        private void AddBNForStudent(ref List<Component_NavigationBut> listControls)
        {
            //------- Courses

            Action defaultCourseDopButtons = () =>
            {
                NavigatePages.openPage(new PanelMainBlock_Courses(true, false), PanelParent);
                UpdateStateButtons("Courses", "Subscribed");
            };

            Action All_CourseDopButtons = () =>
            {
                NavigatePages.openPage(new PanelMainBlock_Courses(true, false), PanelParent);
                UpdateStateButtons("Courses", "All");
            };


            List<Component_NavigationDopBut> CourseDopButtons = new List<Component_NavigationDopBut>()
            {
                new Component_NavigationDopBut("All", All_CourseDopButtons),
                new Component_NavigationDopBut("Subscribed", defaultCourseDopButtons)
            };
            CourseDopButtons.Reverse();

            listControls.Add(
                new Component_NavigationBut("Courses",
                Properties.Resources.ResourceManager.GetObject("view_cozy_FILL0_wght400_GRAD0_opsz48-32.png") as Image,
                true, defaultCourseDopButtons, CourseDopButtons));



            //------- Tasks

            Action defaultTasksDopButtons = () =>
            {
                NavigatePages.openPage(new PanelMainBlock_Certificates(), PanelParent);
                UpdateStateButtons("Tasks", "Assigned");
            };


            Action missing_TasksDopButtons = () =>
            {
                NavigatePages.openPage(new PanelMainBlock_Certificates(), PanelParent);
                UpdateStateButtons("Tasks", "Missing");
            };

            Action done_TasksDopButtons = () =>
            {
                NavigatePages.openPage(new PanelMainBlock_Certificates(), PanelParent);
                UpdateStateButtons("Tasks", "Done");
            };


            List<Component_NavigationDopBut> TaskDopButtons = new List<Component_NavigationDopBut>()
            {
                new Component_NavigationDopBut("Assigned", defaultTasksDopButtons),
                new Component_NavigationDopBut("Missing", missing_TasksDopButtons),
                new Component_NavigationDopBut("Done", done_TasksDopButtons)
            };
            TaskDopButtons.Reverse();

            listControls.Add(
                new Component_NavigationBut("Tasks",
                Properties.Resources.ResourceManager.GetObject("view_cozy_FILL0_wght400_GRAD0_opsz48-32.png") as Image,
                false, defaultTasksDopButtons, TaskDopButtons));



            //------- Calendar

            listControls.Add(
                new Component_NavigationBut("Calendar",
                Properties.Resources.ResourceManager.GetObject("view_cozy_FILL0_wght400_GRAD0_opsz48-32.png") as Image,
                false, () =>
                {
                    NavigatePages.openPage(new PanelMainBlock_Certificates(), PanelParent);
                    UpdateStateButtons("Calendar");
                }, null));



            //------- Certificates

            Action defaultCertificatesDopButtons = () =>
            {
                NavigatePages.openPage(new PanelMainBlock_Certificates(), PanelParent);
                UpdateStateButtons("Certificates", "My");
            };


            Action check_CertificatesDopButtons = () =>
            {
                NavigatePages.openPage(new PanelMainBlock_Certificates(), PanelParent);
                UpdateStateButtons("Certificates", "Check");
            };


            List<Component_NavigationDopBut> CertificatesDopButtons = new List<Component_NavigationDopBut>()
            {
                new Component_NavigationDopBut("My", defaultCertificatesDopButtons),
                new Component_NavigationDopBut("Check", check_CertificatesDopButtons)
            };
            CertificatesDopButtons.Reverse();

            listControls.Add(
                new Component_NavigationBut("Certificates",
                Properties.Resources.ResourceManager.GetObject("view_cozy_FILL0_wght400_GRAD0_opsz48-32.png") as Image,
                false, defaultCertificatesDopButtons, CertificatesDopButtons));



            //------- Teachers

            listControls.Add(
                new Component_NavigationBut("Teachers",
                Properties.Resources.ResourceManager.GetObject("view_cozy_FILL0_wght400_GRAD0_opsz48-32.png") as Image,
                false, () =>
                {
                    NavigatePages.openPage(new PanelMainBlock_Certificates(), PanelParent);
                    UpdateStateButtons("Teachers");
                }, null));



            //------- Edit profile

            listControls.Add(
                new Component_NavigationBut("Edit profile",
                Properties.Resources.ResourceManager.GetObject("view_cozy_FILL0_wght400_GRAD0_opsz48-32.png") as Image,
                false, () =>
                {
                    NavigatePages.openPage(new PanelMainBlock_EditProfile(), PanelParent);
                    UpdateStateButtons("Edit profile");
                }, null));
        }


        private void AddBNForTeacher(ref List<Component_NavigationBut> listControls)
        {
            //------- Courses

            Action defaultCoursesDopButtonPage = () =>
            {
                NavigatePages.openPage(new PanelMainBlock_Courses(true, false), PanelParent);
                UpdateStateButtons("Courses", "Created");
            };


            Action all_CoursesDopButtonPage = () =>
            {
                NavigatePages.openPage(new PanelMainBlock_Courses(true, false), PanelParent);
                UpdateStateButtons("Courses", "All");
            };


            List<Component_NavigationDopBut> CourseDopButtons = new List<Component_NavigationDopBut>()
            {
                new Component_NavigationDopBut("All", all_CoursesDopButtonPage),
                new Component_NavigationDopBut("Created", defaultCoursesDopButtonPage)
            };
            CourseDopButtons.Reverse();

            listControls.Add(
                new Component_NavigationBut("Courses",
                Properties.Resources.ResourceManager.GetObject("view_cozy_FILL0_wght400_GRAD0_opsz48-32.png") as Image,
                true, defaultCoursesDopButtonPage, CourseDopButtons));



            //------- Queue

            listControls.Add(
                new Component_NavigationBut("Queue",
                Properties.Resources.ResourceManager.GetObject("view_cozy_FILL0_wght400_GRAD0_opsz48-32.png") as Image,
                false, () =>
                {
                    NavigatePages.openPage(new PanelMainBlock_Certificates(), PanelParent);
                    UpdateStateButtons("Queue");
                }, null));



            //------- Certificates

            Action defaultCertificatesDopButtonPage = () =>
            {
                NavigatePages.openPage(new PanelMainBlock_Certificates(), PanelParent);
                UpdateStateButtons("Certificates", "All");
            };

            Action waiting_CertificatesDopButtonPage = () =>
            {
                NavigatePages.openPage(new PanelMainBlock_Certificates(), PanelParent);
                UpdateStateButtons("Certificates", "Waiting");
            };

            Action check_CertificatesDopButtonPage = () =>
            {
                NavigatePages.openPage(new PanelMainBlock_Certificates(), PanelParent);
                UpdateStateButtons("Certificates", "Check");
            };


            List<Component_NavigationDopBut> CertificatesDopButtons = new List<Component_NavigationDopBut>()
            {
                new Component_NavigationDopBut("All", defaultCertificatesDopButtonPage),
                new Component_NavigationDopBut("Waiting", waiting_CertificatesDopButtonPage),
                new Component_NavigationDopBut("Check", check_CertificatesDopButtonPage)
            };
            CertificatesDopButtons.Reverse();

            listControls.Add(
                new Component_NavigationBut("Certificates",
                Properties.Resources.ResourceManager.GetObject("view_cozy_FILL0_wght400_GRAD0_opsz48-32.png") as Image,
                false, defaultCertificatesDopButtonPage, CertificatesDopButtons));



            //------- Students

            Action defaultStudentsDopButtonPage = () =>
            {
                NavigatePages.openPage(new PanelMainBlock_Certificates(), PanelParent);
                UpdateStateButtons("Students", "My");
            };

            Action all_StudentsDopButtonPage = () =>
            {
                NavigatePages.openPage(new PanelMainBlock_Certificates(), PanelParent);
                UpdateStateButtons("Students", "All");
            };


            List<Component_NavigationDopBut> StudentsDopButtons = new List<Component_NavigationDopBut>()
            {
                new Component_NavigationDopBut("All", all_StudentsDopButtonPage),
                new Component_NavigationDopBut("My", defaultStudentsDopButtonPage)
            };
            StudentsDopButtons.Reverse();

            listControls.Add(
                new Component_NavigationBut("Students",
                Properties.Resources.ResourceManager.GetObject("view_cozy_FILL0_wght400_GRAD0_opsz48-32.png") as Image,
                false, defaultStudentsDopButtonPage, StudentsDopButtons));



            //------- Statistics

            listControls.Add(
                new Component_NavigationBut("Statistics",
                Properties.Resources.ResourceManager.GetObject("view_cozy_FILL0_wght400_GRAD0_opsz48-32.png") as Image,
                false, () =>
                {
                    NavigatePages.openPage(new PanelMainBlock_Certificates(), PanelParent);
                    UpdateStateButtons("Statistics");
                }, null));



            //------- Edit profile

            listControls.Add(
                new Component_NavigationBut("Edit profile",
                Properties.Resources.ResourceManager.GetObject("view_cozy_FILL0_wght400_GRAD0_opsz48-32.png") as Image,
                false, () =>
                {
                    NavigatePages.openPage(new PanelMainBlock_EditProfile(), PanelParent);
                    UpdateStateButtons("Edit profile");
                }, null));
        }

        //private void ClickButtToPage(string namePage, UserControl openPage, Panel thisPanel)
        //{
        //    NavigatePages.openPage(openPage, thisPanel);
        //    UpdateStateButtons(namePage);
        //}

        private void UpdateStateButtons(string nameButtonActive)
        {
            foreach (Control item in this.Controls)
            {
                Component_NavigationBut objectPan = (Component_NavigationBut)item;
                if (objectPan.name == nameButtonActive)
                    objectPan.ChangeStateButton(true);
                else
                    objectPan.ChangeStateButton(false);
            }
        }

        private void UpdateStateButtons(string nameButtonActive, string nameDopButtonActive)
        {
            foreach (Control item in this.Controls)
            {
                Component_NavigationBut objectPan = (Component_NavigationBut)item;
                if (objectPan.name == nameButtonActive)
                {
                    objectPan.ChangeStateButton(true);
                    objectPan.UpdateStateDopButton(nameDopButtonActive);
                }
                else
                    objectPan.ChangeStateButton(false);
            }
        }
    }
}
