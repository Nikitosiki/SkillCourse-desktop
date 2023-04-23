using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.VisualBasic.Devices;
using SkillCourse.DataBaseStructure;
using SkillCourse.PanelComponents;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SkillCourse.Panels.MainBlock
{
    public partial class PanelMainBlock_Courses : UserControl
    {
        public User handlerStud = AccountHandler.Instance.UserLog;

        private List<Course> thisCourses;
        private List<UserControl> ListCoursePanels { get; set; } = new List<UserControl>();
        private List<UserControl> ListCoursePanelsAfterSort { get; set; } = new List<UserControl>();


        private bool VisibleButView { get; set; }
        private bool VisibleButSub { get; set; }

        public PanelMainBlock_Courses(ViewCourseState stateView, bool buttonView, bool buttonSub)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            thisCourses = stateView == ViewCourseState.My ? ((Student)handlerStud).CoursesSubscribed : SkillCourseDB.Instance.Courses;

            VisibleButView = buttonView;
            VisibleButSub = buttonSub;

            string view = VisibleButView ? "View" : "";
            string sub = VisibleButSub ? "Sub" : "";

            Name = $"{Name} {VisibleButView} {VisibleButSub} {ViewCourseState.My}";

            TuneComboBox();
        }

        private void TuneComboBox()
        {
            //Если пользователь не авторизовался, сортировать список он не может
            if (handlerStud == null)
            {
                customComboBox1.Visible = false;
                return;
            }

            //Если пользователь на странице всех кеурсов
            if (VisibleButView)
            {
                customComboBox1.Items.Remove("Only Sub");
                customComboBox1.Items.Remove("Only UnS");
                return;
            }

            //Если пользователь на странице подписок
            if (VisibleButSub)
            {
                return;
            }
        }

        #region LoadPage
        private async void PanelMainBlock_Courses_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            // Вызываем метод, который будет добавлять элементы в фоновом потоке
            await System.Threading.Tasks.Task.Run(() =>
            {
                foreach (Course course in thisCourses)
                {
                    UserControl userControl = CreateCourse(course);
                    ListCoursePanels.Add(userControl);
                    ListCoursePanelsAfterSort.Add(userControl);   //дефолтное заполнение, на случай если фильтрация отключина

                    // Используем метод Invoke, чтобы добавить элемент в контексте потока пользовательского интерфейса
                    flowLayoutPanel1.Invoke((MethodInvoker)delegate
                    {
                        flowLayoutPanel1.Controls.Add(userControl);
                    });
                }
            });
        }

        private UserControl CreateCourse(Course course)
        {
            if (VisibleButView)
                return new Component_BriefСourse_View(course, () => NavigatePages.OpenNextPage(new PanelMainBlock_CoursePage(course), this.Parent));
            if (VisibleButSub)
                return new Component_BriefСourse_Subscription(course, true,
                    () =>
                    {
                        NavigatePages.OpenNextPage(new PanelMainBlock_CoursePage(course), this.Parent);
                        if (!((Student)handlerStud).SubscripToCourse(course))
                            MessageBox.Show("Failed to subscribe, please try again later.");
                    },
                    () =>
                    {
                        if (!((Student)handlerStud).UnSubscripToCourse(course))
                            MessageBox.Show("Failed to unsubscribe, please try again later.");
                    });
            return new Component_BriefСourse_Base(course);

        }
        #endregion

        #region Search/Sort

        private void ReplaceCoursesOnForm(FlowLayoutPanel mainPanel, Control[] controls)
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

        private void textBoxSearcher_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearcher.Texts.Trim() == "")
            {
                ReplaceCoursesOnForm(flowLayoutPanel1, ListCoursePanelsAfterSort.ToArray());
            }
            else
            {
                ReplaceCoursesOnForm(flowLayoutPanel1, ListCoursePanelsAfterSort.FindAll(
                    pan => pan.Name.Contains(textBoxSearcher.Texts, StringComparison.OrdinalIgnoreCase)).ToArray());

            }
        }

        private async void customComboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            ListCoursePanelsAfterSort.Clear();
            List<UserControl> thisCoursePanels = new List<UserControl>(ListCoursePanels);

            // Вызываем метод, который будет добавлять элементы в фоновом потоке
            int selectComboBox = customComboBox1.SelectedIndex;
            await System.Threading.Tasks.Task.Run(() =>
            {

                //A->W
                //W->A
                //Last
                //First
                //Only Sub
                //Only UnS

                switch (selectComboBox)
                {
                    case 0:     //A->W
                        thisCoursePanels.Sort(delegate (UserControl x, UserControl y)
                        {
                            return x.Name.CompareTo(y.Name);
                        });
                        break;

                    case 1:     //W->A
                        thisCoursePanels.Sort(delegate (UserControl x, UserControl y)
                        {
                            // Возвращаем результат сравнения в обратном порядке
                            return y.Name.CompareTo(x.Name);
                        });
                        break;

                    case 2:     //Last
                        thisCoursePanels.Reverse();
                        break;

                    case 3:     //First
                        break;

                    case 4:     //Only Sub
                        thisCoursePanels.RemoveAll(component =>
                        {
                            Component_BriefСourse_Subscription briefCourse = component as Component_BriefСourse_Subscription;
                            return briefCourse != null && !briefCourse.subscript;
                        });
                        break;

                    case 5:     //Only UnS
                        thisCoursePanels.RemoveAll(component =>
                        {
                            Component_BriefСourse_Subscription briefCourse = component as Component_BriefСourse_Subscription;
                            return briefCourse != null && briefCourse.subscript;
                        });
                        break;
                }
            });
            ListCoursePanelsAfterSort.AddRange(thisCoursePanels.ToArray());

            //вызываем метод обновление списка графически
            textBoxSearcher_TextChanged(sender, e);
        }

        #endregion

        public enum ViewCourseState
        {
            My,
            All
        }
    }
}
