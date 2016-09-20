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
            int wrapCount = 1;
            for(int i=0; i<input.Length; i++)
            {
                if(++columnReached == column)
                {
                    input.Insert(wrapCount++ * columnReached, "\n");
                    //reset columnReached to 0 to start counting again
                    columnReached = 0;
                }
            }

            return input;
        }
    }
}
