using System.Collections.Generic;

namespace FlagPFP.Main
{
    public class FlagClass
    {
        private static FlagClass _Instance;
        public static FlagClass Instance
        {
            get
            {
                if (_Instance == null) _Instance = new FlagClass();
                return _Instance;
            }
        }

        public Dictionary<string, string> flagsTable = new Dictionary<string, string>()
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

        public (string color, string letter)[] gayFlag = new (string color, string letter)[]
        {
            ( "#FF0000", " " ),
            ( "#FF8D00", " " ),
            ( "#FFEE00", " " ),
            ( "#00811A", " " ),
            ( "#004BFF", " " ),
            ( "#89008B", " " )
        };

        public (string color, string letter)[] agenderFlag = new (string color, string letter)[]
        {
            ( "#000000", " " ),
            ( "#BBBBBB", " " ),
            ( "#FFFFFF", " " ),
            ( "#9AF57C", " " ),
            ( "#FFFFFF", " " ),
            ( "#BBBBBB", " " ),
            ( "#000000", " " )
        };

        public (string color, string letter)[] aromanticFlag = new (string color, string letter)[]
        {
            ( "#00A735", " " ),
            ( "#92D574", " " ),
            ( "#FFFFFF", " " ),
            ( "#ABABAB", " " ),
            ( "#000000", " " )
        };

        public (string color, string letter)[] asexualFlag = new (string color, string letter)[]
        {
            ( "#000000", " " ),
            ( "#A5A5A5", " " ),
            ( "#FFFFFF", " " ),
            ( "#970083", " " ),
        };

        public (string color, string letter)[] bisexualFlag = new (string color, string letter)[]
        {
            ( "#FA0073", " " ),
            ( "#FA0073", " " ),
            ( "#B14D9A", " " ),
            ( "#0034AD", " " ),
            ( "#0034AD", " " ),
        };

        public (string color, string letter)[] demisexualFlag = new (string color, string letter)[]
        {
            ( "#FFFFFF", " " ),
            ( "#000000", " " ),
            ( "#810073", " " ),
            ( "#D4D4D3", " " )
        };

        public (string color, string letter)[] gaymenFlag = new (string color, string letter)[]
        {
            ( "#00A7D8", " " ),
            ( "#00BBFF", " " ),
            ( "#FFFFFF", " " ),
            ( "#00D58C", " " ),
            ( "#00A536", " " )
        };

        public (string color, string letter)[] genderfluidFlag = new (string color, string letter)[]
        {
            ( "#FF75A2", " " ),
            ( "#FFFFFF", " " ),
            ( "#BE18D6", " " ),
            ( "#000000", " " ),
            ( "#333EBD", " " )
        };

        public (string color, string letter)[] genderqueerFlag = new (string color, string letter)[]
        {
            ( "#B57EDC", " " ),
            ( "#B57EDC", " " ),
            ( "#FFFFFF", " " ),
            ( "#FFFFFF", " " ),
            ( "#4A8123", " " ),
            ( "#4A8123", " " )
        };

        public (string color, string letter)[] lesbianFlag = new (string color, string letter)[]
        {
            ( "#D52D00", " " ),
            ( "#FF9A56", " " ),
            ( "#FFFFFF", " " ),
            ( "#D362A4", " " ),
            ( "#A30262", " " )
        };

        public (string color, string letter)[] nonbinaryFlag = new (string color, string letter)[]
        {
            ( "#FCF434", " " ),
            ( "#FCFCFC", " " ),
            ( "#9C59D1", " " ),
            ( "#2C2C2C", " " )
        };

        public (string color, string letter)[] pansexualFlag = new (string color, string letter)[]
        {
            ( "#FF218C", " " ),
            ( "#FF218C", " " ),
            ( "#FFD800", " " ),
            ( "#FFD800", " " ),
            ( "#21B1FF", " " ),
            ( "#21B1FF", " " )
        };

        public (string color, string letter)[] polysexualFlag = new (string color, string letter)[]
        {
            ("#F61CB9", " "),
            ("#F61CB9", " "),
            ("#07D569", " "),
            ("#07D569", " "),
            ("#1C92F6", " "),
            ("#1C92F6", " ")
        };

        public (string color, string letter)[] transgenderFlag = new (string color, string letter)[]
        {
            ( "#00D0FC", " " ),
            ( "#FFABBA", " " ),
            ( "#FFFFFF", " " ),
            ( "#FFABBA", " " ),
            ( "#00D0FC", " " )
        };
    }
}