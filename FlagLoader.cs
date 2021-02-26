using Newtonsoft.Json;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FlagPFP.Loading
{
    public class FlagLoader
    {
        public Dictionary<string, PrideFlag> LoadFlags(string folder)
        {
            List<string> files = Directory.GetFiles(folder).ToList();
            Dictionary<string, PrideFlag> finalList = new Dictionary<string, PrideFlag>();

            foreach (string file in files)
            {
                string jsonContent = File.ReadAllText(file);
                PrideFlag flag = JsonConvert.DeserializeObject<PrideFlag>(jsonContent);
                
                if(!string.IsNullOrWhiteSpace(flag.FlagFile)) finalList.Add(flag.ParameterName, flag);
            }
            return finalList;
        }
    }
}