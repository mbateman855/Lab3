using System;
using System.IO;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what would you like me to call you?");
            string name = Console.ReadLine();

            Console.WriteLine("Nice to meet you, " + name + ". Thank you for using this program.");

            bool repeat;

            do
            {
                Console.WriteLine("Please enter an integer between 1 and 100: ");
                var input = Console.ReadLine();

                bool check;
                string evenOdd;
                int inputNum;

                Checker();

                EvenOdd();

                void EvenOdd()
                {
                    if (int.Parse(input) % 2 != 0)
                    {
                        evenOdd = "Odd";
                    }
                    else
                    {
                        evenOdd = "Even";
                    }
                }

                void Checker()
                {
                    check = int.TryParse(input, out int a);

                    if (check == false)
                    {
                        Console.WriteLine("Your input was not an integer, " + name + ". Please enter an integer between 1 and 100.");
                        input = Console.ReadLine();
                        Checker();
                    }
                    else
                    {
                        inputNum = int.Parse(input);
                    }

                    if (inputNum < 0)
                    {
                        Console.WriteLine("The integer cannot be a negative number, " + name + ". Please enter an integer between 1 and 100.");
                        input = Console.ReadLine();
                        Checker();
                    }
                    else if (inputNum == 0)
                    {
                        Console.WriteLine("The integer cannot be zero, " + name + ". Please enter an integer between 1 and 100.");
                        input = Console.ReadLine();
                        Checker();
                    }
                    else if (inputNum > 100)
                    {
                        Console.WriteLine("The integer cannot be greater than 100, " + name + ". Please enter an integer between 1 and 100.");
                        input = Console.ReadLine();
                        Checker();
                    }
                }

                if (evenOdd == "Odd")
                {
                    Console.WriteLine(inputNum + " " + evenOdd + ".");
                }
                else if (evenOdd == "Even")
                {
                    if (inputNum >= 2 && inputNum <= 25)
                    {
                        Console.WriteLine(inputNum + " " + evenOdd + " and less than 25.");
                    }
                    else if (inputNum >= 26 && inputNum <= 60)
                    {
                        Console.WriteLine(inputNum + " " + evenOdd + ".");
                    }
                    else if (inputNum > 60)
                    {
                        Console.WriteLine(inputNum + " " + evenOdd + ".");
                    }
                }


                Console.WriteLine("Would you like to continue? (y/n)");
                string cont = Console.ReadLine();
                cont.ToLower();

                Continue();

                void Continue()
                {
                    if (cont == "y" || cont == "yes")
                    {
                        repeat = true;
                    }
                    else if (cont == "n" || cont == "no")
                    {
                        repeat = false;
                    }
                    else
                    {
                        Console.WriteLine("Please indicate whether you would like to continue. Valid answers are y/n or yes/no. \nContinue?");
                        cont = Console.ReadLine();
                        cont.ToLower();
                        Continue();
                    }
                }
                
                //how to check the data type of a user input?
                /*if (input.GetType() == )
                {
                    int intTrue = int.Parse(input);
                }*/
                //Console.ReadLine will only give a string, therefore the GetType will only ever result in a string.
                //keeping annotation for future reference

            } while (repeat == true);

            Console.WriteLine("Goodbye " + name + "!");

        }
    }
}
