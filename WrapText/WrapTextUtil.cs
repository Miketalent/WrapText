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
            if(column < 0)
            {
                throw new InvalidOperationException();
            }

            if (column >= input.Length)
                return input;

            int columnReached = 0;
            int totalCharAppended = 0;
            StringBuilder output = new StringBuilder();

            foreach(var c in input)
            {
                output.Append(c);
                totalCharAppended++;
                if(++columnReached == column && totalCharAppended < input.Length)
                {
                    output.Append('\n');
                    columnReached = 0;
                }
            }

            return output.ToString();
        }
    }
}
