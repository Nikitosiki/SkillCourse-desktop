using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCourse.handlers
{
    public static class PrintHandler
    {
        public static void ShowPrintPreview(Control controlToPrint)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += (sender, e) =>
            {
                Bitmap bitmap = new Bitmap(controlToPrint.Width, controlToPrint.Height);
                controlToPrint.DrawToBitmap(bitmap, new Rectangle(0, 0, controlToPrint.Width, controlToPrint.Height));
                e.Graphics.DrawImage(bitmap, new Point(0, 0));
                bitmap.Dispose();
            };

            // Установка размера бумаги
            float dpiX = 0, dpiY = 0;
            using (Graphics graphics = Graphics.FromHwnd(IntPtr.Zero))
            {
                dpiX = graphics.DpiX;
                dpiY = graphics.DpiY;
            }
            float scaleForPrinter = dpiX / 96f;         // 125% - маштаб в Windows

            int printerWidth = (int)(controlToPrint.Width / scaleForPrinter);
            int printerHeight = (int)(controlToPrint.Height / scaleForPrinter);
            printDocument.DefaultPageSettings.PaperSize = new PaperSize("Custom", printerWidth, printerHeight);

            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }
    }
}
