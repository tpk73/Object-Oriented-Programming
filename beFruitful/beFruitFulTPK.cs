using System;

class beFruitFulTPK
{
    static void Main(string[] args)
    {
        double[ , ] mFinal, a1, a2;
        string input;
        string[] data;
        
        // getting the user input and converting to use later
        Console.Write("How many rows does the first matrix have ? ");
        int r1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("How many columns does the first matrix have? ");
        int c1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("How many rows does the second matrix have? ");
        int r2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("How many columns does the second matrix have? ");
        int c2 = Convert.ToInt32(Console.ReadLine());

        // check condition to stop the program and go no further
        if (r1 != c2 && r2 != c1){
            Console.WriteLine("These two matrices cannot be multiplied.");
        }
            
        else{
            
            // new arrays for input of first and second martix
            a1 = new double[r1, c1];
            a2 = new double[r2, c2];

            // start of first matrix
            for (int i = 0; i < r1; i++){

                // collecting data for a1
                Console.Write("Enter a row of the first matrix, seperated by space: ");

                input = Console.ReadLine();
                data = input.Split(" "); // split by space to store

                for (int j = 0; j < data.Length; j++){

                    a1[i, j] = Convert.ToDouble(data[j]); // write data into a1
                }
            }


            // begin of a2
            for (int i = 0; i < r2; i++){

                // collecting data for a2
                Console.Write("Enter a row of the second matrix, seperated by space: ");

                input = Console.ReadLine();
                data = input.Split(" "); // split by space

                for (int j = 0; j < data.Length; j++){

                    a2[i, j] = Convert.ToDouble(data[j]); // write data into a2
                }
            }

            // need a final array to mix a1 and a2
            mFinal = new double[r1, c2];

            
            for(int i = 0; i < r1; i++){ // controls row location of a1
                for(int j = 0; j < c2; j++){ // controls col location of a2
                    mFinal[i, j] = 0; // set default so math does not mess up
                    for(int k = 0; k < c1; k++) // use as your walker throughout the matrix
                    {
                        mFinal[i, j] += a1[i, k] * a2[k, j]; // math for a1 * a2
                    }
                }
            }

            // output
            Console.WriteLine("The resulting matrix is:");

            for(int i = 0; i < r1; i++){ // walker for row

                for(int j = 0; j < c2; j++) // walker for col
                {
                    Console.Write("{0,8:F2}", mFinal[i, j]); // formatting for your output
                }
                Console.WriteLine();
            }

        }
    }
}
