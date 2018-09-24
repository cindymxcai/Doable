using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ObjectHolder : Control
    {
        public ObjectHolder()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            pe.Graphics.FillRectangle(new HatchBrush(HatchStyle.Percent90, Color.White, Color.White), ClientRectangle);
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            
        }
    }
}
