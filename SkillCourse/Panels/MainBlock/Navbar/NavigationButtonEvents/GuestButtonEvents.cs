using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SkillCourse.Panels.MainBlock.PanelMainBlock_Courses;

namespace SkillCourse.Panels.MainBlock.Navbar.NavigationButtonEvents
{
    internal static class GuestButtonEvents
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


        public static Action CoursesClick = () =>
        {
            NavigatePages.OpenNewPage(new PanelMainBlock_Courses(ViewCourseState.All, true, false), NavBarHandler.PanelParent);
            NavBarHandler.UpdateStateButtons("Courses");
        };

        public static Action TeachersClick = () =>
        {
            NavigatePages.OpenNewPage(new PanelMainBlock_AllUsers(DataBaseStructure.types.UserType.Teacher), NavBarHandler.PanelParent);
            NavBarHandler.UpdateStateButtons("Teachers");
        };

        public static Action CertificatesClick = () =>
        {
            NavigatePages.OpenNewPage(new PanelMainBlock_FindCertificate(), NavBarHandler.PanelParent);
            NavBarHandler.UpdateStateButtons("Certificates");
        };
    }
}
