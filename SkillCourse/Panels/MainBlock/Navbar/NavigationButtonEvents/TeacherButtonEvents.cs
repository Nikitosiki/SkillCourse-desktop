using SkillCourse.DataBaseStructure;
using SkillCourse.Panels.MainBlock.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SkillCourse.Panels.MainBlock.PanelMainBlock_Courses;

namespace SkillCourse.Panels.MainBlock.Navbar.NavigationButtonEvents
{
    internal static class TeacherButtonEvents
    {
        private static PanelMainBlock_Navbar NavBarHandler
        {
            get
            {
                if (PanelMainBlock_Navbar.GetInstance() == null)
                    throw new Exception("Navbar get Instance is null");

                return PanelMainBlock_Navbar.GetInstance();
            }
        }


        //------- Course

        public static Action Course_MyClick = () =>
        {
            NavigatePages.OpenNewPage(new PanelMainBlock_Courses(ViewCourseState.My, true, false), NavBarHandler.PanelParent);
            NavBarHandler.UpdateStateButtons("Courses", "My");
        };

        public static Action Course_CreateClick = () =>
        {
            NavigatePages.OpenNewPage(new PanelMainBlock_CreateCourse());
            NavBarHandler.UpdateStateButtons("Courses", "Create");
        };

        public static Action Course_PublicClick = () =>
        {
            NavigatePages.OpenNewPage(new PanelMainBlock_Courses(ViewCourseState.All, true, false), NavBarHandler.PanelParent);
            NavBarHandler.UpdateStateButtons("Courses", "Public");
        };


        //------- Task

        public static Action Task_WaitingClick = () =>
        {
            NavigatePages.OpenNewPage(new PanelMainBlock_TasksForTeacher(PanelMainBlock_TasksForTeacher.TypeBlockTasks.Waiting), NavBarHandler.PanelParent);
            NavBarHandler.UpdateStateButtons("Queue", "Waiting");
        };

        public static Action Task_CheckedClick = () =>
        {
            NavigatePages.OpenNewPage(new PanelMainBlock_TasksForTeacher(PanelMainBlock_TasksForTeacher.TypeBlockTasks.Checked), NavBarHandler.PanelParent);
            NavBarHandler.UpdateStateButtons("Queue", "Checked");
        };


        //------- Certificate

        public static Action Certificate_IssuedClick = () =>
        {
            NavigatePages.OpenNewPage(new PanelMainBlock_NotImplemented(), NavBarHandler.PanelParent);
            NavBarHandler.UpdateStateButtons("Certificates", "Issued");
        };

        public static Action Certificate_WaitingClick = () =>
        {
            NavigatePages.OpenNewPage(new PanelMainBlock_NotImplemented(), NavBarHandler.PanelParent);
            NavBarHandler.UpdateStateButtons("Certificates", "Waiting");
        };

        public static Action Certificate_CheckClick = () =>
        {
            NavigatePages.OpenNewPage(new PanelMainBlock_FindCertificate(), NavBarHandler.PanelParent);
            NavBarHandler.UpdateStateButtons("Certificates", "Check");
        };


        //------- Student

        public static Action Student_MyClick = () =>
        {
            if (AccountHandler.Instance.UserLog is Teather handler)
            {
                NavigatePages.OpenNewPage(new PanelMainBlock_AllUsers(handler.GetAllStudents()), NavBarHandler.PanelParent);
                NavBarHandler.UpdateStateButtons("Students", "My");
            }
        };

        public static Action Student_AllClick = () =>
        {
            NavigatePages.OpenNewPage(new PanelMainBlock_AllUsers(DataBaseStructure.types.UserType.Student), NavBarHandler.PanelParent);
            NavBarHandler.UpdateStateButtons("Students", "All");
        };


        //------- Edit profile

        public static Action EditProfileClick = () =>
        {
            NavigatePages.OpenNewPage(new PanelMainBlock_EditProfile(), NavBarHandler.PanelParent);
            NavBarHandler.UpdateStateButtons("Edit profile");
        };
    }
}
