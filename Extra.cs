using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using Pastel;
using System;
using System.Linq;

namespace FlagPFP.Main
{
    public partial class MainProgram
    {
        public static Dictionary<string, string> flagsTable = new Dictionary<string, string>()
        {
            { "gay", "Flags/gay.png" },
            { "agender", "Flags/agender.png" },
            { "aromantic", "Flags/aromantic.png" },
            { "asexual", "Flags/asexual.png" },
            { "bisexual", "Flags/bisexual.png" },
            { "demisexual", "Flags/demisexual.png" },
            { "gaymen", "Flags/gaymen.png" },
            { "genderfluid", "Flags/genderfluid.png" },
            { "genderqueer", "Flags/genderqueer.png" },
            { "lesbian", "Flags/lesbian.png" },
            { "nonbinary", "Flags/nonbinary.png" },
            { "pansexual", "Flags/pansexual.png" },
            { "polysexual", "Flags/polysexual.png" },
            { "transgender", "Flags/transgender.png" }
        };

        //Chunky boy
        public static void WriteHeaders(string flag)
        {
            switch (flag)
            {
                case "gay":
                    Console.WriteLine("-Gay Flag- ".Pastel(Color.LightSteelBlue)
                                      + string.Join("", gayFlag.Select(s => s.letter.PastelBg(s.color))));
                    break;
                case "agender":
                    Console.WriteLine("-Agender Flag- ".Pastel(Color.LightSteelBlue)
                                      + string.Join("", agenderFlag.Select(s => s.letter.PastelBg(s.color))));
                    Console.WriteLine("Flag Design: ".Pastel(Color.LightBlue) + "By Salem Fontana - Salem’s initial agender flag design post from tumblr".Pastel(Color.Aquamarine) +
                                      " Interview with Salem about the flag’s design,".Pastel(Color.Aquamarine) +
                                      " CC BY-SA 4.0, https://commons.wikimedia.org/w/index.php?curid=38242756".Pastel(Color.DarkSeaGreen));
                    break;
                case "aromantic":
                    Console.WriteLine("-Aromantic Flag- ".Pastel(Color.LightSteelBlue)
                                      + string.Join("", aromanticFlag.Select(s => s.letter.PastelBg(s.color))));
                    break;
                case "asexual":
                    Console.WriteLine("-Asexual Flag- ".Pastel(Color.LightSteelBlue)
                                      + string.Join("", asexualFlag.Select(s => s.letter.PastelBg(s.color))));
                    break;
                case "bisexual":
                    Console.WriteLine("-Bisexual Flag- ".Pastel(Color.LightSteelBlue)
                                      + string.Join("", bisexualFlag.Select(s => s.letter.PastelBg(s.color))));
                    break;
                case "demisexual":
                    Console.WriteLine("-Demisexual Flag- ".Pastel(Color.LightSteelBlue)
                                      + string.Join("", demisexualFlag.Select(s => s.letter.PastelBg(s.color))));
                    break;
                case "gaymen":
                    Console.WriteLine("-Gay Men Flag- ".Pastel(Color.LightSteelBlue)
                                      + string.Join("", gaymenFlag.Select(s => s.letter.PastelBg(s.color))));
                    break;
                case "genderfluid":
                    Console.WriteLine("-Genderfluid Flag- ".Pastel(Color.LightSteelBlue)
                                      + string.Join("", genderfluidFlag.Select(s => s.letter.PastelBg(s.color))));
                    Console.WriteLine("Flag Design: ".Pastel(Color.LightBlue) + "By JJ Pole.McLennonSon - Own work,".Pastel(Color.Aquamarine) +
                                      " CC BY-SA 4.0, https://commons.wikimedia.org/w/index.php?curid=38242265".Pastel(Color.DarkSeaGreen));
                    break;
                case "genderqueer":
                    Console.WriteLine("-Genderqueer Flag- ".Pastel(Color.LightSteelBlue)
                                      + string.Join("", genderqueerFlag.Select(s => s.letter.PastelBg(s.color))));
                    break;
                case "lesbian":
                    Console.WriteLine("-Lesbian Flag- ".Pastel(Color.LightSteelBlue)
                                      + string.Join("", lesbianFlag.Select(s => s.letter.PastelBg(s.color))));
                    break;
                case "nonbinary":
                    Console.WriteLine("-Non Binary Flag- ".Pastel(Color.LightSteelBlue)
                                      + string.Join("", nonbinaryFlag.Select(s => s.letter.PastelBg(s.color))));
                    break;
                case "pansexual":
                    Console.WriteLine("-Pansexual Flag- ".Pastel(Color.LightSteelBlue)
                                      + string.Join("", pansexualFlag.Select(s => s.letter.PastelBg(s.color))));
                    break;
                case "polysexual":
                    Console.WriteLine("-Polysexual Flag- ".Pastel(Color.LightSteelBlue)
                                      + string.Join("", polysexualFlag.Select(s => s.letter.PastelBg(s.color))));
                    Console.WriteLine("Flag Design: ".Pastel(Color.LightBlue) + "By McLennonSon - Own work, ".Pastel(Color.Aquamarine) +
                                      "CC BY-SA 4.0, https://commons.wikimedia.org/w/index.php?curid=38241562".Pastel(Color.DarkSeaGreen));
                    break;
                case "transgender":
                    Console.WriteLine("-Transgender Flag- ".Pastel(Color.LightSteelBlue)
                                      + string.Join("", transgenderFlag.Select(s => s.letter.PastelBg(s.color))));
                    break;
            }
        }

