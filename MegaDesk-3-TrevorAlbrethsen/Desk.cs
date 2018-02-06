using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_TrevorAlbrethsen_1_1
{
    class Desk
    {
        private float width;
        public float getWidth
        {
            get
            {
                return this.width;
            }
            set
            {
                this.width = value;
            }
        }

        private float depth;
        public float getDepth
        {
            get
            {
                return this.depth;
            }
            set
            {
                this.depth = value;
            }
        }

        private int drawers;
        public int getDrawers
        {
            get
            {
                return this.drawers;
            }
            set
            {
                this.drawers = value;
            }
        }
    }
}
