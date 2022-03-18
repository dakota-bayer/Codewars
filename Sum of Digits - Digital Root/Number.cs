using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Digits___Digital_Root
{
    public class Number
    {
        //public int DigitalRoot(long n)
        //{
        //    string nString = n.ToString();
        //    char[] charArray = nString.ToCharArray();
        //    int sum = 0;

        //    foreach(char c in charArray)
        //    {
        //        sum += c;
        //    }

        //    return sum;

        //    //This doesn't work, just produces the unicode value
        //}

        public int DigitalRoot(long n)
        {
            string nString = n.ToString();
            int[] numArray = new int[nString.Length];

            //Creating array of 0-9 in each slot
            for (int i = 0; i < nString.Length; i++)
            {
                numArray[i] = int.Parse(nString.Substring(i, 1));
            }

            int sum = 0;

            //Going through each 0-9 element in array and adding it to running total
            foreach (int i in numArray)
            {
                sum += i;
            }

            return sum;
        }
    }
}
