using System;
using System.Collections.Generic;
using System.Linq;

namespace HotkeyBinder
{
    static class FileReader
    {

        private static readonly string regexString = "ActionMappings.*\"(.*)\",bShift=(.*),bCtrl=(.*),bAlt=(.*),bCmd=(.*),Key=(.*)\\)";

        public static List<Item> ReadFromFile(String filepath)
        {
            List<Item> items = new List<Item>();
            var lines = System.IO.File.ReadLines(filepath);
            lines.ToList().ForEach(line => items.Add(ProcessLine(line)));
            items.RemoveAll(item => item is null);

            return items;
        }

        private static Item ProcessLine(string line)
        {
            var match = System.Text.RegularExpressions.Regex.Match(line, regexString);

            if (Enum.TryParse<Keys>(match.Groups[6].Value, true, out Keys key))
            {
                return new Item(match.Groups[1].Value, key, Boolean.Parse(match.Groups[2].Value), Boolean.Parse(match.Groups[3].Value), Boolean.Parse(match.Groups[4].Value), Boolean.Parse(match.Groups[5].Value));
            }

            return null;
        }
    }
}
