using SkillCourse.DataBaseStructure;
using SkillCourse.handlers;
using SkillCourse.helperConfig;
using Task = SkillCourse.DataBaseStructure.Task;


namespace SkillCourse.Forms
{
    public partial class CheckingAnswerToTask : Form
    {
        public int LoatLocationY { get; set; }
        private Task TaskThis { get; set; }
        private AnswerTask AnswerTask { get; set; }


        public CheckingAnswerToTask(Size size, Task task, AnswerTask answer)
        {
            InitializeComponent();
            this.Size = size;

            this.TaskThis = task;
            this.AnswerTask = answer;

            FillingForm();
            ReSizeText();
        }

        private void FillingForm()
        {
            if (UserHandler.GetCourse(TaskThis.IdCourse) is Course course)
                labelCourse.Text = $"Course \"{course.Name}\"";
            else
                labelCourse.Text = "Null";

            labelTaskText.Text = TaskThis.TextTask;
            labelAnswerText.Text = AnswerTask.Text;
            labelStudentName.Text = $"Student: {UserHandler.GetFullName(AnswerTask.IdUser)}";

            if (AnswerTask.Grade is int grade)
                component_AssignmentScore1.Grade = grade;

            if (AnswerTask.Text is string answerText)
                labelCounter.Text = $"{answerText.Length} / {UserTextSize.AnswerTask.maxLenghtName}";
            else
                labelCounter.Text = $"0 / {UserTextSize.AnswerTask.maxLenghtName}";
        }

        private void ReSizeText()
        {
            backRoundPanelTask.Size = new System.Drawing.Size(labelTaskText.Width - labelTaskText.Padding.Horizontal, labelTaskText.Height + (backRoundPanelTask.Padding.Vertical));
            backRoundPanelAnswer.Size = new System.Drawing.Size(labelAnswerText.Width - labelAnswerText.Padding.Horizontal, labelAnswerText.Height + (backRoundPanelAnswer.Padding.Vertical));
        }

        private void newButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void newButtonApply_Click(object sender, EventArgs e)
        {
            AnswerTask.Grade = component_AssignmentScore1.Grade;
            AnswerTask.State = DataBaseStructure.types.StateTask.Checked;
            SkillCourseDB.Instance.AnswerTasks.Update(AnswerTask);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void AnswerToTask_Load(object sender, EventArgs e)
        {
            this.Location = new Point(this.Location.X, this.Location.Y + LoatLocationY);
        }
    }
}
