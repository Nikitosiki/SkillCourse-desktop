using SkillCourse.DataBaseStructure;
using SkillCourse.PanelComponents.UsersPage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkillCourse.Panels.MainBlock
{
    public partial class PanelMainBlock_Teachers : UserControl
    {
        private List<User> allTeachers;
        private List<UserControl> ListTeacherPanels { get; set; } = new List<UserControl>();
        public PanelMainBlock_Teachers()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;

            allTeachers = SkillCourseDB.Instance.Users.FindAll(user => user.UserType == DataBaseStructure.types.UserType.Teacher);
        }

        private async void PanelMainBlock_Teachers_Load(object sender, EventArgs e)
        {
            panelMainTeachers.Controls.Clear();

            // Вызываем метод, который будет добавлять элементы в фоновом потоке
            await System.Threading.Tasks.Task.Run(() =>
            {
                foreach (User teacher in allTeachers)
                {
                    UserControl userControl = new Component_UserText(teacher);
                    userControl.Dock = DockStyle.Top;
                    ListTeacherPanels.Add(userControl);

                    // Используем метод Invoke, чтобы добавить элемент в контексте потока пользовательского интерфейса
                    panelMainTeachers.Invoke((MethodInvoker)delegate
                    {
                        panelMainTeachers.Controls.Add(userControl);
                    });
                }
            });
        }

        private void textBoxSearcher_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearcher.Texts.Trim() == "")
            {
                ReplaceCoursesOnForm(panelMainTeachers, ListTeacherPanels.ToArray());
            }
            else
            {
                ReplaceCoursesOnForm(panelMainTeachers, ListTeacherPanels.FindAll(
                    pan => pan.Name.Contains(textBoxSearcher.Texts, StringComparison.OrdinalIgnoreCase)).ToArray());

            }
        }

        private void ReplaceCoursesOnForm(Panel mainPanel, Control[] controls)
        {
            //отключаем логику отрисовки формы
            mainPanel.SuspendLayout();

            try
            {
                while (mainPanel.Controls.Count != 0)
                {
                    mainPanel.Controls.RemoveAt(mainPanel.Controls.Count - 1);
                }

                for (int i = 0; i < controls.Length; ++i)
                {
                    mainPanel.Controls.Add(controls[i]);
                }
            }
            finally
            {
                //включаем логику отрисовки формы
                mainPanel.ResumeLayout(true);
            }

        }
    }
}
