using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Text;
using System.Drawing.Drawing2D;

namespace DDZCommon
{
    public class Util
    {
        /// <summary>
        /// Designed by eaglet
        /// </summary>
        /// <param name="total"></param>
        /// <returns></returns>
        public static int[] GetRandomSequence2(int begin, int end)
        {
            int total = end - begin;

            int[] sequence = new int[end];
            int[] output = new int[end];
            int[] ro = new int[total];

            for (int i = begin; i < end; i++)
            {
                sequence[i] = i;
            }

            Random random = new Random();

            end = end - 1;
            total = end;
            for (int i = begin; i <= total; i++)
            {
                int num = random.Next(begin, end + 1);
                output[i] = sequence[num];
                sequence[num] = sequence[end];
                end--;
            }
            Array.Copy(output, begin, ro, 0, total);
            return ro;
        }

        public static void PaintNewFont(Graphics g, string text)
        {
            PaintNewFont(g, text, Color.Gray,0,30);
        }
        public static void PaintNewFont(Graphics g,string text,Color c,int x,int y)
        {
            try
            {
                //投影文字
                //   Graphics g = this.CreateGraphics();
                //设置文本输出质量
                g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                Font newFont = new Font("Times New Roman", 48);
                Matrix matrix = new Matrix();
                //投射
                matrix.Shear(-1.5f, 0.0f);
                //缩放
                matrix.Scale(1, 0.5f);
                //平移
                matrix.Translate(130, 88);
                //对绘图平面实施坐标变换、、
                g.Transform = matrix;
                SolidBrush grayBrush = new SolidBrush(c);
                SolidBrush colorBrush = new SolidBrush(Color.WhiteSmoke);

                //绘制阴影
                //   g.DrawString(text, newFont, grayBrush, new PointF(0, 30));
                g.ResetTransform();
                //绘制前景
                g.DrawString(text, newFont, colorBrush, new PointF(x, y));
            }
            catch
            {
                
            }
        }

        public static void ShowImage(Graphics g,Image Image)
        {
            try
            {
                int width = Image.Width; //图像宽度 
                int height = Image.Height; //图像高度
              
                g.Clear(Color.Gray); //初始为全灰色
                for (int i = 0; i <= width / 2; i++)
                {
                    int j = Convert.ToInt32(i * (Convert.ToSingle(height) / Convert.ToSingle(width)));
                    Rectangle DestRect = new Rectangle(width / 2 - i, height / 2 - j, 2 * i, 2 * j);
                    Rectangle SrcRect = new Rectangle(0, 0, Image.Width, Image.Height);
                    g.DrawImage(Image, DestRect, SrcRect, GraphicsUnit.Pixel);
                    System.Threading.Thread.Sleep(10);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void EffectBoom(Graphics g,int x,int y)
        {

        }
    }
}
