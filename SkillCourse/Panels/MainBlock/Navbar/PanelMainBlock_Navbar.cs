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
            LoadDefaultPanel(UserType);
            AddButtonToNavbar(UserType);
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
                UpdateStateButtons("Courses");
            }

            if (userType == DataBaseStructure.types.UserType.Teacher)
            {
                NavigatePages.openPage(new PanelMainBlock_Courses(true, false), PanelParent);
                UpdateStateButtons("Courses");
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

            List<Component_NavigationDopBut> CourseDopButtons = new List<Component_NavigationDopBut>()
            {
                new Component_NavigationDopBut("All"),
                new Component_NavigationDopBut("Subscribed")
            };
            CourseDopButtons.Reverse();

            listControls.Add(
                new Component_NavigationBut("Courses",
                Properties.Resources.ResourceManager.GetObject("view_cozy_FILL0_wght400_GRAD0_opsz48-32.png") as Image,
                true, () =>
                {
                    NavigatePages.openPage(new PanelMainBlock_Courses(true, false), PanelParent);
                    UpdateStateButtons("Courses");
                }, CourseDopButtons));



            //------- Tasks

            List<Component_NavigationDopBut> TaskDopButtons = new List<Component_NavigationDopBut>()
            {
                new Component_NavigationDopBut("Assigned"),
                new Component_NavigationDopBut("Missing"),
                new Component_NavigationDopBut("Done")
            };
            TaskDopButtons.Reverse();

            listControls.Add(
                new Component_NavigationBut("Tasks",
                Properties.Resources.ResourceManager.GetObject("view_cozy_FILL0_wght400_GRAD0_opsz48-32.png") as Image,
                false, () =>
                {
                    NavigatePages.openPage(new PanelMainBlock_Certificates(), PanelParent);
                    UpdateStateButtons("Tasks");
                }, TaskDopButtons));



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

            List<Component_NavigationDopBut> CertificatesDopButtons = new List<Component_NavigationDopBut>()
            {
                new Component_NavigationDopBut("My"),
                new Component_NavigationDopBut("Check")
            };
            CertificatesDopButtons.Reverse();

            listControls.Add(
                new Component_NavigationBut("Certificates",
                Properties.Resources.ResourceManager.GetObject("view_cozy_FILL0_wght400_GRAD0_opsz48-32.png") as Image,
                false, () =>
                {
                    NavigatePages.openPage(new PanelMainBlock_Certificates(), PanelParent);
                    UpdateStateButtons("Certificates");
                }, CertificatesDopButtons));



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

            List<Component_NavigationDopBut> CourseDopButtons = new List<Component_NavigationDopBut>()
            {
                new Component_NavigationDopBut("All"),
                new Component_NavigationDopBut("Created")
            };
            CourseDopButtons.Reverse();

            listControls.Add(
                new Component_NavigationBut("Courses",
                Properties.Resources.ResourceManager.GetObject("view_cozy_FILL0_wght400_GRAD0_opsz48-32.png") as Image,
                true, () =>
                {
                    NavigatePages.openPage(new PanelMainBlock_Courses(true, false), PanelParent);
                    UpdateStateButtons("Courses");
                }, CourseDopButtons));



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

            List<Component_NavigationDopBut> CertificatesDopButtons = new List<Component_NavigationDopBut>()
            {
                new Component_NavigationDopBut("All"),
                new Component_NavigationDopBut("Waiting"),
                new Component_NavigationDopBut("Check")
            };
            CertificatesDopButtons.Reverse();

            listControls.Add(
                new Component_NavigationBut("Certificates",
                Properties.Resources.ResourceManager.GetObject("view_cozy_FILL0_wght400_GRAD0_opsz48-32.png") as Image,
                false, () =>
                {
                    NavigatePages.openPage(new PanelMainBlock_Certificates(), PanelParent);
                    UpdateStateButtons("Certificates");
                }, CertificatesDopButtons));



            //------- Students

            List<Component_NavigationDopBut> StudentsDopButtons = new List<Component_NavigationDopBut>()
            {
                new Component_NavigationDopBut("All"),
                new Component_NavigationDopBut("My")
            };
            StudentsDopButtons.Reverse();

            listControls.Add(
                new Component_NavigationBut("Students",
                Properties.Resources.ResourceManager.GetObject("view_cozy_FILL0_wght400_GRAD0_opsz48-32.png") as Image,
                false, () =>
                {
                    NavigatePages.openPage(new PanelMainBlock_Certificates(), PanelParent);
                    UpdateStateButtons("Students");
                }, StudentsDopButtons));



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


        private void UpdateStateButtons(string nameButtonActive)
        {
            foreach (Control item in this.Controls)
            {
                Component_NavigationBut objectPan = (Component_NavigationBut)item;
                if (objectPan.name == nameButtonActive)
                    objectPan.ChangeStateDopButton(true);
                else
                    objectPan.ChangeStateDopButton(false);
            }
        }
    }
}
