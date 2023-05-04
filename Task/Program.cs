using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write program to print addition of numbers from string and take string from user.
            // - For ex. "WINJIT123" O/P= 1+2+3=6

            Console.WriteLine("Enter String");
            string str = Console.ReadLine();

            int sum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    string s = str[i].ToString();
                    sum += int.Parse(s);
                }
            }
            Console.WriteLine(sum);

            Console.ReadLine();
        }
    }
}
