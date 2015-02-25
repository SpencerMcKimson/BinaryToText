using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToText
{
    class Program
    {
        static void Main(string[] args)
        {
            string output = "";
            if (args.Length == 0)
                throw new ArgumentNullException();

            string binary = args[0];
            //check that the input is proper binary
            if (binary.Length % 8 != 0)
                throw new ArgumentException("Input was not valid binary", "binary");

            for (int i = 0; i < binary.Length; i+=8)
            {
                string t = binary.Substring(i, 8);
                output += (char)Convert.ToByte(t, 2);
            }

            Console.WriteLine(output);
        }
    }
}
