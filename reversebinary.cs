using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kattis
{
    class reversebinary
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            char[] binary = Convert.ToString(number, 2).ToCharArray();
            Array.Reverse(binary);
            string reversedBinary = new string(binary);
            int reversedNumber = Convert.ToInt32(reversedBinary, 2);

            Console.WriteLine(reversedNumber);
            Console.ReadLine();
        }
    }
}
