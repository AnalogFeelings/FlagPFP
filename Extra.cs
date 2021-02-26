using CommandLine;
using CommandLine.Text;
using FlagPFP.Loading;
using Pastel;
using System;
using System.Drawing;
using System.Linq;

namespace FlagPFP.Main
{
    public partial class MainProgram
    {
        public static void LogError(string error, bool exit = false)
        {
            Console.WriteLine("Error: ".Pastel(Color.IndianRed) +
                              error.Pastel(Color.Red));
            if (exit) Environment.Exit(1);
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

        public static void WriteHeaders(PrideFlag flag, bool writeCredits = true, bool helpMode = false)
        {
            if (helpMode)
            {
                Console.Write($"-{flag.ConsoleHeader}- ".Pastel(Color.LightSteelBlue)
                                  + string.Join("", flag.FlagPattern.Select(s => " ".PastelBg(s))));
                Console.WriteLine($" {flag.ParameterName}\n".Pastel(Color.DarkCyan));
            }
            else
            {
                Console.WriteLine($"-{flag.ConsoleHeader}- ".Pastel(Color.LightSteelBlue)
                                  + string.Join("", flag.FlagPattern.Select(s => " ".PastelBg(s))));
                Console.WriteLine();
            }

            if (!string.IsNullOrEmpty(flag.DesignCredits) && writeCredits == true)
            {
                Console.WriteLine(flag.DesignCredits.Pastel(Color.PowderBlue));
            }
        }
    }
}
