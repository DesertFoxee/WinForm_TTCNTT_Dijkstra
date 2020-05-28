namespace TTCNTT
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CB_ShowPosition = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LB_RayCount = new System.Windows.Forms.Label();
            this.LB_TwoDimCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LB_PointCount = new System.Windows.Forms.Label();
            this.LB_OneDimCount = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TB_RayCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_PointCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BTN_Start = new System.Windows.Forms.Button();
            this.BTN_RanDom = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CBB_PointEnd = new System.Windows.Forms.ComboBox();
            this.CBB_PointStart = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pn_show = new System.Windows.Forms.Panel();
            this.BTN_Clear = new System.Windows.Forms.Button();
            this.CTMN_Choose = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CTMN_StartPoint = new System.Windows.Forms.ToolStripMenuItem();
            this.CTMN_EndPoint = new System.Windows.Forms.ToolStripMenuItem();
            this.CTMN_DeletPoint = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.CB_ShowRay = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pn_show.SuspendLayout();
            this.CTMN_Choose.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.CB_ShowRay);
            this.panel1.Controls.Add(this.CB_ShowPosition);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CBB_PointEnd);
            this.panel1.Controls.Add(this.CBB_PointStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(592, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 466);
            this.panel1.TabIndex = 0;
            // 
            // CB_ShowPosition
            // 
            this.CB_ShowPosition.AutoSize = true;
            this.CB_ShowPosition.Location = new System.Drawing.Point(138, 134);
            this.CB_ShowPosition.Name = "CB_ShowPosition";
            this.CB_ShowPosition.Size = new System.Drawing.Size(15, 14);
            this.CB_ShowPosition.TabIndex = 6;
            this.CB_ShowPosition.UseVisualStyleBackColor = true;
            this.CB_ShowPosition.CheckedChanged += new System.EventHandler(this.CB_ShowPosition_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Hiển thị tọa độ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.LB_RayCount);
            this.groupBox2.Controls.Add(this.LB_TwoDimCount);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.LB_PointCount);
            this.groupBox2.Controls.Add(this.LB_OneDimCount);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 150);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // LB_RayCount
            // 
            this.LB_RayCount.AutoSize = true;
            this.LB_RayCount.Location = new System.Drawing.Point(132, 52);
            this.LB_RayCount.Name = "LB_RayCount";
            this.LB_RayCount.Size = new System.Drawing.Size(25, 13);
            this.LB_RayCount.TabIndex = 0;
            this.LB_RayCount.Text = "100";
            // 
            // LB_TwoDimCount
            // 
            this.LB_TwoDimCount.AutoSize = true;
            this.LB_TwoDimCount.Location = new System.Drawing.Point(132, 114);
            this.LB_TwoDimCount.Name = "LB_TwoDimCount";
            this.LB_TwoDimCount.Size = new System.Drawing.Size(25, 13);
            this.LB_TwoDimCount.TabIndex = 0;
            this.LB_TwoDimCount.Text = "100";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số đường nối";
            // 
            // LB_PointCount
            // 
            this.LB_PointCount.AutoSize = true;
            this.LB_PointCount.Location = new System.Drawing.Point(132, 26);
            this.LB_PointCount.Name = "LB_PointCount";
            this.LB_PointCount.Size = new System.Drawing.Size(25, 13);
            this.LB_PointCount.TabIndex = 0;
            this.LB_PointCount.Text = "100";
            // 
            // LB_OneDimCount
            // 
            this.LB_OneDimCount.AutoSize = true;
            this.LB_OneDimCount.Location = new System.Drawing.Point(132, 84);
            this.LB_OneDimCount.Name = "LB_OneDimCount";
            this.LB_OneDimCount.Size = new System.Drawing.Size(25, 13);
            this.LB_OneDimCount.TabIndex = 0;
            this.LB_OneDimCount.Text = "100";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Một chiều";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Hai chiều";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số điểm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TB_RayCount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TB_PointCount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 314);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 111);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cấu hình sinh";
            // 
            // TB_RayCount
            // 
            this.TB_RayCount.Location = new System.Drawing.Point(81, 68);
            this.TB_RayCount.Name = "TB_RayCount";
            this.TB_RayCount.Size = new System.Drawing.Size(120, 20);
            this.TB_RayCount.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số đường";
            // 
            // TB_PointCount
            // 
            this.TB_PointCount.Location = new System.Drawing.Point(81, 28);
            this.TB_PointCount.Name = "TB_PointCount";
            this.TB_PointCount.Size = new System.Drawing.Size(120, 20);
            this.TB_PointCount.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điểm";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BTN_Start);
            this.panel3.Controls.Add(this.BTN_RanDom);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 425);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(204, 37);
            this.panel3.TabIndex = 3;
            // 
            // BTN_Start
            // 
            this.BTN_Start.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTN_Start.FlatAppearance.BorderSize = 0;
            this.BTN_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Start.Location = new System.Drawing.Point(119, 3);
            this.BTN_Start.Name = "BTN_Start";
            this.BTN_Start.Size = new System.Drawing.Size(75, 28);
            this.BTN_Start.TabIndex = 0;
            this.BTN_Start.TabStop = false;
            this.BTN_Start.Text = "Bắt đầu   >";
            this.BTN_Start.UseVisualStyleBackColor = false;
            this.BTN_Start.Click += new System.EventHandler(this.BTN_Start_Click);
            // 
            // BTN_RanDom
            // 
            this.BTN_RanDom.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTN_RanDom.FlatAppearance.BorderSize = 0;
            this.BTN_RanDom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_RanDom.Location = new System.Drawing.Point(5, 3);
            this.BTN_RanDom.Name = "BTN_RanDom";
            this.BTN_RanDom.Size = new System.Drawing.Size(110, 28);
            this.BTN_RanDom.TabIndex = 0;
            this.BTN_RanDom.TabStop = false;
            this.BTN_RanDom.Text = "Sinh ngẫu nhiên";
            this.BTN_RanDom.UseVisualStyleBackColor = false;
            this.BTN_RanDom.Click += new System.EventHandler(this.BTN_RanDom_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Điểm đến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Điểm xuất phát";
            // 
            // CBB_PointEnd
            // 
            this.CBB_PointEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBB_PointEnd.FormattingEnabled = true;
            this.CBB_PointEnd.Location = new System.Drawing.Point(80, 56);
            this.CBB_PointEnd.Name = "CBB_PointEnd";
            this.CBB_PointEnd.Size = new System.Drawing.Size(121, 21);
            this.CBB_PointEnd.TabIndex = 1;
            this.CBB_PointEnd.SelectedIndexChanged += new System.EventHandler(this.CBB_PointEnd_SelectedIndexChanged);
            // 
            // CBB_PointStart
            // 
            this.CBB_PointStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBB_PointStart.FormattingEnabled = true;
            this.CBB_PointStart.Location = new System.Drawing.Point(80, 16);
            this.CBB_PointStart.Name = "CBB_PointStart";
            this.CBB_PointStart.Size = new System.Drawing.Size(121, 21);
            this.CBB_PointStart.TabIndex = 1;
            this.CBB_PointStart.SelectedIndexChanged += new System.EventHandler(this.CBB_PointStart_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(592, 2);
            this.panel2.TabIndex = 1;
            // 
            // pn_show
            // 
            this.pn_show.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pn_show.Controls.Add(this.BTN_Clear);
            this.pn_show.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_show.Location = new System.Drawing.Point(0, 2);
            this.pn_show.Name = "pn_show";
            this.pn_show.Size = new System.Drawing.Size(592, 464);
            this.pn_show.TabIndex = 3;
            this.pn_show.Paint += new System.Windows.Forms.PaintEventHandler(this.Pn_Show_Paint);
            this.pn_show.DoubleClick += new System.EventHandler(this.pn_show_DoubleClick);
            this.pn_show.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pn_show_MouseDown);
            // 
            // BTN_Clear
            // 
            this.BTN_Clear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTN_Clear.FlatAppearance.BorderSize = 0;
            this.BTN_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Clear.Location = new System.Drawing.Point(497, 429);
            this.BTN_Clear.Name = "BTN_Clear";
            this.BTN_Clear.Size = new System.Drawing.Size(92, 28);
            this.BTN_Clear.TabIndex = 0;
            this.BTN_Clear.TabStop = false;
            this.BTN_Clear.Text = "Dọn dẹp";
            this.BTN_Clear.UseVisualStyleBackColor = false;
            this.BTN_Clear.Click += new System.EventHandler(this.BTN_Clear_Click);
            // 
            // CTMN_Choose
            // 
            this.CTMN_Choose.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CTMN_StartPoint,
            this.CTMN_EndPoint,
            this.CTMN_DeletPoint});
            this.CTMN_Choose.Name = "CTMN_Choose";
            this.CTMN_Choose.Size = new System.Drawing.Size(156, 70);
            // 
            // CTMN_StartPoint
            // 
            this.CTMN_StartPoint.Name = "CTMN_StartPoint";
            this.CTMN_StartPoint.Size = new System.Drawing.Size(155, 22);
            this.CTMN_StartPoint.Text = "Điểm xuất phát";
            this.CTMN_StartPoint.Click += new System.EventHandler(this.CTMN_StartPoint_Click);
            // 
            // CTMN_EndPoint
            // 
            this.CTMN_EndPoint.Name = "CTMN_EndPoint";
            this.CTMN_EndPoint.Size = new System.Drawing.Size(155, 22);
            this.CTMN_EndPoint.Text = "Điểm đến";
            this.CTMN_EndPoint.Click += new System.EventHandler(this.CTMN_EndPoint_Click);
            // 
            // CTMN_DeletPoint
            // 
            this.CTMN_DeletPoint.Name = "CTMN_DeletPoint";
            this.CTMN_DeletPoint.Size = new System.Drawing.Size(155, 22);
            this.CTMN_DeletPoint.Text = "Xóa";
            this.CTMN_DeletPoint.Click += new System.EventHandler(this.CTMN_DeletPoint_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Hiển thị đường nối";
            // 
            // CB_ShowRay
            // 
            this.CB_ShowRay.AutoSize = true;
            this.CB_ShowRay.Location = new System.Drawing.Point(138, 98);
            this.CB_ShowRay.Name = "CB_ShowRay";
            this.CB_ShowRay.Size = new System.Drawing.Size(15, 14);
            this.CB_ShowRay.TabIndex = 6;
            this.CB_ShowRay.UseVisualStyleBackColor = true;
            this.CB_ShowRay.CheckedChanged += new System.EventHandler(this.CB_ShowRay_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.pn_show);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thực tập công nghệ thông tin (Tìm đường đi ngắn nhất)";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.pn_show.ResumeLayout(false);
            this.CTMN_Choose.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pn_show;
        private System.Windows.Forms.Button BTN_Start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBB_PointEnd;
        private System.Windows.Forms.ComboBox CBB_PointStart;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BTN_RanDom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LB_TwoDimCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LB_OneDimCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip CTMN_Choose;
        private System.Windows.Forms.ToolStripMenuItem CTMN_StartPoint;
        private System.Windows.Forms.ToolStripMenuItem CTMN_EndPoint;
        private System.Windows.Forms.Label LB_RayCount;
        private System.Windows.Forms.Label LB_PointCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TB_RayCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_PointCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem CTMN_DeletPoint;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BTN_Clear;
        private System.Windows.Forms.CheckBox CB_ShowPosition;
        private System.Windows.Forms.CheckBox CB_ShowRay;
        private System.Windows.Forms.Label label8;
    }
}

