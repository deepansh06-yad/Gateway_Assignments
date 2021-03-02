using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodAssignment
{
    public static class Entensionhelper
    {
        public static string CreateUpperCase(string inputstring)
        {
            if (inputstring.Length > 0)
            {
                char[] chararray = inputstring.ToCharArray();
                chararray[0] = char.IsUpper(chararray[0]) ? char.ToUpper(chararray[0]) : char.ToUpper(chararray[0]);
                return new string(chararray);
            }
            return inputstring;
        }
        public static string CreateLowerCase(string inputstring)
        {
            if (inputstring.Length > 0)
            {
                char[] chararray = inputstring.ToCharArray();
                chararray[0] = char.IsLower(chararray[0]) ? char.ToLower(chararray[0]) : char.ToLower(chararray[0]);
                return new string(chararray);
            }
            return inputstring;
        }
        public static string Converttoint(string inputstring)
        {
            int chararray;
            if (inputstring.Length>0)
            {
                //char[] chararray = inputstring.ToCharArray();
                chararray = (int)Int64.Parse(inputstring);

            }
            return chararray;
        }
    }
}
