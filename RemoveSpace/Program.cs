using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveSpace
{
    class Program
    {
        public static void RemoveSpace(string str)
        {
            char[] delim = { ' ' };
            string[] strArr = str.Split(delim);
            foreach (var space in strArr)
            {
                Console.Write(space);
            }


            //return str;
    }
    static void Main(string[] args)
        {
            string str = "I Love Icescream";
            RemoveSpace(str);
          
        }
    }
}
