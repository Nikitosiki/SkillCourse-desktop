using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkillCourse.Forms
{
    public partial class CheckingAnswerToTask : Form
    {
        public string Text { get; set; }
        public int LoatLocationY { get; set; }

        private readonly int maxHeightContent = 550;

        public CheckingAnswerToTask(Size size)
        {
            InitializeComponent();
            this.Size = size;
        }

        //public CheckingAnswerToTask(Size size, string text, int maxTextLenght, bool autoSizeForText) : this(size)
        //{
        //    richTextBox1.MaxLength = maxTextLenght;
        //    richTextBox1.Text = text;
        //    labelCounter.Text = $"{text.Length} / {maxTextLenght}";

        //    if (autoSizeForText)
        //    {
        //        int countRows = (maxTextLenght / 40) + 1;
        //        int heightThisControl = 145 + (countRows * richTextBox1.Font.Height);
        //        if (heightThisControl > maxHeightContent) heightThisControl = maxHeightContent;
        //        tableLayoutPanel2.Size = new Size(tableLayoutPanel2.Size.Width, heightThisControl);
        //    }
        //}

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
