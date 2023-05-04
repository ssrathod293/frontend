using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string str = "example";
            StringBuilder sb = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }
            string reversedStr = sb.ToString();
            Console.WriteLine(reversedStr);
            Console.ReadLine();
            string str = "example";
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            string reversedStr = new string(charArray);
            Console.WriteLine(reversedStr);
            Console.ReadLine();
            */
            /*
            string words = "shrikant";
            for (int i = words.Length - 1; i >= 0; i--)
            {
                Console.Write(words[i] + " ");
            }*/

            /*
            string input = "Subash,rahul,ravi,mukesh,nandkumar,kishan";
            string[] words = input.Split(',');
            Array.Sort(words);//it will sort in ascending
            foreach (var item in words)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
            Array.Reverse(words);//it will sort in descending order
            foreach (var item in words)
            {
                Console.Write(item + " ");
            }*/

            ///////////////////////////////check if string is palindrome or not
            /*
            string Reverse ="";
            //string Reverse = string.Empty;
            Console.WriteLine("Enter string want to palidrome");
            string str = Console.ReadLine().ToLower();
            Console.WriteLine(str);
            for (int i = str.Length - 1; i >= 0; i--) 
            {
                Reverse += str[i].ToString();
            }
            Console.WriteLine(Reverse);
            if(str==Reverse)
            {
                Console.WriteLine("ENTERED STRING IS PALINDROME");
            }
            else
            {
                Console.WriteLine("entered string is not palindrome");
            }
          */
            ///////////code to check if string are equal or not
            /*
            string str1 = "shrikant";
            string str2 = "shrikant";
            if (str1==str2)
            {
                Console.WriteLine("EQUAL");
            }
            else
            {
                Console.WriteLine("NOT EQUAL");
            }
            */
            ////////////object comarison//////////
            // bool b = Equals(str, Reverse);
            //Console.WriteLine(b);
            //coaprison of string using
            //1.String.compare(strig1,string2)
            //2.Compareto Method==string1.CompareTo(string2)
            //if (str == Reverse)  //string is reference type variable so we cant compare using equal operator
            //if(Equals(str,Reverse))
            //if(String.Compare(str,Reverse)==0)==return 0 if both string are equal

            // if((String.Compare(str,Reverse)==0))
            // if((str.CompareTo(Reverse)==0))
            //if((str.Equals(Reverse)))
            student std1 = new student("shrikant","rathod");
            student std2 = new student("shrikant","rathod");
            
            Console.ReadLine();


        }
        public class student
        {
             string firstname;
            string lastname;
            public student(string fn,string ln)
            {
                firstname = fn;
                lastname = ln;
            }
            public void GetDetail()
            {
                Console.WriteLine($"FirstName:{firstname} LastName:{lastname}");
            }
        }
       
    }
}
