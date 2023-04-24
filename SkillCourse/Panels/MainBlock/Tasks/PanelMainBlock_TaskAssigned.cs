using SkillCourse.DataBaseStructure;
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
    public partial class PanelMainBlock_TaskAssigned : UserControl
    {
        private Student handler = (Student)AccountHandler.Instance.UserLog;

        private List<Task> thisTasks = new List<Task>();
        private List<UserControl> ListTasks { get; set; } = new List<UserControl>();

        private TypeBlockTasks thisTypePage = TypeBlockTasks.Missing;


        public PanelMainBlock_TaskAssigned(TypeBlockTasks thisTypePage)
        {
            InitializeComponent();

            customComboBox1.Items.Add("All");
            customComboBox1.Items.AddRange(handler.CoursesSubscribed.Select(course => course.Name).ToArray());
            this.thisTypePage = thisTypePage;
            Name += thisTypePage.ToString();

            foreach (var course in handler.CoursesSubscribed)
            {
                AddCertainTasksToList(course);
            }

            FillListControlTasks();
            FillPanel();
        }

        private void AddCertainTasksToList(Course course)
        {
            switch (thisTypePage)
            {
                case TypeBlockTasks.Missing:
                    label1.Text = "Missing";
                    thisTasks.AddRange(handler.GetOnlyTask_Missing(course));
                    break;

                case TypeBlockTasks.Assigned:
                    label1.Text = "Assigned";
                    thisTasks.AddRange(handler.GetOnlyTask_Assigned(course));
                    break;

                case TypeBlockTasks.Checked:
                    label1.Text = "Checked";
                    thisTasks.AddRange(handler.GetOnlyTask_Checked(course));
                    break;
            }
        }

        private void FillListControlTasks()
        {
            int i = 0;
            ListTasks.Clear();
            foreach (var task in thisTasks)
            {
                ListTasks.Add(new Component_Task(task, ++i, UpdatePanel_OnSelectedIndexChanged));
            }
            ListTasks.Reverse();
        }

        private void FillPanel()
        {
            panelMain.Controls.Clear();
            panelMain.Controls.AddRange(ListTasks.ToArray());

            if (panelMain.Controls.Count < 1)
            {
                panelMain.Controls.Add(new PanelMainBlock_MessageText("There is nothing here."));
                panelMain.Controls[0].Dock = DockStyle.Fill;
            }
        }

        private void customComboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
            => UpdatePanel_OnSelectedIndexChanged();

        private void UpdatePanel_OnSelectedIndexChanged()
        {
            thisTasks.Clear();

            string nameSelectCoure = customComboBox1.Texts;
            if (nameSelectCoure == "All")
            {
                foreach (var course in handler.CoursesSubscribed)
                {
                    AddCertainTasksToList(course);
                }
            }
            else
            {
                Course? thisSelectCourse = handler.GetCourse(nameSelectCoure);
                if (thisSelectCourse != null)
                    AddCertainTasksToList(thisSelectCourse);
            }

            FillListControlTasks();
            FillPanel();
        }

        public enum TypeBlockTasks
        {
            Missing,
            Assigned,
            Checked
        }
    }
}
