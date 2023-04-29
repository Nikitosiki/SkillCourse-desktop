using System.Drawing.Drawing2D;

namespace CPProject.components.ui
{
    public partial class CustomRoundedButton : Button
    {
        private bool autofocus = false;
        private int focusBorderSize = 2;
        private Color focusBorderColor = Color.Gray;
        private int borderSizeDefault = 0;
        private Color borderColorDefault = Color.PaleVioletRed;
        private int borderSize = 0;
        private int borderRadius = 0;
        private Color borderColor = Color.PaleVioletRed;
        public bool Autofocus
        {
            get => autofocus;
            set
            {
                autofocus = value;
                setAutoFocus(value);
                this.Invalidate();
            }
        }

        public int FocusBorderSize
        {
            get => focusBorderSize;
            set
            {
                focusBorderSize = value;
                this.Invalidate();
            }
        }

        public Color FocusBorderColor
        {
            get => focusBorderColor;
            set
            {
                focusBorderColor = value;
                this.Invalidate();
            }
        }

        public int BorderSize
        {
            get => borderSize;
            set
            {
                borderSize = value;
                //borderSizeDefault = value;
                this.Invalidate();
            }
        }

        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }

        public Color BorderColor
        {
            get => borderColor;
            set
            {
                borderColor = value;
                //borderColorDefault = value;
                this.Invalidate();
            }
        }

        public Color BackgroundColor
        {
            get => this.BackColor;
            set => this.BackColor = value;
        }

        public Color TextColor
        {
            get => this.ForeColor;
            set => this.ForeColor = value;
        }

        public CustomRoundedButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
#pragma warning disable CS8622 // Допустимость значений NULL для ссылочных типов в типе параметра не соответствует целевому объекту делегирования (возможно, из-за атрибутов допустимости значений NULL).
            this.Resize += new EventHandler(Button_Resize);
#pragma warning restore CS8622 // Допустимость значений NULL для ссылочных типов в типе параметра не соответствует целевому объекту делегирования (возможно, из-за атрибутов допустимости значений NULL).
            this.Cursor = Cursors.Hand;
            this.Margin = new Padding(0);
        }

        private void setButtonFocus(bool isFocus)
        {
            if (isFocus)
            {
                BorderColor = FocusBorderColor;
                BorderSize = FocusBorderSize;
            }
            else
            {
                BorderColor = borderColorDefault;
                BorderSize = borderSizeDefault;
            }
        }

        private void setAutoFocus(bool value)
        {
            if (value)
            {
                this.GotFocus += (sender, e) => setButtonFocus(true);
                this.LostFocus += (sender, e) => setButtonFocus(false);
            }
            else
            {
                this.GotFocus -= (sender, e) => setButtonFocus(true);
                this.LostFocus -= (sender, e) => setButtonFocus(false);
            }
        }

        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);


            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = 2;
            if (borderSize > 0)
                smoothSize = borderSize;

            if (borderRadius > 2) //Rounded button
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
                using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    //Button surface
                    this.Region = new Region(pathSurface);
                    //Draw surface border for HD result
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    //Button border                    
                    if (borderSize >= 1)
                        //Draw control border
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.
            }
            else //Normal button
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;
                //Button surface
                this.Region = new Region(rectSurface);
                //Button border
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
#pragma warning disable CS8622 // Допустимость значений NULL для ссылочных типов в типе параметра не соответствует целевому объекту делегирования (возможно, из-за атрибутов допустимости значений NULL).
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.
#pragma warning restore CS8622 // Допустимость значений NULL для ссылочных типов в типе параметра не соответствует целевому объекту делегирования (возможно, из-за атрибутов допустимости значений NULL).
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRadius > this.Height)
                borderRadius = this.Height;
        }
    }
}
