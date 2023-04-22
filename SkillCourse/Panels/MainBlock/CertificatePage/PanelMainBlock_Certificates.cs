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

        private void buttonScrollRight_Click(object sender, EventArgs e)
        {
            int scrollAmount = 865; // Заданное количество пикселей для прокрутки

            int endPositionPanel = flowLayoutPanel1.HorizontalScroll.Value + scrollAmount;
            if (endPositionPanel > flowLayoutPanel1.HorizontalScroll.Minimum &&
                endPositionPanel < flowLayoutPanel1.HorizontalScroll.Maximum)
                ScrollPanelAnimation(scrollAmount);
        }

        private void buttonScrollLeft_Click(object sender, EventArgs e)
        {
            int scrollAmount = -865; // Заданное количество пикселей для прокрутки

            int endPositionPanel = flowLayoutPanel1.HorizontalScroll.Value + scrollAmount;
            if (endPositionPanel > flowLayoutPanel1.HorizontalScroll.Minimum &&
                endPositionPanel < flowLayoutPanel1.HorizontalScroll.Maximum)
                ScrollPanelAnimation(scrollAmount);
        }

        private void ScrollPanelAnimation(int scrollAmount)
        {
            int currentScrollPosition = flowLayoutPanel1.HorizontalScroll.Value;
            int targetScrollPosition = currentScrollPosition + scrollAmount;

            // Анимация прокрутки
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 5; // Интервал обновления анимации (в миллисекундах)
            timer.Tick += (s, args) =>
            {
                if (flowLayoutPanel1.HorizontalScroll.Value < targetScrollPosition)
                {
                    flowLayoutPanel1.HorizontalScroll.Value += 5; // Шаг анимации
                }
                else if (flowLayoutPanel1.HorizontalScroll.Value > targetScrollPosition)
                {
                    flowLayoutPanel1.HorizontalScroll.Value -= 5; // Шаг анимации
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
