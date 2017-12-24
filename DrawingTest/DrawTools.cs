using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;

namespace DrawingTest
{

    class DrawTools
    {
        public Graphics DrawTools_Graphics;//目标绘图板
        private Pen p;
        private int lineWidth = 3;//设置默认划线宽度
        private Image originalImg;//原始画布，用来保存已完成的绘图过程
        private Color drawColor = Color.Black;//绘图的画笔颜色
        private Color backColor = Color.White;//绘图区域的背景颜色
        private Graphics newgraphics;//中间画板
        private Image finishImg;//中间画布，用来保存绘图过程中的痕迹

        //绘图颜色
        public Color DrawColor
        {
            get
            {
                return drawColor;
            }
            set
            {
                drawColor = value;
                p.Color = value;
            }
        }

        //背景颜色
        public Color DrawBackColor
        {
            get
            {
                return backColor;
            }
            set
            {
                backColor = value;
            }
        }

        //线条粗细
        public int LineWidth
        {
            get { return lineWidth; }
            set
            {
                lineWidth = value;
                p.Width = value;
            }
        }

        //原始画布
        public Image OrginalImg
        {
            get
            {
                return originalImg;
            }
            set
            {
                finishImg = (Image)value.Clone();
                originalImg = (Image)value.Clone();
            }
        }

        //设置bool变量startDraw表示是否开始绘图
        public bool startDraw = false;

        //设置绘图起点
        public PointF startPoint;

        /// <summary>
        /// 初始化绘图工具
        /// </summary>
        /// <param name="g">绘图板</param>
        /// <param name="c">绘图颜色</param>
        /// <param name="img">初始画布</param>
        /// <param name="linewidth">线条宽度</param>
        public DrawTools(Graphics g, Color c, Image img, int linewidth)
        {
            DrawTools_Graphics = g;
            drawColor = c;
            p = new Pen(c, linewidth);
            finishImg = (Image)img.Clone();
            originalImg = (Image)img.Clone();
        }

