using SkillCourse.DataBaseStructure;
using SkillCourse.DataBaseStructure.types;
using SkillCourse.PanelComponents;
using SkillCourse.Panels.MainBlock.Navbar.NavigationButtonEvents;
using SkillCourse.Panels.MainBlock.Tasks;
using static SkillCourse.Panels.MainBlock.PanelMainBlock_Courses;

namespace SkillCourse.Panels.MainBlock.Navbar
{
    public partial class PanelMainBlock_Navbar : UserControl
    {
        private static PanelMainBlock_Navbar? instance;
        public UserType? UserType { get; private set; }
        public Panel PanelParent { get; private set; }

        public static PanelMainBlock_Navbar NewInstance(UserType? userType, Panel panelParent)
        {
            instance = new PanelMainBlock_Navbar(userType, panelParent);
            return instance;
        }

        public static PanelMainBlock_Navbar? GetInstance()
        {
            return instance;
        }

        private PanelMainBlock_Navbar(UserType? userType, Panel panelParent)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;

            UserType = userType;
            PanelParent = panelParent;

            if (PanelParent == null)
                throw new ArgumentNullException("Error loading navigation bar!");
        }

        private void PanelMainBlock_Navbar_Load(object sender, EventArgs e)
        {
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
        public void LoadDefaultPanel(UserType? userType)
        {
            if (userType == null)
                GuestButtonEvents.CoursesClick?.Invoke();

            if (userType == DataBaseStructure.types.UserType.Student)
                StudentButtonEvents.Course_SubscribedClick?.Invoke();

            if (userType == DataBaseStructure.types.UserType.Teacher)
                TeacherButtonEvents.Course_MyClick?.Invoke();
        }
        public void LoadDefaultPanel()
        {
            LoadDefaultPanel(UserType);
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
                Properties.Resources.ResourceManager.GetObject("courses_wght400_GRAD0_opsz48_32") as Image,
                true, GuestButtonEvents.CoursesClick, null));



            //------- Teachers

            listControls.Add(
                new Component_NavigationBut("Teachers",
                Properties.Resources.ResourceManager.GetObject("small_group_white_24dp") as Image,
                false, GuestButtonEvents.TeachersClick, null));



            //------- Certificates

