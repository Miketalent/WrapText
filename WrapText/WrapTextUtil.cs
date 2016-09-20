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

            int columnReached = 0;
            int startIndex = 0;
            string output = "";
            for(int i=0; i<input.Length; i++)
            {
                if(++columnReached == column)
                {
                    output += input.Substring(startIndex, column) + "\n";
                    //reset columnReached to 0 to start counting again
                    columnReached = 0;

                    startIndex = i + 1;

                    //check if the remaining substring needs a line break
                    if(input.Substring(startIndex).Length <= column)
                    {
                        output += input.Substring(startIndex);
                        break;
                    }
                }


            }

            return output;
        }
    }
}
