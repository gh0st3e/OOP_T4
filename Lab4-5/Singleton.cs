using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Lab4
{
    class SingletonForm
    {
        private static SingletonForm form1Information;

        public Color BackgroundColor { get; private set; }
        public Font WindowFont { get; private set; }
        public Size WindowSize { get; private set; }

        protected SingletonForm(Color color, Font font, Size size)
        {
            this.BackgroundColor = color;
            this.WindowFont = font;
            this.WindowSize = size;
        }

        public static SingletonForm getInstance(Color color, Font font, Size size)
        {
            if (form1Information == null)
                form1Information = new SingletonForm(color, font, size);
            return form1Information;
        }

        public override string ToString()
        {
            return "Цвет фона: " + this.BackgroundColor.Name + "\nШрифт: " + this.WindowFont.Name + "\nРазмер окна: " + this.WindowSize.Width + "x" + this.WindowSize.Height;
        }
    }
}
