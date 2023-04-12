using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkillCourse.PanelComponents
{
    public partial class Component_BriefСourse_View : UserControl
    {
        private Action clickOnCourse;

        public Component_BriefСourse_View(string nameCourse, string descriptionCourse, Image imageCourse, Action buttonCoutse)
        {
            InitializeComponent();
            Dock = DockStyle.Top;

            Name = nameCourse + " " + descriptionCourse;

            label_NameCourse.Text = nameCourse;
            label_DescriptionCourse.Text = descriptionCourse;
            picture_imageCourse.Image = imageCourse;

            clickOnCourse = buttonCoutse;
        }

        private void button_ViewCourse_Click(object sender, EventArgs e)
        {
            clickOnCourse?.Invoke();
        }
    }
}
