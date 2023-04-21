using SkillCourse.Panels.MainBlock.CertificatePage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkillCourse.Panels.MainBlock
{
    public partial class PanelMainBlock_Certificates : UserControl
    {
        public PanelMainBlock_Certificates()
        {
            InitializeComponent();

            flowLayoutPanel1.Controls.Add(new Component_newCertificate());
            flowLayoutPanel1.Controls.Add(new Component_newCertificate());
            flowLayoutPanel1.Controls.Add(new Component_newCertificate());
        }

        private void ShowPrintPreview(Control controlToPrint)
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


        private void button1_Click(object sender, EventArgs e)
        {
            ShowPrintPreview(flowLayoutPanel1.Controls[0]);
        }
    }
}
