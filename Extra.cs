using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using Pastel;
using System;
using System.Configuration;
using System.Linq;
using CommandLine;
using CommandLine.Text;

namespace FlagPFP.Main
{
    public partial class MainProgram
    {
        public static void LogError(string error, bool exit = false)
        {
            Console.WriteLine("Error: ".Pastel(Color.DarkRed) +
                              error.Pastel(Color.Red));
            if (exit == true) Environment.Exit(1);
        }

        public static void DisplayHelp<T>(ParserResult<T> result)
        {
            HelpText helpText = null;
            helpText = HelpText.AutoBuild(result, h =>
            {
                h.AdditionalNewLineAfterOption = true;
                h.Heading = "FlagPFP".Pastel(Color.PaleTurquoise) + " v2.0".Pastel(Color.PaleGreen);
                h.Copyright = "Copyleft AestheticalZ 2021".Pastel(Color.Aquamarine);

                return HelpText.DefaultParsingErrorsHandler(result, h);
            }, e => e);
            Console.WriteLine(helpText);
        }

        //Chunky boy
        public static void WriteHeaders(string flag, bool writeCredits = true)
        {
            switch (flag)
            {
                case "gay":
                    Console.WriteLine("-Gay Flag- ".Pastel(Color.LightSteelBlue)
                                      + string.Join("", FlagClass.Instance.gayFlag.Select(s => s.letter.PastelBg(s.color))));
                    break;
                case "agender":
                    Console.WriteLine("-Agender Flag- ".Pastel(Color.LightSteelBlue)
                                      + string.Join("", FlagClass.Instance.agenderFlag.Select(s => s.letter.PastelBg(s.color))));
                    if (writeCredits == true)
                    {
                        Console.WriteLine("Flag Design: ".Pastel(Color.LightBlue) +
                                          "By Salem Fontana - Salem’s initial agender flag design post from tumblr"
                                              .Pastel(Color.Aquamarine) +
                                          " Interview with Salem about the flag’s design,".Pastel(Color.Aquamarine) +
                                          " CC BY-SA 4.0, https://commons.wikimedia.org/w/index.php?curid=38242756"
                                              .Pastel(Color.DarkSeaGreen));
                    }

                    break;
                case "aromantic":
                    Console.WriteLine("-Aromantic Flag- ".Pastel(Color.LightSteelBlue)
                                      + string.Join("", FlagClass.Instance.aromanticFlag.Select(s => s.letter.PastelBg(s.color))));
                    break;
                case "asexual":
                    Console.WriteLine("-Asexual Flag- ".Pastel(Color.LightSteelBlue)
                                      + string.Join("", FlagClass.Instance.asexualFlag.Select(s => s.letter.PastelBg(s.color))));
                    break;
                case "bisexual":
                    Console.WriteLine("-Bisexual Flag- ".Pastel(Color.LightSteelBlue)
                                      + string.Join("", FlagClass.Instance.bisexualFlag.Select(s => s.letter.PastelBg(s.color))));
                    break;
                case "demisexual":
                    Console.WriteLine("-Demisexual Flag- ".Pastel(Color.LightSteelBlue)
                                      + string.Join("", FlagClass.Instance.demisexualFlag.Select(s => s.letter.PastelBg(s.color))));
                    break;
                case "gaymen":
                    Console.WriteLine("-Gay Men Flag- ".Pastel(Color.LightSteelBlue)
                                      + string.Join("", FlagClass.Instance.gaymenFlag.Select(s => s.letter.PastelBg(s.color))));
                    break;
                case "genderfluid":
                    Console.WriteLine("-Genderfluid Flag- ".Pastel(Color.LightSteelBlue)
                                      + string.Join("", FlagClass.Instance.genderfluidFlag.Select(s => s.letter.PastelBg(s.color))));
                    if (writeCredits == true)
                    {
                        Console.WriteLine("Flag Design: ".Pastel(Color.LightBlue) +
                                          "By JJ Pole.McLennonSon - Own work,".Pastel(Color.Aquamarine) +
                                          " CC BY-SA 4.0, https://commons.wikimedia.org/w/index.php?curid=38242265"
                                              .Pastel(Color.DarkSeaGreen));
                    }

                    break;
                case "genderqueer":
                    Console.WriteLine("-Genderqueer Flag- ".Pastel(Color.LightSteelBlue)
                                      + string.Join("", FlagClass.Instance.genderqueerFlag.Select(s => s.letter.PastelBg(s.color))));
                    break;
                case "lesbian":
                    Console.WriteLine("-Lesbian Flag- ".Pastel(Color.LightSteelBlue)
                                      + string.Join("", FlagClass.Instance.lesbianFlag.Select(s => s.letter.PastelBg(s.color))));
                    break;
                case "nonbinary":
                    Console.WriteLine("-Non Binary Flag- ".Pastel(Color.LightSteelBlue)
                                      + string.Join("", FlagClass.Instance.nonbinaryFlag.Select(s => s.letter.PastelBg(s.color))));
                    break;
                case "pansexual":
                    Console.WriteLine("-Pansexual Flag- ".Pastel(Color.LightSteelBlue)
                                      + string.Join("", FlagClass.Instance.pansexualFlag.Select(s => s.letter.PastelBg(s.color))));
                    break;
                case "polysexual":
                    Console.WriteLine("-Polysexual Flag- ".Pastel(Color.LightSteelBlue)
                                      + string.Join("", FlagClass.Instance.polysexualFlag.Select(s => s.letter.PastelBg(s.color))));
                    if (writeCredits == true)
                    {
                        Console.WriteLine("Flag Design: ".Pastel(Color.LightBlue) +
                                          "By McLennonSon - Own work, ".Pastel(Color.Aquamarine) +
                                          "CC BY-SA 4.0, https://commons.wikimedia.org/w/index.php?curid=38241562"
                                              .Pastel(Color.DarkSeaGreen));
                    }

                    break;
                case "transgender":
                    Console.WriteLine("-Transgender Flag- ".Pastel(Color.LightSteelBlue)
                                      + string.Join("", FlagClass.Instance.transgenderFlag.Select(s => s.letter.PastelBg(s.color))));
                    break;
            }
        }
    }
}
