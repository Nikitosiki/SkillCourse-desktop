using SkillCourse.DataBaseStructure;
using SkillCourse.DataBaseStructure.serialize;
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

namespace SkillCourse.PanelComponents.UsersPage
{
    public partial class Component_ImageIconUser : UserControl
    {
        public Component_ImageIconUser(Image image)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            pictureBox1.Image = ImageSaveHelper.ResizeImageWithCrop(image, pictureBox1.Width, pictureBox1.Height);
        }

        public Component_ImageIconUser(User user)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;

            string path = SerializeSetting.Default.UserImages + user.ImagePath;
            pictureBox1.Image = ImageSaveHelper.ResizeImageWithCrop(ImageSaveHelper.LoadUserImageFromFile(path), pictureBox1.Width, pictureBox1.Height);
        }
    }
}
