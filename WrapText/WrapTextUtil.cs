using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrapText
{
    public static class WrapTextUtil
    {
        public static string wrapText(string input, int column)
        {
            if (column >= input.Length)
                return input;

            return input.Insert(column, "\n");
        }
    }
}
