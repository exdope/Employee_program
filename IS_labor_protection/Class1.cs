using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_labor_protection
{
    public class Class1
    {
      
        public static Label TextboxDesign()
        {
            var label = new Label()
            {
                Height = 1,
                Dock = DockStyle.Bottom,
                BackColor = Color.Black
            };
            return label;
        }
        public static Label ActiveButtonDesign()
        {
            var label = new Label()
            {
                Width = 4,
                Dock= DockStyle.Left,
                BackColor= Color.SteelBlue,
            };
            return label;
        }
    }
}
