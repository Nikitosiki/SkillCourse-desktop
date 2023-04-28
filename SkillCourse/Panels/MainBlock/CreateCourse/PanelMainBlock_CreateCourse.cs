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


        private string NameCourse { get; set; } = string.Empty;
        private string DescriptionCourse { get; set; } = string.Empty;
        private Image? ImageCourse { get; set; }

        public PanelMainBlock_CreateCourse()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            OpenPage(Step);
        }

        private void OpenPage(int step)
        {
            labelStemNumber.Text = $"Step {Step} / 4";
            panelMainBlock.Controls.Clear();

            switch (step)
            {
                case 1:
                    panelMainBlock.Controls.Add(new Component_CreateCourse_Naming(NameCourse, DescriptionCourse));
                    newButtonNext.Text = "Next";
                    labelStepName.Text = "Naming";
                    newButtonBack.Visible = false;
                    break;
                case 2:
                    panelMainBlock.Controls.Add(new Component_CreateCourse_ChangingImage(NameCourse, ImageCourse));
                    newButtonNext.Text = "Next";
                    labelStepName.Text = "Changing the Image";
                    newButtonBack.Visible = true;
                    break;
                case 3:

                    newButtonNext.Text = "Next";
                    labelStepName.Text = "Adding Task";
                    newButtonBack.Visible = true;
                    break;
                case 4:

                    newButtonNext.Text = "Public";
                    labelStepName.Text = "Signing up students";
                    newButtonBack.Visible = true;
                    break;
            }
        }

        private void NextStepClick(bool next)
        {
            switch (Step)  //Текущий
            {
                case 1:
                    Component_CreateCourse_Naming thisPage1 = (Component_CreateCourse_Naming)panelMainBlock.Controls[panelMainBlock.Controls.Count - 1];
                    this.NameCourse = thisPage1.NameCourse;
                    this.DescriptionCourse = thisPage1.DescriptionCourse;
                    if (this.NameCourse == "" || this.NameCourse == null || this.DescriptionCourse == "" || this.DescriptionCourse == null)
                        return;
                    break;

                case 2:
                    Component_CreateCourse_ChangingImage thisPage2 = (Component_CreateCourse_ChangingImage)panelMainBlock.Controls[panelMainBlock.Controls.Count - 1];
                    this.ImageCourse = thisPage2.ImageCourse;
                    break;

                case 3:

                    break;

                case 4:

                    break;
            }

            if (next) Step += 1; else Step -= 1;
            OpenPage(Step);
        }


        private void newButtonNext_Click(object sender, EventArgs e)
        {
            NextStepClick(true);
        }

        private void newButtonBack_Click(object sender, EventArgs e)
        {
            NextStepClick(false);
        }
    }
}
