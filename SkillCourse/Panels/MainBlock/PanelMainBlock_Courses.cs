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
        public User handlerUser = AccountHandler.Instance.UserLog;

        private List<Course> thisCourses;
        private List<UserControl> ListCoursePanels { get; set; } = new List<UserControl>();
        private List<UserControl> ListCoursePanelsAfterSort { get; set; } = new List<UserControl>();


        private bool VisibleButView { get; set; }
        private bool VisibleButSub { get; set; }
        private bool myCoursePage = false;

        public PanelMainBlock_Courses(ViewCourseState stateView, bool buttonView, bool buttonSub)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            if (stateView == ViewCourseState.My) myCoursePage = true;
            VisibleButView = buttonView;
            VisibleButSub = buttonSub;

            string view = VisibleButView ? "View" : "";
            string sub = VisibleButSub ? "Sub" : "";

            Name = NameThisPage() + stateView.ToString();

            TuneComboBox();
        }

        public PanelMainBlock_Courses(Teather teacher, bool buttonView, bool buttonSub)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            thisCourses = teacher.MyCourses;

            VisibleButView = buttonView;
            VisibleButSub = buttonSub;
            textBoxSearcher.Texts = $"Teacher: {teacher.FirstName} {teacher.LastName}";
            textBoxSearcher.Enabled = false;

            string view = VisibleButView ? "View" : "";
            string sub = VisibleButSub ? "Sub" : "";

            Name = NameThisPage() + teacher.FirstName + teacher.LastName;

            TuneComboBox();
        }

        private string NameThisPage()
        {
            if (handlerUser == null)
                return $"{Name} {VisibleButView} {VisibleButSub} null";
            else
                return $"{Name} {VisibleButView} {VisibleButSub} {handlerUser.UserType}";
        }

        private List<Course> CustomizationForRole()
        {
            //Настраиваем курсы для разных ролей
            if (handlerUser == null)
                return SkillCourseDB.Instance.Courses;

            if (handlerUser.UserType == DataBaseStructure.types.UserType.Student)
                return myCoursePage ? ((Student)handlerUser).CoursesSubscribed : SkillCourseDB.Instance.Courses;
            else
                return myCoursePage ? ((Teather)handlerUser).MyCourses : SkillCourseDB.Instance.Courses;
        }

        private void TuneComboBox()
        {
            //Если пользователь не авторизовался, сортировать список он не может
            if (handlerUser == null)
            {
                customComboBox1.Visible = false;
                return;
            }

            //Если пользователь на странице подписок, с возможностью зайти на курс
            if (VisibleButSub && VisibleButView)
            {
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
            thisCourses = CustomizationForRole();

            flowLayoutPanel1.Controls.Clear();

            //Если нету курсов, то мы присваеваем дефолтную панель
            if (myCoursePage && thisCourses.Count < 1)
            {
                UserControl newPanel = new PanelMainBlock_Message_NoCourses();
                flowLayoutPanel1.Controls.Add(newPanel);
                ListCoursePanels.Add(newPanel);
                ListCoursePanelsAfterSort.Add(newPanel);
                textBoxSearcher.Enabled = false;
                return;
            }

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
            // не зарег пользователь не имеет подписок, и не может попасть на страницу подписок
            if (handlerUser == null)
                return CreateCourseForGuest(course);

            if (handlerUser.UserType == DataBaseStructure.types.UserType.Student)
            {
                return CreateCourseForStudent(course);
            }

            if (handlerUser.UserType == DataBaseStructure.types.UserType.Teacher)
            {
                return CreateCourseForTeacher(course);
            }

            return new Component_BriefСourse_Base(course);
        }

        private UserControl CreateCourseForStudent(Course course)
        {
            //Если пользователь на странице подписок, с возможностью зайти на курс
            if (VisibleButView && VisibleButSub)
            {
                return new Component_BriefСourse_View_Sub(course, true,
                    () => NavigatePages.OpenNextPage(new PanelMainBlock_CoursePage(course)),
                    () =>
                    {
                        if (!((Student)handlerUser).SubscripToCourse(course))
                            MessageBox.Show("Failed to subscribe, please try again later.");
                        NavigatePages.OpenNextPage(new PanelMainBlock_CoursePage(course), this.Parent);
                    },
                    () =>
                    {
                        if (!((Student)handlerUser).UnSubscripToCourse(course))
                            MessageBox.Show("Failed to unsubscribe, please try again later.");
                    });
            }

            if (VisibleButView)
                return new Component_BriefСourse_View(course, () => NavigatePages.OpenNextPage(new PanelMainBlock_CoursePage(course), this.Parent));
            if (VisibleButSub)
            {
                return new Component_BriefСourse_Subscription(course, true,
                    () =>
                    {
                        if (!((Student)handlerUser).SubscripToCourse(course))
                            MessageBox.Show("Failed to subscribe, please try again later.");
                        NavigatePages.OpenNextPage(new PanelMainBlock_CoursePage(course), this.Parent);
                    },
                    () =>
                    {
                        if (!((Student)handlerUser).UnSubscripToCourse(course))
                            MessageBox.Show("Failed to unsubscribe, please try again later.");
                    });
            }
            return new Component_BriefСourse_Base(course);
        }

        private UserControl CreateCourseForTeacher(Course course)
        {
            if (VisibleButView)
                return new Component_BriefСourse_View(course, () => NavigatePages.OpenNextPage(new PanelMainBlock_CoursePage(course), this.Parent));
            else
                return new Component_BriefСourse_Base(course);
        }

        private UserControl CreateCourseForGuest(Course course)
        {
            if (VisibleButView)
                return new Component_BriefСourse_View(course, () => NavigatePages.OpenNextPage(new PanelMainBlock_CoursePage(course), this.Parent));
            else
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
            if (textBoxSearcher.Texts.Trim() == "" || textBoxSearcher.Enabled == false)
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
                            Component_BriefСourse_Subscription briefCourse1 = component as Component_BriefСourse_Subscription;
                            Component_BriefСourse_View_Sub briefCourse2 = component as Component_BriefСourse_View_Sub;

                            return (briefCourse1 != null && !briefCourse1.subscript) || (briefCourse2 != null && !briefCourse2.subscript);
                        });
                        break;

                    case 5:     //Only UnS
                        thisCoursePanels.RemoveAll(component =>
                        {
                            Component_BriefСourse_Subscription briefCourse1 = component as Component_BriefСourse_Subscription;
                            Component_BriefСourse_View_Sub briefCourse2 = component as Component_BriefСourse_View_Sub;

                            return (briefCourse1 != null && briefCourse1.subscript) || (briefCourse2 != null && briefCourse2.subscript);
                        });
                        break;
                }
            });
            ListCoursePanelsAfterSort.AddRange(thisCoursePanels.ToArray());

            //вызываем метод обновление списка графически
            textBoxSearcher_TextChanged(sender, e);
        }

        #endregion

        public new void Invalidate()
        {
            this.OnLoad(EventArgs.Empty);
            base.Invalidate();
        }

        public enum ViewCourseState
        {
            My,
            All
        }
    }
}
