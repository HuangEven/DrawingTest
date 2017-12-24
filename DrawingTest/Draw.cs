using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DrawingTest
{
    public partial class Draw : Form
    {
        public Draw()
        {
            InitializeComponent();
        }

        private DrawTools dt;
        private int lineWidth;//设置线条宽度
        private string sType;//绘图样式
        private string sFilename;//所要打开文件的文件名
        private bool bReSize = false;//判断是否改变画布大小
        private Size DefaultPicSize;//储存原始画布大小，用来新建文件时使用

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFile = new OpenFileDialog();
            oFile.Filter = "图像(*.bmp;*.jpg;*.ico;*.wmf;*.cur)|*.bmp;*.jpg;*.ico;*.wmf;*.cur";
            oFile.Multiselect = false;
            if (oFile.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmpfrom = new Bitmap(oFile.FileName);
                panel2.AutoScrollPosition = new Point(0, 0);
                pbImg.Size = bmpfrom.Size;

                reSize.Location = new Point(bmpfrom.Width, bmpfrom.Height);
                dt.DrawTools_Graphics = pbImg.CreateGraphics();

                Bitmap bmp = new Bitmap(pbImg.Width, pbImg.Height);
                Graphics g = Graphics.FromImage(bmp);
                g.FillRectangle(new SolidBrush(pbImg.BackColor), new Rectangle(0, 0, pbImg.Width, pbImg.Height));
                g.DrawImage(bmpfrom, 0, 0, bmpfrom.Width, bmpfrom.Height);
                g.Dispose();
                bmpfrom.Dispose();

                g = pbImg.CreateGraphics();
                g.DrawImage(bmp, 0, 0);
                g.Dispose();

                dt.OrginalImg = bmp;
                bmp.Dispose();
                sFilename = oFile.FileName;//储存打开的图片文件的详细路径，用来稍后能覆盖这个文件
                oFile.Dispose();
            }
        }

        private void 编辑ToolStripMenuItem_Click(object sender,EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pbImg_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Draw_Load(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            this.UpdateStyles();//以上两句是为了设置控件样式为双缓冲，这可以有效减少图片闪烁的问题
            Bitmap bmp = new Bitmap(pbImg.Width, pbImg.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(new SolidBrush(pbImg.BackColor), new Rectangle(0, 0, pbImg.Width, pbImg.Height));
            g.Dispose();
            dt = new DrawTools(this.pbImg.CreateGraphics(), Color.Black, bmp, 3);//实例化工具类
            DefaultPicSize = pbImg.Size;
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbImg.Size = DefaultPicSize;
            this.panel1.AutoScrollPosition = new Point(0, 0);
            Bitmap bmp = new Bitmap(DefaultPicSize.Width, DefaultPicSize.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(new SolidBrush(Color.White), 0, 0, DefaultPicSize.Width, DefaultPicSize.Height);
            g.Dispose();
            g = pbImg.CreateGraphics();
            g.DrawImage(bmp, 0, 0);
            g.Dispose();
            reSize.Location = new Point(DefaultPicSize.Width, DefaultPicSize.Height);
            dt.OrginalImg = bmp;
            sFilename = null;
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sFilename != null)
            {
                if (MessageBox.Show("是否保存文件", "系统提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dt.OrginalImg.Save(sFilename);
                }
            }
            else
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "图像(*.bmp;*.jpg;*.ico;*.wmf;*.cur)|*.bmp;*.jpg;*.ico;*.wmf;*.cur";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    dt.OrginalImg.Save(saveDialog.FileName);
                    sFilename = saveDialog.FileName;
                }
            }
        }

        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "图像(*.bmp;*.jpg;*.ico;*.wmf;*.cur)|*.bmp;*.jpg;*.ico;*.wmf;*.cur";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                dt.OrginalImg.Save(sfd.FileName);
                sFilename = sfd.FileName;
            }
        }

        private void 调色板ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.绘图工具ToolStripMenuItem.Checked)
            {
                this.绘图工具ToolStripMenuItem.Checked = true;
                this.panel1.Visible = true;
            }
            else
            {
                this.绘图工具ToolStripMenuItem.Checked = false;
                this.panel1.Visible = false;

            }
        }

        private void 调色板ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.调色板ToolStripMenuItem1.Checked)
            {
                this.调色板ToolStripMenuItem1.Checked = true;
                this.panel5.Visible = true;
            }
            else
            {
                this.调色板ToolStripMenuItem1.Checked = false;
                this.panel5.Visible = false;
            }
        }

        public void setcondition()
        {
            tspur.Checked = false;
            tsG.Checked = false;
            tsC.Checked = false;
            tsO.Checked = false;
            tsP.Checked = false;
            tsR.Checked = false;
            tsW.Checked = false;
            tsD.Checked = false;
            tsY.Checked = false;
            tsB.Checked = false;
        }

        #region 颜色板
        private void tsY_Click(object sender, EventArgs e)
        {
            setcondition();
            if (tsY.Checked)
            {
                tsY.Checked = true;
            }
            else
            {
                tsY.Checked = false;
            }
            tsbtForeColor.BackColor = tsY.BackColor;
            dt.DrawColor = tsY.BackColor;
        }

        private void tsB_Click(object sender, EventArgs e)
        {
            setcondition();
            if (tsB.Checked)
            {
                tsB.Checked = true;
            }
            else
            {
                tsB.Checked = false;
            }
            tsbtForeColor.BackColor = tsB.BackColor;
            dt.DrawColor = tsB.BackColor;
        }

        private void tsD_Click(object sender, EventArgs e)
        {
            setcondition();
            if (tsD.Checked)
            {
                tsD.Checked = true;
            }
            else
            {
                tsD.Checked = false;
            }
            tsbtForeColor.BackColor = tsD.BackColor;
            dt.DrawColor = tsD.BackColor;
        }

        private void tsDp_Click(object sender, EventArgs e)
        {
            setcondition();
            if (tsP.Checked)
            {
                tsP.Checked = true;
            }
            else
            {
                tsP.Checked = false;
            }

            tsbtForeColor.BackColor = tsP.BackColor;
            dt.DrawColor = tsP.BackColor;
        }

        private void tsO_Click(object sender, EventArgs e)
        {
            setcondition();
            if (tsO.Checked)
            {
                tsO.Checked = true;
            }
            else
            {
                tsO.Checked = false;
            }
            tsbtForeColor.BackColor = tsO.BackColor;
            dt.DrawColor = tsO.BackColor;
        }

        private void tsW_Click(object sender, EventArgs e)
        {
            setcondition();
            if (tsW.Checked)
            {
                tsW.Checked = true;
            }
            else
            {
                tsW.Checked = false;
            }
            tsbtForeColor.BackColor = tsW.BackColor;
            dt.DrawColor = tsW.BackColor;
        }

        private void tsR_Click(object sender, EventArgs e)
        {
            setcondition();
            if (tsR.Checked)
            {
                tsR.Checked = true;
            }
            else
            {
                tsR.Checked = false;
            }
            tsbtForeColor.BackColor = tsR.BackColor;
            dt.DrawColor = tsR.BackColor;
        }

        private void tsM_Click(object sender, EventArgs e)
        {
            setcondition();
            if (tspur.Checked)
            {
                tspur.Checked = true;
            }
            else
            {
                tspur.Checked = false;
            }
            tsbtForeColor.BackColor = tspur.BackColor;
            dt.DrawColor = tspur.BackColor;
        }

        private void tsG_Click(object sender, EventArgs e)
        {
            setcondition();
            if (tsC.Checked)
            {
                tsC.Checked = true;
            }
            else
            {
                tsC.Checked = false;
            }
            tsbtForeColor.BackColor = tsC.BackColor;
            dt.DrawColor = tsC.BackColor;
        }

        private void tsP_Click(object sender, EventArgs e)
        {
            setcondition();
            if (tsP.Checked)
            {
                tsP.Checked = true;
            }
            else
            {
                tsP.Checked = false;
            }
            tsbtForeColor.BackColor = tsP.BackColor;
            dt.DrawColor = tsP.BackColor;
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            ColorDialog cDia = new ColorDialog();
            if (cDia.ShowDialog(this) == DialogResult.OK)
            {
                tsbtForeColor.BackColor = cDia.Color;
                dt.DrawColor = cDia.Color;
            }
            Refresh();
        }
        #endregion

        private void 清除图像ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap newpic = new Bitmap(pbImg.Width, pbImg.Height);
            Graphics g = Graphics.FromImage(newpic);
            g.FillRectangle(new SolidBrush(Color.White), 0, 0, pbImg.Width, pbImg.Height);
            g.Dispose();
            g = pbImg.CreateGraphics();
            g.DrawImage(newpic, 0, 0);
            g.Dispose();
            dt.OrginalImg = newpic;
        }

        private void 状态栏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.状态栏ToolStripMenuItem.Checked)
            {
                this.状态栏ToolStripMenuItem.Checked = true;
                this.statusStrip1.Visible = true;
            }
            else
            {
                this.状态栏ToolStripMenuItem.Checked = false;
                this.statusStrip1.Visible = false;
            }
        }

       # region 线条粗细设置
        private void line1_Click(object sender, EventArgs e)
        {
            lineWidth = 1;
            dt.LineWidth = lineWidth;
        }

        private void line2_Click(object sender, EventArgs e)
        {
            lineWidth = 2;
            dt.LineWidth = lineWidth;
        }

        private void line3_Click(object sender, EventArgs e)
        {
            lineWidth = 5;
            dt.LineWidth = lineWidth;
        }

        private void line4_Click(object sender, EventArgs e)
        {
            lineWidth = 20;
            dt.LineWidth = lineWidth;
        }

        private void CustomLine_Click(object sender, EventArgs e)
        {
            LineDesign LDesign = new LineDesign();
            LDesign.StartPosition = FormStartPosition.CenterParent;
            if (LDesign.ShowDialog() == DialogResult.OK)
            {
               
                if (LDesign.textBox.Text != "")
                {
                    lineWidth = Convert.ToInt32(LDesign.textBox.Text);
                    dt.LineWidth = lineWidth;
                }
            }
        }

        #endregion

        private void 线条ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.线条ToolStripMenuItem.Checked)
            {
                this.线条ToolStripMenuItem.Checked = true;
                this.panel4.Visible = true;
            }
            else
            {
                this.线条ToolStripMenuItem.Checked = false;
                this.panel4.Visible = false;
            }
        }

        //窗口移动、最小化、最大化等造成的pbimg重画时间处理
        private void pbImg_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(dt.OrginalImg, 0, 0);
            //g.Dispose();切不可使用这个，这个graphics是系统传入的变量，不是我们自己创建的，如果dispose就会出错
        }

        //＂绘图工具选用＂事件处理方法
        private void tool_Click(object sender, EventArgs e)
        {
            ToolStripButton tsb = sender as ToolStripButton;
            if (tsb != null)
            {
                sType = tsb.Name;
                currentDrawType.Text = tsb.Text;
                switch (sType)
                {
                    case "pencil":
                        pbImg.Cursor = Cursors.Hand;
                        break;
                    //case "mouse":
                        //pbImg.Cursor = Cursors.Default;
                        //break;
                    case "eraser":
                        pbImg.Cursor = new Cursor(Application.StartupPath + @"\pb.cur");
                        break;
                    default:
                        pbImg.Cursor = Cursors.Cross;
                        break;

                }
            }
        }

        private void pbImg_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (dt != null)
                {
                    dt.startDraw = true;//相当于所选工具被激活，可以开始绘图
                    dt.startPoint = new PointF(e.X, e.Y);
                }
            }
        }


        private void pbImg_MouseMove(object sender, MouseEventArgs e)
        {
            Thread.Sleep(6);//减少cpu占用率
            mouseposition.Text = "鼠标位置:" + e.Location.ToString();
            toolStripStatusLabel3.Text = "图像大小: " + pbImg.Height + "px" + "*" + pbImg.Width + "px";
            if (dt.startDraw)
            {
                switch (sType)
                {
                    case "pencil": dt.DrawDot(e); break;
                    case "eraser": dt.Eraser(e); break;
                    default: dt.Draw(e, sType); break;

                }
            }
        }

        private void pbImg_MouseUp(object sender, MouseEventArgs e)
        {
            if (dt != null)
            {
                dt.EndDraw();
            }
        }

        private void reSize_MouseDown(object sender, MouseEventArgs e)
        {
            bReSize = true;//当鼠标按下时，说明要开始调节大小
        }

        private void reSize_MouseMove(object sender, MouseEventArgs e)
        {
            if (bReSize)
            {
                reSize.Location = new Point(reSize.Location.X + e.X, reSize.Location.Y + e.Y);

            }
        }

        private void reSize_MouseUp(object sender, MouseEventArgs e)
        {
            bReSize = false;//大小改变结束

            pbImg.Size = new Size(reSize.Location.X - (this.panel1.AutoScrollPosition.X), reSize.Location.Y - (this.panel1.AutoScrollPosition.Y));
            dt.DrawTools_Graphics = pbImg.CreateGraphics();//因为画板的大小被改变所以必须重新赋值

            //另外画布也被改变所以也要重新赋值
            Bitmap bmp = new Bitmap(pbImg.Width, pbImg.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(new SolidBrush(Color.White), 0, 0, pbImg.Width, pbImg.Height);
            g.DrawImage(dt.OrginalImg, 0, 0);
            g.Dispose();
            g = pbImg.CreateGraphics();
            g.DrawImage(bmp, 0, 0);
            g.Dispose();
            dt.OrginalImg = bmp;

            bmp.Dispose();
        }

        private void reSize_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
