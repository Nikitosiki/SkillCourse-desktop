using SkillCourse.DataBaseStructure;
using SkillCourse.DataBaseStructure.serialize;
using SkillCourse.Forms;
using SkillCourse.helpers;
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
    public partial class Component_BriefСourse_View_Sub : UserControl
    {
        private Action? clickOnUnsubscribe;
        private Action? clickOnSubscribe;
        private Action? clickOnView;

        private bool autoUpdate;
        public bool subscript;
        private Course thisCourse;
        private Student handler = (Student)AccountHandler.Instance.UserLog;

        public Component_BriefСourse_View_Sub(Course course, bool AutoUpdate, Action? clickOnView, Action? clickOnUnsubscribe, Action? clickOnSubscribe)
        {
            InitializeComponent();
            Dock = DockStyle.Top;

            Name = course.Name + " " + course.Description;
            this.autoUpdate = AutoUpdate;
            this.thisCourse = course;

            label_NameCourse.Text = course.Name;
            label_DescriptionCourse.Text = course.Description;
            string path = SerializeSetting.Default.CourseImages + course.ImagePath;
            picture_imageCourse.Image = ImageSaveHelper.LoadCourseImageFromFile(path);
            defoultStateSubButton(true);

            this.clickOnUnsubscribe = clickOnUnsubscribe;
            this.clickOnSubscribe = clickOnSubscribe;
            this.clickOnView = clickOnView;
        }

        private void defoultStateSubButton(bool autoRefresh)
        {
            if (handler.CheckSubscrib(thisCourse))
            {
                subscript = false;
                button_SubCourse.Text = "Unsubscribe";
                button_SubCourse.BackColor = Color.Gray;
                button_ViewCourse.Visible = true;
            }
            else
            {
                subscript = true;
                button_SubCourse.Text = "Subscribe";
                button_SubCourse.BackColor = Color.FromArgb(239, 80, 108);       //80, 175, 138 --- 220, 50, 80 --- 62, 114, 187
                button_ViewCourse.Visible = false;
            }
            if (autoRefresh)
                this.Refresh();
        }

        private void button_ViewCourse_Click(object sender, EventArgs e)
        {
            clickOnView?.Invoke();
        }

        private void button_SubCourse_Click(object sender, EventArgs e)
        {
            if (button_SubCourse.Text == "Subscribe")
            {

                clickOnUnsubscribe?.Invoke();
                defoultStateSubButton(autoUpdate);
            }
            else
            {
                string textView = "All your entries will be deleted. Are you sure you want to unsubscribe? 🤨";
                if (CheckerModalFormView(textView))
                {
                    clickOnSubscribe?.Invoke();
                    defoultStateSubButton(autoUpdate);
                }
            }
        }

        private bool CheckerModalFormView(string text)
        {
            var thisParent = this.Parent;
            while (true)
            {
                if (thisParent.Parent == null)
                    break;

                thisParent = thisParent.Parent;
            }

            MessageYesNo modalForm = new MessageYesNo(text, new Size(thisParent.ClientSize.Width, thisParent.ClientSize.Height));
            modalForm.LoatLocationY = ((SystemInformation.CaptionHeight) / 2);
            DialogResult result = modalForm.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                return true;
            }

            return false;
        }
    }
}
