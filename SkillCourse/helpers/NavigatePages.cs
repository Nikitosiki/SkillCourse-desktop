using SkillCourse.Panels.MainBlock.Navbar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SkillCourse
{
    public static class NavigatePages
    {
        public static Panel MainParentPanel { get; private set; }

        public static void clearPanel(Panel panel)
        {
            panel.Controls.Clear();
        }

        public static void clearPanel()
        {
            clearPanel(MainParentPanel);
        }

        public static void setMainPanel(Panel panel)
        {
            if (MainParentPanel == null)
                MainParentPanel = panel;
        }

        public static void OpenNewPage(UserControl Content, Panel ParentPanel)
        {
            if (ParentPanel != null)
            {
                // if (thisPanel.Controls.Count < 1 || thisPanel.Controls[thisPanel.Controls.Count - 1].Name != Content.Name)
                if (ParentPanel.Controls.Count < 1 || ParentPanel.Controls[ParentPanel.Controls.Count - 1].Name != Content.Name)
                {
                    ParentPanel.Controls.Clear();
                    ParentPanel.Controls.Add(Content);
                }
            }
            
            GC.Collect();
        }

        public static void OpenNewPage(UserControl Content)
        {
            OpenNewPage(Content, MainParentPanel);
        }

        public static void OpenNextPage(UserControl Content, Panel ParentPanel)
        {
            if (ParentPanel != null)
            {
                Panel mainPanel = (Panel)ParentPanel;

                if (mainPanel.Controls.Count < 1 || mainPanel.Controls[0] != Content)
                {
                    mainPanel.Controls[mainPanel.Controls.Count - 1].Visible = false;
                    mainPanel.Controls.Add(Content);
                }
            }
        }

        public static void OpenNextPage(UserControl Content, Control? ParentPanel)
        {
            if (ParentPanel != null)
                OpenNextPage(Content, (Panel)ParentPanel);
        }

        public static void OpenNextPage(UserControl Content)
        {
            OpenNextPage(Content, MainParentPanel);
        }

        public static void BackPage(Control RemoveContent, Control? ParentPanel)
        {
            if (ParentPanel != null)
            {
                Panel mainPanel = (Panel)ParentPanel;
                mainPanel.Controls.Remove(RemoveContent);

                VisibleBackPage(ParentPanel, mainPanel);
            }
        }

        public static void BackPage(List<Control> RemoveContent, Control? ParentPanel)
        {
            if (ParentPanel != null && ParentPanel.Controls.Count >= RemoveContent.Count)
            {
                Panel mainPanel = (Panel)ParentPanel;
                foreach (var item in RemoveContent)
                {
                    mainPanel.Controls.Remove(item);
                }

                VisibleBackPage(ParentPanel, mainPanel);
            }
        }

        private static void VisibleBackPage(Control? ParentPanel, Panel mainPanel)
        {
            if (ParentPanel.Controls.Count > 0)
            {
                mainPanel.Controls[mainPanel.Controls.Count - 1].Visible = true;
            }
            else
            {
                // Открываем дефолтную страницу (под роль)
                if (PanelMainBlock_Navbar.GetInstance() is PanelMainBlock_Navbar navbar)
                    navbar.LoadDefaultPanel();
            }
        }

        public static void BackPage(Control RemoveContent)
        {
            BackPage(RemoveContent, MainParentPanel);
        }

        public static Control? OnlyGetBackPage()
        {
            if (MainParentPanel != null && MainParentPanel.Controls.Count > 1)
            {
                return MainParentPanel.Controls[MainParentPanel.Controls.Count - 2];
            }
            return null;
        }

        public static void BackLastPage()
        {
            BackPage(MainParentPanel.Controls[MainParentPanel.Controls.Count - 1]);
        }

        //public static void UpdateBackPage()
        //{
        //    if (MainParentPanel != null && MainParentPanel.Controls.Count > 1)
        //    {
        //        MainParentPanel.Controls[MainParentPanel.Controls.Count - 2].Invalidate();
        //    }
        //}
    }
}
