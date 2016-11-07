using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Tanks
{
    partial class View : UserControl
    {
        Model model;


        public View(Model model)
        {
            // TODO: Complete member initialization
            
              InitializeComponent();
            this.model = model;
           
        }

        private void View_Load(object sender, EventArgs e)
        {

        }

        void Draw(PaintEventArgs e)
        {
            
            e.Graphics.DrawImage(model.tank.img, new Point(model.tank.x, model.tank.y));
            if (model.gameStatus != GameStatus.PLAY)
                return;
           
           
        }
        
        protected override void OnPaint(PaintEventArgs e)
        {
            Draw(e);
            Invalidate();
        }

        private void View_KeyPress(object sender, KeyPressEventArgs e)
        {
            Invalidate();
        }

    }
}
