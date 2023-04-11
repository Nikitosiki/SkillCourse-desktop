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
                NavigatePages.openPage(new PanelMainBlock_Courses(), PanelParent);
                UpdateStateButtons("Courses");
            }

            if (userType == DataBaseStructure.types.UserType.Student)
            {
                NavigatePages.openPage(new PanelMainBlock_Courses(), PanelParent);
                UpdateStateButtons("Courses");
            }

            if (userType == DataBaseStructure.types.UserType.Teacher)
            {
                NavigatePages.openPage(new PanelMainBlock_Courses(), PanelParent);
                UpdateStateButtons("Courses");
            }
        }

        private void AddButtonToNavbar(UserType? userType)
        {
            // ТУТ НУЖНО ДОПИСАТЬ ПРОВЕРКУ ДЛЯ КАЖДОЙ РОЛИ!!!


            this.Controls.Add(
                new Component_NavigationBut("Edit profile",
                Properties.Resources.ResourceManager.GetObject("view_cozy_FILL0_wght400_GRAD0_opsz48-32.png") as Image,
                false, () =>
                {
                    NavigatePages.openPage(new PanelMainBlock_EditProfile(), PanelParent);
                    UpdateStateButtons("Edit profile");
                }, null));


            this.Controls.Add(
                new Component_NavigationBut("Certificates",
                Properties.Resources.ResourceManager.GetObject("view_cozy_FILL0_wght400_GRAD0_opsz48-32.png") as Image,
                false, () =>
                {
                    NavigatePages.openPage(new PanelMainBlock_Certificates(), PanelParent);
                    UpdateStateButtons("Certificates");
                }, null));


            this.Controls.Add(
                new Component_NavigationBut("Add Courses",
                Properties.Resources.ResourceManager.GetObject("view_cozy_FILL0_wght400_GRAD0_opsz48-32.png") as Image,
                false, () =>
                {
                    NavigatePages.openPage(new PanelMainBlock_AddCourses(), PanelParent);
                    UpdateStateButtons("Add Courses");
                }, null));


            this.Controls.Add(
                new Component_NavigationBut("Teachers",
                Properties.Resources.ResourceManager.GetObject("view_cozy_FILL0_wght400_GRAD0_opsz48-32.png") as Image,
                false, () =>
                {
                    NavigatePages.openPage(new PanelMainBlock_Teachers(), PanelParent);
                    UpdateStateButtons("Teachers");
                }, null));


            List<Component_NavigationDopBut> CourseDopButtons = new List<Component_NavigationDopBut>()
            {
                //new Component_NavigationDopBut("Info"),
                //new Component_NavigationDopBut("Tasks"),
                new Component_NavigationDopBut("All"),
                new Component_NavigationDopBut("Subscribed")
            };
            CourseDopButtons.Reverse();

            this.Controls.Add(
                new Component_NavigationBut("Courses",
                Properties.Resources.ResourceManager.GetObject("view_cozy_FILL0_wght400_GRAD0_opsz48-32.png") as Image,
                true, () =>
                {
                    NavigatePages.openPage(new PanelMainBlock_Courses(), PanelParent);
                    UpdateStateButtons("Courses");
                }, CourseDopButtons));
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
