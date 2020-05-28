using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTCNTT
{
    public enum ArrowType
    {
        OneWay,
        TwoWay
    };
    public class Utils
    {
        static Font font;
        public static void setFont(Font _font)
        {
            font = _font;
        }
        public static void drawCircleNoFill(Graphics graphic, CPoint point , Color color , int penSize)
        {
            int radius = point.radius + 1;
            Pen pen = new Pen(color, penSize);
            graphic.DrawEllipse(pen, new Rectangle((int)point.x - radius, (int)point.y - radius, 2 * radius, 2 * radius));

        }
        public static void drawCircle(Graphics graphic, CPoint point, Color color ,int delRad = 0)
        {
            Brush brush = new SolidBrush(color);
            graphic.FillEllipse(brush, new Rectangle((int)point.x - point.radius - delRad, (int)point.y - point.radius - delRad,
                2 *(point.radius + delRad), 2 * (point.radius + delRad)));
        }
        public static void drawCircle(Graphics graphic, CPoint point, string lable)
        {
            Brush brush = new SolidBrush(Color.Black);
            graphic.FillEllipse(brush, new Rectangle((int)point.x - point.radius, (int)point.y - point.radius,
                2 * point.radius, 2 * point.radius));
            graphic.DrawString(lable, font, Brushes.Black, point.x + point.radius, point.y);
        }

        public static void showLable(Graphics graphic, CPoint point)
        {
            string lable = "(" +(int)point.x +":" + (int)point.y + ")";
            graphic.DrawString(lable, font, Brushes.Black, point.x - 20, point.y- point.radius- 20);
        }

        public static void showLable(Graphics graphic, CPoint point ,string msg , int deltaY =0)
        {
            string lable = msg;
            graphic.DrawString(lable, font, Brushes.Black, point.x - 30, point.y + deltaY);
        }

        public static void drawArrow(Graphics graphic, CPoint st, CPoint ed, ArrowType _type,  Color color, int lineWidth = 1,
            DashStyle _typeLine = DashStyle.Solid)
        {
            AdjustableArrowCap bigArrow = new AdjustableArrowCap(5, 4);
            Pen p = new Pen(color, lineWidth);
            p.DashStyle = _typeLine;

            p.CustomEndCap = bigArrow;
            if (_type == ArrowType.TwoWay)
            {
                p.CustomStartCap = bigArrow;
            }
            graphic.DrawLine(p, st.x , st.y , ed.x , ed.y);
        }
        public static ArrowType randomArrowType()
        {
            Array values = Enum.GetValues(typeof(ArrowType));
            Random random = new Random();
            return (ArrowType) values.GetValue(random.Next(values.Length));
        }

        public static CPoint normal(CPoint st)
        {
            float m = mag(st);
            if (m != 0)
            {
                return new CPoint(st.x / m, st.y / m);
            }
            return new CPoint(0, 0);
        }
        public static CPoint add(CPoint st , CPoint ed)
        {
            return new CPoint(st.x + ed.x, st.y + ed.y);
        }
        public static CPoint sub(CPoint st, CPoint ed)
        {
            return new CPoint(st.x - ed.x, st.y - ed.y);
        }

        public static CPoint mul(CPoint st, float a)
        {
            return new CPoint(st.x* (int)a, st.y* (int)a);
        }
        public static float mag(CPoint st)
        {
            return (float) Math.Sqrt(st.x * st.x + st.y * st.y);
        }
        public static float mag(CPoint a , CPoint b)
        {
            float x = b.x - a.x;
            float y = b.y - a.y;
            return (float)Math.Sqrt(x * x + y * y);
        }

    }
}
