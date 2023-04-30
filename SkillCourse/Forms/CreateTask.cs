using SkillCourse.DataBaseStructure;
using System.Net.Http.Headers;
using static SkillCourse.helperConfig.UserTextSize;
using Task = SkillCourse.DataBaseStructure.Task;

namespace SkillCourse.Forms
{
    public partial class CreateTask : Form
    {
        public string TextTask { get; set; } = String.Empty;
        public bool MessType { get; set; } = false;
        public int LoatLocationY { get; set; }

        private readonly int maxHeightContent = 550;

        public CreateTask(Size size, int maxTextLenght)
        {
            InitializeComponent();
            this.Size = size;
            richTextBox1.MaxLength = maxTextLenght;
            labelCounter.Text = $"0 / {maxTextLenght}";

            int countRows = (maxTextLenght / 40) + 1;
            int heightThisControl = 145 + (countRows * richTextBox1.Font.Height);
            if (heightThisControl > maxHeightContent) heightThisControl = maxHeightContent;
            tableLayoutPanel2.Size = new Size(tableLayoutPanel2.Size.Width, heightThisControl);
        }

        private void newButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void newButtonApply_Click(object sender, EventArgs e)
        {
            if (richTextBox1.ForeColor == SystemColors.Control)
            {
                if (richTextBox1.Text == null || richTextBox1.Text == "")
                    return;

                TextTask = richTextBox1.Text;
                MessType = newToggleSwitch1.Checked;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                //
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            labelCounter.Text = $"{richTextBox1.Text.Length} / {richTextBox1.MaxLength}";
        }

        private void AnswerToTask_Load(object sender, EventArgs e)
        {
            this.Location = new Point(this.Location.X, this.Location.Y + LoatLocationY);
        }
    }
}
