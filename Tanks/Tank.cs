using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Tanks
{
    class Tank : IMove, ITurn
    {
        public Image img = Properties.Resources.Tank;

        public int x, y;
        public direction dir;

        public void Run()
        {
            


        }

        public void Turn()
        {

        }

        
    }
}
