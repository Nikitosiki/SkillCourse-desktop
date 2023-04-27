using MongoDB.Bson.Serialization.Serializers;
using SkillCourse.Panels.MainBlock.CreateCourse;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkillCourse.Panels.MainBlock
{
    public partial class PanelMainBlock_CreateCourse : UserControl
    {
        private int Step { get; set; } = 1;
        // Naming
        // Image
        // Add Task
        // Add Student


        private string NameCourse { get; set; }
        private string DescriptionCourse { get; set; }
        //private string ImageCourse { get; set; }

        public PanelMainBlock_CreateCourse()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            OpenPage(Step);
        }

        private void OpenPage(int step)
        {
            switch (step)
            {
                case 1:
                    panelMainBlock.Controls.Add(new Component_CreateCourse_Naming());
                    labelStepName.Text = "Naming";
                    labelStemNumber.Text = $"Step {Step} / 4";
                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
            }
        }

        private void NextStepClick()
        {
            switch (Step)  //Текущий
            {
                case 1:
                    Component_CreateCourse_Naming thisPage = (Component_CreateCourse_Naming)panelMainBlock.Controls[panelMainBlock.Controls.Count - 1];
                    NameCourse = thisPage.NameCourse;
                    DescriptionCourse = thisPage.DescriptionCourse;
                    break;

                case 2:
                    labelStepName.Text = "Changing the Image";
                    break;

                case 3:
                    labelStepName.Text = "Adding Task";
                    break;

                case 4:
                    labelStepName.Text = "Signing up students";
                    break;
            }

            OpenPage(++Step);
        }


        private void newButtonNext_Click(object sender, EventArgs e)
        {
            NextStepClick();
        }
    }
}
