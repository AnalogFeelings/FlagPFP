using System;
using Pastel;
using System.Drawing;
using System.Drawing.Imaging;

namespace FlagPFP.Main
{
    public partial class MainProgram
    {
        //This program complies with the NO_COLOR standard as it uses the Pastel library.
        static void Main(string[] args)
        {
            if(args.Length < 4)
            {
                Console.WriteLine("Error: ".Pastel(Color.DarkRed) +
                    "Please follow the syntax: ".Pastel(Color.Red)
                    + "flagpfp <image> <flag> <pixel margin> <output name>".Pastel(Color.CadetBlue));
                Environment.Exit(1);
            }

            Bitmap imageFile = null;
            Bitmap flag = null;
            string flagPath;
            int pixelMargin = 0;

            try
            {
                imageFile = new Bitmap(Image.FromFile(args[0]));
                flagsTable.TryGetValue(args[1], out flagPath);
                flag = new Bitmap(Image.FromFile(flagPath));
                int.TryParse(args[2], out pixelMargin);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: ".Pastel(Color.DarkRed) + ex.Message.Pastel(Color.Red));
                Environment.Exit(1);
            }
            WriteHeaders(args[1]);
            Console.WriteLine("\nMaking image...".Pastel(Color.LightGreen));

            Bitmap croppedBmp = CropPicture(ref imageFile, 800);
            Bitmap flagBmp = CropFlag(ref flag, pixelMargin);
            Bitmap finalBmp = StitchTogether(ref flagBmp, ref croppedBmp);

            try { finalBmp.Save(args[3], ImageFormat.Png); }
            catch(Exception ex)
            {
                Console.WriteLine("Error: ".Pastel(Color.DarkRed) +
                    ex.StackTrace.Pastel(Color.Red));
                Environment.Exit(1);
            }
            Console.WriteLine($"Success! Saved image \"{args[3]}\"".Pastel(Color.SpringGreen));
            Console.WriteLine($"FlagPFP, by Aesthetical#9203, 2021.".Pastel(Color.PaleTurquoise));
            Environment.Exit(0);
        }
    }
}
