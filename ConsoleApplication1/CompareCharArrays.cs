using System;

//  Problem 3. Compare char arrays

//  Write a program that compares two char arrays lexicographically (letter by letter).

class CompareCharArrays
    {
        static void Main()
        {
            int sumA = 0;
            int sumB = 0;

            Console.Write("Enter the first char array: ");
            string array1 = Console.ReadLine();
            
            Console.Write("Enter the second char array: ");
            string array2 = Console.ReadLine();
            
            foreach (int a in array1)
                {
                sumA += a;
                }
          
            foreach (int b in array2)
                {
                sumB += b;
                }

            if (sumA > sumB)
            {
                Console.WriteLine("{0} > {1}", array1, array2);
            }
            else if (sumA < sumB)
            {
                Console.WriteLine("{0} < {1}", array1, array2);
            }
            else
            {
                Console.WriteLine("{0} = {1}", array1, array2);
            }
        }
    }
