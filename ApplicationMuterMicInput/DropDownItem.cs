using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationMuterMicInput
{
    public sealed class DropDownItem
    {
        public string Value { get; set; }

        public Image Image { get; set; }

        public DropDownItem()
            : this("", null)
        { }

        public DropDownItem(string val, Bitmap image)
        {
            Value = val;
            Image = image;
            using (Graphics g = Graphics.FromImage(Image))
            {
                using (Brush b = new SolidBrush(Color.FromName(val)))
                {
                    g.DrawRectangle(Pens.White, 0, 0, Image.Width + 1, Image.Height + 1);
                    g.FillRectangle(b, 1, 1, Image.Width - 1, Image.Height - 1);
                }
            }
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
