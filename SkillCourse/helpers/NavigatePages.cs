using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCourse
{
    public static class NavigatePages
    {
        public static void openPage(UserControl Content, Panel thisPanel)
        {
            if (thisPanel != null)
            {

                if (thisPanel.Controls.Count < 1 || thisPanel.Controls[0] != Content)
                {
                    thisPanel.Controls.Clear();
                    thisPanel.Controls.Add(Content);
                }
            }
        }
    }
}
