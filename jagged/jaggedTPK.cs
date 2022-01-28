using System;

class jaggedTPK
{
    static void Main(string[] args){

        // get the rows from user
        Console.Write("How many rows are in the jagged array? ");
        int rows = Convert.ToInt32(Console.ReadLine());

        // create new array for jagged
        int[][] jag = new int[rows][];

        for (int i = 0; i < rows; i++){

            // get user input for data
            Console.Write("Enter a row, separated by spaces: ");
            string temp = Console.ReadLine();
            string[] row = temp.Split(" "); // split the array by " "

            int[] final = Array.ConvertAll(row, int.Parse);

            // create new array for output
            jag[i] = new int[final.Length];

            for (int j = 0; j < final.Length; j++){
                // get input from above and store in jag
                jag[i][j] = final[j];
            }
        }

        // output for jag
        Console.WriteLine("After the funky operation, the resulting array is: ");
        for (int i = 0; i < rows; i++){

            for (int j = 0; j < jag[i].Length; j++){

                Console.Write("{0, 5}", jag[i][j] * (i + j + 1));
            }
            Console.WriteLine("");
        }
    }
}
