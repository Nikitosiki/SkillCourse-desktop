using SkillCourse.helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkillCourse.Panels.MainBlock.CreateCourse
{
    public partial class Component_CreateCourse_ChangingImage : UserControl
    {
        //private string NameCourse { get; set; }
        public Image ImageCourse { get; private set; }

        public Component_CreateCourse_ChangingImage()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;

            //NameCourse = name;
            //if (image != null && !pictureBoxImage.Image.Equals(image)) pictureBoxImage.Image = image;
            //ImageCourse = image ?? pictureBoxImage.Image;
        }

        private void newButtonSelectImage_Click(object sender, EventArgs e)
        {
            ImageCourse = ImageSaveHelper.SelectDialogImage() ?? pictureBoxImage.Image;
            pictureBoxImage.Image = ImageCourse;
        }
    }
}
