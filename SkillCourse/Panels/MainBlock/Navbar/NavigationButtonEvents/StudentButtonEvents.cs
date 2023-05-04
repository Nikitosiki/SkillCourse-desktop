using SkillCourse.Panels.MainBlock.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SkillCourse.Panels.MainBlock.PanelMainBlock_Courses;

namespace SkillCourse.Panels.MainBlock.Navbar.NavigationButtonEvents
{
    internal static class StudentButtonEvents
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

        public static Action Course_SubscribedClick = () =>
        {
            NavigatePages.OpenNewPage(new PanelMainBlock_Courses(ViewCourseState.My, true, false), NavBarHandler.PanelParent);
            NavBarHandler.UpdateStateButtons("Courses", "Subscribed");
        };

        public static Action Course_PublicClick = () =>
        {
            NavigatePages.OpenNewPage(new PanelMainBlock_Courses(ViewCourseState.All, false, true), NavBarHandler.PanelParent); ;
            NavBarHandler.UpdateStateButtons("Courses", "Public");
        };


        //------- Task

        public static Action Task_AssignedClick = () =>
        {
            NavigatePages.OpenNewPage(new PanelMainBlock_TasksForStudent(PanelMainBlock_TasksForStudent.TypeBlockTasks.Missing), NavBarHandler.PanelParent);
            NavBarHandler.UpdateStateButtons("Tasks", "Missing");
        };

        public static Action Task_CheckedClick = () =>
        {
            NavigatePages.OpenNewPage(new PanelMainBlock_TasksForStudent(PanelMainBlock_TasksForStudent.TypeBlockTasks.Assigned), NavBarHandler.PanelParent);
            NavBarHandler.UpdateStateButtons("Tasks", "Assigned");
        };

        public static Action Task_MissingClick = () =>
        {
            NavigatePages.OpenNewPage(new PanelMainBlock_TasksForStudent(PanelMainBlock_TasksForStudent.TypeBlockTasks.Checked), NavBarHandler.PanelParent);
            NavBarHandler.UpdateStateButtons("Tasks", "Checked");
        };


        //------- Certificate

        public static Action Certificate_MyClick = () =>
        {
            NavigatePages.OpenNewPage(new PanelMainBlock_Certificates(), NavBarHandler.PanelParent);
            NavBarHandler.UpdateStateButtons("Certificates", "My");
        };

        public static Action Certificate_CheckClick = () =>
        {
            NavigatePages.OpenNewPage(new PanelMainBlock_FindCertificate(), NavBarHandler.PanelParent);
            NavBarHandler.UpdateStateButtons("Certificates", "Check");
        };


        //------- Teacher

        public static Action TeacherClick = () =>
        {
            NavigatePages.OpenNewPage(new PanelMainBlock_AllUsers(DataBaseStructure.types.UserType.Teacher), NavBarHandler.PanelParent);
            NavBarHandler.UpdateStateButtons("Teachers");
        };


        //------- Edit profile

        public static Action EditProfileClick = () =>
        {
            NavigatePages.OpenNewPage(new PanelMainBlock_EditProfile(), NavBarHandler.PanelParent);
            NavBarHandler.UpdateStateButtons("Edit profile");
        };
    }
}
