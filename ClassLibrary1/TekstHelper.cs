using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class TekstHelper
    {
        public int Lengte(string input)
        {
            return input.Length;
        }
        public string Omkeren(string input)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
        public bool IsLeeg(string input)
        {
            return string.IsNullOrEmpty(input);
        }
        public string SamenVoegen(string a, string b)
        {
            return a + b;
        }
        public string Analyze(int number)
        {
            if (number > 0)
                return "Positief";
            else if (number < 0)
                return "Negatief";
            else
                return "Nul";
        }
    }

}
