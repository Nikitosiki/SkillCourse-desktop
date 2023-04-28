using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkillCourse.Panels.MainBlock.CreateCourse
{
    public partial class Component_CreateCourse_AddingTask : UserControl
    {
        public string TaskName
        {
            get
            {
                return textBoxText.Text;
            }
        }

        public bool TaskMessageType
        {
            get
            {
                return newToggleSwitch1.Checked;
            }
        }

        public Component_CreateCourse_AddingTask()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;

            panel3.Visible = false;
        }

        private void newButtonNext_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = true;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            label3.Text = textBoxText.Text.Length + " / 300";
            ResizeDescriptionTextbox(textBoxText);
        }

        private void ResizeDescriptionTextbox(TextBox textBox)
        {
            const int padding = 10;
            int numLines = textBox.GetLineFromCharIndex(textBox.TextLength) + 1;
            int border = textBox.Height - textBox.ClientSize.Height;
            int newHeight = (textBox.Font.Height * numLines) + padding + border;
            if (newHeight > 176)
            {
                //textBox.ScrollBars = ScrollBars.Vertical;
            }
            else
            {
                //textBox.ScrollBars = ScrollBars.None;
                textBox.Height = newHeight;
            }
        }
    }
}
