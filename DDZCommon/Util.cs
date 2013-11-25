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
        public const int PaintNewFont_Size = 48;
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

        public static void PaintCallScorePortrait(Graphics g, string text,int x,int y)
        {
            try
            {
                Font newFont = new Font("隶书", 16,FontStyle.Regular);
                SolidBrush colorBrush = new SolidBrush(Color.White);
                g.DrawString(text, newFont, colorBrush, new PointF(x, y));
            }
            catch (Exception ex)
            {
                throw ex;

            }
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
                Font newFont = new Font("Times New Roman", PaintNewFont_Size);
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
            catch(Exception ex)
            {
                throw ex;
                
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

       
        #region 图片旋转函数
        /// <summary>
        /// 以逆时针为方向对图像进行旋转
        /// </summary>
        /// <param name="b">位图流</param>
        /// <param name="angle">旋转角度[0,360](前台给的)</param>
        /// <returns></returns>
        public static Bitmap Rotate(Bitmap b, int angle)
        {
            angle = angle % 360;

            //弧度转换
            double radian = angle * Math.PI / 180.0;
            double cos = Math.Cos(radian);
            double sin = Math.Sin(radian);

            //原图的宽和高
            int w = b.Width;
            int h = b.Height;
            int W = (int)(Math.Max(Math.Abs(w * cos - h * sin), Math.Abs(w * cos + h * sin)));
            int H = (int)(Math.Max(Math.Abs(w * sin - h * cos), Math.Abs(w * sin + h * cos)));

            //目标位图
            Bitmap dsImage = new Bitmap(W, H);
            Graphics g = Graphics.FromImage(dsImage);

            g.InterpolationMode = InterpolationMode.Bilinear;

            g.SmoothingMode = SmoothingMode.HighQuality;

            //计算偏移量
            Point Offset = new Point((W - w) / 2, (H - h) / 2);

            //构造图像显示区域：让图像的中心与窗口的中心点一致
            Rectangle rect = new Rectangle(Offset.X, Offset.Y, w, h);
            Point center = new Point(rect.X + rect.Width / 2, rect.Y + rect.Height / 2);
            g.TranslateTransform(center.X, center.Y);
            g.RotateTransform(360 - angle);

            //恢复图像在水平和垂直方向的平移
            g.TranslateTransform(-center.X, -center.Y);
            g.DrawImage(b, rect);

            //重至绘图的所有变换
            g.ResetTransform();

            g.Save();
            g.Dispose();
            return dsImage;
        }

        #endregion 图片旋转函数

      


        public static Bitmap rotateImage(Bitmap b, float angle)
        {
            //create a new empty bitmap to hold rotated image
            Bitmap returnBitmap = new Bitmap(b.Width, b.Height);
            //make a graphics object from the empty bitmap
            Graphics g = Graphics.FromImage(returnBitmap);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            //move rotation point to center of image
            g.TranslateTransform((float)b.Width / 2, (float)b.Height / 2);
            //rotate
            g.RotateTransform(angle);
            //move image back
            g.TranslateTransform(-(float)b.Width / 2, -(float)b.Height / 2);
            //draw passed in image onto graphics object
            g.DrawImage(b, new Point(0, 0));
            return returnBitmap;
        }






        public static Bitmap RotateImage(Bitmap image, float rotateAtX, float rotateAtY, float angle, bool bNoClip)
        {
            int W, H, X, Y;
            if (bNoClip)
            {
                double dW = (double)image.Width;
                double dH = (double)image.Height;

                double degrees = Math.Abs(angle);
                if (degrees <= 90)
                {
                    double radians = 0.0174532925 * degrees;
                    double dSin = Math.Sin(radians);
                    double dCos = Math.Cos(radians);
                    W = (int)(dH * dSin + dW * dCos);
                    H = (int)(dW * dSin + dH * dCos);
                    X = (W - image.Width) / 2;
                    Y = (H - image.Height) / 2;
                }
                else
                {
                    degrees -= 90;
                    double radians = 0.0174532925 * degrees;
                    double dSin = Math.Sin(radians);
                    double dCos = Math.Cos(radians);
                    W = (int)(dW * dSin + dH * dCos);
                    H = (int)(dH * dSin + dW * dCos);
                    X = (W - image.Width) / 2;
                    Y = (H - image.Height) / 2;
                }
            }
            else
            {
                W = image.Width;
                H = image.Height;
                X = 0;
                Y = 0;
            }

            //create a new empty bitmap to hold rotated image
            Bitmap bmpRet = new Bitmap(W, H);
            bmpRet.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            //make a graphics object from the empty bitmap
            Graphics g = Graphics.FromImage(bmpRet);

            //Put the rotation point in the "center" of the image
            g.TranslateTransform(rotateAtX + X, rotateAtY + Y);

            //rotate the image
            g.RotateTransform(angle);

            //move the image back
            g.TranslateTransform(-rotateAtX - X, -rotateAtY - Y);

            //draw passed in image onto graphics object
            g.DrawImage(image, new PointF(0 + X, 0 + Y));

            return bmpRet;
        }
    }
}
