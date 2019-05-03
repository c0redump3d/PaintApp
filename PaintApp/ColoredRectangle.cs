using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintApp
{
    class ColoredRectangle
    {
        public Rectangle Rect { get; set; }
        public SolidBrush Color { get; set; }

        public ColoredRectangle(int llx, int lly, int urx, int ury, SolidBrush color)
        {
            Rect = new Rectangle(llx, lly, urx, ury);
            Color = color;
        }

    }
}
