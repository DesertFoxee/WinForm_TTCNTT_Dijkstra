using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTCNTT
{

    public class CPoint
    {
        public float x;
        public float y;
        public int radius;
        public CPoint(float _x , float _y , int _radius)
        {
            x = _x;
            y = _y;
            radius = _radius;
        }
        public CPoint(float _x, float _y)
        {
            x = _x;
            y = _y;
        }
        public bool checkInSide(int px , int py)
        {

            return  (Math.Sqrt((px - x) * (px - x) + (py - y) * (py - y)) <= radius);
        }
    }
}