            listControls.Add(
                new Component_NavigationBut("Certificates",
                Properties.Resources.ResourceManager.GetObject("certificate_wght400_GRAD0_opsz48_32") as Image,
                false, GuestButtonEvents.CertificatesClick, null));
        }


        private void AddBNForStudent(ref List<Component_NavigationBut> listControls)
        {
            //------- Courses

            List<Component_NavigationDopBut> CourseDopButtons = new List<Component_NavigationDopBut>()
            {
                new Component_NavigationDopBut("Subscribed", StudentButtonEvents.Course_SubscribedClick),
                new Component_NavigationDopBut("Public", StudentButtonEvents.Course_PublicClick)
            };
            CourseDopButtons.Reverse();

            listControls.Add(
                new Component_NavigationBut("Courses",
                Properties.Resources.ResourceManager.GetObject("courses_wght400_GRAD0_opsz48_32") as Image,
                true, StudentButtonEvents.Course_SubscribedClick, CourseDopButtons));



            //------- Tasks

            List<Component_NavigationDopBut> TaskDopButtons = new List<Component_NavigationDopBut>()
            {
                new Component_NavigationDopBut("Missing", StudentButtonEvents.Task_AssignedClick),
                new Component_NavigationDopBut("Assigned", StudentButtonEvents.Task_CheckedClick),
                new Component_NavigationDopBut("Checked", StudentButtonEvents.Task_MissingClick)
            };
            TaskDopButtons.Reverse();

            listControls.Add(
                new Component_NavigationBut("Tasks",
                Properties.Resources.ResourceManager.GetObject("checklist_wght400_GRAD0_opsz48_32") as Image,
                false, StudentButtonEvents.Task_AssignedClick, TaskDopButtons));



            //------- Calendar

            //listControls.Add(
            //    new Component_NavigationBut("Calendar",
            //    Properties.Resources.ResourceManager.GetObject("view_cozy_FILL0_wght400_GRAD0_opsz48-32") as Image,
            //    false, () =>
            //    {
            //        NavigatePages.openPage(new PanelMainBlock_Certificates(), PanelParent);
            //        UpdateStateButtons("Calendar");
            //    }, null));



            //------- Certificates

            List<Component_NavigationDopBut> CertificatesDopButtons = new List<Component_NavigationDopBut>()
            {
                new Component_NavigationDopBut("My", StudentButtonEvents.Certificate_MyClick),
                new Component_NavigationDopBut("Check", StudentButtonEvents.Certificate_CheckClick)
            };
            CertificatesDopButtons.Reverse();

            listControls.Add(
                new Component_NavigationBut("Certificates",
                Properties.Resources.ResourceManager.GetObject("certificate_wght400_GRAD0_opsz48_32") as Image,
                false, StudentButtonEvents.Certificate_MyClick, CertificatesDopButtons));



            //------- Teachers

            listControls.Add(
                new Component_NavigationBut("Teachers",
                Properties.Resources.ResourceManager.GetObject("small_group_white_24dp") as Image,
                false, StudentButtonEvents.TeacherClick, null));



            //------- Edit profile

            listControls.Add(
                new Component_NavigationBut("Edit profile",
                Properties.Resources.ResourceManager.GetObject("edit_prifile_cozy_FILL0_wght400_GRAD0_opsz48_32") as Image,
                false, StudentButtonEvents.EditProfileClick, null));
        }


        private void AddBNForTeacher(ref List<Component_NavigationBut> listControls)
        {
            //------- Courses

            List<Component_NavigationDopBut> CourseDopButtons = new List<Component_NavigationDopBut>()
            {
                new Component_NavigationDopBut("My", TeacherButtonEvents.Course_MyClick),
                new Component_NavigationDopBut("Public", TeacherButtonEvents.Course_PublicClick),
                new Component_NavigationDopBut("Create", TeacherButtonEvents.Course_CreateClick)
            };
            CourseDopButtons.Reverse();

            listControls.Add(
                new Component_NavigationBut("Courses",
                Properties.Resources.ResourceManager.GetObject("courses_wght400_GRAD0_opsz48_32") as Image,
                true, TeacherButtonEvents.Course_MyClick, CourseDopButtons));



            //------- Queue

            List<Component_NavigationDopBut> TaskDopButtons = new List<Component_NavigationDopBut>()
            {
                new Component_NavigationDopBut("Waiting", TeacherButtonEvents.Task_WaitingClick),
                new Component_NavigationDopBut("Checked", TeacherButtonEvents.Task_CheckedClick)
            };
            TaskDopButtons.Reverse();

            listControls.Add(
                new Component_NavigationBut("Queue",
                Properties.Resources.ResourceManager.GetObject("checklist_wght400_GRAD0_opsz48_32") as Image,
                false, TeacherButtonEvents.Task_WaitingClick, TaskDopButtons));



            //------- Certificates

            List<Component_NavigationDopBut> CertificatesDopButtons = new List<Component_NavigationDopBut>()
            {
                new Component_NavigationDopBut("Issued", TeacherButtonEvents.Certificate_IssuedClick),
                new Component_NavigationDopBut("Waiting", TeacherButtonEvents.Certificate_WaitingClick),
                new Component_NavigationDopBut("Check", TeacherButtonEvents.Certificate_CheckClick)
            };
            CertificatesDopButtons.Reverse();

            listControls.Add(
                new Component_NavigationBut("Certificates",
                Properties.Resources.ResourceManager.GetObject("add_certificate_wght400_GRAD0_opsz48_32") as Image,
                false, TeacherButtonEvents.Certificate_IssuedClick, CertificatesDopButtons));


            //------- Students

            List<Component_NavigationDopBut> StudentsDopButtons = new List<Component_NavigationDopBut>()
            {
                new Component_NavigationDopBut("My", TeacherButtonEvents.Student_MyClick),
                new Component_NavigationDopBut("All", TeacherButtonEvents.Student_AllClick)
            };
            StudentsDopButtons.Reverse();

            listControls.Add(
                new Component_NavigationBut("Students",
                Properties.Resources.ResourceManager.GetObject("peoples_wght400_GRAD0_opsz48_32") as Image,
                false, TeacherButtonEvents.Student_MyClick, StudentsDopButtons));



            ////------- Statistics

            //listControls.Add(
            //    new Component_NavigationBut("Statistics",
            //    Properties.Resources.ResourceManager.GetObject("view_cozy_FILL0_wght400_GRAD0_opsz48-32") as Image,
            //    false, () =>
            //    {
            //        NavigatePages.OpenNewPage(new PanelMainBlock_NotImplemented(), PanelParent);
            //        UpdateStateButtons("Statistics");
            //    }, null));



            //------- Edit profile

            listControls.Add(
                new Component_NavigationBut("Edit profile",
                Properties.Resources.ResourceManager.GetObject("edit_prifile_cozy_FILL0_wght400_GRAD0_opsz48_32") as Image,
                false, TeacherButtonEvents.EditProfileClick, null));
        }

        //private void ClickButtToPage(string namePage, UserControl openPage, Panel thisPanel)
        //{
        //    NavigatePages.openPage(openPage, thisPanel);
        //    UpdateStateButtons(namePage);
        //}

        public void UpdateStateButtons(string nameButtonActive)
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

        public void UpdateStateButtons(string nameButtonActive, string nameDopButtonActive)
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
