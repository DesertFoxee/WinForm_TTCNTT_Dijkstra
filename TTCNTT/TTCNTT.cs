using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTCNTT
{
    public partial class Form1 : Form
    {
        const int maxPointCount = 20;
        const int maxRayCount = 400;


        // setup 
        bool isShowPosition = false;
        bool isShowRay = true;

        int radius = 10;

        List<CPoint> points = new List<CPoint>();
        List<int> route = new List<int>();

        CPoint pointStart = null;
        CPoint pointEnd = null;
        CPoint pointSelected = null;

        int pointCount;
        int rayCount;
        int oneDimCount;
        int twoDimCount;

        int[,] matRouting;
        Step[,] matStep;

        public void showMatrix()
        {
            for (int x = 0; x < pointCount; x++)
            {
                for (int y = 0; y < pointCount; y++)
                {
                    Console.Write("{0} ", matRouting[x, y]);
                }
                Console.WriteLine();
            }
        }
        public void UpdateInfo()
        {
            LB_PointCount.Text = pointCount.ToString();
            LB_RayCount.Text = rayCount.ToString();
            LB_TwoDimCount.Text = twoDimCount.ToString();
            LB_OneDimCount.Text = oneDimCount.ToString();
            TB_PointCount.Text = pointCount.ToString();
            TB_RayCount.Text = rayCount.ToString();

            CBB_PointStart.Items.Add("None");
            CBB_PointEnd.Items.Add("None");
            for (int i = 0; i < pointCount; i++)
            {
                CBB_PointStart.Items.Add("P" + i.ToString());
                CBB_PointEnd.Items.Add("P" + i.ToString());
            }
            CBB_PointEnd.SelectedIndex = 0;
            CBB_PointStart.SelectedIndex = 0;
        }
        public void ResetInfo()
        {
            points.Clear();
            pointSelected = null;
            pointStart = null;
            pointEnd = null;
            oneDimCount = 0;
            twoDimCount = 0;
            CBB_PointStart.Items.Clear();
            CBB_PointEnd.Items.Clear();
            route.Clear();
        }
        bool getRouter(int diembatdau, int diemketthuc)
        {
            bool check = true;
            bool have = false;
            if (diembatdau == diemketthuc) return true;

            route.Add(diemketthuc);
            int diem = diemketthuc;
            while (check == true)
            {
                if (diem == diembatdau)
                {
                    have = true;
                    break;
                }
                check = false;
                for (int i = pointCount - 2; i >= 0; i--)
                {
                    if (matStep[i, diem].distance != -1)
                    {
                        diem = matStep[i, diem].point;
                        route.Add(diem);
                        check = true;
                        break;
                    }
                }
            }
            return have;
        }
        // So sánh bước cũ với bước mới
        Step minStep(Step ne, Step ol)
        {
            if (ne.distance <= -1) return ol;
            if (ol.distance <= -1) return ne;

            if (ne.distance < ol.distance)
                return ne;
            return ol;
        }
        void init(int begin, int end)
        {
            for (int i = 0; i < pointCount; i++)
            {
                if (i == begin)
                {
                    matStep[0, i] = new Step(-1, -1);
                }
                else
                {
                    matStep[0, i] = new Step(begin, matRouting[begin, i]);
                }
            }
        }
        void Dijkstra(int begin, int end)
        {
            int kc_min;
            if (begin == end) return;
            init(begin, end);

            for (int step = 1; step < pointCount - 1; step++)
            {
                kc_min = -1;
                begin = -1;
                for (int x = 0; x < pointCount; x++) // find  min distance step ;
                {
                    if (matStep[step - 1, x].point != -1 && matStep[step - 1, x].distance != -1
                    && (kc_min == -1 || matStep[step - 1, x].distance < kc_min))
                    {
                        kc_min = matStep[step - 1, x].distance;
                        begin = x;
                    }
                }
                for (int i = 0; i < pointCount; i++)
                {
                    if (begin == -1 || begin == i || matStep[step - 1, i].point == -1)
                    {
                        matStep[step, i] = new Step(-1, -1);
                    }
                    else
                    {
                        int kc = (matRouting[begin, i] == -1)
                                ? -1 : matRouting[begin, i] + kc_min;
                        matStep[step, i] = minStep(new Step(begin, kc), matStep[step - 1, i]);
                    }
                }
            }
        }

        public void Generator()
        {

            ResetInfo();
            // sinh điểm mẫu nhiên
            Random random = new Random();
            int gridX = 50;
            int gridY = 50;
            int uWidth = pn_show.Width / gridX;
            int uHeight = pn_show.Height / gridY;

            for (int i = 0; i < pointCount; i++)
            {
                CPoint p = new CPoint(uWidth * random.Next(1, gridX - 1), uHeight * random.Next(1, gridY - 1), radius);
                points.Add(p);
            }

            // sinh đường đi và ma trận 
            for (int hang = 0; hang < pointCount; hang++)
            {
                for (int cot = 0; cot < pointCount; cot++)
                {
                    if (hang == cot) matRouting[hang, cot] = 0;
                    else matRouting[hang, cot] = -1;
                }
            }

            int count = 0;
            int y = random.Next(0, pointCount - 1);
            int dty = 1;
            while (count < rayCount)
            {
                int x = random.Next(0, pointCount - 1);
                if (x != y && matRouting[x, y] == -1 && matRouting[y, x] == -1)
                {
                    int ty = random.Next(1, 6); // ty le 4/5
                    if (ty <= 4)
                    {
                        matRouting[x, y] = (int)Utils.mag(points[x], points[y]);
                        matRouting[y, x] = -1;
                        oneDimCount++;
                    }
                    else
                    {
                        int dis = (int)Utils.mag(points[x], points[y]);
                        matRouting[x, y] = dis;
                        matRouting[y, x] = dis;
                        twoDimCount++;
                    }
                    count++;
                    if (count == (pointCount * (pointCount - 1)) / 2) break;
                }
                dty = random.Next(0, 1);
                if (dty == 0) y -= 1;
                else y += 1;
                if (y >= pointCount) y = 0;
                else if (y < 0) y = pointCount - 1;
            }
            rayCount = count;
            UpdateInfo();
        }

        public void Init()
        {
            pointCount = 10;
            rayCount = 10;
            Generator();
        }
        public Form1()
        {
            InitializeComponent();
            matRouting = new int[maxPointCount, maxPointCount];
            matStep = new Step[maxPointCount, maxPointCount];
            CB_ShowRay.Checked = isShowRay;
            CB_ShowPosition.Checked = isShowPosition;
            Utils.setFont(this.Font);
            Init();
        }

        private void Pn_Show_Paint(object sender, PaintEventArgs e)
        {
            Graphics grap = e.Graphics;
            grap.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            for (int i = 0; i < pointCount; i++)
            {
                if (isShowPosition == true)
                {
                    Utils.showLable(grap, points[i]);
                }
                Utils.drawCircle(grap, points[i], i.ToString());
            }

            for (int i = 0; i < pointCount; i++)
            {
                for (int j = 0; j < pointCount; j++)
                {
                    if (matRouting[i, j] != 0 && matRouting[i, j] != -1)
                    {
                        CPoint p = Utils.sub(points[i], points[j]);
                        p = Utils.mul(Utils.normal(p), radius);
                        if (isShowRay)
                        {
                            Utils.drawArrow(grap, Utils.sub(points[i], p), Utils.add(points[j], p), ArrowType.OneWay, Color.Gray, 1, DashStyle.Dash);
                        }
                    }
                }
            }

            for (int i = 0; i < route.Count - 1; i++)
            {
                CPoint p = Utils.sub(points[route[i]], points[route[i + 1]]);
                p = Utils.mul(Utils.normal(p), radius);
                Utils.drawArrow(grap, Utils.sub(points[route[i]], p), Utils.add(points[route[i + 1]], p), ArrowType.OneWay, Color.Blue, 2);
            }

            if (pointSelected != null)
            {
                Utils.drawCircleNoFill(grap, pointSelected, Color.Gray, 1);
                Utils.showLable(grap, pointSelected);
            }

            if (pointStart != null)
            {
                Utils.drawCircle(grap, pointStart , Color.Blue ,1);
                Utils.showLable(grap, pointStart, "BĐ");
            }

            if (pointEnd != null)
            {
                Utils.drawCircle(grap, pointEnd, Color.Red );
                Utils.showLable(grap, pointEnd, "KT", -13);
            }
        }


        private void pn_show_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var mouse = e.Location;

                if (pointSelected == null) return;
                foreach (var point in points)
                {
                    if (point.checkInSide(mouse.X, mouse.Y) == true && point == pointSelected)
                    {
                        showContextMenu(mouse);
                        break;
                    }
                }
                this.Invalidate();
            }
            if (e.Button == MouseButtons.Left)
            {
                var mouse = e.Location;

                foreach (var point in points)
                {
                    if (point.checkInSide(mouse.X, mouse.Y) == true)
                    {
                        pointSelected = point;
                        pn_show.Invalidate();
                        return;
                    }
                }
                pointSelected = null;
                pn_show.Invalidate();
            }
        }


        private void BTN_RanDom_Click(object sender, EventArgs e)
        {
            int pc;
            if (int.TryParse(TB_PointCount.Text, out pc))
            {
                if (pc < maxPointCount)
                {
                    pointCount = pc;
                }
                else
                {
                    MessageBox.Show("Giá trị điểm không vượt quá :  " + maxPointCount,
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Giá trị không hợp lệ", "Cảnh báo !",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (int.TryParse(TB_RayCount.Text, out pc))
            {
                if (pc < maxRayCount)
                {
                    rayCount = pc;
                }
                else
                {
                    MessageBox.Show("Giá trị đường không vượt quá :  " + maxRayCount, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Giá trị không hợp lệ", "Cảnh báo !", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            Generator();
            pn_show.Invalidate();
            showMatrix();
        }
        public void showContextMenu(Point mouse)
        {
            CTMN_Choose.Items[0].Visible = true;
            CTMN_Choose.Items[1].Visible = true;
            CTMN_Choose.Items[2].Visible = false;
            if (pointStart != null)
            {
                CTMN_Choose.Items[0].Visible = false;
            }
            if (pointEnd != null)
            {
                CTMN_Choose.Items[1].Visible = false;
            }
            if (pointSelected == pointStart || pointSelected == pointEnd)
            {
                CTMN_Choose.Items[2].Visible = true;
            }

            CTMN_Choose.Show(PointToScreen(mouse));
        }
        public void SetStartPointChoose()
        {
            pointStart = pointSelected;

            int index = points.IndexOf(pointStart);

            if (index != -1)
            {
                CBB_PointStart.SelectedIndex = CBB_PointStart.FindStringExact("P" + index.ToString());
            }
            pointSelected = null;
            pn_show.Invalidate();
        }
        public void SetEndPointChoose()
        {
            pointEnd = pointSelected;

            int index = points.IndexOf(pointEnd);

            if (index != -1)
            {
                CBB_PointEnd.SelectedIndex = CBB_PointEnd.FindStringExact("P" + index.ToString());
            }
            pointSelected = null;
            pn_show.Invalidate();
        }

        public void RemoveStartPointChoose()
        {
            route.Clear();
            pointStart = null;
            CBB_PointStart.SelectedIndex = 0;
            pn_show.Invalidate();
        }

        public void RemoveEndPointChoose()
        {
            route.Clear();
            pointEnd = null;
            CBB_PointEnd.SelectedIndex = 0;
            pn_show.Invalidate();
        }
        private void pn_show_DoubleClick(object sender, EventArgs e)
        {
            MouseEventArgs me = e as MouseEventArgs;

            if (me.Button == MouseButtons.Left)
            {
                var mouse = me.Location;

                foreach (var point in points)
                {
                    if (point.checkInSide(mouse.X, mouse.Y) == true)
                    {
                        pointSelected = point;
                        if (pointStart == null && pointEnd != pointSelected)
                        {
                            SetStartPointChoose();
                        }
                        else if (pointEnd == null && pointStart != pointSelected)
                        {
                            SetEndPointChoose();
                        }
                        else if (pointStart == pointSelected)
                        {
                            RemoveStartPointChoose();
                        }
                        else if (pointEnd == pointSelected)
                        {
                            RemoveEndPointChoose();
                        }
                        return;
                    }
                }
            }
        }
        private void CTMN_StartPoint_Click(object sender, EventArgs e)
        {
            SetStartPointChoose();
        }
        private void CTMN_EndPoint_Click(object sender, EventArgs e)
        {
            SetEndPointChoose();
        }

        private void CTMN_DeletPoint_Click(object sender, EventArgs e)
        {
            if (pointSelected == pointEnd)
            {
                RemoveEndPointChoose();
            }
            else if (pointSelected == pointStart)
            {
                RemoveStartPointChoose();
            }
        }

        public void ChangeSelectPoint(string strIndex, ref CPoint pChange)
        {
            if (strIndex != "None" && strIndex != null)
            {
                strIndex = strIndex.Substring(1, strIndex.Length - 1);
                pChange = points[Int32.Parse(strIndex)];
            }
            else
            {
                pChange = null;
            }
            pn_show.Invalidate();
        }

        private void CBB_PointStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sP = (string)CBB_PointStart.SelectedItem;
            ChangeSelectPoint(sP, ref pointStart);

        }

        private void CBB_PointEnd_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sP = (string)CBB_PointEnd.SelectedItem;
            ChangeSelectPoint(sP, ref pointEnd);
        }

        private void BTN_Start_Click(object sender, EventArgs e)
        {
            string strStart = CBB_PointStart.Text;
            string strEnd = CBB_PointEnd.Text;
            string strIndexStart = CBB_PointStart.Text.Substring(1, strStart.Length - 1);
            string strIndexEnd = CBB_PointEnd.Text.Substring(1, strEnd.Length - 1);

            int indexStart;
            int indexEnd;
            if (int.TryParse(strIndexStart, out indexStart) && int.TryParse(strIndexEnd, out indexEnd))
            {
                Dijkstra(indexStart, indexEnd);
                if (indexStart == indexEnd)
                {
                    MessageBox.Show("Hai điểm là trùng nhau !", "Cảnh báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (getRouter(indexStart, indexEnd))
                {
                    route.Reverse(0, route.Count);
                    pn_show.Invalidate();
                }
                else
                {
                    route.Clear();
                    MessageBox.Show("Không tìm thấy đường đi phù hợp !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Giá trị điểm không hợp lệ !", "Cảnh báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }
        private void BTN_Clear_Click(object sender, EventArgs e)
        {
            pointStart = null;
            pointEnd = null;
            route.Clear();
            CBB_PointStart.SelectedIndex = 0;
            CBB_PointEnd.SelectedIndex = 0;
            pointSelected = null;
        }

        private void CB_ShowPosition_CheckedChanged(object sender, EventArgs e)
        {
            isShowPosition = CB_ShowPosition.Checked;
            pn_show.Invalidate();
        }

        private void CB_ShowRay_CheckedChanged(object sender, EventArgs e)
        {
            isShowRay = CB_ShowRay.Checked;
            pn_show.Invalidate();
        }
    }
}