        /// <summary>
        /// 绘制直线，矩形，圆形
        /// </summary>
        /// <param name="e">鼠标参数</param>
        /// <param name="sType">绘图类型</param>
        public void Draw(MouseEventArgs e, String stype)
        {
            if (startDraw)
            {

                Image img = (Image)originalImg.Clone();//为防止直接改写原始画布，我们定义一个新的image去得到原始画布
                newgraphics = Graphics.FromImage(img);//实例化中间画板
                switch (stype)
                {
                    case "line":
                        {
                            newgraphics.DrawLine(p, startPoint, new Point(e.X, e.Y));
                            break;
                        }

                    case "Rect":
                        {
                            float width = Math.Abs(e.X - startPoint.X);
                            float height = Math.Abs(e.Y - startPoint.Y);
                            PointF rectStartPoint = startPoint;
                            if (e.X < rectStartPoint.X)
                            {
                                rectStartPoint.X = e.X;
                            }
                            if (e.Y < rectStartPoint.Y)
                            {
                                rectStartPoint.Y = e.Y;
                            }
                            newgraphics.DrawRectangle(p, rectStartPoint.X, rectStartPoint.Y, width, height);
                            break;
                        }
                    case "circle":
                        {
                            float width = Math.Abs(e.X - startPoint.X);
                            float height = Math.Abs(e.Y - startPoint.Y);
                            PointF rectStartPoint = startPoint;
                            float bian = (width < height) ? width : height;//获取较小者                           

                            if (e.X < startPoint.X)
                            {
                                rectStartPoint.X = startPoint.X - bian;
                            }
                            if (e.Y < startPoint.Y)
                            {
                                rectStartPoint.Y = startPoint.Y - bian;
                            }
                            newgraphics.DrawEllipse(p, rectStartPoint.X, rectStartPoint.Y, bian, bian);
                            break;
                        }
                    case "ellipse":
                        {
                            newgraphics.DrawEllipse(p, startPoint.X, startPoint.Y, e.X - startPoint.X, e.Y - startPoint.Y);
                            break;
                        }
                    case "square":
                        {
                            float width = Math.Abs(e.X - startPoint.X);
                            float height = Math.Abs(e.Y - startPoint.Y);
                            PointF rectStartPoint = startPoint;
                            float bian = (width < height) ? width : height;//获取较小者                           

                            if (e.X < startPoint.X)
                            {
                                rectStartPoint.X = startPoint.X - bian;
                            }
                            if (e.Y < startPoint.Y)
                            {
                                rectStartPoint.Y = startPoint.Y - bian;
                            }
                            newgraphics.DrawRectangle(p, rectStartPoint.X, rectStartPoint.Y, bian, bian);
                            break;
                        }
                    case "FillRect":
                        {
                            float width = Math.Abs(e.X - startPoint.X);
                            float height = Math.Abs(e.Y - startPoint.Y);
                            PointF rectStartPoint = startPoint;
                            if (e.X < rectStartPoint.X)
                            {
                                rectStartPoint.X = e.X;
                            }
                            if (e.Y < rectStartPoint.Y)
                            {
                                rectStartPoint.Y = e.Y;
                            }
                            newgraphics.FillRectangle(new SolidBrush(drawColor), rectStartPoint.X, rectStartPoint.Y, width, height);
                            break;
                        }
                    case "FillCircle":
                        {
                            newgraphics.FillEllipse(new SolidBrush(drawColor), startPoint.X, startPoint.Y, e.X - startPoint.X, e.Y - startPoint.Y);
                            break;
                        }
                    case "FillSquare":
                        {
                            float width = Math.Abs(e.X - startPoint.X);
                            float height = Math.Abs(e.Y - startPoint.Y);
                            PointF rectStartPoint = startPoint;
                            float bian = (width < height) ? width : height;//获取较小者                           

                            if (e.X < startPoint.X)
                            {
                                rectStartPoint.X = startPoint.X - bian;
                            }
                            if (e.Y < startPoint.Y)
                            {
                                rectStartPoint.Y = startPoint.Y - bian;
                            }
                            newgraphics.FillRectangle(new SolidBrush(drawColor), rectStartPoint.X, rectStartPoint.Y, bian, bian);
                            break;
                        }
                }
                newgraphics.Dispose();//绘图完后，释放中间画板所占资源
                newgraphics = Graphics.FromImage(finishImg);//另外建立一个中间画板，画布为中间图片
                newgraphics.DrawImage(img, 0, 0);//将图片画到中间画板上
                newgraphics.Dispose();
                DrawTools_Graphics.DrawImage(img, 0, 0);//将图片画到目标画板上
                img.Dispose();
            }
        }

        public void EndDraw()
        {
            startDraw = false;
            //为了将完成后的绘图过程保留下来，要将中间图片绘制到原始画布上
            newgraphics = Graphics.FromImage(originalImg);
            newgraphics.DrawImage(finishImg, 0, 0);
            newgraphics.Dispose();
        }

        //橡皮檫
        public void Eraser(MouseEventArgs e)
        {
            if (startDraw)
            {
                newgraphics = Graphics.FromImage(finishImg);
                newgraphics.FillRectangle(new SolidBrush(Color.White), e.X, e.Y, 10, 10);

                newgraphics.Dispose();
                DrawTools_Graphics.DrawImage(finishImg, 0, 0);
            }
        }

        //铅笔
        public void DrawDot(MouseEventArgs e)
        { 
            newgraphics = Graphics.FromImage(finishImg);
            PointF currentPointF = new PointF(e.X, e.Y);
            newgraphics.DrawLine(p, startPoint, currentPointF);
            startPoint = currentPointF;
            newgraphics.Dispose();
            DrawTools_Graphics.DrawImage(finishImg, 0, 0);
        }

        /// <summary>
        /// 清除变量，释放内存
        /// </summary>
        public void ClearVar()
        {
            DrawTools_Graphics.Dispose();
            finishImg.Dispose();
            originalImg.Dispose();
            p.Dispose();
        }
    }
}
