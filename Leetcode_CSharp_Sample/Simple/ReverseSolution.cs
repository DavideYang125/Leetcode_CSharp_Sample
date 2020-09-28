using System;
using System.Linq;
using System.Text;

namespace Leetcode_CSharp_Sample
{
    public class ReverseSolution
    {
        public int Reverse(int x)
        {
            var pos = true;
            if (x < 0)
            {
                pos = false;
                x = -x;
            }

            var xStr = x.ToString();
            var xArrays = xStr.ToArray();
            StringBuilder strBuilder = new StringBuilder();
            for (int i = xArrays.Length - 1; i >= 0; i--)
            {
                strBuilder.Append(xArrays[i]);
            }

            var str = strBuilder.ToString();
            var result = 0;
            Int32.TryParse(str, out result);

            if (!pos) result = -result;
            return result;
        }
    }
}