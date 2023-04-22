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
        private int countControls = 0;
        private int selectIndexControl = 0;

        public PanelMainBlock_Certificates()
        {
            InitializeComponent();

            panelThisCertificates.Controls.Add(new Component_newCertificate());
            panelThisCertificates.Controls.Add(new Component_newCertificate());
            panelThisCertificates.Controls.Add(new Component_newCertificate());

            countControls = panelThisCertificates.Controls.Count;
        }

        private void buttonScrollRight_Click(object sender, EventArgs e)
        {
            //if (selectIndexControl < countControls - 1)
            //{
            //    selectIndexControl++;
            //    ScrollPanelAnimation(panelThisCertificates.Controls[selectIndexControl].Location.X, 30);
            //}
            ScrollMove(true);
        }

        private void buttonScrollLeft_Click(object sender, EventArgs e)
        {
            //if (selectIndexControl > 0)
            //{
            //    selectIndexControl--;
            //    ScrollPanelAnimation(panelThisCertificates.Controls[selectIndexControl].Location.X, 30);
            //}
            ScrollMove(false);
        }

        private void ScrollMove(bool right)
        {
            int stepSize = 40;
            int sizeControl = 866;
            int countControl = panelThisCertificates.Controls.Count;
            int currentScrollPosition = panelThisCertificates.HorizontalScroll.Value;
            float selectControl = (float)currentScrollPosition / (float)sizeControl;      //тот на котором мы сейчас находимся

            if (right)
            {
                // от 0 .. 2 - selectControl
                // от 1 .. 3 - countControl
                if (selectControl + 1 < countControl)
                {
                    int sumSizeControl = (((int)selectControl + 1) * sizeControl);   // + 3
                    ScrollPanelAnimation(sumSizeControl, stepSize);
                }
            }
            else
            {
                if (selectControl > 0)
                {
                    int sumSizeControl = (((int)(selectControl - 0.000001)) * sizeControl);   // + 3
                    ScrollPanelAnimation(sumSizeControl, stepSize);
                }
            }

        }

        private void ScrollPanelAnimation(int targetScrollPosition, int stepSize)
        {
            //int currentScrollPosition = panelThisCertificates.HorizontalScroll.Value;
            //int targetScrollPosition = currentScrollPosition + scrollAmount;

            // Анимация прокрутки
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 5; // Интервал обновления анимации (в миллисекундах)
            timer.Tick += (s, args) =>
            {
                if (panelThisCertificates.HorizontalScroll.Value < targetScrollPosition)
                {
                    if (panelThisCertificates.HorizontalScroll.Value <= targetScrollPosition - stepSize)
                        panelThisCertificates.HorizontalScroll.Value += stepSize; // Шаг анимации
                    else
                    {
                        panelThisCertificates.AutoScrollPosition = new Point(targetScrollPosition, 0);
                    }
                }
                else if (panelThisCertificates.HorizontalScroll.Value > targetScrollPosition)
                {
                    if (panelThisCertificates.HorizontalScroll.Value >= targetScrollPosition + stepSize)
                        panelThisCertificates.HorizontalScroll.Value -= stepSize; // Шаг анимации
                    else
                    {
                        panelThisCertificates.AutoScrollPosition = new Point(targetScrollPosition, 0);
                    }
                }
                else
                {
                    timer.Stop(); // Останавливаем таймер после завершения анимации
                }
            };
            timer.Start(); // Запускаем таймер для анимации
        }
    }
}
