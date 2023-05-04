using SkillCourse.DataBaseStructure;
using SkillCourse.handlers;
using SkillCourse.PanelComponents;
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
using Task = SkillCourse.DataBaseStructure.Task;

namespace SkillCourse.Panels.MainBlock.Tasks
{
    public partial class PanelMainBlock_TasksForTeacher : UserControl
    {
        private Teather handler = (Teather)AccountHandler.Instance.UserLog;

        private List<AnswerTask> thisAnswerTasks = new List<AnswerTask>();
        private List<UserControl> ListAnswerTasks { get; set; } = new List<UserControl>();

        private TypeBlockTasks thisTypePage = TypeBlockTasks.Waiting;


        public PanelMainBlock_TasksForTeacher(TypeBlockTasks thisTypePage)
        {
            InitializeComponent();

            customComboBoxCourse.Items.Add("All");
            customComboBoxCourse.Items.AddRange(handler.MyCourses.Select(course => course.Name).ToArray());
            customComboBoxTask.Items.Add("All Task");
            this.thisTypePage = thisTypePage;
            Name += thisTypePage.ToString();

            UpdatePanel_OnSelectedIndexChanged();

            FillListControlTasks();
            FillPanel();
        }

        private void AddCertainAnswerTasksToList(Task task)
        {
            switch (thisTypePage)
            {
                case TypeBlockTasks.Waiting:
                    label1.Text = "Waiting";
                    thisAnswerTasks.AddRange(handler.GetAllAnswerTask_Waiting(task));
                    break;

                case TypeBlockTasks.Checked:
                    label1.Text = "Checked";
                    thisAnswerTasks.AddRange(handler.GetAllAnswerTask_Checked(task));
                    break;
            }
        }

        private void FillListControlTasks()
        {
            int i = 0;
            ListAnswerTasks.Clear();
            foreach (var answer in thisAnswerTasks)
            {
                ListAnswerTasks.Add(new Component_AnswerTaskForTeacher(answer, ++i, RemoveThisTaskToPanel));
            }
            ListAnswerTasks.Reverse();
        }

        private void FillPanel()
        {
            panelMain.Controls.Clear();
            panelMain.Controls.AddRange(ListAnswerTasks.ToArray());

            if (panelMain.Controls.Count < 1)
            {
                panelMain.Controls.Add(new PanelMainBlock_MessageText("There is nothing here."));
                panelMain.Controls[0].Dock = DockStyle.Fill;
            }
        }

        private void RemoveThisTaskToPanel(UserControl task)
        {
            if (thisTypePage == TypeBlockTasks.Waiting)
            {
                panelMain.Controls.Remove(task);

                if (panelMain.Controls.Count < 1)
                {
                    panelMain.Controls.Add(new PanelMainBlock_MessageText("There is nothing here."));
                    panelMain.Controls[0].Dock = DockStyle.Fill;
                }
            }
        }

        #region SelectComboBox
        private void UpdateTaskComboBox(Course? course)         // null = "All Task"
        {
            customComboBoxTask.Items.Clear();
            customComboBoxTask.Items.Add("All Task");
            customComboBoxTask.SelectedIndex = 0;

            if (course != null)
            {
                customComboBoxTask.Items.AddRange(handler.GetTasksNoMessage(course).Select(task => task.TextTask).ToArray());
                return;
            }
        }

        private void customComboBoxCourse_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTaskComboBox(UserHandler.FindCourse(customComboBoxCourse.Texts));
            UpdatePanel_OnSelectedIndexChanged();
        }

        private void customComboBoxTask_OnSelectedIndexChanged(object sender, EventArgs e)
            => UpdatePanel_OnSelectedIndexChanged();

        private void UpdatePanel_OnSelectedIndexChanged()
        {
            thisAnswerTasks.Clear();

            string nameSelectCoure = customComboBoxCourse.Texts;
            string nameSelectTask  = customComboBoxTask.Texts;

            if (nameSelectCoure == "All")
            {
                // All Course  &&  All Task
                foreach (var course in handler.MyCourses)
                {
                    foreach (var task in handler.GetTasksNoMessage(course))
                    {
                        AddCertainAnswerTasksToList(task);
                    }
                }

            }
            else
            {
                if (nameSelectTask == "All Task")
                {
                    // Select Course  &&  All Task
                    if (UserHandler.FindCourse(nameSelectCoure) is Course selectCourse)
                        foreach (var task in handler.GetTasksNoMessage(selectCourse))
                        {
                            AddCertainAnswerTasksToList(task);
                        }
                }
                else
                {
                    // Select Course  &&  Select Task
                    if (UserHandler.FindCourse(nameSelectCoure) is Course selectCourse)
                        if (UserHandler.FindTask(selectCourse, nameSelectTask) is Task selectTask)
                            AddCertainAnswerTasksToList(selectTask);

                }
            }

            FillListControlTasks();
            FillPanel();
        }
        #endregion SelectComboBox

        public enum TypeBlockTasks
        {
            Checked,
            Waiting
        }
    }
}
