using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotkeyBinder
{
    static class FileSaver
    {
        private static readonly string HEADER = "[/Script/Engine.InputSettings]";
        private static readonly string STRING_FORMAT = "ActionMappings=(ActionName=\"{0}\",bShift={1},bCtrl={2},bAlt={3},bCmd={4},Key={5})";
        private static readonly string MENU_F10 = "ActionMappings=(ActionName=\"Menu\",bShift=False,bCtrl=False,bAlt=False,bCmd=False,Key=F10)";

        public static void SaveFileToDisk(string filepath, List<Item> items)
        {

            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(filepath))
            {
                items.Select(item => FormatString(item))
                .Prepend(HEADER)
                .Append(MENU_F10)
                .ToList()
                .ForEach(sw.WriteLine);
            }
        }

        private static String FormatString(Item item)
        {
            return String.Format(STRING_FORMAT, new object[] 
            { 
                item.getAction(),
                FirstLetterToUpperCaseOrConvertNullToEmptyString(item.getShiftModifier().ToString()),
                FirstLetterToUpperCaseOrConvertNullToEmptyString(item.getCtrlModifier().ToString()),
                FirstLetterToUpperCaseOrConvertNullToEmptyString(item.getAltModifier().ToString()),
                FirstLetterToUpperCaseOrConvertNullToEmptyString(item.getCmdModifier().ToString()),
                item.getKey().ToString()
            }
            );
        }

        /// <summary>
        /// Returns the input string with the first character converted to uppercase, or mutates any nulls passed into string.Empty
        /// </summary>
        private static string FirstLetterToUpperCaseOrConvertNullToEmptyString(this string s)
        {
            if (string.IsNullOrEmpty(s))
                return string.Empty;

            char[] a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }
    }
}
