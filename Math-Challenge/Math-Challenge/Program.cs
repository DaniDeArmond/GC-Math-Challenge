using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Challenge
{
    class Program
    {
        public List<int> MakeArray(string myString)
        {
            char[] charArray = myString.ToCharArray();
            int[] intArray = Array.ConvertAll(charArray, c => (int)Char.GetNumericValue(c));
            List<int> intList = new List<int>(10);
            intList.AddRange(intArray);
            return intList;
        }

        static void Main(string[] args)
        {
            Program n = new Program();
            Console.WriteLine("Please input the first non-negative integer");
            string num1 = (Console.ReadLine());
            List<int> digits1 = new List<int>(n.MakeArray(num1));

            Console.WriteLine("Please input the second non-negative integer");
            string num2 = (Console.ReadLine());
            List<int> digits2 = new List<int>(n.MakeArray(num2));

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("The digits in num1 are: ");
            foreach (int i in digits1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("The digits in num2 are: ");
            foreach (int i in digits2)
            {
                Console.Write(i + " ");
            }
            Console.Read();
        }
    }
}
