using SkillCourse.DataBaseStructure;
using SkillCourse.DataBaseStructure.types;
using SkillCourse.PanelComponents;
using SkillCourse.Panels.MainBlock.Tasks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SkillCourse.Panels.MainBlock.PanelMainBlock_Courses;
using static SkillCourse.Panels.MainBlock.Tasks.PanelMainBlock_TaskAssigned;

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
                NavigatePages.OpenNewPage(new PanelMainBlock_Courses(ViewCourseState.All, false, false), PanelParent);
                UpdateStateButtons("Courses");
            }

            if (userType == DataBaseStructure.types.UserType.Student)
            {
                NavigatePages.OpenNewPage(new PanelMainBlock_Courses(ViewCourseState.My, true, false), PanelParent);
                UpdateStateButtons("Courses", "Subscribed");
            }

            if (userType == DataBaseStructure.types.UserType.Teacher)
            {
                NavigatePages.OpenNewPage(new PanelMainBlock_Courses(ViewCourseState.All, true, false), PanelParent);
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
                    NavigatePages.OpenNewPage(new PanelMainBlock_Courses(ViewCourseState.All, false, false), PanelParent);
                    UpdateStateButtons("Courses");
                }, null));



            //------- Teachers

            listControls.Add(
                new Component_NavigationBut("Teachers",
                Properties.Resources.ResourceManager.GetObject("view_cozy_FILL0_wght400_GRAD0_opsz48-32.png") as Image,
                false, () =>
                {
                    NavigatePages.OpenNewPage(new PanelMainBlock_Teachers(), PanelParent);
                    UpdateStateButtons("Teachers");
                }, null));



            //------- Certificates

            listControls.Add(
                new Component_NavigationBut("Certificates",
                Properties.Resources.ResourceManager.GetObject("view_cozy_FILL0_wght400_GRAD0_opsz48-32.png") as Image,
                false, () =>
                {
                    NavigatePages.OpenNewPage(new PanelMainBlock_FindCertificate(), PanelParent);
                    UpdateStateButtons("Certificates");
                }, null));
        }


        private void AddBNForStudent(ref List<Component_NavigationBut> listControls)
        {
            //------- Courses

            Action defaultCourseDopButtons = () =>
            {
                NavigatePages.OpenNewPage(new PanelMainBlock_Courses(ViewCourseState.My, true, false), PanelParent);
                UpdateStateButtons("Courses", "Subscribed");
            };

            Action Public_CourseDopButtons = () =>
            {
                NavigatePages.OpenNewPage(new PanelMainBlock_Courses(ViewCourseState.All, false, true), PanelParent); ;
                UpdateStateButtons("Courses", "Public");
            };


            List<Component_NavigationDopBut> CourseDopButtons = new List<Component_NavigationDopBut>()
            {
                new Component_NavigationDopBut("Subscribed", defaultCourseDopButtons),
                new Component_NavigationDopBut("Public", Public_CourseDopButtons)
            };
            CourseDopButtons.Reverse();

            listControls.Add(
                new Component_NavigationBut("Courses",
                Properties.Resources.ResourceManager.GetObject("view_cozy_FILL0_wght400_GRAD0_opsz48-32.png") as Image,
                true, defaultCourseDopButtons, CourseDopButtons));



            //------- Tasks

            Action defaultTasksDopButtons = () =>
            {
                NavigatePages.OpenNewPage(new PanelMainBlock_TaskAssigned(TypeBlockTasks.Missing), PanelParent);
                UpdateStateButtons("Tasks", "Missing");
            };


            Action assigned_TasksDopButtons = () =>
            {
                NavigatePages.OpenNewPage(new PanelMainBlock_TaskAssigned(TypeBlockTasks.Assigned), PanelParent);
                UpdateStateButtons("Tasks", "Assigned");
            };

            Action сhecked_TasksDopButtons = () =>
            {
                NavigatePages.OpenNewPage(new PanelMainBlock_TaskAssigned(TypeBlockTasks.Checked), PanelParent);
                UpdateStateButtons("Tasks", "Checked");
            };


            List<Component_NavigationDopBut> TaskDopButtons = new List<Component_NavigationDopBut>()
            {
                new Component_NavigationDopBut("Missing", defaultTasksDopButtons),
                new Component_NavigationDopBut("Assigned", assigned_TasksDopButtons),
                new Component_NavigationDopBut("Checked", сhecked_TasksDopButtons)
            };
            TaskDopButtons.Reverse();

            listControls.Add(
                new Component_NavigationBut("Tasks",
                Properties.Resources.ResourceManager.GetObject("view_cozy_FILL0_wght400_GRAD0_opsz48-32.png") as Image,
                false, defaultTasksDopButtons, TaskDopButtons));



            //------- Calendar

            //listControls.Add(
            //    new Component_NavigationBut("Calendar",
            //    Properties.Resources.ResourceManager.GetObject("view_cozy_FILL0_wght400_GRAD0_opsz48-32.png") as Image,
            //    false, () =>
            //    {
            //        NavigatePages.openPage(new PanelMainBlock_Certificates(), PanelParent);
            //        UpdateStateButtons("Calendar");
            //    }, null));



            //------- Certificates

            Action defaultCertificatesDopButtons = () =>
            {
                NavigatePages.OpenNewPage(new PanelMainBlock_Certificates(), PanelParent);
                UpdateStateButtons("Certificates", "My");
            };


            Action check_CertificatesDopButtons = () =>
            {
                NavigatePages.OpenNewPage(new PanelMainBlock_FindCertificate(), PanelParent);
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
                    NavigatePages.OpenNewPage(new PanelMainBlock_Teachers(), PanelParent);
                    UpdateStateButtons("Teachers");
                }, null));



            //------- Edit profile

            listControls.Add(
                new Component_NavigationBut("Edit profile",
                Properties.Resources.ResourceManager.GetObject("view_cozy_FILL0_wght400_GRAD0_opsz48-32.png") as Image,
                false, () =>
                {
                    NavigatePages.OpenNewPage(new PanelMainBlock_EditProfile(), PanelParent);
                    UpdateStateButtons("Edit profile");
                }, null));
        }


        private void AddBNForTeacher(ref List<Component_NavigationBut> listControls)
        {
            //------- Courses

            Action defaultCoursesDopButtonPage = () =>
            {
                NavigatePages.OpenNewPage(new PanelMainBlock_Courses(ViewCourseState.All, true, false), PanelParent);
                UpdateStateButtons("Courses", "Created");
            };


            Action public_CoursesDopButtonPage = () =>
            {
                NavigatePages.OpenNewPage(new PanelMainBlock_Courses(ViewCourseState.All, true, false), PanelParent);
                UpdateStateButtons("Courses", "Public");
            };


            List<Component_NavigationDopBut> CourseDopButtons = new List<Component_NavigationDopBut>()
            {
                new Component_NavigationDopBut("Public", public_CoursesDopButtonPage),
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
                    NavigatePages.OpenNewPage(new PanelMainBlock_NotImplemented(), PanelParent);
                    UpdateStateButtons("Queue");
                }, null));



            //------- Certificates

            Action defaultCertificatesDopButtonPage = () =>
            {
                NavigatePages.OpenNewPage(new PanelMainBlock_NotImplemented(), PanelParent);
                UpdateStateButtons("Certificates", "All");
            };

            Action waiting_CertificatesDopButtonPage = () =>
            {
                NavigatePages.OpenNewPage(new PanelMainBlock_NotImplemented(), PanelParent);
                UpdateStateButtons("Certificates", "Waiting");
            };

            Action check_CertificatesDopButtonPage = () =>
            {
                NavigatePages.OpenNewPage(new PanelMainBlock_NotImplemented(), PanelParent);
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
                NavigatePages.OpenNewPage(new PanelMainBlock_NotImplemented(), PanelParent);
                UpdateStateButtons("Students", "My");
            };

            Action all_StudentsDopButtonPage = () =>
            {
                NavigatePages.OpenNewPage(new PanelMainBlock_NotImplemented(), PanelParent);
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
                    NavigatePages.OpenNewPage(new PanelMainBlock_NotImplemented(), PanelParent);
                    UpdateStateButtons("Statistics");
                }, null));



            //------- Edit profile

            listControls.Add(
                new Component_NavigationBut("Edit profile",
                Properties.Resources.ResourceManager.GetObject("view_cozy_FILL0_wght400_GRAD0_opsz48-32.png") as Image,
                false, () =>
                {
                    NavigatePages.OpenNewPage(new PanelMainBlock_EditProfile(), PanelParent);
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
