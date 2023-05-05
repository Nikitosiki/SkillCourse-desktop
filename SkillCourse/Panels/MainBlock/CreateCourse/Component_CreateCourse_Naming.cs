using SkillCourse.helperConfig;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using yt_DesignUI;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SkillCourse.Panels.MainBlock.CreateCourse
{
    public partial class Component_CreateCourse_Naming : UserControl
    {
        public string NameCourse
        {
            get
            {
                return textBoxName.Text;
            }
        }
        public string DescriptionCourse
        {
            get
            {
                return textBoxDescription.Text;
            }
        }



        public Component_CreateCourse_Naming()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;

            int maxLenghtName = UserTextSize.Course.maxLenghtName;
            int maxLenghtDescription = UserTextSize.Course.maxLenghtDescription;
            textBoxName.MaxLength = maxLenghtName;
            textBoxDescription.MaxLength = maxLenghtDescription;
            label2.Text = "0 / " + maxLenghtName;
            label4.Text = "0 / " + maxLenghtDescription;
            //NameCourse = textName ?? string.Empty;
            //DescriptionCourse = textDescription ?? string.Empty;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            ValidityCheckName(textBoxName);
            int maxLenghtName = UserTextSize.Course.maxLenghtName;
            label2.Text = textBoxName.Text.Length.ToString() + " / " + maxLenghtName;
        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {
            ValidityCheckName(textBoxDescription);
            int maxLenghtDescription = UserTextSize.Course.maxLenghtDescription;
            label4.Text = textBoxDescription.Text.Length.ToString() + " / " + maxLenghtDescription;
        }

        private void ValidityCheckName(TextBox thisTextBox)
        {
            thisTextBox.Text = Regex.Replace(thisTextBox.Text, @"[\/\\\:\*\?\""\<\>\|]", "");
            thisTextBox.SelectionStart = thisTextBox.Text.Length;
            //thisTextBox.Invalidate();
        }
    }
}
