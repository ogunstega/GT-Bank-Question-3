using System;

namespace GT_Bank_Question_3
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine(test("abcd"));
                
                Console.ReadLine();
            }


        }
        public static string test(string str)
        {
            return str.Length > 1
                ? str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1) : str;
        }
    }    
}
