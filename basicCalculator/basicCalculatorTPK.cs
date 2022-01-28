using System;

namespace basicCalculator
{
    class basicCalculatorTPK
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Calculator Program");
            // get first #
            Console.Write("Enter the first integer: ");
            int i1 = Convert.ToInt32(Console.ReadLine());
            // get second #
            Console.Write("Enter the second integer: ");
            int i2 = Convert.ToInt32(Console.ReadLine());
            // get operation sign
            Console.Write("Enter the operator: ");
            string sign = Console.ReadLine();

            // use switch for each operator
            switch (sign){
                // handle * operator
                case "*":
                    Console.WriteLine("The result is: " + (i1*i2));
                    break;
                // handle / operator
                case "/":
                    // use if to see if zero was inputed for i2
                    if(i2 == 0){
                        Console.WriteLine("Error: cannot divide by zero.");
                    }
                    // if not continue
                    else{
                        Console.WriteLine("The result is: " + (i1/i2));
                    }
                    break;
                // handle - operator
                case "-":
                    Console.WriteLine("The result is: " + (i1-i2));
                    break;
                // handle + operator
                case "+":
                    Console.WriteLine("The result is: " + (i1+i2));
                    break;
                // if user inputs something that does not belong
                default:
                    Console.WriteLine("Invalid operation.");
                    break;
            }
        }
    }
}
