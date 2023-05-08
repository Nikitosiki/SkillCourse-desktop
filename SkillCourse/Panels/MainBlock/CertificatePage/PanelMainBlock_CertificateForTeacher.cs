using SkillCourse.DataBaseStructure;
using SkillCourse.handlers;
using SkillCourse.PanelComponents;
using SkillCourse.Panels.MainBlock.Notification;
using System.Data;
using Task = SkillCourse.DataBaseStructure.Task;

namespace SkillCourse.Panels.MainBlock.CertificatePage
{
    public partial class PanelMainBlock_CertificateForTeacher : UserControl
    {
        private Teather handler = (Teather)AccountHandler.Instance.UserLog;

        private List<SubscriptionCourse> thisSubCourse = new List<SubscriptionCourse>();
        private List<UserControl> ListSubStudents { get; set; } = new List<UserControl>();

        private TypeBlockTasks thisTypePage = TypeBlockTasks.Waiting;


        public PanelMainBlock_CertificateForTeacher(TypeBlockTasks thisTypePage)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;

            customComboBox1.Items.Add("All");
            customComboBox1.Items.AddRange(handler.MyCourses.Select(course => course.Name).ToArray());
            this.thisTypePage = thisTypePage;
            Name += thisTypePage.ToString();

            UpdatePanel_OnSelectedIndexChanged();

            FillListControlTasks();
            FillPanel();
        }

        private void AddCertainTasksToList(Course course)
        {
            switch (thisTypePage)
            {
                case TypeBlockTasks.Waiting:
                    label1.Text = "Waiting";
                    thisSubCourse.AddRange(handler.GetOnlySub_Waiting(course));
                    break;

                case TypeBlockTasks.Issued:
                    label1.Text = "Issued";
                    thisSubCourse.AddRange(handler.GetOnlySub_Issued(course));
                    break;
            }
        }

        private void FillListControlTasks()
        {
            int i = 0;
            ListSubStudents.Clear();
            foreach (var sub in thisSubCourse)
            {
                ListSubStudents.Add(new Component_RowUserCertificate(sub, thisTypePage == TypeBlockTasks.Waiting ? true : false));
            }
            ListSubStudents.Reverse();
        }

        private void FillPanel()
        {
            panelMain.Controls.Clear();
            panelMain.Controls.AddRange(ListSubStudents.ToArray());

            if (panelMain.Controls.Count < 1)
            {
                panelMain.Controls.Add(new PanelMainBlock_MessageText("There is nothing here."));
                panelMain.Controls[0].Dock = DockStyle.Fill;
            }
        }

        private void customComboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
            => UpdatePanel_OnSelectedIndexChanged();

        private void RemoveThisTaskToPanel(UserControl task)
        {
            panelMain.Controls.Remove(task);

            if (panelMain.Controls.Count < 1)
            {
                panelMain.Controls.Add(new PanelMainBlock_MessageText("There is nothing here."));
                panelMain.Controls[0].Dock = DockStyle.Fill;
            }
        }

        public void UpdatePanel_OnSelectedIndexChanged()
        {
            thisSubCourse.Clear();

            string nameSelectCoure = customComboBox1.Texts;
            if (nameSelectCoure == "All")
            {
                foreach (var course in handler.MyCourses)
                {
                    AddCertainTasksToList(course);
                }
            }
            else
            {
                if (UserHandler.FindCourse(nameSelectCoure) is Course selectCourse)
                    AddCertainTasksToList(selectCourse);
            }

            FillListControlTasks();
            FillPanel();
        }

        public enum TypeBlockTasks
        {
            Waiting,
            Issued
            
        }
    }
}
