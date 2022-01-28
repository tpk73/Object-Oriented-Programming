using System;

namespace receiptMachine
{
    class receiptMachineTPK
    {
        static void Main(string[] args)
        {
            // user name
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            // user address
            Console.Write("Street address: ");
            string address = Console.ReadLine();
            // user city
            Console.Write("City: ");
            string city = Console.ReadLine();
            // user state
            Console.Write("State: ");
            string state = Console.ReadLine();
            // user zip
            Console.Write("Zip code: ");
            string zip = Console.ReadLine();
            // # of orders
            Console.Write("How many magic blenders do you want to order? ");
            int qty = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine();
            // set up for print receipt
            Console.WriteLine("Receipt for:");
            Console.WriteLine(name);
            Console.WriteLine(address);
            Console.WriteLine(city + ", " + state + " " + zip);

            Console.WriteLine();
            // prompt for user 
            Console.WriteLine(qty.ToString() + " blenders ordered @39.95 each");
            
            Console.WriteLine();

            double total = (qty * 39.95);
            // use the {} for formatting constraints
            Console.WriteLine("Total:{0, 10}", total.ToString("0.#####"));
            double tax = (total * .07);
            Console.WriteLine("Tax: {0, 11}", tax.ToString("0.######"));

            Console.WriteLine("----------------------------");
            double final = (total + tax);
            Console.WriteLine("Due: {0, 11}", final.ToString("0.######"));

        }
    }
}
