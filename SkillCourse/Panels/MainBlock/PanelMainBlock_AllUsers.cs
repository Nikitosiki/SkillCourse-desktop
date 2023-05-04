using SkillCourse.DataBaseStructure;
using SkillCourse.DataBaseStructure.types;
using SkillCourse.PanelComponents.UsersPage;
using SkillCourse.Panels.MainBlock.Notification;
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
    public partial class PanelMainBlock_AllUsers : UserControl
    {
        private List<User> allUsers;
        private List<UserControl> ListUserPanels { get; set; } = new List<UserControl>();
        public PanelMainBlock_AllUsers(UserType userType)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            Name += userType.ToString();

            if (userType == UserType.Teacher)
                allUsers = SkillCourseDB.Instance.Users.FindAll(user => user.UserType == DataBaseStructure.types.UserType.Teacher);
            else
                allUsers = SkillCourseDB.Instance.Users.FindAll(user => user.UserType == DataBaseStructure.types.UserType.Student);
        }

        public PanelMainBlock_AllUsers(List<User> allUsers)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            Name += allUsers.Count.ToString();

            this.allUsers = allUsers;
        }

        public PanelMainBlock_AllUsers(List<Student> allUsers) : this(allUsers.Cast<User>().ToList())
        { }

        public PanelMainBlock_AllUsers(List<Teather> allUsers) : this(allUsers.Cast<User>().ToList())
        { }

        private async void PanelMainBlock_Teachers_Load(object sender, EventArgs e)
        {
            panelMainTeachers.Controls.Clear();

            // Вызываем метод, который будет добавлять элементы в фоновом потоке
            await System.Threading.Tasks.Task.Run(() =>
            {
                foreach (User teacher in allUsers)
                {
                    UserControl userControl = new Component_UserText(teacher);
                    userControl.Dock = DockStyle.Top;
                    ListUserPanels.Add(userControl);

                    // Используем метод Invoke, чтобы добавить элемент в контексте потока пользовательского интерфейса
                    panelMainTeachers.Invoke((MethodInvoker)delegate
                    {
                        panelMainTeachers.Controls.Add(userControl);
                    });
                }

                if (allUsers.Count < 1)
                    panelMainTeachers.Invoke((MethodInvoker)delegate
                    {
                        Control newMessage = new PanelMainBlock_MessageText("No one here yet, come back later.");
                        newMessage.Dock = DockStyle.Fill;
                        panelMainTeachers.Controls.Add(newMessage);
                    });
            });
        }

        private void textBoxSearcher_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearcher.Texts.Trim() == "")
            {
                ReplaceCoursesOnForm(panelMainTeachers, ListUserPanels.ToArray());
            }
            else
            {
                ReplaceCoursesOnForm(panelMainTeachers, ListUserPanels.FindAll(
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
