using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using Pastel;

namespace FlagPFP.Processing
{
    public class ImageProcessing
    {
        public int finalSize;
        public Bitmap CropPicture(ref Bitmap bmp, int size, bool cropToSquare = true)
        {
            Console.WriteLine("Cropping image...".Pastel(Color.LightSteelBlue));
            finalSize = size;
            if (cropToSquare)
            {
                Bitmap res = new Bitmap(size, size);
                Graphics g = Graphics.FromImage(res);
                g.FillRectangle(new SolidBrush(Color.White), 0, 0, size, size);

                int t = 0, l = 0;
                if (bmp.Height > bmp.Width) t = (bmp.Height - bmp.Width) / 2;
                else l = (bmp.Width - bmp.Height) / 2;

                g.DrawImage(bmp, new Rectangle(0, 0, size, size),
                    new Rectangle(l, t, bmp.Width - l * 2, bmp.Height - t * 2), GraphicsUnit.Pixel);
                return res;
            }

            Console.WriteLine("Cropped successfully!".Pastel(Color.LightGreen));
            return bmp;
        }

        public Bitmap StitchTogether(ref Bitmap flag, ref Bitmap pic, int picSize)
        {
            Console.WriteLine("Stitching everything together...".Pastel(Color.LightSteelBlue));
            Bitmap res = new Bitmap(finalSize, finalSize);
            using (Graphics g = Graphics.FromImage(res))
            {
                g.Clear(Color.White);
                g.DrawImage(pic, new Rectangle((finalSize - picSize) / 2, (finalSize - picSize) / 2, picSize, picSize));
                g.DrawImage(flag, new Rectangle(0, 0, finalSize, finalSize));
            }
            Console.WriteLine("Merged images together successfully!".Pastel(Color.LightGreen));
            return res;
        }

        public Bitmap LoadAndResizeBmp(string filename, int width, int height)
        {
            Bitmap source = new Bitmap(Image.FromFile(filename));
            Bitmap result = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.InterpolationMode = InterpolationMode.NearestNeighbor;
                g.DrawImage(source, 0, 0, width, height);
            }
            return result;
        }

        public Bitmap CropFlag(ref Bitmap flagImg, int pixelMargin)
        {
            Console.WriteLine("Cropping flag...".Pastel(Color.LightSteelBlue));
            int widthHeight = finalSize - pixelMargin;
            using (Graphics g = Graphics.FromImage(flagImg))
            {
                g.CompositingMode = CompositingMode.SourceCopy;
                g.FillEllipse(Brushes.Transparent, (finalSize - widthHeight) / 2, (finalSize - widthHeight) / 2, widthHeight, widthHeight);
            }
            Console.WriteLine("Cropped flag successfully!".Pastel(Color.LightGreen));
            return flagImg;
        }
    }
}