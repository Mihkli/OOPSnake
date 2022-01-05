using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeOOP
{
    class Figure
    {
        protected List<point> pointlist;

        public void Draw()
        {
            foreach (point point in pointlist)
            {
                point.Draw();
            }
        }
    }
}
