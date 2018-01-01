using System;
using System.Collections.Generic;
using System.Linq;

namespace Math_Challenge
{
    class Program
    {
        //method to create an int list from a string input
        private List<int> MakeList(string myString)
        {
            char[] charArray = myString.ToCharArray();
            int[] intArray = Array.ConvertAll(charArray, c => (int)Char.GetNumericValue(c));
            List<int> intList = new List<int>(10);
            intList.AddRange(intArray);
            return intList;
        }
        //method to validate the string input as a non-negative integer
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

            //loop to allow for running the program again
            repeat2 = true;
            while (repeat2)
            {
                //initiating variables
                num1 = "";
                num2 = "";
                repeat1 = true;

                //loop for validation of the user input
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

                //making the user input into an int list
                List<int> digits1 = new List<int>(n.MakeList(num1));
                List<int> digits2 = new List<int>(n.MakeList(num2));

                //making a new list that contains the sums of the digits
                List<int> digits3 = digits1.Zip(digits2, (item1, item2) => item1 + item2).ToList();

                //making sure the sums of the digits are the same, giving back true or false to user
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

                //allows user to run the program again
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
