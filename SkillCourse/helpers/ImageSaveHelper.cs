using SkillCourse.DataBaseStructure.serialize;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SkillCourse.helpers.ImageSaveHelper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace SkillCourse.helpers
{
    public class ImageSaveHelper
    {
        public enum TypeImage
        {
            Course,
            User
        }

        public static Image? SelectDialogAndSaveImage(TypeImage typeImage, string nameNewFile)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "PNG Files (*.png)|*.png";
            dialog.Title = "Select an image";

            if (dialog.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.FileName))
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
                destinationPath += nameNewFile;

                if (File.Exists(destinationPath))
                {
                    File.Delete(destinationPath);
                }
                File.Copy(dialog.FileName, destinationPath);
                return LoadImageFromFile(destinationPath);
            }
            return null;
        }

        public static Image? SelectDialogImage()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "PNG Files (*.png)|*.png";
            dialog.Title = "Select an image";

            if (dialog.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.FileName))
            {
                return LoadImageFromFile(dialog.FileName);
            }
            return null;
        }

        public static string SaveImageToFile(TypeImage typeImage, string nameNewFile, Image image)
        {
            string destinationPath = string.Empty;
            string fileName = "Course_" + nameNewFile + ".png";

            switch (typeImage)
            {
                case TypeImage.Course:
                    destinationPath = SerializeSetting.Default.CourseImages;
                    break;
                case TypeImage.User:
                    destinationPath = SerializeSetting.Default.UserImages;
                    break;
            }
            destinationPath += fileName;
            //Удаляем если уже есть
            if (File.Exists(destinationPath))
            {
                File.Delete(destinationPath);
            }

            //Создаем факл-картинку
            using (FileStream fileStream = new FileStream(destinationPath, FileMode.Create))
            {
                image.Save(fileStream, System.Drawing.Imaging.ImageFormat.Png);
            }
            
            return fileName;
        }

        public static Image? LoadCourseImageFromFile(string filePath)
        {
            return LoadImageFromFile(filePath) ?? LoadImageFromFile(SerializeSetting.Default.CourseImageDefault);
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
                Debug.WriteLine(ex.Message);
                //MessageBox.Show(ex.Message);
                // Обработка ошибки, если не удалось загрузить изображение
                // Например, можно вывести сообщение об ошибке
            }

            return image;
        }
    }
}