        public static int finalSize;
        public static Bitmap CropPicture(ref Bitmap bmp, int size)
        {
            Console.WriteLine("Cropping image to square...".Pastel(Color.LightSteelBlue));
            finalSize = size;
            Bitmap res = new Bitmap(size, size);
            Graphics g = Graphics.FromImage(res);
            g.FillRectangle(new SolidBrush(Color.White), 0, 0, size, size);

            int t = 0, l = 0;
            if (bmp.Height > bmp.Width) t = (bmp.Height - bmp.Width) / 2;
            else l = (bmp.Width - bmp.Height) / 2;

            g.DrawImage(bmp, new Rectangle(0, 0, size, size), new Rectangle(l, t, bmp.Width - l * 2, bmp.Height - t * 2), GraphicsUnit.Pixel);
            Console.WriteLine("Cropped to square successfully!".Pastel(Color.LightSteelBlue));
            return res;
        }

        public static Bitmap StitchTogether(ref Bitmap flag, ref Bitmap pic)
        {
            Console.WriteLine("Stitching everything together...".Pastel(Color.LightSteelBlue));
            Bitmap res = new Bitmap(finalSize, finalSize);
            using(Graphics g = Graphics.FromImage(res))
            {
                g.DrawImage(pic, new Rectangle(0, 0, finalSize, finalSize));
                g.DrawImage(flag, new Rectangle(0, 0, finalSize, finalSize));
            }
            Console.WriteLine("Merged images together successfully!".Pastel(Color.LightSteelBlue));
            return res;
        }

        public static Bitmap CropFlag(ref Bitmap flagImg, int pixelMargin)
        {
            Console.WriteLine("Cropping flag...".Pastel(Color.LightSteelBlue));
            int widthHeight = finalSize - pixelMargin;
            using(Graphics g = Graphics.FromImage(flagImg))
            {
                g.CompositingMode = CompositingMode.SourceCopy;
                g.FillEllipse(Brushes.Transparent, (finalSize - widthHeight) / 2, (finalSize - widthHeight) / 2, widthHeight, widthHeight);
            }
            Console.WriteLine("Cropped flag successfully!".Pastel(Color.LightSteelBlue));
            return flagImg;
        }

        //Unused enum, may use later idk
        public enum Flags
        {
            GAY_PRIDE = 0,
            AGENDER = 1,
            AROMANTIC = 2,
            ASEXUAL = 3,
            BISEXUAL = 4,
            DEMISEXUAL = 5,
            GAY_MEN = 6,
            GENDERFLUID = 7,
            GENDERQUEER = 8,
            INTERSEX = 9,
            LESBIAN = 10,
            NONBINARY = 11,
            PANSEXUAL = 12,
            POLYSEXUAL = 13,
            TRANSGENDER = 14
        }
    }
}
