using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCourse
{
    public static class NavigatePages
    {
        public static Panel MainParentPanel { get; private set; }

        public static void setMainPanel(Panel panel)
        {
            if (MainParentPanel == null)
                MainParentPanel = panel;
        }

        public static void OpenNewPage(UserControl Content, Panel thisPanel)
        {
            if (thisPanel != null)
            {
                // if (thisPanel.Controls.Count < 1 || thisPanel.Controls[thisPanel.Controls.Count - 1].Name != Content.Name)
                if (thisPanel.Controls.Count < 1 || thisPanel.Controls[thisPanel.Controls.Count - 1].Name != Content.Name)
                {
                    thisPanel.Controls.Clear();
                    thisPanel.Controls.Add(Content);
                }
            }
        }

        public static void OpenNewPage(UserControl Content)
        {
            OpenNewPage(Content, MainParentPanel);
        }

        public static void OpenNextPage(UserControl Content, Panel thisPanel)
        {
            if (thisPanel != null)
            {
                Panel mainPanel = (Panel)thisPanel;

                if (mainPanel.Controls.Count < 1 || mainPanel.Controls[0] != Content)
                {
                    mainPanel.Controls[mainPanel.Controls.Count - 1].Visible = false;
                    mainPanel.Controls.Add(Content);
                }
            }
        }

        public static void OpenNextPage(UserControl Content, Control? thisPanel)
        {
            if (thisPanel != null)
                OpenNextPage(Content, (Panel)thisPanel);
        }

        public static void OpenNextPage(UserControl Content)
        {
            OpenNextPage(Content, MainParentPanel);
        }
    }
}
