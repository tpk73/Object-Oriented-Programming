using System;

class Program
{
    static double FindMean(double[] arr, int x){

        // start mean at 0
        double mean = 0;

        // add each element into mean
        for (int i = 0; i < x; i++){
            mean += arr[i];
        }

        // divide the mean by elements to get the mean
        mean /= x;

        // always return
        return mean;

    }
    static double StandardDeviation(double[] arr, int x){

        // make values for mean and the sDev
        double mean = FindMean(arr, x);
        double sDev = 0;

        // using the math.pow do the math and set it to sDev
        for (int i = 0; i < x; i++){

            sDev = sDev + Math.Pow((arr[i] - mean), 2);
        }

        sDev = Math.Sqrt(sDev / x);

        return sDev; // always return
    }

    static void Main(string[] args)
    {
        
        // ask user for how many numbers of input
        Console.Write("How many numbers? ");
        int number = Convert.ToInt32(Console.ReadLine()); // convert data type to int
        Console.WriteLine("Enter {0} numbers:", number);

        // set up array
        double[] arr = new double[number];
        for (int i = 0; i < number; i++){

            arr[i] = Convert.ToDouble(Console.ReadLine());

        }

        Console.WriteLine(""); // formatting

        // call on function sDev to get the final double sending the two types of data
        double final = StandardDeviation(arr, number);

        Console.WriteLine("Standard Deviation: {0:F3}", final); // format to the third decimal
    }
}

