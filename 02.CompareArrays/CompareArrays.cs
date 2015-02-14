using System;

//  Problem 2. Compare arrays

//  Write a program that reads two integer arrays from the console and compares them element by element.


class CompareArrays
{
    static void Main()
    {
        bool equal = true;

        Console.Write("Enter the length for the first array: ");
        int n = int.Parse(Console.ReadLine());
        int[] array1 = new int[n];

        Console.Write("Enter the length for the second array: ");
        int m = int.Parse(Console.ReadLine());
        int[] array2 = new int[m];

        if (n == m)
        {

            Console.Write("Enter the elements for the first array: ");
            Console.WriteLine();
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }


            Console.Write("Enter the elements for the second array: ");
            Console.WriteLine();
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                if (array1[i] != array2[i])
                {
                    equal = false;
                }
            }

            if (equal == true)
            {
                Console.WriteLine("The elements in arrays are equal!");
            }
            else
            {
                Console.WriteLine("The elements in the arrays are NOT equal.");
            }

        }
        else
        {
            Console.WriteLine("Two arrays are equal when their lenghts and elements are equal!");
        }
    }
}