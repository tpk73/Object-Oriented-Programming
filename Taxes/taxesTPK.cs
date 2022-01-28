using System;

namespace taxesTPK
{
    class Program
    {
        static void Main(string[] args)
        {
            // user name
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            // user ssn
            Console.Write("Social Security number: ");
            string ssn = Console.ReadLine();
            // user hr rate
            Console.Write("Hourly pay rate: ");
            string pay = Console.ReadLine();
            // user hrs worked
            Console.Write("Hours worked: ");
            string hrs = Console.ReadLine();
            
            Console.WriteLine();
            // prompt set up for user 
            Console.WriteLine("Payroll Summary for: " + name);
            Console.WriteLine("SSN: " + ssn);
            Console.WriteLine("You earned " + hrs + " hours at " + pay + " per hour");
            
            Console.WriteLine();
            // convert strings to doubles to do math with
            double grossPay = Convert.ToDouble(pay) * Convert.ToDouble(hrs);
            double fedWH = grossPay * .15;
            double stateWH = grossPay * .05;
            double netPay = grossPay - fedWH - stateWH;

            // use the {,} to format correctly
            Console.WriteLine("Gross pay:{0, 21}", grossPay.ToString("F2")); 
            Console.WriteLine("Federal withholding:{0, 11}", fedWH.ToString("F2"));
            Console.WriteLine("State withholding:{0, 13}", stateWH.ToString("F2"));
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Net pay:{0, 23}", netPay.ToString("F2"));
                    
        }
    }
}
