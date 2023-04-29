using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SkillCourse.Forms
{
    public partial class AnswerToTask : Form
    {
        public string Text { get; set; }
        public int LoatLocationY { get; set; }

        public AnswerToTask(Size size)
        {
            InitializeComponent();
            this.Size = size;
        }

        public AnswerToTask(Size size, string text, int maxTextLenght) : this(size)
        {
            richTextBox1.MaxLength = maxTextLenght;
            richTextBox1.Text = text;
            labelCounter.Text = $"{text.Length} / {maxTextLenght}";
            int countRows = (maxTextLenght / 40) + 1;
            int heightThisControl = 145 + (countRows * richTextBox1.Font.Height);
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
                Text = richTextBox1.Text;
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
