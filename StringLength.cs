using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
     class StringLength
    {
        public static void Main()
        {


            string str;
            int l = 0;
            Console.Write("Input the string : ");
            str = Console.ReadLine();
            foreach (char chr in str)
            {
                l += 1;
            }
            Console.Write("Length of the string is : {0}", l);
        }   

    }
}
