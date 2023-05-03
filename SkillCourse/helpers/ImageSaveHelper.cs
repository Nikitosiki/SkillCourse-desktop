using SkillCourse.DataBaseStructure.serialize;
using SkillCourse.helperConfig;
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

        public static string SaveImageToFile(TypeImage typeImage, string fileName, Image image)
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

        public static Image? LoadCourseImageFromFile(string? filePath)
        {
            if (filePath == null)
                return LoadImageFromFile(SerializeSetting.Default.CourseImageDefault);

            return LoadImageFromFile(filePath) ?? LoadImageFromFile(SerializeSetting.Default.CourseImageDefault);
        }

        public static Image? LoadUserImageFromFile(string? filePath)
        {
            if (filePath == null)
                return LoadImageFromFile(SerializeSetting.Default.UserImagesDefault);

            return LoadImageFromFile(filePath) ?? LoadImageFromFile(SerializeSetting.Default.UserImagesDefault);
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

        public static Image ResizeImageWithCrop(Image originalImage, int targetWidth, int targetHeight)
        {
            var originalAspectRatio = (float)originalImage.Width / originalImage.Height;
            var targetAspectRatio = (float)targetWidth / targetHeight;

            int cropWidth, cropHeight;

            if (originalAspectRatio > targetAspectRatio)  // original is wider than target
            {
                cropHeight = originalImage.Height;
                cropWidth = (int)(targetAspectRatio * cropHeight);
            }
            else // original is taller than target
            {
                cropWidth = originalImage.Width;
                cropHeight = (int)(cropWidth / targetAspectRatio);
            }

            // Get the cropped image
            var croppedImage = new Bitmap(cropWidth, cropHeight);

            using (var graphics = Graphics.FromImage(croppedImage))
            {
                graphics.DrawImage(
                    originalImage,
                    new Rectangle(0, 0, cropWidth, cropHeight),
                    new Rectangle((originalImage.Width - cropWidth) / 2, (originalImage.Height - cropHeight) / 2, cropWidth, cropHeight),
                    GraphicsUnit.Pixel);
            }

            // Resize the cropped image to the desired target size
            var resizedImage = new Bitmap(croppedImage, new Size(targetWidth, targetHeight));

            return resizedImage;
        }

    }
}
