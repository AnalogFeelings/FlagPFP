using CommandLine;
using CommandLine.Text;
using Pastel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;

namespace FlagPFP.Main
{
    public partial class MainProgram
    {
        //This program complies with the NO_COLOR standard as it uses the Pastel library.
        static void Main(string[] args)
        {
            Parser parser = new Parser(config => config.HelpWriter = null);
            ParserResult<Options> parseResult = parser.ParseArguments<Options>(args);

            parseResult.WithNotParsed(err => DisplayHelp(parseResult));

            parseResult.WithParsed(o =>
            {
                string flagPath;
                if (!FlagClass.Instance.flagsTable.TryGetValue(o.FlagType, out flagPath))
                {
                    LogError($"{o.FlagType} isn't a valid flag type!\n");
                    Console.WriteLine("---Flag Types---".Pastel(Color.CornflowerBlue));
                    foreach (KeyValuePair<string, string> pair in FlagClass.Instance.flagsTable)
                    {
                        WriteHeaders(pair.Key, false);
                    }

                    Environment.Exit(1);
                }

                WriteHeaders(o.FlagType);
                Console.WriteLine("\nMaking image...".Pastel(Color.LightGreen));

                ImageProcessing processing = new ImageProcessing();

                Bitmap imageFile = null;
                Bitmap flag = null;
                
                try
                {
                    imageFile = processing.LoadAndResizeBmp(o.ImageFile, o.Size, o.Size);
                    flag = processing.LoadAndResizeBmp(flagPath, o.Size, o.Size);
                }
                catch (Exception ex)
                {
                    LogError(ex.StackTrace, true);
                }

                Bitmap croppedBmp = processing.CropPicture(ref imageFile, o.Size, false);
                Bitmap flagBmp = processing.CropFlag(ref flag, o.PixelMargin);
                Bitmap finalBmp = processing.StitchTogether(ref flagBmp, ref croppedBmp, o.InnerSize);

                try { finalBmp.Save(o.Output, ImageFormat.Png); }
                catch (Exception ex)
                {
                    LogError(ex.StackTrace, true);
                }
                Console.WriteLine($"Success! Saved image \"{o.Output}\"".Pastel(Color.SpringGreen));
                Console.WriteLine($"FlagPFP, by Aesthetical#9203, 2021.".Pastel(Color.PaleTurquoise));
                Environment.Exit(0);
            });
        }

        public class Options
        {
            [Option("image", Required = true, HelpText = "Image file to use.")]
            public string ImageFile { get; set; }

            [Option("flag", Required = true, HelpText = "The flag type.")]
            public string FlagType { get; set; }

            [Option("margin", Required = true, HelpText = "Pixel margin between border and inner window.")]
            public int PixelMargin { get; set; }

            [Option("insize", Required = true, HelpText = "Size of the inner image, for example, set it to more than the full image size to crop it.")]
            public int InnerSize { get; set; }

            [Option("fsize", Required = false, HelpText = "Full image size.", Default = (int)800)]
            public int Size { get; set; }

            [Option("output", Required = true, HelpText = "Output image file.")]
            public string Output { get; set; }
        }
    }
}
