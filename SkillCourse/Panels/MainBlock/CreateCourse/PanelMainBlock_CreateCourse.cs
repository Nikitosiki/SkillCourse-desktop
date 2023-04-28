using MongoDB.Bson.Serialization.Serializers;
using SkillCourse.DataBaseStructure;
using SkillCourse.DataBaseStructure.serialize;
using SkillCourse.helpers;
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

        private string FirstTaskName { get; set; } = string.Empty;
        private bool FirstTaskMessageType { get; set; } = false;


        private Component_CreateCourse_Naming panelNaming = new Component_CreateCourse_Naming();
        private Component_CreateCourse_ChangingImage panelChangingImage = new Component_CreateCourse_ChangingImage();
        private Component_CreateCourse_AddingTask panelAddingTask = new Component_CreateCourse_AddingTask();

        private Teather teatherHandler = (Teather)AccountHandler.Instance.UserLog;

        public PanelMainBlock_CreateCourse()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            OpenPage(Step);
        }

        private void OpenPage(int step)
        {
            labelStemNumber.Text = $"Step {Step} / 3";
            panelMainBlock.Controls.Clear();

            switch (step)
            {
                case 1:
                    panelMainBlock.Controls.Add(panelNaming);
                    newButtonNext.Text = "Next";
                    labelStepName.Text = "Naming";
                    newButtonBack.Visible = false;
                    break;
                case 2:
                    panelMainBlock.Controls.Add(panelChangingImage);
                    newButtonNext.Text = "Next";
                    labelStepName.Text = "Changing the Image";
                    newButtonBack.Visible = true;
                    break;
                case 3:
                    panelMainBlock.Controls.Add(panelAddingTask);
                    newButtonNext.Text = "Public";
                    labelStepName.Text = "First Task";
                    newButtonBack.Visible = true;
                    break;
            }
        }

        private void NextStepClick(bool next)
        {
            if (next)
                switch (Step)  //Текущий
                {
                    case 1:
                        this.NameCourse = panelNaming.NameCourse;
                        this.DescriptionCourse = panelNaming.DescriptionCourse;
                        if (this.NameCourse == "" || this.NameCourse == null || this.DescriptionCourse == "" || this.DescriptionCourse == null)
                            return;
                        break;

                    case 2:
                        this.ImageCourse = panelChangingImage.ImageCourse;
                        break;

                    case 3:
                        this.FirstTaskName = panelAddingTask.TaskName;
                        this.FirstTaskMessageType = panelAddingTask.TaskMessageType;
                        PublicNewCourse();
                        break;
                }

            if (next) Step += 1; else Step -= 1;
            OpenPage(Step);
        }


        private void PublicNewCourse()
        {
            string imagePath = ImageSaveHelper.SaveImageToFile(ImageSaveHelper.TypeImage.Course, NameCourse.Replace(" ", "_"), ImageCourse ?? ImageSaveHelper.LoadImageFromFile(SerializeSetting.Default.CourseImageDefault));
            Course newCourse = new Course(NameCourse, DescriptionCourse, imagePath, teatherHandler.IdUser);
            teatherHandler.CreateCourse(newCourse);
            if (FirstTaskName != null && FirstTaskName != "")
                teatherHandler.AddTaskToCourse(newCourse, FirstTaskName, FirstTaskMessageType);
            NavigatePages.OpenNewPage(new PanelMainBlock_CoursePage(newCourse));
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
