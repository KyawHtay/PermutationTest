using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PermutationTest
{
    public class Permutation
    {
        public bool _isFound;


        public Permutation(bool isFound)
        {
            _isFound = isFound;

        }
        /**
        * permutation function
        * @param str string to
        calculate permutation for
        * @param l starting index
        * @param r end index
        */

        public bool permute(String str,
                                    int l, int r,
                                    string checkstring)
        {
            if (l == r)
            {
                Console.WriteLine(str);
                if (str.ToLower() == checkstring.ToLower())
                {
                    _isFound = true;

                }

            }
            else
            {
                for (int i = l; i <= r; i++)
                {
                    str = swap(str, l, i);
                    permute(str, l + 1, r, checkstring);
                    str = swap(str, l, i);
                }
            }
            return _isFound;
        }

        /**
        * Swap Characters at position
        * @param a string value
        * @param i position 1
        * @param j position 2
        * @return swapped string
        */
        private String swap(String a,
                                int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }
    }
}

