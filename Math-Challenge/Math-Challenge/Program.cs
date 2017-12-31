using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Challenge
{
    class Program
    {
        private List<int> MakeList(string myString)
        {
            char[] charArray = myString.ToCharArray();
            int[] intArray = Array.ConvertAll(charArray, c => (int)Char.GetNumericValue(c));
            List<int> intList = new List<int>(10);
            intList.AddRange(intArray);
            return intList;
        }
        private int ValidateInput(string myString)
        {
            int value;
            if (int.TryParse(myString, out int num))
            {
                if (num > 0)
                {
                    value = num;
                    return value;
                }
                else
                {
                    value = 0;
                    return value;
                }
            }
            else
            {
                value = 0;
                return value;
            }
        }

        static void Main(string[] args)
        {
            Program n = new Program();
            //declaring variables
            bool repeat1, repeat2;
            string num1, num2;
            int myValue1, myValue2;
            char doAgain = 'Y';

            repeat2 = true;
            while (repeat2)
            {
                //initiating variables
                num1 = "";
                num2 = "";
                repeat1 = true;

                while (repeat1)
                {
                    Console.WriteLine("Please input the first non-negative integer");
                    num1 = (Console.ReadLine());

                    Console.WriteLine("Please input the second non-negative integer");
                    num2 = (Console.ReadLine());

                    myValue1 = (n.ValidateInput(num1));
                    myValue2 = (n.ValidateInput(num2));

                    if ((myValue1 > 0) & (myValue2 > 0))
                    {
                        if (num1.Length == num2.Length)
                        {
                            repeat1 = false;
                        }
                        else
                        {
                            Console.Write("Your integers are not the same length. Please try again.");
                            Console.WriteLine(Environment.NewLine);
                            repeat1 = true;
                        }
                    }
                    else
                    {
                        Console.Write("At least one of your integers is not positive. Please try again.");
                        Console.WriteLine(Environment.NewLine);
                        repeat1 = true;
                    }
                }

                List<int> digits1 = new List<int>(n.MakeList(num1));
                List<int> digits2 = new List<int>(n.MakeList(num2));

                List<int> digits3 = digits1.Zip(digits2, (item1, item2) => item1 + item2).ToList();


                if (digits3.All(i => i == digits3[0]))
                {
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("False");
                }

                Console.WriteLine("Would you like to run this program again? (Y or N)");
                doAgain = (Convert.ToChar(Console.ReadLine()));

                if (doAgain == 'Y' || doAgain == 'y')
                {
                    continue;
                }
                else
                {
                    Environment.Exit(0);
                }
            }           
        }
    }
}
