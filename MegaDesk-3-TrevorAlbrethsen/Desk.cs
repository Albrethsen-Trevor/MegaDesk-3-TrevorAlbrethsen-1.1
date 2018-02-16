using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_TrevorAlbrethsen_1_1
{
    public class Desk
    {
        public int Width { get; set; }
        public int Depth { get; set; }
        public int WidthDepth { get; set; }
        public int Drawers { get; set; }
        public string SurfaceMaterials { get; set; }

        public enum Materials
        {
            Oak,
            Laminate,
            Pine,
            Rosewood,
            Veneer
        }
    }
}