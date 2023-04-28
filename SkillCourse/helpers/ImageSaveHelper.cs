using SkillCourse.DataBaseStructure.serialize;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCourse.helpers
{
    public class ImageSaveHelper
    {
        public enum TypeImage
        {
            Course,
            User
        }

        public static Image? SelectImage(TypeImage typeImage, string nameNewFile)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "PNG Files (*.png)|*.png";
            dialog.Title = "Select an image";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string destinationPath = string.Empty;
                switch (typeImage)
                {
                    case TypeImage.Course:
                        destinationPath = SerializeSetting.Default.CourseImages;
                        break;
                    case TypeImage.User:
                        destinationPath = SerializeSetting.Default.UserImages;
                        break;
                }
                destinationPath += nameNewFile + ".png";

                if (File.Exists(destinationPath))
                {
                    File.Delete(destinationPath);
                }
                File.Copy(dialog.FileName, destinationPath);
                return LoadImageFromFile(destinationPath);
            }
            return null;
        }

        public static Image? LoadImageFromFile(string filePath)
        {
            Image? image = null;

            try
            {
                using (FileStream stream = new FileStream(filePath, FileMode.Open))
                {
                    image = Image.FromStream(stream);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // Обработка ошибки, если не удалось загрузить изображение
                // Например, можно вывести сообщение об ошибке
            }

            return image;
        }
    }
}
